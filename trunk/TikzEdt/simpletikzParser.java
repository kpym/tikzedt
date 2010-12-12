// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-12-10 11:17:16

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;

import org.antlr.runtime.tree.*;

public class simpletikzParser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BEGIN", "END", "USETIKZLIB", "TIKZSTYLE", "TIKZSET", "NODE", "DRAW", "PATH", "FILL", "LPAR", "RPAR", "LBR", "RBR", "KOMMA", "EQU", "SEMIC", "COLON", "IM_PATH", "IM_NODE", "IM_COORD", "IM_NODENAME", "IM_NUMBERUNIT", "IM_PICTURE", "IM_DOCUMENT", "IM_SCOPE", "IM_STARTTAG", "IM_ENDTAG", "IM_OPTIONS", "IM_OPTION_STYLE", "IM_OPTION_KV", "IM_ID", "IM_TIKZSET", "IM_USETIKZLIB", "IM_STRING", "IM_STYLE", "ID", "FLOAT", "INT", "MATHSTRING", "EXPONENT", "COMMENT", "WS", "ESC_SEQ", "COMMAND", "SOMETHING", "'{'", "'}'", "'node'", "'at'", "'--'", "'edge'", "'->'", "'|-'", "'-|'", "'to'", "'grid'", "'rectangle'", "'+'", "'++'", "'cm'", "'in'", "'ex'", "'mm'", "'pt'", "'tikzpicture'", "'scope'", "'/.style'"
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
    public static final int SOMETHING=48;
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
    public static final int T__70=70;
    public static final int KOMMA=17;
    public static final int EQU=18;
    public static final int RPAR=14;
    public static final int END=5;
    public static final int SEMIC=19;
    public static final int IM_NODENAME=24;
    public static final int DRAW=10;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "tikzdocument", "tikzscope", "idd", "tikzpicture_end", 
        "option_style", "tikzscope_end", "edgeop", "tikzpath", "node_start", 
        "squarebr_end", "tikznode", "tikznodei", "tikzpathi", "tikzstring", 
        "squarebr_start", "otherend", "dontcare_body", "coord", "unit", 
        "semicolon_end", "tikzscope_start", "tikzpicture_start", "nodename", 
        "option", "number", "path_start_tag", "tikz_options", "usetikzlib_start", 
        "tikz_styleorset", "iddornumberunit", "tikzbody", "path_start", 
        "option_kv", "tikznodee", "path_end", "tikz_style", "usetikzlib", 
        "coordornode", "tikzpicture", "coord_modifier", "numberunit", "tikz_set_start", 
        "roundbr_end", "tikz_set", "dontcare_preamble", "otherbegin"
    };
     
        public int ruleLevel = 0;
        public int getRuleLevel() { return ruleLevel; }
        public void incRuleLevel() { ruleLevel++; }
        public void decRuleLevel() { ruleLevel--; }
        public simpletikzParser(TokenStream input) {
            this(input, DebugEventSocketProxy.DEFAULT_DEBUGGER_PORT, new RecognizerSharedState());
        }
        public simpletikzParser(TokenStream input, int port, RecognizerSharedState state) {
            super(input, state);
            DebugEventSocketProxy proxy =
                new DebugEventSocketProxy(this,port,adaptor);
            setDebugListener(proxy);
            setTokenStream(new DebugTokenStream(input,proxy));
            try {
                proxy.handshake();
            }
            catch (IOException ioe) {
                reportError(ioe);
            }
            TreeAdaptor adap = new CommonTreeAdaptor();
            setTreeAdaptor(adap);
            proxy.setTreeAdaptor(adap);
        }
    public simpletikzParser(TokenStream input, DebugEventListener dbg) {
        super(input, dbg);

         
        TreeAdaptor adap = new CommonTreeAdaptor();
        setTreeAdaptor(adap);

    }
    protected boolean evalPredicate(boolean result, String predicate) {
        dbg.semanticPredicate(result, predicate);
        return result;
    }

    protected DebugTreeAdaptor adaptor;
    public void setTreeAdaptor(TreeAdaptor adaptor) {
        this.adaptor = new DebugTreeAdaptor(dbg,adaptor);

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
        try { dbg.enterRule(getGrammarFileName(), "tikzdocument");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(88, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:2: ( ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:5: ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture ( . )*
            {
            dbg.location(89,5);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:5: ( dontcare_preamble | tikz_styleorset | otherbegin )*
            try { dbg.enterSubRule(1);

            loop1:
            do {
                int alt1=4;
                try { dbg.enterDecision(1);

                switch ( input.LA(1) ) {
                case BEGIN:
                    {
                    int LA1_1 = input.LA(2);

                    if ( (LA1_1==49) ) {
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
                case SOMETHING:
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
                case 70:
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

                } finally {dbg.exitDecision(1);}

                switch (alt1) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:6: dontcare_preamble
            	    {
            	    dbg.location(89,6);
            	    pushFollow(FOLLOW_dontcare_preamble_in_tikzdocument321);
            	    dontcare_preamble1=dontcare_preamble();

            	    state._fsp--;

            	    stream_dontcare_preamble.add(dontcare_preamble1.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:26: tikz_styleorset
            	    {
            	    dbg.location(89,26);
            	    pushFollow(FOLLOW_tikz_styleorset_in_tikzdocument325);
            	    tikz_styleorset2=tikz_styleorset();

            	    state._fsp--;

            	    stream_tikz_styleorset.add(tikz_styleorset2.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:44: otherbegin
            	    {
            	    dbg.location(89,44);
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
            } finally {dbg.exitSubRule(1);}

            dbg.location(89,58);
            pushFollow(FOLLOW_tikzpicture_in_tikzdocument334);
            tikzpicture4=tikzpicture();

            state._fsp--;

            stream_tikzpicture.add(tikzpicture4.getTree());
            dbg.location(89,71);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:71: ( . )*
            try { dbg.enterSubRule(2);

            loop2:
            do {
                int alt2=2;
                try { dbg.enterDecision(2);

                int LA2_0 = input.LA(1);

                if ( ((LA2_0>=BEGIN && LA2_0<=70)) ) {
                    alt2=1;
                }
                else if ( (LA2_0==EOF) ) {
                    alt2=2;
                }


                } finally {dbg.exitDecision(2);}

                switch (alt2) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:71: .
            	    {
            	    dbg.location(89,71);
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
            } finally {dbg.exitSubRule(2);}



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
                dbg.location(89,78);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:78: ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(89,80);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

                dbg.location(89,92);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:92: ( tikz_styleorset )*
                while ( stream_tikz_styleorset.hasNext() ) {
                    dbg.location(89,92);
                    adaptor.addChild(root_1, stream_tikz_styleorset.nextTree());

                }
                stream_tikz_styleorset.reset();
                dbg.location(89,109);
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
        dbg.location(90, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzdocument");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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



        try { dbg.enterRule(getGrammarFileName(), "tikz_styleorset");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(95, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:2: ( tikz_style | tikz_set )
            int alt3=2;
            try { dbg.enterDecision(3);

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

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(3);}

            switch (alt3) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:4: tikz_style
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(96,4);
                    pushFollow(FOLLOW_tikz_style_in_tikz_styleorset364);
                    tikz_style6=tikz_style();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_style6.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:17: tikz_set
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(96,17);
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
        dbg.location(97, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_styleorset");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        try { dbg.enterRule(getGrammarFileName(), "dontcare_preamble");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(99, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:2: ( (~ ( BEGIN | TIKZSTYLE | TIKZSET ) )+ )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:4: (~ ( BEGIN | TIKZSTYLE | TIKZSET ) )+
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(100,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:4: (~ ( BEGIN | TIKZSTYLE | TIKZSET ) )+
            int cnt4=0;
            try { dbg.enterSubRule(4);

            loop4:
            do {
                int alt4=2;
                try { dbg.enterDecision(4);

                int LA4_0 = input.LA(1);

                if ( ((LA4_0>=END && LA4_0<=USETIKZLIB)||(LA4_0>=NODE && LA4_0<=70)) ) {
                    alt4=1;
                }


                } finally {dbg.exitDecision(4);}

                switch (alt4) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:5: ~ ( BEGIN | TIKZSTYLE | TIKZSET )
            	    {
            	    dbg.location(100,5);
            	    set8=(Token)input.LT(1);
            	    if ( (input.LA(1)>=END && input.LA(1)<=USETIKZLIB)||(input.LA(1)>=NODE && input.LA(1)<=70) ) {
            	        input.consume();
            	        adaptor.addChild(root_0, (Object)adaptor.create(set8));
            	        state.errorRecovery=false;
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        dbg.recognitionException(mse);
            	        throw mse;
            	    }


            	    }
            	    break;

            	default :
            	    if ( cnt4 >= 1 ) break loop4;
                        EarlyExitException eee =
                            new EarlyExitException(4, input);
                        dbg.recognitionException(eee);

                        throw eee;
                }
                cnt4++;
            } while (true);
            } finally {dbg.exitSubRule(4);}


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
        dbg.location(101, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "dontcare_preamble");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        try { dbg.enterRule(getGrammarFileName(), "otherbegin");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(102, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:2: ( BEGIN '{' idd '}' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:4: BEGIN '{' idd '}'
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(103,4);
            BEGIN9=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_otherbegin403); 
            BEGIN9_tree = (Object)adaptor.create(BEGIN9);
            adaptor.addChild(root_0, BEGIN9_tree);

            dbg.location(103,10);
            char_literal10=(Token)match(input,49,FOLLOW_49_in_otherbegin405); 
            char_literal10_tree = (Object)adaptor.create(char_literal10);
            adaptor.addChild(root_0, char_literal10_tree);

            dbg.location(103,14);
            pushFollow(FOLLOW_idd_in_otherbegin407);
            idd11=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd11.getTree());
            dbg.location(103,18);
            char_literal12=(Token)match(input,50,FOLLOW_50_in_otherbegin409); 
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
        dbg.location(104, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "otherbegin");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_TIKZSTYLE=new RewriteRuleTokenStream(adaptor,"token TIKZSTYLE");
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikz_style");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(106, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:2: ( TIKZSTYLE '{' idd '}' '=' tikz_options -> ^( IM_STYLE idd tikz_options ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:4: TIKZSTYLE '{' idd '}' '=' tikz_options
            {
            dbg.location(107,4);
            TIKZSTYLE13=(Token)match(input,TIKZSTYLE,FOLLOW_TIKZSTYLE_in_tikz_style420);  
            stream_TIKZSTYLE.add(TIKZSTYLE13);

            dbg.location(107,14);
            char_literal14=(Token)match(input,49,FOLLOW_49_in_tikz_style422);  
            stream_49.add(char_literal14);

            dbg.location(107,18);
            pushFollow(FOLLOW_idd_in_tikz_style424);
            idd15=idd();

            state._fsp--;

            stream_idd.add(idd15.getTree());
            dbg.location(107,22);
            char_literal16=(Token)match(input,50,FOLLOW_50_in_tikz_style426);  
            stream_50.add(char_literal16);

            dbg.location(107,26);
            char_literal17=(Token)match(input,EQU,FOLLOW_EQU_in_tikz_style428);  
            stream_EQU.add(char_literal17);

            dbg.location(107,30);
            pushFollow(FOLLOW_tikz_options_in_tikz_style430);
            tikz_options18=tikz_options();

            state._fsp--;

            stream_tikz_options.add(tikz_options18.getTree());


            // AST REWRITE
            // elements: idd, tikz_options
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
                dbg.location(107,46);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:46: ^( IM_STYLE idd tikz_options )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(107,48);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STYLE, "IM_STYLE"), root_1);

                dbg.location(107,57);
                adaptor.addChild(root_1, stream_idd.nextTree());
                dbg.location(107,61);
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
        dbg.location(108, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_style");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikz_style"

    public static class tikzpath_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpath"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:110:1: tikzpath : path_start ( tikz_options )? tikzpathi path_end -> ^( IM_PATH path_start ( tikz_options )? tikzpathi path_end ) ;
    public final simpletikzParser.tikzpath_return tikzpath() throws RecognitionException {
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_return path_start19 = null;

        simpletikzParser.tikz_options_return tikz_options20 = null;

        simpletikzParser.tikzpathi_return tikzpathi21 = null;

        simpletikzParser.path_end_return path_end22 = null;


        RewriteRuleSubtreeStream stream_path_end=new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_path_start=new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try { dbg.enterRule(getGrammarFileName(), "tikzpath");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(110, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:2: ( path_start ( tikz_options )? tikzpathi path_end -> ^( IM_PATH path_start ( tikz_options )? tikzpathi path_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:4: path_start ( tikz_options )? tikzpathi path_end
            {
            dbg.location(111,4);
            pushFollow(FOLLOW_path_start_in_tikzpath452);
            path_start19=path_start();

            state._fsp--;

            stream_path_start.add(path_start19.getTree());
            dbg.location(111,15);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:15: ( tikz_options )?
            int alt5=2;
            try { dbg.enterSubRule(5);
            try { dbg.enterDecision(5);

            int LA5_0 = input.LA(1);

            if ( (LA5_0==LBR) ) {
                alt5=1;
            }
            } finally {dbg.exitDecision(5);}

            switch (alt5) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:15: tikz_options
                    {
                    dbg.location(111,15);
                    pushFollow(FOLLOW_tikz_options_in_tikzpath454);
                    tikz_options20=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options20.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(5);}

            dbg.location(111,29);
            pushFollow(FOLLOW_tikzpathi_in_tikzpath457);
            tikzpathi21=tikzpathi();

            state._fsp--;

            stream_tikzpathi.add(tikzpathi21.getTree());
            dbg.location(111,39);
            pushFollow(FOLLOW_path_end_in_tikzpath459);
            path_end22=path_end();

            state._fsp--;

            stream_path_end.add(path_end22.getTree());


            // AST REWRITE
            // elements: tikzpathi, path_end, tikz_options, path_start
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 111:48: -> ^( IM_PATH path_start ( tikz_options )? tikzpathi path_end )
            {
                dbg.location(111,51);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:51: ^( IM_PATH path_start ( tikz_options )? tikzpathi path_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(111,53);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(111,61);
                adaptor.addChild(root_1, stream_path_start.nextTree());
                dbg.location(111,72);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:72: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(111,72);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                dbg.location(111,86);
                adaptor.addChild(root_1, stream_tikzpathi.nextTree());
                dbg.location(111,96);
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
        dbg.location(112, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzpath");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token SEMIC23=null;

        Object SEMIC23_tree=null;
        RewriteRuleTokenStream stream_SEMIC=new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try { dbg.enterRule(getGrammarFileName(), "path_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(113, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:114:2: ( SEMIC -> ^( IM_ENDTAG SEMIC ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:114:4: SEMIC
            {
            dbg.location(114,4);
            SEMIC23=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_path_end485);  
            stream_SEMIC.add(SEMIC23);



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
                dbg.location(114,13);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:114:13: ^( IM_ENDTAG SEMIC )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(114,15);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(114,25);
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
        dbg.location(115, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "path_end");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        simpletikzParser.coordornode_return coordornode24 = null;

        simpletikzParser.coordornode_return coordornode25 = null;

        simpletikzParser.tikz_options_return tikz_options26 = null;

        simpletikzParser.edgeop_return edgeop27 = null;

        simpletikzParser.coordornode_return coordornode28 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzpathi");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(117, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:2: ( coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:5: coordornode ( coordornode | ( tikz_options )? edgeop coordornode )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(118,5);
            pushFollow(FOLLOW_coordornode_in_tikzpathi505);
            coordornode24=coordornode();

            state._fsp--;

            adaptor.addChild(root_0, coordornode24.getTree());
            dbg.location(118,17);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:17: ( coordornode | ( tikz_options )? edgeop coordornode )*
            try { dbg.enterSubRule(7);

            loop7:
            do {
                int alt7=3;
                try { dbg.enterDecision(7);

                int LA7_0 = input.LA(1);

                if ( (LA7_0==LPAR||LA7_0==51||(LA7_0>=61 && LA7_0<=62)) ) {
                    alt7=1;
                }
                else if ( (LA7_0==LBR||(LA7_0>=53 && LA7_0<=60)) ) {
                    alt7=2;
                }


                } finally {dbg.exitDecision(7);}

                switch (alt7) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:18: coordornode
            	    {
            	    dbg.location(118,18);
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi508);
            	    coordornode25=coordornode();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode25.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:32: ( tikz_options )? edgeop coordornode
            	    {
            	    dbg.location(118,32);
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:32: ( tikz_options )?
            	    int alt6=2;
            	    try { dbg.enterSubRule(6);
            	    try { dbg.enterDecision(6);

            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0==LBR) ) {
            	        alt6=1;
            	    }
            	    } finally {dbg.exitDecision(6);}

            	    switch (alt6) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:32: tikz_options
            	            {
            	            dbg.location(118,32);
            	            pushFollow(FOLLOW_tikz_options_in_tikzpathi512);
            	            tikz_options26=tikz_options();

            	            state._fsp--;

            	            adaptor.addChild(root_0, tikz_options26.getTree());

            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(6);}

            	    dbg.location(118,52);
            	    pushFollow(FOLLOW_edgeop_in_tikzpathi515);
            	    edgeop27=edgeop();

            	    state._fsp--;

            	    dbg.location(118,54);
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi518);
            	    coordornode28=coordornode();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode28.getTree());

            	    }
            	    break;

            	default :
            	    break loop7;
                }
            } while (true);
            } finally {dbg.exitSubRule(7);}


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
        dbg.location(119, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzpathi");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        simpletikzParser.coord_return coord29 = null;

        simpletikzParser.tikznodei_return tikznodei30 = null;



        try { dbg.enterRule(getGrammarFileName(), "coordornode");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(121, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:2: ( coord | tikznodei )
            int alt8=2;
            try { dbg.enterDecision(8);

            int LA8_0 = input.LA(1);

            if ( (LA8_0==LPAR||(LA8_0>=61 && LA8_0<=62)) ) {
                alt8=1;
            }
            else if ( (LA8_0==51) ) {
                alt8=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 8, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(8);}

            switch (alt8) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:4: coord
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(122,4);
                    pushFollow(FOLLOW_coord_in_coordornode533);
                    coord29=coord();

                    state._fsp--;

                    adaptor.addChild(root_0, coord29.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:12: tikznodei
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(122,12);
                    pushFollow(FOLLOW_tikznodei_in_coordornode537);
                    tikznodei30=tikznodei();

                    state._fsp--;

                    adaptor.addChild(root_0, tikznodei30.getTree());

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
        dbg.location(123, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "coordornode");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token string_literal31=null;
        simpletikzParser.tikznode_return tikznode32 = null;


        Object string_literal31_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "tikznodei");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(125, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:2: ( 'node' tikznode )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:4: 'node' tikznode
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(126,10);
            string_literal31=(Token)match(input,51,FOLLOW_51_in_tikznodei549); 
            dbg.location(126,12);
            pushFollow(FOLLOW_tikznode_in_tikznodei552);
            tikznode32=tikznode();

            state._fsp--;

            adaptor.addChild(root_0, tikznode32.getTree());

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
        dbg.location(127, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikznodei");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        simpletikzParser.node_start_return node_start33 = null;

        simpletikzParser.tikznode_return tikznode34 = null;

        simpletikzParser.tikzpathi_return tikzpathi35 = null;

        simpletikzParser.path_end_return path_end36 = null;


        RewriteRuleSubtreeStream stream_node_start=new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_path_end=new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_tikznode=new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try { dbg.enterRule(getGrammarFileName(), "tikznodee");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(128, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:2: ( node_start tikznode ( tikzpathi )? path_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:4: node_start tikznode ( tikzpathi )? path_end
            {
            dbg.location(129,4);
            pushFollow(FOLLOW_node_start_in_tikznodee562);
            node_start33=node_start();

            state._fsp--;

            stream_node_start.add(node_start33.getTree());
            dbg.location(129,15);
            pushFollow(FOLLOW_tikznode_in_tikznodee564);
            tikznode34=tikznode();

            state._fsp--;

            stream_tikznode.add(tikznode34.getTree());
            dbg.location(129,24);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:24: ( tikzpathi )?
            int alt9=2;
            try { dbg.enterSubRule(9);
            try { dbg.enterDecision(9);

            int LA9_0 = input.LA(1);

            if ( (LA9_0==LPAR||LA9_0==51||(LA9_0>=61 && LA9_0<=62)) ) {
                alt9=1;
            }
            } finally {dbg.exitDecision(9);}

            switch (alt9) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:24: tikzpathi
                    {
                    dbg.location(129,24);
                    pushFollow(FOLLOW_tikzpathi_in_tikznodee566);
                    tikzpathi35=tikzpathi();

                    state._fsp--;

                    stream_tikzpathi.add(tikzpathi35.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(9);}

            dbg.location(129,35);
            pushFollow(FOLLOW_path_end_in_tikznodee569);
            path_end36=path_end();

            state._fsp--;

            stream_path_end.add(path_end36.getTree());


            // AST REWRITE
            // elements: tikznode, node_start, path_end, tikzpathi
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
                dbg.location(129,47);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:47: ^( IM_PATH node_start tikznode ( tikzpathi )? path_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(129,49);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(129,57);
                adaptor.addChild(root_1, stream_node_start.nextTree());
                dbg.location(129,68);
                adaptor.addChild(root_1, stream_tikznode.nextTree());
                dbg.location(129,77);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:77: ( tikzpathi )?
                if ( stream_tikzpathi.hasNext() ) {
                    dbg.location(129,77);
                    adaptor.addChild(root_1, stream_tikzpathi.nextTree());

                }
                stream_tikzpathi.reset();
                dbg.location(129,88);
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
        dbg.location(130, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikznodee");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token NODE37=null;

        Object NODE37_tree=null;
        RewriteRuleTokenStream stream_NODE=new RewriteRuleTokenStream(adaptor,"token NODE");

        try { dbg.enterRule(getGrammarFileName(), "node_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(131, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:4: NODE
            {
            dbg.location(132,4);
            NODE37=(Token)match(input,NODE,FOLLOW_NODE_in_node_start595);  
            stream_NODE.add(NODE37);



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
                dbg.location(132,12);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:12: ^( IM_STARTTAG NODE )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(132,14);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(132,26);
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
        dbg.location(133, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "node_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token string_literal39=null;
        simpletikzParser.nodename_return nodename38 = null;

        simpletikzParser.coord_return coord40 = null;

        simpletikzParser.tikzstring_return tikzstring41 = null;


        Object string_literal39_tree=null;
        RewriteRuleTokenStream stream_52=new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_coord=new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_tikzstring=new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try { dbg.enterRule(getGrammarFileName(), "tikznode");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(134, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:2: ( ( nodename )? ( 'at' coord )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:4: ( nodename )? ( 'at' coord )? tikzstring
            {
            dbg.location(135,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:4: ( nodename )?
            int alt10=2;
            try { dbg.enterSubRule(10);
            try { dbg.enterDecision(10);

            int LA10_0 = input.LA(1);

            if ( (LA10_0==LPAR) ) {
                alt10=1;
            }
            } finally {dbg.exitDecision(10);}

            switch (alt10) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:4: nodename
                    {
                    dbg.location(135,4);
                    pushFollow(FOLLOW_nodename_in_tikznode613);
                    nodename38=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename38.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(10);}

            dbg.location(135,14);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:14: ( 'at' coord )?
            int alt11=2;
            try { dbg.enterSubRule(11);
            try { dbg.enterDecision(11);

            int LA11_0 = input.LA(1);

            if ( (LA11_0==52) ) {
                alt11=1;
            }
            } finally {dbg.exitDecision(11);}

            switch (alt11) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:15: 'at' coord
                    {
                    dbg.location(135,15);
                    string_literal39=(Token)match(input,52,FOLLOW_52_in_tikznode617);  
                    stream_52.add(string_literal39);

                    dbg.location(135,20);
                    pushFollow(FOLLOW_coord_in_tikznode619);
                    coord40=coord();

                    state._fsp--;

                    stream_coord.add(coord40.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(11);}

            dbg.location(135,28);
            pushFollow(FOLLOW_tikzstring_in_tikznode623);
            tikzstring41=tikzstring();

            state._fsp--;

            stream_tikzstring.add(tikzstring41.getTree());


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
                dbg.location(135,43);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:43: ^( IM_NODE ( nodename )? ( coord )? tikzstring )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(135,45);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODE, "IM_NODE"), root_1);

                dbg.location(135,53);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:53: ( nodename )?
                if ( stream_nodename.hasNext() ) {
                    dbg.location(135,53);
                    adaptor.addChild(root_1, stream_nodename.nextTree());

                }
                stream_nodename.reset();
                dbg.location(135,63);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:63: ( coord )?
                if ( stream_coord.hasNext() ) {
                    dbg.location(135,63);
                    adaptor.addChild(root_1, stream_coord.nextTree());

                }
                stream_coord.reset();
                dbg.location(135,70);
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
        dbg.location(136, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikznode");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token set42=null;

        Object set42_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "edgeop");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(138, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:2: ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' | 'grid' | 'rectangle' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(139,2);
            set42=(Token)input.LT(1);
            if ( (input.LA(1)>=53 && input.LA(1)<=60) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set42));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                dbg.recognitionException(mse);
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
        dbg.location(140, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "edgeop");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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
        Token RPAR43=null;

        Object lc_tree=null;
        Object id_tree=null;
        Object RPAR43_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try { dbg.enterRule(getGrammarFileName(), "nodename");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(142, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:2: (lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:4: lc= LPAR id= ID RPAR
            {
            dbg.location(143,6);
            lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_nodename696);  
            stream_LPAR.add(lc);

            dbg.location(143,14);
            id=(Token)match(input,ID,FOLLOW_ID_in_nodename700);  
            stream_ID.add(id);

            dbg.location(143,18);
            RPAR43=(Token)match(input,RPAR,FOLLOW_RPAR_in_nodename702);  
            stream_RPAR.add(RPAR43);



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
                dbg.location(143,27);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:27: ^( IM_NODENAME[$lc] $id)
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(143,29);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODENAME, lc), root_1);

                dbg.location(143,46);
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
        dbg.location(144, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "nodename");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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
        Token KOMMA47=null;
        Token RPAR49=null;
        simpletikzParser.nodename_return nodename44 = null;

        simpletikzParser.coord_modifier_return coord_modifier45 = null;

        simpletikzParser.numberunit_return numberunit46 = null;

        simpletikzParser.numberunit_return numberunit48 = null;


        Object lc_tree=null;
        Object KOMMA47_tree=null;
        Object RPAR49_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_numberunit=new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier=new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try { dbg.enterRule(getGrammarFileName(), "coord");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(146, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) )
            int alt13=2;
            try { dbg.enterDecision(13);

            int LA13_0 = input.LA(1);

            if ( (LA13_0==LPAR) ) {
                int LA13_1 = input.LA(2);

                if ( (LA13_1==ID) ) {
                    alt13=1;
                }
                else if ( ((LA13_1>=FLOAT && LA13_1<=INT)) ) {
                    alt13=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 13, 1, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
            }
            else if ( ((LA13_0>=61 && LA13_0<=62)) ) {
                alt13=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 13, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(13);}

            switch (alt13) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:6: nodename
                    {
                    dbg.location(147,6);
                    pushFollow(FOLLOW_nodename_in_coord727);
                    nodename44=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename44.getTree());


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
                        dbg.location(147,26);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:26: ^( IM_COORD nodename )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(147,28);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, "IM_COORD"), root_1);

                        dbg.location(147,37);
                        adaptor.addChild(root_1, stream_nodename.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    {
                    dbg.location(148,5);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:7: ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR
                    {
                    dbg.location(148,7);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:7: ( coord_modifier )?
                    int alt12=2;
                    try { dbg.enterSubRule(12);
                    try { dbg.enterDecision(12);

                    int LA12_0 = input.LA(1);

                    if ( ((LA12_0>=61 && LA12_0<=62)) ) {
                        alt12=1;
                    }
                    } finally {dbg.exitDecision(12);}

                    switch (alt12) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:7: coord_modifier
                            {
                            dbg.location(148,7);
                            pushFollow(FOLLOW_coord_modifier_in_coord751);
                            coord_modifier45=coord_modifier();

                            state._fsp--;

                            stream_coord_modifier.add(coord_modifier45.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(12);}

                    dbg.location(148,25);
                    lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_coord756);  
                    stream_LPAR.add(lc);

                    dbg.location(148,31);
                    pushFollow(FOLLOW_numberunit_in_coord758);
                    numberunit46=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit46.getTree());
                    dbg.location(148,42);
                    KOMMA47=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_coord760);  
                    stream_KOMMA.add(KOMMA47);

                    dbg.location(148,48);
                    pushFollow(FOLLOW_numberunit_in_coord762);
                    numberunit48=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit48.getTree());
                    dbg.location(148,59);
                    RPAR49=(Token)match(input,RPAR,FOLLOW_RPAR_in_coord764);  
                    stream_RPAR.add(RPAR49);


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
                        dbg.location(148,69);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:69: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(148,71);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, lc), root_1);

                        dbg.location(148,85);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:85: ( coord_modifier )?
                        if ( stream_coord_modifier.hasNext() ) {
                            dbg.location(148,85);
                            adaptor.addChild(root_1, stream_coord_modifier.nextTree());

                        }
                        stream_coord_modifier.reset();
                        dbg.location(148,101);
                        if ( !(stream_numberunit.hasNext()) ) {
                            throw new RewriteEarlyExitException();
                        }
                        while ( stream_numberunit.hasNext() ) {
                            dbg.location(148,101);
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
        dbg.location(149, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "coord");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token set50=null;

        Object set50_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "coord_modifier");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(151, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:2: ( '+' | '++' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(152,2);
            set50=(Token)input.LT(1);
            if ( (input.LA(1)>=61 && input.LA(1)<=62) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set50));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                dbg.recognitionException(mse);
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
        dbg.location(153, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "coord_modifier");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        simpletikzParser.number_return number51 = null;

        simpletikzParser.unit_return unit52 = null;


        RewriteRuleSubtreeStream stream_unit=new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
        try { dbg.enterRule(getGrammarFileName(), "numberunit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(155, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:4: number ( unit )?
            {
            dbg.location(156,4);
            pushFollow(FOLLOW_number_in_numberunit806);
            number51=number();

            state._fsp--;

            stream_number.add(number51.getTree());
            dbg.location(156,11);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:11: ( unit )?
            int alt14=2;
            try { dbg.enterSubRule(14);
            try { dbg.enterDecision(14);

            int LA14_0 = input.LA(1);

            if ( ((LA14_0>=63 && LA14_0<=67)) ) {
                alt14=1;
            }
            } finally {dbg.exitDecision(14);}

            switch (alt14) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:11: unit
                    {
                    dbg.location(156,11);
                    pushFollow(FOLLOW_unit_in_numberunit808);
                    unit52=unit();

                    state._fsp--;

                    stream_unit.add(unit52.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(14);}



            // AST REWRITE
            // elements: unit, number
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
                dbg.location(156,20);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:20: ^( IM_NUMBERUNIT number ( unit )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(156,22);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

                dbg.location(156,36);
                adaptor.addChild(root_1, stream_number.nextTree());
                dbg.location(156,43);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:43: ( unit )?
                if ( stream_unit.hasNext() ) {
                    dbg.location(156,43);
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
        dbg.location(157, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "numberunit");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token set53=null;

        Object set53_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "number");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(158, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:159:2: ( ( FLOAT | INT ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:159:4: ( FLOAT | INT )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(159,4);
            set53=(Token)input.LT(1);
            if ( (input.LA(1)>=FLOAT && input.LA(1)<=INT) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set53));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                dbg.recognitionException(mse);
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
        dbg.location(160, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "number");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token set54=null;

        Object set54_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(161, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(162,2);
            set54=(Token)input.LT(1);
            if ( (input.LA(1)>=63 && input.LA(1)<=67) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set54));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                dbg.recognitionException(mse);
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
        dbg.location(163, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "unit");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        simpletikzParser.path_start_tag_return path_start_tag55 = null;


        RewriteRuleSubtreeStream stream_path_start_tag=new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try { dbg.enterRule(getGrammarFileName(), "path_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(165, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:4: path_start_tag
            {
            dbg.location(166,4);
            pushFollow(FOLLOW_path_start_tag_in_path_start875);
            path_start_tag55=path_start_tag();

            state._fsp--;

            stream_path_start_tag.add(path_start_tag55.getTree());


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
                dbg.location(166,22);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:22: ^( IM_STARTTAG path_start_tag )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(166,24);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(166,36);
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
        dbg.location(167, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "path_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token set56=null;

        Object set56_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "path_start_tag");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(168, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:2: ( DRAW | FILL | PATH )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(169,2);
            set56=(Token)input.LT(1);
            if ( (input.LA(1)>=DRAW && input.LA(1)<=FILL) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set56));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                dbg.recognitionException(mse);
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
        dbg.location(170, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "path_start_tag");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        simpletikzParser.tikzpicture_start_return tikzpicture_start57 = null;

        simpletikzParser.tikz_options_return tikz_options58 = null;

        simpletikzParser.tikzbody_return tikzbody59 = null;

        simpletikzParser.tikzpicture_end_return tikzpicture_end60 = null;


        RewriteRuleSubtreeStream stream_tikzpicture_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikzpicture");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(172, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            dbg.location(173,5);
            pushFollow(FOLLOW_tikzpicture_start_in_tikzpicture914);
            tikzpicture_start57=tikzpicture_start();

            state._fsp--;

            stream_tikzpicture_start.add(tikzpicture_start57.getTree());
            dbg.location(173,23);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:23: ( tikz_options )?
            int alt15=2;
            try { dbg.enterSubRule(15);
            try { dbg.enterDecision(15);

            try {
                isCyclicDecision = true;
                alt15 = dfa15.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(15);}

            switch (alt15) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:23: tikz_options
                    {
                    dbg.location(173,23);
                    pushFollow(FOLLOW_tikz_options_in_tikzpicture916);
                    tikz_options58=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options58.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(15);}

            dbg.location(173,37);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:37: ( tikzbody )?
            int alt16=2;
            try { dbg.enterSubRule(16);
            try { dbg.enterDecision(16);

            int LA16_0 = input.LA(1);

            if ( (LA16_0==BEGIN||(LA16_0>=USETIKZLIB && LA16_0<=70)) ) {
                alt16=1;
            }
            else if ( (LA16_0==END) ) {
                int LA16_2 = input.LA(2);

                if ( (LA16_2==49) ) {
                    int LA16_3 = input.LA(3);

                    if ( (LA16_3==ID) ) {
                        alt16=1;
                    }
                }
            }
            } finally {dbg.exitDecision(16);}

            switch (alt16) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:37: tikzbody
                    {
                    dbg.location(173,37);
                    pushFollow(FOLLOW_tikzbody_in_tikzpicture919);
                    tikzbody59=tikzbody();

                    state._fsp--;

                    stream_tikzbody.add(tikzbody59.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(16);}

            dbg.location(173,47);
            pushFollow(FOLLOW_tikzpicture_end_in_tikzpicture922);
            tikzpicture_end60=tikzpicture_end();

            state._fsp--;

            stream_tikzpicture_end.add(tikzpicture_end60.getTree());


            // AST REWRITE
            // elements: tikz_options, tikzpicture_end, tikzpicture_start, tikzbody
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
                dbg.location(173,67);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(173,69);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PICTURE, "IM_PICTURE"), root_1);

                dbg.location(173,80);
                adaptor.addChild(root_1, stream_tikzpicture_start.nextTree());
                dbg.location(173,98);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:98: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(173,98);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                dbg.location(173,112);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:112: ( tikzbody )?
                if ( stream_tikzbody.hasNext() ) {
                    dbg.location(173,112);
                    adaptor.addChild(root_1, stream_tikzbody.nextTree());

                }
                stream_tikzbody.reset();
                dbg.location(173,122);
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
        dbg.location(174, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzpicture");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token BEGIN61=null;
        Token char_literal62=null;
        Token string_literal63=null;
        Token char_literal64=null;

        Object BEGIN61_tree=null;
        Object char_literal62_tree=null;
        Object string_literal63_tree=null;
        Object char_literal64_tree=null;
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_68=new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_BEGIN=new RewriteRuleTokenStream(adaptor,"token BEGIN");
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");

        try { dbg.enterRule(getGrammarFileName(), "tikzpicture_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(175, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:2: ( BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:4: BEGIN '{' 'tikzpicture' '}'
            {
            dbg.location(176,4);
            BEGIN61=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_tikzpicture_start949);  
            stream_BEGIN.add(BEGIN61);

            dbg.location(176,10);
            char_literal62=(Token)match(input,49,FOLLOW_49_in_tikzpicture_start951);  
            stream_49.add(char_literal62);

            dbg.location(176,14);
            string_literal63=(Token)match(input,68,FOLLOW_68_in_tikzpicture_start953);  
            stream_68.add(string_literal63);

            dbg.location(176,28);
            char_literal64=(Token)match(input,50,FOLLOW_50_in_tikzpicture_start955);  
            stream_50.add(char_literal64);



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
                dbg.location(176,35);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:35: ^( IM_STARTTAG BEGIN )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(176,37);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(176,49);
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
        dbg.location(177, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzpicture_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token END65=null;
        Token char_literal66=null;
        Token string_literal67=null;
        Token char_literal68=null;

        Object END65_tree=null;
        Object char_literal66_tree=null;
        Object string_literal67_tree=null;
        Object char_literal68_tree=null;
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_68=new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_END=new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");

        try { dbg.enterRule(getGrammarFileName(), "tikzpicture_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(178, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:2: ( END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:4: END '{' 'tikzpicture' '}'
            {
            dbg.location(179,4);
            END65=(Token)match(input,END,FOLLOW_END_in_tikzpicture_end973);  
            stream_END.add(END65);

            dbg.location(179,8);
            char_literal66=(Token)match(input,49,FOLLOW_49_in_tikzpicture_end975);  
            stream_49.add(char_literal66);

            dbg.location(179,12);
            string_literal67=(Token)match(input,68,FOLLOW_68_in_tikzpicture_end977);  
            stream_68.add(string_literal67);

            dbg.location(179,26);
            char_literal68=(Token)match(input,50,FOLLOW_50_in_tikzpicture_end979);  
            stream_50.add(char_literal68);



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
                dbg.location(179,33);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:33: ^( IM_ENDTAG END )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(179,35);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(179,45);
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
        dbg.location(180, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzpicture_end");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        simpletikzParser.tikzscope_return tikzscope69 = null;

        simpletikzParser.tikzpath_return tikzpath70 = null;

        simpletikzParser.tikznodee_return tikznodee71 = null;

        simpletikzParser.dontcare_body_return dontcare_body72 = null;

        simpletikzParser.tikz_set_return tikz_set73 = null;

        simpletikzParser.tikz_style_return tikz_style74 = null;

        simpletikzParser.otherbegin_return otherbegin75 = null;

        simpletikzParser.otherend_return otherend76 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzbody");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(181, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:2: ( ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )+ )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:4: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )+
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(182,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:4: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )+
            int cnt17=0;
            try { dbg.enterSubRule(17);

            loop17:
            do {
                int alt17=9;
                try { dbg.enterDecision(17);

                try {
                    isCyclicDecision = true;
                    alt17 = dfa17.predict(input);
                }
                catch (NoViableAltException nvae) {
                    dbg.recognitionException(nvae);
                    throw nvae;
                }
                } finally {dbg.exitDecision(17);}

                switch (alt17) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:6: tikzscope
            	    {
            	    dbg.location(182,6);
            	    pushFollow(FOLLOW_tikzscope_in_tikzbody999);
            	    tikzscope69=tikzscope();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzscope69.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:18: tikzpath
            	    {
            	    dbg.location(182,18);
            	    pushFollow(FOLLOW_tikzpath_in_tikzbody1003);
            	    tikzpath70=tikzpath();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzpath70.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:29: tikznodee
            	    {
            	    dbg.location(182,29);
            	    pushFollow(FOLLOW_tikznodee_in_tikzbody1007);
            	    tikznodee71=tikznodee();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikznodee71.getTree());

            	    }
            	    break;
            	case 4 :
            	    dbg.enterAlt(4);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:41: dontcare_body
            	    {
            	    dbg.location(182,41);
            	    pushFollow(FOLLOW_dontcare_body_in_tikzbody1011);
            	    dontcare_body72=dontcare_body();

            	    state._fsp--;

            	    adaptor.addChild(root_0, dontcare_body72.getTree());

            	    }
            	    break;
            	case 5 :
            	    dbg.enterAlt(5);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:57: tikz_set
            	    {
            	    dbg.location(182,57);
            	    pushFollow(FOLLOW_tikz_set_in_tikzbody1015);
            	    tikz_set73=tikz_set();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikz_set73.getTree());

            	    }
            	    break;
            	case 6 :
            	    dbg.enterAlt(6);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:68: tikz_style
            	    {
            	    dbg.location(182,68);
            	    pushFollow(FOLLOW_tikz_style_in_tikzbody1019);
            	    tikz_style74=tikz_style();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikz_style74.getTree());

            	    }
            	    break;
            	case 7 :
            	    dbg.enterAlt(7);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:81: otherbegin
            	    {
            	    dbg.location(182,81);
            	    pushFollow(FOLLOW_otherbegin_in_tikzbody1023);
            	    otherbegin75=otherbegin();

            	    state._fsp--;

            	    adaptor.addChild(root_0, otherbegin75.getTree());

            	    }
            	    break;
            	case 8 :
            	    dbg.enterAlt(8);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:93: otherend
            	    {
            	    dbg.location(182,93);
            	    pushFollow(FOLLOW_otherend_in_tikzbody1026);
            	    otherend76=otherend();

            	    state._fsp--;

            	    adaptor.addChild(root_0, otherend76.getTree());

            	    }
            	    break;

            	default :
            	    if ( cnt17 >= 1 ) break loop17;
                        EarlyExitException eee =
                            new EarlyExitException(17, input);
                        dbg.recognitionException(eee);

                        throw eee;
                }
                cnt17++;
            } while (true);
            } finally {dbg.exitSubRule(17);}


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
        dbg.location(183, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzbody");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token set77=null;

        Object set77_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "dontcare_body");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(184, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:185:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )+ )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:185:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )+
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(185,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:185:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )+
            int cnt18=0;
            try { dbg.enterSubRule(18);

            loop18:
            do {
                int alt18=2;
                try { dbg.enterDecision(18);

                int LA18_0 = input.LA(1);

                if ( (LA18_0==USETIKZLIB||(LA18_0>=LPAR && LA18_0<=70)) ) {
                    alt18=1;
                }


                } finally {dbg.exitDecision(18);}

                switch (alt18) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:185:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET )
            	    {
            	    dbg.location(185,5);
            	    set77=(Token)input.LT(1);
            	    if ( input.LA(1)==USETIKZLIB||(input.LA(1)>=LPAR && input.LA(1)<=70) ) {
            	        input.consume();
            	        adaptor.addChild(root_0, (Object)adaptor.create(set77));
            	        state.errorRecovery=false;
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        dbg.recognitionException(mse);
            	        throw mse;
            	    }


            	    }
            	    break;

            	default :
            	    if ( cnt18 >= 1 ) break loop18;
                        EarlyExitException eee =
                            new EarlyExitException(18, input);
                        dbg.recognitionException(eee);

                        throw eee;
                }
                cnt18++;
            } while (true);
            } finally {dbg.exitSubRule(18);}


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
        dbg.location(186, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "dontcare_body");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token END78=null;
        Token char_literal79=null;
        Token char_literal81=null;
        simpletikzParser.idd_return idd80 = null;


        Object END78_tree=null;
        Object char_literal79_tree=null;
        Object char_literal81_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "otherend");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(187, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:2: ( END '{' idd '}' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:4: END '{' idd '}'
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(188,4);
            END78=(Token)match(input,END,FOLLOW_END_in_otherend1086); 
            END78_tree = (Object)adaptor.create(END78);
            adaptor.addChild(root_0, END78_tree);

            dbg.location(188,8);
            char_literal79=(Token)match(input,49,FOLLOW_49_in_otherend1088); 
            char_literal79_tree = (Object)adaptor.create(char_literal79);
            adaptor.addChild(root_0, char_literal79_tree);

            dbg.location(188,12);
            pushFollow(FOLLOW_idd_in_otherend1090);
            idd80=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd80.getTree());
            dbg.location(188,16);
            char_literal81=(Token)match(input,50,FOLLOW_50_in_otherend1092); 
            char_literal81_tree = (Object)adaptor.create(char_literal81);
            adaptor.addChild(root_0, char_literal81_tree);


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
        dbg.location(189, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "otherend");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        simpletikzParser.tikzscope_start_return tikzscope_start82 = null;

        simpletikzParser.tikz_options_return tikz_options83 = null;

        simpletikzParser.tikzbody_return tikzbody84 = null;

        simpletikzParser.tikzscope_end_return tikzscope_end85 = null;


        RewriteRuleSubtreeStream stream_tikzscope_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikzscope");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(194, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:2: ( tikzscope_start ( tikz_options )? tikzbody tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:4: tikzscope_start ( tikz_options )? tikzbody tikzscope_end
            {
            dbg.location(195,4);
            pushFollow(FOLLOW_tikzscope_start_in_tikzscope1106);
            tikzscope_start82=tikzscope_start();

            state._fsp--;

            stream_tikzscope_start.add(tikzscope_start82.getTree());
            dbg.location(195,20);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:20: ( tikz_options )?
            int alt19=2;
            try { dbg.enterSubRule(19);
            try { dbg.enterDecision(19);

            try {
                isCyclicDecision = true;
                alt19 = dfa19.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(19);}

            switch (alt19) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:20: tikz_options
                    {
                    dbg.location(195,20);
                    pushFollow(FOLLOW_tikz_options_in_tikzscope1108);
                    tikz_options83=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options83.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(19);}

            dbg.location(195,34);
            pushFollow(FOLLOW_tikzbody_in_tikzscope1111);
            tikzbody84=tikzbody();

            state._fsp--;

            stream_tikzbody.add(tikzbody84.getTree());
            dbg.location(195,43);
            pushFollow(FOLLOW_tikzscope_end_in_tikzscope1113);
            tikzscope_end85=tikzscope_end();

            state._fsp--;

            stream_tikzscope_end.add(tikzscope_end85.getTree());


            // AST REWRITE
            // elements: tikz_options, tikzscope_end, tikzscope_start, tikzbody
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
                dbg.location(195,61);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:61: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(195,63);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_SCOPE, "IM_SCOPE"), root_1);

                dbg.location(195,72);
                adaptor.addChild(root_1, stream_tikzscope_start.nextTree());
                dbg.location(195,88);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:88: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(195,88);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                dbg.location(195,102);
                adaptor.addChild(root_1, stream_tikzbody.nextTree());
                dbg.location(195,111);
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
        dbg.location(196, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzscope");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token BEGIN86=null;
        Token char_literal87=null;
        Token string_literal88=null;
        Token char_literal89=null;

        Object BEGIN86_tree=null;
        Object char_literal87_tree=null;
        Object string_literal88_tree=null;
        Object char_literal89_tree=null;
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_69=new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_BEGIN=new RewriteRuleTokenStream(adaptor,"token BEGIN");
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");

        try { dbg.enterRule(getGrammarFileName(), "tikzscope_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(197, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:2: ( BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:4: BEGIN '{' 'scope' '}'
            {
            dbg.location(198,4);
            BEGIN86=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_tikzscope_start1139);  
            stream_BEGIN.add(BEGIN86);

            dbg.location(198,10);
            char_literal87=(Token)match(input,49,FOLLOW_49_in_tikzscope_start1141);  
            stream_49.add(char_literal87);

            dbg.location(198,14);
            string_literal88=(Token)match(input,69,FOLLOW_69_in_tikzscope_start1143);  
            stream_69.add(string_literal88);

            dbg.location(198,22);
            char_literal89=(Token)match(input,50,FOLLOW_50_in_tikzscope_start1145);  
            stream_50.add(char_literal89);



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
                dbg.location(198,29);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:29: ^( IM_STARTTAG BEGIN )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(198,31);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(198,43);
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
        dbg.location(199, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzscope_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token END90=null;
        Token char_literal91=null;
        Token string_literal92=null;
        Token char_literal93=null;

        Object END90_tree=null;
        Object char_literal91_tree=null;
        Object string_literal92_tree=null;
        Object char_literal93_tree=null;
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_69=new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_END=new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");

        try { dbg.enterRule(getGrammarFileName(), "tikzscope_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(200, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:2: ( END '{' 'scope' '}' -> ^( IM_ENDTAG END ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:4: END '{' 'scope' '}'
            {
            dbg.location(201,4);
            END90=(Token)match(input,END,FOLLOW_END_in_tikzscope_end1163);  
            stream_END.add(END90);

            dbg.location(201,8);
            char_literal91=(Token)match(input,49,FOLLOW_49_in_tikzscope_end1165);  
            stream_49.add(char_literal91);

            dbg.location(201,12);
            string_literal92=(Token)match(input,69,FOLLOW_69_in_tikzscope_end1167);  
            stream_69.add(string_literal92);

            dbg.location(201,20);
            char_literal93=(Token)match(input,50,FOLLOW_50_in_tikzscope_end1169);  
            stream_50.add(char_literal93);



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
                dbg.location(201,27);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:27: ^( IM_ENDTAG END )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(201,29);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(201,39);
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
        dbg.location(202, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzscope_end");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token char_literal96=null;
        Token char_literal98=null;
        simpletikzParser.squarebr_start_return squarebr_start94 = null;

        simpletikzParser.option_return option95 = null;

        simpletikzParser.option_return option97 = null;

        simpletikzParser.squarebr_end_return squarebr_end99 = null;


        Object char_literal96_tree=null;
        Object char_literal98_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_squarebr_start=new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_squarebr_end=new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try { dbg.enterRule(getGrammarFileName(), "tikz_options");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(204, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            dbg.location(205,5);
            pushFollow(FOLLOW_squarebr_start_in_tikz_options1189);
            squarebr_start94=squarebr_start();

            state._fsp--;

            stream_squarebr_start.add(squarebr_start94.getTree());
            dbg.location(205,20);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:20: ( option ( ',' option )* ( ',' )? )?
            int alt22=2;
            try { dbg.enterSubRule(22);
            try { dbg.enterDecision(22);

            int LA22_0 = input.LA(1);

            if ( (LA22_0==ID) ) {
                alt22=1;
            }
            } finally {dbg.exitDecision(22);}

            switch (alt22) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:21: option ( ',' option )* ( ',' )?
                    {
                    dbg.location(205,21);
                    pushFollow(FOLLOW_option_in_tikz_options1192);
                    option95=option();

                    state._fsp--;

                    stream_option.add(option95.getTree());
                    dbg.location(205,28);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:28: ( ',' option )*
                    try { dbg.enterSubRule(20);

                    loop20:
                    do {
                        int alt20=2;
                        try { dbg.enterDecision(20);

                        int LA20_0 = input.LA(1);

                        if ( (LA20_0==KOMMA) ) {
                            int LA20_1 = input.LA(2);

                            if ( (LA20_1==ID) ) {
                                alt20=1;
                            }


                        }


                        } finally {dbg.exitDecision(20);}

                        switch (alt20) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:29: ',' option
                    	    {
                    	    dbg.location(205,29);
                    	    char_literal96=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options1195);  
                    	    stream_KOMMA.add(char_literal96);

                    	    dbg.location(205,33);
                    	    pushFollow(FOLLOW_option_in_tikz_options1197);
                    	    option97=option();

                    	    state._fsp--;

                    	    stream_option.add(option97.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop20;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(20);}

                    dbg.location(205,42);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:42: ( ',' )?
                    int alt21=2;
                    try { dbg.enterSubRule(21);
                    try { dbg.enterDecision(21);

                    int LA21_0 = input.LA(1);

                    if ( (LA21_0==KOMMA) ) {
                        alt21=1;
                    }
                    } finally {dbg.exitDecision(21);}

                    switch (alt21) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:42: ','
                            {
                            dbg.location(205,42);
                            char_literal98=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options1201);  
                            stream_KOMMA.add(char_literal98);


                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(21);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(22);}

            dbg.location(205,49);
            pushFollow(FOLLOW_squarebr_end_in_tikz_options1206);
            squarebr_end99=squarebr_end();

            state._fsp--;

            stream_squarebr_end.add(squarebr_end99.getTree());


            // AST REWRITE
            // elements: squarebr_end, option, squarebr_start
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
                dbg.location(205,66);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(205,68);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTIONS, "IM_OPTIONS"), root_1);

                dbg.location(205,79);
                adaptor.addChild(root_1, stream_squarebr_start.nextTree());
                dbg.location(205,94);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:94: ( option )*
                while ( stream_option.hasNext() ) {
                    dbg.location(205,94);
                    adaptor.addChild(root_1, stream_option.nextTree());

                }
                stream_option.reset();
                dbg.location(205,102);
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
        dbg.location(206, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_options");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token LBR100=null;

        Object LBR100_tree=null;
        RewriteRuleTokenStream stream_LBR=new RewriteRuleTokenStream(adaptor,"token LBR");

        try { dbg.enterRule(getGrammarFileName(), "squarebr_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(207, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:2: ( LBR -> ^( IM_STARTTAG LBR ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:4: LBR
            {
            dbg.location(208,4);
            LBR100=(Token)match(input,LBR,FOLLOW_LBR_in_squarebr_start1230);  
            stream_LBR.add(LBR100);



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
                dbg.location(208,11);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:11: ^( IM_STARTTAG LBR )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(208,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(208,25);
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
        dbg.location(209, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "squarebr_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token RBR101=null;

        Object RBR101_tree=null;
        RewriteRuleTokenStream stream_RBR=new RewriteRuleTokenStream(adaptor,"token RBR");

        try { dbg.enterRule(getGrammarFileName(), "squarebr_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(210, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:211:2: ( RBR -> ^( IM_ENDTAG RBR ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:211:4: RBR
            {
            dbg.location(211,4);
            RBR101=(Token)match(input,RBR,FOLLOW_RBR_in_squarebr_end1248);  
            stream_RBR.add(RBR101);



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
                dbg.location(211,11);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:211:11: ^( IM_ENDTAG RBR )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(211,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(211,23);
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
        dbg.location(212, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "squarebr_end");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token char_literal104=null;
        simpletikzParser.tikz_set_start_return tikz_set_start102 = null;

        simpletikzParser.option_return option103 = null;

        simpletikzParser.option_return option105 = null;

        simpletikzParser.roundbr_end_return roundbr_end106 = null;


        Object char_literal104_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_tikz_set_start=new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end=new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try { dbg.enterRule(getGrammarFileName(), "tikz_set");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(214, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:2: ( tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:5: tikz_set_start ( option ( ',' option )* )? roundbr_end
            {
            dbg.location(215,5);
            pushFollow(FOLLOW_tikz_set_start_in_tikz_set1270);
            tikz_set_start102=tikz_set_start();

            state._fsp--;

            stream_tikz_set_start.add(tikz_set_start102.getTree());
            dbg.location(215,20);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:20: ( option ( ',' option )* )?
            int alt24=2;
            try { dbg.enterSubRule(24);
            try { dbg.enterDecision(24);

            int LA24_0 = input.LA(1);

            if ( (LA24_0==ID) ) {
                alt24=1;
            }
            } finally {dbg.exitDecision(24);}

            switch (alt24) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:21: option ( ',' option )*
                    {
                    dbg.location(215,21);
                    pushFollow(FOLLOW_option_in_tikz_set1273);
                    option103=option();

                    state._fsp--;

                    stream_option.add(option103.getTree());
                    dbg.location(215,28);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:28: ( ',' option )*
                    try { dbg.enterSubRule(23);

                    loop23:
                    do {
                        int alt23=2;
                        try { dbg.enterDecision(23);

                        int LA23_0 = input.LA(1);

                        if ( (LA23_0==KOMMA) ) {
                            alt23=1;
                        }


                        } finally {dbg.exitDecision(23);}

                        switch (alt23) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:29: ',' option
                    	    {
                    	    dbg.location(215,29);
                    	    char_literal104=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_set1276);  
                    	    stream_KOMMA.add(char_literal104);

                    	    dbg.location(215,33);
                    	    pushFollow(FOLLOW_option_in_tikz_set1278);
                    	    option105=option();

                    	    state._fsp--;

                    	    stream_option.add(option105.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop23;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(23);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(24);}

            dbg.location(215,44);
            pushFollow(FOLLOW_roundbr_end_in_tikz_set1284);
            roundbr_end106=roundbr_end();

            state._fsp--;

            stream_roundbr_end.add(roundbr_end106.getTree());


            // AST REWRITE
            // elements: tikz_set_start, option, roundbr_end
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
                dbg.location(215,59);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:59: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(215,61);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_TIKZSET, "IM_TIKZSET"), root_1);

                dbg.location(215,72);
                adaptor.addChild(root_1, stream_tikz_set_start.nextTree());
                dbg.location(215,87);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:215:87: ( option )*
                while ( stream_option.hasNext() ) {
                    dbg.location(215,87);
                    adaptor.addChild(root_1, stream_option.nextTree());

                }
                stream_option.reset();
                dbg.location(215,95);
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
        dbg.location(216, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_set");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token TIKZSET107=null;
        Token char_literal108=null;

        Object TIKZSET107_tree=null;
        Object char_literal108_tree=null;
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_TIKZSET=new RewriteRuleTokenStream(adaptor,"token TIKZSET");

        try { dbg.enterRule(getGrammarFileName(), "tikz_set_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(217, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:2: ( TIKZSET '{' -> ^( IM_STARTTAG ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:4: TIKZSET '{'
            {
            dbg.location(218,4);
            TIKZSET107=(Token)match(input,TIKZSET,FOLLOW_TIKZSET_in_tikz_set_start1307);  
            stream_TIKZSET.add(TIKZSET107);

            dbg.location(218,12);
            char_literal108=(Token)match(input,49,FOLLOW_49_in_tikz_set_start1309);  
            stream_49.add(char_literal108);



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
                dbg.location(218,20);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:20: ^( IM_STARTTAG )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(218,22);
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
        dbg.location(219, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_set_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token char_literal111=null;
        simpletikzParser.usetikzlib_start_return usetikzlib_start109 = null;

        simpletikzParser.idd_return idd110 = null;

        simpletikzParser.idd_return idd112 = null;

        simpletikzParser.roundbr_end_return roundbr_end113 = null;


        Object char_literal111_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_usetikzlib_start=new RewriteRuleSubtreeStream(adaptor,"rule usetikzlib_start");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_roundbr_end=new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        try { dbg.enterRule(getGrammarFileName(), "usetikzlib");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(221, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:2: ( usetikzlib_start idd ( ',' idd )* roundbr_end -> ^( IM_USETIKZLIB usetikzlib_start ( idd )* roundbr_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:4: usetikzlib_start idd ( ',' idd )* roundbr_end
            {
            dbg.location(222,4);
            pushFollow(FOLLOW_usetikzlib_start_in_usetikzlib1330);
            usetikzlib_start109=usetikzlib_start();

            state._fsp--;

            stream_usetikzlib_start.add(usetikzlib_start109.getTree());
            dbg.location(222,21);
            pushFollow(FOLLOW_idd_in_usetikzlib1332);
            idd110=idd();

            state._fsp--;

            stream_idd.add(idd110.getTree());
            dbg.location(222,25);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:25: ( ',' idd )*
            try { dbg.enterSubRule(25);

            loop25:
            do {
                int alt25=2;
                try { dbg.enterDecision(25);

                int LA25_0 = input.LA(1);

                if ( (LA25_0==KOMMA) ) {
                    alt25=1;
                }


                } finally {dbg.exitDecision(25);}

                switch (alt25) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:26: ',' idd
            	    {
            	    dbg.location(222,26);
            	    char_literal111=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_usetikzlib1335);  
            	    stream_KOMMA.add(char_literal111);

            	    dbg.location(222,30);
            	    pushFollow(FOLLOW_idd_in_usetikzlib1337);
            	    idd112=idd();

            	    state._fsp--;

            	    stream_idd.add(idd112.getTree());

            	    }
            	    break;

            	default :
            	    break loop25;
                }
            } while (true);
            } finally {dbg.exitSubRule(25);}

            dbg.location(222,36);
            pushFollow(FOLLOW_roundbr_end_in_usetikzlib1341);
            roundbr_end113=roundbr_end();

            state._fsp--;

            stream_roundbr_end.add(roundbr_end113.getTree());


            // AST REWRITE
            // elements: usetikzlib_start, roundbr_end, idd
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
                dbg.location(222,51);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:51: ^( IM_USETIKZLIB usetikzlib_start ( idd )* roundbr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(222,53);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_USETIKZLIB, "IM_USETIKZLIB"), root_1);

                dbg.location(222,67);
                adaptor.addChild(root_1, stream_usetikzlib_start.nextTree());
                dbg.location(222,84);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:222:84: ( idd )*
                while ( stream_idd.hasNext() ) {
                    dbg.location(222,84);
                    adaptor.addChild(root_1, stream_idd.nextTree());

                }
                stream_idd.reset();
                dbg.location(222,89);
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
        dbg.location(223, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "usetikzlib");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token USETIKZLIB114=null;
        Token char_literal115=null;

        Object USETIKZLIB114_tree=null;
        Object char_literal115_tree=null;
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_USETIKZLIB=new RewriteRuleTokenStream(adaptor,"token USETIKZLIB");

        try { dbg.enterRule(getGrammarFileName(), "usetikzlib_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(224, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:225:2: ( USETIKZLIB '{' -> ^( IM_STARTTAG USETIKZLIB ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:225:4: USETIKZLIB '{'
            {
            dbg.location(225,4);
            USETIKZLIB114=(Token)match(input,USETIKZLIB,FOLLOW_USETIKZLIB_in_usetikzlib_start1364);  
            stream_USETIKZLIB.add(USETIKZLIB114);

            dbg.location(225,15);
            char_literal115=(Token)match(input,49,FOLLOW_49_in_usetikzlib_start1366);  
            stream_49.add(char_literal115);



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
                dbg.location(225,22);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:225:22: ^( IM_STARTTAG USETIKZLIB )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(225,24);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(225,36);
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
        dbg.location(226, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "usetikzlib_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token char_literal116=null;

        Object char_literal116_tree=null;
        RewriteRuleTokenStream stream_SEMIC=new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try { dbg.enterRule(getGrammarFileName(), "semicolon_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(227, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:228:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:228:4: ';'
            {
            dbg.location(228,4);
            char_literal116=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_semicolon_end1385);  
            stream_SEMIC.add(char_literal116);



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
                dbg.location(228,11);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:228:11: ^( IM_ENDTAG ';' )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(228,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(228,23);
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
        dbg.location(229, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "semicolon_end");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token char_literal117=null;

        Object char_literal117_tree=null;
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");

        try { dbg.enterRule(getGrammarFileName(), "roundbr_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(230, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:4: '}'
            {
            dbg.location(231,4);
            char_literal117=(Token)match(input,50,FOLLOW_50_in_roundbr_end1403);  
            stream_50.add(char_literal117);



            // AST REWRITE
            // elements: 50
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
                dbg.location(231,11);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:11: ^( IM_ENDTAG '}' )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(231,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(231,23);
                adaptor.addChild(root_1, stream_50.nextNode());

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
        dbg.location(232, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "roundbr_end");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        simpletikzParser.option_style_return option_style118 = null;

        simpletikzParser.option_kv_return option_kv119 = null;



        try { dbg.enterRule(getGrammarFileName(), "option");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(234, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:235:2: ( option_style | option_kv )
            int alt26=2;
            try { dbg.enterDecision(26);

            try {
                isCyclicDecision = true;
                alt26 = dfa26.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(26);}

            switch (alt26) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:235:4: option_style
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(235,4);
                    pushFollow(FOLLOW_option_style_in_option1423);
                    option_style118=option_style();

                    state._fsp--;

                    adaptor.addChild(root_0, option_style118.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:236:5: option_kv
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(236,5);
                    pushFollow(FOLLOW_option_kv_in_option1432);
                    option_kv119=option_kv();

                    state._fsp--;

                    adaptor.addChild(root_0, option_kv119.getTree());

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
        dbg.location(237, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "option");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token char_literal121=null;
        simpletikzParser.idd_return idd120 = null;

        simpletikzParser.iddornumberunit_return iddornumberunit122 = null;


        Object char_literal121_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_iddornumberunit=new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunit");
        try { dbg.enterRule(getGrammarFileName(), "option_kv");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(239, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:2: ( idd ( '=' iddornumberunit )? -> ^( IM_OPTION_KV idd ( iddornumberunit )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:4: idd ( '=' iddornumberunit )?
            {
            dbg.location(240,4);
            pushFollow(FOLLOW_idd_in_option_kv1446);
            idd120=idd();

            state._fsp--;

            stream_idd.add(idd120.getTree());
            dbg.location(240,8);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:8: ( '=' iddornumberunit )?
            int alt27=2;
            try { dbg.enterSubRule(27);
            try { dbg.enterDecision(27);

            int LA27_0 = input.LA(1);

            if ( (LA27_0==EQU) ) {
                alt27=1;
            }
            } finally {dbg.exitDecision(27);}

            switch (alt27) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:9: '=' iddornumberunit
                    {
                    dbg.location(240,9);
                    char_literal121=(Token)match(input,EQU,FOLLOW_EQU_in_option_kv1449);  
                    stream_EQU.add(char_literal121);

                    dbg.location(240,13);
                    pushFollow(FOLLOW_iddornumberunit_in_option_kv1451);
                    iddornumberunit122=iddornumberunit();

                    state._fsp--;

                    stream_iddornumberunit.add(iddornumberunit122.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(27);}



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
                dbg.location(240,34);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:34: ^( IM_OPTION_KV idd ( iddornumberunit )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(240,36);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

                dbg.location(240,49);
                adaptor.addChild(root_1, stream_idd.nextTree());
                dbg.location(240,53);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:53: ( iddornumberunit )?
                if ( stream_iddornumberunit.hasNext() ) {
                    dbg.location(240,53);
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
        dbg.location(241, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "option_kv");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        simpletikzParser.idd_return idd123 = null;

        simpletikzParser.numberunit_return numberunit124 = null;



        try { dbg.enterRule(getGrammarFileName(), "iddornumberunit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(242, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:243:2: ( idd | numberunit )
            int alt28=2;
            try { dbg.enterDecision(28);

            int LA28_0 = input.LA(1);

            if ( (LA28_0==ID) ) {
                alt28=1;
            }
            else if ( ((LA28_0>=FLOAT && LA28_0<=INT)) ) {
                alt28=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 28, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(28);}

            switch (alt28) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:243:4: idd
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(243,4);
                    pushFollow(FOLLOW_idd_in_iddornumberunit1474);
                    idd123=idd();

                    state._fsp--;

                    adaptor.addChild(root_0, idd123.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:243:10: numberunit
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(243,10);
                    pushFollow(FOLLOW_numberunit_in_iddornumberunit1478);
                    numberunit124=numberunit();

                    state._fsp--;

                    adaptor.addChild(root_0, numberunit124.getTree());

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
        dbg.location(244, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "iddornumberunit");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token string_literal126=null;
        Token char_literal127=null;
        Token char_literal128=null;
        Token char_literal130=null;
        Token char_literal132=null;
        Token char_literal133=null;
        simpletikzParser.idd_return idd125 = null;

        simpletikzParser.option_kv_return option_kv129 = null;

        simpletikzParser.option_kv_return option_kv131 = null;


        Object string_literal126_tree=null;
        Object char_literal127_tree=null;
        Object char_literal128_tree=null;
        Object char_literal130_tree=null;
        Object char_literal132_tree=null;
        Object char_literal133_tree=null;
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleTokenStream stream_70=new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv=new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try { dbg.enterRule(getGrammarFileName(), "option_style");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(245, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:2: ( idd '/.style' '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}' -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:4: idd '/.style' '=' '{' ( option_kv ( ',' option_kv )* )? ( ',' )? '}'
            {
            dbg.location(246,4);
            pushFollow(FOLLOW_idd_in_option_style1488);
            idd125=idd();

            state._fsp--;

            stream_idd.add(idd125.getTree());
            dbg.location(246,8);
            string_literal126=(Token)match(input,70,FOLLOW_70_in_option_style1490);  
            stream_70.add(string_literal126);

            dbg.location(246,18);
            char_literal127=(Token)match(input,EQU,FOLLOW_EQU_in_option_style1492);  
            stream_EQU.add(char_literal127);

            dbg.location(246,22);
            char_literal128=(Token)match(input,49,FOLLOW_49_in_option_style1494);  
            stream_49.add(char_literal128);

            dbg.location(246,26);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:26: ( option_kv ( ',' option_kv )* )?
            int alt30=2;
            try { dbg.enterSubRule(30);
            try { dbg.enterDecision(30);

            int LA30_0 = input.LA(1);

            if ( (LA30_0==ID) ) {
                alt30=1;
            }
            } finally {dbg.exitDecision(30);}

            switch (alt30) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:27: option_kv ( ',' option_kv )*
                    {
                    dbg.location(246,27);
                    pushFollow(FOLLOW_option_kv_in_option_style1497);
                    option_kv129=option_kv();

                    state._fsp--;

                    stream_option_kv.add(option_kv129.getTree());
                    dbg.location(246,37);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:37: ( ',' option_kv )*
                    try { dbg.enterSubRule(29);

                    loop29:
                    do {
                        int alt29=2;
                        try { dbg.enterDecision(29);

                        int LA29_0 = input.LA(1);

                        if ( (LA29_0==KOMMA) ) {
                            int LA29_1 = input.LA(2);

                            if ( (LA29_1==ID) ) {
                                alt29=1;
                            }


                        }


                        } finally {dbg.exitDecision(29);}

                        switch (alt29) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:38: ',' option_kv
                    	    {
                    	    dbg.location(246,38);
                    	    char_literal130=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_option_style1500);  
                    	    stream_KOMMA.add(char_literal130);

                    	    dbg.location(246,42);
                    	    pushFollow(FOLLOW_option_kv_in_option_style1502);
                    	    option_kv131=option_kv();

                    	    state._fsp--;

                    	    stream_option_kv.add(option_kv131.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop29;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(29);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(30);}

            dbg.location(246,57);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:57: ( ',' )?
            int alt31=2;
            try { dbg.enterSubRule(31);
            try { dbg.enterDecision(31);

            int LA31_0 = input.LA(1);

            if ( (LA31_0==KOMMA) ) {
                alt31=1;
            }
            } finally {dbg.exitDecision(31);}

            switch (alt31) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:57: ','
                    {
                    dbg.location(246,57);
                    char_literal132=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_option_style1509);  
                    stream_KOMMA.add(char_literal132);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(31);}

            dbg.location(246,62);
            char_literal133=(Token)match(input,50,FOLLOW_50_in_option_style1512);  
            stream_50.add(char_literal133);



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
                dbg.location(246,70);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:70: ^( IM_OPTION_STYLE idd ( option_kv )* )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(246,72);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

                dbg.location(246,88);
                adaptor.addChild(root_1, stream_idd.nextTree());
                dbg.location(246,92);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:92: ( option_kv )*
                while ( stream_option_kv.hasNext() ) {
                    dbg.location(246,92);
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
        dbg.location(247, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "option_style");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token ID134=null;
        Token ID135=null;

        Object ID134_tree=null;
        Object ID135_tree=null;
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try { dbg.enterRule(getGrammarFileName(), "idd");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(250, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:2: ( ID ( ID )* -> ^( IM_ID ( ID )* ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:4: ID ( ID )*
            {
            dbg.location(251,4);
            ID134=(Token)match(input,ID,FOLLOW_ID_in_idd1538);  
            stream_ID.add(ID134);

            dbg.location(251,7);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:7: ( ID )*
            try { dbg.enterSubRule(32);

            loop32:
            do {
                int alt32=2;
                try { dbg.enterDecision(32);

                int LA32_0 = input.LA(1);

                if ( (LA32_0==ID) ) {
                    alt32=1;
                }


                } finally {dbg.exitDecision(32);}

                switch (alt32) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:8: ID
            	    {
            	    dbg.location(251,8);
            	    ID135=(Token)match(input,ID,FOLLOW_ID_in_idd1541);  
            	    stream_ID.add(ID135);


            	    }
            	    break;

            	default :
            	    break loop32;
                }
            } while (true);
            } finally {dbg.exitSubRule(32);}



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
                dbg.location(251,16);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:16: ^( IM_ID ( ID )* )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(251,18);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ID, "IM_ID"), root_1);

                dbg.location(251,24);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:24: ( ID )*
                while ( stream_ID.hasNext() ) {
                    dbg.location(251,24);
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
        dbg.location(252, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "idd");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
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

        Token char_literal136=null;
        Token MATHSTRING138=null;
        Token ID139=null;
        Token char_literal140=null;
        simpletikzParser.tikzstring_return tikzstring137 = null;


        Object char_literal136_tree=null;
        Object MATHSTRING138_tree=null;
        Object ID139_tree=null;
        Object char_literal140_tree=null;
        RewriteRuleTokenStream stream_49=new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_MATHSTRING=new RewriteRuleTokenStream(adaptor,"token MATHSTRING");
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_tikzstring=new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        try { dbg.enterRule(getGrammarFileName(), "tikzstring");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(254, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:2: ( '{' ( tikzstring | MATHSTRING | ID )* '}' -> ^( IM_STRING '{' '}' ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:4: '{' ( tikzstring | MATHSTRING | ID )* '}'
            {
            dbg.location(255,4);
            char_literal136=(Token)match(input,49,FOLLOW_49_in_tikzstring1563);  
            stream_49.add(char_literal136);

            dbg.location(255,9);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:9: ( tikzstring | MATHSTRING | ID )*
            try { dbg.enterSubRule(33);

            loop33:
            do {
                int alt33=4;
                try { dbg.enterDecision(33);

                switch ( input.LA(1) ) {
                case 49:
                    {
                    alt33=1;
                    }
                    break;
                case MATHSTRING:
                    {
                    alt33=2;
                    }
                    break;
                case ID:
                    {
                    alt33=3;
                    }
                    break;

                }

                } finally {dbg.exitDecision(33);}

                switch (alt33) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:10: tikzstring
            	    {
            	    dbg.location(255,10);
            	    pushFollow(FOLLOW_tikzstring_in_tikzstring1567);
            	    tikzstring137=tikzstring();

            	    state._fsp--;

            	    stream_tikzstring.add(tikzstring137.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:23: MATHSTRING
            	    {
            	    dbg.location(255,23);
            	    MATHSTRING138=(Token)match(input,MATHSTRING,FOLLOW_MATHSTRING_in_tikzstring1571);  
            	    stream_MATHSTRING.add(MATHSTRING138);


            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:36: ID
            	    {
            	    dbg.location(255,36);
            	    ID139=(Token)match(input,ID,FOLLOW_ID_in_tikzstring1575);  
            	    stream_ID.add(ID139);


            	    }
            	    break;

            	default :
            	    break loop33;
                }
            } while (true);
            } finally {dbg.exitSubRule(33);}

            dbg.location(255,41);
            char_literal140=(Token)match(input,50,FOLLOW_50_in_tikzstring1579);  
            stream_50.add(char_literal140);



            // AST REWRITE
            // elements: 50, 49
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
                dbg.location(255,48);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:48: ^( IM_STRING '{' '}' )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(255,50);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STRING, "IM_STRING"), root_1);

                dbg.location(255,60);
                adaptor.addChild(root_1, stream_49.nextNode());
                dbg.location(255,64);
                adaptor.addChild(root_1, stream_50.nextNode());

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
        dbg.location(256, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzstring");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzstring"

    // Delegated rules


    protected DFA15 dfa15 = new DFA15(this);
    protected DFA17 dfa17 = new DFA17(this);
    protected DFA19 dfa19 = new DFA19(this);
    protected DFA26 dfa26 = new DFA26(this);
    static final String DFA15_eotS =
        "\73\uffff";
    static final String DFA15_eofS =
        "\73\uffff";
    static final String DFA15_minS =
        "\2\4\1\uffff\1\4\1\uffff\66\4";
    static final String DFA15_maxS =
        "\2\106\1\uffff\1\106\1\uffff\66\106";
    static final String DFA15_acceptS =
        "\2\uffff\1\2\1\uffff\1\1\66\uffff";
    static final String DFA15_specialS =
        "\73\uffff}>";
    static final String[] DFA15_transitionS = {
            "\13\2\1\1\67\2",
            "\14\2\1\4\26\2\1\3\37\2",
            "",
            "\14\2\1\4\1\10\1\7\24\2\1\5\36\2\1\6",
            "",
            "\14\2\1\4\1\10\1\7\24\2\1\5\36\2\1\6",
            "\16\2\1\11\64\2",
            "\43\2\1\12\2\13\35\2",
            "\14\2\1\4\26\2\1\14\37\2",
            "\55\2\1\15\25\2",
            "\14\2\1\4\1\10\25\2\1\16\37\2",
            "\14\2\1\4\1\10\55\2\5\17\3\2",
            "\14\2\1\4\1\10\1\21\24\2\1\20\36\2\1\22",
            "\15\2\1\24\25\2\1\23\12\2\1\25\24\2",
            "\14\2\1\4\1\10\25\2\1\16\37\2",
            "\14\2\1\4\1\10\65\2",
            "\14\2\1\4\1\10\1\21\24\2\1\20\36\2\1\22",
            "\43\2\1\26\2\27\35\2",
            "\16\2\1\30\64\2",
            "\15\2\1\33\1\32\24\2\1\31\12\2\1\25\24\2",
            "\56\2\1\25\24\2",
            "\14\2\1\4\1\10\65\2",
            "\14\2\1\4\1\10\25\2\1\34\37\2",
            "\14\2\1\4\1\10\55\2\5\35\3\2",
            "\55\2\1\36\25\2",
            "\15\2\1\33\1\32\24\2\1\31\12\2\1\25\24\2",
            "\43\2\1\37\2\40\35\2",
            "\43\2\1\41\12\2\1\25\24\2",
            "\14\2\1\4\1\10\25\2\1\34\37\2",
            "\14\2\1\4\1\10\65\2",
            "\15\2\1\43\25\2\1\42\12\2\1\44\24\2",
            "\15\2\1\33\25\2\1\45\12\2\1\25\24\2",
            "\15\2\1\33\40\2\1\25\14\2\5\46\3\2",
            "\15\2\1\33\1\50\24\2\1\47\12\2\1\25\24\2",
            "\15\2\1\53\1\52\24\2\1\51\12\2\1\44\24\2",
            "\56\2\1\44\24\2",
            "\14\2\1\4\1\10\65\2",
            "\15\2\1\33\25\2\1\45\12\2\1\25\24\2",
            "\15\2\1\33\40\2\1\25\24\2",
            "\15\2\1\33\1\50\24\2\1\47\12\2\1\25\24\2",
            "\43\2\1\54\2\55\35\2",
            "\15\2\1\53\1\52\24\2\1\51\12\2\1\44\24\2",
            "\43\2\1\56\2\57\35\2",
            "\43\2\1\60\12\2\1\44\24\2",
            "\15\2\1\33\25\2\1\61\12\2\1\25\24\2",
            "\15\2\1\33\40\2\1\25\14\2\5\62\3\2",
            "\15\2\1\53\25\2\1\63\12\2\1\44\24\2",
            "\15\2\1\53\40\2\1\44\14\2\5\64\3\2",
            "\15\2\1\53\1\66\24\2\1\65\12\2\1\44\24\2",
            "\15\2\1\33\25\2\1\61\12\2\1\25\24\2",
            "\15\2\1\33\40\2\1\25\24\2",
            "\15\2\1\53\25\2\1\63\12\2\1\44\24\2",
            "\15\2\1\53\40\2\1\44\24\2",
            "\15\2\1\53\1\66\24\2\1\65\12\2\1\44\24\2",
            "\43\2\1\67\2\70\35\2",
            "\15\2\1\53\25\2\1\71\12\2\1\44\24\2",
            "\15\2\1\53\40\2\1\44\14\2\5\72\3\2",
            "\15\2\1\53\25\2\1\71\12\2\1\44\24\2",
            "\15\2\1\53\40\2\1\44\24\2"
    };

    static final short[] DFA15_eot = DFA.unpackEncodedString(DFA15_eotS);
    static final short[] DFA15_eof = DFA.unpackEncodedString(DFA15_eofS);
    static final char[] DFA15_min = DFA.unpackEncodedStringToUnsignedChars(DFA15_minS);
    static final char[] DFA15_max = DFA.unpackEncodedStringToUnsignedChars(DFA15_maxS);
    static final short[] DFA15_accept = DFA.unpackEncodedString(DFA15_acceptS);
    static final short[] DFA15_special = DFA.unpackEncodedString(DFA15_specialS);
    static final short[][] DFA15_transition;

    static {
        int numStates = DFA15_transitionS.length;
        DFA15_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA15_transition[i] = DFA.unpackEncodedString(DFA15_transitionS[i]);
        }
    }

    class DFA15 extends DFA {

        public DFA15(BaseRecognizer recognizer) {
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
        public String getDescription() {
            return "173:23: ( tikz_options )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
    static final String DFA17_eotS =
        "\16\uffff";
    static final String DFA17_eofS =
        "\16\uffff";
    static final String DFA17_minS =
        "\1\4\2\61\5\uffff\2\47\4\uffff";
    static final String DFA17_maxS =
        "\1\106\2\61\5\uffff\2\105\4\uffff";
    static final String DFA17_acceptS =
        "\3\uffff\1\2\1\3\1\4\1\5\1\6\2\uffff\1\11\1\10\1\1\1\7";
    static final String DFA17_specialS =
        "\16\uffff}>";
    static final String[] DFA17_transitionS = {
            "\1\2\1\1\1\5\1\7\1\6\1\4\3\3\72\5",
            "\1\10",
            "\1\11",
            "",
            "",
            "",
            "",
            "",
            "\1\13\34\uffff\2\12",
            "\1\15\35\uffff\1\14",
            "",
            "",
            "",
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
            return "()+ loopback of 182:4: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )+";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
    static final String DFA19_eotS =
        "\73\uffff";
    static final String DFA19_eofS =
        "\73\uffff";
    static final String DFA19_minS =
        "\2\4\1\uffff\1\4\1\uffff\66\4";
    static final String DFA19_maxS =
        "\2\106\1\uffff\1\106\1\uffff\66\106";
    static final String DFA19_acceptS =
        "\2\uffff\1\2\1\uffff\1\1\66\uffff";
    static final String DFA19_specialS =
        "\73\uffff}>";
    static final String[] DFA19_transitionS = {
            "\13\2\1\1\67\2",
            "\14\2\1\4\26\2\1\3\37\2",
            "",
            "\14\2\1\4\1\10\1\7\24\2\1\5\36\2\1\6",
            "",
            "\14\2\1\4\1\10\1\7\24\2\1\5\36\2\1\6",
            "\16\2\1\11\64\2",
            "\43\2\1\12\2\13\35\2",
            "\14\2\1\4\26\2\1\14\37\2",
            "\55\2\1\15\25\2",
            "\14\2\1\4\1\10\25\2\1\16\37\2",
            "\14\2\1\4\1\10\55\2\5\17\3\2",
            "\14\2\1\4\1\10\1\21\24\2\1\20\36\2\1\22",
            "\15\2\1\24\25\2\1\23\12\2\1\25\24\2",
            "\14\2\1\4\1\10\25\2\1\16\37\2",
            "\14\2\1\4\1\10\65\2",
            "\14\2\1\4\1\10\1\21\24\2\1\20\36\2\1\22",
            "\43\2\1\26\2\27\35\2",
            "\16\2\1\30\64\2",
            "\15\2\1\33\1\32\24\2\1\31\12\2\1\25\24\2",
            "\56\2\1\25\24\2",
            "\14\2\1\4\1\10\65\2",
            "\14\2\1\4\1\10\25\2\1\34\37\2",
            "\14\2\1\4\1\10\55\2\5\35\3\2",
            "\55\2\1\36\25\2",
            "\15\2\1\33\1\32\24\2\1\31\12\2\1\25\24\2",
            "\43\2\1\37\2\40\35\2",
            "\43\2\1\41\12\2\1\25\24\2",
            "\14\2\1\4\1\10\25\2\1\34\37\2",
            "\14\2\1\4\1\10\65\2",
            "\15\2\1\43\25\2\1\42\12\2\1\44\24\2",
            "\15\2\1\33\25\2\1\45\12\2\1\25\24\2",
            "\15\2\1\33\40\2\1\25\14\2\5\46\3\2",
            "\15\2\1\33\1\50\24\2\1\47\12\2\1\25\24\2",
            "\15\2\1\53\1\52\24\2\1\51\12\2\1\44\24\2",
            "\56\2\1\44\24\2",
            "\14\2\1\4\1\10\65\2",
            "\15\2\1\33\25\2\1\45\12\2\1\25\24\2",
            "\15\2\1\33\40\2\1\25\24\2",
            "\15\2\1\33\1\50\24\2\1\47\12\2\1\25\24\2",
            "\43\2\1\54\2\55\35\2",
            "\15\2\1\53\1\52\24\2\1\51\12\2\1\44\24\2",
            "\43\2\1\56\2\57\35\2",
            "\43\2\1\60\12\2\1\44\24\2",
            "\15\2\1\33\25\2\1\61\12\2\1\25\24\2",
            "\15\2\1\33\40\2\1\25\14\2\5\62\3\2",
            "\15\2\1\53\25\2\1\63\12\2\1\44\24\2",
            "\15\2\1\53\40\2\1\44\14\2\5\64\3\2",
            "\15\2\1\53\1\66\24\2\1\65\12\2\1\44\24\2",
            "\15\2\1\33\25\2\1\61\12\2\1\25\24\2",
            "\15\2\1\33\40\2\1\25\24\2",
            "\15\2\1\53\25\2\1\63\12\2\1\44\24\2",
            "\15\2\1\53\40\2\1\44\24\2",
            "\15\2\1\53\1\66\24\2\1\65\12\2\1\44\24\2",
            "\43\2\1\67\2\70\35\2",
            "\15\2\1\53\25\2\1\71\12\2\1\44\24\2",
            "\15\2\1\53\40\2\1\44\14\2\5\72\3\2",
            "\15\2\1\53\25\2\1\71\12\2\1\44\24\2",
            "\15\2\1\53\40\2\1\44\24\2"
    };

    static final short[] DFA19_eot = DFA.unpackEncodedString(DFA19_eotS);
    static final short[] DFA19_eof = DFA.unpackEncodedString(DFA19_eofS);
    static final char[] DFA19_min = DFA.unpackEncodedStringToUnsignedChars(DFA19_minS);
    static final char[] DFA19_max = DFA.unpackEncodedStringToUnsignedChars(DFA19_maxS);
    static final short[] DFA19_accept = DFA.unpackEncodedString(DFA19_acceptS);
    static final short[] DFA19_special = DFA.unpackEncodedString(DFA19_specialS);
    static final short[][] DFA19_transition;

    static {
        int numStates = DFA19_transitionS.length;
        DFA19_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA19_transition[i] = DFA.unpackEncodedString(DFA19_transitionS[i]);
        }
    }

    class DFA19 extends DFA {

        public DFA19(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;
        }
        public String getDescription() {
            return "195:20: ( tikz_options )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
    static final String DFA26_eotS =
        "\5\uffff";
    static final String DFA26_eofS =
        "\5\uffff";
    static final String DFA26_minS =
        "\1\47\2\20\2\uffff";
    static final String DFA26_maxS =
        "\1\47\2\106\2\uffff";
    static final String DFA26_acceptS =
        "\3\uffff\1\1\1\2";
    static final String DFA26_specialS =
        "\5\uffff}>";
    static final String[] DFA26_transitionS = {
            "\1\1",
            "\3\4\24\uffff\1\2\12\uffff\1\4\23\uffff\1\3",
            "\3\4\24\uffff\1\2\12\uffff\1\4\23\uffff\1\3",
            "",
            ""
    };

    static final short[] DFA26_eot = DFA.unpackEncodedString(DFA26_eotS);
    static final short[] DFA26_eof = DFA.unpackEncodedString(DFA26_eofS);
    static final char[] DFA26_min = DFA.unpackEncodedStringToUnsignedChars(DFA26_minS);
    static final char[] DFA26_max = DFA.unpackEncodedStringToUnsignedChars(DFA26_maxS);
    static final short[] DFA26_accept = DFA.unpackEncodedString(DFA26_acceptS);
    static final short[] DFA26_special = DFA.unpackEncodedString(DFA26_specialS);
    static final short[][] DFA26_transition;

    static {
        int numStates = DFA26_transitionS.length;
        DFA26_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA26_transition[i] = DFA.unpackEncodedString(DFA26_transitionS[i]);
        }
    }

    class DFA26 extends DFA {

        public DFA26(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 26;
            this.eot = DFA26_eot;
            this.eof = DFA26_eof;
            this.min = DFA26_min;
            this.max = DFA26_max;
            this.accept = DFA26_accept;
            this.special = DFA26_special;
            this.transition = DFA26_transition;
        }
        public String getDescription() {
            return "234:1: option : ( option_style | option_kv );";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
 

    public static final BitSet FOLLOW_dontcare_preamble_in_tikzdocument321 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000007FL});
    public static final BitSet FOLLOW_tikz_styleorset_in_tikzdocument325 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000007FL});
    public static final BitSet FOLLOW_otherbegin_in_tikzdocument329 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000007FL});
    public static final BitSet FOLLOW_tikzpicture_in_tikzdocument334 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000007FL});
    public static final BitSet FOLLOW_tikz_style_in_tikz_styleorset364 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_set_in_tikz_styleorset368 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_dontcare_preamble380 = new BitSet(new long[]{0xFFFFFFFFFFFFFE62L,0x000000000000007FL});
    public static final BitSet FOLLOW_BEGIN_in_otherbegin403 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_otherbegin405 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_idd_in_otherbegin407 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_otherbegin409 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TIKZSTYLE_in_tikz_style420 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_tikz_style422 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_idd_in_tikz_style424 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_tikz_style426 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_EQU_in_tikz_style428 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_tikz_options_in_tikz_style430 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_in_tikzpath452 = new BitSet(new long[]{0x600800000000A000L});
    public static final BitSet FOLLOW_tikz_options_in_tikzpath454 = new BitSet(new long[]{0x600800000000A000L});
    public static final BitSet FOLLOW_tikzpathi_in_tikzpath457 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_path_end_in_tikzpath459 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SEMIC_in_path_end485 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi505 = new BitSet(new long[]{0x7FE800000000A002L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi508 = new BitSet(new long[]{0x7FE800000000A002L});
    public static final BitSet FOLLOW_tikz_options_in_tikzpathi512 = new BitSet(new long[]{0x7FE800000000A000L});
    public static final BitSet FOLLOW_edgeop_in_tikzpathi515 = new BitSet(new long[]{0x600800000000A000L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi518 = new BitSet(new long[]{0x7FE800000000A002L});
    public static final BitSet FOLLOW_coord_in_coordornode533 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikznodei_in_coordornode537 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_51_in_tikznodei549 = new BitSet(new long[]{0x0012000000002000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodei552 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_node_start_in_tikznodee562 = new BitSet(new long[]{0x0012000000002000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodee564 = new BitSet(new long[]{0x600800000008A000L});
    public static final BitSet FOLLOW_tikzpathi_in_tikznodee566 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_path_end_in_tikznodee569 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_node_start595 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_tikznode613 = new BitSet(new long[]{0x0012000000002000L});
    public static final BitSet FOLLOW_52_in_tikznode617 = new BitSet(new long[]{0x6000000000002000L});
    public static final BitSet FOLLOW_coord_in_tikznode619 = new BitSet(new long[]{0x0012000000002000L});
    public static final BitSet FOLLOW_tikzstring_in_tikznode623 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_edgeop0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LPAR_in_nodename696 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_ID_in_nodename700 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_RPAR_in_nodename702 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_coord727 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_modifier_in_coord751 = new BitSet(new long[]{0x0000000000002000L});
    public static final BitSet FOLLOW_LPAR_in_coord756 = new BitSet(new long[]{0x0000030000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord758 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_KOMMA_in_coord760 = new BitSet(new long[]{0x0000030000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord762 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_RPAR_in_coord764 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_number_in_numberunit806 = new BitSet(new long[]{0x8000000000000002L,0x000000000000000FL});
    public static final BitSet FOLLOW_unit_in_numberunit808 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_number831 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_unit0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_tag_in_path_start875 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzpicture_start_in_tikzpicture914 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000007FL});
    public static final BitSet FOLLOW_tikz_options_in_tikzpicture916 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000007FL});
    public static final BitSet FOLLOW_tikzbody_in_tikzpicture919 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000007FL});
    public static final BitSet FOLLOW_tikzpicture_end_in_tikzpicture922 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_tikzpicture_start949 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_tikzpicture_start951 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000010L});
    public static final BitSet FOLLOW_68_in_tikzpicture_start953 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_tikzpicture_start955 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_tikzpicture_end973 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_tikzpicture_end975 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000010L});
    public static final BitSet FOLLOW_68_in_tikzpicture_end977 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_tikzpicture_end979 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody999 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000007FL});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody1003 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000007FL});
    public static final BitSet FOLLOW_tikznodee_in_tikzbody1007 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000007FL});
    public static final BitSet FOLLOW_dontcare_body_in_tikzbody1011 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000007FL});
    public static final BitSet FOLLOW_tikz_set_in_tikzbody1015 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000007FL});
    public static final BitSet FOLLOW_tikz_style_in_tikzbody1019 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000007FL});
    public static final BitSet FOLLOW_otherbegin_in_tikzbody1023 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000007FL});
    public static final BitSet FOLLOW_otherend_in_tikzbody1026 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000007FL});
    public static final BitSet FOLLOW_set_in_dontcare_body1040 = new BitSet(new long[]{0xFFFFFFFFFFFFE042L,0x000000000000007FL});
    public static final BitSet FOLLOW_END_in_otherend1086 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_otherend1088 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_idd_in_otherend1090 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_otherend1092 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzscope_start_in_tikzscope1106 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000007FL});
    public static final BitSet FOLLOW_tikz_options_in_tikzscope1108 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000007FL});
    public static final BitSet FOLLOW_tikzbody_in_tikzscope1111 = new BitSet(new long[]{0x0000000000000020L});
    public static final BitSet FOLLOW_tikzscope_end_in_tikzscope1113 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_tikzscope_start1139 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_tikzscope_start1141 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000020L});
    public static final BitSet FOLLOW_69_in_tikzscope_start1143 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_tikzscope_start1145 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_tikzscope_end1163 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_tikzscope_end1165 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000020L});
    public static final BitSet FOLLOW_69_in_tikzscope_end1167 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_tikzscope_end1169 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_squarebr_start_in_tikz_options1189 = new BitSet(new long[]{0x0000008000010000L});
    public static final BitSet FOLLOW_option_in_tikz_options1192 = new BitSet(new long[]{0x0000008000030000L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_options1195 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_option_in_tikz_options1197 = new BitSet(new long[]{0x0000008000030000L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_options1201 = new BitSet(new long[]{0x0000008000010000L});
    public static final BitSet FOLLOW_squarebr_end_in_tikz_options1206 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBR_in_squarebr_start1230 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RBR_in_squarebr_end1248 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_set_start_in_tikz_set1270 = new BitSet(new long[]{0x0004008000000000L});
    public static final BitSet FOLLOW_option_in_tikz_set1273 = new BitSet(new long[]{0x0004008000020000L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_set1276 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_option_in_tikz_set1278 = new BitSet(new long[]{0x0004008000020000L});
    public static final BitSet FOLLOW_roundbr_end_in_tikz_set1284 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TIKZSET_in_tikz_set_start1307 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_tikz_set_start1309 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_usetikzlib_start_in_usetikzlib1330 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_idd_in_usetikzlib1332 = new BitSet(new long[]{0x0004008000020000L});
    public static final BitSet FOLLOW_KOMMA_in_usetikzlib1335 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_idd_in_usetikzlib1337 = new BitSet(new long[]{0x0004008000020000L});
    public static final BitSet FOLLOW_roundbr_end_in_usetikzlib1341 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_USETIKZLIB_in_usetikzlib_start1364 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_usetikzlib_start1366 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SEMIC_in_semicolon_end1385 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_50_in_roundbr_end1403 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_style_in_option1423 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_kv_in_option1432 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_kv1446 = new BitSet(new long[]{0x0000000000040002L});
    public static final BitSet FOLLOW_EQU_in_option_kv1449 = new BitSet(new long[]{0x0000038000000000L});
    public static final BitSet FOLLOW_iddornumberunit_in_option_kv1451 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_iddornumberunit1474 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_numberunit_in_iddornumberunit1478 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_style1488 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000040L});
    public static final BitSet FOLLOW_70_in_option_style1490 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_EQU_in_option_style1492 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_49_in_option_style1494 = new BitSet(new long[]{0x0004008000020000L});
    public static final BitSet FOLLOW_option_kv_in_option_style1497 = new BitSet(new long[]{0x0004000000020000L});
    public static final BitSet FOLLOW_KOMMA_in_option_style1500 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_option_kv_in_option_style1502 = new BitSet(new long[]{0x0004000000020000L});
    public static final BitSet FOLLOW_KOMMA_in_option_style1509 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_option_style1512 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ID_in_idd1538 = new BitSet(new long[]{0x0000008000000002L});
    public static final BitSet FOLLOW_ID_in_idd1541 = new BitSet(new long[]{0x0000008000000002L});
    public static final BitSet FOLLOW_49_in_tikzstring1563 = new BitSet(new long[]{0x0016048000002000L});
    public static final BitSet FOLLOW_tikzstring_in_tikzstring1567 = new BitSet(new long[]{0x0016048000002000L});
    public static final BitSet FOLLOW_MATHSTRING_in_tikzstring1571 = new BitSet(new long[]{0x0016048000002000L});
    public static final BitSet FOLLOW_ID_in_tikzstring1575 = new BitSet(new long[]{0x0016048000002000L});
    public static final BitSet FOLLOW_50_in_tikzstring1579 = new BitSet(new long[]{0x0000000000000002L});

}