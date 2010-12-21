// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g 2010-12-19 21:39:34

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

public class TikzGrammarLexer extends Lexer {
    public static final int FUNCTION=20;
    public static final int LINETO=47;
    public static final int CONTROLS=25;
    public static final int OPTION=66;
    public static final int COORDINATE=23;
    public static final int POINT=43;
    public static final int EDGE=24;
    public static final int CYCLE=15;
    public static final int DOTS=28;
    public static final int PATH_CONSTRUCTION=52;
    public static final int AND=8;
    public static final int LISTS=61;
    public static final int EOF=-1;
    public static final int BEND=37;
    public static final int COMMAND=64;
    public static final int VARNAME=51;
    public static final int AT=19;
    public static final int ARC=35;
    public static final int PARENT=27;
    public static final int NAME=57;
    public static final int IN=14;
    public static final int COMMANDS=65;
    public static final int SIN=45;
    public static final int COS=46;
    public static final int LIST_ELEM=59;
    public static final int BEGIN=5;
    public static final int ELLIPSE=34;
    public static final int RECTANGLE=29;
    public static final int BODY=56;
    public static final int COORD_SYS=42;
    public static final int COMMENT=40;
    public static final int AGAINPATH=39;
    public static final int CHILD=32;
    public static final int PARABOLA=36;
    public static final int T__80=80;
    public static final int CONTROL_CHARS=72;
    public static final int T__81=81;
    public static final int T__82=82;
    public static final int NODE=18;
    public static final int LINETOVH=49;
    public static final int TO=13;
    public static final int LINETOHV=48;
    public static final int GRID=30;
    public static final int OPERATOR=9;
    public static final int CURVE=44;
    public static final int HVLINE=11;
    public static final int EDGE_FROM_PARENT=54;
    public static final int VALUE=58;
    public static final int FILE=21;
    public static final int LIST=60;
    public static final int LINE=38;
    public static final int PLOT=31;
    public static final int WS=73;
    public static final int GNUPLOT=53;
    public static final int COORDINATES=22;
    public static final int CS=17;
    public static final int CIRCLE=33;
    public static final int FUNC=7;
    public static final int MOVETO=50;
    public static final int BLOCK=62;
    public static final int KEYWORDS=71;
    public static final int FOREACH=16;
    public static final int VHLINE=12;
    public static final int FROM=26;
    public static final int T__76=76;
    public static final int END=6;
    public static final int OPERATION=41;
    public static final int PD=69;
    public static final int T__75=75;
    public static final int BLOCKS=63;
    public static final int PE=70;
    public static final int T__74=74;
    public static final int MACRO=55;
    public static final int T__79=79;
    public static final int OPTIONS=67;
    public static final int T__78=78;
    public static final int STRING=10;
    public static final int T__77=77;
    public static final int BACKSLASH=4;
    public static final int PC=68;

    // delegates
    // delegators

