// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-12-16 08:49:13

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;

import org.antlr.runtime.tree.*;

public class simpletikzParser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BEGIN", "END", "USETIKZLIB", "TIKZSTYLE", "TIKZSET", "NODE", "DRAW", "PATH", "FILL", "LPAR", "RPAR", "LBR", "RBR", "LBRR", "RBRR", "KOMMA", "EQU", "SEMIC", "COLON", "IM_PATH", "IM_NODE", "IM_COORD", "IM_NODENAME", "IM_NUMBERUNIT", "IM_PICTURE", "IM_DOCUMENT", "IM_SCOPE", "IM_STARTTAG", "IM_ENDTAG", "IM_OPTIONS", "IM_OPTION_STYLE", "IM_OPTION_KV", "IM_ID", "IM_TIKZSET", "IM_USETIKZLIB", "IM_STRING", "IM_STYLE", "ID", "FLOAT", "INT", "EXPONENT", "COMMENT", "WS", "ESC_SEQ", "MATHSTRING", "COMMAND", "SOMETHING", "'/.style'", "'cm'", "'in'", "'ex'", "'mm'", "'pt'", "'node'", "'at'", "'--'", "'->'", "'|-'", "'-|'", "'+'", "'++'", "'tikzpicture'", "'scope'"
    };
    public static final int T__66=66;
    public static final int EXPONENT=44;
    public static final int T__64=64;
    public static final int IM_STARTTAG=31;
    public static final int T__65=65;
    public static final int T__62=62;
    public static final int T__63=63;
    public static final int RBR=16;
    public static final int IM_PATH=23;
    public static final int IM_ID=36;
    public static final int FLOAT=42;
    public static final int SOMETHING=50;
    public static final int ID=41;
    public static final int T__61=61;
    public static final int T__60=60;
    public static final int EOF=-1;
    public static final int MATHSTRING=48;
    public static final int LBR=15;
    public static final int COMMAND=49;
    public static final int IM_ENDTAG=32;
    public static final int IM_USETIKZLIB=38;
    public static final int T__55=55;
    public static final int T__56=56;
    public static final int T__57=57;
    public static final int IM_DOCUMENT=29;
    public static final int T__58=58;
    public static final int RBRR=18;
    public static final int ESC_SEQ=47;
    public static final int IM_STRING=39;
    public static final int T__51=51;
    public static final int T__52=52;
    public static final int T__53=53;
    public static final int LPAR=13;
    public static final int T__54=54;
    public static final int FILL=12;
    public static final int PATH=11;
    public static final int IM_TIKZSET=37;
    public static final int T__59=59;
    public static final int BEGIN=4;
    public static final int IM_OPTION_KV=35;
    public static final int COMMENT=45;
    public static final int IM_OPTIONS=33;
    public static final int IM_OPTION_STYLE=34;
    public static final int NODE=9;
    public static final int TIKZSTYLE=7;
    public static final int TIKZSET=8;
    public static final int IM_COORD=25;
    public static final int IM_PICTURE=28;
    public static final int INT=43;
    public static final int LBRR=17;
    public static final int USETIKZLIB=6;
    public static final int IM_NODE=24;
    public static final int IM_STYLE=40;
    public static final int COLON=22;
    public static final int IM_SCOPE=30;
    public static final int IM_NUMBERUNIT=27;
    public static final int WS=46;
    public static final int KOMMA=19;
    public static final int EQU=20;
    public static final int RPAR=14;
    public static final int END=5;
    public static final int SEMIC=21;
    public static final int IM_NODENAME=26;
    public static final int DRAW=10;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "squarebr_end", "edgeop", "coordornode", "tikzscope", 
        "coord_sep", "squarebr_start", "tikzpicture", "tikzpicture_start", 
        "nodename", "option", "tikz_style", "tikz_options", "idd", "tikzdocument", 
        "tikz_set_start", "coord_modifier", "dontcare_body", "tikzpath", 
        "tikzscope_end", "dontcare_body_nobr", "option_style", "roundbr_end", 
        "iddornumberunitorstring", "path_start_tag", "tikzpicture_end", 
        "dontcare_preamble", "unit", "node_start", "numberunit", "tikz_styleorset", 
        "semicolon_end", "no_rlbrace", "tikzscope_start", "tikznode", "tikznodei", 
        "tikzstring", "option_kv", "number", "otherbegin", "tikznodee", 
        "tikzpathi", "tikz_set", "otherend", "path_start", "coord", "tikzbody"
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:1: tikzdocument : ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture ) ;
    public final simpletikzParser.tikzdocument_return tikzdocument() throws RecognitionException {
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.dontcare_preamble_return dontcare_preamble1 = null;

        simpletikzParser.tikz_styleorset_return tikz_styleorset2 = null;

        simpletikzParser.otherbegin_return otherbegin3 = null;

        simpletikzParser.tikzpicture_return tikzpicture4 = null;


        RewriteRuleSubtreeStream stream_dontcare_preamble=new RewriteRuleSubtreeStream(adaptor,"rule dontcare_preamble");
        RewriteRuleSubtreeStream stream_tikzpicture=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        RewriteRuleSubtreeStream stream_otherbegin=new RewriteRuleSubtreeStream(adaptor,"rule otherbegin");
        RewriteRuleSubtreeStream stream_tikz_styleorset=new RewriteRuleSubtreeStream(adaptor,"rule tikz_styleorset");
        try { dbg.enterRule(getGrammarFileName(), "tikzdocument");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(89, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:2: ( ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:5: ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture
            {
            dbg.location(90,5);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:5: ( dontcare_preamble | tikz_styleorset | otherbegin )*
            try { dbg.enterSubRule(1);

            loop1:
            do {
                int alt1=4;
                try { dbg.enterDecision(1);

                switch ( input.LA(1) ) {
                case BEGIN:
                    {
                    int LA1_1 = input.LA(2);

                    if ( (LA1_1==LBRR) ) {
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
                case LBRR:
                case RBRR:
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
                case EXPONENT:
                case COMMENT:
                case WS:
                case ESC_SEQ:
                case MATHSTRING:
                case COMMAND:
                case SOMETHING:
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

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:6: dontcare_preamble
            	    {
            	    dbg.location(90,6);
            	    pushFollow(FOLLOW_dontcare_preamble_in_tikzdocument337);
            	    dontcare_preamble1=dontcare_preamble();

            	    state._fsp--;

            	    stream_dontcare_preamble.add(dontcare_preamble1.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:26: tikz_styleorset
            	    {
            	    dbg.location(90,26);
            	    pushFollow(FOLLOW_tikz_styleorset_in_tikzdocument341);
            	    tikz_styleorset2=tikz_styleorset();

            	    state._fsp--;

            	    stream_tikz_styleorset.add(tikz_styleorset2.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:44: otherbegin
            	    {
            	    dbg.location(90,44);
            	    pushFollow(FOLLOW_otherbegin_in_tikzdocument345);
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

            dbg.location(90,58);
            pushFollow(FOLLOW_tikzpicture_in_tikzdocument350);
            tikzpicture4=tikzpicture();

            state._fsp--;

            stream_tikzpicture.add(tikzpicture4.getTree());


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
            // 90:73: -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture )
            {
                dbg.location(90,76);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:76: ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(90,78);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

                dbg.location(90,90);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:90: ( tikz_styleorset )*
                while ( stream_tikz_styleorset.hasNext() ) {
                    dbg.location(90,90);
                    adaptor.addChild(root_1, stream_tikz_styleorset.nextTree());

                }
                stream_tikz_styleorset.reset();
                dbg.location(90,107);
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
        dbg.location(91, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:1: tikz_styleorset : ( tikz_style | tikz_set );
    public final simpletikzParser.tikz_styleorset_return tikz_styleorset() throws RecognitionException {
        simpletikzParser.tikz_styleorset_return retval = new simpletikzParser.tikz_styleorset_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikz_style_return tikz_style5 = null;

        simpletikzParser.tikz_set_return tikz_set6 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikz_styleorset");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(93, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:2: ( tikz_style | tikz_set )
            int alt2=2;
            try { dbg.enterDecision(2);

            int LA2_0 = input.LA(1);

            if ( (LA2_0==TIKZSTYLE) ) {
                alt2=1;
            }
            else if ( (LA2_0==TIKZSET) ) {
                alt2=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 2, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(2);}

            switch (alt2) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:4: tikz_style
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(94,4);
                    pushFollow(FOLLOW_tikz_style_in_tikz_styleorset375);
                    tikz_style5=tikz_style();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_style5.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:17: tikz_set
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(94,17);
                    pushFollow(FOLLOW_tikz_set_in_tikz_styleorset379);
                    tikz_set6=tikz_set();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_set6.getTree());

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
        dbg.location(95, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:1: dontcare_preamble : ~ ( BEGIN | TIKZSTYLE | TIKZSET ) ;
    public final simpletikzParser.dontcare_preamble_return dontcare_preamble() throws RecognitionException {
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set7=null;

        Object set7_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "dontcare_preamble");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(97, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:2: (~ ( BEGIN | TIKZSTYLE | TIKZSET ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:4: ~ ( BEGIN | TIKZSTYLE | TIKZSET )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(98,4);
            set7=(Token)input.LT(1);
            if ( (input.LA(1)>=END && input.LA(1)<=USETIKZLIB)||(input.LA(1)>=NODE && input.LA(1)<=66) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set7));
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
        dbg.location(99, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:1: otherbegin : BEGIN LBRR idd RBRR ;
    public final simpletikzParser.otherbegin_return otherbegin() throws RecognitionException {
        simpletikzParser.otherbegin_return retval = new simpletikzParser.otherbegin_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGIN8=null;
        Token LBRR9=null;
        Token RBRR11=null;
        simpletikzParser.idd_return idd10 = null;


        Object BEGIN8_tree=null;
        Object LBRR9_tree=null;
        Object RBRR11_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "otherbegin");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(100, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:101:2: ( BEGIN LBRR idd RBRR )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:101:4: BEGIN LBRR idd RBRR
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(101,4);
            BEGIN8=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_otherbegin411); 
            BEGIN8_tree = (Object)adaptor.create(BEGIN8);
            adaptor.addChild(root_0, BEGIN8_tree);

            dbg.location(101,10);
            LBRR9=(Token)match(input,LBRR,FOLLOW_LBRR_in_otherbegin413); 
            LBRR9_tree = (Object)adaptor.create(LBRR9);
            adaptor.addChild(root_0, LBRR9_tree);

            dbg.location(101,15);
            pushFollow(FOLLOW_idd_in_otherbegin415);
            idd10=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd10.getTree());
            dbg.location(101,19);
            RBRR11=(Token)match(input,RBRR,FOLLOW_RBRR_in_otherbegin417); 
            RBRR11_tree = (Object)adaptor.create(RBRR11);
            adaptor.addChild(root_0, RBRR11_tree);


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
        dbg.location(102, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:1: tikz_style : TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) ;
    public final simpletikzParser.tikz_style_return tikz_style() throws RecognitionException {
        simpletikzParser.tikz_style_return retval = new simpletikzParser.tikz_style_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token TIKZSTYLE12=null;
        Token LBRR13=null;
        Token RBRR15=null;
        Token char_literal16=null;
        simpletikzParser.idd_return idd14 = null;

        simpletikzParser.tikz_options_return tikz_options17 = null;


        Object TIKZSTYLE12_tree=null;
        Object LBRR13_tree=null;
        Object RBRR15_tree=null;
        Object char_literal16_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSTYLE=new RewriteRuleTokenStream(adaptor,"token TIKZSTYLE");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikz_style");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(104, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:2: ( TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:4: TIKZSTYLE LBRR idd RBRR '=' tikz_options
            {
            dbg.location(105,4);
            TIKZSTYLE12=(Token)match(input,TIKZSTYLE,FOLLOW_TIKZSTYLE_in_tikz_style428);  
            stream_TIKZSTYLE.add(TIKZSTYLE12);

            dbg.location(105,14);
            LBRR13=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikz_style430);  
            stream_LBRR.add(LBRR13);

            dbg.location(105,19);
            pushFollow(FOLLOW_idd_in_tikz_style432);
            idd14=idd();

            state._fsp--;

            stream_idd.add(idd14.getTree());
            dbg.location(105,23);
            RBRR15=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikz_style434);  
            stream_RBRR.add(RBRR15);

            dbg.location(105,28);
            char_literal16=(Token)match(input,EQU,FOLLOW_EQU_in_tikz_style436);  
            stream_EQU.add(char_literal16);

            dbg.location(105,32);
            pushFollow(FOLLOW_tikz_options_in_tikz_style438);
            tikz_options17=tikz_options();

            state._fsp--;

            stream_tikz_options.add(tikz_options17.getTree());


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
            // 105:45: -> ^( IM_STYLE idd tikz_options )
            {
                dbg.location(105,48);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:48: ^( IM_STYLE idd tikz_options )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(105,50);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STYLE, "IM_STYLE"), root_1);

                dbg.location(105,59);
                adaptor.addChild(root_1, stream_idd.nextTree());
                dbg.location(105,63);
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
        dbg.location(106, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_style");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikz_style"

    public static class tikz_options_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_options"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
    public final simpletikzParser.tikz_options_return tikz_options() throws RecognitionException {
        simpletikzParser.tikz_options_return retval = new simpletikzParser.tikz_options_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal20=null;
        Token char_literal22=null;
        simpletikzParser.squarebr_start_return squarebr_start18 = null;

        simpletikzParser.option_return option19 = null;

        simpletikzParser.option_return option21 = null;

        simpletikzParser.squarebr_end_return squarebr_end23 = null;


        Object char_literal20_tree=null;
        Object char_literal22_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_squarebr_start=new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_squarebr_end=new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try { dbg.enterRule(getGrammarFileName(), "tikz_options");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(108, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            dbg.location(109,5);
            pushFollow(FOLLOW_squarebr_start_in_tikz_options460);
            squarebr_start18=squarebr_start();

            state._fsp--;

            stream_squarebr_start.add(squarebr_start18.getTree());
            dbg.location(109,20);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:20: ( option ( ',' option )* ( ',' )? )?
            int alt5=2;
            try { dbg.enterSubRule(5);
            try { dbg.enterDecision(5);

            int LA5_0 = input.LA(1);

            if ( (LA5_0==ID) ) {
                alt5=1;
            }
            } finally {dbg.exitDecision(5);}

            switch (alt5) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:21: option ( ',' option )* ( ',' )?
                    {
                    dbg.location(109,21);
                    pushFollow(FOLLOW_option_in_tikz_options463);
                    option19=option();

                    state._fsp--;

                    stream_option.add(option19.getTree());
                    dbg.location(109,28);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:28: ( ',' option )*
                    try { dbg.enterSubRule(3);

                    loop3:
                    do {
                        int alt3=2;
                        try { dbg.enterDecision(3);

                        int LA3_0 = input.LA(1);

                        if ( (LA3_0==KOMMA) ) {
                            int LA3_1 = input.LA(2);

                            if ( (LA3_1==ID) ) {
                                alt3=1;
                            }


                        }


                        } finally {dbg.exitDecision(3);}

                        switch (alt3) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:29: ',' option
                    	    {
                    	    dbg.location(109,29);
                    	    char_literal20=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options466);  
                    	    stream_KOMMA.add(char_literal20);

                    	    dbg.location(109,33);
                    	    pushFollow(FOLLOW_option_in_tikz_options468);
                    	    option21=option();

                    	    state._fsp--;

                    	    stream_option.add(option21.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop3;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(3);}

                    dbg.location(109,42);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:42: ( ',' )?
                    int alt4=2;
                    try { dbg.enterSubRule(4);
                    try { dbg.enterDecision(4);

                    int LA4_0 = input.LA(1);

                    if ( (LA4_0==KOMMA) ) {
                        alt4=1;
                    }
                    } finally {dbg.exitDecision(4);}

                    switch (alt4) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:42: ','
                            {
                            dbg.location(109,42);
                            char_literal22=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options472);  
                            stream_KOMMA.add(char_literal22);


                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(4);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(5);}

            dbg.location(109,49);
            pushFollow(FOLLOW_squarebr_end_in_tikz_options477);
            squarebr_end23=squarebr_end();

            state._fsp--;

            stream_squarebr_end.add(squarebr_end23.getTree());


            // AST REWRITE
            // elements: option, squarebr_start, squarebr_end
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 109:63: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            {
                dbg.location(109,66);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(109,68);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTIONS, "IM_OPTIONS"), root_1);

                dbg.location(109,79);
                adaptor.addChild(root_1, stream_squarebr_start.nextTree());
                dbg.location(109,94);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:94: ( option )*
                while ( stream_option.hasNext() ) {
                    dbg.location(109,94);
                    adaptor.addChild(root_1, stream_option.nextTree());

                }
                stream_option.reset();
                dbg.location(109,102);
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
        dbg.location(110, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_options");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikz_options"

    public static class option_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "option"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:1: option : ( option_style | option_kv );
    public final simpletikzParser.option_return option() throws RecognitionException {
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.option_style_return option_style24 = null;

        simpletikzParser.option_kv_return option_kv25 = null;



        try { dbg.enterRule(getGrammarFileName(), "option");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(112, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:2: ( option_style | option_kv )
            int alt6=2;
            try { dbg.enterDecision(6);

            try {
                isCyclicDecision = true;
                alt6 = dfa6.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(6);}

            switch (alt6) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:4: option_style
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(113,4);
                    pushFollow(FOLLOW_option_style_in_option502);
                    option_style24=option_style();

                    state._fsp--;

                    adaptor.addChild(root_0, option_style24.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:114:5: option_kv
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(114,5);
                    pushFollow(FOLLOW_option_kv_in_option511);
                    option_kv25=option_kv();

                    state._fsp--;

                    adaptor.addChild(root_0, option_kv25.getTree());

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
        dbg.location(115, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:1: option_kv : idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) ;
    public final simpletikzParser.option_kv_return option_kv() throws RecognitionException {
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal27=null;
        simpletikzParser.idd_return idd26 = null;

        simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring28 = null;


        Object char_literal27_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_iddornumberunitorstring=new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunitorstring");
        try { dbg.enterRule(getGrammarFileName(), "option_kv");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(117, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:2: ( idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:4: idd ( '=' iddornumberunitorstring )?
            {
            dbg.location(118,4);
            pushFollow(FOLLOW_idd_in_option_kv525);
            idd26=idd();

            state._fsp--;

            stream_idd.add(idd26.getTree());
            dbg.location(118,8);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:8: ( '=' iddornumberunitorstring )?
            int alt7=2;
            try { dbg.enterSubRule(7);
            try { dbg.enterDecision(7);

            int LA7_0 = input.LA(1);

            if ( (LA7_0==EQU) ) {
                alt7=1;
            }
            } finally {dbg.exitDecision(7);}

            switch (alt7) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:9: '=' iddornumberunitorstring
                    {
                    dbg.location(118,9);
                    char_literal27=(Token)match(input,EQU,FOLLOW_EQU_in_option_kv528);  
                    stream_EQU.add(char_literal27);

                    dbg.location(118,13);
                    pushFollow(FOLLOW_iddornumberunitorstring_in_option_kv530);
                    iddornumberunitorstring28=iddornumberunitorstring();

                    state._fsp--;

                    stream_iddornumberunitorstring.add(iddornumberunitorstring28.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(7);}



            // AST REWRITE
            // elements: iddornumberunitorstring, idd
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 118:40: -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
            {
                dbg.location(118,43);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:43: ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(118,45);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

                dbg.location(118,58);
                adaptor.addChild(root_1, stream_idd.nextTree());
                dbg.location(118,62);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:62: ( iddornumberunitorstring )?
                if ( stream_iddornumberunitorstring.hasNext() ) {
                    dbg.location(118,62);
                    adaptor.addChild(root_1, stream_iddornumberunitorstring.nextTree());

                }
                stream_iddornumberunitorstring.reset();

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
        dbg.location(119, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "option_kv");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "option_kv"

    public static class tikzstring_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzstring"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:1: tikzstring : LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) ;
    public final simpletikzParser.tikzstring_return tikzstring() throws RecognitionException {
        simpletikzParser.tikzstring_return retval = new simpletikzParser.tikzstring_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LBRR29=null;
        Token RBRR33=null;
        simpletikzParser.no_rlbrace_return no_rlbrace30 = null;

        simpletikzParser.tikzstring_return tikzstring31 = null;

        simpletikzParser.no_rlbrace_return no_rlbrace32 = null;


        Object LBRR29_tree=null;
        Object RBRR33_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleSubtreeStream stream_tikzstring=new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace=new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try { dbg.enterRule(getGrammarFileName(), "tikzstring");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(121, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:2: ( LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:4: LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR
            {
            dbg.location(122,4);
            LBRR29=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzstring558);  
            stream_LBRR.add(LBRR29);

            dbg.location(122,9);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:9: ( no_rlbrace )*
            try { dbg.enterSubRule(8);

            loop8:
            do {
                int alt8=2;
                try { dbg.enterDecision(8);

                int LA8_0 = input.LA(1);

                if ( ((LA8_0>=BEGIN && LA8_0<=RBR)||(LA8_0>=KOMMA && LA8_0<=66)) ) {
                    alt8=1;
                }


                } finally {dbg.exitDecision(8);}

                switch (alt8) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:9: no_rlbrace
            	    {
            	    dbg.location(122,9);
            	    pushFollow(FOLLOW_no_rlbrace_in_tikzstring560);
            	    no_rlbrace30=no_rlbrace();

            	    state._fsp--;

            	    stream_no_rlbrace.add(no_rlbrace30.getTree());

            	    }
            	    break;

            	default :
            	    break loop8;
                }
            } while (true);
            } finally {dbg.exitSubRule(8);}

            dbg.location(122,21);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:21: ( tikzstring ( no_rlbrace )* )*
            try { dbg.enterSubRule(10);

            loop10:
            do {
                int alt10=2;
                try { dbg.enterDecision(10);

                int LA10_0 = input.LA(1);

                if ( (LA10_0==LBRR) ) {
                    alt10=1;
                }


                } finally {dbg.exitDecision(10);}

                switch (alt10) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:22: tikzstring ( no_rlbrace )*
            	    {
            	    dbg.location(122,22);
            	    pushFollow(FOLLOW_tikzstring_in_tikzstring564);
            	    tikzstring31=tikzstring();

            	    state._fsp--;

            	    stream_tikzstring.add(tikzstring31.getTree());
            	    dbg.location(122,33);
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:33: ( no_rlbrace )*
            	    try { dbg.enterSubRule(9);

            	    loop9:
            	    do {
            	        int alt9=2;
            	        try { dbg.enterDecision(9);

            	        int LA9_0 = input.LA(1);

            	        if ( ((LA9_0>=BEGIN && LA9_0<=RBR)||(LA9_0>=KOMMA && LA9_0<=66)) ) {
            	            alt9=1;
            	        }


            	        } finally {dbg.exitDecision(9);}

            	        switch (alt9) {
            	    	case 1 :
            	    	    dbg.enterAlt(1);

            	    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:33: no_rlbrace
            	    	    {
            	    	    dbg.location(122,33);
            	    	    pushFollow(FOLLOW_no_rlbrace_in_tikzstring566);
            	    	    no_rlbrace32=no_rlbrace();

            	    	    state._fsp--;

            	    	    stream_no_rlbrace.add(no_rlbrace32.getTree());

            	    	    }
            	    	    break;

            	    	default :
            	    	    break loop9;
            	        }
            	    } while (true);
            	    } finally {dbg.exitSubRule(9);}


            	    }
            	    break;

            	default :
            	    break loop10;
                }
            } while (true);
            } finally {dbg.exitSubRule(10);}

            dbg.location(122,47);
            RBRR33=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzstring571);  
            stream_RBRR.add(RBRR33);



            // AST REWRITE
            // elements: LBRR, RBRR
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 122:52: -> ^( IM_STRING LBRR RBRR )
            {
                dbg.location(122,55);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:55: ^( IM_STRING LBRR RBRR )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(122,57);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STRING, "IM_STRING"), root_1);

                dbg.location(122,67);
                adaptor.addChild(root_1, stream_LBRR.nextNode());
                dbg.location(122,72);
                adaptor.addChild(root_1, stream_RBRR.nextNode());

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
        dbg.location(123, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzstring");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzstring"

    public static class no_rlbrace_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "no_rlbrace"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:1: no_rlbrace : ~ ( LBRR | RBRR ) ;
    public final simpletikzParser.no_rlbrace_return no_rlbrace() throws RecognitionException {
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set34=null;

        Object set34_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "no_rlbrace");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(125, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:2: (~ ( LBRR | RBRR ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:4: ~ ( LBRR | RBRR )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(126,4);
            set34=(Token)input.LT(1);
            if ( (input.LA(1)>=BEGIN && input.LA(1)<=RBR)||(input.LA(1)>=KOMMA && input.LA(1)<=66) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set34));
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
        dbg.location(127, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "no_rlbrace");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "no_rlbrace"

    public static class iddornumberunitorstring_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "iddornumberunitorstring"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:1: iddornumberunitorstring : ( idd | numberunit | tikzstring );
    public final simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring() throws RecognitionException {
        simpletikzParser.iddornumberunitorstring_return retval = new simpletikzParser.iddornumberunitorstring_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.idd_return idd35 = null;

        simpletikzParser.numberunit_return numberunit36 = null;

        simpletikzParser.tikzstring_return tikzstring37 = null;



        try { dbg.enterRule(getGrammarFileName(), "iddornumberunitorstring");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(128, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:2: ( idd | numberunit | tikzstring )
            int alt11=3;
            try { dbg.enterDecision(11);

            switch ( input.LA(1) ) {
            case ID:
                {
                alt11=1;
                }
                break;
            case FLOAT:
            case INT:
                {
                alt11=2;
                }
                break;
            case LBRR:
                {
                alt11=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 11, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(11);}

            switch (alt11) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:4: idd
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(129,4);
                    pushFollow(FOLLOW_idd_in_iddornumberunitorstring611);
                    idd35=idd();

                    state._fsp--;

                    adaptor.addChild(root_0, idd35.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:10: numberunit
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(129,10);
                    pushFollow(FOLLOW_numberunit_in_iddornumberunitorstring615);
                    numberunit36=numberunit();

                    state._fsp--;

                    adaptor.addChild(root_0, numberunit36.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:23: tikzstring
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(129,23);
                    pushFollow(FOLLOW_tikzstring_in_iddornumberunitorstring619);
                    tikzstring37=tikzstring();

                    state._fsp--;

                    adaptor.addChild(root_0, tikzstring37.getTree());

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
        dbg.location(130, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "iddornumberunitorstring");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "iddornumberunitorstring"

    public static class option_style_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "option_style"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:1: option_style : idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public final simpletikzParser.option_style_return option_style() throws RecognitionException {
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal39=null;
        Token char_literal40=null;
        Token LBRR41=null;
        Token char_literal43=null;
        Token char_literal45=null;
        Token RBRR46=null;
        simpletikzParser.idd_return idd38 = null;

        simpletikzParser.option_kv_return option_kv42 = null;

        simpletikzParser.option_kv_return option_kv44 = null;


        Object string_literal39_tree=null;
        Object char_literal40_tree=null;
        Object LBRR41_tree=null;
        Object char_literal43_tree=null;
        Object char_literal45_tree=null;
        Object RBRR46_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_51=new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv=new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try { dbg.enterRule(getGrammarFileName(), "option_style");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(131, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:2: ( idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:4: idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR
            {
            dbg.location(132,4);
            pushFollow(FOLLOW_idd_in_option_style629);
            idd38=idd();

            state._fsp--;

            stream_idd.add(idd38.getTree());
            dbg.location(132,8);
            string_literal39=(Token)match(input,51,FOLLOW_51_in_option_style631);  
            stream_51.add(string_literal39);

            dbg.location(132,18);
            char_literal40=(Token)match(input,EQU,FOLLOW_EQU_in_option_style633);  
            stream_EQU.add(char_literal40);

            dbg.location(132,22);
            LBRR41=(Token)match(input,LBRR,FOLLOW_LBRR_in_option_style635);  
            stream_LBRR.add(LBRR41);

            dbg.location(132,27);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:27: ( option_kv ( ',' option_kv )* )?
            int alt13=2;
            try { dbg.enterSubRule(13);
            try { dbg.enterDecision(13);

            int LA13_0 = input.LA(1);

            if ( (LA13_0==ID) ) {
                alt13=1;
            }
            } finally {dbg.exitDecision(13);}

            switch (alt13) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:28: option_kv ( ',' option_kv )*
                    {
                    dbg.location(132,28);
                    pushFollow(FOLLOW_option_kv_in_option_style638);
                    option_kv42=option_kv();

                    state._fsp--;

                    stream_option_kv.add(option_kv42.getTree());
                    dbg.location(132,38);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:38: ( ',' option_kv )*
                    try { dbg.enterSubRule(12);

                    loop12:
                    do {
                        int alt12=2;
                        try { dbg.enterDecision(12);

                        int LA12_0 = input.LA(1);

                        if ( (LA12_0==KOMMA) ) {
                            int LA12_1 = input.LA(2);

                            if ( (LA12_1==ID) ) {
                                alt12=1;
                            }


                        }


                        } finally {dbg.exitDecision(12);}

                        switch (alt12) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:39: ',' option_kv
                    	    {
                    	    dbg.location(132,39);
                    	    char_literal43=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_option_style641);  
                    	    stream_KOMMA.add(char_literal43);

                    	    dbg.location(132,43);
                    	    pushFollow(FOLLOW_option_kv_in_option_style643);
                    	    option_kv44=option_kv();

                    	    state._fsp--;

                    	    stream_option_kv.add(option_kv44.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop12;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(12);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(13);}

            dbg.location(132,58);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:58: ( ',' )?
            int alt14=2;
            try { dbg.enterSubRule(14);
            try { dbg.enterDecision(14);

            int LA14_0 = input.LA(1);

            if ( (LA14_0==KOMMA) ) {
                alt14=1;
            }
            } finally {dbg.exitDecision(14);}

            switch (alt14) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:58: ','
                    {
                    dbg.location(132,58);
                    char_literal45=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_option_style650);  
                    stream_KOMMA.add(char_literal45);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(14);}

            dbg.location(132,63);
            RBRR46=(Token)match(input,RBRR,FOLLOW_RBRR_in_option_style653);  
            stream_RBRR.add(RBRR46);



            // AST REWRITE
            // elements: idd, option_kv
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 132:69: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            {
                dbg.location(132,72);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:72: ^( IM_OPTION_STYLE idd ( option_kv )* )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(132,74);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

                dbg.location(132,90);
                adaptor.addChild(root_1, stream_idd.nextTree());
                dbg.location(132,94);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:94: ( option_kv )*
                while ( stream_option_kv.hasNext() ) {
                    dbg.location(132,94);
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
        dbg.location(133, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:136:1: idd : ID ( ID | number )* -> ^( IM_ID ( ID )* ) ;
    public final simpletikzParser.idd_return idd() throws RecognitionException {
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token ID47=null;
        Token ID48=null;
        simpletikzParser.number_return number49 = null;


        Object ID47_tree=null;
        Object ID48_tree=null;
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
        try { dbg.enterRule(getGrammarFileName(), "idd");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(136, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:2: ( ID ( ID | number )* -> ^( IM_ID ( ID )* ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:4: ID ( ID | number )*
            {
            dbg.location(137,4);
            ID47=(Token)match(input,ID,FOLLOW_ID_in_idd679);  
            stream_ID.add(ID47);

            dbg.location(137,7);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:7: ( ID | number )*
            try { dbg.enterSubRule(15);

            loop15:
            do {
                int alt15=3;
                try { dbg.enterDecision(15);

                int LA15_0 = input.LA(1);

                if ( (LA15_0==ID) ) {
                    alt15=1;
                }
                else if ( ((LA15_0>=FLOAT && LA15_0<=INT)) ) {
                    alt15=2;
                }


                } finally {dbg.exitDecision(15);}

                switch (alt15) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:8: ID
            	    {
            	    dbg.location(137,8);
            	    ID48=(Token)match(input,ID,FOLLOW_ID_in_idd682);  
            	    stream_ID.add(ID48);


            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:13: number
            	    {
            	    dbg.location(137,13);
            	    pushFollow(FOLLOW_number_in_idd686);
            	    number49=number();

            	    state._fsp--;

            	    stream_number.add(number49.getTree());

            	    }
            	    break;

            	default :
            	    break loop15;
                }
            } while (true);
            } finally {dbg.exitSubRule(15);}



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
            // 137:22: -> ^( IM_ID ( ID )* )
            {
                dbg.location(137,25);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:25: ^( IM_ID ( ID )* )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(137,27);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ID, "IM_ID"), root_1);

                dbg.location(137,33);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:33: ( ID )*
                while ( stream_ID.hasNext() ) {
                    dbg.location(137,33);
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
        dbg.location(138, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "idd");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "idd"

    public static class numberunit_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "numberunit"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:140:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public final simpletikzParser.numberunit_return numberunit() throws RecognitionException {
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.number_return number50 = null;

        simpletikzParser.unit_return unit51 = null;


        RewriteRuleSubtreeStream stream_unit=new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
        try { dbg.enterRule(getGrammarFileName(), "numberunit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(140, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:4: number ( unit )?
            {
            dbg.location(141,4);
            pushFollow(FOLLOW_number_in_numberunit712);
            number50=number();

            state._fsp--;

            stream_number.add(number50.getTree());
            dbg.location(141,11);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:11: ( unit )?
            int alt16=2;
            try { dbg.enterSubRule(16);
            try { dbg.enterDecision(16);

            int LA16_0 = input.LA(1);

            if ( ((LA16_0>=52 && LA16_0<=56)) ) {
                alt16=1;
            }
            } finally {dbg.exitDecision(16);}

            switch (alt16) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:11: unit
                    {
                    dbg.location(141,11);
                    pushFollow(FOLLOW_unit_in_numberunit714);
                    unit51=unit();

                    state._fsp--;

                    stream_unit.add(unit51.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(16);}



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
            // 141:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            {
                dbg.location(141,20);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:20: ^( IM_NUMBERUNIT number ( unit )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(141,22);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

                dbg.location(141,36);
                adaptor.addChild(root_1, stream_number.nextTree());
                dbg.location(141,43);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:43: ( unit )?
                if ( stream_unit.hasNext() ) {
                    dbg.location(141,43);
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
        dbg.location(142, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:1: number : ( FLOAT | INT ) ;
    public final simpletikzParser.number_return number() throws RecognitionException {
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set52=null;

        Object set52_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "number");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(143, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:2: ( ( FLOAT | INT ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:4: ( FLOAT | INT )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(144,4);
            set52=(Token)input.LT(1);
            if ( (input.LA(1)>=FLOAT && input.LA(1)<=INT) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set52));
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
        dbg.location(145, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' );
    public final simpletikzParser.unit_return unit() throws RecognitionException {
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set53=null;

        Object set53_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(146, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(147,2);
            set53=(Token)input.LT(1);
            if ( (input.LA(1)>=52 && input.LA(1)<=56) ) {
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
        dbg.location(148, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "unit");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "unit"

    public static class tikz_set_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_set"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:1: tikz_set : tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public final simpletikzParser.tikz_set_return tikz_set() throws RecognitionException {
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal56=null;
        simpletikzParser.tikz_set_start_return tikz_set_start54 = null;

        simpletikzParser.option_return option55 = null;

        simpletikzParser.option_return option57 = null;

        simpletikzParser.roundbr_end_return roundbr_end58 = null;


        Object char_literal56_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_tikz_set_start=new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end=new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try { dbg.enterRule(getGrammarFileName(), "tikz_set");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(150, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:2: ( tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:5: tikz_set_start ( option ( ',' option )* )? roundbr_end
            {
            dbg.location(151,5);
            pushFollow(FOLLOW_tikz_set_start_in_tikz_set784);
            tikz_set_start54=tikz_set_start();

            state._fsp--;

            stream_tikz_set_start.add(tikz_set_start54.getTree());
            dbg.location(151,20);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:20: ( option ( ',' option )* )?
            int alt18=2;
            try { dbg.enterSubRule(18);
            try { dbg.enterDecision(18);

            int LA18_0 = input.LA(1);

            if ( (LA18_0==ID) ) {
                alt18=1;
            }
            } finally {dbg.exitDecision(18);}

            switch (alt18) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:21: option ( ',' option )*
                    {
                    dbg.location(151,21);
                    pushFollow(FOLLOW_option_in_tikz_set787);
                    option55=option();

                    state._fsp--;

                    stream_option.add(option55.getTree());
                    dbg.location(151,28);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:28: ( ',' option )*
                    try { dbg.enterSubRule(17);

                    loop17:
                    do {
                        int alt17=2;
                        try { dbg.enterDecision(17);

                        int LA17_0 = input.LA(1);

                        if ( (LA17_0==KOMMA) ) {
                            alt17=1;
                        }


                        } finally {dbg.exitDecision(17);}

                        switch (alt17) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:29: ',' option
                    	    {
                    	    dbg.location(151,29);
                    	    char_literal56=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_set790);  
                    	    stream_KOMMA.add(char_literal56);

                    	    dbg.location(151,33);
                    	    pushFollow(FOLLOW_option_in_tikz_set792);
                    	    option57=option();

                    	    state._fsp--;

                    	    stream_option.add(option57.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop17;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(17);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(18);}

            dbg.location(151,44);
            pushFollow(FOLLOW_roundbr_end_in_tikz_set798);
            roundbr_end58=roundbr_end();

            state._fsp--;

            stream_roundbr_end.add(roundbr_end58.getTree());


            // AST REWRITE
            // elements: option, tikz_set_start, roundbr_end
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 151:56: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            {
                dbg.location(151,59);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:59: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(151,61);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_TIKZSET, "IM_TIKZSET"), root_1);

                dbg.location(151,72);
                adaptor.addChild(root_1, stream_tikz_set_start.nextTree());
                dbg.location(151,87);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:87: ( option )*
                while ( stream_option.hasNext() ) {
                    dbg.location(151,87);
                    adaptor.addChild(root_1, stream_option.nextTree());

                }
                stream_option.reset();
                dbg.location(151,95);
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
        dbg.location(152, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_set");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikz_set"

    public static class tikzpicture_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpicture"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public final simpletikzParser.tikzpicture_return tikzpicture() throws RecognitionException {
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start59 = null;

        simpletikzParser.tikz_options_return tikz_options60 = null;

        simpletikzParser.tikzbody_return tikzbody61 = null;

        simpletikzParser.tikzpicture_end_return tikzpicture_end62 = null;


        RewriteRuleSubtreeStream stream_tikzpicture_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikzpicture");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(156, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            dbg.location(157,5);
            pushFollow(FOLLOW_tikzpicture_start_in_tikzpicture826);
            tikzpicture_start59=tikzpicture_start();

            state._fsp--;

            stream_tikzpicture_start.add(tikzpicture_start59.getTree());
            dbg.location(157,23);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:23: ( tikz_options )?
            int alt19=2;
            try { dbg.enterSubRule(19);
            try { dbg.enterDecision(19);

            int LA19_0 = input.LA(1);

            if ( (LA19_0==LBR) ) {
                alt19=1;
            }
            } finally {dbg.exitDecision(19);}

            switch (alt19) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:23: tikz_options
                    {
                    dbg.location(157,23);
                    pushFollow(FOLLOW_tikz_options_in_tikzpicture828);
                    tikz_options60=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options60.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(19);}

            dbg.location(157,37);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:37: ( tikzbody )?
            int alt20=2;
            try { dbg.enterSubRule(20);
            try { dbg.enterDecision(20);

            int LA20_0 = input.LA(1);

            if ( (LA20_0==BEGIN||(LA20_0>=USETIKZLIB && LA20_0<=RPAR)||(LA20_0>=RBR && LA20_0<=66)) ) {
                alt20=1;
            }
            else if ( (LA20_0==END) ) {
                int LA20_2 = input.LA(2);

                if ( (LA20_2==LBRR) ) {
                    int LA20_3 = input.LA(3);

                    if ( (LA20_3==ID) ) {
                        alt20=1;
                    }
                }
            }
            } finally {dbg.exitDecision(20);}

            switch (alt20) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:37: tikzbody
                    {
                    dbg.location(157,37);
                    pushFollow(FOLLOW_tikzbody_in_tikzpicture831);
                    tikzbody61=tikzbody();

                    state._fsp--;

                    stream_tikzbody.add(tikzbody61.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(20);}

            dbg.location(157,47);
            pushFollow(FOLLOW_tikzpicture_end_in_tikzpicture834);
            tikzpicture_end62=tikzpicture_end();

            state._fsp--;

            stream_tikzpicture_end.add(tikzpicture_end62.getTree());


            // AST REWRITE
            // elements: tikzbody, tikzpicture_end, tikz_options, tikzpicture_start
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 157:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            {
                dbg.location(157,67);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(157,69);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PICTURE, "IM_PICTURE"), root_1);

                dbg.location(157,80);
                adaptor.addChild(root_1, stream_tikzpicture_start.nextTree());
                dbg.location(157,98);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:98: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(157,98);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                dbg.location(157,112);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:112: ( tikzbody )?
                if ( stream_tikzbody.hasNext() ) {
                    dbg.location(157,112);
                    adaptor.addChild(root_1, stream_tikzbody.nextTree());

                }
                stream_tikzbody.reset();
                dbg.location(157,122);
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
        dbg.location(158, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzpicture");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzpicture"

    public static class tikzbody_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzbody"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:1: tikzbody : ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )* ;
    public final simpletikzParser.tikzbody_return tikzbody() throws RecognitionException {
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope63 = null;

        simpletikzParser.tikzpath_return tikzpath64 = null;

        simpletikzParser.tikznodee_return tikznodee65 = null;

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr66 = null;

        simpletikzParser.tikz_set_return tikz_set67 = null;

        simpletikzParser.tikz_style_return tikz_style68 = null;

        simpletikzParser.otherbegin_return otherbegin69 = null;

        simpletikzParser.otherend_return otherend70 = null;

        simpletikzParser.tikzscope_return tikzscope71 = null;

        simpletikzParser.tikzpath_return tikzpath72 = null;

        simpletikzParser.tikznodee_return tikznodee73 = null;

        simpletikzParser.dontcare_body_return dontcare_body74 = null;

        simpletikzParser.tikz_set_return tikz_set75 = null;

        simpletikzParser.tikz_style_return tikz_style76 = null;

        simpletikzParser.otherbegin_return otherbegin77 = null;

        simpletikzParser.otherend_return otherend78 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzbody");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(160, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:2: ( ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )* )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(161,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend )
            int alt21=8;
            try { dbg.enterSubRule(21);
            try { dbg.enterDecision(21);

            try {
                isCyclicDecision = true;
                alt21 = dfa21.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(21);}

            switch (alt21) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:6: tikzscope
                    {
                    dbg.location(161,6);
                    pushFollow(FOLLOW_tikzscope_in_tikzbody864);
                    tikzscope63=tikzscope();

                    state._fsp--;

                    adaptor.addChild(root_0, tikzscope63.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:18: tikzpath
                    {
                    dbg.location(161,18);
                    pushFollow(FOLLOW_tikzpath_in_tikzbody868);
                    tikzpath64=tikzpath();

                    state._fsp--;

                    adaptor.addChild(root_0, tikzpath64.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:29: tikznodee
                    {
                    dbg.location(161,29);
                    pushFollow(FOLLOW_tikznodee_in_tikzbody872);
                    tikznodee65=tikznodee();

                    state._fsp--;

                    adaptor.addChild(root_0, tikznodee65.getTree());

                    }
                    break;
                case 4 :
                    dbg.enterAlt(4);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:41: dontcare_body_nobr
                    {
                    dbg.location(161,41);
                    pushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody876);
                    dontcare_body_nobr66=dontcare_body_nobr();

                    state._fsp--;

                    adaptor.addChild(root_0, dontcare_body_nobr66.getTree());

                    }
                    break;
                case 5 :
                    dbg.enterAlt(5);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:62: tikz_set
                    {
                    dbg.location(161,62);
                    pushFollow(FOLLOW_tikz_set_in_tikzbody880);
                    tikz_set67=tikz_set();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_set67.getTree());

                    }
                    break;
                case 6 :
                    dbg.enterAlt(6);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:73: tikz_style
                    {
                    dbg.location(161,73);
                    pushFollow(FOLLOW_tikz_style_in_tikzbody884);
                    tikz_style68=tikz_style();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_style68.getTree());

                    }
                    break;
                case 7 :
                    dbg.enterAlt(7);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:86: otherbegin
                    {
                    dbg.location(161,86);
                    pushFollow(FOLLOW_otherbegin_in_tikzbody888);
                    otherbegin69=otherbegin();

                    state._fsp--;

                    adaptor.addChild(root_0, otherbegin69.getTree());

                    }
                    break;
                case 8 :
                    dbg.enterAlt(8);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:98: otherend
                    {
                    dbg.location(161,98);
                    pushFollow(FOLLOW_otherend_in_tikzbody891);
                    otherend70=otherend();

                    state._fsp--;

                    adaptor.addChild(root_0, otherend70.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(21);}

            dbg.location(162,3);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:3: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*
            try { dbg.enterSubRule(22);

            loop22:
            do {
                int alt22=9;
                try { dbg.enterDecision(22);

                try {
                    isCyclicDecision = true;
                    alt22 = dfa22.predict(input);
                }
                catch (NoViableAltException nvae) {
                    dbg.recognitionException(nvae);
                    throw nvae;
                }
                } finally {dbg.exitDecision(22);}

                switch (alt22) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:5: tikzscope
            	    {
            	    dbg.location(162,5);
            	    pushFollow(FOLLOW_tikzscope_in_tikzbody901);
            	    tikzscope71=tikzscope();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzscope71.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:17: tikzpath
            	    {
            	    dbg.location(162,17);
            	    pushFollow(FOLLOW_tikzpath_in_tikzbody905);
            	    tikzpath72=tikzpath();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzpath72.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:28: tikznodee
            	    {
            	    dbg.location(162,28);
            	    pushFollow(FOLLOW_tikznodee_in_tikzbody909);
            	    tikznodee73=tikznodee();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikznodee73.getTree());

            	    }
            	    break;
            	case 4 :
            	    dbg.enterAlt(4);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:40: dontcare_body
            	    {
            	    dbg.location(162,40);
            	    pushFollow(FOLLOW_dontcare_body_in_tikzbody913);
            	    dontcare_body74=dontcare_body();

            	    state._fsp--;

            	    adaptor.addChild(root_0, dontcare_body74.getTree());

            	    }
            	    break;
            	case 5 :
            	    dbg.enterAlt(5);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:56: tikz_set
            	    {
            	    dbg.location(162,56);
            	    pushFollow(FOLLOW_tikz_set_in_tikzbody917);
            	    tikz_set75=tikz_set();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikz_set75.getTree());

            	    }
            	    break;
            	case 6 :
            	    dbg.enterAlt(6);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:67: tikz_style
            	    {
            	    dbg.location(162,67);
            	    pushFollow(FOLLOW_tikz_style_in_tikzbody921);
            	    tikz_style76=tikz_style();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikz_style76.getTree());

            	    }
            	    break;
            	case 7 :
            	    dbg.enterAlt(7);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:80: otherbegin
            	    {
            	    dbg.location(162,80);
            	    pushFollow(FOLLOW_otherbegin_in_tikzbody925);
            	    otherbegin77=otherbegin();

            	    state._fsp--;

            	    adaptor.addChild(root_0, otherbegin77.getTree());

            	    }
            	    break;
            	case 8 :
            	    dbg.enterAlt(8);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:92: otherend
            	    {
            	    dbg.location(162,92);
            	    pushFollow(FOLLOW_otherend_in_tikzbody928);
            	    otherend78=otherend();

            	    state._fsp--;

            	    adaptor.addChild(root_0, otherend78.getTree());

            	    }
            	    break;

            	default :
            	    break loop22;
                }
            } while (true);
            } finally {dbg.exitSubRule(22);}


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
            dbg.exitRule(getGrammarFileName(), "tikzbody");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzbody"

    public static class dontcare_body_nobr_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "dontcare_body_nobr"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:1: dontcare_body_nobr : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) ) ;
    public final simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() throws RecognitionException {
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set79=null;

        Object set79_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "dontcare_body_nobr");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(165, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(166,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR )
            {
            dbg.location(166,5);
            set79=(Token)input.LT(1);
            if ( input.LA(1)==USETIKZLIB||(input.LA(1)>=LPAR && input.LA(1)<=RPAR)||(input.LA(1)>=RBR && input.LA(1)<=66) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set79));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                dbg.recognitionException(mse);
                throw mse;
            }


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
        dbg.location(167, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "dontcare_body_nobr");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "dontcare_body_nobr"

    public static class dontcare_body_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "dontcare_body"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:1: dontcare_body : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) ) ;
    public final simpletikzParser.dontcare_body_return dontcare_body() throws RecognitionException {
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set80=null;

        Object set80_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "dontcare_body");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(168, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(169,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET )
            {
            dbg.location(169,5);
            set80=(Token)input.LT(1);
            if ( input.LA(1)==USETIKZLIB||(input.LA(1)>=LPAR && input.LA(1)<=66) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set80));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                dbg.recognitionException(mse);
                throw mse;
            }


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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:171:1: otherend : END '{' idd '}' ;
    public final simpletikzParser.otherend_return otherend() throws RecognitionException {
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token END81=null;
        Token char_literal82=null;
        Token char_literal84=null;
        simpletikzParser.idd_return idd83 = null;


        Object END81_tree=null;
        Object char_literal82_tree=null;
        Object char_literal84_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "otherend");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(171, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:2: ( END '{' idd '}' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:4: END '{' idd '}'
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(172,4);
            END81=(Token)match(input,END,FOLLOW_END_in_otherend1038); 
            END81_tree = (Object)adaptor.create(END81);
            adaptor.addChild(root_0, END81_tree);

            dbg.location(172,8);
            char_literal82=(Token)match(input,LBRR,FOLLOW_LBRR_in_otherend1040); 
            char_literal82_tree = (Object)adaptor.create(char_literal82);
            adaptor.addChild(root_0, char_literal82_tree);

            dbg.location(172,12);
            pushFollow(FOLLOW_idd_in_otherend1042);
            idd83=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd83.getTree());
            dbg.location(172,16);
            char_literal84=(Token)match(input,RBRR,FOLLOW_RBRR_in_otherend1044); 
            char_literal84_tree = (Object)adaptor.create(char_literal84);
            adaptor.addChild(root_0, char_literal84_tree);


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
        dbg.location(173, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "otherend");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "otherend"

    public static class tikzpath_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpath"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:1: tikzpath : path_start ( tikz_options )? tikzpathi semicolon_end -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end ) ;
    public final simpletikzParser.tikzpath_return tikzpath() throws RecognitionException {
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_return path_start85 = null;

        simpletikzParser.tikz_options_return tikz_options86 = null;

        simpletikzParser.tikzpathi_return tikzpathi87 = null;

        simpletikzParser.semicolon_end_return semicolon_end88 = null;


        RewriteRuleSubtreeStream stream_path_start=new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_semicolon_end=new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try { dbg.enterRule(getGrammarFileName(), "tikzpath");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(175, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:2: ( path_start ( tikz_options )? tikzpathi semicolon_end -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:4: path_start ( tikz_options )? tikzpathi semicolon_end
            {
            dbg.location(176,4);
            pushFollow(FOLLOW_path_start_in_tikzpath1057);
            path_start85=path_start();

            state._fsp--;

            stream_path_start.add(path_start85.getTree());
            dbg.location(176,15);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:15: ( tikz_options )?
            int alt23=2;
            try { dbg.enterSubRule(23);
            try { dbg.enterDecision(23);

            int LA23_0 = input.LA(1);

            if ( (LA23_0==LBR) ) {
                alt23=1;
            }
            } finally {dbg.exitDecision(23);}

            switch (alt23) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:15: tikz_options
                    {
                    dbg.location(176,15);
                    pushFollow(FOLLOW_tikz_options_in_tikzpath1059);
                    tikz_options86=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options86.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(23);}

            dbg.location(176,29);
            pushFollow(FOLLOW_tikzpathi_in_tikzpath1062);
            tikzpathi87=tikzpathi();

            state._fsp--;

            stream_tikzpathi.add(tikzpathi87.getTree());
            dbg.location(176,39);
            pushFollow(FOLLOW_semicolon_end_in_tikzpath1064);
            semicolon_end88=semicolon_end();

            state._fsp--;

            stream_semicolon_end.add(semicolon_end88.getTree());


            // AST REWRITE
            // elements: tikz_options, path_start, tikzpathi, semicolon_end
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 176:53: -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end )
            {
                dbg.location(176,56);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:56: ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(176,58);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(176,66);
                adaptor.addChild(root_1, stream_path_start.nextTree());
                dbg.location(176,77);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:77: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(176,77);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                dbg.location(176,91);
                adaptor.addChild(root_1, stream_tikzpathi.nextTree());
                dbg.location(176,101);
                adaptor.addChild(root_1, stream_semicolon_end.nextTree());

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
            dbg.exitRule(getGrammarFileName(), "tikzpath");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzpath"

    public static class tikzpathi_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpathi"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:1: tikzpathi : coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* ;
    public final simpletikzParser.tikzpathi_return tikzpathi() throws RecognitionException {
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coordornode_return coordornode89 = null;

        simpletikzParser.coordornode_return coordornode90 = null;

        simpletikzParser.tikz_options_return tikz_options91 = null;

        simpletikzParser.edgeop_return edgeop92 = null;

        simpletikzParser.coordornode_return coordornode93 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzpathi");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(179, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:2: ( coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:5: coordornode ( coordornode | ( tikz_options )? edgeop coordornode )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(180,5);
            pushFollow(FOLLOW_coordornode_in_tikzpathi1093);
            coordornode89=coordornode();

            state._fsp--;

            adaptor.addChild(root_0, coordornode89.getTree());
            dbg.location(180,17);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:17: ( coordornode | ( tikz_options )? edgeop coordornode )*
            try { dbg.enterSubRule(25);

            loop25:
            do {
                int alt25=3;
                try { dbg.enterDecision(25);

                int LA25_0 = input.LA(1);

                if ( (LA25_0==LPAR||LA25_0==57||(LA25_0>=63 && LA25_0<=64)) ) {
                    alt25=1;
                }
                else if ( (LA25_0==LBR||LA25_0==ID||(LA25_0>=59 && LA25_0<=62)) ) {
                    alt25=2;
                }


                } finally {dbg.exitDecision(25);}

                switch (alt25) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:18: coordornode
            	    {
            	    dbg.location(180,18);
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi1096);
            	    coordornode90=coordornode();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode90.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:32: ( tikz_options )? edgeop coordornode
            	    {
            	    dbg.location(180,32);
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:32: ( tikz_options )?
            	    int alt24=2;
            	    try { dbg.enterSubRule(24);
            	    try { dbg.enterDecision(24);

            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0==LBR) ) {
            	        alt24=1;
            	    }
            	    } finally {dbg.exitDecision(24);}

            	    switch (alt24) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:32: tikz_options
            	            {
            	            dbg.location(180,32);
            	            pushFollow(FOLLOW_tikz_options_in_tikzpathi1100);
            	            tikz_options91=tikz_options();

            	            state._fsp--;

            	            adaptor.addChild(root_0, tikz_options91.getTree());

            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(24);}

            	    dbg.location(180,52);
            	    pushFollow(FOLLOW_edgeop_in_tikzpathi1103);
            	    edgeop92=edgeop();

            	    state._fsp--;

            	    dbg.location(180,54);
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi1106);
            	    coordornode93=coordornode();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode93.getTree());

            	    }
            	    break;

            	default :
            	    break loop25;
                }
            } while (true);
            } finally {dbg.exitSubRule(25);}


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
        dbg.location(181, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzpathi");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzpathi"

    public static class tikzscope_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzscope"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public final simpletikzParser.tikzscope_return tikzscope() throws RecognitionException {
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start94 = null;

        simpletikzParser.tikz_options_return tikz_options95 = null;

        simpletikzParser.tikzbody_return tikzbody96 = null;

        simpletikzParser.tikzscope_end_return tikzscope_end97 = null;


        RewriteRuleSubtreeStream stream_tikzscope_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikzscope");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(183, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            dbg.location(184,4);
            pushFollow(FOLLOW_tikzscope_start_in_tikzscope1122);
            tikzscope_start94=tikzscope_start();

            state._fsp--;

            stream_tikzscope_start.add(tikzscope_start94.getTree());
            dbg.location(184,20);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:20: ( tikz_options )?
            int alt26=2;
            try { dbg.enterSubRule(26);
            try { dbg.enterDecision(26);

            int LA26_0 = input.LA(1);

            if ( (LA26_0==LBR) ) {
                alt26=1;
            }
            } finally {dbg.exitDecision(26);}

            switch (alt26) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:20: tikz_options
                    {
                    dbg.location(184,20);
                    pushFollow(FOLLOW_tikz_options_in_tikzscope1124);
                    tikz_options95=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options95.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(26);}

            dbg.location(184,34);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:34: ( tikzbody )?
            int alt27=2;
            try { dbg.enterSubRule(27);
            try { dbg.enterDecision(27);

            int LA27_0 = input.LA(1);

            if ( (LA27_0==BEGIN||(LA27_0>=USETIKZLIB && LA27_0<=RPAR)||(LA27_0>=RBR && LA27_0<=66)) ) {
                alt27=1;
            }
            else if ( (LA27_0==END) ) {
                int LA27_2 = input.LA(2);

                if ( (LA27_2==LBRR) ) {
                    int LA27_3 = input.LA(3);

                    if ( (LA27_3==ID) ) {
                        alt27=1;
                    }
                }
            }
            } finally {dbg.exitDecision(27);}

            switch (alt27) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:34: tikzbody
                    {
                    dbg.location(184,34);
                    pushFollow(FOLLOW_tikzbody_in_tikzscope1127);
                    tikzbody96=tikzbody();

                    state._fsp--;

                    stream_tikzbody.add(tikzbody96.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(27);}

            dbg.location(184,44);
            pushFollow(FOLLOW_tikzscope_end_in_tikzscope1130);
            tikzscope_end97=tikzscope_end();

            state._fsp--;

            stream_tikzscope_end.add(tikzscope_end97.getTree());


            // AST REWRITE
            // elements: tikz_options, tikzscope_start, tikzbody, tikzscope_end
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 184:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            {
                dbg.location(184,62);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(184,64);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_SCOPE, "IM_SCOPE"), root_1);

                dbg.location(184,73);
                adaptor.addChild(root_1, stream_tikzscope_start.nextTree());
                dbg.location(184,89);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:184:89: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(184,89);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                dbg.location(184,103);
                adaptor.addChild(root_1, stream_tikzbody.nextTree());
                dbg.location(184,112);
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
        dbg.location(185, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzscope");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzscope"

    public static class coordornode_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coordornode"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:1: coordornode : ( coord | tikznodei );
    public final simpletikzParser.coordornode_return coordornode() throws RecognitionException {
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coord_return coord98 = null;

        simpletikzParser.tikznodei_return tikznodei99 = null;



        try { dbg.enterRule(getGrammarFileName(), "coordornode");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(187, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:2: ( coord | tikznodei )
            int alt28=2;
            try { dbg.enterDecision(28);

            int LA28_0 = input.LA(1);

            if ( (LA28_0==LPAR||(LA28_0>=63 && LA28_0<=64)) ) {
                alt28=1;
            }
            else if ( (LA28_0==57) ) {
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:4: coord
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(188,4);
                    pushFollow(FOLLOW_coord_in_coordornode1157);
                    coord98=coord();

                    state._fsp--;

                    adaptor.addChild(root_0, coord98.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:12: tikznodei
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(188,12);
                    pushFollow(FOLLOW_tikznodei_in_coordornode1161);
                    tikznodei99=tikznodei();

                    state._fsp--;

                    adaptor.addChild(root_0, tikznodei99.getTree());

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
        dbg.location(189, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:191:1: tikznodei : 'node' tikznode ;
    public final simpletikzParser.tikznodei_return tikznodei() throws RecognitionException {
        simpletikzParser.tikznodei_return retval = new simpletikzParser.tikznodei_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal100=null;
        simpletikzParser.tikznode_return tikznode101 = null;


        Object string_literal100_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "tikznodei");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(191, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:2: ( 'node' tikznode )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:4: 'node' tikznode
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(192,10);
            string_literal100=(Token)match(input,57,FOLLOW_57_in_tikznodei1173); 
            dbg.location(192,12);
            pushFollow(FOLLOW_tikznode_in_tikznodei1176);
            tikznode101=tikznode();

            state._fsp--;

            adaptor.addChild(root_0, tikznode101.getTree());

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
        dbg.location(193, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikznodei");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikznodei"

    public static class nodename_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "nodename"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:1: nodename : LPAR idd RPAR -> ^( IM_NODENAME idd ) ;
    public final simpletikzParser.nodename_return nodename() throws RecognitionException {
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LPAR102=null;
        Token RPAR104=null;
        simpletikzParser.idd_return idd103 = null;


        Object LPAR102_tree=null;
        Object RPAR104_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try { dbg.enterRule(getGrammarFileName(), "nodename");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(195, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:196:2: ( LPAR idd RPAR -> ^( IM_NODENAME idd ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:196:4: LPAR idd RPAR
            {
            dbg.location(196,4);
            LPAR102=(Token)match(input,LPAR,FOLLOW_LPAR_in_nodename1188);  
            stream_LPAR.add(LPAR102);

            dbg.location(196,9);
            pushFollow(FOLLOW_idd_in_nodename1190);
            idd103=idd();

            state._fsp--;

            stream_idd.add(idd103.getTree());
            dbg.location(196,13);
            RPAR104=(Token)match(input,RPAR,FOLLOW_RPAR_in_nodename1192);  
            stream_RPAR.add(RPAR104);



            // AST REWRITE
            // elements: idd
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 196:19: -> ^( IM_NODENAME idd )
            {
                dbg.location(196,22);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:196:22: ^( IM_NODENAME idd )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(196,24);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODENAME, "IM_NODENAME"), root_1);

                dbg.location(196,36);
                adaptor.addChild(root_1, stream_idd.nextTree());

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
        dbg.location(197, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:199:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep ) );
    public final simpletikzParser.coord_return coord() throws RecognitionException {
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token RPAR110=null;
        simpletikzParser.nodename_return nodename105 = null;

        simpletikzParser.coord_modifier_return coord_modifier106 = null;

        simpletikzParser.numberunit_return numberunit107 = null;

        simpletikzParser.coord_sep_return coord_sep108 = null;

        simpletikzParser.numberunit_return numberunit109 = null;


        Object lc_tree=null;
        Object RPAR110_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_numberunit=new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_sep=new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier=new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try { dbg.enterRule(getGrammarFileName(), "coord");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(199, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:200:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep ) )
            int alt30=2;
            try { dbg.enterDecision(30);

            int LA30_0 = input.LA(1);

            if ( (LA30_0==LPAR) ) {
                int LA30_1 = input.LA(2);

                if ( ((LA30_1>=FLOAT && LA30_1<=INT)) ) {
                    alt30=2;
                }
                else if ( (LA30_1==ID) ) {
                    alt30=1;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 30, 1, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
            }
            else if ( ((LA30_0>=63 && LA30_0<=64)) ) {
                alt30=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 30, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(30);}

            switch (alt30) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:200:6: nodename
                    {
                    dbg.location(200,6);
                    pushFollow(FOLLOW_nodename_in_coord1215);
                    nodename105=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename105.getTree());


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
                    // 200:23: -> ^( IM_COORD nodename )
                    {
                        dbg.location(200,26);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:200:26: ^( IM_COORD nodename )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(200,28);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, "IM_COORD"), root_1);

                        dbg.location(200,37);
                        adaptor.addChild(root_1, stream_nodename.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:5: ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR )
                    {
                    dbg.location(201,5);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:5: ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR )
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:7: ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR
                    {
                    dbg.location(201,7);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:7: ( coord_modifier )?
                    int alt29=2;
                    try { dbg.enterSubRule(29);
                    try { dbg.enterDecision(29);

                    int LA29_0 = input.LA(1);

                    if ( ((LA29_0>=63 && LA29_0<=64)) ) {
                        alt29=1;
                    }
                    } finally {dbg.exitDecision(29);}

                    switch (alt29) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:7: coord_modifier
                            {
                            dbg.location(201,7);
                            pushFollow(FOLLOW_coord_modifier_in_coord1239);
                            coord_modifier106=coord_modifier();

                            state._fsp--;

                            stream_coord_modifier.add(coord_modifier106.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(29);}

                    dbg.location(201,25);
                    lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_coord1244);  
                    stream_LPAR.add(lc);

                    dbg.location(201,31);
                    pushFollow(FOLLOW_numberunit_in_coord1246);
                    numberunit107=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit107.getTree());
                    dbg.location(201,42);
                    pushFollow(FOLLOW_coord_sep_in_coord1248);
                    coord_sep108=coord_sep();

                    state._fsp--;

                    stream_coord_sep.add(coord_sep108.getTree());
                    dbg.location(201,52);
                    pushFollow(FOLLOW_numberunit_in_coord1250);
                    numberunit109=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit109.getTree());
                    dbg.location(201,63);
                    RPAR110=(Token)match(input,RPAR,FOLLOW_RPAR_in_coord1252);  
                    stream_RPAR.add(RPAR110);


                    }



                    // AST REWRITE
                    // elements: numberunit, coord_modifier, coord_sep
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 201:70: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep )
                    {
                        dbg.location(201,73);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:73: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(201,75);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, lc), root_1);

                        dbg.location(201,89);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:89: ( coord_modifier )?
                        if ( stream_coord_modifier.hasNext() ) {
                            dbg.location(201,89);
                            adaptor.addChild(root_1, stream_coord_modifier.nextTree());

                        }
                        stream_coord_modifier.reset();
                        dbg.location(201,105);
                        if ( !(stream_numberunit.hasNext()) ) {
                            throw new RewriteEarlyExitException();
                        }
                        while ( stream_numberunit.hasNext() ) {
                            dbg.location(201,105);
                            adaptor.addChild(root_1, stream_numberunit.nextTree());

                        }
                        stream_numberunit.reset();
                        dbg.location(201,117);
                        adaptor.addChild(root_1, stream_coord_sep.nextTree());

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
        dbg.location(202, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "coord");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "coord"

    public static class coord_sep_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coord_sep"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:203:1: coord_sep : ( ',' | ':' ) ;
    public final simpletikzParser.coord_sep_return coord_sep() throws RecognitionException {
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set111=null;

        Object set111_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "coord_sep");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(203, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:204:2: ( ( ',' | ':' ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:204:4: ( ',' | ':' )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(204,4);
            set111=(Token)input.LT(1);
            if ( input.LA(1)==KOMMA||input.LA(1)==COLON ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set111));
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
        dbg.location(205, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "coord_sep");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "coord_sep"

    public static class tikznode_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznode"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:1: tikznode : ( nodename ( tikz_options )? )? ( 'at' coord ( tikz_options )? )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ( tikz_options )? ) ;
    public final simpletikzParser.tikznode_return tikznode() throws RecognitionException {
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal114=null;
        simpletikzParser.nodename_return nodename112 = null;

        simpletikzParser.tikz_options_return tikz_options113 = null;

        simpletikzParser.coord_return coord115 = null;

        simpletikzParser.tikz_options_return tikz_options116 = null;

        simpletikzParser.tikzstring_return tikzstring117 = null;


        Object string_literal114_tree=null;
        RewriteRuleTokenStream stream_58=new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleSubtreeStream stream_coord=new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_tikzstring=new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikznode");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(207, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:2: ( ( nodename ( tikz_options )? )? ( 'at' coord ( tikz_options )? )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ( tikz_options )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:4: ( nodename ( tikz_options )? )? ( 'at' coord ( tikz_options )? )? tikzstring
            {
            dbg.location(208,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:4: ( nodename ( tikz_options )? )?
            int alt32=2;
            try { dbg.enterSubRule(32);
            try { dbg.enterDecision(32);

            int LA32_0 = input.LA(1);

            if ( (LA32_0==LPAR) ) {
                alt32=1;
            }
            } finally {dbg.exitDecision(32);}

            switch (alt32) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:5: nodename ( tikz_options )?
                    {
                    dbg.location(208,5);
                    pushFollow(FOLLOW_nodename_in_tikznode1300);
                    nodename112=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename112.getTree());
                    dbg.location(208,14);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:14: ( tikz_options )?
                    int alt31=2;
                    try { dbg.enterSubRule(31);
                    try { dbg.enterDecision(31);

                    int LA31_0 = input.LA(1);

                    if ( (LA31_0==LBR) ) {
                        alt31=1;
                    }
                    } finally {dbg.exitDecision(31);}

                    switch (alt31) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:14: tikz_options
                            {
                            dbg.location(208,14);
                            pushFollow(FOLLOW_tikz_options_in_tikznode1302);
                            tikz_options113=tikz_options();

                            state._fsp--;

                            stream_tikz_options.add(tikz_options113.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(31);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(32);}

            dbg.location(208,30);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:30: ( 'at' coord ( tikz_options )? )?
            int alt34=2;
            try { dbg.enterSubRule(34);
            try { dbg.enterDecision(34);

            int LA34_0 = input.LA(1);

            if ( (LA34_0==58) ) {
                alt34=1;
            }
            } finally {dbg.exitDecision(34);}

            switch (alt34) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:31: 'at' coord ( tikz_options )?
                    {
                    dbg.location(208,31);
                    string_literal114=(Token)match(input,58,FOLLOW_58_in_tikznode1308);  
                    stream_58.add(string_literal114);

                    dbg.location(208,36);
                    pushFollow(FOLLOW_coord_in_tikznode1310);
                    coord115=coord();

                    state._fsp--;

                    stream_coord.add(coord115.getTree());
                    dbg.location(208,42);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:42: ( tikz_options )?
                    int alt33=2;
                    try { dbg.enterSubRule(33);
                    try { dbg.enterDecision(33);

                    int LA33_0 = input.LA(1);

                    if ( (LA33_0==LBR) ) {
                        alt33=1;
                    }
                    } finally {dbg.exitDecision(33);}

                    switch (alt33) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:42: tikz_options
                            {
                            dbg.location(208,42);
                            pushFollow(FOLLOW_tikz_options_in_tikznode1312);
                            tikz_options116=tikz_options();

                            state._fsp--;

                            stream_tikz_options.add(tikz_options116.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(33);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(34);}

            dbg.location(208,58);
            pushFollow(FOLLOW_tikzstring_in_tikznode1317);
            tikzstring117=tikzstring();

            state._fsp--;

            stream_tikzstring.add(tikzstring117.getTree());


            // AST REWRITE
            // elements: nodename, tikz_options, coord, tikzstring
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 208:70: -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ( tikz_options )? )
            {
                dbg.location(208,73);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:73: ^( IM_NODE ( nodename )? ( coord )? tikzstring ( tikz_options )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(208,75);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODE, "IM_NODE"), root_1);

                dbg.location(208,83);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:83: ( nodename )?
                if ( stream_nodename.hasNext() ) {
                    dbg.location(208,83);
                    adaptor.addChild(root_1, stream_nodename.nextTree());

                }
                stream_nodename.reset();
                dbg.location(208,93);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:93: ( coord )?
                if ( stream_coord.hasNext() ) {
                    dbg.location(208,93);
                    adaptor.addChild(root_1, stream_coord.nextTree());

                }
                stream_coord.reset();
                dbg.location(208,100);
                adaptor.addChild(root_1, stream_tikzstring.nextTree());
                dbg.location(208,111);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:111: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(208,111);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:211:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public final simpletikzParser.edgeop_return edgeop() throws RecognitionException {
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set118=null;

        Object set118_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "edgeop");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(211, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:212:2: ( '--' | '->' | '|-' | '-|' | ID )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(212,2);
            set118=(Token)input.LT(1);
            if ( input.LA(1)==ID||(input.LA(1)>=59 && input.LA(1)<=62) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set118));
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
        dbg.location(213, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "edgeop");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "edgeop"

    public static class coord_modifier_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coord_modifier"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:216:1: coord_modifier : ( '+' | '++' );
    public final simpletikzParser.coord_modifier_return coord_modifier() throws RecognitionException {
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set119=null;

        Object set119_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "coord_modifier");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(216, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:217:2: ( '+' | '++' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(217,2);
            set119=(Token)input.LT(1);
            if ( (input.LA(1)>=63 && input.LA(1)<=64) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set119));
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
        dbg.location(218, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "coord_modifier");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "coord_modifier"

    public static class tikznodee_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznodee"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:220:1: tikznodee : node_start ( tikz_options )? tikznode ( tikzpathi )? semicolon_end -> ^( IM_PATH node_start ( tikz_options )? tikznode ( tikzpathi )? semicolon_end ) ;
    public final simpletikzParser.tikznodee_return tikznodee() throws RecognitionException {
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.node_start_return node_start120 = null;

        simpletikzParser.tikz_options_return tikz_options121 = null;

        simpletikzParser.tikznode_return tikznode122 = null;

        simpletikzParser.tikzpathi_return tikzpathi123 = null;

        simpletikzParser.semicolon_end_return semicolon_end124 = null;


        RewriteRuleSubtreeStream stream_node_start=new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode=new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        RewriteRuleSubtreeStream stream_semicolon_end=new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try { dbg.enterRule(getGrammarFileName(), "tikznodee");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(220, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:221:2: ( node_start ( tikz_options )? tikznode ( tikzpathi )? semicolon_end -> ^( IM_PATH node_start ( tikz_options )? tikznode ( tikzpathi )? semicolon_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:221:4: node_start ( tikz_options )? tikznode ( tikzpathi )? semicolon_end
            {
            dbg.location(221,4);
            pushFollow(FOLLOW_node_start_in_tikznodee1394);
            node_start120=node_start();

            state._fsp--;

            stream_node_start.add(node_start120.getTree());
            dbg.location(221,15);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:221:15: ( tikz_options )?
            int alt35=2;
            try { dbg.enterSubRule(35);
            try { dbg.enterDecision(35);

            int LA35_0 = input.LA(1);

            if ( (LA35_0==LBR) ) {
                alt35=1;
            }
            } finally {dbg.exitDecision(35);}

            switch (alt35) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:221:15: tikz_options
                    {
                    dbg.location(221,15);
                    pushFollow(FOLLOW_tikz_options_in_tikznodee1396);
                    tikz_options121=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options121.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(35);}

            dbg.location(221,29);
            pushFollow(FOLLOW_tikznode_in_tikznodee1399);
            tikznode122=tikznode();

            state._fsp--;

            stream_tikznode.add(tikznode122.getTree());
            dbg.location(221,38);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:221:38: ( tikzpathi )?
            int alt36=2;
            try { dbg.enterSubRule(36);
            try { dbg.enterDecision(36);

            int LA36_0 = input.LA(1);

            if ( (LA36_0==LPAR||LA36_0==57||(LA36_0>=63 && LA36_0<=64)) ) {
                alt36=1;
            }
            } finally {dbg.exitDecision(36);}

            switch (alt36) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:221:38: tikzpathi
                    {
                    dbg.location(221,38);
                    pushFollow(FOLLOW_tikzpathi_in_tikznodee1401);
                    tikzpathi123=tikzpathi();

                    state._fsp--;

                    stream_tikzpathi.add(tikzpathi123.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(36);}

            dbg.location(221,49);
            pushFollow(FOLLOW_semicolon_end_in_tikznodee1404);
            semicolon_end124=semicolon_end();

            state._fsp--;

            stream_semicolon_end.add(semicolon_end124.getTree());


            // AST REWRITE
            // elements: semicolon_end, tikzpathi, tikznode, node_start, tikz_options
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 221:63: -> ^( IM_PATH node_start ( tikz_options )? tikznode ( tikzpathi )? semicolon_end )
            {
                dbg.location(221,66);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:221:66: ^( IM_PATH node_start ( tikz_options )? tikznode ( tikzpathi )? semicolon_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(221,68);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(221,76);
                adaptor.addChild(root_1, stream_node_start.nextTree());
                dbg.location(221,87);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:221:87: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(221,87);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                dbg.location(221,101);
                adaptor.addChild(root_1, stream_tikznode.nextTree());
                dbg.location(221,110);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:221:110: ( tikzpathi )?
                if ( stream_tikzpathi.hasNext() ) {
                    dbg.location(221,110);
                    adaptor.addChild(root_1, stream_tikzpathi.nextTree());

                }
                stream_tikzpathi.reset();
                dbg.location(221,121);
                adaptor.addChild(root_1, stream_semicolon_end.nextTree());

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
        dbg.location(222, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:224:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public final simpletikzParser.node_start_return node_start() throws RecognitionException {
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token NODE125=null;

        Object NODE125_tree=null;
        RewriteRuleTokenStream stream_NODE=new RewriteRuleTokenStream(adaptor,"token NODE");

        try { dbg.enterRule(getGrammarFileName(), "node_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(224, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:225:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:225:4: NODE
            {
            dbg.location(225,4);
            NODE125=(Token)match(input,NODE,FOLLOW_NODE_in_node_start1435);  
            stream_NODE.add(NODE125);



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
            // 225:9: -> ^( IM_STARTTAG NODE )
            {
                dbg.location(225,12);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:225:12: ^( IM_STARTTAG NODE )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(225,14);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(225,26);
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
        dbg.location(226, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "node_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "node_start"

    public static class squarebr_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "squarebr_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:267:1: squarebr_start : LBR -> ^( IM_STARTTAG LBR ) ;
    public final simpletikzParser.squarebr_start_return squarebr_start() throws RecognitionException {
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LBR126=null;

        Object LBR126_tree=null;
        RewriteRuleTokenStream stream_LBR=new RewriteRuleTokenStream(adaptor,"token LBR");

        try { dbg.enterRule(getGrammarFileName(), "squarebr_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(267, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:268:2: ( LBR -> ^( IM_STARTTAG LBR ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:268:4: LBR
            {
            dbg.location(268,4);
            LBR126=(Token)match(input,LBR,FOLLOW_LBR_in_squarebr_start1461);  
            stream_LBR.add(LBR126);



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
            // 268:8: -> ^( IM_STARTTAG LBR )
            {
                dbg.location(268,11);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:268:11: ^( IM_STARTTAG LBR )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(268,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(268,25);
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
        dbg.location(269, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:270:1: squarebr_end : RBR -> ^( IM_ENDTAG RBR ) ;
    public final simpletikzParser.squarebr_end_return squarebr_end() throws RecognitionException {
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token RBR127=null;

        Object RBR127_tree=null;
        RewriteRuleTokenStream stream_RBR=new RewriteRuleTokenStream(adaptor,"token RBR");

        try { dbg.enterRule(getGrammarFileName(), "squarebr_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(270, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:271:2: ( RBR -> ^( IM_ENDTAG RBR ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:271:4: RBR
            {
            dbg.location(271,4);
            RBR127=(Token)match(input,RBR,FOLLOW_RBR_in_squarebr_end1479);  
            stream_RBR.add(RBR127);



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
            // 271:8: -> ^( IM_ENDTAG RBR )
            {
                dbg.location(271,11);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:271:11: ^( IM_ENDTAG RBR )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(271,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(271,23);
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
        dbg.location(272, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "squarebr_end");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "squarebr_end"

    public static class semicolon_end_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "semicolon_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:273:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public final simpletikzParser.semicolon_end_return semicolon_end() throws RecognitionException {
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal128=null;

        Object char_literal128_tree=null;
        RewriteRuleTokenStream stream_SEMIC=new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try { dbg.enterRule(getGrammarFileName(), "semicolon_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(273, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:274:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:274:4: ';'
            {
            dbg.location(274,4);
            char_literal128=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_semicolon_end1498);  
            stream_SEMIC.add(char_literal128);



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
            // 274:8: -> ^( IM_ENDTAG ';' )
            {
                dbg.location(274,11);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:274:11: ^( IM_ENDTAG ';' )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(274,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(274,23);
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
        dbg.location(275, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:276:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public final simpletikzParser.roundbr_end_return roundbr_end() throws RecognitionException {
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal129=null;

        Object char_literal129_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");

        try { dbg.enterRule(getGrammarFileName(), "roundbr_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(276, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:277:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:277:4: '}'
            {
            dbg.location(277,4);
            char_literal129=(Token)match(input,RBRR,FOLLOW_RBRR_in_roundbr_end1516);  
            stream_RBRR.add(char_literal129);



            // AST REWRITE
            // elements: RBRR
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 277:8: -> ^( IM_ENDTAG '}' )
            {
                dbg.location(277,11);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:277:11: ^( IM_ENDTAG '}' )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(277,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(277,23);
                adaptor.addChild(root_1, stream_RBRR.nextNode());

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
        dbg.location(278, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "roundbr_end");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "roundbr_end"

    public static class tikz_set_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_set_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:279:1: tikz_set_start : TIKZSET '{' -> ^( IM_STARTTAG ) ;
    public final simpletikzParser.tikz_set_start_return tikz_set_start() throws RecognitionException {
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token TIKZSET130=null;
        Token char_literal131=null;

        Object TIKZSET130_tree=null;
        Object char_literal131_tree=null;
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSET=new RewriteRuleTokenStream(adaptor,"token TIKZSET");

        try { dbg.enterRule(getGrammarFileName(), "tikz_set_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(279, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:280:2: ( TIKZSET '{' -> ^( IM_STARTTAG ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:280:4: TIKZSET '{'
            {
            dbg.location(280,4);
            TIKZSET130=(Token)match(input,TIKZSET,FOLLOW_TIKZSET_in_tikz_set_start1534);  
            stream_TIKZSET.add(TIKZSET130);

            dbg.location(280,12);
            char_literal131=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikz_set_start1536);  
            stream_LBRR.add(char_literal131);



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
            // 280:17: -> ^( IM_STARTTAG )
            {
                dbg.location(280,20);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:280:20: ^( IM_STARTTAG )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(280,22);
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
        dbg.location(281, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_set_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikz_set_start"

    public static class tikzpicture_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpicture_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:282:1: tikzpicture_start : BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public final simpletikzParser.tikzpicture_start_return tikzpicture_start() throws RecognitionException {
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGIN132=null;
        Token char_literal133=null;
        Token string_literal134=null;
        Token char_literal135=null;

        Object BEGIN132_tree=null;
        Object char_literal133_tree=null;
        Object string_literal134_tree=null;
        Object char_literal135_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_65=new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleTokenStream stream_BEGIN=new RewriteRuleTokenStream(adaptor,"token BEGIN");

        try { dbg.enterRule(getGrammarFileName(), "tikzpicture_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(282, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:283:2: ( BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:283:4: BEGIN '{' 'tikzpicture' '}'
            {
            dbg.location(283,4);
            BEGIN132=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_tikzpicture_start1555);  
            stream_BEGIN.add(BEGIN132);

            dbg.location(283,10);
            char_literal133=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_start1557);  
            stream_LBRR.add(char_literal133);

            dbg.location(283,14);
            string_literal134=(Token)match(input,65,FOLLOW_65_in_tikzpicture_start1559);  
            stream_65.add(string_literal134);

            dbg.location(283,28);
            char_literal135=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_start1561);  
            stream_RBRR.add(char_literal135);



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
            // 283:32: -> ^( IM_STARTTAG BEGIN )
            {
                dbg.location(283,35);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:283:35: ^( IM_STARTTAG BEGIN )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(283,37);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(283,49);
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
        dbg.location(284, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:285:1: tikzpicture_end : END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) ;
    public final simpletikzParser.tikzpicture_end_return tikzpicture_end() throws RecognitionException {
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token END136=null;
        Token char_literal137=null;
        Token string_literal138=null;
        Token char_literal139=null;

        Object END136_tree=null;
        Object char_literal137_tree=null;
        Object string_literal138_tree=null;
        Object char_literal139_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END=new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_65=new RewriteRuleTokenStream(adaptor,"token 65");

        try { dbg.enterRule(getGrammarFileName(), "tikzpicture_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(285, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:286:2: ( END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:286:4: END '{' 'tikzpicture' '}'
            {
            dbg.location(286,4);
            END136=(Token)match(input,END,FOLLOW_END_in_tikzpicture_end1579);  
            stream_END.add(END136);

            dbg.location(286,8);
            char_literal137=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_end1581);  
            stream_LBRR.add(char_literal137);

            dbg.location(286,12);
            string_literal138=(Token)match(input,65,FOLLOW_65_in_tikzpicture_end1583);  
            stream_65.add(string_literal138);

            dbg.location(286,26);
            char_literal139=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_end1585);  
            stream_RBRR.add(char_literal139);



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
            // 286:30: -> ^( IM_ENDTAG END )
            {
                dbg.location(286,33);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:286:33: ^( IM_ENDTAG END )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(286,35);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(286,45);
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
        dbg.location(287, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzpicture_end");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzpicture_end"

    public static class tikzscope_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzscope_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:288:1: tikzscope_start : BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public final simpletikzParser.tikzscope_start_return tikzscope_start() throws RecognitionException {
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGIN140=null;
        Token char_literal141=null;
        Token string_literal142=null;
        Token char_literal143=null;

        Object BEGIN140_tree=null;
        Object char_literal141_tree=null;
        Object string_literal142_tree=null;
        Object char_literal143_tree=null;
        RewriteRuleTokenStream stream_66=new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_BEGIN=new RewriteRuleTokenStream(adaptor,"token BEGIN");

        try { dbg.enterRule(getGrammarFileName(), "tikzscope_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(288, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:289:2: ( BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:289:4: BEGIN '{' 'scope' '}'
            {
            dbg.location(289,4);
            BEGIN140=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_tikzscope_start1603);  
            stream_BEGIN.add(BEGIN140);

            dbg.location(289,10);
            char_literal141=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzscope_start1605);  
            stream_LBRR.add(char_literal141);

            dbg.location(289,14);
            string_literal142=(Token)match(input,66,FOLLOW_66_in_tikzscope_start1607);  
            stream_66.add(string_literal142);

            dbg.location(289,22);
            char_literal143=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzscope_start1609);  
            stream_RBRR.add(char_literal143);



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
            // 289:26: -> ^( IM_STARTTAG BEGIN )
            {
                dbg.location(289,29);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:289:29: ^( IM_STARTTAG BEGIN )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(289,31);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(289,43);
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
        dbg.location(290, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:291:1: tikzscope_end : END '{' 'scope' '}' -> ^( IM_ENDTAG END ) ;
    public final simpletikzParser.tikzscope_end_return tikzscope_end() throws RecognitionException {
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token END144=null;
        Token char_literal145=null;
        Token string_literal146=null;
        Token char_literal147=null;

        Object END144_tree=null;
        Object char_literal145_tree=null;
        Object string_literal146_tree=null;
        Object char_literal147_tree=null;
        RewriteRuleTokenStream stream_66=new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END=new RewriteRuleTokenStream(adaptor,"token END");

        try { dbg.enterRule(getGrammarFileName(), "tikzscope_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(291, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:292:2: ( END '{' 'scope' '}' -> ^( IM_ENDTAG END ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:292:4: END '{' 'scope' '}'
            {
            dbg.location(292,4);
            END144=(Token)match(input,END,FOLLOW_END_in_tikzscope_end1627);  
            stream_END.add(END144);

            dbg.location(292,8);
            char_literal145=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzscope_end1629);  
            stream_LBRR.add(char_literal145);

            dbg.location(292,12);
            string_literal146=(Token)match(input,66,FOLLOW_66_in_tikzscope_end1631);  
            stream_66.add(string_literal146);

            dbg.location(292,20);
            char_literal147=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzscope_end1633);  
            stream_RBRR.add(char_literal147);



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
            // 292:24: -> ^( IM_ENDTAG END )
            {
                dbg.location(292,27);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:292:27: ^( IM_ENDTAG END )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(292,29);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(292,39);
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
        dbg.location(293, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzscope_end");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzscope_end"

    public static class path_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "path_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:294:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public final simpletikzParser.path_start_return path_start() throws RecognitionException {
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag148 = null;


        RewriteRuleSubtreeStream stream_path_start_tag=new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try { dbg.enterRule(getGrammarFileName(), "path_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(294, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:295:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:295:4: path_start_tag
            {
            dbg.location(295,4);
            pushFollow(FOLLOW_path_start_tag_in_path_start1652);
            path_start_tag148=path_start_tag();

            state._fsp--;

            stream_path_start_tag.add(path_start_tag148.getTree());


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
            // 295:19: -> ^( IM_STARTTAG path_start_tag )
            {
                dbg.location(295,22);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:295:22: ^( IM_STARTTAG path_start_tag )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(295,24);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(295,36);
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
        dbg.location(296, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:298:1: path_start_tag : ( DRAW | FILL | PATH );
    public final simpletikzParser.path_start_tag_return path_start_tag() throws RecognitionException {
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set149=null;

        Object set149_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "path_start_tag");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(298, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:299:2: ( DRAW | FILL | PATH )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(299,2);
            set149=(Token)input.LT(1);
            if ( (input.LA(1)>=DRAW && input.LA(1)<=FILL) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set149));
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
        dbg.location(300, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "path_start_tag");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "path_start_tag"

    // Delegated rules


    protected DFA6 dfa6 = new DFA6(this);
    protected DFA21 dfa21 = new DFA21(this);
    protected DFA22 dfa22 = new DFA22(this);
    static final String DFA6_eotS =
        "\6\uffff";
    static final String DFA6_eofS =
        "\6\uffff";
    static final String DFA6_minS =
        "\1\51\3\20\2\uffff";
    static final String DFA6_maxS =
        "\1\51\3\63\2\uffff";
    static final String DFA6_acceptS =
        "\4\uffff\1\1\1\2";
    static final String DFA6_specialS =
        "\6\uffff}>";
    static final String[] DFA6_transitionS = {
            "\1\1",
            "\1\5\1\uffff\3\5\24\uffff\1\2\2\3\7\uffff\1\4",
            "\1\5\1\uffff\3\5\24\uffff\1\2\2\3\7\uffff\1\4",
            "\1\5\1\uffff\3\5\24\uffff\1\2\2\3\7\uffff\1\4",
            "",
            ""
    };

    static final short[] DFA6_eot = DFA.unpackEncodedString(DFA6_eotS);
    static final short[] DFA6_eof = DFA.unpackEncodedString(DFA6_eofS);
    static final char[] DFA6_min = DFA.unpackEncodedStringToUnsignedChars(DFA6_minS);
    static final char[] DFA6_max = DFA.unpackEncodedStringToUnsignedChars(DFA6_maxS);
    static final short[] DFA6_accept = DFA.unpackEncodedString(DFA6_acceptS);
    static final short[] DFA6_special = DFA.unpackEncodedString(DFA6_specialS);
    static final short[][] DFA6_transition;

    static {
        int numStates = DFA6_transitionS.length;
        DFA6_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA6_transition[i] = DFA.unpackEncodedString(DFA6_transitionS[i]);
        }
    }

    class DFA6 extends DFA {

        public DFA6(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;
        }
        public String getDescription() {
            return "112:1: option : ( option_style | option_kv );";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
    static final String DFA21_eotS =
        "\13\uffff";
    static final String DFA21_eofS =
        "\13\uffff";
    static final String DFA21_minS =
        "\1\4\1\21\6\uffff\1\51\2\uffff";
    static final String DFA21_maxS =
        "\1\102\1\21\6\uffff\1\102\2\uffff";
    static final String DFA21_acceptS =
        "\2\uffff\1\2\1\3\1\4\1\5\1\6\1\10\1\uffff\1\1\1\7";
    static final String DFA21_specialS =
        "\13\uffff}>";
    static final String[] DFA21_transitionS = {
            "\1\1\1\7\1\4\1\6\1\5\1\3\3\2\2\4\1\uffff\63\4",
            "\1\10",
            "",
            "",
            "",
            "",
            "",
            "",
            "\1\12\30\uffff\1\11",
            "",
            ""
    };

    static final short[] DFA21_eot = DFA.unpackEncodedString(DFA21_eotS);
    static final short[] DFA21_eof = DFA.unpackEncodedString(DFA21_eofS);
    static final char[] DFA21_min = DFA.unpackEncodedStringToUnsignedChars(DFA21_minS);
    static final char[] DFA21_max = DFA.unpackEncodedStringToUnsignedChars(DFA21_maxS);
    static final short[] DFA21_accept = DFA.unpackEncodedString(DFA21_acceptS);
    static final short[] DFA21_special = DFA.unpackEncodedString(DFA21_specialS);
    static final short[][] DFA21_transition;

    static {
        int numStates = DFA21_transitionS.length;
        DFA21_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA21_transition[i] = DFA.unpackEncodedString(DFA21_transitionS[i]);
        }
    }

    class DFA21 extends DFA {

        public DFA21(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 21;
            this.eot = DFA21_eot;
            this.eof = DFA21_eof;
            this.min = DFA21_min;
            this.max = DFA21_max;
            this.accept = DFA21_accept;
            this.special = DFA21_special;
            this.transition = DFA21_transition;
        }
        public String getDescription() {
            return "161:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend )";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
    static final String DFA22_eotS =
        "\16\uffff";
    static final String DFA22_eofS =
        "\16\uffff";
    static final String DFA22_minS =
        "\1\4\2\21\5\uffff\2\51\4\uffff";
    static final String DFA22_maxS =
        "\1\102\2\21\5\uffff\2\102\4\uffff";
    static final String DFA22_acceptS =
        "\3\uffff\1\2\1\3\1\4\1\5\1\6\2\uffff\1\11\1\10\1\1\1\7";
    static final String DFA22_specialS =
        "\16\uffff}>";
    static final String[] DFA22_transitionS = {
            "\1\2\1\1\1\5\1\7\1\6\1\4\3\3\66\5",
            "\1\10",
            "\1\11",
            "",
            "",
            "",
            "",
            "",
            "\1\13\27\uffff\2\12",
            "\1\15\30\uffff\1\14",
            "",
            "",
            "",
            ""
    };

    static final short[] DFA22_eot = DFA.unpackEncodedString(DFA22_eotS);
    static final short[] DFA22_eof = DFA.unpackEncodedString(DFA22_eofS);
    static final char[] DFA22_min = DFA.unpackEncodedStringToUnsignedChars(DFA22_minS);
    static final char[] DFA22_max = DFA.unpackEncodedStringToUnsignedChars(DFA22_maxS);
    static final short[] DFA22_accept = DFA.unpackEncodedString(DFA22_acceptS);
    static final short[] DFA22_special = DFA.unpackEncodedString(DFA22_specialS);
    static final short[][] DFA22_transition;

    static {
        int numStates = DFA22_transitionS.length;
        DFA22_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA22_transition[i] = DFA.unpackEncodedString(DFA22_transitionS[i]);
        }
    }

    class DFA22 extends DFA {

        public DFA22(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 22;
            this.eot = DFA22_eot;
            this.eof = DFA22_eof;
            this.min = DFA22_min;
            this.max = DFA22_max;
            this.accept = DFA22_accept;
            this.special = DFA22_special;
            this.transition = DFA22_transition;
        }
        public String getDescription() {
            return "()* loopback of 162:3: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
 

    public static final BitSet FOLLOW_dontcare_preamble_in_tikzdocument337 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikz_styleorset_in_tikzdocument341 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_otherbegin_in_tikzdocument345 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikzpicture_in_tikzdocument350 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_style_in_tikz_styleorset375 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_set_in_tikz_styleorset379 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_dontcare_preamble390 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_otherbegin411 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_otherbegin413 = new BitSet(new long[]{0x0000020000000000L});
    public static final BitSet FOLLOW_idd_in_otherbegin415 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_otherbegin417 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TIKZSTYLE_in_tikz_style428 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_tikz_style430 = new BitSet(new long[]{0x0000020000000000L});
    public static final BitSet FOLLOW_idd_in_tikz_style432 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_tikz_style434 = new BitSet(new long[]{0x0000000000100000L});
    public static final BitSet FOLLOW_EQU_in_tikz_style436 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_tikz_options_in_tikz_style438 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_squarebr_start_in_tikz_options460 = new BitSet(new long[]{0x0000020000010000L});
    public static final BitSet FOLLOW_option_in_tikz_options463 = new BitSet(new long[]{0x0000020000090000L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_options466 = new BitSet(new long[]{0x0000020000000000L});
    public static final BitSet FOLLOW_option_in_tikz_options468 = new BitSet(new long[]{0x0000020000090000L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_options472 = new BitSet(new long[]{0x0000020000010000L});
    public static final BitSet FOLLOW_squarebr_end_in_tikz_options477 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_style_in_option502 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_kv_in_option511 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_kv525 = new BitSet(new long[]{0x0000000000100002L});
    public static final BitSet FOLLOW_EQU_in_option_kv528 = new BitSet(new long[]{0x00000E0000020000L});
    public static final BitSet FOLLOW_iddornumberunitorstring_in_option_kv530 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBRR_in_tikzstring558 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_no_rlbrace_in_tikzstring560 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikzstring_in_tikzstring564 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_no_rlbrace_in_tikzstring566 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_RBRR_in_tikzstring571 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_no_rlbrace594 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_iddornumberunitorstring611 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_numberunit_in_iddornumberunitorstring615 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzstring_in_iddornumberunitorstring619 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_style629 = new BitSet(new long[]{0x0008000000000000L});
    public static final BitSet FOLLOW_51_in_option_style631 = new BitSet(new long[]{0x0000000000100000L});
    public static final BitSet FOLLOW_EQU_in_option_style633 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_option_style635 = new BitSet(new long[]{0x00000200000C0000L});
    public static final BitSet FOLLOW_option_kv_in_option_style638 = new BitSet(new long[]{0x00000000000C0000L});
    public static final BitSet FOLLOW_KOMMA_in_option_style641 = new BitSet(new long[]{0x0000020000000000L});
    public static final BitSet FOLLOW_option_kv_in_option_style643 = new BitSet(new long[]{0x00000000000C0000L});
    public static final BitSet FOLLOW_KOMMA_in_option_style650 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_option_style653 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ID_in_idd679 = new BitSet(new long[]{0x00000E0000000002L});
    public static final BitSet FOLLOW_ID_in_idd682 = new BitSet(new long[]{0x00000E0000000002L});
    public static final BitSet FOLLOW_number_in_idd686 = new BitSet(new long[]{0x00000E0000000002L});
    public static final BitSet FOLLOW_number_in_numberunit712 = new BitSet(new long[]{0x01F0000000000002L});
    public static final BitSet FOLLOW_unit_in_numberunit714 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_number737 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_unit0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_set_start_in_tikz_set784 = new BitSet(new long[]{0x0000020000040000L});
    public static final BitSet FOLLOW_option_in_tikz_set787 = new BitSet(new long[]{0x00000200000C0000L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_set790 = new BitSet(new long[]{0x0000020000000000L});
    public static final BitSet FOLLOW_option_in_tikz_set792 = new BitSet(new long[]{0x00000200000C0000L});
    public static final BitSet FOLLOW_roundbr_end_in_tikz_set798 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzpicture_start_in_tikzpicture826 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikz_options_in_tikzpicture828 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikzbody_in_tikzpicture831 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikzpicture_end_in_tikzpicture834 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody864 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody868 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikznodee_in_tikzbody872 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_dontcare_body_nobr_in_tikzbody876 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikz_set_in_tikzbody880 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikz_style_in_tikzbody884 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_otherbegin_in_tikzbody888 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_otherend_in_tikzbody891 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody901 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody905 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikznodee_in_tikzbody909 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_dontcare_body_in_tikzbody913 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikz_set_in_tikzbody917 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikz_style_in_tikzbody921 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_otherbegin_in_tikzbody925 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_otherend_in_tikzbody928 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000007L});
    public static final BitSet FOLLOW_set_in_dontcare_body_nobr944 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_dontcare_body994 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_otherend1038 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_otherend1040 = new BitSet(new long[]{0x0000020000000000L});
    public static final BitSet FOLLOW_idd_in_otherend1042 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_otherend1044 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_in_tikzpath1057 = new BitSet(new long[]{0x820000000000A000L,0x0000000000000001L});
    public static final BitSet FOLLOW_tikz_options_in_tikzpath1059 = new BitSet(new long[]{0x820000000000A000L,0x0000000000000001L});
    public static final BitSet FOLLOW_tikzpathi_in_tikzpath1062 = new BitSet(new long[]{0x0000000000200000L});
    public static final BitSet FOLLOW_semicolon_end_in_tikzpath1064 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi1093 = new BitSet(new long[]{0xFA0002000000A002L,0x0000000000000001L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi1096 = new BitSet(new long[]{0xFA0002000000A002L,0x0000000000000001L});
    public static final BitSet FOLLOW_tikz_options_in_tikzpathi1100 = new BitSet(new long[]{0xFA0002000000A000L,0x0000000000000001L});
    public static final BitSet FOLLOW_edgeop_in_tikzpathi1103 = new BitSet(new long[]{0x820000000000A000L,0x0000000000000001L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi1106 = new BitSet(new long[]{0xFA0002000000A002L,0x0000000000000001L});
    public static final BitSet FOLLOW_tikzscope_start_in_tikzscope1122 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikz_options_in_tikzscope1124 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikzbody_in_tikzscope1127 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000007L});
    public static final BitSet FOLLOW_tikzscope_end_in_tikzscope1130 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_in_coordornode1157 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikznodei_in_coordornode1161 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_57_in_tikznodei1173 = new BitSet(new long[]{0x04000E0000022000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodei1176 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LPAR_in_nodename1188 = new BitSet(new long[]{0x0000020000000000L});
    public static final BitSet FOLLOW_idd_in_nodename1190 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_RPAR_in_nodename1192 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_coord1215 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_modifier_in_coord1239 = new BitSet(new long[]{0x0000000000002000L});
    public static final BitSet FOLLOW_LPAR_in_coord1244 = new BitSet(new long[]{0x00000C0000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord1246 = new BitSet(new long[]{0x0000000000480000L});
    public static final BitSet FOLLOW_coord_sep_in_coord1248 = new BitSet(new long[]{0x00000C0000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord1250 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_RPAR_in_coord1252 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_sep1279 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_tikznode1300 = new BitSet(new long[]{0x04000E0000028000L});
    public static final BitSet FOLLOW_tikz_options_in_tikznode1302 = new BitSet(new long[]{0x04000E0000020000L});
    public static final BitSet FOLLOW_58_in_tikznode1308 = new BitSet(new long[]{0x8000000000002000L,0x0000000000000001L});
    public static final BitSet FOLLOW_coord_in_tikznode1310 = new BitSet(new long[]{0x00000E0000028000L});
    public static final BitSet FOLLOW_tikz_options_in_tikznode1312 = new BitSet(new long[]{0x00000E0000020000L});
    public static final BitSet FOLLOW_tikzstring_in_tikznode1317 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_edgeop0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_node_start_in_tikznodee1394 = new BitSet(new long[]{0x04000E000002A000L});
    public static final BitSet FOLLOW_tikz_options_in_tikznodee1396 = new BitSet(new long[]{0x04000E0000022000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodee1399 = new BitSet(new long[]{0x820000000020A000L,0x0000000000000001L});
    public static final BitSet FOLLOW_tikzpathi_in_tikznodee1401 = new BitSet(new long[]{0x0000000000200000L});
    public static final BitSet FOLLOW_semicolon_end_in_tikznodee1404 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_node_start1435 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBR_in_squarebr_start1461 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RBR_in_squarebr_end1479 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SEMIC_in_semicolon_end1498 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RBRR_in_roundbr_end1516 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TIKZSET_in_tikz_set_start1534 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_tikz_set_start1536 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_tikzpicture_start1555 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_tikzpicture_start1557 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000002L});
    public static final BitSet FOLLOW_65_in_tikzpicture_start1559 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_tikzpicture_start1561 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_tikzpicture_end1579 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_tikzpicture_end1581 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000002L});
    public static final BitSet FOLLOW_65_in_tikzpicture_end1583 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_tikzpicture_end1585 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_tikzscope_start1603 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_tikzscope_start1605 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000004L});
    public static final BitSet FOLLOW_66_in_tikzscope_start1607 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_tikzscope_start1609 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_tikzscope_end1627 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_tikzscope_end1629 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000004L});
    public static final BitSet FOLLOW_66_in_tikzscope_end1631 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_tikzscope_end1633 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_tag_in_path_start1652 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new long[]{0x0000000000000002L});

}