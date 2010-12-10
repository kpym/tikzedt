// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-12-09 21:28:12

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;


import org.antlr.runtime.tree.*;

public class simpletikzParser extends Parser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BEGIN", "END", "USETIKZLIB", "TIKZSTYLE", "TIKZSET", "NODE", "DRAW", "PATH", "FILL", "LPAR", "RPAR", "LBR", "RBR", "KOMMA", "EQU", "SEMIC", "COLON", "IM_PATH", "IM_NODE", "IM_COORD", "IM_NODENAME", "IM_NUMBERUNIT", "IM_PICTURE", "IM_DOCUMENT", "IM_SCOPE", "IM_STARTTAG", "IM_ENDTAG", "IM_OPTIONS", "IM_OPTION_STYLE", "IM_OPTION_KV", "IM_ID", "IM_TIKZSET", "IM_USETIKZLIB", "IM_STRING", "IM_STYLE", "ID", "FLOAT", "INT", "MATHSTRING", "EXPONENT", "COMMENT", "WS", "ESC_SEQ", "COMMAND", "'{'", "'}'", "'node'", "'at'", "'--'", "'edge'", "'->'", "'|-'", "'-|'", "'to'", "'grid'", "'rectangle'", "'+'", "'++'", "'cm'", "'in'", "'ex'", "'mm'", "'pt'", "'tikzpicture'", "'scope'", "'/.style'"
    };
    public static final int T__68=68;
    public static final int T__69=69;
    public static final int T__66=66;
    public static final int EXPONENT=43;
    public static final int T__67=67;
    public static final int T__64=64;
    public static final int IM_STARTTAG=29;
    public static final int T__65=65;
    public static final int T__62=62;
    public static final int T__63=63;
    public static final int RBR=16;
    public static final int IM_PATH=21;
    public static final int IM_ID=34;
    public static final int FLOAT=40;
    public static final int ID=39;
    public static final int T__61=61;
    public static final int T__60=60;
    public static final int EOF=-1;
    public static final int MATHSTRING=42;
    public static final int LBR=15;
    public static final int COMMAND=47;
    public static final int IM_ENDTAG=30;
    public static final int IM_USETIKZLIB=36;
    public static final int T__55=55;
    public static final int T__56=56;
    public static final int T__57=57;
    public static final int IM_DOCUMENT=27;
    public static final int T__58=58;
    public static final int ESC_SEQ=46;
    public static final int IM_STRING=37;
    public static final int T__51=51;
    public static final int T__52=52;
    public static final int T__53=53;
    public static final int LPAR=13;
    public static final int T__54=54;
    public static final int FILL=12;
    public static final int PATH=11;
    public static final int IM_TIKZSET=35;
    public static final int T__59=59;
    public static final int BEGIN=4;
    public static final int IM_OPTION_KV=33;
    public static final int COMMENT=44;
    public static final int T__50=50;
    public static final int IM_OPTIONS=31;
    public static final int IM_OPTION_STYLE=32;
    public static final int NODE=9;
    public static final int TIKZSTYLE=7;
    public static final int TIKZSET=8;
    public static final int T__48=48;
    public static final int T__49=49;
    public static final int IM_COORD=23;
    public static final int IM_PICTURE=26;
    public static final int INT=41;
    public static final int IM_NODE=22;
    public static final int USETIKZLIB=6;
    public static final int IM_STYLE=38;
    public static final int COLON=20;
    public static final int IM_SCOPE=28;
    public static final int IM_NUMBERUNIT=25;
    public static final int WS=45;
    public static final int KOMMA=17;
    public static final int EQU=18;
    public static final int RPAR=14;
    public static final int END=5;
    public static final int SEMIC=19;
    public static final int IM_NODENAME=24;
    public static final int DRAW=10;

    // delegates
    // delegators


        public simpletikzParser(TokenStream input) {
            this(input, new RecognizerSharedState());
        }
        public simpletikzParser(TokenStream input, RecognizerSharedState state) {
            super(input, state);
             
        }
        
    protected TreeAdaptor adaptor = new CommonTreeAdaptor();

    public void setTreeAdaptor(TreeAdaptor adaptor) {
        this.adaptor = adaptor;
    }
    public TreeAdaptor getTreeAdaptor() {
        return adaptor;
    }

    public String[] getTokenNames() { return simpletikzParser.tokenNames; }
    public String getGrammarFileName() { return "C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g"; }


    public static class tikzdocument_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzdocument"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:88:1: tikzdocument : ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture ) ;
    public final simpletikzParser.tikzdocument_return tikzdocument() throws RecognitionException {
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token wildcard5=null;
        simpletikzParser.dontcare_preamble_return dontcare_preamble1 = null;

        simpletikzParser.tikz_styleorset_return tikz_styleorset2 = null;

        simpletikzParser.otherbegin_return otherbegin3 = null;

        simpletikzParser.tikzpicture_return tikzpicture4 = null;


        Object wildcard5_tree=null;
        RewriteRuleSubtreeStream stream_dontcare_preamble=new RewriteRuleSubtreeStream(adaptor,"rule dontcare_preamble");
        RewriteRuleSubtreeStream stream_tikzpicture=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        RewriteRuleSubtreeStream stream_otherbegin=new RewriteRuleSubtreeStream(adaptor,"rule otherbegin");
        RewriteRuleSubtreeStream stream_tikz_styleorset=new RewriteRuleSubtreeStream(adaptor,"rule tikz_styleorset");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:2: ( ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:5: ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture ( . )*
            {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:5: ( dontcare_preamble | tikz_styleorset | otherbegin )*
            loop1:
            do {
                int alt1=4;
                switch ( input.LA(1) ) {
                case BEGIN:
                    {
                    int LA1_1 = input.LA(2);

                    if ( (LA1_1==48) ) {
                        int LA1_4 = input.LA(3);

                        if ( (LA1_4==ID) ) {
                            alt1=3;
                        }


                    }


                    }
                    break;
                case END:
                case USETIKZLIB:
                case NODE:
                case DRAW:
                case PATH:
                case FILL:
                case LPAR:
                case RPAR:
                case LBR:
                case RBR:
                case KOMMA:
                case EQU:
                case SEMIC:
                case COLON:
                case IM_PATH:
                case IM_NODE:
                case IM_COORD:
                case IM_NODENAME:
                case IM_NUMBERUNIT:
                case IM_PICTURE:
                case IM_DOCUMENT:
                case IM_SCOPE:
                case IM_STARTTAG:
                case IM_ENDTAG:
                case IM_OPTIONS:
                case IM_OPTION_STYLE:
                case IM_OPTION_KV:
                case IM_ID:
                case IM_TIKZSET:
                case IM_USETIKZLIB:
                case IM_STRING:
                case IM_STYLE:
                case ID:
                case FLOAT:
                case INT:
                case MATHSTRING:
                case EXPONENT:
                case COMMENT:
                case WS:
                case ESC_SEQ:
                case COMMAND:
                case 48:
                case 49:
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                case 58:
                case 59:
                case 60:
                case 61:
                case 62:
                case 63:
                case 64:
                case 65:
                case 66:
                case 67:
                case 68:
                case 69:
                    {
                    alt1=1;
                    }
                    break;
                case TIKZSTYLE:
                case TIKZSET:
                    {
                    alt1=2;
                    }
                    break;

                }

                switch (alt1) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:6: dontcare_preamble
            	    {
            	    pushFollow(FOLLOW_dontcare_preamble_in_tikzdocument321);
            	    dontcare_preamble1=dontcare_preamble();

            	    state._fsp--;

            	    stream_dontcare_preamble.add(dontcare_preamble1.getTree());

            	    }
            	    break;
            	case 2 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:26: tikz_styleorset
            	    {
            	    pushFollow(FOLLOW_tikz_styleorset_in_tikzdocument325);
            	    tikz_styleorset2=tikz_styleorset();

            	    state._fsp--;

            	    stream_tikz_styleorset.add(tikz_styleorset2.getTree());

            	    }
            	    break;
            	case 3 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:44: otherbegin
            	    {
            	    pushFollow(FOLLOW_otherbegin_in_tikzdocument329);
            	    otherbegin3=otherbegin();

            	    state._fsp--;

            	    stream_otherbegin.add(otherbegin3.getTree());

            	    }
            	    break;

            	default :
            	    break loop1;
                }
            } while (true);

            pushFollow(FOLLOW_tikzpicture_in_tikzdocument334);
            tikzpicture4=tikzpicture();

            state._fsp--;

            stream_tikzpicture.add(tikzpicture4.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:71: ( . )*
            loop2:
            do {
                int alt2=2;
                int LA2_0 = input.LA(1);

                if ( ((LA2_0>=BEGIN && LA2_0<=69)) ) {
                    alt2=1;
                }
                else if ( (LA2_0==EOF) ) {
                    alt2=2;
                }


                switch (alt2) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:71: .
            	    {
            	    wildcard5=(Token)input.LT(1);
            	    matchAny(input); 
            	    wildcard5_tree = (Object)adaptor.create(wildcard5);
            	    adaptor.addChild(root_0, wildcard5_tree);


            	    }
            	    break;

            	default :
            	    break loop2;
                }
            } while (true);



            // AST REWRITE
            // elements: tikz_styleorset, tikzpicture
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 89:75: -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:78: ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:92: ( tikz_styleorset )*
                while ( stream_tikz_styleorset.hasNext() ) {
                    adaptor.addChild(root_1, stream_tikz_styleorset.nextTree());

                }
                stream_tikz_styleorset.reset();
                adaptor.addChild(root_1, stream_tikzpicture.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikzdocument"

    public static class tikz_styleorset_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_styleorset"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:95:1: tikz_styleorset : ( tikz_style | tikz_set );
    public final simpletikzParser.tikz_styleorset_return tikz_styleorset() throws RecognitionException {
        simpletikzParser.tikz_styleorset_return retval = new simpletikzParser.tikz_styleorset_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikz_style_return tikz_style6 = null;

        simpletikzParser.tikz_set_return tikz_set7 = null;



        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:2: ( tikz_style | tikz_set )
            int alt3=2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0==TIKZSTYLE) ) {
                alt3=1;
            }
            else if ( (LA3_0==TIKZSET) ) {
                alt3=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 3, 0, input);

                throw nvae;
            }
            switch (alt3) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:4: tikz_style
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_tikz_style_in_tikz_styleorset364);
                    tikz_style6=tikz_style();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_style6.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:17: tikz_set
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_tikz_set_in_tikz_styleorset368);
                    tikz_set7=tikz_set();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_set7.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikz_styleorset"

    public static class dontcare_preamble_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "dontcare_preamble"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:99:1: dontcare_preamble : (~ ( BEGIN | TIKZSTYLE | TIKZSET ) )+ ;
    public final simpletikzParser.dontcare_preamble_return dontcare_preamble() throws RecognitionException {
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set8=null;

        Object set8_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:2: ( (~ ( BEGIN | TIKZSTYLE | TIKZSET ) )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:4: (~ ( BEGIN | TIKZSTYLE | TIKZSET ) )+
            {
            root_0 = (Object)adaptor.nil();

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:4: (~ ( BEGIN | TIKZSTYLE | TIKZSET ) )+
            int cnt4=0;
            loop4:
            do {
                int alt4=2;
                int LA4_0 = input.LA(1);

                if ( ((LA4_0>=END && LA4_0<=USETIKZLIB)||(LA4_0>=NODE && LA4_0<=69)) ) {
                    alt4=1;
                }


                switch (alt4) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:5: ~ ( BEGIN | TIKZSTYLE | TIKZSET )
            	    {
            	    set8=(Token)input.LT(1);
            	    if ( (input.LA(1)>=END && input.LA(1)<=USETIKZLIB)||(input.LA(1)>=NODE && input.LA(1)<=69) ) {
            	        input.consume();
            	        adaptor.addChild(root_0, (Object)adaptor.create(set8));
            	        state.errorRecovery=false;
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        throw mse;
            	    }


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

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "dontcare_preamble"

    public static class otherbegin_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "otherbegin"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:1: otherbegin : BEGIN '{' idd '}' ;
    public final simpletikzParser.otherbegin_return otherbegin() throws RecognitionException {
        simpletikzParser.otherbegin_return retval = new simpletikzParser.otherbegin_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGIN9=null;
        Token char_literal10=null;
        Token char_literal12=null;
        simpletikzParser.idd_return idd11 = null;


        Object BEGIN9_tree=null;
        Object char_literal10_tree=null;
        Object char_literal12_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:2: ( BEGIN '{' idd '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:4: BEGIN '{' idd '}'
            {
            root_0 = (Object)adaptor.nil();

            BEGIN9=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_otherbegin403); 
            BEGIN9_tree = (Object)adaptor.create(BEGIN9);
            adaptor.addChild(root_0, BEGIN9_tree);

            char_literal10=(Token)match(input,48,FOLLOW_48_in_otherbegin405); 
            char_literal10_tree = (Object)adaptor.create(char_literal10);
            adaptor.addChild(root_0, char_literal10_tree);

            pushFollow(FOLLOW_idd_in_otherbegin407);
            idd11=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd11.getTree());
            char_literal12=(Token)match(input,49,FOLLOW_49_in_otherbegin409); 
            char_literal12_tree = (Object)adaptor.create(char_literal12);
            adaptor.addChild(root_0, char_literal12_tree);


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "otherbegin"

    public static class tikz_style_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_style"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:106:1: tikz_style : TIKZSTYLE '{' idd '}' '=' tikz_options -> ^( IM_STYLE idd tikz_options ) ;
    public final simpletikzParser.tikz_style_return tikz_style() throws RecognitionException {
        simpletikzParser.tikz_style_return retval = new simpletikzParser.tikz_style_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token TIKZSTYLE13=null;
        Token char_literal14=null;
        Token char_literal16=null;
        Token char_literal17=null;
        simpletikzParser.idd_return idd15 = null;

        simpletikzParser.tikz_options_return tikz_options18 = null;


        Object TIKZSTYLE13_tree=null;
        Object char_literal14_tree=null;
        Object char_literal16_tree=null;
        Object char_literal17_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48=new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_TIKZSTYLE=new RewriteRuleTokenStream(adaptor,"token TIKZSTYLE");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:2: ( TIKZSTYLE '{' idd '}' '=' tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:4: TIKZSTYLE '{' idd '}' '=' tikz_options
            {
            TIKZSTYLE13=(Token)match(input,TIKZSTYLE,FOLLOW_TIKZSTYLE_in_tikz_style420);  
            stream_TIKZSTYLE.add(TIKZSTYLE13);

            char_literal14=(Token)match(input,48,FOLLOW_48_in_tikz_style422);  
            stream_48.add(char_literal14);

            pushFollow(FOLLOW_idd_in_tikz_style424);
            idd15=idd();

            state._fsp--;

            stream_idd.add(idd15.getTree());
            char_literal16=(Token)match(input,49,FOLLOW_49_in_tikz_style426);  
            stream_49.add(char_literal16);

            char_literal17=(Token)match(input,EQU,FOLLOW_EQU_in_tikz_style428);  
            stream_EQU.add(char_literal17);

            pushFollow(FOLLOW_tikz_options_in_tikz_style430);
            tikz_options18=tikz_options();

            state._fsp--;

            stream_tikz_options.add(tikz_options18.getTree());


            // AST REWRITE
            // elements: tikz_options, idd
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 107:43: -> ^( IM_STYLE idd tikz_options )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:46: ^( IM_STYLE idd tikz_options )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STYLE, "IM_STYLE"), root_1);

                adaptor.addChild(root_1, stream_idd.nextTree());
                adaptor.addChild(root_1, stream_tikz_options.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikz_style"

    public static class tikzpath_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpath"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:110:1: tikzpath : path_start tikzpathi path_end -> ^( IM_PATH path_start tikzpathi path_end ) ;
    public final simpletikzParser.tikzpath_return tikzpath() throws RecognitionException {
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_return path_start19 = null;

        simpletikzParser.tikzpathi_return tikzpathi20 = null;

        simpletikzParser.path_end_return path_end21 = null;


        RewriteRuleSubtreeStream stream_path_end=new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_path_start=new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:2: ( path_start tikzpathi path_end -> ^( IM_PATH path_start tikzpathi path_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:4: path_start tikzpathi path_end
            {
            pushFollow(FOLLOW_path_start_in_tikzpath452);
            path_start19=path_start();

            state._fsp--;

            stream_path_start.add(path_start19.getTree());
            pushFollow(FOLLOW_tikzpathi_in_tikzpath454);
            tikzpathi20=tikzpathi();

            state._fsp--;

            stream_tikzpathi.add(tikzpathi20.getTree());
            pushFollow(FOLLOW_path_end_in_tikzpath456);
            path_end21=path_end();

            state._fsp--;

            stream_path_end.add(path_end21.getTree());


            // AST REWRITE
            // elements: path_end, path_start, tikzpathi
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 111:34: -> ^( IM_PATH path_start tikzpathi path_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:37: ^( IM_PATH path_start tikzpathi path_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                adaptor.addChild(root_1, stream_path_start.nextTree());
                adaptor.addChild(root_1, stream_tikzpathi.nextTree());
                adaptor.addChild(root_1, stream_path_end.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikzpath"

    public static class path_end_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "path_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:1: path_end : SEMIC -> ^( IM_ENDTAG SEMIC ) ;
    public final simpletikzParser.path_end_return path_end() throws RecognitionException {
        simpletikzParser.path_end_return retval = new simpletikzParser.path_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token SEMIC22=null;

        Object SEMIC22_tree=null;
        RewriteRuleTokenStream stream_SEMIC=new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:114:2: ( SEMIC -> ^( IM_ENDTAG SEMIC ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:114:4: SEMIC
            {
            SEMIC22=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_path_end479);  
            stream_SEMIC.add(SEMIC22);



            // AST REWRITE
            // elements: SEMIC
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 114:10: -> ^( IM_ENDTAG SEMIC )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:114:13: ^( IM_ENDTAG SEMIC )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                adaptor.addChild(root_1, stream_SEMIC.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "path_end"

    public static class tikzpathi_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpathi"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:1: tikzpathi : coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* ;
    public final simpletikzParser.tikzpathi_return tikzpathi() throws RecognitionException {
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coordornode_return coordornode23 = null;

        simpletikzParser.coordornode_return coordornode24 = null;

        simpletikzParser.tikz_options_return tikz_options25 = null;

        simpletikzParser.edgeop_return edgeop26 = null;

        simpletikzParser.coordornode_return coordornode27 = null;



        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:2: ( coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:5: coordornode ( coordornode | ( tikz_options )? edgeop coordornode )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_coordornode_in_tikzpathi499);
            coordornode23=coordornode();

            state._fsp--;

            adaptor.addChild(root_0, coordornode23.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:17: ( coordornode | ( tikz_options )? edgeop coordornode )*
            loop6:
            do {
                int alt6=3;
                int LA6_0 = input.LA(1);

                if ( (LA6_0==LPAR||LA6_0==50||(LA6_0>=60 && LA6_0<=61)) ) {
                    alt6=1;
                }
                else if ( (LA6_0==LBR||(LA6_0>=52 && LA6_0<=59)) ) {
                    alt6=2;
                }


                switch (alt6) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:18: coordornode
            	    {
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi502);
            	    coordornode24=coordornode();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode24.getTree());

            	    }
            	    break;
            	case 2 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:32: ( tikz_options )? edgeop coordornode
            	    {
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:32: ( tikz_options )?
            	    int alt5=2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0==LBR) ) {
            	        alt5=1;
            	    }
            	    switch (alt5) {
            	        case 1 :
            	            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:32: tikz_options
            	            {
            	            pushFollow(FOLLOW_tikz_options_in_tikzpathi506);
            	            tikz_options25=tikz_options();

            	            state._fsp--;

            	            adaptor.addChild(root_0, tikz_options25.getTree());

            	            }
            	            break;

            	    }

            	    pushFollow(FOLLOW_edgeop_in_tikzpathi509);
            	    edgeop26=edgeop();

            	    state._fsp--;

            	    pushFollow(FOLLOW_coordornode_in_tikzpathi512);
            	    coordornode27=coordornode();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode27.getTree());

            	    }
            	    break;

            	default :
            	    break loop6;
                }
            } while (true);


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikzpathi"

    public static class coordornode_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coordornode"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:1: coordornode : ( coord | tikznodei );
    public final simpletikzParser.coordornode_return coordornode() throws RecognitionException {
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coord_return coord28 = null;

        simpletikzParser.tikznodei_return tikznodei29 = null;



        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:2: ( coord | tikznodei )
            int alt7=2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0==LPAR||(LA7_0>=60 && LA7_0<=61)) ) {
                alt7=1;
            }
            else if ( (LA7_0==50) ) {
                alt7=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 7, 0, input);

                throw nvae;
            }
            switch (alt7) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:4: coord
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_coord_in_coordornode527);
                    coord28=coord();

                    state._fsp--;

                    adaptor.addChild(root_0, coord28.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:12: tikznodei
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_tikznodei_in_coordornode531);
                    tikznodei29=tikznodei();

                    state._fsp--;

                    adaptor.addChild(root_0, tikznodei29.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "coordornode"

    public static class tikznodei_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznodei"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:1: tikznodei : 'node' tikznode ;
    public final simpletikzParser.tikznodei_return tikznodei() throws RecognitionException {
        simpletikzParser.tikznodei_return retval = new simpletikzParser.tikznodei_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal30=null;
        simpletikzParser.tikznode_return tikznode31 = null;


        Object string_literal30_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:2: ( 'node' tikznode )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:4: 'node' tikznode
            {
            root_0 = (Object)adaptor.nil();

            string_literal30=(Token)match(input,50,FOLLOW_50_in_tikznodei543); 
            pushFollow(FOLLOW_tikznode_in_tikznodei546);
            tikznode31=tikznode();

            state._fsp--;

            adaptor.addChild(root_0, tikznode31.getTree());

            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikznodei"

    public static class tikznodee_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznodee"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:1: tikznodee : node_start tikznode ( tikzpathi )? path_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end ) ;
    public final simpletikzParser.tikznodee_return tikznodee() throws RecognitionException {
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.node_start_return node_start32 = null;

        simpletikzParser.tikznode_return tikznode33 = null;

        simpletikzParser.tikzpathi_return tikzpathi34 = null;

        simpletikzParser.path_end_return path_end35 = null;


        RewriteRuleSubtreeStream stream_node_start=new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_path_end=new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_tikznode=new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:2: ( node_start tikznode ( tikzpathi )? path_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:4: node_start tikznode ( tikzpathi )? path_end
            {
            pushFollow(FOLLOW_node_start_in_tikznodee556);
            node_start32=node_start();

            state._fsp--;

            stream_node_start.add(node_start32.getTree());
            pushFollow(FOLLOW_tikznode_in_tikznodee558);
            tikznode33=tikznode();

            state._fsp--;

            stream_tikznode.add(tikznode33.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:24: ( tikzpathi )?
            int alt8=2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0==LPAR||LA8_0==50||(LA8_0>=60 && LA8_0<=61)) ) {
                alt8=1;
            }
            switch (alt8) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:24: tikzpathi
                    {
                    pushFollow(FOLLOW_tikzpathi_in_tikznodee560);
                    tikzpathi34=tikzpathi();

                    state._fsp--;

                    stream_tikzpathi.add(tikzpathi34.getTree());

                    }
                    break;

            }

            pushFollow(FOLLOW_path_end_in_tikznodee563);
            path_end35=path_end();

            state._fsp--;

            stream_path_end.add(path_end35.getTree());


            // AST REWRITE
            // elements: path_end, tikznode, tikzpathi, node_start
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 129:44: -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:47: ^( IM_PATH node_start tikznode ( tikzpathi )? path_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                adaptor.addChild(root_1, stream_node_start.nextTree());
                adaptor.addChild(root_1, stream_tikznode.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:77: ( tikzpathi )?
                if ( stream_tikzpathi.hasNext() ) {
                    adaptor.addChild(root_1, stream_tikzpathi.nextTree());

                }
                stream_tikzpathi.reset();
                adaptor.addChild(root_1, stream_path_end.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikznodee"

    public static class node_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "node_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public final simpletikzParser.node_start_return node_start() throws RecognitionException {
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token NODE36=null;

        Object NODE36_tree=null;
        RewriteRuleTokenStream stream_NODE=new RewriteRuleTokenStream(adaptor,"token NODE");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:4: NODE
            {
            NODE36=(Token)match(input,NODE,FOLLOW_NODE_in_node_start589);  
            stream_NODE.add(NODE36);



            // AST REWRITE
            // elements: NODE
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 132:9: -> ^( IM_STARTTAG NODE )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:12: ^( IM_STARTTAG NODE )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                adaptor.addChild(root_1, stream_NODE.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "node_start"

    public static class tikznode_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznode"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:1: tikznode : ( nodename )? ( 'at' coord )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ) ;
    public final simpletikzParser.tikznode_return tikznode() throws RecognitionException {
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal38=null;
        simpletikzParser.nodename_return nodename37 = null;

        simpletikzParser.coord_return coord39 = null;

        simpletikzParser.tikzstring_return tikzstring40 = null;


        Object string_literal38_tree=null;
        RewriteRuleTokenStream stream_51=new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleSubtreeStream stream_coord=new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_tikzstring=new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:2: ( ( nodename )? ( 'at' coord )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:4: ( nodename )? ( 'at' coord )? tikzstring
            {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:4: ( nodename )?
            int alt9=2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0==LPAR) ) {
                alt9=1;
            }
            switch (alt9) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:4: nodename
                    {
                    pushFollow(FOLLOW_nodename_in_tikznode607);
                    nodename37=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename37.getTree());

                    }
                    break;

            }

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:14: ( 'at' coord )?
            int alt10=2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0==51) ) {
                alt10=1;
            }
            switch (alt10) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:15: 'at' coord
                    {
                    string_literal38=(Token)match(input,51,FOLLOW_51_in_tikznode611);  
                    stream_51.add(string_literal38);

                    pushFollow(FOLLOW_coord_in_tikznode613);
                    coord39=coord();

                    state._fsp--;

                    stream_coord.add(coord39.getTree());

                    }
                    break;

            }

            pushFollow(FOLLOW_tikzstring_in_tikznode617);
            tikzstring40=tikzstring();

            state._fsp--;

            stream_tikzstring.add(tikzstring40.getTree());


            // AST REWRITE
            // elements: coord, nodename, tikzstring
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 135:40: -> ^( IM_NODE ( nodename )? ( coord )? tikzstring )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:43: ^( IM_NODE ( nodename )? ( coord )? tikzstring )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODE, "IM_NODE"), root_1);

                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:53: ( nodename )?
                if ( stream_nodename.hasNext() ) {
                    adaptor.addChild(root_1, stream_nodename.nextTree());

                }
                stream_nodename.reset();
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:63: ( coord )?
                if ( stream_coord.hasNext() ) {
                    adaptor.addChild(root_1, stream_coord.nextTree());

                }
                stream_coord.reset();
                adaptor.addChild(root_1, stream_tikzstring.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikznode"

    public static class edgeop_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "edgeop"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:1: edgeop : ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' | 'grid' | 'rectangle' );
    public final simpletikzParser.edgeop_return edgeop() throws RecognitionException {
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set41=null;

        Object set41_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:2: ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' | 'grid' | 'rectangle' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            set41=(Token)input.LT(1);
            if ( (input.LA(1)>=52 && input.LA(1)<=59) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set41));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                throw mse;
            }


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "edgeop"

    public static class nodename_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "nodename"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:1: nodename : lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) ;
    public final simpletikzParser.nodename_return nodename() throws RecognitionException {
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token id=null;
        Token RPAR42=null;

        Object lc_tree=null;
        Object id_tree=null;
        Object RPAR42_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:2: (lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:4: lc= LPAR id= ID RPAR
            {
            lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_nodename690);  
            stream_LPAR.add(lc);

            id=(Token)match(input,ID,FOLLOW_ID_in_nodename694);  
            stream_ID.add(id);

            RPAR42=(Token)match(input,RPAR,FOLLOW_RPAR_in_nodename696);  
            stream_RPAR.add(RPAR42);



            // AST REWRITE
            // elements: id
            // token labels: id
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleTokenStream stream_id=new RewriteRuleTokenStream(adaptor,"token id",id);
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 143:24: -> ^( IM_NODENAME[$lc] $id)
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:27: ^( IM_NODENAME[$lc] $id)
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODENAME, lc), root_1);

                adaptor.addChild(root_1, stream_id.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "nodename"

    public static class coord_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coord"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) );
    public final simpletikzParser.coord_return coord() throws RecognitionException {
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token KOMMA46=null;
        Token RPAR48=null;
        simpletikzParser.nodename_return nodename43 = null;

        simpletikzParser.coord_modifier_return coord_modifier44 = null;

        simpletikzParser.numberunit_return numberunit45 = null;

        simpletikzParser.numberunit_return numberunit47 = null;


        Object lc_tree=null;
        Object KOMMA46_tree=null;
        Object RPAR48_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_numberunit=new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier=new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) )
            int alt12=2;
            int LA12_0 = input.LA(1);

            if ( (LA12_0==LPAR) ) {
                int LA12_1 = input.LA(2);

                if ( (LA12_1==ID) ) {
                    alt12=1;
                }
                else if ( ((LA12_1>=FLOAT && LA12_1<=INT)) ) {
                    alt12=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 12, 1, input);

                    throw nvae;
                }
            }
            else if ( ((LA12_0>=60 && LA12_0<=61)) ) {
                alt12=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 12, 0, input);

                throw nvae;
            }
            switch (alt12) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:6: nodename
                    {
                    pushFollow(FOLLOW_nodename_in_coord721);
                    nodename43=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename43.getTree());


                    // AST REWRITE
                    // elements: nodename
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 147:23: -> ^( IM_COORD nodename )
                    {
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:26: ^( IM_COORD nodename )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, "IM_COORD"), root_1);

                        adaptor.addChild(root_1, stream_nodename.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    {
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:7: ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR
                    {
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:7: ( coord_modifier )?
                    int alt11=2;
                    int LA11_0 = input.LA(1);

                    if ( ((LA11_0>=60 && LA11_0<=61)) ) {
                        alt11=1;
                    }
                    switch (alt11) {
                        case 1 :
                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:7: coord_modifier
                            {
                            pushFollow(FOLLOW_coord_modifier_in_coord745);
                            coord_modifier44=coord_modifier();

                            state._fsp--;

                            stream_coord_modifier.add(coord_modifier44.getTree());

                            }
                            break;

                    }

                    lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_coord750);  
                    stream_LPAR.add(lc);

                    pushFollow(FOLLOW_numberunit_in_coord752);
                    numberunit45=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit45.getTree());
                    KOMMA46=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_coord754);  
                    stream_KOMMA.add(KOMMA46);

                    pushFollow(FOLLOW_numberunit_in_coord756);
                    numberunit47=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit47.getTree());
                    RPAR48=(Token)match(input,RPAR,FOLLOW_RPAR_in_coord758);  
                    stream_RPAR.add(RPAR48);


                    }



                    // AST REWRITE
                    // elements: coord_modifier, numberunit
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 148:66: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    {
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:69: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, lc), root_1);

                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:85: ( coord_modifier )?
                        if ( stream_coord_modifier.hasNext() ) {
                            adaptor.addChild(root_1, stream_coord_modifier.nextTree());

                        }
                        stream_coord_modifier.reset();
                        if ( !(stream_numberunit.hasNext()) ) {
                            throw new RewriteEarlyExitException();
                        }
                        while ( stream_numberunit.hasNext() ) {
                            adaptor.addChild(root_1, stream_numberunit.nextTree());

                        }
                        stream_numberunit.reset();

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "coord"

    public static class coord_modifier_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coord_modifier"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:1: coord_modifier : ( '+' | '++' );
    public final simpletikzParser.coord_modifier_return coord_modifier() throws RecognitionException {
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set49=null;

        Object set49_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:2: ( '+' | '++' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            set49=(Token)input.LT(1);
            if ( (input.LA(1)>=60 && input.LA(1)<=61) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set49));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                throw mse;
            }


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "coord_modifier"

    public static class numberunit_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "numberunit"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public final simpletikzParser.numberunit_return numberunit() throws RecognitionException {
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.number_return number50 = null;

        simpletikzParser.unit_return unit51 = null;


        RewriteRuleSubtreeStream stream_unit=new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:4: number ( unit )?
            {
            pushFollow(FOLLOW_number_in_numberunit800);
            number50=number();

            state._fsp--;

            stream_number.add(number50.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:11: ( unit )?
            int alt13=2;
            int LA13_0 = input.LA(1);

            if ( ((LA13_0>=62 && LA13_0<=66)) ) {
                alt13=1;
            }
            switch (alt13) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:11: unit
                    {
                    pushFollow(FOLLOW_unit_in_numberunit802);
                    unit51=unit();

                    state._fsp--;

                    stream_unit.add(unit51.getTree());

                    }
                    break;

            }



            // AST REWRITE
            // elements: number, unit
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 156:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:20: ^( IM_NUMBERUNIT number ( unit )? )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

                adaptor.addChild(root_1, stream_number.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:43: ( unit )?
                if ( stream_unit.hasNext() ) {
                    adaptor.addChild(root_1, stream_unit.nextTree());

                }
                stream_unit.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "numberunit"

    public static class number_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "number"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:1: number : ( FLOAT | INT ) ;
    public final simpletikzParser.number_return number() throws RecognitionException {
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set52=null;

        Object set52_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:159:2: ( ( FLOAT | INT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:159:4: ( FLOAT | INT )
            {
            root_0 = (Object)adaptor.nil();

            set52=(Token)input.LT(1);
            if ( (input.LA(1)>=FLOAT && input.LA(1)<=INT) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set52));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                throw mse;
            }


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "number"

    public static class unit_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "unit"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' );
    public final simpletikzParser.unit_return unit() throws RecognitionException {
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set53=null;

        Object set53_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            set53=(Token)input.LT(1);
            if ( (input.LA(1)>=62 && input.LA(1)<=66) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set53));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                throw mse;
            }


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "unit"

    public static class path_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "path_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public final simpletikzParser.path_start_return path_start() throws RecognitionException {
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag54 = null;


        RewriteRuleSubtreeStream stream_path_start_tag=new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:4: path_start_tag
            {
            pushFollow(FOLLOW_path_start_tag_in_path_start869);
            path_start_tag54=path_start_tag();

            state._fsp--;

            stream_path_start_tag.add(path_start_tag54.getTree());


            // AST REWRITE
            // elements: path_start_tag
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 166:19: -> ^( IM_STARTTAG path_start_tag )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:22: ^( IM_STARTTAG path_start_tag )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                adaptor.addChild(root_1, stream_path_start_tag.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "path_start"

    public static class path_start_tag_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "path_start_tag"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:1: path_start_tag : ( DRAW | FILL | PATH );
    public final simpletikzParser.path_start_tag_return path_start_tag() throws RecognitionException {
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set55=null;

        Object set55_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:2: ( DRAW | FILL | PATH )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            set55=(Token)input.LT(1);
            if ( (input.LA(1)>=DRAW && input.LA(1)<=FILL) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set55));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                throw mse;
            }


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "path_start_tag"

    public static class tikzpicture_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpicture"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public final simpletikzParser.tikzpicture_return tikzpicture() throws RecognitionException {
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start56 = null;

        simpletikzParser.tikz_options_return tikz_options57 = null;

        simpletikzParser.tikzbody_return tikzbody58 = null;

        simpletikzParser.tikzpicture_end_return tikzpicture_end59 = null;


        RewriteRuleSubtreeStream stream_tikzpicture_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            pushFollow(FOLLOW_tikzpicture_start_in_tikzpicture908);
            tikzpicture_start56=tikzpicture_start();

            state._fsp--;

            stream_tikzpicture_start.add(tikzpicture_start56.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:23: ( tikz_options )?
            int alt14=2;
            alt14 = dfa14.predict(input);
            switch (alt14) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:23: tikz_options
                    {
                    pushFollow(FOLLOW_tikz_options_in_tikzpicture910);
                    tikz_options57=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options57.getTree());

                    }
                    break;

            }

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:37: ( tikzbody )?
            int alt15=2;
            int LA15_0 = input.LA(1);

            if ( (LA15_0==BEGIN||(LA15_0>=USETIKZLIB && LA15_0<=69)) ) {
                alt15=1;
            }
            else if ( (LA15_0==END) ) {
                int LA15_2 = input.LA(2);

                if ( (LA15_2==48) ) {
                    int LA15_3 = input.LA(3);

                    if ( (LA15_3==ID) ) {
                        alt15=1;
                    }
                }
            }
            switch (alt15) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:37: tikzbody
                    {
                    pushFollow(FOLLOW_tikzbody_in_tikzpicture913);
                    tikzbody58=tikzbody();

                    state._fsp--;

                    stream_tikzbody.add(tikzbody58.getTree());

                    }
                    break;

            }

            pushFollow(FOLLOW_tikzpicture_end_in_tikzpicture916);
            tikzpicture_end59=tikzpicture_end();

            state._fsp--;

            stream_tikzpicture_end.add(tikzpicture_end59.getTree());


            // AST REWRITE
            // elements: tikzpicture_end, tikzpicture_start, tikz_options, tikzbody
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 173:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PICTURE, "IM_PICTURE"), root_1);

                adaptor.addChild(root_1, stream_tikzpicture_start.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:98: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:112: ( tikzbody )?
                if ( stream_tikzbody.hasNext() ) {
                    adaptor.addChild(root_1, stream_tikzbody.nextTree());

                }
                stream_tikzbody.reset();
                adaptor.addChild(root_1, stream_tikzpicture_end.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikzpicture"

    public static class tikzpicture_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpicture_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:1: tikzpicture_start : BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public final simpletikzParser.tikzpicture_start_return tikzpicture_start() throws RecognitionException {
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGIN60=null;
        Token char_literal61=null;
        Token string_literal62=null;
        Token char_literal63=null;

        Object BEGIN60_tree=null;
        Object char_literal61_tree=null;
        Object string_literal62_tree=null;
        Object char_literal63_tree=null;
        RewriteRuleTokenStream stream_67=new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48=new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_BEGIN=new RewriteRuleTokenStream(adaptor,"token BEGIN");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:2: ( BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:4: BEGIN '{' 'tikzpicture' '}'
            {
            BEGIN60=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_tikzpicture_start943);  
            stream_BEGIN.add(BEGIN60);

            char_literal61=(Token)match(input,48,FOLLOW_48_in_tikzpicture_start945);  
            stream_48.add(char_literal61);

            string_literal62=(Token)match(input,67,FOLLOW_67_in_tikzpicture_start947);  
            stream_67.add(string_literal62);

            char_literal63=(Token)match(input,49,FOLLOW_49_in_tikzpicture_start949);  
            stream_49.add(char_literal63);



            // AST REWRITE
            // elements: BEGIN
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 176:32: -> ^( IM_STARTTAG BEGIN )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:35: ^( IM_STARTTAG BEGIN )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                adaptor.addChild(root_1, stream_BEGIN.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikzpicture_start"

    public static class tikzpicture_end_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpicture_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:178:1: tikzpicture_end : END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) ;
    public final simpletikzParser.tikzpicture_end_return tikzpicture_end() throws RecognitionException {
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token END64=null;
        Token char_literal65=null;
        Token string_literal66=null;
        Token char_literal67=null;

        Object END64_tree=null;
        Object char_literal65_tree=null;
        Object string_literal66_tree=null;
        Object char_literal67_tree=null;
        RewriteRuleTokenStream stream_67=new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48=new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_END=new RewriteRuleTokenStream(adaptor,"token END");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:2: ( END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:4: END '{' 'tikzpicture' '}'
            {
            END64=(Token)match(input,END,FOLLOW_END_in_tikzpicture_end967);  
            stream_END.add(END64);

            char_literal65=(Token)match(input,48,FOLLOW_48_in_tikzpicture_end969);  
            stream_48.add(char_literal65);

            string_literal66=(Token)match(input,67,FOLLOW_67_in_tikzpicture_end971);  
            stream_67.add(string_literal66);

            char_literal67=(Token)match(input,49,FOLLOW_49_in_tikzpicture_end973);  
            stream_49.add(char_literal67);



            // AST REWRITE
            // elements: END
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 179:30: -> ^( IM_ENDTAG END )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:33: ^( IM_ENDTAG END )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                adaptor.addChild(root_1, stream_END.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikzpicture_end"

    public static class tikzbody_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzbody"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:1: tikzbody : ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )+ ;
    public final simpletikzParser.tikzbody_return tikzbody() throws RecognitionException {
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope68 = null;

        simpletikzParser.tikzpath_return tikzpath69 = null;

        simpletikzParser.tikznodee_return tikznodee70 = null;

        simpletikzParser.dontcare_body_return dontcare_body71 = null;

        simpletikzParser.tikz_set_return tikz_set72 = null;

        simpletikzParser.tikz_style_return tikz_style73 = null;

        simpletikzParser.otherbegin_return otherbegin74 = null;

        simpletikzParser.otherend_return otherend75 = null;



        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:2: ( ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:4: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )+
            {
            root_0 = (Object)adaptor.nil();

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:4: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )+
            int cnt16=0;
            loop16:
            do {
                int alt16=9;
                alt16 = dfa16.predict(input);
                switch (alt16) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:6: tikzscope
            	    {
            	    pushFollow(FOLLOW_tikzscope_in_tikzbody993);
            	    tikzscope68=tikzscope();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzscope68.getTree());

            	    }
            	    break;
            	case 2 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:18: tikzpath
            	    {
            	    pushFollow(FOLLOW_tikzpath_in_tikzbody997);
            	    tikzpath69=tikzpath();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzpath69.getTree());

            	    }
            	    break;
            	case 3 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:29: tikznodee
            	    {
            	    pushFollow(FOLLOW_tikznodee_in_tikzbody1001);
            	    tikznodee70=tikznodee();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikznodee70.getTree());

            	    }
            	    break;
            	case 4 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:41: dontcare_body
            	    {
            	    pushFollow(FOLLOW_dontcare_body_in_tikzbody1005);
            	    dontcare_body71=dontcare_body();

            	    state._fsp--;

            	    adaptor.addChild(root_0, dontcare_body71.getTree());

            	    }
            	    break;
            	case 5 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:57: tikz_set
            	    {
            	    pushFollow(FOLLOW_tikz_set_in_tikzbody1009);
            	    tikz_set72=tikz_set();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikz_set72.getTree());

            	    }
            	    break;
            	case 6 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:68: tikz_style
            	    {
            	    pushFollow(FOLLOW_tikz_style_in_tikzbody1013);
            	    tikz_style73=tikz_style();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikz_style73.getTree());

            	    }
            	    break;
            	case 7 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:81: otherbegin
            	    {
            	    pushFollow(FOLLOW_otherbegin_in_tikzbody1017);
            	    otherbegin74=otherbegin();

            	    state._fsp--;

            	    adaptor.addChild(root_0, otherbegin74.getTree());

            	    }
            	    break;
            	case 8 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:93: otherend
            	    {
            	    pushFollow(FOLLOW_otherend_in_tikzbody1020);
            	    otherend75=otherend();

            	    state._fsp--;

            	    adaptor.addChild(root_0, otherend75.getTree());

            	    }
            	    break;

            	default :
            	    if ( cnt16 >= 1 ) break loop16;
                        EarlyExitException eee =
                            new EarlyExitException(16, input);
                        throw eee;
                }
                cnt16++;
            } while (true);


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikzbody"

    public static class dontcare_body_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "dontcare_body"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:1: dontcare_body : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )+ ;
    public final simpletikzParser.dontcare_body_return dontcare_body() throws RecognitionException {
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set76=null;

        Object set76_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:185:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )+ )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:185:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )+
            {
            root_0 = (Object)adaptor.nil();

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:185:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )+
            int cnt17=0;
            loop17:
            do {
                int alt17=2;
                int LA17_0 = input.LA(1);

                if ( (LA17_0==USETIKZLIB||(LA17_0>=LPAR && LA17_0<=69)) ) {
                    alt17=1;
                }


                switch (alt17) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:185:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET )
            	    {
            	    set76=(Token)input.LT(1);
            	    if ( input.LA(1)==USETIKZLIB||(input.LA(1)>=LPAR && input.LA(1)<=69) ) {
            	        input.consume();
            	        adaptor.addChild(root_0, (Object)adaptor.create(set76));
            	        state.errorRecovery=false;
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        throw mse;
            	    }


            	    }
            	    break;

            	default :
            	    if ( cnt17 >= 1 ) break loop17;
                        EarlyExitException eee =
                            new EarlyExitException(17, input);
                        throw eee;
                }
                cnt17++;
            } while (true);


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "dontcare_body"

    public static class otherend_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "otherend"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:1: otherend : END '{' idd '}' ;
    public final simpletikzParser.otherend_return otherend() throws RecognitionException {
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token END77=null;
        Token char_literal78=null;
        Token char_literal80=null;
        simpletikzParser.idd_return idd79 = null;


        Object END77_tree=null;
        Object char_literal78_tree=null;
        Object char_literal80_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:2: ( END '{' idd '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:4: END '{' idd '}'
            {
            root_0 = (Object)adaptor.nil();

            END77=(Token)match(input,END,FOLLOW_END_in_otherend1080); 
            END77_tree = (Object)adaptor.create(END77);
            adaptor.addChild(root_0, END77_tree);

            char_literal78=(Token)match(input,48,FOLLOW_48_in_otherend1082); 
            char_literal78_tree = (Object)adaptor.create(char_literal78);
            adaptor.addChild(root_0, char_literal78_tree);

            pushFollow(FOLLOW_idd_in_otherend1084);
            idd79=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd79.getTree());
            char_literal80=(Token)match(input,49,FOLLOW_49_in_otherend1086); 
            char_literal80_tree = (Object)adaptor.create(char_literal80);
            adaptor.addChild(root_0, char_literal80_tree);


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "otherend"

    public static class tikzscope_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzscope"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:194:1: tikzscope : tikzscope_start ( tikz_options )? tikzbody tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public final simpletikzParser.tikzscope_return tikzscope() throws RecognitionException {
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start81 = null;

        simpletikzParser.tikz_options_return tikz_options82 = null;

        simpletikzParser.tikzbody_return tikzbody83 = null;

        simpletikzParser.tikzscope_end_return tikzscope_end84 = null;


        RewriteRuleSubtreeStream stream_tikzscope_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:2: ( tikzscope_start ( tikz_options )? tikzbody tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:4: tikzscope_start ( tikz_options )? tikzbody tikzscope_end
            {
            pushFollow(FOLLOW_tikzscope_start_in_tikzscope1100);
            tikzscope_start81=tikzscope_start();

            state._fsp--;

            stream_tikzscope_start.add(tikzscope_start81.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:20: ( tikz_options )?
            int alt18=2;
            alt18 = dfa18.predict(input);
            switch (alt18) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:20: tikz_options
                    {
                    pushFollow(FOLLOW_tikz_options_in_tikzscope1102);
                    tikz_options82=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options82.getTree());

                    }
                    break;

            }

            pushFollow(FOLLOW_tikzbody_in_tikzscope1105);
            tikzbody83=tikzbody();

            state._fsp--;

            stream_tikzbody.add(tikzbody83.getTree());
            pushFollow(FOLLOW_tikzscope_end_in_tikzscope1107);
            tikzscope_end84=tikzscope_end();

            state._fsp--;

            stream_tikzscope_end.add(tikzscope_end84.getTree());


            // AST REWRITE
            // elements: tikzbody, tikzscope_end, tikzscope_start, tikz_options
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 195:58: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:61: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_SCOPE, "IM_SCOPE"), root_1);

                adaptor.addChild(root_1, stream_tikzscope_start.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:88: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                adaptor.addChild(root_1, stream_tikzbody.nextTree());
                adaptor.addChild(root_1, stream_tikzscope_end.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikzscope"

    public static class tikzscope_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzscope_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:197:1: tikzscope_start : BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public final simpletikzParser.tikzscope_start_return tikzscope_start() throws RecognitionException {
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGIN85=null;
        Token char_literal86=null;
        Token string_literal87=null;
        Token char_literal88=null;

        Object BEGIN85_tree=null;
        Object char_literal86_tree=null;
        Object string_literal87_tree=null;
        Object char_literal88_tree=null;
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48=new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_68=new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_BEGIN=new RewriteRuleTokenStream(adaptor,"token BEGIN");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:2: ( BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:4: BEGIN '{' 'scope' '}'
            {
            BEGIN85=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_tikzscope_start1133);  
            stream_BEGIN.add(BEGIN85);

            char_literal86=(Token)match(input,48,FOLLOW_48_in_tikzscope_start1135);  
            stream_48.add(char_literal86);

            string_literal87=(Token)match(input,68,FOLLOW_68_in_tikzscope_start1137);  
            stream_68.add(string_literal87);

            char_literal88=(Token)match(input,49,FOLLOW_49_in_tikzscope_start1139);  
            stream_49.add(char_literal88);



            // AST REWRITE
            // elements: BEGIN
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 198:26: -> ^( IM_STARTTAG BEGIN )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:29: ^( IM_STARTTAG BEGIN )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                adaptor.addChild(root_1, stream_BEGIN.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikzscope_start"

    public static class tikzscope_end_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzscope_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:200:1: tikzscope_end : END '{' 'scope' '}' -> ^( IM_ENDTAG END ) ;
    public final simpletikzParser.tikzscope_end_return tikzscope_end() throws RecognitionException {
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token END89=null;
        Token char_literal90=null;
        Token string_literal91=null;
        Token char_literal92=null;

        Object END89_tree=null;
        Object char_literal90_tree=null;
        Object string_literal91_tree=null;
        Object char_literal92_tree=null;
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48=new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_68=new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_END=new RewriteRuleTokenStream(adaptor,"token END");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:2: ( END '{' 'scope' '}' -> ^( IM_ENDTAG END ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:4: END '{' 'scope' '}'
            {
            END89=(Token)match(input,END,FOLLOW_END_in_tikzscope_end1157);  
            stream_END.add(END89);

            char_literal90=(Token)match(input,48,FOLLOW_48_in_tikzscope_end1159);  
            stream_48.add(char_literal90);

            string_literal91=(Token)match(input,68,FOLLOW_68_in_tikzscope_end1161);  
            stream_68.add(string_literal91);

            char_literal92=(Token)match(input,49,FOLLOW_49_in_tikzscope_end1163);  
            stream_49.add(char_literal92);



            // AST REWRITE
            // elements: END
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 201:24: -> ^( IM_ENDTAG END )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:27: ^( IM_ENDTAG END )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                adaptor.addChild(root_1, stream_END.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikzscope_end"

    public static class tikz_options_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_options"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:204:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
    public final simpletikzParser.tikz_options_return tikz_options() throws RecognitionException {
        simpletikzParser.tikz_options_return retval = new simpletikzParser.tikz_options_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal95=null;
        Token char_literal97=null;
        simpletikzParser.squarebr_start_return squarebr_start93 = null;

        simpletikzParser.option_return option94 = null;

        simpletikzParser.option_return option96 = null;

        simpletikzParser.squarebr_end_return squarebr_end98 = null;


        Object char_literal95_tree=null;
        Object char_literal97_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_squarebr_start=new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_squarebr_end=new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            pushFollow(FOLLOW_squarebr_start_in_tikz_options1183);
            squarebr_start93=squarebr_start();

            state._fsp--;

            stream_squarebr_start.add(squarebr_start93.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:20: ( option ( ',' option )* ( ',' )? )?
            int alt21=2;
            int LA21_0 = input.LA(1);

            if ( (LA21_0==ID) ) {
                alt21=1;
            }
            switch (alt21) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:21: option ( ',' option )* ( ',' )?
                    {
                    pushFollow(FOLLOW_option_in_tikz_options1186);
                    option94=option();

                    state._fsp--;

                    stream_option.add(option94.getTree());
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:28: ( ',' option )*
                    loop19:
                    do {
                        int alt19=2;
                        int LA19_0 = input.LA(1);

                        if ( (LA19_0==KOMMA) ) {
                            int LA19_1 = input.LA(2);

                            if ( (LA19_1==ID) ) {
                                alt19=1;
                            }


                        }


                        switch (alt19) {
                    	case 1 :
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:29: ',' option
                    	    {
                    	    char_literal95=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options1189);  
                    	    stream_KOMMA.add(char_literal95);

                    	    pushFollow(FOLLOW_option_in_tikz_options1191);
                    	    option96=option();

                    	    state._fsp--;

                    	    stream_option.add(option96.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop19;
                        }
                    } while (true);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:42: ( ',' )?
                    int alt20=2;
                    int LA20_0 = input.LA(1);

                    if ( (LA20_0==KOMMA) ) {
                        alt20=1;
                    }
                    switch (alt20) {
                        case 1 :
                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:42: ','
                            {
                            char_literal97=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options1195);  
                            stream_KOMMA.add(char_literal97);


                            }
                            break;

                    }


                    }
                    break;

            }

            pushFollow(FOLLOW_squarebr_end_in_tikz_options1200);
            squarebr_end98=squarebr_end();

            state._fsp--;

            stream_squarebr_end.add(squarebr_end98.getTree());


            // AST REWRITE
            // elements: squarebr_start, squarebr_end, option
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 205:63: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTIONS, "IM_OPTIONS"), root_1);

                adaptor.addChild(root_1, stream_squarebr_start.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:94: ( option )*
                while ( stream_option.hasNext() ) {
                    adaptor.addChild(root_1, stream_option.nextTree());

                }
                stream_option.reset();
                adaptor.addChild(root_1, stream_squarebr_end.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikz_options"

    public static class squarebr_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "squarebr_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:1: squarebr_start : LBR -> ^( IM_STARTTAG LBR ) ;
    public final simpletikzParser.squarebr_start_return squarebr_start() throws RecognitionException {
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LBR99=null;

        Object LBR99_tree=null;
        RewriteRuleTokenStream stream_LBR=new RewriteRuleTokenStream(adaptor,"token LBR");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:2: ( LBR -> ^( IM_STARTTAG LBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:4: LBR
            {
            LBR99=(Token)match(input,LBR,FOLLOW_LBR_in_squarebr_start1224);  
            stream_LBR.add(LBR99);



            // AST REWRITE
            // elements: LBR
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 208:8: -> ^( IM_STARTTAG LBR )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:11: ^( IM_STARTTAG LBR )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                adaptor.addChild(root_1, stream_LBR.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "squarebr_start"

    public static class squarebr_end_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "squarebr_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:210:1: squarebr_end : RBR -> ^( IM_ENDTAG RBR ) ;
    public final simpletikzParser.squarebr_end_return squarebr_end() throws RecognitionException {
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token RBR100=null;

        Object RBR100_tree=null;
        RewriteRuleTokenStream stream_RBR=new RewriteRuleTokenStream(adaptor,"token RBR");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:211:2: ( RBR -> ^( IM_ENDTAG RBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:211:4: RBR
            {
            RBR100=(Token)match(input,RBR,FOLLOW_RBR_in_squarebr_end1242);  
            stream_RBR.add(RBR100);



            // AST REWRITE
            // elements: RBR
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 211:8: -> ^( IM_ENDTAG RBR )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:211:11: ^( IM_ENDTAG RBR )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                adaptor.addChild(root_1, stream_RBR.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "squarebr_end"

    public static class tikz_set_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_set"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:1: tikz_set : tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public final simpletikzParser.tikz_set_return tikz_set() throws RecognitionException {
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal103=null;
        simpletikzParser.tikz_set_start_return tikz_set_start101 = null;

        simpletikzParser.option_return option102 = null;

        simpletikzParser.option_return option104 = null;

        simpletikzParser.roundbr_end_return roundbr_end105 = null;


        Object char_literal103_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_tikz_set_start=new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end=new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:2: ( tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:5: tikz_set_start ( option ( ',' option )* )? roundbr_end
            {
            pushFollow(FOLLOW_tikz_set_start_in_tikz_set1264);
            tikz_set_start101=tikz_set_start();

            state._fsp--;

            stream_tikz_set_start.add(tikz_set_start101.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:20: ( option ( ',' option )* )?
            int alt23=2;
            int LA23_0 = input.LA(1);

            if ( (LA23_0==ID) ) {
                alt23=1;
            }
            switch (alt23) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:21: option ( ',' option )*
                    {
                    pushFollow(FOLLOW_option_in_tikz_set1267);
                    option102=option();

                    state._fsp--;

                    stream_option.add(option102.getTree());
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:28: ( ',' option )*
                    loop22:
                    do {
                        int alt22=2;
                        int LA22_0 = input.LA(1);

                        if ( (LA22_0==KOMMA) ) {
                            alt22=1;
                        }


                        switch (alt22) {
                    	case 1 :
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:29: ',' option
                    	    {
                    	    char_literal103=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_set1270);  
                    	    stream_KOMMA.add(char_literal103);

                    	    pushFollow(FOLLOW_option_in_tikz_set1272);
                    	    option104=option();

                    	    state._fsp--;

                    	    stream_option.add(option104.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop22;
                        }
                    } while (true);


                    }
                    break;

            }

            pushFollow(FOLLOW_roundbr_end_in_tikz_set1278);
            roundbr_end105=roundbr_end();

            state._fsp--;

            stream_roundbr_end.add(roundbr_end105.getTree());


            // AST REWRITE
            // elements: roundbr_end, option, tikz_set_start
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 215:56: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:59: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_TIKZSET, "IM_TIKZSET"), root_1);

                adaptor.addChild(root_1, stream_tikz_set_start.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:87: ( option )*
                while ( stream_option.hasNext() ) {
                    adaptor.addChild(root_1, stream_option.nextTree());

                }
                stream_option.reset();
                adaptor.addChild(root_1, stream_roundbr_end.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikz_set"

    public static class tikz_set_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_set_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:217:1: tikz_set_start : TIKZSET '{' -> ^( IM_STARTTAG ) ;
    public final simpletikzParser.tikz_set_start_return tikz_set_start() throws RecognitionException {
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token TIKZSET106=null;
        Token char_literal107=null;

        Object TIKZSET106_tree=null;
        Object char_literal107_tree=null;
        RewriteRuleTokenStream stream_48=new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_TIKZSET=new RewriteRuleTokenStream(adaptor,"token TIKZSET");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:2: ( TIKZSET '{' -> ^( IM_STARTTAG ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:4: TIKZSET '{'
            {
            TIKZSET106=(Token)match(input,TIKZSET,FOLLOW_TIKZSET_in_tikz_set_start1301);  
            stream_TIKZSET.add(TIKZSET106);

            char_literal107=(Token)match(input,48,FOLLOW_48_in_tikz_set_start1303);  
            stream_48.add(char_literal107);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 218:17: -> ^( IM_STARTTAG )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:20: ^( IM_STARTTAG )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikz_set_start"

    public static class usetikzlib_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "usetikzlib"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:221:1: usetikzlib : usetikzlib_start idd ( ',' idd )* roundbr_end -> ^( IM_USETIKZLIB usetikzlib_start ( idd )* roundbr_end ) ;
    public final simpletikzParser.usetikzlib_return usetikzlib() throws RecognitionException {
        simpletikzParser.usetikzlib_return retval = new simpletikzParser.usetikzlib_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal110=null;
        simpletikzParser.usetikzlib_start_return usetikzlib_start108 = null;

        simpletikzParser.idd_return idd109 = null;

        simpletikzParser.idd_return idd111 = null;

        simpletikzParser.roundbr_end_return roundbr_end112 = null;


        Object char_literal110_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_usetikzlib_start=new RewriteRuleSubtreeStream(adaptor,"rule usetikzlib_start");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_roundbr_end=new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:2: ( usetikzlib_start idd ( ',' idd )* roundbr_end -> ^( IM_USETIKZLIB usetikzlib_start ( idd )* roundbr_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:4: usetikzlib_start idd ( ',' idd )* roundbr_end
            {
            pushFollow(FOLLOW_usetikzlib_start_in_usetikzlib1324);
            usetikzlib_start108=usetikzlib_start();

            state._fsp--;

            stream_usetikzlib_start.add(usetikzlib_start108.getTree());
            pushFollow(FOLLOW_idd_in_usetikzlib1326);
            idd109=idd();

            state._fsp--;

            stream_idd.add(idd109.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:25: ( ',' idd )*
            loop24:
            do {
                int alt24=2;
                int LA24_0 = input.LA(1);

                if ( (LA24_0==KOMMA) ) {
                    alt24=1;
                }


                switch (alt24) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:26: ',' idd
            	    {
            	    char_literal110=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_usetikzlib1329);  
            	    stream_KOMMA.add(char_literal110);

            	    pushFollow(FOLLOW_idd_in_usetikzlib1331);
            	    idd111=idd();

            	    state._fsp--;

            	    stream_idd.add(idd111.getTree());

            	    }
            	    break;

            	default :
            	    break loop24;
                }
            } while (true);

            pushFollow(FOLLOW_roundbr_end_in_usetikzlib1335);
            roundbr_end112=roundbr_end();

            state._fsp--;

            stream_roundbr_end.add(roundbr_end112.getTree());


            // AST REWRITE
            // elements: idd, roundbr_end, usetikzlib_start
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 222:48: -> ^( IM_USETIKZLIB usetikzlib_start ( idd )* roundbr_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:51: ^( IM_USETIKZLIB usetikzlib_start ( idd )* roundbr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_USETIKZLIB, "IM_USETIKZLIB"), root_1);

                adaptor.addChild(root_1, stream_usetikzlib_start.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:84: ( idd )*
                while ( stream_idd.hasNext() ) {
                    adaptor.addChild(root_1, stream_idd.nextTree());

                }
                stream_idd.reset();
                adaptor.addChild(root_1, stream_roundbr_end.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "usetikzlib"

    public static class usetikzlib_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "usetikzlib_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:224:1: usetikzlib_start : USETIKZLIB '{' -> ^( IM_STARTTAG USETIKZLIB ) ;
    public final simpletikzParser.usetikzlib_start_return usetikzlib_start() throws RecognitionException {
        simpletikzParser.usetikzlib_start_return retval = new simpletikzParser.usetikzlib_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token USETIKZLIB113=null;
        Token char_literal114=null;

        Object USETIKZLIB113_tree=null;
        Object char_literal114_tree=null;
        RewriteRuleTokenStream stream_48=new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_USETIKZLIB=new RewriteRuleTokenStream(adaptor,"token USETIKZLIB");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:225:2: ( USETIKZLIB '{' -> ^( IM_STARTTAG USETIKZLIB ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:225:4: USETIKZLIB '{'
            {
            USETIKZLIB113=(Token)match(input,USETIKZLIB,FOLLOW_USETIKZLIB_in_usetikzlib_start1358);  
            stream_USETIKZLIB.add(USETIKZLIB113);

            char_literal114=(Token)match(input,48,FOLLOW_48_in_usetikzlib_start1360);  
            stream_48.add(char_literal114);



            // AST REWRITE
            // elements: USETIKZLIB
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 225:19: -> ^( IM_STARTTAG USETIKZLIB )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:225:22: ^( IM_STARTTAG USETIKZLIB )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                adaptor.addChild(root_1, stream_USETIKZLIB.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "usetikzlib_start"

    public static class semicolon_end_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "semicolon_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public final simpletikzParser.semicolon_end_return semicolon_end() throws RecognitionException {
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal115=null;

        Object char_literal115_tree=null;
        RewriteRuleTokenStream stream_SEMIC=new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:228:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:228:4: ';'
            {
            char_literal115=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_semicolon_end1379);  
            stream_SEMIC.add(char_literal115);



            // AST REWRITE
            // elements: SEMIC
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 228:8: -> ^( IM_ENDTAG ';' )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:228:11: ^( IM_ENDTAG ';' )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                adaptor.addChild(root_1, stream_SEMIC.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "semicolon_end"

    public static class roundbr_end_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "roundbr_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:230:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public final simpletikzParser.roundbr_end_return roundbr_end() throws RecognitionException {
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal116=null;

        Object char_literal116_tree=null;
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:4: '}'
            {
            char_literal116=(Token)match(input,49,FOLLOW_49_in_roundbr_end1397);  
            stream_49.add(char_literal116);



            // AST REWRITE
            // elements: 49
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 231:8: -> ^( IM_ENDTAG '}' )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:11: ^( IM_ENDTAG '}' )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                adaptor.addChild(root_1, stream_49.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "roundbr_end"

    public static class option_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "option"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:234:1: option : ( option_style | option_kv );
    public final simpletikzParser.option_return option() throws RecognitionException {
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.option_style_return option_style117 = null;

        simpletikzParser.option_kv_return option_kv118 = null;



        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:235:2: ( option_style | option_kv )
            int alt25=2;
            alt25 = dfa25.predict(input);
            switch (alt25) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:235:4: option_style
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_option_style_in_option1417);
                    option_style117=option_style();

                    state._fsp--;

                    adaptor.addChild(root_0, option_style117.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:236:5: option_kv
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_option_kv_in_option1426);
                    option_kv118=option_kv();

                    state._fsp--;

                    adaptor.addChild(root_0, option_kv118.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "option"

    public static class option_kv_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "option_kv"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:239:1: option_kv : idd ( '=' iddornumberunit )? -> ^( IM_OPTION_KV idd ( iddornumberunit )? ) ;
    public final simpletikzParser.option_kv_return option_kv() throws RecognitionException {
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal120=null;
        simpletikzParser.idd_return idd119 = null;

        simpletikzParser.iddornumberunit_return iddornumberunit121 = null;


        Object char_literal120_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_iddornumberunit=new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunit");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:2: ( idd ( '=' iddornumberunit )? -> ^( IM_OPTION_KV idd ( iddornumberunit )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:4: idd ( '=' iddornumberunit )?
            {
            pushFollow(FOLLOW_idd_in_option_kv1440);
            idd119=idd();

            state._fsp--;

            stream_idd.add(idd119.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:8: ( '=' iddornumberunit )?
            int alt26=2;
            int LA26_0 = input.LA(1);

            if ( (LA26_0==EQU) ) {
                alt26=1;
            }
            switch (alt26) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:9: '=' iddornumberunit
                    {
                    char_literal120=(Token)match(input,EQU,FOLLOW_EQU_in_option_kv1443);  
                    stream_EQU.add(char_literal120);

                    pushFollow(FOLLOW_iddornumberunit_in_option_kv1445);
                    iddornumberunit121=iddornumberunit();

                    state._fsp--;

                    stream_iddornumberunit.add(iddornumberunit121.getTree());

                    }
                    break;

            }



            // AST REWRITE
            // elements: idd, iddornumberunit
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 240:31: -> ^( IM_OPTION_KV idd ( iddornumberunit )? )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:34: ^( IM_OPTION_KV idd ( iddornumberunit )? )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

                adaptor.addChild(root_1, stream_idd.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:53: ( iddornumberunit )?
                if ( stream_iddornumberunit.hasNext() ) {
                    adaptor.addChild(root_1, stream_iddornumberunit.nextTree());

                }
                stream_iddornumberunit.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "option_kv"

    public static class iddornumberunit_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "iddornumberunit"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:242:1: iddornumberunit : ( idd | numberunit );
    public final simpletikzParser.iddornumberunit_return iddornumberunit() throws RecognitionException {
        simpletikzParser.iddornumberunit_return retval = new simpletikzParser.iddornumberunit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.idd_return idd122 = null;

        simpletikzParser.numberunit_return numberunit123 = null;



        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:243:2: ( idd | numberunit )
            int alt27=2;
            int LA27_0 = input.LA(1);

            if ( (LA27_0==ID) ) {
                alt27=1;
            }
            else if ( ((LA27_0>=FLOAT && LA27_0<=INT)) ) {
                alt27=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 27, 0, input);

                throw nvae;
            }
            switch (alt27) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:243:4: idd
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_idd_in_iddornumberunit1468);
                    idd122=idd();

                    state._fsp--;

                    adaptor.addChild(root_0, idd122.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:243:10: numberunit
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_numberunit_in_iddornumberunit1472);
                    numberunit123=numberunit();

                    state._fsp--;

                    adaptor.addChild(root_0, numberunit123.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "iddornumberunit"

    public static class option_style_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "option_style"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:245:1: option_style : idd '/.style' '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public final simpletikzParser.option_style_return option_style() throws RecognitionException {
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal125=null;
        Token char_literal126=null;
        Token char_literal127=null;
        Token char_literal129=null;
        Token char_literal131=null;
        Token char_literal132=null;
        simpletikzParser.idd_return idd124 = null;

        simpletikzParser.option_kv_return option_kv128 = null;

        simpletikzParser.option_kv_return option_kv130 = null;


        Object string_literal125_tree=null;
        Object char_literal126_tree=null;
        Object char_literal127_tree=null;
        Object char_literal129_tree=null;
        Object char_literal131_tree=null;
        Object char_literal132_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48=new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_69=new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv=new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:2: ( idd '/.style' '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:4: idd '/.style' '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}'
            {
            pushFollow(FOLLOW_idd_in_option_style1482);
            idd124=idd();

            state._fsp--;

            stream_idd.add(idd124.getTree());
            string_literal125=(Token)match(input,69,FOLLOW_69_in_option_style1484);  
            stream_69.add(string_literal125);

            char_literal126=(Token)match(input,EQU,FOLLOW_EQU_in_option_style1486);  
            stream_EQU.add(char_literal126);

            char_literal127=(Token)match(input,48,FOLLOW_48_in_option_style1488);  
            stream_48.add(char_literal127);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:26: ( option_kv ( ',' option_kv )* )?
            int alt29=2;
            int LA29_0 = input.LA(1);

            if ( (LA29_0==ID) ) {
                alt29=1;
            }
            switch (alt29) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:27: option_kv ( ',' option_kv )*
                    {
                    pushFollow(FOLLOW_option_kv_in_option_style1491);
                    option_kv128=option_kv();

                    state._fsp--;

                    stream_option_kv.add(option_kv128.getTree());
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:37: ( ',' option_kv )*
                    loop28:
                    do {
                        int alt28=2;
                        int LA28_0 = input.LA(1);

                        if ( (LA28_0==KOMMA) ) {
                            int LA28_1 = input.LA(2);

                            if ( (LA28_1==ID) ) {
                                alt28=1;
                            }


                        }


                        switch (alt28) {
                    	case 1 :
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:38: ',' option_kv
                    	    {
                    	    char_literal129=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_option_style1494);  
                    	    stream_KOMMA.add(char_literal129);

                    	    pushFollow(FOLLOW_option_kv_in_option_style1496);
                    	    option_kv130=option_kv();

                    	    state._fsp--;

                    	    stream_option_kv.add(option_kv130.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop28;
                        }
                    } while (true);


                    }
                    break;

            }

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:57: ( ',' )?
            int alt30=2;
            int LA30_0 = input.LA(1);

            if ( (LA30_0==KOMMA) ) {
                alt30=1;
            }
            switch (alt30) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:57: ','
                    {
                    char_literal131=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_option_style1503);  
                    stream_KOMMA.add(char_literal131);


                    }
                    break;

            }

            char_literal132=(Token)match(input,49,FOLLOW_49_in_option_style1506);  
            stream_49.add(char_literal132);



            // AST REWRITE
            // elements: option_kv, idd
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 246:67: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:70: ^( IM_OPTION_STYLE idd ( option_kv )* )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

                adaptor.addChild(root_1, stream_idd.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:92: ( option_kv )*
                while ( stream_option_kv.hasNext() ) {
                    adaptor.addChild(root_1, stream_option_kv.nextTree());

                }
                stream_option_kv.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "option_style"

    public static class idd_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "idd"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:250:1: idd : ID ( ID )* -> ^( IM_ID ( ID )* ) ;
    public final simpletikzParser.idd_return idd() throws RecognitionException {
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token ID133=null;
        Token ID134=null;

        Object ID133_tree=null;
        Object ID134_tree=null;
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:2: ( ID ( ID )* -> ^( IM_ID ( ID )* ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:4: ID ( ID )*
            {
            ID133=(Token)match(input,ID,FOLLOW_ID_in_idd1532);  
            stream_ID.add(ID133);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:7: ( ID )*
            loop31:
            do {
                int alt31=2;
                int LA31_0 = input.LA(1);

                if ( (LA31_0==ID) ) {
                    alt31=1;
                }


                switch (alt31) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:8: ID
            	    {
            	    ID134=(Token)match(input,ID,FOLLOW_ID_in_idd1535);  
            	    stream_ID.add(ID134);


            	    }
            	    break;

            	default :
            	    break loop31;
                }
            } while (true);



            // AST REWRITE
            // elements: ID
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 251:13: -> ^( IM_ID ( ID )* )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:16: ^( IM_ID ( ID )* )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ID, "IM_ID"), root_1);

                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:24: ( ID )*
                while ( stream_ID.hasNext() ) {
                    adaptor.addChild(root_1, stream_ID.nextNode());

                }
                stream_ID.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "idd"

    public static class tikzstring_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzstring"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:254:1: tikzstring : '{' ( tikzstring | MATHSTRING | ID )* '}' -> ^( IM_STRING '{' '}' ) ;
    public final simpletikzParser.tikzstring_return tikzstring() throws RecognitionException {
        simpletikzParser.tikzstring_return retval = new simpletikzParser.tikzstring_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal135=null;
        Token MATHSTRING137=null;
        Token ID138=null;
        Token char_literal139=null;
        simpletikzParser.tikzstring_return tikzstring136 = null;


        Object char_literal135_tree=null;
        Object MATHSTRING137_tree=null;
        Object ID138_tree=null;
        Object char_literal139_tree=null;
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48=new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_MATHSTRING=new RewriteRuleTokenStream(adaptor,"token MATHSTRING");
        RewriteRuleSubtreeStream stream_tikzstring=new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:2: ( '{' ( tikzstring | MATHSTRING | ID )* '}' -> ^( IM_STRING '{' '}' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:4: '{' ( tikzstring | MATHSTRING | ID )* '}'
            {
            char_literal135=(Token)match(input,48,FOLLOW_48_in_tikzstring1557);  
            stream_48.add(char_literal135);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:9: ( tikzstring | MATHSTRING | ID )*
            loop32:
            do {
                int alt32=4;
                switch ( input.LA(1) ) {
                case 48:
                    {
                    alt32=1;
                    }
                    break;
                case MATHSTRING:
                    {
                    alt32=2;
                    }
                    break;
                case ID:
                    {
                    alt32=3;
                    }
                    break;

                }

                switch (alt32) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:10: tikzstring
            	    {
            	    pushFollow(FOLLOW_tikzstring_in_tikzstring1561);
            	    tikzstring136=tikzstring();

            	    state._fsp--;

            	    stream_tikzstring.add(tikzstring136.getTree());

            	    }
            	    break;
            	case 2 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:23: MATHSTRING
            	    {
            	    MATHSTRING137=(Token)match(input,MATHSTRING,FOLLOW_MATHSTRING_in_tikzstring1565);  
            	    stream_MATHSTRING.add(MATHSTRING137);


            	    }
            	    break;
            	case 3 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:36: ID
            	    {
            	    ID138=(Token)match(input,ID,FOLLOW_ID_in_tikzstring1569);  
            	    stream_ID.add(ID138);


            	    }
            	    break;

            	default :
            	    break loop32;
                }
            } while (true);

            char_literal139=(Token)match(input,49,FOLLOW_49_in_tikzstring1573);  
            stream_49.add(char_literal139);



            // AST REWRITE
            // elements: 48, 49
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 255:45: -> ^( IM_STRING '{' '}' )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:48: ^( IM_STRING '{' '}' )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STRING, "IM_STRING"), root_1);

                adaptor.addChild(root_1, stream_48.nextNode());
                adaptor.addChild(root_1, stream_49.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "tikzstring"

    // Delegated rules


    protected DFA14 dfa14 = new DFA14(this);
    protected DFA16 dfa16 = new DFA16(this);
    protected DFA18 dfa18 = new DFA18(this);
    protected DFA25 dfa25 = new DFA25(this);
    static final String DFA14_eotS =
        "\73\uffff";
    static final String DFA14_eofS =
        "\73\uffff";
    static final String DFA14_minS =
        "\2\4\1\uffff\1\4\1\uffff\66\4";
    static final String DFA14_maxS =
        "\2\105\1\uffff\1\105\1\uffff\66\105";
    static final String DFA14_acceptS =
        "\2\uffff\1\2\1\uffff\1\1\66\uffff";
    static final String DFA14_specialS =
        "\73\uffff}>";
    static final String[] DFA14_transitionS = {
            "\13\2\1\1\66\2",
            "\14\2\1\4\26\2\1\3\36\2",
            "",
            "\14\2\1\4\1\10\1\7\24\2\1\5\35\2\1\6",
            "",
            "\14\2\1\4\1\10\1\7\24\2\1\5\35\2\1\6",
            "\16\2\1\11\63\2",
            "\43\2\1\12\2\13\34\2",
            "\14\2\1\4\26\2\1\14\36\2",
            "\54\2\1\15\25\2",
            "\14\2\1\4\1\10\25\2\1\16\36\2",
            "\14\2\1\4\1\10\54\2\5\17\3\2",
            "\14\2\1\4\1\10\1\21\24\2\1\20\35\2\1\22",
            "\15\2\1\24\25\2\1\23\11\2\1\25\24\2",
            "\14\2\1\4\1\10\25\2\1\16\36\2",
            "\14\2\1\4\1\10\64\2",
            "\14\2\1\4\1\10\1\21\24\2\1\20\35\2\1\22",
            "\43\2\1\26\2\27\34\2",
            "\16\2\1\30\63\2",
            "\15\2\1\33\1\32\24\2\1\31\11\2\1\25\24\2",
            "\55\2\1\25\24\2",
            "\14\2\1\4\1\10\64\2",
            "\14\2\1\4\1\10\25\2\1\34\36\2",
            "\14\2\1\4\1\10\54\2\5\35\3\2",
            "\54\2\1\36\25\2",
            "\15\2\1\33\1\32\24\2\1\31\11\2\1\25\24\2",
            "\43\2\1\37\2\40\34\2",
            "\43\2\1\41\11\2\1\25\24\2",
            "\14\2\1\4\1\10\25\2\1\34\36\2",
            "\14\2\1\4\1\10\64\2",
            "\15\2\1\43\25\2\1\42\11\2\1\44\24\2",
            "\15\2\1\33\25\2\1\45\11\2\1\25\24\2",
            "\15\2\1\33\37\2\1\25\14\2\5\46\3\2",
            "\15\2\1\33\1\50\24\2\1\47\11\2\1\25\24\2",
            "\15\2\1\53\1\52\24\2\1\51\11\2\1\44\24\2",
            "\55\2\1\44\24\2",
            "\14\2\1\4\1\10\64\2",
            "\15\2\1\33\25\2\1\45\11\2\1\25\24\2",
            "\15\2\1\33\37\2\1\25\24\2",
            "\15\2\1\33\1\50\24\2\1\47\11\2\1\25\24\2",
            "\43\2\1\54\2\55\34\2",
            "\15\2\1\53\1\52\24\2\1\51\11\2\1\44\24\2",
            "\43\2\1\56\2\57\34\2",
            "\43\2\1\60\11\2\1\44\24\2",
            "\15\2\1\33\25\2\1\61\11\2\1\25\24\2",
            "\15\2\1\33\37\2\1\25\14\2\5\62\3\2",
            "\15\2\1\53\25\2\1\63\11\2\1\44\24\2",
            "\15\2\1\53\37\2\1\44\14\2\5\64\3\2",
            "\15\2\1\53\1\66\24\2\1\65\11\2\1\44\24\2",
            "\15\2\1\33\25\2\1\61\11\2\1\25\24\2",
            "\15\2\1\33\37\2\1\25\24\2",
            "\15\2\1\53\25\2\1\63\11\2\1\44\24\2",
            "\15\2\1\53\37\2\1\44\24\2",
            "\15\2\1\53\1\66\24\2\1\65\11\2\1\44\24\2",
            "\43\2\1\67\2\70\34\2",
            "\15\2\1\53\25\2\1\71\11\2\1\44\24\2",
            "\15\2\1\53\37\2\1\44\14\2\5\72\3\2",
            "\15\2\1\53\25\2\1\71\11\2\1\44\24\2",
            "\15\2\1\53\37\2\1\44\24\2"
    };

    static final short[] DFA14_eot = DFA.unpackEncodedString(DFA14_eotS);
    static final short[] DFA14_eof = DFA.unpackEncodedString(DFA14_eofS);
    static final char[] DFA14_min = DFA.unpackEncodedStringToUnsignedChars(DFA14_minS);
    static final char[] DFA14_max = DFA.unpackEncodedStringToUnsignedChars(DFA14_maxS);
    static final short[] DFA14_accept = DFA.unpackEncodedString(DFA14_acceptS);
    static final short[] DFA14_special = DFA.unpackEncodedString(DFA14_specialS);
    static final short[][] DFA14_transition;

    static {
        int numStates = DFA14_transitionS.length;
        DFA14_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA14_transition[i] = DFA.unpackEncodedString(DFA14_transitionS[i]);
        }
    }

    class DFA14 extends DFA {

        public DFA14(BaseRecognizer recognizer) {
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
        public String getDescription() {
            return "173:23: ( tikz_options )?";
        }
    }
    static final String DFA16_eotS =
        "\16\uffff";
    static final String DFA16_eofS =
        "\16\uffff";
    static final String DFA16_minS =
        "\1\4\2\60\5\uffff\2\47\4\uffff";
    static final String DFA16_maxS =
        "\1\105\2\60\5\uffff\2\104\4\uffff";
    static final String DFA16_acceptS =
        "\3\uffff\1\2\1\3\1\4\1\5\1\6\2\uffff\1\11\1\10\1\1\1\7";
    static final String DFA16_specialS =
        "\16\uffff}>";
    static final String[] DFA16_transitionS = {
            "\1\2\1\1\1\5\1\7\1\6\1\4\3\3\71\5",
            "\1\10",
            "\1\11",
            "",
            "",
            "",
            "",
            "",
            "\1\13\33\uffff\2\12",
            "\1\15\34\uffff\1\14",
            "",
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
            return "()+ loopback of 182:4: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )+";
        }
    }
    static final String DFA18_eotS =
        "\73\uffff";
    static final String DFA18_eofS =
        "\73\uffff";
    static final String DFA18_minS =
        "\2\4\1\uffff\1\4\1\uffff\66\4";
    static final String DFA18_maxS =
        "\2\105\1\uffff\1\105\1\uffff\66\105";
    static final String DFA18_acceptS =
        "\2\uffff\1\2\1\uffff\1\1\66\uffff";
    static final String DFA18_specialS =
        "\73\uffff}>";
    static final String[] DFA18_transitionS = {
            "\13\2\1\1\66\2",
            "\14\2\1\4\26\2\1\3\36\2",
            "",
            "\14\2\1\4\1\10\1\7\24\2\1\5\35\2\1\6",
            "",
            "\14\2\1\4\1\10\1\7\24\2\1\5\35\2\1\6",
            "\16\2\1\11\63\2",
            "\43\2\1\12\2\13\34\2",
            "\14\2\1\4\26\2\1\14\36\2",
            "\54\2\1\15\25\2",
            "\14\2\1\4\1\10\25\2\1\16\36\2",
            "\14\2\1\4\1\10\54\2\5\17\3\2",
            "\14\2\1\4\1\10\1\21\24\2\1\20\35\2\1\22",
            "\15\2\1\24\25\2\1\23\11\2\1\25\24\2",
            "\14\2\1\4\1\10\25\2\1\16\36\2",
            "\14\2\1\4\1\10\64\2",
            "\14\2\1\4\1\10\1\21\24\2\1\20\35\2\1\22",
            "\43\2\1\26\2\27\34\2",
            "\16\2\1\30\63\2",
            "\15\2\1\33\1\32\24\2\1\31\11\2\1\25\24\2",
            "\55\2\1\25\24\2",
            "\14\2\1\4\1\10\64\2",
            "\14\2\1\4\1\10\25\2\1\34\36\2",
            "\14\2\1\4\1\10\54\2\5\35\3\2",
            "\54\2\1\36\25\2",
            "\15\2\1\33\1\32\24\2\1\31\11\2\1\25\24\2",
            "\43\2\1\37\2\40\34\2",
            "\43\2\1\41\11\2\1\25\24\2",
            "\14\2\1\4\1\10\25\2\1\34\36\2",
            "\14\2\1\4\1\10\64\2",
            "\15\2\1\43\25\2\1\42\11\2\1\44\24\2",
            "\15\2\1\33\25\2\1\45\11\2\1\25\24\2",
            "\15\2\1\33\37\2\1\25\14\2\5\46\3\2",
            "\15\2\1\33\1\50\24\2\1\47\11\2\1\25\24\2",
            "\15\2\1\53\1\52\24\2\1\51\11\2\1\44\24\2",
            "\55\2\1\44\24\2",
            "\14\2\1\4\1\10\64\2",
            "\15\2\1\33\25\2\1\45\11\2\1\25\24\2",
            "\15\2\1\33\37\2\1\25\24\2",
            "\15\2\1\33\1\50\24\2\1\47\11\2\1\25\24\2",
            "\43\2\1\54\2\55\34\2",
            "\15\2\1\53\1\52\24\2\1\51\11\2\1\44\24\2",
            "\43\2\1\56\2\57\34\2",
            "\43\2\1\60\11\2\1\44\24\2",
            "\15\2\1\33\25\2\1\61\11\2\1\25\24\2",
            "\15\2\1\33\37\2\1\25\14\2\5\62\3\2",
            "\15\2\1\53\25\2\1\63\11\2\1\44\24\2",
            "\15\2\1\53\37\2\1\44\14\2\5\64\3\2",
            "\15\2\1\53\1\66\24\2\1\65\11\2\1\44\24\2",
            "\15\2\1\33\25\2\1\61\11\2\1\25\24\2",
            "\15\2\1\33\37\2\1\25\24\2",
            "\15\2\1\53\25\2\1\63\11\2\1\44\24\2",
            "\15\2\1\53\37\2\1\44\24\2",
            "\15\2\1\53\1\66\24\2\1\65\11\2\1\44\24\2",
            "\43\2\1\67\2\70\34\2",
            "\15\2\1\53\25\2\1\71\11\2\1\44\24\2",
            "\15\2\1\53\37\2\1\44\14\2\5\72\3\2",
            "\15\2\1\53\25\2\1\71\11\2\1\44\24\2",
            "\15\2\1\53\37\2\1\44\24\2"
    };

    static final short[] DFA18_eot = DFA.unpackEncodedString(DFA18_eotS);
    static final short[] DFA18_eof = DFA.unpackEncodedString(DFA18_eofS);
    static final char[] DFA18_min = DFA.unpackEncodedStringToUnsignedChars(DFA18_minS);
    static final char[] DFA18_max = DFA.unpackEncodedStringToUnsignedChars(DFA18_maxS);
    static final short[] DFA18_accept = DFA.unpackEncodedString(DFA18_acceptS);
    static final short[] DFA18_special = DFA.unpackEncodedString(DFA18_specialS);
    static final short[][] DFA18_transition;

    static {
        int numStates = DFA18_transitionS.length;
        DFA18_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA18_transition[i] = DFA.unpackEncodedString(DFA18_transitionS[i]);
        }
    }

    class DFA18 extends DFA {

        public DFA18(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 18;
            this.eot = DFA18_eot;
            this.eof = DFA18_eof;
            this.min = DFA18_min;
            this.max = DFA18_max;
            this.accept = DFA18_accept;
            this.special = DFA18_special;
            this.transition = DFA18_transition;
        }
        public String getDescription() {
            return "195:20: ( tikz_options )?";
        }
    }
    static final String DFA25_eotS =
        "\5\uffff";
    static final String DFA25_eofS =
        "\5\uffff";
    static final String DFA25_minS =
        "\1\47\2\20\2\uffff";
    static final String DFA25_maxS =
        "\1\47\2\105\2\uffff";
    static final String DFA25_acceptS =
        "\3\uffff\1\1\1\2";
    static final String DFA25_specialS =
        "\5\uffff}>";
    static final String[] DFA25_transitionS = {
            "\1\1",
            "\3\4\24\uffff\1\2\11\uffff\1\4\23\uffff\1\3",
            "\3\4\24\uffff\1\2\11\uffff\1\4\23\uffff\1\3",
            "",
            ""
    };

    static final short[] DFA25_eot = DFA.unpackEncodedString(DFA25_eotS);
    static final short[] DFA25_eof = DFA.unpackEncodedString(DFA25_eofS);
    static final char[] DFA25_min = DFA.unpackEncodedStringToUnsignedChars(DFA25_minS);
    static final char[] DFA25_max = DFA.unpackEncodedStringToUnsignedChars(DFA25_maxS);
    static final short[] DFA25_accept = DFA.unpackEncodedString(DFA25_acceptS);
    static final short[] DFA25_special = DFA.unpackEncodedString(DFA25_specialS);
    static final short[][] DFA25_transition;

    static {
        int numStates = DFA25_transitionS.length;
        DFA25_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA25_transition[i] = DFA.unpackEncodedString(DFA25_transitionS[i]);
        }
    }

    class DFA25 extends DFA {

        public DFA25(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 25;
            this.eot = DFA25_eot;
            this.eof = DFA25_eof;
            this.min = DFA25_min;
            this.max = DFA25_max;
            this.accept = DFA25_accept;
            this.special = DFA25_special;
            this.transition = DFA25_transition;
        }
        public String getDescription() {
            return "234:1: option : ( option_style | option_kv );";
        }
    }
 

    public static final BitSet FOLLOW_dontcare_preamble_in_tikzdocument321 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000003FL});
    public static final BitSet FOLLOW_tikz_styleorset_in_tikzdocument325 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000003FL});
    public static final BitSet FOLLOW_otherbegin_in_tikzdocument329 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000003FL});
    public static final BitSet FOLLOW_tikzpicture_in_tikzdocument334 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000003FL});
    public static final BitSet FOLLOW_tikz_style_in_tikz_styleorset364 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_set_in_tikz_styleorset368 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_dontcare_preamble380 = new BitSet(new long[]{0xFFFFFFFFFFFFFE62L,0x000000000000003FL});
    public static final BitSet FOLLOW_BEGIN_in_otherbegin403 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_48_in_otherbegin405 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_idd_in_otherbegin407 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_otherbegin409 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TIKZSTYLE_in_tikz_style420 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_48_in_tikz_style422 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_idd_in_tikz_style424 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_tikz_style426 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_EQU_in_tikz_style428 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_tikz_options_in_tikz_style430 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_in_tikzpath452 = new BitSet(new long[]{0x3004000000002000L});
    public static final BitSet FOLLOW_tikzpathi_in_tikzpath454 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_path_end_in_tikzpath456 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SEMIC_in_path_end479 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi499 = new BitSet(new long[]{0x3FF400000000A002L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi502 = new BitSet(new long[]{0x3FF400000000A002L});
    public static final BitSet FOLLOW_tikz_options_in_tikzpathi506 = new BitSet(new long[]{0x3FF400000000A000L});
    public static final BitSet FOLLOW_edgeop_in_tikzpathi509 = new BitSet(new long[]{0x3004000000002000L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi512 = new BitSet(new long[]{0x3FF400000000A002L});
    public static final BitSet FOLLOW_coord_in_coordornode527 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikznodei_in_coordornode531 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_50_in_tikznodei543 = new BitSet(new long[]{0x0009000000002000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodei546 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_node_start_in_tikznodee556 = new BitSet(new long[]{0x0009000000002000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodee558 = new BitSet(new long[]{0x3004000000082000L});
    public static final BitSet FOLLOW_tikzpathi_in_tikznodee560 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_path_end_in_tikznodee563 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_node_start589 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_tikznode607 = new BitSet(new long[]{0x0009000000002000L});
    public static final BitSet FOLLOW_51_in_tikznode611 = new BitSet(new long[]{0x3000000000002000L});
    public static final BitSet FOLLOW_coord_in_tikznode613 = new BitSet(new long[]{0x0009000000002000L});
    public static final BitSet FOLLOW_tikzstring_in_tikznode617 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_edgeop0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LPAR_in_nodename690 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_ID_in_nodename694 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_RPAR_in_nodename696 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_coord721 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_modifier_in_coord745 = new BitSet(new long[]{0x0000000000002000L});
    public static final BitSet FOLLOW_LPAR_in_coord750 = new BitSet(new long[]{0x0000030000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord752 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_KOMMA_in_coord754 = new BitSet(new long[]{0x0000030000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord756 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_RPAR_in_coord758 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_number_in_numberunit800 = new BitSet(new long[]{0xC000000000000002L,0x0000000000000007L});
    public static final BitSet FOLLOW_unit_in_numberunit802 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_number825 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_unit0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_tag_in_path_start869 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzpicture_start_in_tikzpicture908 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000003FL});
    public static final BitSet FOLLOW_tikz_options_in_tikzpicture910 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000003FL});
    public static final BitSet FOLLOW_tikzbody_in_tikzpicture913 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000003FL});
    public static final BitSet FOLLOW_tikzpicture_end_in_tikzpicture916 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_tikzpicture_start943 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_48_in_tikzpicture_start945 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000008L});
    public static final BitSet FOLLOW_67_in_tikzpicture_start947 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_tikzpicture_start949 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_tikzpicture_end967 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_48_in_tikzpicture_end969 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000008L});
    public static final BitSet FOLLOW_67_in_tikzpicture_end971 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_tikzpicture_end973 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody993 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000003FL});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody997 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000003FL});
    public static final BitSet FOLLOW_tikznodee_in_tikzbody1001 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000003FL});
    public static final BitSet FOLLOW_dontcare_body_in_tikzbody1005 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000003FL});
    public static final BitSet FOLLOW_tikz_set_in_tikzbody1009 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000003FL});
    public static final BitSet FOLLOW_tikz_style_in_tikzbody1013 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000003FL});
    public static final BitSet FOLLOW_otherbegin_in_tikzbody1017 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000003FL});
    public static final BitSet FOLLOW_otherend_in_tikzbody1020 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000003FL});
    public static final BitSet FOLLOW_set_in_dontcare_body1034 = new BitSet(new long[]{0xFFFFFFFFFFFFE042L,0x000000000000003FL});
    public static final BitSet FOLLOW_END_in_otherend1080 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_48_in_otherend1082 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_idd_in_otherend1084 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_otherend1086 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzscope_start_in_tikzscope1100 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000003FL});
    public static final BitSet FOLLOW_tikz_options_in_tikzscope1102 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000003FL});
    public static final BitSet FOLLOW_tikzbody_in_tikzscope1105 = new BitSet(new long[]{0x0000000000000020L});
    public static final BitSet FOLLOW_tikzscope_end_in_tikzscope1107 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_tikzscope_start1133 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_48_in_tikzscope_start1135 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000010L});
    public static final BitSet FOLLOW_68_in_tikzscope_start1137 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_tikzscope_start1139 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_tikzscope_end1157 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_48_in_tikzscope_end1159 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000010L});
    public static final BitSet FOLLOW_68_in_tikzscope_end1161 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_tikzscope_end1163 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_squarebr_start_in_tikz_options1183 = new BitSet(new long[]{0x0000008000010000L});
    public static final BitSet FOLLOW_option_in_tikz_options1186 = new BitSet(new long[]{0x0000008000030000L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_options1189 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_option_in_tikz_options1191 = new BitSet(new long[]{0x0000008000030000L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_options1195 = new BitSet(new long[]{0x0000008000010000L});
    public static final BitSet FOLLOW_squarebr_end_in_tikz_options1200 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBR_in_squarebr_start1224 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RBR_in_squarebr_end1242 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_set_start_in_tikz_set1264 = new BitSet(new long[]{0x0002008000000000L});
    public static final BitSet FOLLOW_option_in_tikz_set1267 = new BitSet(new long[]{0x0002008000020000L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_set1270 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_option_in_tikz_set1272 = new BitSet(new long[]{0x0002008000020000L});
    public static final BitSet FOLLOW_roundbr_end_in_tikz_set1278 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TIKZSET_in_tikz_set_start1301 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_48_in_tikz_set_start1303 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_usetikzlib_start_in_usetikzlib1324 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_idd_in_usetikzlib1326 = new BitSet(new long[]{0x0002008000020000L});
    public static final BitSet FOLLOW_KOMMA_in_usetikzlib1329 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_idd_in_usetikzlib1331 = new BitSet(new long[]{0x0002008000020000L});
    public static final BitSet FOLLOW_roundbr_end_in_usetikzlib1335 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_USETIKZLIB_in_usetikzlib_start1358 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_48_in_usetikzlib_start1360 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SEMIC_in_semicolon_end1379 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_49_in_roundbr_end1397 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_style_in_option1417 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_kv_in_option1426 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_kv1440 = new BitSet(new long[]{0x0000000000040002L});
    public static final BitSet FOLLOW_EQU_in_option_kv1443 = new BitSet(new long[]{0x0000038000000000L});
    public static final BitSet FOLLOW_iddornumberunit_in_option_kv1445 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_iddornumberunit1468 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_numberunit_in_iddornumberunit1472 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_style1482 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000020L});
    public static final BitSet FOLLOW_69_in_option_style1484 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_EQU_in_option_style1486 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_48_in_option_style1488 = new BitSet(new long[]{0x0002008000020000L});
    public static final BitSet FOLLOW_option_kv_in_option_style1491 = new BitSet(new long[]{0x0002000000020000L});
    public static final BitSet FOLLOW_KOMMA_in_option_style1494 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_option_kv_in_option_style1496 = new BitSet(new long[]{0x0002000000020000L});
    public static final BitSet FOLLOW_KOMMA_in_option_style1503 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_option_style1506 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ID_in_idd1532 = new BitSet(new long[]{0x0000008000000002L});
    public static final BitSet FOLLOW_ID_in_idd1535 = new BitSet(new long[]{0x0000008000000002L});
    public static final BitSet FOLLOW_48_in_tikzstring1557 = new BitSet(new long[]{0x000B048000002000L});
    public static final BitSet FOLLOW_tikzstring_in_tikzstring1561 = new BitSet(new long[]{0x000B048000002000L});
    public static final BitSet FOLLOW_MATHSTRING_in_tikzstring1565 = new BitSet(new long[]{0x000B048000002000L});
    public static final BitSet FOLLOW_ID_in_tikzstring1569 = new BitSet(new long[]{0x000B048000002000L});
    public static final BitSet FOLLOW_49_in_tikzstring1573 = new BitSet(new long[]{0x0000000000000002L});

}