    public TikzGrammarLexer() {;} 
    public TikzGrammarLexer(CharStream input) {
        this(input, new RecognizerSharedState());
    }
    public TikzGrammarLexer(CharStream input, RecognizerSharedState state) {
        super(input,state);

    }
    public String getGrammarFileName() { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g"; }

    // $ANTLR start "T__74"
    public final void mT__74() throws RecognitionException {
        try {
            int _type = T__74;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:3:7: ( '{' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:3:9: '{'
            {
            match('{'); 

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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:4:7: ( '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:4:9: '}'
            {
            match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public final void mT__76() throws RecognitionException {
        try {
            int _type = T__76;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:5:7: ( ';' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:5:9: ';'
            {
            match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public final void mT__77() throws RecognitionException {
        try {
            int _type = T__77;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:6:7: ( '(' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:6:9: '('
            {
            match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public final void mT__78() throws RecognitionException {
        try {
            int _type = T__78;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:7:7: ( ')' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:7:9: ')'
            {
            match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__78"

    // $ANTLR start "T__79"
    public final void mT__79() throws RecognitionException {
        try {
            int _type = T__79;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:8:7: ( '[' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:8:9: '['
            {
            match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__79"

    // $ANTLR start "T__80"
    public final void mT__80() throws RecognitionException {
        try {
            int _type = T__80;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:9:7: ( ']' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:9:9: ']'
            {
            match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__80"

    // $ANTLR start "T__81"
    public final void mT__81() throws RecognitionException {
        try {
            int _type = T__81;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:10:7: ( ',' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:10:9: ','
            {
            match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__81"

    // $ANTLR start "T__82"
    public final void mT__82() throws RecognitionException {
        try {
            int _type = T__82;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:11:7: ( ':' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:11:9: ':'
            {
            match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__82"

    // $ANTLR start "COMMENT"
    public final void mCOMMENT() throws RecognitionException {
        try {
            int _type = COMMENT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:216:9: ( '%' (~ '\\n' )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:216:17: '%' (~ '\\n' )*
            {
            match('%'); 
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:216:21: (~ '\\n' )*
            loop1:
            do {
                int alt1=2;
                int LA1_0 = input.LA(1);

                if ( ((LA1_0>='\u0000' && LA1_0<='\t')||(LA1_0>='\u000B' && LA1_0<='\uFFFF')) ) {
                    alt1=1;
                }


                switch (alt1) {
            	case 1 :
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:216:22: ~ '\\n'
            	    {
            	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\uFFFF') ) {
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

            _channel=HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "BACKSLASH"
    public final void mBACKSLASH() throws RecognitionException {
        try {
            int _type = BACKSLASH;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:220:9: ( '\\\\' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:220:17: '\\\\'
            {
            match('\\'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "BACKSLASH"

    // $ANTLR start "FUNCTION"
    public final void mFUNCTION() throws RecognitionException {
        try {
            int _type = FUNCTION;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:227:9: ( 'function' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:227:17: 'function'
            {
            match("function"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "FUNCTION"

    // $ANTLR start "FILE"
    public final void mFILE() throws RecognitionException {
        try {
            int _type = FILE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:230:9: ( 'file' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:230:17: 'file'
            {
            match("file"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "FILE"

    // $ANTLR start "COORDINATES"
    public final void mCOORDINATES() throws RecognitionException {
        try {
            int _type = COORDINATES;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:234:9: ( 'coordinates' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:234:17: 'coordinates'
            {
            match("coordinates"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "COORDINATES"

    // $ANTLR start "PLOT"
    public final void mPLOT() throws RecognitionException {
        try {
            int _type = PLOT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:237:9: ( 'plot' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:237:17: 'plot'
            {
            match("plot"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "PLOT"

    // $ANTLR start "RECTANGLE"
    public final void mRECTANGLE() throws RecognitionException {
        try {
            int _type = RECTANGLE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:241:9: ( 'rectangle' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:241:18: 'rectangle'
            {
            match("rectangle"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "RECTANGLE"

    // $ANTLR start "GRID"
    public final void mGRID() throws RecognitionException {
        try {
            int _type = GRID;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:244:9: ( 'gird' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:244:18: 'gird'
            {
            match("gird"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "GRID"

    // $ANTLR start "LINE"
    public final void mLINE() throws RecognitionException {
        try {
            int _type = LINE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:247:9: ( '--' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:247:17: '--'
            {
            match("--"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "LINE"

    // $ANTLR start "FROM"
    public final void mFROM() throws RecognitionException {
        try {
            int _type = FROM;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:250:9: ( 'from' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:250:17: 'from'
            {
            match("from"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "FROM"

    // $ANTLR start "PARENT"
    public final void mPARENT() throws RecognitionException {
        try {
            int _type = PARENT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:253:9: ( 'parent' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:253:17: 'parent'
            {
            match("parent"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "PARENT"

    // $ANTLR start "HVLINE"
    public final void mHVLINE() throws RecognitionException {
        try {
            int _type = HVLINE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:256:9: ( '-|' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:256:17: '-|'
            {
            match("-|"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "HVLINE"

    // $ANTLR start "VHLINE"
    public final void mVHLINE() throws RecognitionException {
        try {
            int _type = VHLINE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:260:9: ( '|-' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:260:17: '|-'
            {
            match("|-"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "VHLINE"

    // $ANTLR start "DOTS"
    public final void mDOTS() throws RecognitionException {
        try {
            int _type = DOTS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:264:9: ( '..' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:264:17: '..'
            {
            match(".."); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "DOTS"

    // $ANTLR start "TO"
    public final void mTO() throws RecognitionException {
        try {
            int _type = TO;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:268:9: ( 'to' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:268:17: 'to'
            {
            match("to"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "TO"

    // $ANTLR start "IN"
    public final void mIN() throws RecognitionException {
        try {
            int _type = IN;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:272:9: ( 'in' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:272:17: 'in'
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

    // $ANTLR start "CS"
    public final void mCS() throws RecognitionException {
        try {
            int _type = CS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:276:9: ( 'cs:' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:276:17: 'cs:'
            {
            match("cs:"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "CS"

    // $ANTLR start "AT"
    public final void mAT() throws RecognitionException {
        try {
            int _type = AT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:279:9: ( 'at' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:279:18: 'at'
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

    // $ANTLR start "AND"
    public final void mAND() throws RecognitionException {
        try {
            int _type = AND;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:282:9: ( 'and' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:282:18: 'and'
            {
            match("and"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "AND"

    // $ANTLR start "CYCLE"
    public final void mCYCLE() throws RecognitionException {
        try {
            int _type = CYCLE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:285:9: ( 'cycle' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:285:17: 'cycle'
            {
            match("cycle"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "CYCLE"

    // $ANTLR start "FOREACH"
    public final void mFOREACH() throws RecognitionException {
        try {
            int _type = FOREACH;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:288:9: ( 'foreach' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:288:17: 'foreach'
            {
            match("foreach"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "FOREACH"

    // $ANTLR start "NODE"
    public final void mNODE() throws RecognitionException {
        try {
            int _type = NODE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:291:9: ( 'node' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:291:17: 'node'
            {
            match("node"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "NODE"

    // $ANTLR start "EDGE"
    public final void mEDGE() throws RecognitionException {
        try {
            int _type = EDGE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:294:9: ( 'edge' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:294:17: 'edge'
            {
            match("edge"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "EDGE"

    // $ANTLR start "CONTROLS"
    public final void mCONTROLS() throws RecognitionException {
        try {
            int _type = CONTROLS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:297:9: ( 'controls' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:297:17: 'controls'
            {
            match("controls"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "CONTROLS"

    // $ANTLR start "OPERATOR"
    public final void mOPERATOR() throws RecognitionException {
        try {
            int _type = OPERATOR;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:302:9: ( '<' | '>' | '=' | '*' | '-' | '+' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:
            {
            if ( (input.LA(1)>='*' && input.LA(1)<='+')||input.LA(1)=='-'||(input.LA(1)>='<' && input.LA(1)<='>') ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "OPERATOR"

    // $ANTLR start "CHILD"
    public final void mCHILD() throws RecognitionException {
        try {
            int _type = CHILD;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:309:9: ( 'child' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:309:17: 'child'
            {
            match("child"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "CHILD"

    // $ANTLR start "CIRCLE"
    public final void mCIRCLE() throws RecognitionException {
        try {
            int _type = CIRCLE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:312:9: ( 'circle' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:312:17: 'circle'
            {
            match("circle"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "CIRCLE"

    // $ANTLR start "ELLIPSE"
    public final void mELLIPSE() throws RecognitionException {
        try {
            int _type = ELLIPSE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:315:9: ( 'ellipse' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:315:17: 'ellipse'
            {
            match("ellipse"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ELLIPSE"

    // $ANTLR start "ARC"
    public final void mARC() throws RecognitionException {
        try {
            int _type = ARC;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:318:9: ( 'arc' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:318:17: 'arc'
            {
            match("arc"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ARC"

    // $ANTLR start "PARABOLA"
    public final void mPARABOLA() throws RecognitionException {
        try {
            int _type = PARABOLA;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:321:9: ( 'parabola' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:321:17: 'parabola'
            {
            match("parabola"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "PARABOLA"

    // $ANTLR start "BEND"
    public final void mBEND() throws RecognitionException {
        try {
            int _type = BEND;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:324:9: ( 'bend' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:324:17: 'bend'
            {
            match("bend"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "BEND"

    // $ANTLR start "OPERATION"
    public final void mOPERATION() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:329:9: ( 'operation' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:329:17: 'operation'
            {
            match("operation"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "OPERATION"

    // $ANTLR start "COORD_SYS"
    public final void mCOORD_SYS() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:334:9: ( 'coordinate system' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:334:17: 'coordinate system'
            {
            match("coordinate system"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "COORD_SYS"

    // $ANTLR start "POINT"
    public final void mPOINT() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:338:9: ( 'point' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:338:17: 'point'
            {
            match("point"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "POINT"

    // $ANTLR start "CURVE"
    public final void mCURVE() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:347:9: ( 'curve' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:347:17: 'curve'
            {
            match("curve"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "CURVE"

    // $ANTLR start "SIN"
    public final void mSIN() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:351:9: ( 'sin' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:351:17: 'sin'
            {
            match("sin"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "SIN"

    // $ANTLR start "COS"
    public final void mCOS() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:355:9: ( 'cos' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:355:17: 'cos'
            {
            match("cos"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "COS"

    // $ANTLR start "FUNC"
    public final void mFUNC() throws RecognitionException {
        try {
            int _type = FUNC;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:358:9: ( SIN | COS )
            int alt2=2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0=='s') ) {
                alt2=1;
            }
            else if ( (LA2_0=='c') ) {
                alt2=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 2, 0, input);

                throw nvae;
            }
            switch (alt2) {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:358:17: SIN
                    {
                    mSIN(); 

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:358:21: COS
                    {
                    mCOS(); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "FUNC"

    // $ANTLR start "AGAINPATH"
    public final void mAGAINPATH() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:363:9: ( 'againpath' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:363:17: 'againpath'
            {
            match("againpath"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "AGAINPATH"

    // $ANTLR start "LINETO"
    public final void mLINETO() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:367:9: ( 'lineto' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:367:17: 'lineto'
            {
            match("lineto"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "LINETO"

    // $ANTLR start "LINETOHV"
    public final void mLINETOHV() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:371:9: ( 'linetohv' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:371:17: 'linetohv'
            {
            match("linetohv"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "LINETOHV"

    // $ANTLR start "LINETOVH"
    public final void mLINETOVH() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:375:9: ( 'linetovh' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:375:17: 'linetovh'
            {
            match("linetovh"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "LINETOVH"

    // $ANTLR start "MOVETO"
    public final void mMOVETO() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:379:9: ( 'moveto' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:379:17: 'moveto'
            {
            match("moveto"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "MOVETO"

    // $ANTLR start "VARNAME"
    public final void mVARNAME() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:383:9: ( 'varname' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:383:17: 'varname'
            {
            match("varname"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "VARNAME"

    // $ANTLR start "PATH_CONSTRUCTION"
    public final void mPATH_CONSTRUCTION() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:388:9: ( 'path' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:388:17: 'path'
            {
            match("path"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "PATH_CONSTRUCTION"

    // $ANTLR start "GNUPLOT"
    public final void mGNUPLOT() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:392:9: ( 'gnuplot' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:392:17: 'gnuplot'
            {
            match("gnuplot"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "GNUPLOT"

    // $ANTLR start "EDGE_FROM_PARENT"
    public final void mEDGE_FROM_PARENT() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:397:9: ( 'edge from parent' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:397:17: 'edge from parent'
            {
            match("edge from parent"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "EDGE_FROM_PARENT"

    // $ANTLR start "BEGIN"
    public final void mBEGIN() throws RecognitionException {
        try {
            int _type = BEGIN;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:402:9: ( 'begin' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:402:17: 'begin'
            {
            match("begin"); 


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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:405:9: ( 'end' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:405:17: 'end'
            {
            match("end"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "END"

    // $ANTLR start "MACRO"
    public final void mMACRO() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:409:9: ( 'macro' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:409:17: 'macro'
            {
            match("macro"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "MACRO"

    // $ANTLR start "BODY"
    public final void mBODY() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:413:9: ( 'body' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:413:17: 'body'
            {
            match("body"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "BODY"

    // $ANTLR start "NAME"
    public final void mNAME() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:417:9: ( 'name' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:417:17: 'name'
            {
            match("name"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "NAME"

    // $ANTLR start "VALUE"
    public final void mVALUE() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:421:9: ( 'value' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:421:17: 'value'
            {
            match("value"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "VALUE"

    // $ANTLR start "LIST_ELEM"
    public final void mLIST_ELEM() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:426:9: ( 'list_elem' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:426:17: 'list_elem'
            {
            match("list_elem"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "LIST_ELEM"

    // $ANTLR start "LIST"
    public final void mLIST() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:430:9: ( 'list' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:430:17: 'list'
            {
            match("list"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "LIST"

    // $ANTLR start "LISTS"
    public final void mLISTS() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:434:9: ( 'lists' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:434:17: 'lists'
            {
            match("lists"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "LISTS"

    // $ANTLR start "BLOCK"
    public final void mBLOCK() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:438:9: ( 'block' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:438:17: 'block'
            {
            match("block"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "BLOCK"

    // $ANTLR start "BLOCKS"
    public final void mBLOCKS() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:441:9: ( 'blocks' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:441:17: 'blocks'
            {
            match("blocks"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "BLOCKS"

    // $ANTLR start "COMMAND"
    public final void mCOMMAND() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:445:9: ( 'command' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:445:17: 'command'
            {
            match("command"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "COMMAND"

    // $ANTLR start "COMMANDS"
    public final void mCOMMANDS() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:449:9: ( 'commands' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:449:17: 'commands'
            {
            match("commands"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "COMMANDS"

    // $ANTLR start "OPTION"
    public final void mOPTION() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:453:9: ( 'option' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:453:17: 'option'
            {
            match("option"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "OPTION"

    // $ANTLR start "OPTIONS"
    public final void mOPTIONS() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:457:9: ( 'options' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:457:17: 'options'
            {
            match("options"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "OPTIONS"

    // $ANTLR start "COORDINATE"
    public final void mCOORDINATE() throws RecognitionException {
        try {
            int _type = COORDINATE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:461:9: ( 'coordinate' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:461:17: 'coordinate'
            {
            match("coordinate"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "COORDINATE"

    // $ANTLR start "PC"
    public final void mPC() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:465:9: ( 'pc' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:465:17: 'pc'
            {
            match("pc"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "PC"

    // $ANTLR start "PD"
    public final void mPD() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:469:9: ( 'pd' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:469:17: 'pd'
            {
            match("pd"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "PD"

    // $ANTLR start "PE"
    public final void mPE() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:473:9: ( 'pe' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:473:17: 'pe'
            {
            match("pe"); 


            }

        }
        finally {
        }
    }
    // $ANTLR end "PE"

    // $ANTLR start "KEYWORDS"
    public final void mKEYWORDS() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:477:9: ( BEGIN | END | HVLINE | VHLINE | BACKSLASH | TO | IN | CYCLE | FOREACH | CS | NODE | AT | FUNC | FUNCTION | FILE | COORDINATES | COORDINATE | EDGE | AND | CONTROLS | FROM | PARENT | DOTS | RECTANGLE | GRID | PLOT | CHILD | CIRCLE | ELLIPSE | ARC | PARABOLA | BEND | OPERATOR )
            int alt3=33;
            alt3 = dfa3.predict(input);
            switch (alt3) {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:477:17: BEGIN
                    {
                    mBEGIN(); 

                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:477:23: END
                    {
                    mEND(); 

                    }
                    break;
                case 3 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:477:27: HVLINE
                    {
                    mHVLINE(); 

                    }
                    break;
                case 4 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:477:34: VHLINE
                    {
                    mVHLINE(); 

                    }
                    break;
                case 5 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:477:41: BACKSLASH
                    {
                    mBACKSLASH(); 

                    }
                    break;
                case 6 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:477:51: TO
                    {
                    mTO(); 

                    }
                    break;
                case 7 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:477:54: IN
                    {
                    mIN(); 

                    }
                    break;
                case 8 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:477:57: CYCLE
                    {
                    mCYCLE(); 

                    }
                    break;
                case 9 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:477:63: FOREACH
                    {
                    mFOREACH(); 

                    }
                    break;
                case 10 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:477:71: CS
                    {
                    mCS(); 

                    }
                    break;
                case 11 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:477:74: NODE
                    {
                    mNODE(); 

                    }
                    break;
                case 12 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:478:18: AT
                    {
                    mAT(); 

                    }
                    break;
                case 13 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:478:21: FUNC
                    {
                    mFUNC(); 

                    }
                    break;
                case 14 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:478:26: FUNCTION
                    {
                    mFUNCTION(); 

                    }
                    break;
                case 15 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:478:35: FILE
                    {
                    mFILE(); 

                    }
                    break;
                case 16 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:478:40: COORDINATES
                    {
                    mCOORDINATES(); 

                    }
                    break;
                case 17 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:478:52: COORDINATE
                    {
                    mCOORDINATE(); 

                    }
                    break;
                case 18 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:478:63: EDGE
                    {
                    mEDGE(); 

                    }
                    break;
                case 19 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:478:68: AND
                    {
                    mAND(); 

                    }
                    break;
                case 20 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:478:72: CONTROLS
                    {
                    mCONTROLS(); 

                    }
                    break;
                case 21 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:478:81: FROM
                    {
                    mFROM(); 

                    }
                    break;
                case 22 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:478:86: PARENT
                    {
                    mPARENT(); 

                    }
                    break;
                case 23 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:479:18: DOTS
                    {
                    mDOTS(); 

                    }
                    break;
                case 24 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:479:23: RECTANGLE
                    {
                    mRECTANGLE(); 

                    }
                    break;
                case 25 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:479:33: GRID
                    {
                    mGRID(); 

                    }
                    break;
                case 26 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:479:38: PLOT
                    {
                    mPLOT(); 

                    }
                    break;
                case 27 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:479:43: CHILD
                    {
                    mCHILD(); 

                    }
                    break;
                case 28 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:479:49: CIRCLE
                    {
                    mCIRCLE(); 

                    }
                    break;
                case 29 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:479:56: ELLIPSE
                    {
                    mELLIPSE(); 

                    }
                    break;
                case 30 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:479:64: ARC
                    {
                    mARC(); 

                    }
                    break;
                case 31 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:479:68: PARABOLA
                    {
                    mPARABOLA(); 

                    }
                    break;
                case 32 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:479:77: BEND
                    {
                    mBEND(); 

                    }
                    break;
                case 33 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:479:82: OPERATOR
                    {
                    mOPERATOR(); 

                    }
                    break;

            }
        }
        finally {
        }
    }
    // $ANTLR end "KEYWORDS"

    // $ANTLR start "CONTROL_CHARS"
    public final void mCONTROL_CHARS() throws RecognitionException {
        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:484:9: ( '{' | '}' | '(' | ')' | '[' | ']' | ',' | ':' | ';' | ' ' | '\\t' | '\\n' | '\\r' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:
            {
            if ( (input.LA(1)>='\t' && input.LA(1)<='\n')||input.LA(1)=='\r'||input.LA(1)==' '||(input.LA(1)>='(' && input.LA(1)<=')')||input.LA(1)==','||(input.LA(1)>=':' && input.LA(1)<=';')||input.LA(1)=='['||input.LA(1)==']'||input.LA(1)=='{'||input.LA(1)=='}' ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}


            }

        }
        finally {
        }
    }
    // $ANTLR end "CONTROL_CHARS"

    // $ANTLR start "STRING"
    public final void mSTRING() throws RecognitionException {
        try {
            int _type = STRING;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:488:9: ( (~ ( KEYWORDS | CONTROL_CHARS ) )+ )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:488:17: (~ ( KEYWORDS | CONTROL_CHARS ) )+
            {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:488:17: (~ ( KEYWORDS | CONTROL_CHARS ) )+
            int cnt4=0;
            loop4:
            do {
                int alt4=2;
                int LA4_0 = input.LA(1);

                if ( ((LA4_0>='\u0000' && LA4_0<='\b')||(LA4_0>='\u000B' && LA4_0<='\f')||(LA4_0>='\u000E' && LA4_0<='\u001F')||(LA4_0>='!' && LA4_0<='\'')||(LA4_0>='.' && LA4_0<='9')||(LA4_0>='?' && LA4_0<='Z')||(LA4_0>='^' && LA4_0<='z')||LA4_0=='|'||(LA4_0>='~' && LA4_0<='\uFFFF')) ) {
                    alt4=1;
                }


                switch (alt4) {
            	case 1 :
            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:488:19: ~ ( KEYWORDS | CONTROL_CHARS )
            	    {
            	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='\b')||(input.LA(1)>='\u000B' && input.LA(1)<='\f')||(input.LA(1)>='\u000E' && input.LA(1)<='\u001F')||(input.LA(1)>='!' && input.LA(1)<='\'')||(input.LA(1)>='.' && input.LA(1)<='9')||(input.LA(1)>='?' && input.LA(1)<='Z')||(input.LA(1)>='^' && input.LA(1)<='z')||input.LA(1)=='|'||(input.LA(1)>='~' && input.LA(1)<='\uFFFF') ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    if ( cnt4 >= 1 ) break loop4;
                        EarlyExitException eee =
                            new EarlyExitException(4, input);
                        throw eee;
                }
                cnt4++;
            } while (true);


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "WS"
    public final void mWS() throws RecognitionException {
        try {
            int _type = WS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:493:9: ( ( ' ' | '\\t' | '\\n' | '\\r' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:493:17: ( ' ' | '\\t' | '\\n' | '\\r' )
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

    public void mTokens() throws RecognitionException {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:8: ( T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | COMMENT | BACKSLASH | FUNCTION | FILE | COORDINATES | PLOT | RECTANGLE | GRID | LINE | FROM | PARENT | HVLINE | VHLINE | DOTS | TO | IN | CS | AT | AND | CYCLE | FOREACH | NODE | EDGE | CONTROLS | OPERATOR | CHILD | CIRCLE | ELLIPSE | ARC | PARABOLA | BEND | FUNC | BEGIN | END | COORDINATE | STRING | WS )
        int alt5=46;
        alt5 = dfa5.predict(input);
        switch (alt5) {
            case 1 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:10: T__74
                {
                mT__74(); 

                }
                break;
            case 2 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:16: T__75
                {
                mT__75(); 

                }
                break;
            case 3 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:22: T__76
                {
                mT__76(); 

                }
                break;
            case 4 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:28: T__77
                {
                mT__77(); 

                }
                break;
            case 5 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:34: T__78
                {
                mT__78(); 

                }
                break;
            case 6 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:40: T__79
                {
                mT__79(); 

                }
                break;
            case 7 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:46: T__80
                {
                mT__80(); 

                }
                break;
            case 8 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:52: T__81
                {
                mT__81(); 

                }
                break;
            case 9 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:58: T__82
                {
                mT__82(); 

                }
                break;
            case 10 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:64: COMMENT
                {
                mCOMMENT(); 

                }
                break;
            case 11 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:72: BACKSLASH
                {
                mBACKSLASH(); 

                }
                break;
            case 12 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:82: FUNCTION
                {
                mFUNCTION(); 

                }
                break;
            case 13 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:91: FILE
                {
                mFILE(); 

                }
                break;
            case 14 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:96: COORDINATES
                {
                mCOORDINATES(); 

                }
                break;
            case 15 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:108: PLOT
                {
                mPLOT(); 

                }
                break;
            case 16 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:113: RECTANGLE
                {
                mRECTANGLE(); 

                }
                break;
            case 17 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:123: GRID
                {
                mGRID(); 

                }
                break;
            case 18 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:128: LINE
                {
                mLINE(); 

                }
                break;
            case 19 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:133: FROM
                {
                mFROM(); 

                }
                break;
            case 20 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:138: PARENT
                {
                mPARENT(); 

                }
                break;
            case 21 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:145: HVLINE
                {
                mHVLINE(); 

                }
                break;
            case 22 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:152: VHLINE
                {
                mVHLINE(); 

                }
                break;
            case 23 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:159: DOTS
                {
                mDOTS(); 

                }
                break;
            case 24 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:164: TO
                {
                mTO(); 

                }
                break;
            case 25 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:167: IN
                {
                mIN(); 

                }
                break;
            case 26 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:170: CS
                {
                mCS(); 

                }
                break;
            case 27 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:173: AT
                {
                mAT(); 

                }
                break;
            case 28 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:176: AND
                {
                mAND(); 

                }
                break;
            case 29 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:180: CYCLE
                {
                mCYCLE(); 

                }
                break;
            case 30 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:186: FOREACH
                {
                mFOREACH(); 

                }
                break;
            case 31 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:194: NODE
                {
                mNODE(); 

                }
                break;
            case 32 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:199: EDGE
                {
                mEDGE(); 

                }
                break;
            case 33 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:204: CONTROLS
                {
                mCONTROLS(); 

                }
                break;
            case 34 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:213: OPERATOR
                {
                mOPERATOR(); 

                }
                break;
            case 35 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:222: CHILD
                {
                mCHILD(); 

                }
                break;
            case 36 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:228: CIRCLE
                {
                mCIRCLE(); 

                }
                break;
            case 37 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:235: ELLIPSE
                {
                mELLIPSE(); 

                }
                break;
            case 38 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:243: ARC
                {
                mARC(); 

                }
                break;
            case 39 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:247: PARABOLA
                {
                mPARABOLA(); 

                }
                break;
            case 40 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:256: BEND
                {
                mBEND(); 

                }
                break;
            case 41 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:261: FUNC
                {
                mFUNC(); 

                }
                break;
            case 42 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:266: BEGIN
                {
                mBEGIN(); 

                }
                break;
            case 43 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:272: END
                {
                mEND(); 

                }
                break;
            case 44 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:276: COORDINATE
                {
                mCOORDINATE(); 

                }
                break;
            case 45 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:287: STRING
                {
                mSTRING(); 

                }
                break;
            case 46 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:1:294: WS
                {
                mWS(); 

                }
                break;

        }

    }


    protected DFA3 dfa3 = new DFA3(this);
    protected DFA5 dfa5 = new DFA5(this);
    static final String DFA3_eotS =
        "\3\uffff\1\21\56\uffff\1\64\2\uffff";
    static final String DFA3_eofS =
        "\65\uffff";
    static final String DFA3_minS =
        "\1\52\1\145\1\144\1\174\4\uffff\1\150\1\151\1\uffff\1\156\1\uffff"+
        "\1\141\4\uffff\1\147\6\uffff\1\156\11\uffff\1\162\3\uffff\1\162"+
        "\1\uffff\1\141\1\144\2\uffff\1\151\1\156\1\141\1\164\1\145\1\163"+
        "\2\uffff";
    static final String DFA3_maxS =
        "\1\174\1\145\1\156\1\174\4\uffff\1\171\1\165\1\uffff\1\164\1\uffff"+
        "\1\154\4\uffff\1\156\6\uffff\1\163\11\uffff\1\162\3\uffff\1\162"+
        "\1\uffff\1\145\1\144\2\uffff\1\151\1\156\1\141\1\164\1\145\1\163"+
        "\2\uffff";
    static final String DFA3_acceptS =
        "\4\uffff\1\4\1\5\1\6\1\7\2\uffff\1\13\1\uffff\1\15\1\uffff\1\27"+
        "\1\30\1\31\1\41\1\uffff\1\2\1\22\1\35\1\3\1\10\1\12\1\uffff\1\33"+
        "\1\34\1\11\1\16\1\17\1\25\1\14\1\23\1\36\1\uffff\1\32\1\1\1\40\1"+
        "\uffff\1\24\2\uffff\1\26\1\37\6\uffff\1\20\1\21";
    static final String DFA3_specialS =
        "\65\uffff}>";
    static final String[] DFA3_transitionS = {
            "\2\21\1\uffff\1\3\1\16\15\uffff\3\21\35\uffff\1\5\4\uffff\1"+
            "\13\1\1\1\10\1\uffff\1\2\1\11\1\20\1\uffff\1\7\4\uffff\1\12"+
            "\1\uffff\1\15\1\uffff\1\17\1\14\1\6\7\uffff\1\4",
            "\1\22",
            "\1\24\7\uffff\1\25\1\uffff\1\23",
            "\1\26",
            "",
            "",
            "",
            "",
            "\1\32\1\33\5\uffff\1\31\3\uffff\1\30\5\uffff\1\27",
            "\1\36\5\uffff\1\34\2\uffff\1\37\2\uffff\1\35",
            "",
            "\1\41\3\uffff\1\42\1\uffff\1\40",
            "",
            "\1\43\12\uffff\1\44",
            "",
            "",
            "",
            "",
            "\1\45\6\uffff\1\46",
            "",
            "",
            "",
            "",
            "",
            "",
            "\1\50\1\47\3\uffff\1\14",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\1\51",
            "",
            "",
            "",
            "\1\52",
            "",
            "\1\54\3\uffff\1\53",
            "\1\55",
            "",
            "",
            "\1\56",
            "\1\57",
            "\1\60",
            "\1\61",
            "\1\62",
            "\1\63",
            "",
            ""
    };

    static final short[] DFA3_eot = DFA.unpackEncodedString(DFA3_eotS);
    static final short[] DFA3_eof = DFA.unpackEncodedString(DFA3_eofS);
    static final char[] DFA3_min = DFA.unpackEncodedStringToUnsignedChars(DFA3_minS);
    static final char[] DFA3_max = DFA.unpackEncodedStringToUnsignedChars(DFA3_maxS);
    static final short[] DFA3_accept = DFA.unpackEncodedString(DFA3_acceptS);
    static final short[] DFA3_special = DFA.unpackEncodedString(DFA3_specialS);
    static final short[][] DFA3_transition;

    static {
        int numStates = DFA3_transitionS.length;
        DFA3_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA3_transition[i] = DFA.unpackEncodedString(DFA3_transitionS[i]);
        }
    }

    class DFA3 extends DFA {

        public DFA3(BaseRecognizer recognizer) {
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
        public String getDescription() {
            return "476:1: fragment KEYWORDS : ( BEGIN | END | HVLINE | VHLINE | BACKSLASH | TO | IN | CYCLE | FOREACH | CS | NODE | AT | FUNC | FUNCTION | FILE | COORDINATES | COORDINATE | EDGE | AND | CONTROLS | FROM | PARENT | DOTS | RECTANGLE | GRID | PLOT | CHILD | CIRCLE | ELLIPSE | ARC | PARABOLA | BEND | OPERATOR );";
        }
    }
    static final String DFA5_eotS =
        "\12\uffff\1\36\1\uffff\5\34\1\31\7\34\1\uffff\2\34\3\uffff\1\36"+
        "\15\34\3\uffff\1\113\1\114\1\115\1\116\16\34\1\136\1\uffff\7\34"+
        "\4\uffff\1\147\1\150\3\34\1\154\2\34\1\136\1\34\1\160\1\161\3\34"+
        "\1\uffff\3\34\1\170\3\34\1\174\2\uffff\1\175\1\176\1\34\1\uffff"+
        "\1\u0080\2\34\2\uffff\3\34\1\u0086\1\u0087\1\34\1\uffff\3\34\3\uffff"+
        "\1\34\1\uffff\1\u008d\4\34\2\uffff\1\u0092\1\u0093\3\34\1\uffff"+
        "\1\34\1\u0098\2\34\2\uffff\2\34\1\u009d\1\u009e\1\uffff\1\34\1\u00a0"+
        "\1\u00a1\1\34\2\uffff\1\34\2\uffff\1\u00a4\1\u00a6\1\uffff\1\u00a7"+
        "\2\uffff";
    static final String DFA5_eofS =
        "\u00a8\uffff";
    static final String DFA5_minS =
        "\1\0\11\uffff\1\0\1\uffff\1\151\1\150\1\141\1\145\1\151\2\55\1"+
        "\56\1\157\2\156\1\157\1\144\1\uffff\1\145\1\151\3\uffff\1\0\1\156"+
        "\1\154\1\157\1\162\1\156\1\72\1\143\1\151\1\162\1\157\1\162\1\143"+
        "\1\162\3\uffff\4\0\1\144\1\143\1\144\1\147\1\154\1\144\1\147\1\156"+
        "\1\143\1\145\1\155\1\145\1\162\1\164\1\0\1\uffff\2\154\1\143\1\164"+
        "\1\141\1\164\1\144\4\uffff\2\0\2\145\1\151\1\0\1\144\1\151\1\0\1"+
        "\164\2\0\1\141\1\144\1\162\1\uffff\1\145\1\144\1\154\1\0\1\156\1"+
        "\142\1\141\1\0\2\uffff\2\0\1\160\1\uffff\1\0\1\156\1\151\2\uffff"+
        "\1\143\1\151\1\157\2\0\1\145\1\uffff\1\164\1\157\1\156\3\uffff\1"+
        "\163\1\uffff\1\0\1\157\1\150\1\156\1\154\2\uffff\2\0\1\154\1\147"+
        "\1\145\1\uffff\1\156\1\0\1\141\1\163\2\uffff\1\141\1\154\2\0\1\uffff"+
        "\1\164\2\0\1\145\2\uffff\1\145\2\uffff\2\0\1\uffff\1\0\2\uffff";
    static final String DFA5_maxS =
        "\1\uffff\11\uffff\1\uffff\1\uffff\1\165\1\171\1\154\1\145\1\151"+
        "\1\174\1\55\1\56\1\157\1\156\1\164\1\157\1\156\1\uffff\1\145\1\151"+
        "\3\uffff\1\uffff\1\156\1\154\1\157\1\162\1\163\1\72\1\143\1\151"+
        "\1\162\1\157\1\162\1\143\1\162\3\uffff\4\uffff\1\144\1\143\1\144"+
        "\1\147\1\154\1\144\2\156\1\143\1\145\1\155\1\145\1\162\1\164\1\uffff"+
        "\1\uffff\2\154\1\143\1\164\1\145\1\164\1\144\4\uffff\2\uffff\2\145"+
        "\1\151\1\uffff\1\144\1\151\1\uffff\1\164\2\uffff\1\141\1\144\1\162"+
        "\1\uffff\1\145\1\144\1\154\1\uffff\1\156\1\142\1\141\1\uffff\2\uffff"+
        "\2\uffff\1\160\1\uffff\1\uffff\1\156\1\151\2\uffff\1\143\1\151\1"+
        "\157\2\uffff\1\145\1\uffff\1\164\1\157\1\156\3\uffff\1\163\1\uffff"+
        "\1\uffff\1\157\1\150\1\156\1\154\2\uffff\2\uffff\1\154\1\147\1\145"+
        "\1\uffff\1\156\1\uffff\1\141\1\163\2\uffff\1\141\1\154\2\uffff\1"+
        "\uffff\1\164\2\uffff\1\145\2\uffff\1\145\2\uffff\2\uffff\1\uffff"+
        "\1\uffff\2\uffff";
    static final String DFA5_acceptS =
        "\1\uffff\1\1\1\2\1\3\1\4\1\5\1\6\1\7\1\10\1\11\1\uffff\1\13\15"+
        "\uffff\1\42\2\uffff\1\55\1\56\1\12\16\uffff\1\22\1\25\1\26\23\uffff"+
        "\1\32\7\uffff\1\27\1\30\1\31\1\33\17\uffff\1\51\10\uffff\1\34\1"+
        "\46\3\uffff\1\53\3\uffff\1\15\1\23\6\uffff\1\17\3\uffff\1\21\1\37"+
        "\1\40\1\uffff\1\50\5\uffff\1\35\1\43\5\uffff\1\52\4\uffff\1\44\1"+
        "\24\4\uffff\1\36\4\uffff\1\45\1\14\1\uffff\1\41\1\47\2\uffff\1\20"+
        "\1\uffff\1\54\1\16";
    static final String DFA5_specialS =
        "\1\33\11\uffff\1\31\24\uffff\1\14\20\uffff\1\6\1\2\1\5\1\32\16"+
        "\uffff\1\22\14\uffff\1\35\1\0\3\uffff\1\23\2\uffff\1\17\1\uffff"+
        "\1\25\1\16\7\uffff\1\30\3\uffff\1\11\2\uffff\1\24\1\26\2\uffff\1"+
        "\3\7\uffff\1\36\1\7\12\uffff\1\37\6\uffff\1\12\1\13\5\uffff\1\20"+
        "\6\uffff\1\15\1\34\2\uffff\1\27\1\1\6\uffff\1\10\1\4\1\uffff\1\21"+
        "\2\uffff}>";
    static final String[] DFA5_transitionS = {
            "\11\34\2\35\2\34\1\35\22\34\1\35\4\34\1\12\2\34\1\4\1\5\2\31"+
            "\1\10\1\21\1\23\13\34\1\11\1\3\3\31\34\34\1\6\1\13\1\7\3\34"+
            "\1\26\1\32\1\15\1\34\1\30\1\14\1\20\1\34\1\25\4\34\1\27\1\34"+
            "\1\16\1\34\1\17\1\33\1\24\6\34\1\1\1\22\1\2\uff82\34",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\11\37\2\uffff\2\37\1\uffff\22\37\1\uffff\7\37\6\uffff\14"+
            "\37\5\uffff\34\37\3\uffff\35\37\1\uffff\1\37\1\uffff\uff82\37",
            "",
            "\1\41\5\uffff\1\43\2\uffff\1\42\2\uffff\1\40",
            "\1\47\1\50\5\uffff\1\44\3\uffff\1\45\5\uffff\1\46",
            "\1\52\12\uffff\1\51",
            "\1\53",
            "\1\54",
            "\1\55\116\uffff\1\56",
            "\1\57",
            "\1\60",
            "\1\61",
            "\1\62",
            "\1\64\3\uffff\1\65\1\uffff\1\63",
            "\1\66",
            "\1\67\7\uffff\1\70\1\uffff\1\71",
            "",
            "\1\72",
            "\1\73",
            "",
            "",
            "",
            "\11\37\2\uffff\2\37\1\uffff\22\37\1\uffff\7\37\6\uffff\14"+
            "\37\5\uffff\34\37\3\uffff\35\37\1\uffff\1\37\1\uffff\uff82\37",
            "\1\74",
            "\1\75",
            "\1\76",
            "\1\77",
            "\1\101\1\100\3\uffff\1\102",
            "\1\103",
            "\1\104",
            "\1\105",
            "\1\106",
            "\1\107",
            "\1\110",
            "\1\111",
            "\1\112",
            "",
            "",
            "",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\117",
            "\1\120",
            "\1\121",
            "\1\122",
            "\1\123",
            "\1\124",
            "\1\126\6\uffff\1\125",
            "\1\127",
            "\1\130",
            "\1\131",
            "\1\132",
            "\1\133",
            "\1\134",
            "\1\135",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "",
            "\1\137",
            "\1\140",
            "\1\141",
            "\1\142",
            "\1\144\3\uffff\1\143",
            "\1\145",
            "\1\146",
            "",
            "",
            "",
            "",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\151",
            "\1\152",
            "\1\153",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\155",
            "\1\156",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\157",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\162",
            "\1\163",
            "\1\164",
            "",
            "\1\165",
            "\1\166",
            "\1\167",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\171",
            "\1\172",
            "\1\173",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "",
            "",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\177",
            "",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\u0081",
            "\1\u0082",
            "",
            "",
            "\1\u0083",
            "\1\u0084",
            "\1\u0085",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\u0088",
            "",
            "\1\u0089",
            "\1\u008a",
            "\1\u008b",
            "",
            "",
            "",
            "\1\u008c",
            "",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\u008e",
            "\1\u008f",
            "\1\u0090",
            "\1\u0091",
            "",
            "",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\u0094",
            "\1\u0095",
            "\1\u0096",
            "",
            "\1\u0097",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\u0099",
            "\1\u009a",
            "",
            "",
            "\1\u009b",
            "\1\u009c",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "",
            "\1\u009f",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\1\u00a2",
            "",
            "",
            "\1\u00a3",
            "",
            "",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\25\34\1\u00a5\7\34\1\uffff\1\34\1"+
            "\uffff\uff82\34",
            "",
            "\11\34\2\uffff\2\34\1\uffff\22\34\1\uffff\7\34\6\uffff\14"+
            "\34\5\uffff\34\34\3\uffff\35\34\1\uffff\1\34\1\uffff\uff82\34",
            "",
            ""
    };

    static final short[] DFA5_eot = DFA.unpackEncodedString(DFA5_eotS);
    static final short[] DFA5_eof = DFA.unpackEncodedString(DFA5_eofS);
    static final char[] DFA5_min = DFA.unpackEncodedStringToUnsignedChars(DFA5_minS);
    static final char[] DFA5_max = DFA.unpackEncodedStringToUnsignedChars(DFA5_maxS);
    static final short[] DFA5_accept = DFA.unpackEncodedString(DFA5_acceptS);
    static final short[] DFA5_special = DFA.unpackEncodedString(DFA5_specialS);
    static final short[][] DFA5_transition;

    static {
        int numStates = DFA5_transitionS.length;
        DFA5_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA5_transition[i] = DFA.unpackEncodedString(DFA5_transitionS[i]);
        }
    }

    class DFA5 extends DFA {

        public DFA5(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;
        }
        public String getDescription() {
            return "1:1: Tokens : ( T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | COMMENT | BACKSLASH | FUNCTION | FILE | COORDINATES | PLOT | RECTANGLE | GRID | LINE | FROM | PARENT | HVLINE | VHLINE | DOTS | TO | IN | CS | AT | AND | CYCLE | FOREACH | NODE | EDGE | CONTROLS | OPERATOR | CHILD | CIRCLE | ELLIPSE | ARC | PARABOLA | BEND | FUNC | BEGIN | END | COORDINATE | STRING | WS );";
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            IntStream input = _input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA5_80 = input.LA(1);

                        s = -1;
                        if ( ((LA5_80>='\u0000' && LA5_80<='\b')||(LA5_80>='\u000B' && LA5_80<='\f')||(LA5_80>='\u000E' && LA5_80<='\u001F')||(LA5_80>='!' && LA5_80<='\'')||(LA5_80>='.' && LA5_80<='9')||(LA5_80>='?' && LA5_80<='Z')||(LA5_80>='^' && LA5_80<='z')||LA5_80=='|'||(LA5_80>='~' && LA5_80<='\uFFFF')) ) {s = 28;}

                        else s = 104;

                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA5_155 = input.LA(1);

                        s = -1;
                        if ( ((LA5_155>='\u0000' && LA5_155<='\b')||(LA5_155>='\u000B' && LA5_155<='\f')||(LA5_155>='\u000E' && LA5_155<='\u001F')||(LA5_155>='!' && LA5_155<='\'')||(LA5_155>='.' && LA5_155<='9')||(LA5_155>='?' && LA5_155<='Z')||(LA5_155>='^' && LA5_155<='z')||LA5_155=='|'||(LA5_155>='~' && LA5_155<='\uFFFF')) ) {s = 28;}

                        else s = 161;

                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA5_49 = input.LA(1);

                        s = -1;
                        if ( ((LA5_49>='\u0000' && LA5_49<='\b')||(LA5_49>='\u000B' && LA5_49<='\f')||(LA5_49>='\u000E' && LA5_49<='\u001F')||(LA5_49>='!' && LA5_49<='\'')||(LA5_49>='.' && LA5_49<='9')||(LA5_49>='?' && LA5_49<='Z')||(LA5_49>='^' && LA5_49<='z')||LA5_49=='|'||(LA5_49>='~' && LA5_49<='\uFFFF')) ) {s = 28;}

                        else s = 76;

                        if ( s>=0 ) return s;
                        break;
                    case 3 : 
                        int LA5_109 = input.LA(1);

                        s = -1;
                        if ( ((LA5_109>='\u0000' && LA5_109<='\b')||(LA5_109>='\u000B' && LA5_109<='\f')||(LA5_109>='\u000E' && LA5_109<='\u001F')||(LA5_109>='!' && LA5_109<='\'')||(LA5_109>='.' && LA5_109<='9')||(LA5_109>='?' && LA5_109<='Z')||(LA5_109>='^' && LA5_109<='z')||LA5_109=='|'||(LA5_109>='~' && LA5_109<='\uFFFF')) ) {s = 28;}

                        else s = 128;

                        if ( s>=0 ) return s;
                        break;
                    case 4 : 
                        int LA5_163 = input.LA(1);

                        s = -1;
                        if ( (LA5_163=='s') ) {s = 165;}

                        else if ( ((LA5_163>='\u0000' && LA5_163<='\b')||(LA5_163>='\u000B' && LA5_163<='\f')||(LA5_163>='\u000E' && LA5_163<='\u001F')||(LA5_163>='!' && LA5_163<='\'')||(LA5_163>='.' && LA5_163<='9')||(LA5_163>='?' && LA5_163<='Z')||(LA5_163>='^' && LA5_163<='r')||(LA5_163>='t' && LA5_163<='z')||LA5_163=='|'||(LA5_163>='~' && LA5_163<='\uFFFF')) ) {s = 28;}

                        else s = 166;

                        if ( s>=0 ) return s;
                        break;
                    case 5 : 
                        int LA5_50 = input.LA(1);

                        s = -1;
                        if ( ((LA5_50>='\u0000' && LA5_50<='\b')||(LA5_50>='\u000B' && LA5_50<='\f')||(LA5_50>='\u000E' && LA5_50<='\u001F')||(LA5_50>='!' && LA5_50<='\'')||(LA5_50>='.' && LA5_50<='9')||(LA5_50>='?' && LA5_50<='Z')||(LA5_50>='^' && LA5_50<='z')||LA5_50=='|'||(LA5_50>='~' && LA5_50<='\uFFFF')) ) {s = 28;}

                        else s = 77;

                        if ( s>=0 ) return s;
                        break;
                    case 6 : 
                        int LA5_48 = input.LA(1);

                        s = -1;
                        if ( ((LA5_48>='\u0000' && LA5_48<='\b')||(LA5_48>='\u000B' && LA5_48<='\f')||(LA5_48>='\u000E' && LA5_48<='\u001F')||(LA5_48>='!' && LA5_48<='\'')||(LA5_48>='.' && LA5_48<='9')||(LA5_48>='?' && LA5_48<='Z')||(LA5_48>='^' && LA5_48<='z')||LA5_48=='|'||(LA5_48>='~' && LA5_48<='\uFFFF')) ) {s = 28;}

                        else s = 75;

                        if ( s>=0 ) return s;
                        break;
                    case 7 : 
                        int LA5_118 = input.LA(1);

                        s = -1;
                        if ( ((LA5_118>='\u0000' && LA5_118<='\b')||(LA5_118>='\u000B' && LA5_118<='\f')||(LA5_118>='\u000E' && LA5_118<='\u001F')||(LA5_118>='!' && LA5_118<='\'')||(LA5_118>='.' && LA5_118<='9')||(LA5_118>='?' && LA5_118<='Z')||(LA5_118>='^' && LA5_118<='z')||LA5_118=='|'||(LA5_118>='~' && LA5_118<='\uFFFF')) ) {s = 28;}

                        else s = 135;

                        if ( s>=0 ) return s;
                        break;
                    case 8 : 
                        int LA5_162 = input.LA(1);

                        s = -1;
                        if ( ((LA5_162>='\u0000' && LA5_162<='\b')||(LA5_162>='\u000B' && LA5_162<='\f')||(LA5_162>='\u000E' && LA5_162<='\u001F')||(LA5_162>='!' && LA5_162<='\'')||(LA5_162>='.' && LA5_162<='9')||(LA5_162>='?' && LA5_162<='Z')||(LA5_162>='^' && LA5_162<='z')||LA5_162=='|'||(LA5_162>='~' && LA5_162<='\uFFFF')) ) {s = 28;}

                        else s = 164;

                        if ( s>=0 ) return s;
                        break;
                    case 9 : 
                        int LA5_102 = input.LA(1);

                        s = -1;
                        if ( ((LA5_102>='\u0000' && LA5_102<='\b')||(LA5_102>='\u000B' && LA5_102<='\f')||(LA5_102>='\u000E' && LA5_102<='\u001F')||(LA5_102>='!' && LA5_102<='\'')||(LA5_102>='.' && LA5_102<='9')||(LA5_102>='?' && LA5_102<='Z')||(LA5_102>='^' && LA5_102<='z')||LA5_102=='|'||(LA5_102>='~' && LA5_102<='\uFFFF')) ) {s = 28;}

                        else s = 124;

                        if ( s>=0 ) return s;
                        break;
                    case 10 : 
                        int LA5_136 = input.LA(1);

                        s = -1;
                        if ( ((LA5_136>='\u0000' && LA5_136<='\b')||(LA5_136>='\u000B' && LA5_136<='\f')||(LA5_136>='\u000E' && LA5_136<='\u001F')||(LA5_136>='!' && LA5_136<='\'')||(LA5_136>='.' && LA5_136<='9')||(LA5_136>='?' && LA5_136<='Z')||(LA5_136>='^' && LA5_136<='z')||LA5_136=='|'||(LA5_136>='~' && LA5_136<='\uFFFF')) ) {s = 28;}

                        else s = 146;

                        if ( s>=0 ) return s;
                        break;
                    case 11 : 
                        int LA5_137 = input.LA(1);

                        s = -1;
                        if ( ((LA5_137>='\u0000' && LA5_137<='\b')||(LA5_137>='\u000B' && LA5_137<='\f')||(LA5_137>='\u000E' && LA5_137<='\u001F')||(LA5_137>='!' && LA5_137<='\'')||(LA5_137>='.' && LA5_137<='9')||(LA5_137>='?' && LA5_137<='Z')||(LA5_137>='^' && LA5_137<='z')||LA5_137=='|'||(LA5_137>='~' && LA5_137<='\uFFFF')) ) {s = 28;}

                        else s = 147;

                        if ( s>=0 ) return s;
                        break;
                    case 12 : 
                        int LA5_31 = input.LA(1);

                        s = -1;
                        if ( ((LA5_31>='\u0000' && LA5_31<='\b')||(LA5_31>='\u000B' && LA5_31<='\f')||(LA5_31>='\u000E' && LA5_31<='\u001F')||(LA5_31>='!' && LA5_31<='\'')||(LA5_31>='.' && LA5_31<='9')||(LA5_31>='?' && LA5_31<='Z')||(LA5_31>='^' && LA5_31<='z')||LA5_31=='|'||(LA5_31>='~' && LA5_31<='\uFFFF')) ) {s = 31;}

                        else s = 30;

                        if ( s>=0 ) return s;
                        break;
                    case 13 : 
                        int LA5_150 = input.LA(1);

                        s = -1;
                        if ( ((LA5_150>='\u0000' && LA5_150<='\b')||(LA5_150>='\u000B' && LA5_150<='\f')||(LA5_150>='\u000E' && LA5_150<='\u001F')||(LA5_150>='!' && LA5_150<='\'')||(LA5_150>='.' && LA5_150<='9')||(LA5_150>='?' && LA5_150<='Z')||(LA5_150>='^' && LA5_150<='z')||LA5_150=='|'||(LA5_150>='~' && LA5_150<='\uFFFF')) ) {s = 28;}

                        else s = 157;

                        if ( s>=0 ) return s;
                        break;
                    case 14 : 
                        int LA5_90 = input.LA(1);

                        s = -1;
                        if ( ((LA5_90>='\u0000' && LA5_90<='\b')||(LA5_90>='\u000B' && LA5_90<='\f')||(LA5_90>='\u000E' && LA5_90<='\u001F')||(LA5_90>='!' && LA5_90<='\'')||(LA5_90>='.' && LA5_90<='9')||(LA5_90>='?' && LA5_90<='Z')||(LA5_90>='^' && LA5_90<='z')||LA5_90=='|'||(LA5_90>='~' && LA5_90<='\uFFFF')) ) {s = 28;}

                        else s = 113;

                        if ( s>=0 ) return s;
                        break;
                    case 15 : 
                        int LA5_87 = input.LA(1);

                        s = -1;
                        if ( ((LA5_87>='\u0000' && LA5_87<='\b')||(LA5_87>='\u000B' && LA5_87<='\f')||(LA5_87>='\u000E' && LA5_87<='\u001F')||(LA5_87>='!' && LA5_87<='\'')||(LA5_87>='.' && LA5_87<='9')||(LA5_87>='?' && LA5_87<='Z')||(LA5_87>='^' && LA5_87<='z')||LA5_87=='|'||(LA5_87>='~' && LA5_87<='\uFFFF')) ) {s = 28;}

                        else s = 94;

                        if ( s>=0 ) return s;
                        break;
                    case 16 : 
                        int LA5_143 = input.LA(1);

                        s = -1;
                        if ( ((LA5_143>='\u0000' && LA5_143<='\b')||(LA5_143>='\u000B' && LA5_143<='\f')||(LA5_143>='\u000E' && LA5_143<='\u001F')||(LA5_143>='!' && LA5_143<='\'')||(LA5_143>='.' && LA5_143<='9')||(LA5_143>='?' && LA5_143<='Z')||(LA5_143>='^' && LA5_143<='z')||LA5_143=='|'||(LA5_143>='~' && LA5_143<='\uFFFF')) ) {s = 28;}

                        else s = 152;

                        if ( s>=0 ) return s;
                        break;
                    case 17 : 
                        int LA5_165 = input.LA(1);

                        s = -1;
                        if ( ((LA5_165>='\u0000' && LA5_165<='\b')||(LA5_165>='\u000B' && LA5_165<='\f')||(LA5_165>='\u000E' && LA5_165<='\u001F')||(LA5_165>='!' && LA5_165<='\'')||(LA5_165>='.' && LA5_165<='9')||(LA5_165>='?' && LA5_165<='Z')||(LA5_165>='^' && LA5_165<='z')||LA5_165=='|'||(LA5_165>='~' && LA5_165<='\uFFFF')) ) {s = 28;}

                        else s = 167;

                        if ( s>=0 ) return s;
                        break;
                    case 18 : 
                        int LA5_66 = input.LA(1);

                        s = -1;
                        if ( ((LA5_66>='\u0000' && LA5_66<='\b')||(LA5_66>='\u000B' && LA5_66<='\f')||(LA5_66>='\u000E' && LA5_66<='\u001F')||(LA5_66>='!' && LA5_66<='\'')||(LA5_66>='.' && LA5_66<='9')||(LA5_66>='?' && LA5_66<='Z')||(LA5_66>='^' && LA5_66<='z')||LA5_66=='|'||(LA5_66>='~' && LA5_66<='\uFFFF')) ) {s = 28;}

                        else s = 94;

                        if ( s>=0 ) return s;
                        break;
                    case 19 : 
                        int LA5_84 = input.LA(1);

                        s = -1;
                        if ( ((LA5_84>='\u0000' && LA5_84<='\b')||(LA5_84>='\u000B' && LA5_84<='\f')||(LA5_84>='\u000E' && LA5_84<='\u001F')||(LA5_84>='!' && LA5_84<='\'')||(LA5_84>='.' && LA5_84<='9')||(LA5_84>='?' && LA5_84<='Z')||(LA5_84>='^' && LA5_84<='z')||LA5_84=='|'||(LA5_84>='~' && LA5_84<='\uFFFF')) ) {s = 28;}

                        else s = 108;

                        if ( s>=0 ) return s;
                        break;
                    case 20 : 
                        int LA5_105 = input.LA(1);

                        s = -1;
                        if ( ((LA5_105>='\u0000' && LA5_105<='\b')||(LA5_105>='\u000B' && LA5_105<='\f')||(LA5_105>='\u000E' && LA5_105<='\u001F')||(LA5_105>='!' && LA5_105<='\'')||(LA5_105>='.' && LA5_105<='9')||(LA5_105>='?' && LA5_105<='Z')||(LA5_105>='^' && LA5_105<='z')||LA5_105=='|'||(LA5_105>='~' && LA5_105<='\uFFFF')) ) {s = 28;}

                        else s = 125;

                        if ( s>=0 ) return s;
                        break;
                    case 21 : 
                        int LA5_89 = input.LA(1);

                        s = -1;
                        if ( ((LA5_89>='\u0000' && LA5_89<='\b')||(LA5_89>='\u000B' && LA5_89<='\f')||(LA5_89>='\u000E' && LA5_89<='\u001F')||(LA5_89>='!' && LA5_89<='\'')||(LA5_89>='.' && LA5_89<='9')||(LA5_89>='?' && LA5_89<='Z')||(LA5_89>='^' && LA5_89<='z')||LA5_89=='|'||(LA5_89>='~' && LA5_89<='\uFFFF')) ) {s = 28;}

                        else s = 112;

                        if ( s>=0 ) return s;
                        break;
                    case 22 : 
                        int LA5_106 = input.LA(1);

                        s = -1;
                        if ( ((LA5_106>='\u0000' && LA5_106<='\b')||(LA5_106>='\u000B' && LA5_106<='\f')||(LA5_106>='\u000E' && LA5_106<='\u001F')||(LA5_106>='!' && LA5_106<='\'')||(LA5_106>='.' && LA5_106<='9')||(LA5_106>='?' && LA5_106<='Z')||(LA5_106>='^' && LA5_106<='z')||LA5_106=='|'||(LA5_106>='~' && LA5_106<='\uFFFF')) ) {s = 28;}

                        else s = 126;

                        if ( s>=0 ) return s;
                        break;
                    case 23 : 
                        int LA5_154 = input.LA(1);

                        s = -1;
                        if ( ((LA5_154>='\u0000' && LA5_154<='\b')||(LA5_154>='\u000B' && LA5_154<='\f')||(LA5_154>='\u000E' && LA5_154<='\u001F')||(LA5_154>='!' && LA5_154<='\'')||(LA5_154>='.' && LA5_154<='9')||(LA5_154>='?' && LA5_154<='Z')||(LA5_154>='^' && LA5_154<='z')||LA5_154=='|'||(LA5_154>='~' && LA5_154<='\uFFFF')) ) {s = 28;}

                        else s = 160;

                        if ( s>=0 ) return s;
                        break;
                    case 24 : 
                        int LA5_98 = input.LA(1);

                        s = -1;
                        if ( ((LA5_98>='\u0000' && LA5_98<='\b')||(LA5_98>='\u000B' && LA5_98<='\f')||(LA5_98>='\u000E' && LA5_98<='\u001F')||(LA5_98>='!' && LA5_98<='\'')||(LA5_98>='.' && LA5_98<='9')||(LA5_98>='?' && LA5_98<='Z')||(LA5_98>='^' && LA5_98<='z')||LA5_98=='|'||(LA5_98>='~' && LA5_98<='\uFFFF')) ) {s = 28;}

                        else s = 120;

                        if ( s>=0 ) return s;
                        break;
                    case 25 : 
                        int LA5_10 = input.LA(1);

                        s = -1;
                        if ( ((LA5_10>='\u0000' && LA5_10<='\b')||(LA5_10>='\u000B' && LA5_10<='\f')||(LA5_10>='\u000E' && LA5_10<='\u001F')||(LA5_10>='!' && LA5_10<='\'')||(LA5_10>='.' && LA5_10<='9')||(LA5_10>='?' && LA5_10<='Z')||(LA5_10>='^' && LA5_10<='z')||LA5_10=='|'||(LA5_10>='~' && LA5_10<='\uFFFF')) ) {s = 31;}

                        else s = 30;

                        if ( s>=0 ) return s;
                        break;
                    case 26 : 
                        int LA5_51 = input.LA(1);

                        s = -1;
                        if ( ((LA5_51>='\u0000' && LA5_51<='\b')||(LA5_51>='\u000B' && LA5_51<='\f')||(LA5_51>='\u000E' && LA5_51<='\u001F')||(LA5_51>='!' && LA5_51<='\'')||(LA5_51>='.' && LA5_51<='9')||(LA5_51>='?' && LA5_51<='Z')||(LA5_51>='^' && LA5_51<='z')||LA5_51=='|'||(LA5_51>='~' && LA5_51<='\uFFFF')) ) {s = 28;}

                        else s = 78;

                        if ( s>=0 ) return s;
                        break;
                    case 27 : 
                        int LA5_0 = input.LA(1);

                        s = -1;
                        if ( (LA5_0=='{') ) {s = 1;}

                        else if ( (LA5_0=='}') ) {s = 2;}

                        else if ( (LA5_0==';') ) {s = 3;}

                        else if ( (LA5_0=='(') ) {s = 4;}

                        else if ( (LA5_0==')') ) {s = 5;}

                        else if ( (LA5_0=='[') ) {s = 6;}

                        else if ( (LA5_0==']') ) {s = 7;}

                        else if ( (LA5_0==',') ) {s = 8;}

                        else if ( (LA5_0==':') ) {s = 9;}

                        else if ( (LA5_0=='%') ) {s = 10;}

                        else if ( (LA5_0=='\\') ) {s = 11;}

                        else if ( (LA5_0=='f') ) {s = 12;}

                        else if ( (LA5_0=='c') ) {s = 13;}

                        else if ( (LA5_0=='p') ) {s = 14;}

                        else if ( (LA5_0=='r') ) {s = 15;}

                        else if ( (LA5_0=='g') ) {s = 16;}

                        else if ( (LA5_0=='-') ) {s = 17;}

                        else if ( (LA5_0=='|') ) {s = 18;}

                        else if ( (LA5_0=='.') ) {s = 19;}

                        else if ( (LA5_0=='t') ) {s = 20;}

                        else if ( (LA5_0=='i') ) {s = 21;}

                        else if ( (LA5_0=='a') ) {s = 22;}

                        else if ( (LA5_0=='n') ) {s = 23;}

                        else if ( (LA5_0=='e') ) {s = 24;}

                        else if ( ((LA5_0>='*' && LA5_0<='+')||(LA5_0>='<' && LA5_0<='>')) ) {s = 25;}

                        else if ( (LA5_0=='b') ) {s = 26;}

                        else if ( (LA5_0=='s') ) {s = 27;}

                        else if ( ((LA5_0>='\u0000' && LA5_0<='\b')||(LA5_0>='\u000B' && LA5_0<='\f')||(LA5_0>='\u000E' && LA5_0<='\u001F')||(LA5_0>='!' && LA5_0<='$')||(LA5_0>='&' && LA5_0<='\'')||(LA5_0>='/' && LA5_0<='9')||(LA5_0>='?' && LA5_0<='Z')||(LA5_0>='^' && LA5_0<='`')||LA5_0=='d'||LA5_0=='h'||(LA5_0>='j' && LA5_0<='m')||LA5_0=='o'||LA5_0=='q'||(LA5_0>='u' && LA5_0<='z')||(LA5_0>='~' && LA5_0<='\uFFFF')) ) {s = 28;}

                        else if ( ((LA5_0>='\t' && LA5_0<='\n')||LA5_0=='\r'||LA5_0==' ') ) {s = 29;}

                        if ( s>=0 ) return s;
                        break;
                    case 28 : 
                        int LA5_151 = input.LA(1);

                        s = -1;
                        if ( ((LA5_151>='\u0000' && LA5_151<='\b')||(LA5_151>='\u000B' && LA5_151<='\f')||(LA5_151>='\u000E' && LA5_151<='\u001F')||(LA5_151>='!' && LA5_151<='\'')||(LA5_151>='.' && LA5_151<='9')||(LA5_151>='?' && LA5_151<='Z')||(LA5_151>='^' && LA5_151<='z')||LA5_151=='|'||(LA5_151>='~' && LA5_151<='\uFFFF')) ) {s = 28;}

                        else s = 158;

                        if ( s>=0 ) return s;
                        break;
                    case 29 : 
                        int LA5_79 = input.LA(1);

                        s = -1;
                        if ( ((LA5_79>='\u0000' && LA5_79<='\b')||(LA5_79>='\u000B' && LA5_79<='\f')||(LA5_79>='\u000E' && LA5_79<='\u001F')||(LA5_79>='!' && LA5_79<='\'')||(LA5_79>='.' && LA5_79<='9')||(LA5_79>='?' && LA5_79<='Z')||(LA5_79>='^' && LA5_79<='z')||LA5_79=='|'||(LA5_79>='~' && LA5_79<='\uFFFF')) ) {s = 28;}

                        else s = 103;

                        if ( s>=0 ) return s;
                        break;
                    case 30 : 
                        int LA5_117 = input.LA(1);

                        s = -1;
                        if ( ((LA5_117>='\u0000' && LA5_117<='\b')||(LA5_117>='\u000B' && LA5_117<='\f')||(LA5_117>='\u000E' && LA5_117<='\u001F')||(LA5_117>='!' && LA5_117<='\'')||(LA5_117>='.' && LA5_117<='9')||(LA5_117>='?' && LA5_117<='Z')||(LA5_117>='^' && LA5_117<='z')||LA5_117=='|'||(LA5_117>='~' && LA5_117<='\uFFFF')) ) {s = 28;}

                        else s = 134;

                        if ( s>=0 ) return s;
                        break;
                    case 31 : 
                        int LA5_129 = input.LA(1);

                        s = -1;
                        if ( ((LA5_129>='\u0000' && LA5_129<='\b')||(LA5_129>='\u000B' && LA5_129<='\f')||(LA5_129>='\u000E' && LA5_129<='\u001F')||(LA5_129>='!' && LA5_129<='\'')||(LA5_129>='.' && LA5_129<='9')||(LA5_129>='?' && LA5_129<='Z')||(LA5_129>='^' && LA5_129<='z')||LA5_129=='|'||(LA5_129>='~' && LA5_129<='\uFFFF')) ) {s = 28;}

                        else s = 141;

                        if ( s>=0 ) return s;
                        break;
            }
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 5, _s, input);
            error(nvae);
            throw nvae;
        }
    }
 

}