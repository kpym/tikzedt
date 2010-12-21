// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g 2010-12-19 21:39:33

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;
import java.util.Map;
import java.util.HashMap;
import org.antlr.runtime.debug.*;
import java.io.IOException;

import org.antlr.runtime.tree.*;

public class TikzGrammarParser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BACKSLASH", "BEGIN", "END", "FUNC", "AND", "OPERATOR", "STRING", "HVLINE", "VHLINE", "TO", "IN", "CYCLE", "FOREACH", "CS", "NODE", "AT", "FUNCTION", "FILE", "COORDINATES", "COORDINATE", "EDGE", "CONTROLS", "FROM", "PARENT", "DOTS", "RECTANGLE", "GRID", "PLOT", "CHILD", "CIRCLE", "ELLIPSE", "ARC", "PARABOLA", "BEND", "LINE", "AGAINPATH", "COMMENT", "OPERATION", "COORD_SYS", "POINT", "CURVE", "SIN", "COS", "LINETO", "LINETOHV", "LINETOVH", "MOVETO", "VARNAME", "PATH_CONSTRUCTION", "GNUPLOT", "EDGE_FROM_PARENT", "MACRO", "BODY", "NAME", "VALUE", "LIST_ELEM", "LIST", "LISTS", "BLOCK", "BLOCKS", "COMMAND", "COMMANDS", "OPTION", "OPTIONS", "PC", "PD", "PE", "KEYWORDS", "CONTROL_CHARS", "WS", "'{'", "'}'", "';'", "'('", "')'", "'['", "']'", "','", "':'"
    };
    public static final int FUNCTION=20;
    public static final int LINETO=47;
    public static final int CONTROLS=25;
    public static final int OPTION=66;
    public static final int COORDINATE=23;
    public static final int POINT=43;
    public static final int CYCLE=15;
    public static final int EDGE=24;
    public static final int DOTS=28;
    public static final int PATH_CONSTRUCTION=52;
    public static final int LISTS=61;
    public static final int AND=8;
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
    public static final int OPERATOR=9;
    public static final int GRID=30;
    public static final int CURVE=44;
    public static final int EDGE_FROM_PARENT=54;
    public static final int HVLINE=11;
    public static final int VALUE=58;
    public static final int LIST=60;
    public static final int FILE=21;
    public static final int LINE=38;
    public static final int PLOT=31;
    public static final int WS=73;
    public static final int GNUPLOT=53;
    public static final int CS=17;
    public static final int COORDINATES=22;
    public static final int CIRCLE=33;
    public static final int MOVETO=50;
    public static final int FUNC=7;
    public static final int BLOCK=62;
    public static final int KEYWORDS=71;
    public static final int FOREACH=16;
    public static final int VHLINE=12;
    public static final int PD=69;
    public static final int OPERATION=41;
    public static final int END=6;
    public static final int T__76=76;
    public static final int FROM=26;
    public static final int PE=70;
    public static final int BLOCKS=63;
    public static final int T__75=75;
    public static final int MACRO=55;
    public static final int T__74=74;
    public static final int OPTIONS=67;
    public static final int T__79=79;
    public static final int STRING=10;
    public static final int T__78=78;
    public static final int PC=68;
    public static final int BACKSLASH=4;
    public static final int T__77=77;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "synpred138_TikzGrammar", "t_ellipse", "synpred101_TikzGrammar", 
        "synpred21_TikzGrammar", "synpred43_TikzGrammar", "synpred38_TikzGrammar", 
        "synpred94_TikzGrammar", "synpred56_TikzGrammar", "t_block", "synpred88_TikzGrammar", 
        "synpred137_TikzGrammar", "synpred89_TikzGrammar", "synpred4_TikzGrammar", 
        "synpred112_TikzGrammar", "synpred20_TikzGrammar", "synpred10_TikzGrammar", 
        "t_child", "synpred120_TikzGrammar", "synpred70_TikzGrammar", "synpred50_TikzGrammar", 
        "synpred142_TikzGrammar", "synpred85_TikzGrammar", "synpred117_TikzGrammar", 
        "synpred6_TikzGrammar", "synpred31_TikzGrammar", "synpred36_TikzGrammar", 
        "synpred45_TikzGrammar", "t_cycle", "t_edge", "synpred61_TikzGrammar", 
        "synpred9_TikzGrammar", "synpred51_TikzGrammar", "synpred15_TikzGrammar", 
        "synpred81_TikzGrammar", "synpred103_TikzGrammar", "synpred141_TikzGrammar", 
        "synpred67_TikzGrammar", "string", "t_coordinate", "t_lineto_vh", 
        "synpred58_TikzGrammar", "synpred121_TikzGrammar", "synpred125_TikzGrammar", 
        "synpred65_TikzGrammar", "t_arc", "synpred66_TikzGrammar", "curly_brackets", 
        "t_plot", "synpred123_TikzGrammar", "synpred7_TikzGrammar", "synpred17_TikzGrammar", 
        "t_circle", "t_againpath", "synpred30_TikzGrammar", "t_gird", "synpred99_TikzGrammar", 
        "synpred84_TikzGrammar", "synpred126_TikzGrammar", "synpred78_TikzGrammar", 
        "t_to_path", "synpred92_TikzGrammar", "synpred27_TikzGrammar", "synpred130_TikzGrammar", 
        "synpred14_TikzGrammar", "synpred42_TikzGrammar", "synpred77_TikzGrammar", 
        "t_options", "t_lineto", "synpred24_TikzGrammar", "synpred32_TikzGrammar", 
        "synpred72_TikzGrammar", "synpred41_TikzGrammar", "synpred63_TikzGrammar", 
        "synpred68_TikzGrammar", "synpred71_TikzGrammar", "synpred79_TikzGrammar", 
        "t_lineto_hv", "synpred57_TikzGrammar", "synpred1_TikzGrammar", 
        "synpred124_TikzGrammar", "synpred111_TikzGrammar", "synpred37_TikzGrammar", 
        "synpred128_TikzGrammar", "synpred19_TikzGrammar", "synpred113_TikzGrammar", 
        "synpred26_TikzGrammar", "synpred29_TikzGrammar", "synpred35_TikzGrammar", 
        "synpred127_TikzGrammar", "synpred47_TikzGrammar", "synpred140_TikzGrammar", 
        "synpred95_TikzGrammar", "t_list", "square_brackets", "synpred82_TikzGrammar", 
        "synpred13_TikzGrammar", "t_foreach", "synpred48_TikzGrammar", "synpred34_TikzGrammar", 
        "synpred55_TikzGrammar", "t_macro", "synpred52_TikzGrammar", "synpred134_TikzGrammar", 
        "t_file", "synpred97_TikzGrammar", "multioperator", "synpred25_TikzGrammar", 
        "synpred80_TikzGrammar", "t_parabola", "synpred46_TikzGrammar", 
        "synpred64_TikzGrammar", "synpred109_TikzGrammar", "synpred129_TikzGrammar", 
        "t_rectangle", "synpred115_TikzGrammar", "synpred122_TikzGrammar", 
        "synpred135_TikzGrammar", "synpred98_TikzGrammar", "synpred62_TikzGrammar", 
        "synpred107_TikzGrammar", "function", "synpred74_TikzGrammar", "synpred86_TikzGrammar", 
        "synpred11_TikzGrammar", "synpred96_TikzGrammar", "synpred102_TikzGrammar", 
        "synpred8_TikzGrammar", "t_moveto", "synpred114_TikzGrammar", "synpred22_TikzGrammar", 
        "synpred5_TikzGrammar", "synpred69_TikzGrammar", "t_grid", "synpred76_TikzGrammar", 
        "synpred60_TikzGrammar", "synpred16_TikzGrammar", "synpred132_TikzGrammar", 
        "synpred131_TikzGrammar", "synpred39_TikzGrammar", "synpred133_TikzGrammar", 
        "synpred105_TikzGrammar", "synpred87_TikzGrammar", "synpred54_TikzGrammar", 
        "synpred93_TikzGrammar", "t_main_structures", "synpred40_TikzGrammar", 
        "synpred100_TikzGrammar", "synpred83_TikzGrammar", "synpred119_TikzGrammar", 
        "synpred2_TikzGrammar", "synpred28_TikzGrammar", "synpred110_TikzGrammar", 
        "t_list_elem", "synpred33_TikzGrammar", "synpred104_TikzGrammar", 
        "synpred23_TikzGrammar", "synpred59_TikzGrammar", "synpred116_TikzGrammar", 
        "synpred106_TikzGrammar", "synpred44_TikzGrammar", "synpred108_TikzGrammar", 
        "synpred75_TikzGrammar", "synpred136_TikzGrammar", "synpred91_TikzGrammar", 
        "synpred118_TikzGrammar", "synpred73_TikzGrammar", "synpred90_TikzGrammar", 
        "t_curve", "t_node", "synpred139_TikzGrammar", "synpred12_TikzGrammar", 
        "synpred18_TikzGrammar", "synpred49_TikzGrammar", "synpred53_TikzGrammar", 
        "synpred3_TikzGrammar"
    };
     
        public int ruleLevel = 0;
        public int getRuleLevel() { return ruleLevel; }
        public void incRuleLevel() { ruleLevel++; }
        public void decRuleLevel() { ruleLevel--; }
        public TikzGrammarParser(TokenStream input) {
            this(input, DebugEventSocketProxy.DEFAULT_DEBUGGER_PORT, new RecognizerSharedState());
        }
        public TikzGrammarParser(TokenStream input, int port, RecognizerSharedState state) {
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
    public TikzGrammarParser(TokenStream input, DebugEventListener dbg) {
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


    public String[] getTokenNames() { return TikzGrammarParser.tokenNames; }
    public String getGrammarFileName() { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g"; }


    public static class t_file_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_file"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:9:1: t_file : ( t_main_structures )* -> ^( FILE ( t_main_structures )* ) ;
    public final TikzGrammarParser.t_file_return t_file() throws RecognitionException {
        TikzGrammarParser.t_file_return retval = new TikzGrammarParser.t_file_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        TikzGrammarParser.t_main_structures_return t_main_structures1 = null;


        RewriteRuleSubtreeStream stream_t_main_structures=new RewriteRuleSubtreeStream(adaptor,"rule t_main_structures");
        try { dbg.enterRule(getGrammarFileName(), "t_file");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(9, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:9:9: ( ( t_main_structures )* -> ^( FILE ( t_main_structures )* ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:9:17: ( t_main_structures )*
            {
            dbg.location(9,17);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:9:17: ( t_main_structures )*
            try { dbg.enterSubRule(1);

            loop1:
            do {
                int alt1=2;
                try { dbg.enterDecision(1);

                int LA1_0 = input.LA(1);

                if ( ((LA1_0>=BACKSLASH && LA1_0<=LINE)||LA1_0==74||LA1_0==77||LA1_0==79||(LA1_0>=81 && LA1_0<=82)) ) {
                    alt1=1;
                }


                } finally {dbg.exitDecision(1);}

                switch (alt1) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_main_structures
            	    {
            	    dbg.location(9,17);
            	    pushFollow(FOLLOW_t_main_structures_in_t_file52);
            	    t_main_structures1=t_main_structures();

            	    state._fsp--;
            	    if (state.failed) return retval;
            	    if ( state.backtracking==0 ) stream_t_main_structures.add(t_main_structures1.getTree());

            	    }
            	    break;

            	default :
            	    break loop1;
                }
            } while (true);
            } finally {dbg.exitSubRule(1);}



            // AST REWRITE
            // elements: t_main_structures
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 9:36: -> ^( FILE ( t_main_structures )* )
            {
                dbg.location(9,40);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:9:40: ^( FILE ( t_main_structures )* )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(9,43);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(FILE, "FILE"), root_1);

                dbg.location(9,48);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:9:48: ( t_main_structures )*
                while ( stream_t_main_structures.hasNext() ) {
                    dbg.location(9,48);
                    adaptor.addChild(root_1, stream_t_main_structures.nextTree());

                }
                stream_t_main_structures.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(10, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_file");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_file"

    public static class t_main_structures_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_main_structures"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:12:1: t_main_structures : ( function | square_brackets | curly_brackets | t_block | t_list | t_macro ) -> ( function )* ( square_brackets )* ( curly_brackets )* ( t_block )* ( t_list )* ( t_macro )* ;
    public final TikzGrammarParser.t_main_structures_return t_main_structures() throws RecognitionException {
        TikzGrammarParser.t_main_structures_return retval = new TikzGrammarParser.t_main_structures_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        TikzGrammarParser.function_return function2 = null;

        TikzGrammarParser.square_brackets_return square_brackets3 = null;

        TikzGrammarParser.curly_brackets_return curly_brackets4 = null;

        TikzGrammarParser.t_block_return t_block5 = null;

        TikzGrammarParser.t_list_return t_list6 = null;

        TikzGrammarParser.t_macro_return t_macro7 = null;


        RewriteRuleSubtreeStream stream_curly_brackets=new RewriteRuleSubtreeStream(adaptor,"rule curly_brackets");
        RewriteRuleSubtreeStream stream_square_brackets=new RewriteRuleSubtreeStream(adaptor,"rule square_brackets");
        RewriteRuleSubtreeStream stream_t_block=new RewriteRuleSubtreeStream(adaptor,"rule t_block");
        RewriteRuleSubtreeStream stream_t_list=new RewriteRuleSubtreeStream(adaptor,"rule t_list");
        RewriteRuleSubtreeStream stream_t_macro=new RewriteRuleSubtreeStream(adaptor,"rule t_macro");
        RewriteRuleSubtreeStream stream_function=new RewriteRuleSubtreeStream(adaptor,"rule function");
        try { dbg.enterRule(getGrammarFileName(), "t_main_structures");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(12, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:9: ( ( function | square_brackets | curly_brackets | t_block | t_list | t_macro ) -> ( function )* ( square_brackets )* ( curly_brackets )* ( t_block )* ( t_list )* ( t_macro )* )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:17: ( function | square_brackets | curly_brackets | t_block | t_list | t_macro )
            {
            dbg.location(13,17);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:17: ( function | square_brackets | curly_brackets | t_block | t_list | t_macro )
            int alt2=6;
            try { dbg.enterSubRule(2);
            try { dbg.enterDecision(2);

            try {
                isCyclicDecision = true;
                alt2 = dfa2.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(2);}

            switch (alt2) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:18: function
                    {
                    dbg.location(13,18);
                    pushFollow(FOLLOW_function_in_t_main_structures97);
                    function2=function();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_function.add(function2.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:29: square_brackets
                    {
                    dbg.location(13,29);
                    pushFollow(FOLLOW_square_brackets_in_t_main_structures101);
                    square_brackets3=square_brackets();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_square_brackets.add(square_brackets3.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:47: curly_brackets
                    {
                    dbg.location(13,47);
                    pushFollow(FOLLOW_curly_brackets_in_t_main_structures105);
                    curly_brackets4=curly_brackets();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_curly_brackets.add(curly_brackets4.getTree());

                    }
                    break;
                case 4 :
                    dbg.enterAlt(4);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:64: t_block
                    {
                    dbg.location(13,64);
                    pushFollow(FOLLOW_t_block_in_t_main_structures109);
                    t_block5=t_block();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_block.add(t_block5.getTree());

                    }
                    break;
                case 5 :
                    dbg.enterAlt(5);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:74: t_list
                    {
                    dbg.location(13,74);
                    pushFollow(FOLLOW_t_list_in_t_main_structures113);
                    t_list6=t_list();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_list.add(t_list6.getTree());

                    }
                    break;
                case 6 :
                    dbg.enterAlt(6);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:83: t_macro
                    {
                    dbg.location(13,83);
                    pushFollow(FOLLOW_t_macro_in_t_main_structures117);
                    t_macro7=t_macro();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_macro.add(t_macro7.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(2);}



            // AST REWRITE
            // elements: t_macro, square_brackets, t_list, function, curly_brackets, t_block
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 14:9: -> ( function )* ( square_brackets )* ( curly_brackets )* ( t_block )* ( t_list )* ( t_macro )*
            {
                dbg.location(14,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:14:17: ( function )*
                while ( stream_function.hasNext() ) {
                    dbg.location(14,17);
                    adaptor.addChild(root_0, stream_function.nextTree());

                }
                stream_function.reset();
                dbg.location(14,27);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:14:27: ( square_brackets )*
                while ( stream_square_brackets.hasNext() ) {
                    dbg.location(14,27);
                    adaptor.addChild(root_0, stream_square_brackets.nextTree());

                }
                stream_square_brackets.reset();
                dbg.location(14,44);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:14:44: ( curly_brackets )*
                while ( stream_curly_brackets.hasNext() ) {
                    dbg.location(14,44);
                    adaptor.addChild(root_0, stream_curly_brackets.nextTree());

                }
                stream_curly_brackets.reset();
                dbg.location(14,60);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:14:60: ( t_block )*
                while ( stream_t_block.hasNext() ) {
                    dbg.location(14,60);
                    adaptor.addChild(root_0, stream_t_block.nextTree());

                }
                stream_t_block.reset();
                dbg.location(14,69);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:14:69: ( t_list )*
                while ( stream_t_list.hasNext() ) {
                    dbg.location(14,69);
                    adaptor.addChild(root_0, stream_t_list.nextTree());

                }
                stream_t_list.reset();
                dbg.location(14,77);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:14:77: ( t_macro )*
                while ( stream_t_macro.hasNext() ) {
                    dbg.location(14,77);
                    adaptor.addChild(root_0, stream_t_macro.nextTree());

                }
                stream_t_macro.reset();

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(15, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_main_structures");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_main_structures"

    public static class t_block_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_block"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:18:1: t_block : BACKSLASH BEGIN '{' block_name+= string '}' ( '{' block_name+= string '}' )? ( t_main_structures )* BACKSLASH END '{' string '}' -> ^( BLOCK ( ^( NAME $block_name) )* ( t_main_structures )* ) ;
    public final TikzGrammarParser.t_block_return t_block() throws RecognitionException {
        TikzGrammarParser.t_block_return retval = new TikzGrammarParser.t_block_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token BACKSLASH8=null;
        Token BEGIN9=null;
        Token char_literal10=null;
        Token char_literal11=null;
        Token char_literal12=null;
        Token char_literal13=null;
        Token BACKSLASH15=null;
        Token END16=null;
        Token char_literal17=null;
        Token char_literal19=null;
        List list_block_name=null;
        TikzGrammarParser.t_main_structures_return t_main_structures14 = null;

        TikzGrammarParser.string_return string18 = null;

        RuleReturnScope block_name = null;
        CommonTree BACKSLASH8_tree=null;
        CommonTree BEGIN9_tree=null;
        CommonTree char_literal10_tree=null;
        CommonTree char_literal11_tree=null;
        CommonTree char_literal12_tree=null;
        CommonTree char_literal13_tree=null;
        CommonTree BACKSLASH15_tree=null;
        CommonTree END16_tree=null;
        CommonTree char_literal17_tree=null;
        CommonTree char_literal19_tree=null;
        RewriteRuleTokenStream stream_END=new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_BEGIN=new RewriteRuleTokenStream(adaptor,"token BEGIN");
        RewriteRuleTokenStream stream_74=new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleTokenStream stream_75=new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleTokenStream stream_BACKSLASH=new RewriteRuleTokenStream(adaptor,"token BACKSLASH");
        RewriteRuleSubtreeStream stream_t_main_structures=new RewriteRuleSubtreeStream(adaptor,"rule t_main_structures");
        RewriteRuleSubtreeStream stream_string=new RewriteRuleSubtreeStream(adaptor,"rule string");
        try { dbg.enterRule(getGrammarFileName(), "t_block");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(18, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:18:9: ( BACKSLASH BEGIN '{' block_name+= string '}' ( '{' block_name+= string '}' )? ( t_main_structures )* BACKSLASH END '{' string '}' -> ^( BLOCK ( ^( NAME $block_name) )* ( t_main_structures )* ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:18:17: BACKSLASH BEGIN '{' block_name+= string '}' ( '{' block_name+= string '}' )? ( t_main_structures )* BACKSLASH END '{' string '}'
            {
            dbg.location(18,17);
            BACKSLASH8=(Token)match(input,BACKSLASH,FOLLOW_BACKSLASH_in_t_block191); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_BACKSLASH.add(BACKSLASH8);

            dbg.location(18,27);
            BEGIN9=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_t_block193); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_BEGIN.add(BEGIN9);

            dbg.location(18,33);
            char_literal10=(Token)match(input,74,FOLLOW_74_in_t_block195); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_74.add(char_literal10);

            dbg.location(18,47);
            pushFollow(FOLLOW_string_in_t_block199);
            block_name=string();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_string.add(block_name.getTree());
            if (list_block_name==null) list_block_name=new ArrayList();
            list_block_name.add(block_name.getTree());

            dbg.location(18,56);
            char_literal11=(Token)match(input,75,FOLLOW_75_in_t_block201); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_75.add(char_literal11);

            dbg.location(18,60);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:18:60: ( '{' block_name+= string '}' )?
            int alt3=2;
            try { dbg.enterSubRule(3);
            try { dbg.enterDecision(3);

            try {
                isCyclicDecision = true;
                alt3 = dfa3.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(3);}

            switch (alt3) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:18:62: '{' block_name+= string '}'
                    {
                    dbg.location(18,62);
                    char_literal12=(Token)match(input,74,FOLLOW_74_in_t_block205); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_74.add(char_literal12);

                    dbg.location(18,76);
                    pushFollow(FOLLOW_string_in_t_block209);
                    block_name=string();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_string.add(block_name.getTree());
                    if (list_block_name==null) list_block_name=new ArrayList();
                    list_block_name.add(block_name.getTree());

                    dbg.location(18,85);
                    char_literal13=(Token)match(input,75,FOLLOW_75_in_t_block211); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_75.add(char_literal13);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(3);}

            dbg.location(18,92);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:18:92: ( t_main_structures )*
            try { dbg.enterSubRule(4);

            loop4:
            do {
                int alt4=2;
                try { dbg.enterDecision(4);

                try {
                    isCyclicDecision = true;
                    alt4 = dfa4.predict(input);
                }
                catch (NoViableAltException nvae) {
                    dbg.recognitionException(nvae);
                    throw nvae;
                }
                } finally {dbg.exitDecision(4);}

                switch (alt4) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_main_structures
            	    {
            	    dbg.location(18,92);
            	    pushFollow(FOLLOW_t_main_structures_in_t_block216);
            	    t_main_structures14=t_main_structures();

            	    state._fsp--;
            	    if (state.failed) return retval;
            	    if ( state.backtracking==0 ) stream_t_main_structures.add(t_main_structures14.getTree());

            	    }
            	    break;

            	default :
            	    break loop4;
                }
            } while (true);
            } finally {dbg.exitSubRule(4);}

            dbg.location(18,111);
            BACKSLASH15=(Token)match(input,BACKSLASH,FOLLOW_BACKSLASH_in_t_block219); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_BACKSLASH.add(BACKSLASH15);

            dbg.location(18,121);
            END16=(Token)match(input,END,FOLLOW_END_in_t_block221); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_END.add(END16);

            dbg.location(18,125);
            char_literal17=(Token)match(input,74,FOLLOW_74_in_t_block223); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_74.add(char_literal17);

            dbg.location(18,129);
            pushFollow(FOLLOW_string_in_t_block225);
            string18=string();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_string.add(string18.getTree());
            dbg.location(18,136);
            char_literal19=(Token)match(input,75,FOLLOW_75_in_t_block227); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_75.add(char_literal19);



            // AST REWRITE
            // elements: block_name, t_main_structures
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: block_name
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);
            RewriteRuleSubtreeStream stream_block_name=new RewriteRuleSubtreeStream(adaptor,"token block_name",list_block_name);
            root_0 = (CommonTree)adaptor.nil();
            // 19:9: -> ^( BLOCK ( ^( NAME $block_name) )* ( t_main_structures )* )
            {
                dbg.location(19,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:19:17: ^( BLOCK ( ^( NAME $block_name) )* ( t_main_structures )* )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(19,20);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(BLOCK, "BLOCK"), root_1);

                dbg.location(19,26);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:19:26: ( ^( NAME $block_name) )*
                while ( stream_block_name.hasNext() ) {
                    dbg.location(19,26);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:19:26: ^( NAME $block_name)
                    {
                    CommonTree root_2 = (CommonTree)adaptor.nil();
                    dbg.location(19,29);
                    root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(NAME, "NAME"), root_2);

                    dbg.location(19,34);
                    adaptor.addChild(root_2, stream_block_name.nextTree());

                    adaptor.addChild(root_1, root_2);
                    }

                }
                stream_block_name.reset();
                dbg.location(19,49);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:19:49: ( t_main_structures )*
                while ( stream_t_main_structures.hasNext() ) {
                    dbg.location(19,49);
                    adaptor.addChild(root_1, stream_t_main_structures.nextTree());

                }
                stream_t_main_structures.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(20, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_block");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_block"

    public static class t_macro_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_macro"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:22:1: t_macro : BACKSLASH ( t_foreach -> t_foreach | t_node -> t_node | t_coordinate -> t_coordinate | (macro_name= string ( t_macro )? ( t_options | t_lineto | t_moveto | t_lineto_hv | t_lineto_vh | t_cycle | t_curve | t_rectangle | t_gird | t_parabola | t_plot | t_edge | t_to_path | t_to_path | t_foreach | t_edge | add_blocks+= curly_brackets | add_blocks+= t_block | t_circle | t_ellipse | t_arc | str+= string | t_foreach | t_node | t_coordinate )* ) -> ^( MACRO ^( NAME $macro_name) ( t_macro )? ( t_options )* ( t_moveto )* ( t_lineto )* ( t_lineto_hv )* ( t_lineto_vh )* ( t_cycle )* ( t_to_path )* ( t_foreach )* ( t_edge )* ( t_curve )* ( t_rectangle )* ( t_gird )* ( t_plot )* ( t_circle )* ( t_ellipse )* ( t_parabola )* ( t_arc )* ( $add_blocks)* ( $str)* ( t_foreach )* ( t_node )* ( t_coordinate )* ) ) ( ';' )? ;
    public final TikzGrammarParser.t_macro_return t_macro() throws RecognitionException {
        TikzGrammarParser.t_macro_return retval = new TikzGrammarParser.t_macro_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token BACKSLASH20=null;
        Token char_literal47=null;
        List list_add_blocks=null;
        List list_str=null;
        TikzGrammarParser.string_return macro_name = null;

        TikzGrammarParser.t_foreach_return t_foreach21 = null;

        TikzGrammarParser.t_node_return t_node22 = null;

        TikzGrammarParser.t_coordinate_return t_coordinate23 = null;

        TikzGrammarParser.t_macro_return t_macro24 = null;

        TikzGrammarParser.t_options_return t_options25 = null;

        TikzGrammarParser.t_lineto_return t_lineto26 = null;

        TikzGrammarParser.t_moveto_return t_moveto27 = null;

        TikzGrammarParser.t_lineto_hv_return t_lineto_hv28 = null;

        TikzGrammarParser.t_lineto_vh_return t_lineto_vh29 = null;

        TikzGrammarParser.t_cycle_return t_cycle30 = null;

        TikzGrammarParser.t_curve_return t_curve31 = null;

        TikzGrammarParser.t_rectangle_return t_rectangle32 = null;

        TikzGrammarParser.t_gird_return t_gird33 = null;

        TikzGrammarParser.t_parabola_return t_parabola34 = null;

        TikzGrammarParser.t_plot_return t_plot35 = null;

        TikzGrammarParser.t_edge_return t_edge36 = null;

        TikzGrammarParser.t_to_path_return t_to_path37 = null;

        TikzGrammarParser.t_to_path_return t_to_path38 = null;

        TikzGrammarParser.t_foreach_return t_foreach39 = null;

        TikzGrammarParser.t_edge_return t_edge40 = null;

        TikzGrammarParser.t_circle_return t_circle41 = null;

        TikzGrammarParser.t_ellipse_return t_ellipse42 = null;

        TikzGrammarParser.t_arc_return t_arc43 = null;

        TikzGrammarParser.t_foreach_return t_foreach44 = null;

        TikzGrammarParser.t_node_return t_node45 = null;

        TikzGrammarParser.t_coordinate_return t_coordinate46 = null;

        RuleReturnScope add_blocks = null;
        RuleReturnScope str = null;
        CommonTree BACKSLASH20_tree=null;
        CommonTree char_literal47_tree=null;
        RewriteRuleTokenStream stream_BACKSLASH=new RewriteRuleTokenStream(adaptor,"token BACKSLASH");
        RewriteRuleTokenStream stream_76=new RewriteRuleTokenStream(adaptor,"token 76");
        RewriteRuleSubtreeStream stream_t_lineto_hv=new RewriteRuleSubtreeStream(adaptor,"rule t_lineto_hv");
        RewriteRuleSubtreeStream stream_t_parabola=new RewriteRuleSubtreeStream(adaptor,"rule t_parabola");
        RewriteRuleSubtreeStream stream_t_moveto=new RewriteRuleSubtreeStream(adaptor,"rule t_moveto");
        RewriteRuleSubtreeStream stream_t_arc=new RewriteRuleSubtreeStream(adaptor,"rule t_arc");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        RewriteRuleSubtreeStream stream_t_cycle=new RewriteRuleSubtreeStream(adaptor,"rule t_cycle");
        RewriteRuleSubtreeStream stream_t_lineto=new RewriteRuleSubtreeStream(adaptor,"rule t_lineto");
        RewriteRuleSubtreeStream stream_t_macro=new RewriteRuleSubtreeStream(adaptor,"rule t_macro");
        RewriteRuleSubtreeStream stream_t_edge=new RewriteRuleSubtreeStream(adaptor,"rule t_edge");
        RewriteRuleSubtreeStream stream_t_foreach=new RewriteRuleSubtreeStream(adaptor,"rule t_foreach");
        RewriteRuleSubtreeStream stream_t_ellipse=new RewriteRuleSubtreeStream(adaptor,"rule t_ellipse");
        RewriteRuleSubtreeStream stream_t_options=new RewriteRuleSubtreeStream(adaptor,"rule t_options");
        RewriteRuleSubtreeStream stream_curly_brackets=new RewriteRuleSubtreeStream(adaptor,"rule curly_brackets");
        RewriteRuleSubtreeStream stream_t_rectangle=new RewriteRuleSubtreeStream(adaptor,"rule t_rectangle");
        RewriteRuleSubtreeStream stream_t_lineto_vh=new RewriteRuleSubtreeStream(adaptor,"rule t_lineto_vh");
        RewriteRuleSubtreeStream stream_t_block=new RewriteRuleSubtreeStream(adaptor,"rule t_block");
        RewriteRuleSubtreeStream stream_t_curve=new RewriteRuleSubtreeStream(adaptor,"rule t_curve");
        RewriteRuleSubtreeStream stream_t_plot=new RewriteRuleSubtreeStream(adaptor,"rule t_plot");
        RewriteRuleSubtreeStream stream_string=new RewriteRuleSubtreeStream(adaptor,"rule string");
        RewriteRuleSubtreeStream stream_t_circle=new RewriteRuleSubtreeStream(adaptor,"rule t_circle");
        RewriteRuleSubtreeStream stream_t_gird=new RewriteRuleSubtreeStream(adaptor,"rule t_gird");
        RewriteRuleSubtreeStream stream_t_node=new RewriteRuleSubtreeStream(adaptor,"rule t_node");
        RewriteRuleSubtreeStream stream_t_to_path=new RewriteRuleSubtreeStream(adaptor,"rule t_to_path");
        try { dbg.enterRule(getGrammarFileName(), "t_macro");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(22, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:22:9: ( BACKSLASH ( t_foreach -> t_foreach | t_node -> t_node | t_coordinate -> t_coordinate | (macro_name= string ( t_macro )? ( t_options | t_lineto | t_moveto | t_lineto_hv | t_lineto_vh | t_cycle | t_curve | t_rectangle | t_gird | t_parabola | t_plot | t_edge | t_to_path | t_to_path | t_foreach | t_edge | add_blocks+= curly_brackets | add_blocks+= t_block | t_circle | t_ellipse | t_arc | str+= string | t_foreach | t_node | t_coordinate )* ) -> ^( MACRO ^( NAME $macro_name) ( t_macro )? ( t_options )* ( t_moveto )* ( t_lineto )* ( t_lineto_hv )* ( t_lineto_vh )* ( t_cycle )* ( t_to_path )* ( t_foreach )* ( t_edge )* ( t_curve )* ( t_rectangle )* ( t_gird )* ( t_plot )* ( t_circle )* ( t_ellipse )* ( t_parabola )* ( t_arc )* ( $add_blocks)* ( $str)* ( t_foreach )* ( t_node )* ( t_coordinate )* ) ) ( ';' )? )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:22:17: BACKSLASH ( t_foreach -> t_foreach | t_node -> t_node | t_coordinate -> t_coordinate | (macro_name= string ( t_macro )? ( t_options | t_lineto | t_moveto | t_lineto_hv | t_lineto_vh | t_cycle | t_curve | t_rectangle | t_gird | t_parabola | t_plot | t_edge | t_to_path | t_to_path | t_foreach | t_edge | add_blocks+= curly_brackets | add_blocks+= t_block | t_circle | t_ellipse | t_arc | str+= string | t_foreach | t_node | t_coordinate )* ) -> ^( MACRO ^( NAME $macro_name) ( t_macro )? ( t_options )* ( t_moveto )* ( t_lineto )* ( t_lineto_hv )* ( t_lineto_vh )* ( t_cycle )* ( t_to_path )* ( t_foreach )* ( t_edge )* ( t_curve )* ( t_rectangle )* ( t_gird )* ( t_plot )* ( t_circle )* ( t_ellipse )* ( t_parabola )* ( t_arc )* ( $add_blocks)* ( $str)* ( t_foreach )* ( t_node )* ( t_coordinate )* ) ) ( ';' )?
            {
            dbg.location(22,17);
            BACKSLASH20=(Token)match(input,BACKSLASH,FOLLOW_BACKSLASH_in_t_macro285); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_BACKSLASH.add(BACKSLASH20);

            dbg.location(23,25);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:23:25: ( t_foreach -> t_foreach | t_node -> t_node | t_coordinate -> t_coordinate | (macro_name= string ( t_macro )? ( t_options | t_lineto | t_moveto | t_lineto_hv | t_lineto_vh | t_cycle | t_curve | t_rectangle | t_gird | t_parabola | t_plot | t_edge | t_to_path | t_to_path | t_foreach | t_edge | add_blocks+= curly_brackets | add_blocks+= t_block | t_circle | t_ellipse | t_arc | str+= string | t_foreach | t_node | t_coordinate )* ) -> ^( MACRO ^( NAME $macro_name) ( t_macro )? ( t_options )* ( t_moveto )* ( t_lineto )* ( t_lineto_hv )* ( t_lineto_vh )* ( t_cycle )* ( t_to_path )* ( t_foreach )* ( t_edge )* ( t_curve )* ( t_rectangle )* ( t_gird )* ( t_plot )* ( t_circle )* ( t_ellipse )* ( t_parabola )* ( t_arc )* ( $add_blocks)* ( $str)* ( t_foreach )* ( t_node )* ( t_coordinate )* ) )
            int alt7=4;
            try { dbg.enterSubRule(7);
            try { dbg.enterDecision(7);

            try {
                isCyclicDecision = true;
                alt7 = dfa7.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(7);}

            switch (alt7) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:23:27: t_foreach
                    {
                    dbg.location(23,27);
                    pushFollow(FOLLOW_t_foreach_in_t_macro314);
                    t_foreach21=t_foreach();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_foreach.add(t_foreach21.getTree());


                    // AST REWRITE
                    // elements: t_foreach
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 24:9: -> t_foreach
                    {
                        dbg.location(24,25);
                        adaptor.addChild(root_0, stream_t_foreach.nextTree());

                    }

                    retval.tree = root_0;}
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:26:27: t_node
                    {
                    dbg.location(26,27);
                    pushFollow(FOLLOW_t_node_in_t_macro376);
                    t_node22=t_node();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_node.add(t_node22.getTree());


                    // AST REWRITE
                    // elements: t_node
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 27:9: -> t_node
                    {
                        dbg.location(27,25);
                        adaptor.addChild(root_0, stream_t_node.nextTree());

                    }

                    retval.tree = root_0;}
                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:29:27: t_coordinate
                    {
                    dbg.location(29,27);
                    pushFollow(FOLLOW_t_coordinate_in_t_macro438);
                    t_coordinate23=t_coordinate();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate23.getTree());


                    // AST REWRITE
                    // elements: t_coordinate
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 30:9: -> t_coordinate
                    {
                        dbg.location(30,25);
                        adaptor.addChild(root_0, stream_t_coordinate.nextTree());

                    }

                    retval.tree = root_0;}
                    }
                    break;
                case 4 :
                    dbg.enterAlt(4);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:32:26: (macro_name= string ( t_macro )? ( t_options | t_lineto | t_moveto | t_lineto_hv | t_lineto_vh | t_cycle | t_curve | t_rectangle | t_gird | t_parabola | t_plot | t_edge | t_to_path | t_to_path | t_foreach | t_edge | add_blocks+= curly_brackets | add_blocks+= t_block | t_circle | t_ellipse | t_arc | str+= string | t_foreach | t_node | t_coordinate )* )
                    {
                    dbg.location(32,26);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:32:26: (macro_name= string ( t_macro )? ( t_options | t_lineto | t_moveto | t_lineto_hv | t_lineto_vh | t_cycle | t_curve | t_rectangle | t_gird | t_parabola | t_plot | t_edge | t_to_path | t_to_path | t_foreach | t_edge | add_blocks+= curly_brackets | add_blocks+= t_block | t_circle | t_ellipse | t_arc | str+= string | t_foreach | t_node | t_coordinate )* )
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:32:28: macro_name= string ( t_macro )? ( t_options | t_lineto | t_moveto | t_lineto_hv | t_lineto_vh | t_cycle | t_curve | t_rectangle | t_gird | t_parabola | t_plot | t_edge | t_to_path | t_to_path | t_foreach | t_edge | add_blocks+= curly_brackets | add_blocks+= t_block | t_circle | t_ellipse | t_arc | str+= string | t_foreach | t_node | t_coordinate )*
                    {
                    dbg.location(32,38);
                    pushFollow(FOLLOW_string_in_t_macro519);
                    macro_name=string();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_string.add(macro_name.getTree());
                    dbg.location(32,46);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:32:46: ( t_macro )?
                    int alt5=2;
                    try { dbg.enterSubRule(5);
                    try { dbg.enterDecision(5);

                    try {
                        isCyclicDecision = true;
                        alt5 = dfa5.predict(input);
                    }
                    catch (NoViableAltException nvae) {
                        dbg.recognitionException(nvae);
                        throw nvae;
                    }
                    } finally {dbg.exitDecision(5);}

                    switch (alt5) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_macro
                            {
                            dbg.location(32,46);
                            pushFollow(FOLLOW_t_macro_in_t_macro521);
                            t_macro24=t_macro();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_macro.add(t_macro24.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(5);}

                    dbg.location(33,25);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:25: ( t_options | t_lineto | t_moveto | t_lineto_hv | t_lineto_vh | t_cycle | t_curve | t_rectangle | t_gird | t_parabola | t_plot | t_edge | t_to_path | t_to_path | t_foreach | t_edge | add_blocks+= curly_brackets | add_blocks+= t_block | t_circle | t_ellipse | t_arc | str+= string | t_foreach | t_node | t_coordinate )*
                    try { dbg.enterSubRule(6);

                    loop6:
                    do {
                        int alt6=26;
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

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:27: t_options
                    	    {
                    	    dbg.location(33,27);
                    	    pushFollow(FOLLOW_t_options_in_t_macro561);
                    	    t_options25=t_options();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_options.add(t_options25.getTree());

                    	    }
                    	    break;
                    	case 2 :
                    	    dbg.enterAlt(2);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:39: t_lineto
                    	    {
                    	    dbg.location(33,39);
                    	    pushFollow(FOLLOW_t_lineto_in_t_macro565);
                    	    t_lineto26=t_lineto();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_lineto.add(t_lineto26.getTree());

                    	    }
                    	    break;
                    	case 3 :
                    	    dbg.enterAlt(3);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:50: t_moveto
                    	    {
                    	    dbg.location(33,50);
                    	    pushFollow(FOLLOW_t_moveto_in_t_macro569);
                    	    t_moveto27=t_moveto();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_moveto.add(t_moveto27.getTree());

                    	    }
                    	    break;
                    	case 4 :
                    	    dbg.enterAlt(4);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:61: t_lineto_hv
                    	    {
                    	    dbg.location(33,61);
                    	    pushFollow(FOLLOW_t_lineto_hv_in_t_macro573);
                    	    t_lineto_hv28=t_lineto_hv();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_lineto_hv.add(t_lineto_hv28.getTree());

                    	    }
                    	    break;
                    	case 5 :
                    	    dbg.enterAlt(5);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:27: t_lineto_vh
                    	    {
                    	    dbg.location(34,27);
                    	    pushFollow(FOLLOW_t_lineto_vh_in_t_macro602);
                    	    t_lineto_vh29=t_lineto_vh();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_lineto_vh.add(t_lineto_vh29.getTree());

                    	    }
                    	    break;
                    	case 6 :
                    	    dbg.enterAlt(6);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:41: t_cycle
                    	    {
                    	    dbg.location(34,41);
                    	    pushFollow(FOLLOW_t_cycle_in_t_macro606);
                    	    t_cycle30=t_cycle();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_cycle.add(t_cycle30.getTree());

                    	    }
                    	    break;
                    	case 7 :
                    	    dbg.enterAlt(7);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:51: t_curve
                    	    {
                    	    dbg.location(34,51);
                    	    pushFollow(FOLLOW_t_curve_in_t_macro610);
                    	    t_curve31=t_curve();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_curve.add(t_curve31.getTree());

                    	    }
                    	    break;
                    	case 8 :
                    	    dbg.enterAlt(8);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:60: t_rectangle
                    	    {
                    	    dbg.location(34,60);
                    	    pushFollow(FOLLOW_t_rectangle_in_t_macro613);
                    	    t_rectangle32=t_rectangle();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_rectangle.add(t_rectangle32.getTree());

                    	    }
                    	    break;
                    	case 9 :
                    	    dbg.enterAlt(9);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:74: t_gird
                    	    {
                    	    dbg.location(34,74);
                    	    pushFollow(FOLLOW_t_gird_in_t_macro617);
                    	    t_gird33=t_gird();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_gird.add(t_gird33.getTree());

                    	    }
                    	    break;
                    	case 10 :
                    	    dbg.enterAlt(10);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:83: t_parabola
                    	    {
                    	    dbg.location(34,83);
                    	    pushFollow(FOLLOW_t_parabola_in_t_macro621);
                    	    t_parabola34=t_parabola();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_parabola.add(t_parabola34.getTree());

                    	    }
                    	    break;
                    	case 11 :
                    	    dbg.enterAlt(11);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:96: t_plot
                    	    {
                    	    dbg.location(34,96);
                    	    pushFollow(FOLLOW_t_plot_in_t_macro625);
                    	    t_plot35=t_plot();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_plot.add(t_plot35.getTree());

                    	    }
                    	    break;
                    	case 12 :
                    	    dbg.enterAlt(12);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:105: t_edge
                    	    {
                    	    dbg.location(34,105);
                    	    pushFollow(FOLLOW_t_edge_in_t_macro629);
                    	    t_edge36=t_edge();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_edge.add(t_edge36.getTree());

                    	    }
                    	    break;
                    	case 13 :
                    	    dbg.enterAlt(13);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:27: t_to_path
                    	    {
                    	    dbg.location(35,27);
                    	    pushFollow(FOLLOW_t_to_path_in_t_macro658);
                    	    t_to_path37=t_to_path();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_to_path.add(t_to_path37.getTree());

                    	    }
                    	    break;
                    	case 14 :
                    	    dbg.enterAlt(14);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:39: t_to_path
                    	    {
                    	    dbg.location(35,39);
                    	    pushFollow(FOLLOW_t_to_path_in_t_macro662);
                    	    t_to_path38=t_to_path();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_to_path.add(t_to_path38.getTree());

                    	    }
                    	    break;
                    	case 15 :
                    	    dbg.enterAlt(15);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:52: t_foreach
                    	    {
                    	    dbg.location(35,52);
                    	    pushFollow(FOLLOW_t_foreach_in_t_macro667);
                    	    t_foreach39=t_foreach();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_foreach.add(t_foreach39.getTree());

                    	    }
                    	    break;
                    	case 16 :
                    	    dbg.enterAlt(16);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:64: t_edge
                    	    {
                    	    dbg.location(35,64);
                    	    pushFollow(FOLLOW_t_edge_in_t_macro671);
                    	    t_edge40=t_edge();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_edge.add(t_edge40.getTree());

                    	    }
                    	    break;
                    	case 17 :
                    	    dbg.enterAlt(17);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:73: add_blocks+= curly_brackets
                    	    {
                    	    dbg.location(35,83);
                    	    pushFollow(FOLLOW_curly_brackets_in_t_macro677);
                    	    add_blocks=curly_brackets();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_curly_brackets.add(add_blocks.getTree());
                    	    if (list_add_blocks==null) list_add_blocks=new ArrayList();
                    	    list_add_blocks.add(add_blocks.getTree());


                    	    }
                    	    break;
                    	case 18 :
                    	    dbg.enterAlt(18);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:101: add_blocks+= t_block
                    	    {
                    	    dbg.location(35,111);
                    	    pushFollow(FOLLOW_t_block_in_t_macro682);
                    	    add_blocks=t_block();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_block.add(add_blocks.getTree());
                    	    if (list_add_blocks==null) list_add_blocks=new ArrayList();
                    	    list_add_blocks.add(add_blocks.getTree());


                    	    }
                    	    break;
                    	case 19 :
                    	    dbg.enterAlt(19);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:27: t_circle
                    	    {
                    	    dbg.location(36,27);
                    	    pushFollow(FOLLOW_t_circle_in_t_macro711);
                    	    t_circle41=t_circle();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_circle.add(t_circle41.getTree());

                    	    }
                    	    break;
                    	case 20 :
                    	    dbg.enterAlt(20);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:38: t_ellipse
                    	    {
                    	    dbg.location(36,38);
                    	    pushFollow(FOLLOW_t_ellipse_in_t_macro715);
                    	    t_ellipse42=t_ellipse();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_ellipse.add(t_ellipse42.getTree());

                    	    }
                    	    break;
                    	case 21 :
                    	    dbg.enterAlt(21);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:50: t_arc
                    	    {
                    	    dbg.location(36,50);
                    	    pushFollow(FOLLOW_t_arc_in_t_macro719);
                    	    t_arc43=t_arc();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_arc.add(t_arc43.getTree());

                    	    }
                    	    break;
                    	case 22 :
                    	    dbg.enterAlt(22);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:57: str+= string
                    	    {
                    	    dbg.location(36,60);
                    	    pushFollow(FOLLOW_string_in_t_macro724);
                    	    str=string();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_string.add(str.getTree());
                    	    if (list_str==null) list_str=new ArrayList();
                    	    list_str.add(str.getTree());


                    	    }
                    	    break;
                    	case 23 :
                    	    dbg.enterAlt(23);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:71: t_foreach
                    	    {
                    	    dbg.location(36,71);
                    	    pushFollow(FOLLOW_t_foreach_in_t_macro728);
                    	    t_foreach44=t_foreach();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_foreach.add(t_foreach44.getTree());

                    	    }
                    	    break;
                    	case 24 :
                    	    dbg.enterAlt(24);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:83: t_node
                    	    {
                    	    dbg.location(36,83);
                    	    pushFollow(FOLLOW_t_node_in_t_macro732);
                    	    t_node45=t_node();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_node.add(t_node45.getTree());

                    	    }
                    	    break;
                    	case 25 :
                    	    dbg.enterAlt(25);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:92: t_coordinate
                    	    {
                    	    dbg.location(36,92);
                    	    pushFollow(FOLLOW_t_coordinate_in_t_macro736);
                    	    t_coordinate46=t_coordinate();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate46.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop6;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(6);}


                    }



                    // AST REWRITE
                    // elements: t_parabola, t_moveto, t_ellipse, t_macro, t_curve, t_rectangle, t_coordinate, t_arc, t_node, t_foreach, str, t_gird, t_lineto_hv, t_foreach, add_blocks, t_to_path, macro_name, t_edge, t_plot, t_lineto_vh, t_cycle, t_circle, t_options, t_lineto
                    // token labels: 
                    // rule labels: retval, macro_name
                    // token list labels: 
                    // rule list labels: str, add_blocks
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);
                    RewriteRuleSubtreeStream stream_macro_name=new RewriteRuleSubtreeStream(adaptor,"rule macro_name",macro_name!=null?macro_name.tree:null);
                    RewriteRuleSubtreeStream stream_str=new RewriteRuleSubtreeStream(adaptor,"token str",list_str);
                    RewriteRuleSubtreeStream stream_add_blocks=new RewriteRuleSubtreeStream(adaptor,"token add_blocks",list_add_blocks);
                    root_0 = (CommonTree)adaptor.nil();
                    // 37:9: -> ^( MACRO ^( NAME $macro_name) ( t_macro )? ( t_options )* ( t_moveto )* ( t_lineto )* ( t_lineto_hv )* ( t_lineto_vh )* ( t_cycle )* ( t_to_path )* ( t_foreach )* ( t_edge )* ( t_curve )* ( t_rectangle )* ( t_gird )* ( t_plot )* ( t_circle )* ( t_ellipse )* ( t_parabola )* ( t_arc )* ( $add_blocks)* ( $str)* ( t_foreach )* ( t_node )* ( t_coordinate )* )
                    {
                        dbg.location(37,25);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:37:25: ^( MACRO ^( NAME $macro_name) ( t_macro )? ( t_options )* ( t_moveto )* ( t_lineto )* ( t_lineto_hv )* ( t_lineto_vh )* ( t_cycle )* ( t_to_path )* ( t_foreach )* ( t_edge )* ( t_curve )* ( t_rectangle )* ( t_gird )* ( t_plot )* ( t_circle )* ( t_ellipse )* ( t_parabola )* ( t_arc )* ( $add_blocks)* ( $str)* ( t_foreach )* ( t_node )* ( t_coordinate )* )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(37,28);
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(MACRO, "MACRO"), root_1);

                        dbg.location(37,34);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:37:34: ^( NAME $macro_name)
                        {
                        CommonTree root_2 = (CommonTree)adaptor.nil();
                        dbg.location(37,37);
                        root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(NAME, "NAME"), root_2);

                        dbg.location(37,42);
                        adaptor.addChild(root_2, stream_macro_name.nextTree());

                        adaptor.addChild(root_1, root_2);
                        }
                        dbg.location(37,56);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:37:56: ( t_macro )?
                        if ( stream_t_macro.hasNext() ) {
                            dbg.location(37,56);
                            adaptor.addChild(root_1, stream_t_macro.nextTree());

                        }
                        stream_t_macro.reset();
                        dbg.location(37,65);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:37:65: ( t_options )*
                        while ( stream_t_options.hasNext() ) {
                            dbg.location(37,65);
                            adaptor.addChild(root_1, stream_t_options.nextTree());

                        }
                        stream_t_options.reset();
                        dbg.location(37,76);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:37:76: ( t_moveto )*
                        while ( stream_t_moveto.hasNext() ) {
                            dbg.location(37,76);
                            adaptor.addChild(root_1, stream_t_moveto.nextTree());

                        }
                        stream_t_moveto.reset();
                        dbg.location(37,86);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:37:86: ( t_lineto )*
                        while ( stream_t_lineto.hasNext() ) {
                            dbg.location(37,86);
                            adaptor.addChild(root_1, stream_t_lineto.nextTree());

                        }
                        stream_t_lineto.reset();
                        dbg.location(38,25);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:38:25: ( t_lineto_hv )*
                        while ( stream_t_lineto_hv.hasNext() ) {
                            dbg.location(38,25);
                            adaptor.addChild(root_1, stream_t_lineto_hv.nextTree());

                        }
                        stream_t_lineto_hv.reset();
                        dbg.location(38,38);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:38:38: ( t_lineto_vh )*
                        while ( stream_t_lineto_vh.hasNext() ) {
                            dbg.location(38,38);
                            adaptor.addChild(root_1, stream_t_lineto_vh.nextTree());

                        }
                        stream_t_lineto_vh.reset();
                        dbg.location(38,51);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:38:51: ( t_cycle )*
                        while ( stream_t_cycle.hasNext() ) {
                            dbg.location(38,51);
                            adaptor.addChild(root_1, stream_t_cycle.nextTree());

                        }
                        stream_t_cycle.reset();
                        dbg.location(38,60);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:38:60: ( t_to_path )*
                        while ( stream_t_to_path.hasNext() ) {
                            dbg.location(38,60);
                            adaptor.addChild(root_1, stream_t_to_path.nextTree());

                        }
                        stream_t_to_path.reset();
                        dbg.location(38,71);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:38:71: ( t_foreach )*
                        while ( stream_t_foreach.hasNext() ) {
                            dbg.location(38,71);
                            adaptor.addChild(root_1, stream_t_foreach.nextTree());

                        }
                        stream_t_foreach.reset();
                        dbg.location(38,82);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:38:82: ( t_edge )*
                        while ( stream_t_edge.hasNext() ) {
                            dbg.location(38,82);
                            adaptor.addChild(root_1, stream_t_edge.nextTree());

                        }
                        stream_t_edge.reset();
                        dbg.location(38,90);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:38:90: ( t_curve )*
                        while ( stream_t_curve.hasNext() ) {
                            dbg.location(38,90);
                            adaptor.addChild(root_1, stream_t_curve.nextTree());

                        }
                        stream_t_curve.reset();
                        dbg.location(38,99);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:38:99: ( t_rectangle )*
                        while ( stream_t_rectangle.hasNext() ) {
                            dbg.location(38,99);
                            adaptor.addChild(root_1, stream_t_rectangle.nextTree());

                        }
                        stream_t_rectangle.reset();
                        dbg.location(39,25);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:39:25: ( t_gird )*
                        while ( stream_t_gird.hasNext() ) {
                            dbg.location(39,25);
                            adaptor.addChild(root_1, stream_t_gird.nextTree());

                        }
                        stream_t_gird.reset();
                        dbg.location(39,33);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:39:33: ( t_plot )*
                        while ( stream_t_plot.hasNext() ) {
                            dbg.location(39,33);
                            adaptor.addChild(root_1, stream_t_plot.nextTree());

                        }
                        stream_t_plot.reset();
                        dbg.location(39,42);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:39:42: ( t_circle )*
                        while ( stream_t_circle.hasNext() ) {
                            dbg.location(39,42);
                            adaptor.addChild(root_1, stream_t_circle.nextTree());

                        }
                        stream_t_circle.reset();
                        dbg.location(39,52);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:39:52: ( t_ellipse )*
                        while ( stream_t_ellipse.hasNext() ) {
                            dbg.location(39,52);
                            adaptor.addChild(root_1, stream_t_ellipse.nextTree());

                        }
                        stream_t_ellipse.reset();
                        dbg.location(39,63);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:39:63: ( t_parabola )*
                        while ( stream_t_parabola.hasNext() ) {
                            dbg.location(39,63);
                            adaptor.addChild(root_1, stream_t_parabola.nextTree());

                        }
                        stream_t_parabola.reset();
                        dbg.location(39,75);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:39:75: ( t_arc )*
                        while ( stream_t_arc.hasNext() ) {
                            dbg.location(39,75);
                            adaptor.addChild(root_1, stream_t_arc.nextTree());

                        }
                        stream_t_arc.reset();
                        dbg.location(39,82);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:39:82: ( $add_blocks)*
                        while ( stream_add_blocks.hasNext() ) {
                            dbg.location(39,82);
                            adaptor.addChild(root_1, stream_add_blocks.nextTree());

                        }
                        stream_add_blocks.reset();
                        dbg.location(39,95);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:39:95: ( $str)*
                        while ( stream_str.hasNext() ) {
                            dbg.location(39,95);
                            adaptor.addChild(root_1, stream_str.nextTree());

                        }
                        stream_str.reset();
                        dbg.location(40,25);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:40:25: ( t_foreach )*
                        while ( stream_t_foreach.hasNext() ) {
                            dbg.location(40,25);
                            adaptor.addChild(root_1, stream_t_foreach.nextTree());

                        }
                        stream_t_foreach.reset();
                        dbg.location(40,36);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:40:36: ( t_node )*
                        while ( stream_t_node.hasNext() ) {
                            dbg.location(40,36);
                            adaptor.addChild(root_1, stream_t_node.nextTree());

                        }
                        stream_t_node.reset();
                        dbg.location(40,44);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:40:44: ( t_coordinate )*
                        while ( stream_t_coordinate.hasNext() ) {
                            dbg.location(40,44);
                            adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                        }
                        stream_t_coordinate.reset();

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;

            }
            } finally {dbg.exitSubRule(7);}

            dbg.location(41,19);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:41:19: ( ';' )?
            int alt8=2;
            try { dbg.enterSubRule(8);
            try { dbg.enterDecision(8);

            int LA8_0 = input.LA(1);

            if ( (LA8_0==76) ) {
                int LA8_1 = input.LA(2);

                if ( (synpred38_TikzGrammar()) ) {
                    alt8=1;
                }
            }
            } finally {dbg.exitDecision(8);}

            switch (alt8) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: ';'
                    {
                    dbg.location(41,19);
                    char_literal47=(Token)match(input,76,FOLLOW_76_in_t_macro961); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_76.add(char_literal47);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(8);}


            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(42, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_macro");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_macro"

    public static class curly_brackets_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "curly_brackets"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:44:1: curly_brackets : '{' ( t_main_structures )* '}' -> ^( BLOCK ( t_main_structures )* ) ;
    public final TikzGrammarParser.curly_brackets_return curly_brackets() throws RecognitionException {
        TikzGrammarParser.curly_brackets_return retval = new TikzGrammarParser.curly_brackets_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token char_literal48=null;
        Token char_literal50=null;
        TikzGrammarParser.t_main_structures_return t_main_structures49 = null;


        CommonTree char_literal48_tree=null;
        CommonTree char_literal50_tree=null;
        RewriteRuleTokenStream stream_74=new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleTokenStream stream_75=new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleSubtreeStream stream_t_main_structures=new RewriteRuleSubtreeStream(adaptor,"rule t_main_structures");
        try { dbg.enterRule(getGrammarFileName(), "curly_brackets");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(44, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:45:9: ( '{' ( t_main_structures )* '}' -> ^( BLOCK ( t_main_structures )* ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:45:17: '{' ( t_main_structures )* '}'
            {
            dbg.location(45,17);
            char_literal48=(Token)match(input,74,FOLLOW_74_in_curly_brackets993); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_74.add(char_literal48);

            dbg.location(45,21);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:45:21: ( t_main_structures )*
            try { dbg.enterSubRule(9);

            loop9:
            do {
                int alt9=2;
                try { dbg.enterDecision(9);

                int LA9_0 = input.LA(1);

                if ( ((LA9_0>=BACKSLASH && LA9_0<=LINE)||LA9_0==74||LA9_0==77||LA9_0==79||(LA9_0>=81 && LA9_0<=82)) ) {
                    alt9=1;
                }


                } finally {dbg.exitDecision(9);}

                switch (alt9) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_main_structures
            	    {
            	    dbg.location(45,21);
            	    pushFollow(FOLLOW_t_main_structures_in_curly_brackets995);
            	    t_main_structures49=t_main_structures();

            	    state._fsp--;
            	    if (state.failed) return retval;
            	    if ( state.backtracking==0 ) stream_t_main_structures.add(t_main_structures49.getTree());

            	    }
            	    break;

            	default :
            	    break loop9;
                }
            } while (true);
            } finally {dbg.exitSubRule(9);}

            dbg.location(45,40);
            char_literal50=(Token)match(input,75,FOLLOW_75_in_curly_brackets998); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_75.add(char_literal50);



            // AST REWRITE
            // elements: t_main_structures
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 46:9: -> ^( BLOCK ( t_main_structures )* )
            {
                dbg.location(46,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:46:17: ^( BLOCK ( t_main_structures )* )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(46,20);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(BLOCK, "BLOCK"), root_1);

                dbg.location(46,26);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:46:26: ( t_main_structures )*
                while ( stream_t_main_structures.hasNext() ) {
                    dbg.location(46,26);
                    adaptor.addChild(root_1, stream_t_main_structures.nextTree());

                }
                stream_t_main_structures.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(47, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "curly_brackets");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "curly_brackets"

    public static class function_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "function"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:49:1: function : ( FUNC )? '(' ( function | curly_brackets | t_list | t_macro )* ')' -> ^( FUNCTION ( ^( NAME FUNC ) )? ( function )* ( curly_brackets )* ( t_list )* ( t_macro )* ) ;
    public final TikzGrammarParser.function_return function() throws RecognitionException {
        TikzGrammarParser.function_return retval = new TikzGrammarParser.function_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token FUNC51=null;
        Token char_literal52=null;
        Token char_literal57=null;
        TikzGrammarParser.function_return function53 = null;

        TikzGrammarParser.curly_brackets_return curly_brackets54 = null;

        TikzGrammarParser.t_list_return t_list55 = null;

        TikzGrammarParser.t_macro_return t_macro56 = null;


        CommonTree FUNC51_tree=null;
        CommonTree char_literal52_tree=null;
        CommonTree char_literal57_tree=null;
        RewriteRuleTokenStream stream_78=new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_77=new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_FUNC=new RewriteRuleTokenStream(adaptor,"token FUNC");
        RewriteRuleSubtreeStream stream_curly_brackets=new RewriteRuleSubtreeStream(adaptor,"rule curly_brackets");
        RewriteRuleSubtreeStream stream_t_list=new RewriteRuleSubtreeStream(adaptor,"rule t_list");
        RewriteRuleSubtreeStream stream_t_macro=new RewriteRuleSubtreeStream(adaptor,"rule t_macro");
        RewriteRuleSubtreeStream stream_function=new RewriteRuleSubtreeStream(adaptor,"rule function");
        try { dbg.enterRule(getGrammarFileName(), "function");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(49, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:9: ( ( FUNC )? '(' ( function | curly_brackets | t_list | t_macro )* ')' -> ^( FUNCTION ( ^( NAME FUNC ) )? ( function )* ( curly_brackets )* ( t_list )* ( t_macro )* ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:17: ( FUNC )? '(' ( function | curly_brackets | t_list | t_macro )* ')'
            {
            dbg.location(50,17);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:17: ( FUNC )?
            int alt10=2;
            try { dbg.enterSubRule(10);
            try { dbg.enterDecision(10);

            int LA10_0 = input.LA(1);

            if ( (LA10_0==FUNC) ) {
                alt10=1;
            }
            } finally {dbg.exitDecision(10);}

            switch (alt10) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: FUNC
                    {
                    dbg.location(50,17);
                    FUNC51=(Token)match(input,FUNC,FOLLOW_FUNC_in_function1061); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_FUNC.add(FUNC51);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(10);}

            dbg.location(50,23);
            char_literal52=(Token)match(input,77,FOLLOW_77_in_function1064); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_77.add(char_literal52);

            dbg.location(50,26);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:26: ( function | curly_brackets | t_list | t_macro )*
            try { dbg.enterSubRule(11);

            loop11:
            do {
                int alt11=5;
                try { dbg.enterDecision(11);

                try {
                    isCyclicDecision = true;
                    alt11 = dfa11.predict(input);
                }
                catch (NoViableAltException nvae) {
                    dbg.recognitionException(nvae);
                    throw nvae;
                }
                } finally {dbg.exitDecision(11);}

                switch (alt11) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:27: function
            	    {
            	    dbg.location(50,27);
            	    pushFollow(FOLLOW_function_in_function1066);
            	    function53=function();

            	    state._fsp--;
            	    if (state.failed) return retval;
            	    if ( state.backtracking==0 ) stream_function.add(function53.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:38: curly_brackets
            	    {
            	    dbg.location(50,38);
            	    pushFollow(FOLLOW_curly_brackets_in_function1070);
            	    curly_brackets54=curly_brackets();

            	    state._fsp--;
            	    if (state.failed) return retval;
            	    if ( state.backtracking==0 ) stream_curly_brackets.add(curly_brackets54.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:55: t_list
            	    {
            	    dbg.location(50,55);
            	    pushFollow(FOLLOW_t_list_in_function1074);
            	    t_list55=t_list();

            	    state._fsp--;
            	    if (state.failed) return retval;
            	    if ( state.backtracking==0 ) stream_t_list.add(t_list55.getTree());

            	    }
            	    break;
            	case 4 :
            	    dbg.enterAlt(4);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:63: t_macro
            	    {
            	    dbg.location(50,63);
            	    pushFollow(FOLLOW_t_macro_in_function1077);
            	    t_macro56=t_macro();

            	    state._fsp--;
            	    if (state.failed) return retval;
            	    if ( state.backtracking==0 ) stream_t_macro.add(t_macro56.getTree());

            	    }
            	    break;

            	default :
            	    break loop11;
                }
            } while (true);
            } finally {dbg.exitSubRule(11);}

            dbg.location(50,73);
            char_literal57=(Token)match(input,78,FOLLOW_78_in_function1081); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_78.add(char_literal57);



            // AST REWRITE
            // elements: t_list, t_macro, curly_brackets, function, FUNC
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 51:9: -> ^( FUNCTION ( ^( NAME FUNC ) )? ( function )* ( curly_brackets )* ( t_list )* ( t_macro )* )
            {
                dbg.location(51,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:51:17: ^( FUNCTION ( ^( NAME FUNC ) )? ( function )* ( curly_brackets )* ( t_list )* ( t_macro )* )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(51,20);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(FUNCTION, "FUNCTION"), root_1);

                dbg.location(51,30);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:51:30: ( ^( NAME FUNC ) )?
                if ( stream_FUNC.hasNext() ) {
                    dbg.location(51,30);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:51:30: ^( NAME FUNC )
                    {
                    CommonTree root_2 = (CommonTree)adaptor.nil();
                    dbg.location(51,32);
                    root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(NAME, "NAME"), root_2);

                    dbg.location(51,37);
                    adaptor.addChild(root_2, stream_FUNC.nextNode());

                    adaptor.addChild(root_1, root_2);
                    }

                }
                stream_FUNC.reset();
                dbg.location(51,44);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:51:44: ( function )*
                while ( stream_function.hasNext() ) {
                    dbg.location(51,44);
                    adaptor.addChild(root_1, stream_function.nextTree());

                }
                stream_function.reset();
                dbg.location(51,55);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:51:55: ( curly_brackets )*
                while ( stream_curly_brackets.hasNext() ) {
                    dbg.location(51,55);
                    adaptor.addChild(root_1, stream_curly_brackets.nextTree());

                }
                stream_curly_brackets.reset();
                dbg.location(51,72);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:51:72: ( t_list )*
                while ( stream_t_list.hasNext() ) {
                    dbg.location(51,72);
                    adaptor.addChild(root_1, stream_t_list.nextTree());

                }
                stream_t_list.reset();
                dbg.location(51,80);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:51:80: ( t_macro )*
                while ( stream_t_macro.hasNext() ) {
                    dbg.location(51,80);
                    adaptor.addChild(root_1, stream_t_macro.nextTree());

                }
                stream_t_macro.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(53, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "function");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "function"

    public static class square_brackets_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "square_brackets"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:55:1: square_brackets : '[' ']' ;
    public final TikzGrammarParser.square_brackets_return square_brackets() throws RecognitionException {
        TikzGrammarParser.square_brackets_return retval = new TikzGrammarParser.square_brackets_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token char_literal58=null;
        Token char_literal59=null;

        CommonTree char_literal58_tree=null;
        CommonTree char_literal59_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "square_brackets");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(55, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:56:9: ( '[' ']' )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:56:17: '[' ']'
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(56,17);
            char_literal58=(Token)match(input,79,FOLLOW_79_in_square_brackets1165); if (state.failed) return retval;
            if ( state.backtracking==0 ) {
            char_literal58_tree = (CommonTree)adaptor.create(char_literal58);
            adaptor.addChild(root_0, char_literal58_tree);
            }
            dbg.location(58,9);
            char_literal59=(Token)match(input,80,FOLLOW_80_in_square_brackets1187); if (state.failed) return retval;
            if ( state.backtracking==0 ) {
            char_literal59_tree = (CommonTree)adaptor.create(char_literal59);
            adaptor.addChild(root_0, char_literal59_tree);
            }

            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(60, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "square_brackets");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "square_brackets"

    public static class t_list_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_list"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:62:1: t_list : ( t_list_elem | ',' | ':' | AND )+ -> ^( LIST ( t_list_elem )* ) ;
    public final TikzGrammarParser.t_list_return t_list() throws RecognitionException {
        TikzGrammarParser.t_list_return retval = new TikzGrammarParser.t_list_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token char_literal61=null;
        Token char_literal62=null;
        Token AND63=null;
        TikzGrammarParser.t_list_elem_return t_list_elem60 = null;


        CommonTree char_literal61_tree=null;
        CommonTree char_literal62_tree=null;
        CommonTree AND63_tree=null;
        RewriteRuleTokenStream stream_AND=new RewriteRuleTokenStream(adaptor,"token AND");
        RewriteRuleTokenStream stream_82=new RewriteRuleTokenStream(adaptor,"token 82");
        RewriteRuleTokenStream stream_81=new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleSubtreeStream stream_t_list_elem=new RewriteRuleSubtreeStream(adaptor,"rule t_list_elem");
        try { dbg.enterRule(getGrammarFileName(), "t_list");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(62, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:63:9: ( ( t_list_elem | ',' | ':' | AND )+ -> ^( LIST ( t_list_elem )* ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:63:17: ( t_list_elem | ',' | ':' | AND )+
            {
            dbg.location(63,17);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:63:17: ( t_list_elem | ',' | ':' | AND )+
            int cnt12=0;
            try { dbg.enterSubRule(12);

            loop12:
            do {
                int alt12=5;
                try { dbg.enterDecision(12);

                try {
                    isCyclicDecision = true;
                    alt12 = dfa12.predict(input);
                }
                catch (NoViableAltException nvae) {
                    dbg.recognitionException(nvae);
                    throw nvae;
                }
                } finally {dbg.exitDecision(12);}

                switch (alt12) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:63:20: t_list_elem
            	    {
            	    dbg.location(63,20);
            	    pushFollow(FOLLOW_t_list_elem_in_t_list1230);
            	    t_list_elem60=t_list_elem();

            	    state._fsp--;
            	    if (state.failed) return retval;
            	    if ( state.backtracking==0 ) stream_t_list_elem.add(t_list_elem60.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:63:34: ','
            	    {
            	    dbg.location(63,34);
            	    char_literal61=(Token)match(input,81,FOLLOW_81_in_t_list1234); if (state.failed) return retval; 
            	    if ( state.backtracking==0 ) stream_81.add(char_literal61);


            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:63:40: ':'
            	    {
            	    dbg.location(63,40);
            	    char_literal62=(Token)match(input,82,FOLLOW_82_in_t_list1238); if (state.failed) return retval; 
            	    if ( state.backtracking==0 ) stream_82.add(char_literal62);


            	    }
            	    break;
            	case 4 :
            	    dbg.enterAlt(4);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:63:46: AND
            	    {
            	    dbg.location(63,46);
            	    AND63=(Token)match(input,AND,FOLLOW_AND_in_t_list1242); if (state.failed) return retval; 
            	    if ( state.backtracking==0 ) stream_AND.add(AND63);


            	    }
            	    break;

            	default :
            	    if ( cnt12 >= 1 ) break loop12;
            	    if (state.backtracking>0) {state.failed=true; return retval;}
                        EarlyExitException eee =
                            new EarlyExitException(12, input);
                        dbg.recognitionException(eee);

                        throw eee;
                }
                cnt12++;
            } while (true);
            } finally {dbg.exitSubRule(12);}



            // AST REWRITE
            // elements: t_list_elem
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 64:9: -> ^( LIST ( t_list_elem )* )
            {
                dbg.location(64,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:64:17: ^( LIST ( t_list_elem )* )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(64,20);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(LIST, "LIST"), root_1);

                dbg.location(64,25);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:64:25: ( t_list_elem )*
                while ( stream_t_list_elem.hasNext() ) {
                    dbg.location(64,25);
                    adaptor.addChild(root_1, stream_t_list_elem.nextTree());

                }
                stream_t_list_elem.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(65, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_list");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_list"

    public static class t_list_elem_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_list_elem"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:67:1: t_list_elem : ( ( (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )? oper= multioperator (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto ) ) -> ^( OPERATION $oper ^( NAME ( $elem_name)? ) ^( VALUE $elem_value) ) | (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto ) -> ^( NAME $elem_name) );
    public final TikzGrammarParser.t_list_elem_return t_list_elem() throws RecognitionException {
        TikzGrammarParser.t_list_elem_return retval = new TikzGrammarParser.t_list_elem_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        List list_elem_name=null;
        List list_elem_value=null;
        TikzGrammarParser.multioperator_return oper = null;

        RuleReturnScope elem_name = null;
        RuleReturnScope elem_value = null;
        RewriteRuleSubtreeStream stream_curly_brackets=new RewriteRuleSubtreeStream(adaptor,"rule curly_brackets");
        RewriteRuleSubtreeStream stream_square_brackets=new RewriteRuleSubtreeStream(adaptor,"rule square_brackets");
        RewriteRuleSubtreeStream stream_string=new RewriteRuleSubtreeStream(adaptor,"rule string");
        RewriteRuleSubtreeStream stream_t_lineto=new RewriteRuleSubtreeStream(adaptor,"rule t_lineto");
        RewriteRuleSubtreeStream stream_multioperator=new RewriteRuleSubtreeStream(adaptor,"rule multioperator");
        RewriteRuleSubtreeStream stream_t_macro=new RewriteRuleSubtreeStream(adaptor,"rule t_macro");
        RewriteRuleSubtreeStream stream_function=new RewriteRuleSubtreeStream(adaptor,"rule function");
        try { dbg.enterRule(getGrammarFileName(), "t_list_elem");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(67, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:9: ( ( (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )? oper= multioperator (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto ) ) -> ^( OPERATION $oper ^( NAME ( $elem_name)? ) ^( VALUE $elem_value) ) | (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto ) -> ^( NAME $elem_name) )
            int alt16=2;
            try { dbg.enterDecision(16);

            try {
                isCyclicDecision = true;
                alt16 = dfa16.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(16);}

            switch (alt16) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:17: ( (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )? oper= multioperator (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto ) )
                    {
                    dbg.location(68,17);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:17: ( (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )? oper= multioperator (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto ) )
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:19: (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )? oper= multioperator (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto )
                    {
                    dbg.location(68,19);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:19: (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )?
                    int alt13=7;
                    try { dbg.enterSubRule(13);
                    try { dbg.enterDecision(13);

                    try {
                        isCyclicDecision = true;
                        alt13 = dfa13.predict(input);
                    }
                    catch (NoViableAltException nvae) {
                        dbg.recognitionException(nvae);
                        throw nvae;
                    }
                    } finally {dbg.exitDecision(13);}

                    switch (alt13) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:21: elem_name+= t_macro
                            {
                            dbg.location(68,30);
                            pushFollow(FOLLOW_t_macro_in_t_list_elem1307);
                            elem_name=t_macro();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_macro.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;
                        case 2 :
                            dbg.enterAlt(2);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:42: elem_name+= string
                            {
                            dbg.location(68,51);
                            pushFollow(FOLLOW_string_in_t_list_elem1313);
                            elem_name=string();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_string.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;
                        case 3 :
                            dbg.enterAlt(3);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:62: elem_name+= function
                            {
                            dbg.location(68,71);
                            pushFollow(FOLLOW_function_in_t_list_elem1319);
                            elem_name=function();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_function.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;
                        case 4 :
                            dbg.enterAlt(4);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:84: elem_name+= curly_brackets
                            {
                            dbg.location(68,93);
                            pushFollow(FOLLOW_curly_brackets_in_t_list_elem1325);
                            elem_name=curly_brackets();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_curly_brackets.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;
                        case 5 :
                            dbg.enterAlt(5);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:113: elem_name+= square_brackets
                            {
                            dbg.location(68,122);
                            pushFollow(FOLLOW_square_brackets_in_t_list_elem1332);
                            elem_name=square_brackets();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_square_brackets.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;
                        case 6 :
                            dbg.enterAlt(6);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:142: elem_name+= t_lineto
                            {
                            dbg.location(68,151);
                            pushFollow(FOLLOW_t_lineto_in_t_list_elem1338);
                            elem_name=t_lineto();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_lineto.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(13);}

                    dbg.location(69,21);
                    pushFollow(FOLLOW_multioperator_in_t_list_elem1361);
                    oper=multioperator();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_multioperator.add(oper.getTree());
                    dbg.location(69,36);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:36: (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto )
                    int alt14=6;
                    try { dbg.enterSubRule(14);
                    try { dbg.enterDecision(14);

                    try {
                        isCyclicDecision = true;
                        alt14 = dfa14.predict(input);
                    }
                    catch (NoViableAltException nvae) {
                        dbg.recognitionException(nvae);
                        throw nvae;
                    }
                    } finally {dbg.exitDecision(14);}

                    switch (alt14) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:38: elem_value+= t_macro
                            {
                            dbg.location(69,48);
                            pushFollow(FOLLOW_t_macro_in_t_list_elem1367);
                            elem_value=t_macro();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_macro.add(elem_value.getTree());
                            if (list_elem_value==null) list_elem_value=new ArrayList();
                            list_elem_value.add(elem_value.getTree());


                            }
                            break;
                        case 2 :
                            dbg.enterAlt(2);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:60: elem_value+= string
                            {
                            dbg.location(69,70);
                            pushFollow(FOLLOW_string_in_t_list_elem1373);
                            elem_value=string();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_string.add(elem_value.getTree());
                            if (list_elem_value==null) list_elem_value=new ArrayList();
                            list_elem_value.add(elem_value.getTree());


                            }
                            break;
                        case 3 :
                            dbg.enterAlt(3);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:81: elem_value+= function
                            {
                            dbg.location(69,91);
                            pushFollow(FOLLOW_function_in_t_list_elem1379);
                            elem_value=function();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_function.add(elem_value.getTree());
                            if (list_elem_value==null) list_elem_value=new ArrayList();
                            list_elem_value.add(elem_value.getTree());


                            }
                            break;
                        case 4 :
                            dbg.enterAlt(4);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:104: elem_value+= curly_brackets
                            {
                            dbg.location(69,114);
                            pushFollow(FOLLOW_curly_brackets_in_t_list_elem1385);
                            elem_value=curly_brackets();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_curly_brackets.add(elem_value.getTree());
                            if (list_elem_value==null) list_elem_value=new ArrayList();
                            list_elem_value.add(elem_value.getTree());


                            }
                            break;
                        case 5 :
                            dbg.enterAlt(5);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:134: elem_value+= square_brackets
                            {
                            dbg.location(69,144);
                            pushFollow(FOLLOW_square_brackets_in_t_list_elem1392);
                            elem_value=square_brackets();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_square_brackets.add(elem_value.getTree());
                            if (list_elem_value==null) list_elem_value=new ArrayList();
                            list_elem_value.add(elem_value.getTree());


                            }
                            break;
                        case 6 :
                            dbg.enterAlt(6);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:164: elem_name+= t_lineto
                            {
                            dbg.location(69,173);
                            pushFollow(FOLLOW_t_lineto_in_t_list_elem1398);
                            elem_name=t_lineto();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_lineto.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(14);}


                    }



                    // AST REWRITE
                    // elements: oper, elem_name, elem_value
                    // token labels: 
                    // rule labels: retval, oper
                    // token list labels: 
                    // rule list labels: elem_name, elem_value
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);
                    RewriteRuleSubtreeStream stream_oper=new RewriteRuleSubtreeStream(adaptor,"rule oper",oper!=null?oper.tree:null);
                    RewriteRuleSubtreeStream stream_elem_name=new RewriteRuleSubtreeStream(adaptor,"token elem_name",list_elem_name);
                    RewriteRuleSubtreeStream stream_elem_value=new RewriteRuleSubtreeStream(adaptor,"token elem_value",list_elem_value);
                    root_0 = (CommonTree)adaptor.nil();
                    // 70:9: -> ^( OPERATION $oper ^( NAME ( $elem_name)? ) ^( VALUE $elem_value) )
                    {
                        dbg.location(70,17);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:70:17: ^( OPERATION $oper ^( NAME ( $elem_name)? ) ^( VALUE $elem_value) )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(70,19);
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(OPERATION, "OPERATION"), root_1);

                        dbg.location(70,29);
                        adaptor.addChild(root_1, stream_oper.nextTree());
                        dbg.location(70,35);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:70:35: ^( NAME ( $elem_name)? )
                        {
                        CommonTree root_2 = (CommonTree)adaptor.nil();
                        dbg.location(70,38);
                        root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(NAME, "NAME"), root_2);

                        dbg.location(70,43);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:70:43: ( $elem_name)?
                        if ( stream_elem_name.hasNext() ) {
                            dbg.location(70,43);
                            adaptor.addChild(root_2, stream_elem_name.nextTree());

                        }
                        stream_elem_name.reset();

                        adaptor.addChild(root_1, root_2);
                        }
                        dbg.location(70,57);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:70:57: ^( VALUE $elem_value)
                        {
                        CommonTree root_2 = (CommonTree)adaptor.nil();
                        dbg.location(70,60);
                        root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(VALUE, "VALUE"), root_2);

                        dbg.location(70,66);
                        adaptor.addChild(root_2, stream_elem_value.nextTree());

                        adaptor.addChild(root_1, root_2);
                        }

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:71:19: (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )
                    {
                    dbg.location(71,19);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:71:19: (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )
                    int alt15=6;
                    try { dbg.enterSubRule(15);
                    try { dbg.enterDecision(15);

                    switch ( input.LA(1) ) {
                    case BACKSLASH:
                        {
                        alt15=1;
                        }
                        break;
                    case BEGIN:
                    case END:
                    case AND:
                    case OPERATOR:
                    case STRING:
                    case HVLINE:
                    case VHLINE:
                    case TO:
                    case IN:
                    case CYCLE:
                    case FOREACH:
                    case CS:
                    case NODE:
                    case AT:
                    case FUNCTION:
                    case FILE:
                    case COORDINATES:
                    case COORDINATE:
                    case EDGE:
                    case CONTROLS:
                    case FROM:
                    case PARENT:
                    case DOTS:
                    case RECTANGLE:
                    case GRID:
                    case PLOT:
                    case CHILD:
                    case CIRCLE:
                    case ELLIPSE:
                    case ARC:
                    case PARABOLA:
                    case BEND:
                        {
                        alt15=2;
                        }
                        break;
                    case FUNC:
                        {
                        int LA15_3 = input.LA(2);

                        if ( (synpred62_TikzGrammar()) ) {
                            alt15=2;
                        }
                        else if ( (synpred63_TikzGrammar()) ) {
                            alt15=3;
                        }
                        else {
                            if (state.backtracking>0) {state.failed=true; return retval;}
                            NoViableAltException nvae =
                                new NoViableAltException("", 15, 3, input);

                            dbg.recognitionException(nvae);
                            throw nvae;
                        }
                        }
                        break;
                    case 77:
                        {
                        alt15=3;
                        }
                        break;
                    case 74:
                        {
                        alt15=4;
                        }
                        break;
                    case 79:
                        {
                        alt15=5;
                        }
                        break;
                    case LINE:
                        {
                        alt15=6;
                        }
                        break;
                    default:
                        if (state.backtracking>0) {state.failed=true; return retval;}
                        NoViableAltException nvae =
                            new NoViableAltException("", 15, 0, input);

                        dbg.recognitionException(nvae);
                        throw nvae;
                    }

                    } finally {dbg.exitDecision(15);}

                    switch (alt15) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:71:21: elem_name+= t_macro
                            {
                            dbg.location(71,30);
                            pushFollow(FOLLOW_t_macro_in_t_list_elem1469);
                            elem_name=t_macro();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_macro.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;
                        case 2 :
                            dbg.enterAlt(2);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:71:42: elem_name+= string
                            {
                            dbg.location(71,51);
                            pushFollow(FOLLOW_string_in_t_list_elem1475);
                            elem_name=string();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_string.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;
                        case 3 :
                            dbg.enterAlt(3);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:71:62: elem_name+= function
                            {
                            dbg.location(71,71);
                            pushFollow(FOLLOW_function_in_t_list_elem1481);
                            elem_name=function();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_function.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;
                        case 4 :
                            dbg.enterAlt(4);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:71:84: elem_name+= curly_brackets
                            {
                            dbg.location(71,93);
                            pushFollow(FOLLOW_curly_brackets_in_t_list_elem1487);
                            elem_name=curly_brackets();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_curly_brackets.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;
                        case 5 :
                            dbg.enterAlt(5);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:71:113: elem_name+= square_brackets
                            {
                            dbg.location(71,122);
                            pushFollow(FOLLOW_square_brackets_in_t_list_elem1494);
                            elem_name=square_brackets();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_square_brackets.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;
                        case 6 :
                            dbg.enterAlt(6);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:71:143: elem_name+= t_lineto
                            {
                            dbg.location(71,152);
                            pushFollow(FOLLOW_t_lineto_in_t_list_elem1501);
                            elem_name=t_lineto();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_lineto.add(elem_name.getTree());
                            if (list_elem_name==null) list_elem_name=new ArrayList();
                            list_elem_name.add(elem_name.getTree());


                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(15);}



                    // AST REWRITE
                    // elements: elem_name
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: elem_name
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);
                    RewriteRuleSubtreeStream stream_elem_name=new RewriteRuleSubtreeStream(adaptor,"token elem_name",list_elem_name);
                    root_0 = (CommonTree)adaptor.nil();
                    // 72:17: -> ^( NAME $elem_name)
                    {
                        dbg.location(72,21);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:72:21: ^( NAME $elem_name)
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(72,24);
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(NAME, "NAME"), root_1);

                        dbg.location(72,29);
                        adaptor.addChild(root_1, stream_elem_name.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(73, 17);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_list_elem");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_list_elem"

    public static class t_options_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_options"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:75:1: t_options : '[' ( t_list_elem | ',' | ':' )+ ']' -> ^( OPTIONS ( t_list_elem )* ) ;
    public final TikzGrammarParser.t_options_return t_options() throws RecognitionException {
        TikzGrammarParser.t_options_return retval = new TikzGrammarParser.t_options_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token char_literal64=null;
        Token char_literal66=null;
        Token char_literal67=null;
        Token char_literal68=null;
        TikzGrammarParser.t_list_elem_return t_list_elem65 = null;


        CommonTree char_literal64_tree=null;
        CommonTree char_literal66_tree=null;
        CommonTree char_literal67_tree=null;
        CommonTree char_literal68_tree=null;
        RewriteRuleTokenStream stream_79=new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_82=new RewriteRuleTokenStream(adaptor,"token 82");
        RewriteRuleTokenStream stream_80=new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_81=new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleSubtreeStream stream_t_list_elem=new RewriteRuleSubtreeStream(adaptor,"rule t_list_elem");
        try { dbg.enterRule(getGrammarFileName(), "t_options");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(75, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:76:9: ( '[' ( t_list_elem | ',' | ':' )+ ']' -> ^( OPTIONS ( t_list_elem )* ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:76:17: '[' ( t_list_elem | ',' | ':' )+ ']'
            {
            dbg.location(76,17);
            char_literal64=(Token)match(input,79,FOLLOW_79_in_t_options1594); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_79.add(char_literal64);

            dbg.location(76,21);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:76:21: ( t_list_elem | ',' | ':' )+
            int cnt17=0;
            try { dbg.enterSubRule(17);

            loop17:
            do {
                int alt17=4;
                try { dbg.enterDecision(17);

                switch ( input.LA(1) ) {
                case BACKSLASH:
                case BEGIN:
                case END:
                case FUNC:
                case AND:
                case OPERATOR:
                case STRING:
                case HVLINE:
                case VHLINE:
                case TO:
                case IN:
                case CYCLE:
                case FOREACH:
                case CS:
                case NODE:
                case AT:
                case FUNCTION:
                case FILE:
                case COORDINATES:
                case COORDINATE:
                case EDGE:
                case CONTROLS:
                case FROM:
                case PARENT:
                case DOTS:
                case RECTANGLE:
                case GRID:
                case PLOT:
                case CHILD:
                case CIRCLE:
                case ELLIPSE:
                case ARC:
                case PARABOLA:
                case BEND:
                case LINE:
                case 74:
                case 77:
                case 79:
                    {
                    alt17=1;
                    }
                    break;
                case 81:
                    {
                    alt17=2;
                    }
                    break;
                case 82:
                    {
                    alt17=3;
                    }
                    break;

                }

                } finally {dbg.exitDecision(17);}

                switch (alt17) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:76:23: t_list_elem
            	    {
            	    dbg.location(76,23);
            	    pushFollow(FOLLOW_t_list_elem_in_t_options1598);
            	    t_list_elem65=t_list_elem();

            	    state._fsp--;
            	    if (state.failed) return retval;
            	    if ( state.backtracking==0 ) stream_t_list_elem.add(t_list_elem65.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:76:37: ','
            	    {
            	    dbg.location(76,37);
            	    char_literal66=(Token)match(input,81,FOLLOW_81_in_t_options1602); if (state.failed) return retval; 
            	    if ( state.backtracking==0 ) stream_81.add(char_literal66);


            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:76:43: ':'
            	    {
            	    dbg.location(76,43);
            	    char_literal67=(Token)match(input,82,FOLLOW_82_in_t_options1606); if (state.failed) return retval; 
            	    if ( state.backtracking==0 ) stream_82.add(char_literal67);


            	    }
            	    break;

            	default :
            	    if ( cnt17 >= 1 ) break loop17;
            	    if (state.backtracking>0) {state.failed=true; return retval;}
                        EarlyExitException eee =
                            new EarlyExitException(17, input);
                        dbg.recognitionException(eee);

                        throw eee;
                }
                cnt17++;
            } while (true);
            } finally {dbg.exitSubRule(17);}

            dbg.location(76,50);
            char_literal68=(Token)match(input,80,FOLLOW_80_in_t_options1611); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_80.add(char_literal68);



            // AST REWRITE
            // elements: t_list_elem
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 77:9: -> ^( OPTIONS ( t_list_elem )* )
            {
                dbg.location(77,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:77:17: ^( OPTIONS ( t_list_elem )* )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(77,20);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(OPTIONS, "OPTIONS"), root_1);

                dbg.location(77,28);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:77:28: ( t_list_elem )*
                while ( stream_t_list_elem.hasNext() ) {
                    dbg.location(77,28);
                    adaptor.addChild(root_1, stream_t_list_elem.nextTree());

                }
                stream_t_list_elem.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(78, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_options");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_options"

    public static class multioperator_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "multioperator"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:82:1: multioperator : ( OPERATOR )+ ;
    public final TikzGrammarParser.multioperator_return multioperator() throws RecognitionException {
        TikzGrammarParser.multioperator_return retval = new TikzGrammarParser.multioperator_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token OPERATOR69=null;

        CommonTree OPERATOR69_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "multioperator");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(82, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:83:9: ( ( OPERATOR )+ )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:83:17: ( OPERATOR )+
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(83,17);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:83:17: ( OPERATOR )+
            int cnt18=0;
            try { dbg.enterSubRule(18);

            loop18:
            do {
                int alt18=2;
                try { dbg.enterDecision(18);

                int LA18_0 = input.LA(1);

                if ( (LA18_0==OPERATOR) ) {
                    int LA18_2 = input.LA(2);

                    if ( (synpred69_TikzGrammar()) ) {
                        alt18=1;
                    }


                }


                } finally {dbg.exitDecision(18);}

                switch (alt18) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: OPERATOR
            	    {
            	    dbg.location(83,17);
            	    OPERATOR69=(Token)match(input,OPERATOR,FOLLOW_OPERATOR_in_multioperator1707); if (state.failed) return retval;
            	    if ( state.backtracking==0 ) {
            	    OPERATOR69_tree = (CommonTree)adaptor.create(OPERATOR69);
            	    adaptor.addChild(root_0, OPERATOR69_tree);
            	    }

            	    }
            	    break;

            	default :
            	    if ( cnt18 >= 1 ) break loop18;
            	    if (state.backtracking>0) {state.failed=true; return retval;}
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

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(84, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "multioperator");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "multioperator"

    public static class string_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "string"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:87:1: string : ( ( ( OPERATOR )* ( STRING )+ ) | ( OPERATOR )+ | BEGIN | END | HVLINE | VHLINE | TO | IN | CYCLE | FOREACH | CS | NODE | AT | FUNC | FUNCTION | FILE | COORDINATES | COORDINATE | EDGE | AND | CONTROLS | FROM | PARENT | DOTS | RECTANGLE | GRID | PLOT | CHILD | CIRCLE | ELLIPSE | ARC | PARABOLA | BEND );
    public final TikzGrammarParser.string_return string() throws RecognitionException {
        TikzGrammarParser.string_return retval = new TikzGrammarParser.string_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token OPERATOR70=null;
        Token STRING71=null;
        Token OPERATOR72=null;
        Token BEGIN73=null;
        Token END74=null;
        Token HVLINE75=null;
        Token VHLINE76=null;
        Token TO77=null;
        Token IN78=null;
        Token CYCLE79=null;
        Token FOREACH80=null;
        Token CS81=null;
        Token NODE82=null;
        Token AT83=null;
        Token FUNC84=null;
        Token FUNCTION85=null;
        Token FILE86=null;
        Token COORDINATES87=null;
        Token COORDINATE88=null;
        Token EDGE89=null;
        Token AND90=null;
        Token CONTROLS91=null;
        Token FROM92=null;
        Token PARENT93=null;
        Token DOTS94=null;
        Token RECTANGLE95=null;
        Token GRID96=null;
        Token PLOT97=null;
        Token CHILD98=null;
        Token CIRCLE99=null;
        Token ELLIPSE100=null;
        Token ARC101=null;
        Token PARABOLA102=null;
        Token BEND103=null;

        CommonTree OPERATOR70_tree=null;
        CommonTree STRING71_tree=null;
        CommonTree OPERATOR72_tree=null;
        CommonTree BEGIN73_tree=null;
        CommonTree END74_tree=null;
        CommonTree HVLINE75_tree=null;
        CommonTree VHLINE76_tree=null;
        CommonTree TO77_tree=null;
        CommonTree IN78_tree=null;
        CommonTree CYCLE79_tree=null;
        CommonTree FOREACH80_tree=null;
        CommonTree CS81_tree=null;
        CommonTree NODE82_tree=null;
        CommonTree AT83_tree=null;
        CommonTree FUNC84_tree=null;
        CommonTree FUNCTION85_tree=null;
        CommonTree FILE86_tree=null;
        CommonTree COORDINATES87_tree=null;
        CommonTree COORDINATE88_tree=null;
        CommonTree EDGE89_tree=null;
        CommonTree AND90_tree=null;
        CommonTree CONTROLS91_tree=null;
        CommonTree FROM92_tree=null;
        CommonTree PARENT93_tree=null;
        CommonTree DOTS94_tree=null;
        CommonTree RECTANGLE95_tree=null;
        CommonTree GRID96_tree=null;
        CommonTree PLOT97_tree=null;
        CommonTree CHILD98_tree=null;
        CommonTree CIRCLE99_tree=null;
        CommonTree ELLIPSE100_tree=null;
        CommonTree ARC101_tree=null;
        CommonTree PARABOLA102_tree=null;
        CommonTree BEND103_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "string");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(87, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:87:9: ( ( ( OPERATOR )* ( STRING )+ ) | ( OPERATOR )+ | BEGIN | END | HVLINE | VHLINE | TO | IN | CYCLE | FOREACH | CS | NODE | AT | FUNC | FUNCTION | FILE | COORDINATES | COORDINATE | EDGE | AND | CONTROLS | FROM | PARENT | DOTS | RECTANGLE | GRID | PLOT | CHILD | CIRCLE | ELLIPSE | ARC | PARABOLA | BEND )
            int alt22=33;
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

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:17: ( ( OPERATOR )* ( STRING )+ )
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(88,17);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:17: ( ( OPERATOR )* ( STRING )+ )
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:18: ( OPERATOR )* ( STRING )+
                    {
                    dbg.location(88,18);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:18: ( OPERATOR )*
                    try { dbg.enterSubRule(19);

                    loop19:
                    do {
                        int alt19=2;
                        try { dbg.enterDecision(19);

                        int LA19_0 = input.LA(1);

                        if ( (LA19_0==OPERATOR) ) {
                            alt19=1;
                        }


                        } finally {dbg.exitDecision(19);}

                        switch (alt19) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: OPERATOR
                    	    {
                    	    dbg.location(88,18);
                    	    OPERATOR70=(Token)match(input,OPERATOR,FOLLOW_OPERATOR_in_string1759); if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) {
                    	    OPERATOR70_tree = (CommonTree)adaptor.create(OPERATOR70);
                    	    adaptor.addChild(root_0, OPERATOR70_tree);
                    	    }

                    	    }
                    	    break;

                    	default :
                    	    break loop19;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(19);}

                    dbg.location(88,28);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:28: ( STRING )+
                    int cnt20=0;
                    try { dbg.enterSubRule(20);

                    loop20:
                    do {
                        int alt20=2;
                        try { dbg.enterDecision(20);

                        int LA20_0 = input.LA(1);

                        if ( (LA20_0==STRING) ) {
                            int LA20_2 = input.LA(2);

                            if ( (synpred71_TikzGrammar()) ) {
                                alt20=1;
                            }


                        }


                        } finally {dbg.exitDecision(20);}

                        switch (alt20) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: STRING
                    	    {
                    	    dbg.location(88,28);
                    	    STRING71=(Token)match(input,STRING,FOLLOW_STRING_in_string1762); if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) {
                    	    STRING71_tree = (CommonTree)adaptor.create(STRING71);
                    	    adaptor.addChild(root_0, STRING71_tree);
                    	    }

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt20 >= 1 ) break loop20;
                    	    if (state.backtracking>0) {state.failed=true; return retval;}
                                EarlyExitException eee =
                                    new EarlyExitException(20, input);
                                dbg.recognitionException(eee);

                                throw eee;
                        }
                        cnt20++;
                    } while (true);
                    } finally {dbg.exitSubRule(20);}


                    }


                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:89:19: ( OPERATOR )+
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(89,19);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:89:19: ( OPERATOR )+
                    int cnt21=0;
                    try { dbg.enterSubRule(21);

                    loop21:
                    do {
                        int alt21=2;
                        try { dbg.enterDecision(21);

                        int LA21_0 = input.LA(1);

                        if ( (LA21_0==OPERATOR) ) {
                            int LA21_2 = input.LA(2);

                            if ( (synpred73_TikzGrammar()) ) {
                                alt21=1;
                            }


                        }


                        } finally {dbg.exitDecision(21);}

                        switch (alt21) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: OPERATOR
                    	    {
                    	    dbg.location(89,19);
                    	    OPERATOR72=(Token)match(input,OPERATOR,FOLLOW_OPERATOR_in_string1784); if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) {
                    	    OPERATOR72_tree = (CommonTree)adaptor.create(OPERATOR72);
                    	    adaptor.addChild(root_0, OPERATOR72_tree);
                    	    }

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt21 >= 1 ) break loop21;
                    	    if (state.backtracking>0) {state.failed=true; return retval;}
                                EarlyExitException eee =
                                    new EarlyExitException(21, input);
                                dbg.recognitionException(eee);

                                throw eee;
                        }
                        cnt21++;
                    } while (true);
                    } finally {dbg.exitSubRule(21);}


                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:91:18: BEGIN
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(91,18);
                    BEGIN73=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_string1821); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    BEGIN73_tree = (CommonTree)adaptor.create(BEGIN73);
                    adaptor.addChild(root_0, BEGIN73_tree);
                    }

                    }
                    break;
                case 4 :
                    dbg.enterAlt(4);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:91:24: END
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(91,24);
                    END74=(Token)match(input,END,FOLLOW_END_in_string1823); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    END74_tree = (CommonTree)adaptor.create(END74);
                    adaptor.addChild(root_0, END74_tree);
                    }

                    }
                    break;
                case 5 :
                    dbg.enterAlt(5);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:91:28: HVLINE
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(91,28);
                    HVLINE75=(Token)match(input,HVLINE,FOLLOW_HVLINE_in_string1825); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    HVLINE75_tree = (CommonTree)adaptor.create(HVLINE75);
                    adaptor.addChild(root_0, HVLINE75_tree);
                    }

                    }
                    break;
                case 6 :
                    dbg.enterAlt(6);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:91:35: VHLINE
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(91,35);
                    VHLINE76=(Token)match(input,VHLINE,FOLLOW_VHLINE_in_string1827); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    VHLINE76_tree = (CommonTree)adaptor.create(VHLINE76);
                    adaptor.addChild(root_0, VHLINE76_tree);
                    }

                    }
                    break;
                case 7 :
                    dbg.enterAlt(7);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:91:42: TO
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(91,42);
                    TO77=(Token)match(input,TO,FOLLOW_TO_in_string1829); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    TO77_tree = (CommonTree)adaptor.create(TO77);
                    adaptor.addChild(root_0, TO77_tree);
                    }

                    }
                    break;
                case 8 :
                    dbg.enterAlt(8);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:91:45: IN
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(91,45);
                    IN78=(Token)match(input,IN,FOLLOW_IN_in_string1831); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    IN78_tree = (CommonTree)adaptor.create(IN78);
                    adaptor.addChild(root_0, IN78_tree);
                    }

                    }
                    break;
                case 9 :
                    dbg.enterAlt(9);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:91:48: CYCLE
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(91,48);
                    CYCLE79=(Token)match(input,CYCLE,FOLLOW_CYCLE_in_string1833); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    CYCLE79_tree = (CommonTree)adaptor.create(CYCLE79);
                    adaptor.addChild(root_0, CYCLE79_tree);
                    }

                    }
                    break;
                case 10 :
                    dbg.enterAlt(10);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:91:54: FOREACH
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(91,54);
                    FOREACH80=(Token)match(input,FOREACH,FOLLOW_FOREACH_in_string1835); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    FOREACH80_tree = (CommonTree)adaptor.create(FOREACH80);
                    adaptor.addChild(root_0, FOREACH80_tree);
                    }

                    }
                    break;
                case 11 :
                    dbg.enterAlt(11);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:91:62: CS
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(91,62);
                    CS81=(Token)match(input,CS,FOLLOW_CS_in_string1837); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    CS81_tree = (CommonTree)adaptor.create(CS81);
                    adaptor.addChild(root_0, CS81_tree);
                    }

                    }
                    break;
                case 12 :
                    dbg.enterAlt(12);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:91:65: NODE
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(91,65);
                    NODE82=(Token)match(input,NODE,FOLLOW_NODE_in_string1839); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    NODE82_tree = (CommonTree)adaptor.create(NODE82);
                    adaptor.addChild(root_0, NODE82_tree);
                    }

                    }
                    break;
                case 13 :
                    dbg.enterAlt(13);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:92:18: AT
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(92,18);
                    AT83=(Token)match(input,AT,FOLLOW_AT_in_string1858); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    AT83_tree = (CommonTree)adaptor.create(AT83);
                    adaptor.addChild(root_0, AT83_tree);
                    }

                    }
                    break;
                case 14 :
                    dbg.enterAlt(14);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:92:21: FUNC
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(92,21);
                    FUNC84=(Token)match(input,FUNC,FOLLOW_FUNC_in_string1860); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    FUNC84_tree = (CommonTree)adaptor.create(FUNC84);
                    adaptor.addChild(root_0, FUNC84_tree);
                    }

                    }
                    break;
                case 15 :
                    dbg.enterAlt(15);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:92:26: FUNCTION
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(92,26);
                    FUNCTION85=(Token)match(input,FUNCTION,FOLLOW_FUNCTION_in_string1862); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    FUNCTION85_tree = (CommonTree)adaptor.create(FUNCTION85);
                    adaptor.addChild(root_0, FUNCTION85_tree);
                    }

                    }
                    break;
                case 16 :
                    dbg.enterAlt(16);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:92:35: FILE
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(92,35);
                    FILE86=(Token)match(input,FILE,FOLLOW_FILE_in_string1864); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    FILE86_tree = (CommonTree)adaptor.create(FILE86);
                    adaptor.addChild(root_0, FILE86_tree);
                    }

                    }
                    break;
                case 17 :
                    dbg.enterAlt(17);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:92:40: COORDINATES
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(92,40);
                    COORDINATES87=(Token)match(input,COORDINATES,FOLLOW_COORDINATES_in_string1866); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    COORDINATES87_tree = (CommonTree)adaptor.create(COORDINATES87);
                    adaptor.addChild(root_0, COORDINATES87_tree);
                    }

                    }
                    break;
                case 18 :
                    dbg.enterAlt(18);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:92:52: COORDINATE
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(92,52);
                    COORDINATE88=(Token)match(input,COORDINATE,FOLLOW_COORDINATE_in_string1868); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    COORDINATE88_tree = (CommonTree)adaptor.create(COORDINATE88);
                    adaptor.addChild(root_0, COORDINATE88_tree);
                    }

                    }
                    break;
                case 19 :
                    dbg.enterAlt(19);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:92:63: EDGE
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(92,63);
                    EDGE89=(Token)match(input,EDGE,FOLLOW_EDGE_in_string1870); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    EDGE89_tree = (CommonTree)adaptor.create(EDGE89);
                    adaptor.addChild(root_0, EDGE89_tree);
                    }

                    }
                    break;
                case 20 :
                    dbg.enterAlt(20);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:92:68: AND
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(92,68);
                    AND90=(Token)match(input,AND,FOLLOW_AND_in_string1872); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    AND90_tree = (CommonTree)adaptor.create(AND90);
                    adaptor.addChild(root_0, AND90_tree);
                    }

                    }
                    break;
                case 21 :
                    dbg.enterAlt(21);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:92:72: CONTROLS
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(92,72);
                    CONTROLS91=(Token)match(input,CONTROLS,FOLLOW_CONTROLS_in_string1874); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    CONTROLS91_tree = (CommonTree)adaptor.create(CONTROLS91);
                    adaptor.addChild(root_0, CONTROLS91_tree);
                    }

                    }
                    break;
                case 22 :
                    dbg.enterAlt(22);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:92:81: FROM
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(92,81);
                    FROM92=(Token)match(input,FROM,FOLLOW_FROM_in_string1876); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    FROM92_tree = (CommonTree)adaptor.create(FROM92);
                    adaptor.addChild(root_0, FROM92_tree);
                    }

                    }
                    break;
                case 23 :
                    dbg.enterAlt(23);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:92:86: PARENT
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(92,86);
                    PARENT93=(Token)match(input,PARENT,FOLLOW_PARENT_in_string1878); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    PARENT93_tree = (CommonTree)adaptor.create(PARENT93);
                    adaptor.addChild(root_0, PARENT93_tree);
                    }

                    }
                    break;
                case 24 :
                    dbg.enterAlt(24);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:93:18: DOTS
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(93,18);
                    DOTS94=(Token)match(input,DOTS,FOLLOW_DOTS_in_string1897); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    DOTS94_tree = (CommonTree)adaptor.create(DOTS94);
                    adaptor.addChild(root_0, DOTS94_tree);
                    }

                    }
                    break;
                case 25 :
                    dbg.enterAlt(25);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:93:23: RECTANGLE
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(93,23);
                    RECTANGLE95=(Token)match(input,RECTANGLE,FOLLOW_RECTANGLE_in_string1899); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    RECTANGLE95_tree = (CommonTree)adaptor.create(RECTANGLE95);
                    adaptor.addChild(root_0, RECTANGLE95_tree);
                    }

                    }
                    break;
                case 26 :
                    dbg.enterAlt(26);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:93:33: GRID
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(93,33);
                    GRID96=(Token)match(input,GRID,FOLLOW_GRID_in_string1901); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    GRID96_tree = (CommonTree)adaptor.create(GRID96);
                    adaptor.addChild(root_0, GRID96_tree);
                    }

                    }
                    break;
                case 27 :
                    dbg.enterAlt(27);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:93:38: PLOT
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(93,38);
                    PLOT97=(Token)match(input,PLOT,FOLLOW_PLOT_in_string1903); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    PLOT97_tree = (CommonTree)adaptor.create(PLOT97);
                    adaptor.addChild(root_0, PLOT97_tree);
                    }

                    }
                    break;
                case 28 :
                    dbg.enterAlt(28);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:93:43: CHILD
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(93,43);
                    CHILD98=(Token)match(input,CHILD,FOLLOW_CHILD_in_string1905); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    CHILD98_tree = (CommonTree)adaptor.create(CHILD98);
                    adaptor.addChild(root_0, CHILD98_tree);
                    }

                    }
                    break;
                case 29 :
                    dbg.enterAlt(29);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:93:49: CIRCLE
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(93,49);
                    CIRCLE99=(Token)match(input,CIRCLE,FOLLOW_CIRCLE_in_string1907); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    CIRCLE99_tree = (CommonTree)adaptor.create(CIRCLE99);
                    adaptor.addChild(root_0, CIRCLE99_tree);
                    }

                    }
                    break;
                case 30 :
                    dbg.enterAlt(30);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:93:56: ELLIPSE
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(93,56);
                    ELLIPSE100=(Token)match(input,ELLIPSE,FOLLOW_ELLIPSE_in_string1909); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    ELLIPSE100_tree = (CommonTree)adaptor.create(ELLIPSE100);
                    adaptor.addChild(root_0, ELLIPSE100_tree);
                    }

                    }
                    break;
                case 31 :
                    dbg.enterAlt(31);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:93:64: ARC
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(93,64);
                    ARC101=(Token)match(input,ARC,FOLLOW_ARC_in_string1911); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    ARC101_tree = (CommonTree)adaptor.create(ARC101);
                    adaptor.addChild(root_0, ARC101_tree);
                    }

                    }
                    break;
                case 32 :
                    dbg.enterAlt(32);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:93:68: PARABOLA
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(93,68);
                    PARABOLA102=(Token)match(input,PARABOLA,FOLLOW_PARABOLA_in_string1913); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    PARABOLA102_tree = (CommonTree)adaptor.create(PARABOLA102);
                    adaptor.addChild(root_0, PARABOLA102_tree);
                    }

                    }
                    break;
                case 33 :
                    dbg.enterAlt(33);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:93:77: BEND
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(93,77);
                    BEND103=(Token)match(input,BEND,FOLLOW_BEND_in_string1915); if (state.failed) return retval;
                    if ( state.backtracking==0 ) {
                    BEND103_tree = (CommonTree)adaptor.create(BEND103);
                    adaptor.addChild(root_0, BEND103_tree);
                    }

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(94, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "string");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "string"

    public static class t_coordinate_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_coordinate"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:96:1: t_coordinate : ( COORDINATE ( t_options )* '(' string ')' ( AT ( multioperator )? '(' (cs_name= string CS )? ( t_options )* t_list ')' )? -> ^( POINT ( t_list )? ( ^( NAME string ) )? ( ^( COORD_SYS $cs_name) )? ( t_options )? ( multioperator )? ) | ( multioperator )? '(' (cs_name= string CS )? ( t_options )* t_list ')' -> ^( POINT t_list ( t_options )? ( multioperator )? ) );
    public final TikzGrammarParser.t_coordinate_return t_coordinate() throws RecognitionException {
        TikzGrammarParser.t_coordinate_return retval = new TikzGrammarParser.t_coordinate_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token COORDINATE104=null;
        Token char_literal106=null;
        Token char_literal108=null;
        Token AT109=null;
        Token char_literal111=null;
        Token CS112=null;
        Token char_literal115=null;
        Token char_literal117=null;
        Token CS118=null;
        Token char_literal121=null;
        TikzGrammarParser.string_return cs_name = null;

        TikzGrammarParser.t_options_return t_options105 = null;

        TikzGrammarParser.string_return string107 = null;

        TikzGrammarParser.multioperator_return multioperator110 = null;

        TikzGrammarParser.t_options_return t_options113 = null;

        TikzGrammarParser.t_list_return t_list114 = null;

        TikzGrammarParser.multioperator_return multioperator116 = null;

        TikzGrammarParser.t_options_return t_options119 = null;

        TikzGrammarParser.t_list_return t_list120 = null;


        CommonTree COORDINATE104_tree=null;
        CommonTree char_literal106_tree=null;
        CommonTree char_literal108_tree=null;
        CommonTree AT109_tree=null;
        CommonTree char_literal111_tree=null;
        CommonTree CS112_tree=null;
        CommonTree char_literal115_tree=null;
        CommonTree char_literal117_tree=null;
        CommonTree CS118_tree=null;
        CommonTree char_literal121_tree=null;
        RewriteRuleTokenStream stream_AT=new RewriteRuleTokenStream(adaptor,"token AT");
        RewriteRuleTokenStream stream_78=new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_77=new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_COORDINATE=new RewriteRuleTokenStream(adaptor,"token COORDINATE");
        RewriteRuleTokenStream stream_CS=new RewriteRuleTokenStream(adaptor,"token CS");
        RewriteRuleSubtreeStream stream_string=new RewriteRuleSubtreeStream(adaptor,"rule string");
        RewriteRuleSubtreeStream stream_multioperator=new RewriteRuleSubtreeStream(adaptor,"rule multioperator");
        RewriteRuleSubtreeStream stream_t_list=new RewriteRuleSubtreeStream(adaptor,"rule t_list");
        RewriteRuleSubtreeStream stream_t_options=new RewriteRuleSubtreeStream(adaptor,"rule t_options");
        try { dbg.enterRule(getGrammarFileName(), "t_coordinate");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(96, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:9: ( COORDINATE ( t_options )* '(' string ')' ( AT ( multioperator )? '(' (cs_name= string CS )? ( t_options )* t_list ')' )? -> ^( POINT ( t_list )? ( ^( NAME string ) )? ( ^( COORD_SYS $cs_name) )? ( t_options )? ( multioperator )? ) | ( multioperator )? '(' (cs_name= string CS )? ( t_options )* t_list ')' -> ^( POINT t_list ( t_options )? ( multioperator )? ) )
            int alt31=2;
            try { dbg.enterDecision(31);

            int LA31_0 = input.LA(1);

            if ( (LA31_0==COORDINATE) ) {
                alt31=1;
            }
            else if ( (LA31_0==OPERATOR||LA31_0==77) ) {
                alt31=2;
            }
            else {
                if (state.backtracking>0) {state.failed=true; return retval;}
                NoViableAltException nvae =
                    new NoViableAltException("", 31, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(31);}

            switch (alt31) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:17: COORDINATE ( t_options )* '(' string ')' ( AT ( multioperator )? '(' (cs_name= string CS )? ( t_options )* t_list ')' )?
                    {
                    dbg.location(97,17);
                    COORDINATE104=(Token)match(input,COORDINATE,FOLLOW_COORDINATE_in_t_coordinate1970); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_COORDINATE.add(COORDINATE104);

                    dbg.location(97,28);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:28: ( t_options )*
                    try { dbg.enterSubRule(23);

                    loop23:
                    do {
                        int alt23=2;
                        try { dbg.enterDecision(23);

                        int LA23_0 = input.LA(1);

                        if ( (LA23_0==79) ) {
                            alt23=1;
                        }


                        } finally {dbg.exitDecision(23);}

                        switch (alt23) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                    	    {
                    	    dbg.location(97,28);
                    	    pushFollow(FOLLOW_t_options_in_t_coordinate1972);
                    	    t_options105=t_options();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_options.add(t_options105.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop23;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(23);}

                    dbg.location(97,39);
                    char_literal106=(Token)match(input,77,FOLLOW_77_in_t_coordinate1975); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_77.add(char_literal106);

                    dbg.location(97,43);
                    pushFollow(FOLLOW_string_in_t_coordinate1977);
                    string107=string();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_string.add(string107.getTree());
                    dbg.location(97,50);
                    char_literal108=(Token)match(input,78,FOLLOW_78_in_t_coordinate1979); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_78.add(char_literal108);

                    dbg.location(97,54);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:54: ( AT ( multioperator )? '(' (cs_name= string CS )? ( t_options )* t_list ')' )?
                    int alt27=2;
                    try { dbg.enterSubRule(27);
                    try { dbg.enterDecision(27);

                    try {
                        isCyclicDecision = true;
                        alt27 = dfa27.predict(input);
                    }
                    catch (NoViableAltException nvae) {
                        dbg.recognitionException(nvae);
                        throw nvae;
                    }
                    } finally {dbg.exitDecision(27);}

                    switch (alt27) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:56: AT ( multioperator )? '(' (cs_name= string CS )? ( t_options )* t_list ')'
                            {
                            dbg.location(97,56);
                            AT109=(Token)match(input,AT,FOLLOW_AT_in_t_coordinate1983); if (state.failed) return retval; 
                            if ( state.backtracking==0 ) stream_AT.add(AT109);

                            dbg.location(97,59);
                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:59: ( multioperator )?
                            int alt24=2;
                            try { dbg.enterSubRule(24);
                            try { dbg.enterDecision(24);

                            int LA24_0 = input.LA(1);

                            if ( (LA24_0==OPERATOR) ) {
                                alt24=1;
                            }
                            } finally {dbg.exitDecision(24);}

                            switch (alt24) {
                                case 1 :
                                    dbg.enterAlt(1);

                                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: multioperator
                                    {
                                    dbg.location(97,59);
                                    pushFollow(FOLLOW_multioperator_in_t_coordinate1985);
                                    multioperator110=multioperator();

                                    state._fsp--;
                                    if (state.failed) return retval;
                                    if ( state.backtracking==0 ) stream_multioperator.add(multioperator110.getTree());

                                    }
                                    break;

                            }
                            } finally {dbg.exitSubRule(24);}

                            dbg.location(97,75);
                            char_literal111=(Token)match(input,77,FOLLOW_77_in_t_coordinate1989); if (state.failed) return retval; 
                            if ( state.backtracking==0 ) stream_77.add(char_literal111);

                            dbg.location(97,79);
                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:79: (cs_name= string CS )?
                            int alt25=2;
                            try { dbg.enterSubRule(25);
                            try { dbg.enterDecision(25);

                            try {
                                isCyclicDecision = true;
                                alt25 = dfa25.predict(input);
                            }
                            catch (NoViableAltException nvae) {
                                dbg.recognitionException(nvae);
                                throw nvae;
                            }
                            } finally {dbg.exitDecision(25);}

                            switch (alt25) {
                                case 1 :
                                    dbg.enterAlt(1);

                                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:81: cs_name= string CS
                                    {
                                    dbg.location(97,88);
                                    pushFollow(FOLLOW_string_in_t_coordinate1995);
                                    cs_name=string();

                                    state._fsp--;
                                    if (state.failed) return retval;
                                    if ( state.backtracking==0 ) stream_string.add(cs_name.getTree());
                                    dbg.location(97,96);
                                    CS112=(Token)match(input,CS,FOLLOW_CS_in_t_coordinate1997); if (state.failed) return retval; 
                                    if ( state.backtracking==0 ) stream_CS.add(CS112);


                                    }
                                    break;

                            }
                            } finally {dbg.exitSubRule(25);}

                            dbg.location(97,102);
                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:102: ( t_options )*
                            try { dbg.enterSubRule(26);

                            loop26:
                            do {
                                int alt26=2;
                                try { dbg.enterDecision(26);

                                int LA26_0 = input.LA(1);

                                if ( (LA26_0==79) ) {
                                    int LA26_2 = input.LA(2);

                                    if ( ((LA26_2>=BACKSLASH && LA26_2<=LINE)||LA26_2==74||LA26_2==77||LA26_2==79||(LA26_2>=81 && LA26_2<=82)) ) {
                                        alt26=1;
                                    }


                                }


                                } finally {dbg.exitDecision(26);}

                                switch (alt26) {
                            	case 1 :
                            	    dbg.enterAlt(1);

                            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                            	    {
                            	    dbg.location(97,102);
                            	    pushFollow(FOLLOW_t_options_in_t_coordinate2002);
                            	    t_options113=t_options();

                            	    state._fsp--;
                            	    if (state.failed) return retval;
                            	    if ( state.backtracking==0 ) stream_t_options.add(t_options113.getTree());

                            	    }
                            	    break;

                            	default :
                            	    break loop26;
                                }
                            } while (true);
                            } finally {dbg.exitSubRule(26);}

                            dbg.location(97,113);
                            pushFollow(FOLLOW_t_list_in_t_coordinate2005);
                            t_list114=t_list();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_list.add(t_list114.getTree());
                            dbg.location(97,120);
                            char_literal115=(Token)match(input,78,FOLLOW_78_in_t_coordinate2007); if (state.failed) return retval; 
                            if ( state.backtracking==0 ) stream_78.add(char_literal115);


                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(27);}



                    // AST REWRITE
                    // elements: multioperator, string, t_options, t_list, cs_name
                    // token labels: 
                    // rule labels: retval, cs_name
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);
                    RewriteRuleSubtreeStream stream_cs_name=new RewriteRuleSubtreeStream(adaptor,"rule cs_name",cs_name!=null?cs_name.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 98:9: -> ^( POINT ( t_list )? ( ^( NAME string ) )? ( ^( COORD_SYS $cs_name) )? ( t_options )? ( multioperator )? )
                    {
                        dbg.location(98,17);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:98:17: ^( POINT ( t_list )? ( ^( NAME string ) )? ( ^( COORD_SYS $cs_name) )? ( t_options )? ( multioperator )? )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(98,20);
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(POINT, "POINT"), root_1);

                        dbg.location(98,26);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:98:26: ( t_list )?
                        if ( stream_t_list.hasNext() ) {
                            dbg.location(98,26);
                            adaptor.addChild(root_1, stream_t_list.nextTree());

                        }
                        stream_t_list.reset();
                        dbg.location(98,35);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:98:35: ( ^( NAME string ) )?
                        if ( stream_string.hasNext() ) {
                            dbg.location(98,35);
                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:98:35: ^( NAME string )
                            {
                            CommonTree root_2 = (CommonTree)adaptor.nil();
                            dbg.location(98,38);
                            root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(NAME, "NAME"), root_2);

                            dbg.location(98,43);
                            adaptor.addChild(root_2, stream_string.nextTree());

                            adaptor.addChild(root_1, root_2);
                            }

                        }
                        stream_string.reset();
                        dbg.location(98,53);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:98:53: ( ^( COORD_SYS $cs_name) )?
                        if ( stream_cs_name.hasNext() ) {
                            dbg.location(98,53);
                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:98:53: ^( COORD_SYS $cs_name)
                            {
                            CommonTree root_2 = (CommonTree)adaptor.nil();
                            dbg.location(98,56);
                            root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(COORD_SYS, "COORD_SYS"), root_2);

                            dbg.location(98,66);
                            adaptor.addChild(root_2, stream_cs_name.nextTree());

                            adaptor.addChild(root_1, root_2);
                            }

                        }
                        stream_cs_name.reset();
                        dbg.location(98,78);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:98:78: ( t_options )?
                        if ( stream_t_options.hasNext() ) {
                            dbg.location(98,78);
                            adaptor.addChild(root_1, stream_t_options.nextTree());

                        }
                        stream_t_options.reset();
                        dbg.location(98,89);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:98:89: ( multioperator )?
                        if ( stream_multioperator.hasNext() ) {
                            dbg.location(98,89);
                            adaptor.addChild(root_1, stream_multioperator.nextTree());

                        }
                        stream_multioperator.reset();

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:99:17: ( multioperator )? '(' (cs_name= string CS )? ( t_options )* t_list ')'
                    {
                    dbg.location(99,17);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:99:17: ( multioperator )?
                    int alt28=2;
                    try { dbg.enterSubRule(28);
                    try { dbg.enterDecision(28);

                    int LA28_0 = input.LA(1);

                    if ( (LA28_0==OPERATOR) ) {
                        alt28=1;
                    }
                    } finally {dbg.exitDecision(28);}

                    switch (alt28) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: multioperator
                            {
                            dbg.location(99,17);
                            pushFollow(FOLLOW_multioperator_in_t_coordinate2078);
                            multioperator116=multioperator();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_multioperator.add(multioperator116.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(28);}

                    dbg.location(99,32);
                    char_literal117=(Token)match(input,77,FOLLOW_77_in_t_coordinate2081); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_77.add(char_literal117);

                    dbg.location(99,36);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:99:36: (cs_name= string CS )?
                    int alt29=2;
                    try { dbg.enterSubRule(29);
                    try { dbg.enterDecision(29);

                    try {
                        isCyclicDecision = true;
                        alt29 = dfa29.predict(input);
                    }
                    catch (NoViableAltException nvae) {
                        dbg.recognitionException(nvae);
                        throw nvae;
                    }
                    } finally {dbg.exitDecision(29);}

                    switch (alt29) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:99:38: cs_name= string CS
                            {
                            dbg.location(99,45);
                            pushFollow(FOLLOW_string_in_t_coordinate2087);
                            cs_name=string();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_string.add(cs_name.getTree());
                            dbg.location(99,53);
                            CS118=(Token)match(input,CS,FOLLOW_CS_in_t_coordinate2089); if (state.failed) return retval; 
                            if ( state.backtracking==0 ) stream_CS.add(CS118);


                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(29);}

                    dbg.location(99,59);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:99:59: ( t_options )*
                    try { dbg.enterSubRule(30);

                    loop30:
                    do {
                        int alt30=2;
                        try { dbg.enterDecision(30);

                        int LA30_0 = input.LA(1);

                        if ( (LA30_0==79) ) {
                            int LA30_2 = input.LA(2);

                            if ( ((LA30_2>=BACKSLASH && LA30_2<=LINE)||LA30_2==74||LA30_2==77||LA30_2==79||(LA30_2>=81 && LA30_2<=82)) ) {
                                alt30=1;
                            }


                        }


                        } finally {dbg.exitDecision(30);}

                        switch (alt30) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                    	    {
                    	    dbg.location(99,59);
                    	    pushFollow(FOLLOW_t_options_in_t_coordinate2094);
                    	    t_options119=t_options();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_options.add(t_options119.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop30;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(30);}

                    dbg.location(99,70);
                    pushFollow(FOLLOW_t_list_in_t_coordinate2097);
                    t_list120=t_list();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_list.add(t_list120.getTree());
                    dbg.location(99,77);
                    char_literal121=(Token)match(input,78,FOLLOW_78_in_t_coordinate2099); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_78.add(char_literal121);



                    // AST REWRITE
                    // elements: t_list, multioperator, t_options
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 100:9: -> ^( POINT t_list ( t_options )? ( multioperator )? )
                    {
                        dbg.location(100,17);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:100:17: ^( POINT t_list ( t_options )? ( multioperator )? )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(100,20);
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(POINT, "POINT"), root_1);

                        dbg.location(100,26);
                        adaptor.addChild(root_1, stream_t_list.nextTree());
                        dbg.location(100,33);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:100:33: ( t_options )?
                        if ( stream_t_options.hasNext() ) {
                            dbg.location(100,33);
                            adaptor.addChild(root_1, stream_t_options.nextTree());

                        }
                        stream_t_options.reset();
                        dbg.location(100,44);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:100:44: ( multioperator )?
                        if ( stream_multioperator.hasNext() ) {
                            dbg.location(100,44);
                            adaptor.addChild(root_1, stream_multioperator.nextTree());

                        }
                        stream_multioperator.reset();

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(101, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_coordinate");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_coordinate"

    public static class t_moveto_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_moveto"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:103:1: t_moveto : t_coordinate -> ^( MOVETO t_coordinate ) ;
    public final TikzGrammarParser.t_moveto_return t_moveto() throws RecognitionException {
        TikzGrammarParser.t_moveto_return retval = new TikzGrammarParser.t_moveto_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        TikzGrammarParser.t_coordinate_return t_coordinate122 = null;


        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        try { dbg.enterRule(getGrammarFileName(), "t_moveto");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(103, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:103:9: ( t_coordinate -> ^( MOVETO t_coordinate ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:103:17: t_coordinate
            {
            dbg.location(103,17);
            pushFollow(FOLLOW_t_coordinate_in_t_moveto2165);
            t_coordinate122=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate122.getTree());


            // AST REWRITE
            // elements: t_coordinate
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 104:9: -> ^( MOVETO t_coordinate )
            {
                dbg.location(104,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:104:17: ^( MOVETO t_coordinate )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(104,20);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(MOVETO, "MOVETO"), root_1);

                dbg.location(104,27);
                adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(105, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_moveto");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_moveto"

    public static class t_lineto_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_lineto"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:108:1: t_lineto : LINE t_coordinate -> ^( LINETO t_coordinate ) ;
    public final TikzGrammarParser.t_lineto_return t_lineto() throws RecognitionException {
        TikzGrammarParser.t_lineto_return retval = new TikzGrammarParser.t_lineto_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token LINE123=null;
        TikzGrammarParser.t_coordinate_return t_coordinate124 = null;


        CommonTree LINE123_tree=null;
        RewriteRuleTokenStream stream_LINE=new RewriteRuleTokenStream(adaptor,"token LINE");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        try { dbg.enterRule(getGrammarFileName(), "t_lineto");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(108, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:108:9: ( LINE t_coordinate -> ^( LINETO t_coordinate ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:108:17: LINE t_coordinate
            {
            dbg.location(108,17);
            LINE123=(Token)match(input,LINE,FOLLOW_LINE_in_t_lineto2211); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_LINE.add(LINE123);

            dbg.location(108,22);
            pushFollow(FOLLOW_t_coordinate_in_t_lineto2213);
            t_coordinate124=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate124.getTree());


            // AST REWRITE
            // elements: t_coordinate
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 109:9: -> ^( LINETO t_coordinate )
            {
                dbg.location(109,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:109:17: ^( LINETO t_coordinate )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(109,20);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(LINETO, "LINETO"), root_1);

                dbg.location(109,27);
                adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(110, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_lineto");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_lineto"

    public static class t_lineto_hv_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_lineto_hv"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:112:1: t_lineto_hv : HVLINE t_coordinate -> ^( LINETOHV t_coordinate ) ;
    public final TikzGrammarParser.t_lineto_hv_return t_lineto_hv() throws RecognitionException {
        TikzGrammarParser.t_lineto_hv_return retval = new TikzGrammarParser.t_lineto_hv_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token HVLINE125=null;
        TikzGrammarParser.t_coordinate_return t_coordinate126 = null;


        CommonTree HVLINE125_tree=null;
        RewriteRuleTokenStream stream_HVLINE=new RewriteRuleTokenStream(adaptor,"token HVLINE");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        try { dbg.enterRule(getGrammarFileName(), "t_lineto_hv");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(112, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:113:9: ( HVLINE t_coordinate -> ^( LINETOHV t_coordinate ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:113:17: HVLINE t_coordinate
            {
            dbg.location(113,17);
            HVLINE125=(Token)match(input,HVLINE,FOLLOW_HVLINE_in_t_lineto_hv2267); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_HVLINE.add(HVLINE125);

            dbg.location(113,24);
            pushFollow(FOLLOW_t_coordinate_in_t_lineto_hv2269);
            t_coordinate126=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate126.getTree());


            // AST REWRITE
            // elements: t_coordinate
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 114:9: -> ^( LINETOHV t_coordinate )
            {
                dbg.location(114,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:114:17: ^( LINETOHV t_coordinate )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(114,20);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(LINETOHV, "LINETOHV"), root_1);

                dbg.location(114,29);
                adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(115, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_lineto_hv");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_lineto_hv"

    public static class t_lineto_vh_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_lineto_vh"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:117:1: t_lineto_vh : VHLINE t_coordinate -> ^( LINETOVH t_coordinate ) ;
    public final TikzGrammarParser.t_lineto_vh_return t_lineto_vh() throws RecognitionException {
        TikzGrammarParser.t_lineto_vh_return retval = new TikzGrammarParser.t_lineto_vh_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token VHLINE127=null;
        TikzGrammarParser.t_coordinate_return t_coordinate128 = null;


        CommonTree VHLINE127_tree=null;
        RewriteRuleTokenStream stream_VHLINE=new RewriteRuleTokenStream(adaptor,"token VHLINE");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        try { dbg.enterRule(getGrammarFileName(), "t_lineto_vh");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(117, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:118:9: ( VHLINE t_coordinate -> ^( LINETOVH t_coordinate ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:118:17: VHLINE t_coordinate
            {
            dbg.location(118,17);
            VHLINE127=(Token)match(input,VHLINE,FOLLOW_VHLINE_in_t_lineto_vh2331); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_VHLINE.add(VHLINE127);

            dbg.location(118,24);
            pushFollow(FOLLOW_t_coordinate_in_t_lineto_vh2333);
            t_coordinate128=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate128.getTree());


            // AST REWRITE
            // elements: t_coordinate
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 119:9: -> ^( LINETOVH t_coordinate )
            {
                dbg.location(119,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:119:17: ^( LINETOVH t_coordinate )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(119,20);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(LINETOVH, "LINETOVH"), root_1);

                dbg.location(119,29);
                adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(120, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_lineto_vh");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_lineto_vh"

    public static class t_cycle_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_cycle"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:122:1: t_cycle : LINE CYCLE -> CYCLE ;
    public final TikzGrammarParser.t_cycle_return t_cycle() throws RecognitionException {
        TikzGrammarParser.t_cycle_return retval = new TikzGrammarParser.t_cycle_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token LINE129=null;
        Token CYCLE130=null;

        CommonTree LINE129_tree=null;
        CommonTree CYCLE130_tree=null;
        RewriteRuleTokenStream stream_LINE=new RewriteRuleTokenStream(adaptor,"token LINE");
        RewriteRuleTokenStream stream_CYCLE=new RewriteRuleTokenStream(adaptor,"token CYCLE");

        try { dbg.enterRule(getGrammarFileName(), "t_cycle");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(122, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:122:9: ( LINE CYCLE -> CYCLE )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:122:17: LINE CYCLE
            {
            dbg.location(122,17);
            LINE129=(Token)match(input,LINE,FOLLOW_LINE_in_t_cycle2387); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_LINE.add(LINE129);

            dbg.location(122,22);
            CYCLE130=(Token)match(input,CYCLE,FOLLOW_CYCLE_in_t_cycle2389); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_CYCLE.add(CYCLE130);



            // AST REWRITE
            // elements: CYCLE
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 123:9: -> CYCLE
            {
                dbg.location(123,17);
                adaptor.addChild(root_0, stream_CYCLE.nextNode());

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(124, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_cycle");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_cycle"

    public static class t_to_path_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_to_path"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:126:1: t_to_path : ( TO ( t_options )? t_coordinate -> ^( PATH_CONSTRUCTION ( t_options )? t_coordinate ) | TO ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )? -> ^( PATH_CONSTRUCTION ( t_options )? ^( NODE ( t_options )? curly_brackets t_coordinate ) ) );
    public final TikzGrammarParser.t_to_path_return t_to_path() throws RecognitionException {
        TikzGrammarParser.t_to_path_return retval = new TikzGrammarParser.t_to_path_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token TO131=null;
        Token TO134=null;
        Token NODE136=null;
        TikzGrammarParser.t_options_return t_options132 = null;

        TikzGrammarParser.t_coordinate_return t_coordinate133 = null;

        TikzGrammarParser.t_options_return t_options135 = null;

        TikzGrammarParser.t_options_return t_options137 = null;

        TikzGrammarParser.curly_brackets_return curly_brackets138 = null;

        TikzGrammarParser.t_coordinate_return t_coordinate139 = null;


        CommonTree TO131_tree=null;
        CommonTree TO134_tree=null;
        CommonTree NODE136_tree=null;
        RewriteRuleTokenStream stream_NODE=new RewriteRuleTokenStream(adaptor,"token NODE");
        RewriteRuleTokenStream stream_TO=new RewriteRuleTokenStream(adaptor,"token TO");
        RewriteRuleSubtreeStream stream_curly_brackets=new RewriteRuleSubtreeStream(adaptor,"rule curly_brackets");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        RewriteRuleSubtreeStream stream_t_options=new RewriteRuleSubtreeStream(adaptor,"rule t_options");
        try { dbg.enterRule(getGrammarFileName(), "t_to_path");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(126, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:127:9: ( TO ( t_options )? t_coordinate -> ^( PATH_CONSTRUCTION ( t_options )? t_coordinate ) | TO ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )? -> ^( PATH_CONSTRUCTION ( t_options )? ^( NODE ( t_options )? curly_brackets t_coordinate ) ) )
            int alt36=2;
            try { dbg.enterDecision(36);

            int LA36_0 = input.LA(1);

            if ( (LA36_0==TO) ) {
                int LA36_1 = input.LA(2);

                if ( (synpred115_TikzGrammar()) ) {
                    alt36=1;
                }
                else if ( (true) ) {
                    alt36=2;
                }
                else {
                    if (state.backtracking>0) {state.failed=true; return retval;}
                    NoViableAltException nvae =
                        new NoViableAltException("", 36, 1, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
            }
            else {
                if (state.backtracking>0) {state.failed=true; return retval;}
                NoViableAltException nvae =
                    new NoViableAltException("", 36, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(36);}

            switch (alt36) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:127:17: TO ( t_options )? t_coordinate
                    {
                    dbg.location(127,17);
                    TO131=(Token)match(input,TO,FOLLOW_TO_in_t_to_path2444); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_TO.add(TO131);

                    dbg.location(127,20);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:127:20: ( t_options )?
                    int alt32=2;
                    try { dbg.enterSubRule(32);
                    try { dbg.enterDecision(32);

                    int LA32_0 = input.LA(1);

                    if ( (LA32_0==79) ) {
                        alt32=1;
                    }
                    } finally {dbg.exitDecision(32);}

                    switch (alt32) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                            {
                            dbg.location(127,20);
                            pushFollow(FOLLOW_t_options_in_t_to_path2446);
                            t_options132=t_options();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_options.add(t_options132.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(32);}

                    dbg.location(127,31);
                    pushFollow(FOLLOW_t_coordinate_in_t_to_path2449);
                    t_coordinate133=t_coordinate();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate133.getTree());


                    // AST REWRITE
                    // elements: t_coordinate, t_options
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 128:9: -> ^( PATH_CONSTRUCTION ( t_options )? t_coordinate )
                    {
                        dbg.location(128,17);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:128:17: ^( PATH_CONSTRUCTION ( t_options )? t_coordinate )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(128,20);
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(PATH_CONSTRUCTION, "PATH_CONSTRUCTION"), root_1);

                        dbg.location(128,38);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:128:38: ( t_options )?
                        if ( stream_t_options.hasNext() ) {
                            dbg.location(128,38);
                            adaptor.addChild(root_1, stream_t_options.nextTree());

                        }
                        stream_t_options.reset();
                        dbg.location(128,49);
                        adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:129:17: TO ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )?
                    {
                    dbg.location(129,17);
                    TO134=(Token)match(input,TO,FOLLOW_TO_in_t_to_path2493); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_TO.add(TO134);

                    dbg.location(129,20);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:129:20: ( t_options )?
                    int alt33=2;
                    try { dbg.enterSubRule(33);
                    try { dbg.enterDecision(33);

                    int LA33_0 = input.LA(1);

                    if ( (LA33_0==79) ) {
                        alt33=1;
                    }
                    } finally {dbg.exitDecision(33);}

                    switch (alt33) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                            {
                            dbg.location(129,20);
                            pushFollow(FOLLOW_t_options_in_t_to_path2495);
                            t_options135=t_options();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_options.add(t_options135.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(33);}

                    dbg.location(129,31);
                    NODE136=(Token)match(input,NODE,FOLLOW_NODE_in_t_to_path2498); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_NODE.add(NODE136);

                    dbg.location(129,36);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:129:36: ( t_options )?
                    int alt34=2;
                    try { dbg.enterSubRule(34);
                    try { dbg.enterDecision(34);

                    int LA34_0 = input.LA(1);

                    if ( (LA34_0==79) ) {
                        alt34=1;
                    }
                    } finally {dbg.exitDecision(34);}

                    switch (alt34) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                            {
                            dbg.location(129,36);
                            pushFollow(FOLLOW_t_options_in_t_to_path2500);
                            t_options137=t_options();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_options.add(t_options137.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(34);}

                    dbg.location(129,47);
                    pushFollow(FOLLOW_curly_brackets_in_t_to_path2503);
                    curly_brackets138=curly_brackets();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_curly_brackets.add(curly_brackets138.getTree());
                    dbg.location(129,62);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:129:62: ( t_coordinate )?
                    int alt35=2;
                    try { dbg.enterSubRule(35);
                    try { dbg.enterDecision(35);

                    try {
                        isCyclicDecision = true;
                        alt35 = dfa35.predict(input);
                    }
                    catch (NoViableAltException nvae) {
                        dbg.recognitionException(nvae);
                        throw nvae;
                    }
                    } finally {dbg.exitDecision(35);}

                    switch (alt35) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_coordinate
                            {
                            dbg.location(129,62);
                            pushFollow(FOLLOW_t_coordinate_in_t_to_path2505);
                            t_coordinate139=t_coordinate();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate139.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(35);}



                    // AST REWRITE
                    // elements: t_coordinate, t_options, t_options, NODE, curly_brackets
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 130:9: -> ^( PATH_CONSTRUCTION ( t_options )? ^( NODE ( t_options )? curly_brackets t_coordinate ) )
                    {
                        dbg.location(130,17);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:130:17: ^( PATH_CONSTRUCTION ( t_options )? ^( NODE ( t_options )? curly_brackets t_coordinate ) )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(130,20);
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(PATH_CONSTRUCTION, "PATH_CONSTRUCTION"), root_1);

                        dbg.location(130,38);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:130:38: ( t_options )?
                        if ( stream_t_options.hasNext() ) {
                            dbg.location(130,38);
                            adaptor.addChild(root_1, stream_t_options.nextTree());

                        }
                        stream_t_options.reset();
                        dbg.location(130,49);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:130:49: ^( NODE ( t_options )? curly_brackets t_coordinate )
                        {
                        CommonTree root_2 = (CommonTree)adaptor.nil();
                        dbg.location(130,51);
                        root_2 = (CommonTree)adaptor.becomeRoot(stream_NODE.nextNode(), root_2);

                        dbg.location(130,56);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:130:56: ( t_options )?
                        if ( stream_t_options.hasNext() ) {
                            dbg.location(130,56);
                            adaptor.addChild(root_2, stream_t_options.nextTree());

                        }
                        stream_t_options.reset();
                        dbg.location(130,67);
                        adaptor.addChild(root_2, stream_curly_brackets.nextTree());
                        dbg.location(130,82);
                        adaptor.addChild(root_2, stream_t_coordinate.nextTree());

                        adaptor.addChild(root_1, root_2);
                        }

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(131, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_to_path");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_to_path"

    public static class t_node_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_node"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:1: t_node : NODE ( t_options )* ( '(' string ')' )? ( AT t_coordinate )? ( t_options )* curly_brackets ( CHILD )* -> ^( NODE ( t_options )* ( ^( NAME string ) )? ( t_coordinate )? curly_brackets ( CHILD )* ) ;
    public final TikzGrammarParser.t_node_return t_node() throws RecognitionException {
        TikzGrammarParser.t_node_return retval = new TikzGrammarParser.t_node_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token NODE140=null;
        Token char_literal142=null;
        Token char_literal144=null;
        Token AT145=null;
        Token CHILD149=null;
        TikzGrammarParser.t_options_return t_options141 = null;

        TikzGrammarParser.string_return string143 = null;

        TikzGrammarParser.t_coordinate_return t_coordinate146 = null;

        TikzGrammarParser.t_options_return t_options147 = null;

        TikzGrammarParser.curly_brackets_return curly_brackets148 = null;


        CommonTree NODE140_tree=null;
        CommonTree char_literal142_tree=null;
        CommonTree char_literal144_tree=null;
        CommonTree AT145_tree=null;
        CommonTree CHILD149_tree=null;
        RewriteRuleTokenStream stream_AT=new RewriteRuleTokenStream(adaptor,"token AT");
        RewriteRuleTokenStream stream_CHILD=new RewriteRuleTokenStream(adaptor,"token CHILD");
        RewriteRuleTokenStream stream_78=new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_77=new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_NODE=new RewriteRuleTokenStream(adaptor,"token NODE");
        RewriteRuleSubtreeStream stream_curly_brackets=new RewriteRuleSubtreeStream(adaptor,"rule curly_brackets");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        RewriteRuleSubtreeStream stream_string=new RewriteRuleSubtreeStream(adaptor,"rule string");
        RewriteRuleSubtreeStream stream_t_options=new RewriteRuleSubtreeStream(adaptor,"rule t_options");
        try { dbg.enterRule(getGrammarFileName(), "t_node");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(138, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:9: ( NODE ( t_options )* ( '(' string ')' )? ( AT t_coordinate )? ( t_options )* curly_brackets ( CHILD )* -> ^( NODE ( t_options )* ( ^( NAME string ) )? ( t_coordinate )? curly_brackets ( CHILD )* ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:17: NODE ( t_options )* ( '(' string ')' )? ( AT t_coordinate )? ( t_options )* curly_brackets ( CHILD )*
            {
            dbg.location(138,17);
            NODE140=(Token)match(input,NODE,FOLLOW_NODE_in_t_node2568); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_NODE.add(NODE140);

            dbg.location(138,22);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:22: ( t_options )*
            try { dbg.enterSubRule(37);

            loop37:
            do {
                int alt37=2;
                try { dbg.enterDecision(37);

                int LA37_0 = input.LA(1);

                if ( (LA37_0==79) ) {
                    int LA37_3 = input.LA(2);

                    if ( (synpred119_TikzGrammar()) ) {
                        alt37=1;
                    }


                }


                } finally {dbg.exitDecision(37);}

                switch (alt37) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
            	    {
            	    dbg.location(138,22);
            	    pushFollow(FOLLOW_t_options_in_t_node2570);
            	    t_options141=t_options();

            	    state._fsp--;
            	    if (state.failed) return retval;
            	    if ( state.backtracking==0 ) stream_t_options.add(t_options141.getTree());

            	    }
            	    break;

            	default :
            	    break loop37;
                }
            } while (true);
            } finally {dbg.exitSubRule(37);}

            dbg.location(138,33);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:33: ( '(' string ')' )?
            int alt38=2;
            try { dbg.enterSubRule(38);
            try { dbg.enterDecision(38);

            int LA38_0 = input.LA(1);

            if ( (LA38_0==77) ) {
                alt38=1;
            }
            } finally {dbg.exitDecision(38);}

            switch (alt38) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:35: '(' string ')'
                    {
                    dbg.location(138,35);
                    char_literal142=(Token)match(input,77,FOLLOW_77_in_t_node2575); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_77.add(char_literal142);

                    dbg.location(138,39);
                    pushFollow(FOLLOW_string_in_t_node2577);
                    string143=string();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_string.add(string143.getTree());
                    dbg.location(138,46);
                    char_literal144=(Token)match(input,78,FOLLOW_78_in_t_node2579); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_78.add(char_literal144);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(38);}

            dbg.location(138,52);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:52: ( AT t_coordinate )?
            int alt39=2;
            try { dbg.enterSubRule(39);
            try { dbg.enterDecision(39);

            int LA39_0 = input.LA(1);

            if ( (LA39_0==AT) ) {
                alt39=1;
            }
            } finally {dbg.exitDecision(39);}

            switch (alt39) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:53: AT t_coordinate
                    {
                    dbg.location(138,53);
                    AT145=(Token)match(input,AT,FOLLOW_AT_in_t_node2584); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_AT.add(AT145);

                    dbg.location(138,56);
                    pushFollow(FOLLOW_t_coordinate_in_t_node2586);
                    t_coordinate146=t_coordinate();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate146.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(39);}

            dbg.location(138,71);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:71: ( t_options )*
            try { dbg.enterSubRule(40);

            loop40:
            do {
                int alt40=2;
                try { dbg.enterDecision(40);

                int LA40_0 = input.LA(1);

                if ( (LA40_0==79) ) {
                    alt40=1;
                }


                } finally {dbg.exitDecision(40);}

                switch (alt40) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
            	    {
            	    dbg.location(138,71);
            	    pushFollow(FOLLOW_t_options_in_t_node2590);
            	    t_options147=t_options();

            	    state._fsp--;
            	    if (state.failed) return retval;
            	    if ( state.backtracking==0 ) stream_t_options.add(t_options147.getTree());

            	    }
            	    break;

            	default :
            	    break loop40;
                }
            } while (true);
            } finally {dbg.exitSubRule(40);}

            dbg.location(138,82);
            pushFollow(FOLLOW_curly_brackets_in_t_node2593);
            curly_brackets148=curly_brackets();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_curly_brackets.add(curly_brackets148.getTree());
            dbg.location(138,97);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:97: ( CHILD )*
            try { dbg.enterSubRule(41);

            loop41:
            do {
                int alt41=2;
                try { dbg.enterDecision(41);

                int LA41_0 = input.LA(1);

                if ( (LA41_0==CHILD) ) {
                    int LA41_2 = input.LA(2);

                    if ( (synpred123_TikzGrammar()) ) {
                        alt41=1;
                    }


                }


                } finally {dbg.exitDecision(41);}

                switch (alt41) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: CHILD
            	    {
            	    dbg.location(138,97);
            	    CHILD149=(Token)match(input,CHILD,FOLLOW_CHILD_in_t_node2595); if (state.failed) return retval; 
            	    if ( state.backtracking==0 ) stream_CHILD.add(CHILD149);


            	    }
            	    break;

            	default :
            	    break loop41;
                }
            } while (true);
            } finally {dbg.exitSubRule(41);}



            // AST REWRITE
            // elements: t_coordinate, t_options, curly_brackets, CHILD, string, NODE
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 139:9: -> ^( NODE ( t_options )* ( ^( NAME string ) )? ( t_coordinate )? curly_brackets ( CHILD )* )
            {
                dbg.location(139,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:139:17: ^( NODE ( t_options )* ( ^( NAME string ) )? ( t_coordinate )? curly_brackets ( CHILD )* )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(139,19);
                root_1 = (CommonTree)adaptor.becomeRoot(stream_NODE.nextNode(), root_1);

                dbg.location(139,24);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:139:24: ( t_options )*
                while ( stream_t_options.hasNext() ) {
                    dbg.location(139,24);
                    adaptor.addChild(root_1, stream_t_options.nextTree());

                }
                stream_t_options.reset();
                dbg.location(139,35);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:139:35: ( ^( NAME string ) )?
                if ( stream_string.hasNext() ) {
                    dbg.location(139,35);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:139:35: ^( NAME string )
                    {
                    CommonTree root_2 = (CommonTree)adaptor.nil();
                    dbg.location(139,37);
                    root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(NAME, "NAME"), root_2);

                    dbg.location(139,42);
                    adaptor.addChild(root_2, stream_string.nextTree());

                    adaptor.addChild(root_1, root_2);
                    }

                }
                stream_string.reset();
                dbg.location(139,51);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:139:51: ( t_coordinate )?
                if ( stream_t_coordinate.hasNext() ) {
                    dbg.location(139,51);
                    adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                }
                stream_t_coordinate.reset();
                dbg.location(139,65);
                adaptor.addChild(root_1, stream_curly_brackets.nextTree());
                dbg.location(139,80);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:139:80: ( CHILD )*
                while ( stream_CHILD.hasNext() ) {
                    dbg.location(139,80);
                    adaptor.addChild(root_1, stream_CHILD.nextNode());

                }
                stream_CHILD.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(140, 17);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_node");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_node"

    public static class t_child_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_child"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:142:1: t_child : CHILD ( t_options )? (block= ( t_foreach | curly_brackets ) )? -> ^( CHILD ( t_options )? $block) ;
    public final TikzGrammarParser.t_child_return t_child() throws RecognitionException {
        TikzGrammarParser.t_child_return retval = new TikzGrammarParser.t_child_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token block=null;
        Token CHILD150=null;
        TikzGrammarParser.t_options_return t_options151 = null;

        TikzGrammarParser.t_foreach_return t_foreach152 = null;

        TikzGrammarParser.curly_brackets_return curly_brackets153 = null;


        CommonTree block_tree=null;
        CommonTree CHILD150_tree=null;
        RewriteRuleTokenStream stream_CHILD=new RewriteRuleTokenStream(adaptor,"token CHILD");
        RewriteRuleSubtreeStream stream_curly_brackets=new RewriteRuleSubtreeStream(adaptor,"rule curly_brackets");
        RewriteRuleSubtreeStream stream_t_foreach=new RewriteRuleSubtreeStream(adaptor,"rule t_foreach");
        RewriteRuleSubtreeStream stream_t_options=new RewriteRuleSubtreeStream(adaptor,"rule t_options");
        try { dbg.enterRule(getGrammarFileName(), "t_child");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(142, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:142:9: ( CHILD ( t_options )? (block= ( t_foreach | curly_brackets ) )? -> ^( CHILD ( t_options )? $block) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:142:17: CHILD ( t_options )? (block= ( t_foreach | curly_brackets ) )?
            {
            dbg.location(142,17);
            CHILD150=(Token)match(input,CHILD,FOLLOW_CHILD_in_t_child2688); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_CHILD.add(CHILD150);

            dbg.location(142,23);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:142:23: ( t_options )?
            int alt42=2;
            try { dbg.enterSubRule(42);
            try { dbg.enterDecision(42);

            int LA42_0 = input.LA(1);

            if ( (LA42_0==79) ) {
                alt42=1;
            }
            } finally {dbg.exitDecision(42);}

            switch (alt42) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                    {
                    dbg.location(142,23);
                    pushFollow(FOLLOW_t_options_in_t_child2690);
                    t_options151=t_options();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_options.add(t_options151.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(42);}

            dbg.location(142,39);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:142:39: (block= ( t_foreach | curly_brackets ) )?
            int alt44=2;
            try { dbg.enterSubRule(44);
            try { dbg.enterDecision(44);

            int LA44_0 = input.LA(1);

            if ( (LA44_0==FOREACH||LA44_0==74) ) {
                alt44=1;
            }
            } finally {dbg.exitDecision(44);}

            switch (alt44) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: block= ( t_foreach | curly_brackets )
                    {
                    dbg.location(142,39);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:142:40: ( t_foreach | curly_brackets )
                    int alt43=2;
                    try { dbg.enterSubRule(43);
                    try { dbg.enterDecision(43);

                    int LA43_0 = input.LA(1);

                    if ( (LA43_0==FOREACH) ) {
                        alt43=1;
                    }
                    else if ( (LA43_0==74) ) {
                        alt43=2;
                    }
                    else {
                        if (state.backtracking>0) {state.failed=true; return retval;}
                        NoViableAltException nvae =
                            new NoViableAltException("", 43, 0, input);

                        dbg.recognitionException(nvae);
                        throw nvae;
                    }
                    } finally {dbg.exitDecision(43);}

                    switch (alt43) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:142:42: t_foreach
                            {
                            dbg.location(142,42);
                            pushFollow(FOLLOW_t_foreach_in_t_child2697);
                            t_foreach152=t_foreach();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_foreach.add(t_foreach152.getTree());

                            }
                            break;
                        case 2 :
                            dbg.enterAlt(2);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:142:54: curly_brackets
                            {
                            dbg.location(142,54);
                            pushFollow(FOLLOW_curly_brackets_in_t_child2701);
                            curly_brackets153=curly_brackets();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_curly_brackets.add(curly_brackets153.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(43);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(44);}



            // AST REWRITE
            // elements: CHILD, t_options, block
            // token labels: block
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleTokenStream stream_block=new RewriteRuleTokenStream(adaptor,"token block",block);
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 143:9: -> ^( CHILD ( t_options )? $block)
            {
                dbg.location(143,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:143:17: ^( CHILD ( t_options )? $block)
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(143,19);
                root_1 = (CommonTree)adaptor.becomeRoot(stream_CHILD.nextNode(), root_1);

                dbg.location(143,25);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:143:25: ( t_options )?
                if ( stream_t_options.hasNext() ) {
                    dbg.location(143,25);
                    adaptor.addChild(root_1, stream_t_options.nextTree());

                }
                stream_t_options.reset();
                dbg.location(143,36);
                adaptor.addChild(root_1, stream_block.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(144, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_child");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_child"

    public static class t_foreach_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_foreach"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:146:1: t_foreach : FOREACH BACKSLASH string IN '{' t_list '}' ( curly_brackets | t_macro ) -> ^( FOREACH ^( VARNAME string ) t_list ( curly_brackets )? ( t_macro )? ) ;
    public final TikzGrammarParser.t_foreach_return t_foreach() throws RecognitionException {
        TikzGrammarParser.t_foreach_return retval = new TikzGrammarParser.t_foreach_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token FOREACH154=null;
        Token BACKSLASH155=null;
        Token IN157=null;
        Token char_literal158=null;
        Token char_literal160=null;
        TikzGrammarParser.string_return string156 = null;

        TikzGrammarParser.t_list_return t_list159 = null;

        TikzGrammarParser.curly_brackets_return curly_brackets161 = null;

        TikzGrammarParser.t_macro_return t_macro162 = null;


        CommonTree FOREACH154_tree=null;
        CommonTree BACKSLASH155_tree=null;
        CommonTree IN157_tree=null;
        CommonTree char_literal158_tree=null;
        CommonTree char_literal160_tree=null;
        RewriteRuleTokenStream stream_FOREACH=new RewriteRuleTokenStream(adaptor,"token FOREACH");
        RewriteRuleTokenStream stream_IN=new RewriteRuleTokenStream(adaptor,"token IN");
        RewriteRuleTokenStream stream_74=new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleTokenStream stream_75=new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleTokenStream stream_BACKSLASH=new RewriteRuleTokenStream(adaptor,"token BACKSLASH");
        RewriteRuleSubtreeStream stream_curly_brackets=new RewriteRuleSubtreeStream(adaptor,"rule curly_brackets");
        RewriteRuleSubtreeStream stream_string=new RewriteRuleSubtreeStream(adaptor,"rule string");
        RewriteRuleSubtreeStream stream_t_list=new RewriteRuleSubtreeStream(adaptor,"rule t_list");
        RewriteRuleSubtreeStream stream_t_macro=new RewriteRuleSubtreeStream(adaptor,"rule t_macro");
        try { dbg.enterRule(getGrammarFileName(), "t_foreach");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(146, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:147:9: ( FOREACH BACKSLASH string IN '{' t_list '}' ( curly_brackets | t_macro ) -> ^( FOREACH ^( VARNAME string ) t_list ( curly_brackets )? ( t_macro )? ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:147:17: FOREACH BACKSLASH string IN '{' t_list '}' ( curly_brackets | t_macro )
            {
            dbg.location(147,17);
            FOREACH154=(Token)match(input,FOREACH,FOLLOW_FOREACH_in_t_foreach2761); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_FOREACH.add(FOREACH154);

            dbg.location(147,26);
            BACKSLASH155=(Token)match(input,BACKSLASH,FOLLOW_BACKSLASH_in_t_foreach2764); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_BACKSLASH.add(BACKSLASH155);

            dbg.location(147,36);
            pushFollow(FOLLOW_string_in_t_foreach2766);
            string156=string();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_string.add(string156.getTree());
            dbg.location(147,43);
            IN157=(Token)match(input,IN,FOLLOW_IN_in_t_foreach2768); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_IN.add(IN157);

            dbg.location(147,46);
            char_literal158=(Token)match(input,74,FOLLOW_74_in_t_foreach2770); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_74.add(char_literal158);

            dbg.location(147,50);
            pushFollow(FOLLOW_t_list_in_t_foreach2772);
            t_list159=t_list();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_list.add(t_list159.getTree());
            dbg.location(147,57);
            char_literal160=(Token)match(input,75,FOLLOW_75_in_t_foreach2774); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_75.add(char_literal160);

            dbg.location(147,61);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:147:61: ( curly_brackets | t_macro )
            int alt45=2;
            try { dbg.enterSubRule(45);
            try { dbg.enterDecision(45);

            int LA45_0 = input.LA(1);

            if ( (LA45_0==74) ) {
                alt45=1;
            }
            else if ( (LA45_0==BACKSLASH) ) {
                alt45=2;
            }
            else {
                if (state.backtracking>0) {state.failed=true; return retval;}
                NoViableAltException nvae =
                    new NoViableAltException("", 45, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(45);}

            switch (alt45) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:147:63: curly_brackets
                    {
                    dbg.location(147,63);
                    pushFollow(FOLLOW_curly_brackets_in_t_foreach2778);
                    curly_brackets161=curly_brackets();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_curly_brackets.add(curly_brackets161.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:147:80: t_macro
                    {
                    dbg.location(147,80);
                    pushFollow(FOLLOW_t_macro_in_t_foreach2782);
                    t_macro162=t_macro();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_macro.add(t_macro162.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(45);}



            // AST REWRITE
            // elements: string, t_list, t_macro, curly_brackets, FOREACH
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 148:9: -> ^( FOREACH ^( VARNAME string ) t_list ( curly_brackets )? ( t_macro )? )
            {
                dbg.location(148,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:148:17: ^( FOREACH ^( VARNAME string ) t_list ( curly_brackets )? ( t_macro )? )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(148,20);
                root_1 = (CommonTree)adaptor.becomeRoot(stream_FOREACH.nextNode(), root_1);

                dbg.location(148,28);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:148:28: ^( VARNAME string )
                {
                CommonTree root_2 = (CommonTree)adaptor.nil();
                dbg.location(148,31);
                root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(VARNAME, "VARNAME"), root_2);

                dbg.location(148,39);
                adaptor.addChild(root_2, stream_string.nextTree());

                adaptor.addChild(root_1, root_2);
                }
                dbg.location(148,48);
                adaptor.addChild(root_1, stream_t_list.nextTree());
                dbg.location(148,55);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:148:55: ( curly_brackets )?
                if ( stream_curly_brackets.hasNext() ) {
                    dbg.location(148,55);
                    adaptor.addChild(root_1, stream_curly_brackets.nextTree());

                }
                stream_curly_brackets.reset();
                dbg.location(148,72);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:148:72: ( t_macro )?
                if ( stream_t_macro.hasNext() ) {
                    dbg.location(148,72);
                    adaptor.addChild(root_1, stream_t_macro.nextTree());

                }
                stream_t_macro.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(149, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_foreach");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_foreach"

    public static class t_againpath_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_againpath"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:151:1: t_againpath : BACKSLASH AGAINPATH BACKSLASH string -> ^( AGAINPATH ^( NAME string ) ) ;
    public final TikzGrammarParser.t_againpath_return t_againpath() throws RecognitionException {
        TikzGrammarParser.t_againpath_return retval = new TikzGrammarParser.t_againpath_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token BACKSLASH163=null;
        Token AGAINPATH164=null;
        Token BACKSLASH165=null;
        TikzGrammarParser.string_return string166 = null;


        CommonTree BACKSLASH163_tree=null;
        CommonTree AGAINPATH164_tree=null;
        CommonTree BACKSLASH165_tree=null;
        RewriteRuleTokenStream stream_AGAINPATH=new RewriteRuleTokenStream(adaptor,"token AGAINPATH");
        RewriteRuleTokenStream stream_BACKSLASH=new RewriteRuleTokenStream(adaptor,"token BACKSLASH");
        RewriteRuleSubtreeStream stream_string=new RewriteRuleSubtreeStream(adaptor,"rule string");
        try { dbg.enterRule(getGrammarFileName(), "t_againpath");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(151, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:152:9: ( BACKSLASH AGAINPATH BACKSLASH string -> ^( AGAINPATH ^( NAME string ) ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:152:17: BACKSLASH AGAINPATH BACKSLASH string
            {
            dbg.location(152,17);
            BACKSLASH163=(Token)match(input,BACKSLASH,FOLLOW_BACKSLASH_in_t_againpath2853); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_BACKSLASH.add(BACKSLASH163);

            dbg.location(152,27);
            AGAINPATH164=(Token)match(input,AGAINPATH,FOLLOW_AGAINPATH_in_t_againpath2855); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_AGAINPATH.add(AGAINPATH164);

            dbg.location(152,37);
            BACKSLASH165=(Token)match(input,BACKSLASH,FOLLOW_BACKSLASH_in_t_againpath2857); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_BACKSLASH.add(BACKSLASH165);

            dbg.location(152,47);
            pushFollow(FOLLOW_string_in_t_againpath2859);
            string166=string();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_string.add(string166.getTree());


            // AST REWRITE
            // elements: string, AGAINPATH
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 153:9: -> ^( AGAINPATH ^( NAME string ) )
            {
                dbg.location(153,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:153:17: ^( AGAINPATH ^( NAME string ) )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(153,20);
                root_1 = (CommonTree)adaptor.becomeRoot(stream_AGAINPATH.nextNode(), root_1);

                dbg.location(153,30);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:153:30: ^( NAME string )
                {
                CommonTree root_2 = (CommonTree)adaptor.nil();
                dbg.location(153,33);
                root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(NAME, "NAME"), root_2);

                dbg.location(153,38);
                adaptor.addChild(root_2, stream_string.nextTree());

                adaptor.addChild(root_1, root_2);
                }

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(154, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_againpath");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_againpath"

    public static class t_edge_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_edge"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:156:1: t_edge : EDGE ( ( ( t_options )? t_coordinate ) -> ^( EDGE ( t_options )? t_coordinate ) | ( ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )? ) -> ^( EDGE ( t_options )? ^( NODE ( t_options )? curly_brackets t_coordinate ) ) | ( EDGE FROM PARENT t_options ) -> ^( EDGE_FROM_PARENT t_options ) ) ;
    public final TikzGrammarParser.t_edge_return t_edge() throws RecognitionException {
        TikzGrammarParser.t_edge_return retval = new TikzGrammarParser.t_edge_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token EDGE167=null;
        Token NODE171=null;
        Token EDGE175=null;
        Token FROM176=null;
        Token PARENT177=null;
        TikzGrammarParser.t_options_return t_options168 = null;

        TikzGrammarParser.t_coordinate_return t_coordinate169 = null;

        TikzGrammarParser.t_options_return t_options170 = null;

        TikzGrammarParser.t_options_return t_options172 = null;

        TikzGrammarParser.curly_brackets_return curly_brackets173 = null;

        TikzGrammarParser.t_coordinate_return t_coordinate174 = null;

        TikzGrammarParser.t_options_return t_options178 = null;


        CommonTree EDGE167_tree=null;
        CommonTree NODE171_tree=null;
        CommonTree EDGE175_tree=null;
        CommonTree FROM176_tree=null;
        CommonTree PARENT177_tree=null;
        RewriteRuleTokenStream stream_PARENT=new RewriteRuleTokenStream(adaptor,"token PARENT");
        RewriteRuleTokenStream stream_NODE=new RewriteRuleTokenStream(adaptor,"token NODE");
        RewriteRuleTokenStream stream_FROM=new RewriteRuleTokenStream(adaptor,"token FROM");
        RewriteRuleTokenStream stream_EDGE=new RewriteRuleTokenStream(adaptor,"token EDGE");
        RewriteRuleSubtreeStream stream_curly_brackets=new RewriteRuleSubtreeStream(adaptor,"rule curly_brackets");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        RewriteRuleSubtreeStream stream_t_options=new RewriteRuleSubtreeStream(adaptor,"rule t_options");
        try { dbg.enterRule(getGrammarFileName(), "t_edge");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(156, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:156:9: ( EDGE ( ( ( t_options )? t_coordinate ) -> ^( EDGE ( t_options )? t_coordinate ) | ( ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )? ) -> ^( EDGE ( t_options )? ^( NODE ( t_options )? curly_brackets t_coordinate ) ) | ( EDGE FROM PARENT t_options ) -> ^( EDGE_FROM_PARENT t_options ) ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:156:17: EDGE ( ( ( t_options )? t_coordinate ) -> ^( EDGE ( t_options )? t_coordinate ) | ( ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )? ) -> ^( EDGE ( t_options )? ^( NODE ( t_options )? curly_brackets t_coordinate ) ) | ( EDGE FROM PARENT t_options ) -> ^( EDGE_FROM_PARENT t_options ) )
            {
            dbg.location(156,17);
            EDGE167=(Token)match(input,EDGE,FOLLOW_EDGE_in_t_edge2927); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_EDGE.add(EDGE167);

            dbg.location(156,22);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:156:22: ( ( ( t_options )? t_coordinate ) -> ^( EDGE ( t_options )? t_coordinate ) | ( ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )? ) -> ^( EDGE ( t_options )? ^( NODE ( t_options )? curly_brackets t_coordinate ) ) | ( EDGE FROM PARENT t_options ) -> ^( EDGE_FROM_PARENT t_options ) )
            int alt50=3;
            try { dbg.enterSubRule(50);
            try { dbg.enterDecision(50);

            switch ( input.LA(1) ) {
            case 79:
                {
                int LA50_1 = input.LA(2);

                if ( (synpred130_TikzGrammar()) ) {
                    alt50=1;
                }
                else if ( (synpred134_TikzGrammar()) ) {
                    alt50=2;
                }
                else {
                    if (state.backtracking>0) {state.failed=true; return retval;}
                    NoViableAltException nvae =
                        new NoViableAltException("", 50, 1, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
                }
                break;
            case OPERATOR:
            case COORDINATE:
            case 77:
                {
                alt50=1;
                }
                break;
            case NODE:
                {
                alt50=2;
                }
                break;
            case EDGE:
                {
                alt50=3;
                }
                break;
            default:
                if (state.backtracking>0) {state.failed=true; return retval;}
                NoViableAltException nvae =
                    new NoViableAltException("", 50, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(50);}

            switch (alt50) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:157:25: ( ( t_options )? t_coordinate )
                    {
                    dbg.location(157,25);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:157:25: ( ( t_options )? t_coordinate )
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:157:27: ( t_options )? t_coordinate
                    {
                    dbg.location(157,27);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:157:27: ( t_options )?
                    int alt46=2;
                    try { dbg.enterSubRule(46);
                    try { dbg.enterDecision(46);

                    int LA46_0 = input.LA(1);

                    if ( (LA46_0==79) ) {
                        alt46=1;
                    }
                    } finally {dbg.exitDecision(46);}

                    switch (alt46) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                            {
                            dbg.location(157,27);
                            pushFollow(FOLLOW_t_options_in_t_edge2958);
                            t_options168=t_options();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_options.add(t_options168.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(46);}

                    dbg.location(157,38);
                    pushFollow(FOLLOW_t_coordinate_in_t_edge2961);
                    t_coordinate169=t_coordinate();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate169.getTree());

                    }



                    // AST REWRITE
                    // elements: EDGE, t_options, t_coordinate
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 158:9: -> ^( EDGE ( t_options )? t_coordinate )
                    {
                        dbg.location(158,25);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:158:25: ^( EDGE ( t_options )? t_coordinate )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(158,27);
                        root_1 = (CommonTree)adaptor.becomeRoot(stream_EDGE.nextNode(), root_1);

                        dbg.location(158,32);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:158:32: ( t_options )?
                        if ( stream_t_options.hasNext() ) {
                            dbg.location(158,32);
                            adaptor.addChild(root_1, stream_t_options.nextTree());

                        }
                        stream_t_options.reset();
                        dbg.location(158,44);
                        adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:27: ( ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )? )
                    {
                    dbg.location(159,27);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:27: ( ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )? )
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:29: ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )?
                    {
                    dbg.location(159,29);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:29: ( t_options )?
                    int alt47=2;
                    try { dbg.enterSubRule(47);
                    try { dbg.enterDecision(47);

                    int LA47_0 = input.LA(1);

                    if ( (LA47_0==79) ) {
                        alt47=1;
                    }
                    } finally {dbg.exitDecision(47);}

                    switch (alt47) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                            {
                            dbg.location(159,29);
                            pushFollow(FOLLOW_t_options_in_t_edge3026);
                            t_options170=t_options();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_options.add(t_options170.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(47);}

                    dbg.location(159,40);
                    NODE171=(Token)match(input,NODE,FOLLOW_NODE_in_t_edge3029); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_NODE.add(NODE171);

                    dbg.location(159,45);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:45: ( t_options )?
                    int alt48=2;
                    try { dbg.enterSubRule(48);
                    try { dbg.enterDecision(48);

                    int LA48_0 = input.LA(1);

                    if ( (LA48_0==79) ) {
                        alt48=1;
                    }
                    } finally {dbg.exitDecision(48);}

                    switch (alt48) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                            {
                            dbg.location(159,45);
                            pushFollow(FOLLOW_t_options_in_t_edge3031);
                            t_options172=t_options();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_options.add(t_options172.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(48);}

                    dbg.location(159,56);
                    pushFollow(FOLLOW_curly_brackets_in_t_edge3034);
                    curly_brackets173=curly_brackets();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_curly_brackets.add(curly_brackets173.getTree());
                    dbg.location(159,71);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:71: ( t_coordinate )?
                    int alt49=2;
                    try { dbg.enterSubRule(49);
                    try { dbg.enterDecision(49);

                    try {
                        isCyclicDecision = true;
                        alt49 = dfa49.predict(input);
                    }
                    catch (NoViableAltException nvae) {
                        dbg.recognitionException(nvae);
                        throw nvae;
                    }
                    } finally {dbg.exitDecision(49);}

                    switch (alt49) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_coordinate
                            {
                            dbg.location(159,71);
                            pushFollow(FOLLOW_t_coordinate_in_t_edge3036);
                            t_coordinate174=t_coordinate();

                            state._fsp--;
                            if (state.failed) return retval;
                            if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate174.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(49);}


                    }



                    // AST REWRITE
                    // elements: EDGE, curly_brackets, t_coordinate, t_options, NODE, t_options
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 160:9: -> ^( EDGE ( t_options )? ^( NODE ( t_options )? curly_brackets t_coordinate ) )
                    {
                        dbg.location(160,25);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:160:25: ^( EDGE ( t_options )? ^( NODE ( t_options )? curly_brackets t_coordinate ) )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(160,27);
                        root_1 = (CommonTree)adaptor.becomeRoot(stream_EDGE.nextNode(), root_1);

                        dbg.location(160,32);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:160:32: ( t_options )?
                        if ( stream_t_options.hasNext() ) {
                            dbg.location(160,32);
                            adaptor.addChild(root_1, stream_t_options.nextTree());

                        }
                        stream_t_options.reset();
                        dbg.location(160,43);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:160:43: ^( NODE ( t_options )? curly_brackets t_coordinate )
                        {
                        CommonTree root_2 = (CommonTree)adaptor.nil();
                        dbg.location(160,45);
                        root_2 = (CommonTree)adaptor.becomeRoot(stream_NODE.nextNode(), root_2);

                        dbg.location(160,50);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:160:50: ( t_options )?
                        if ( stream_t_options.hasNext() ) {
                            dbg.location(160,50);
                            adaptor.addChild(root_2, stream_t_options.nextTree());

                        }
                        stream_t_options.reset();
                        dbg.location(160,61);
                        adaptor.addChild(root_2, stream_curly_brackets.nextTree());
                        dbg.location(160,76);
                        adaptor.addChild(root_2, stream_t_coordinate.nextTree());

                        adaptor.addChild(root_1, root_2);
                        }

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:161:27: ( EDGE FROM PARENT t_options )
                    {
                    dbg.location(161,27);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:161:27: ( EDGE FROM PARENT t_options )
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:161:28: EDGE FROM PARENT t_options
                    {
                    dbg.location(161,28);
                    EDGE175=(Token)match(input,EDGE,FOLLOW_EDGE_in_t_edge3112); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_EDGE.add(EDGE175);

                    dbg.location(161,33);
                    FROM176=(Token)match(input,FROM,FOLLOW_FROM_in_t_edge3114); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_FROM.add(FROM176);

                    dbg.location(161,38);
                    PARENT177=(Token)match(input,PARENT,FOLLOW_PARENT_in_t_edge3116); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_PARENT.add(PARENT177);

                    dbg.location(161,45);
                    pushFollow(FOLLOW_t_options_in_t_edge3118);
                    t_options178=t_options();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_options.add(t_options178.getTree());

                    }



                    // AST REWRITE
                    // elements: t_options
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 162:9: -> ^( EDGE_FROM_PARENT t_options )
                    {
                        dbg.location(162,25);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:162:25: ^( EDGE_FROM_PARENT t_options )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(162,27);
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(EDGE_FROM_PARENT, "EDGE_FROM_PARENT"), root_1);

                        dbg.location(162,44);
                        adaptor.addChild(root_1, stream_t_options.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;

            }
            } finally {dbg.exitSubRule(50);}


            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(164, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_edge");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_edge"

    public static class t_gird_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_gird"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:166:1: t_gird : GRID t_coordinate -> ^( GRID t_coordinate ) ;
    public final TikzGrammarParser.t_gird_return t_gird() throws RecognitionException {
        TikzGrammarParser.t_gird_return retval = new TikzGrammarParser.t_gird_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token GRID179=null;
        TikzGrammarParser.t_coordinate_return t_coordinate180 = null;


        CommonTree GRID179_tree=null;
        RewriteRuleTokenStream stream_GRID=new RewriteRuleTokenStream(adaptor,"token GRID");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        try { dbg.enterRule(getGrammarFileName(), "t_gird");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(166, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:167:9: ( GRID t_coordinate -> ^( GRID t_coordinate ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:167:17: GRID t_coordinate
            {
            dbg.location(167,17);
            GRID179=(Token)match(input,GRID,FOLLOW_GRID_in_t_gird3205); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_GRID.add(GRID179);

            dbg.location(167,22);
            pushFollow(FOLLOW_t_coordinate_in_t_gird3207);
            t_coordinate180=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate180.getTree());


            // AST REWRITE
            // elements: GRID, t_coordinate
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 168:9: -> ^( GRID t_coordinate )
            {
                dbg.location(168,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:168:17: ^( GRID t_coordinate )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(168,19);
                root_1 = (CommonTree)adaptor.becomeRoot(stream_GRID.nextNode(), root_1);

                dbg.location(168,24);
                adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(169, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_gird");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_gird"

    public static class t_curve_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_curve"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:171:1: t_curve : DOTS CONTROLS p1= t_coordinate ( AND p2= t_coordinate )? DOTS target= t_coordinate -> ^( CURVE ^( PC $p1) ( ^( PD $p2) )? ^( PE $target) ) ;
    public final TikzGrammarParser.t_curve_return t_curve() throws RecognitionException {
        TikzGrammarParser.t_curve_return retval = new TikzGrammarParser.t_curve_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token DOTS181=null;
        Token CONTROLS182=null;
        Token AND183=null;
        Token DOTS184=null;
        TikzGrammarParser.t_coordinate_return p1 = null;

        TikzGrammarParser.t_coordinate_return p2 = null;

        TikzGrammarParser.t_coordinate_return target = null;


        CommonTree DOTS181_tree=null;
        CommonTree CONTROLS182_tree=null;
        CommonTree AND183_tree=null;
        CommonTree DOTS184_tree=null;
        RewriteRuleTokenStream stream_DOTS=new RewriteRuleTokenStream(adaptor,"token DOTS");
        RewriteRuleTokenStream stream_CONTROLS=new RewriteRuleTokenStream(adaptor,"token CONTROLS");
        RewriteRuleTokenStream stream_AND=new RewriteRuleTokenStream(adaptor,"token AND");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        try { dbg.enterRule(getGrammarFileName(), "t_curve");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(171, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:171:9: ( DOTS CONTROLS p1= t_coordinate ( AND p2= t_coordinate )? DOTS target= t_coordinate -> ^( CURVE ^( PC $p1) ( ^( PD $p2) )? ^( PE $target) ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:171:17: DOTS CONTROLS p1= t_coordinate ( AND p2= t_coordinate )? DOTS target= t_coordinate
            {
            dbg.location(171,17);
            DOTS181=(Token)match(input,DOTS,FOLLOW_DOTS_in_t_curve3259); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_DOTS.add(DOTS181);

            dbg.location(171,22);
            CONTROLS182=(Token)match(input,CONTROLS,FOLLOW_CONTROLS_in_t_curve3261); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_CONTROLS.add(CONTROLS182);

            dbg.location(171,33);
            pushFollow(FOLLOW_t_coordinate_in_t_curve3265);
            p1=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(p1.getTree());
            dbg.location(171,47);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:171:47: ( AND p2= t_coordinate )?
            int alt51=2;
            try { dbg.enterSubRule(51);
            try { dbg.enterDecision(51);

            int LA51_0 = input.LA(1);

            if ( (LA51_0==AND) ) {
                alt51=1;
            }
            } finally {dbg.exitDecision(51);}

            switch (alt51) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:171:49: AND p2= t_coordinate
                    {
                    dbg.location(171,49);
                    AND183=(Token)match(input,AND,FOLLOW_AND_in_t_curve3269); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_AND.add(AND183);

                    dbg.location(171,55);
                    pushFollow(FOLLOW_t_coordinate_in_t_curve3273);
                    p2=t_coordinate();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_coordinate.add(p2.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(51);}

            dbg.location(171,72);
            DOTS184=(Token)match(input,DOTS,FOLLOW_DOTS_in_t_curve3278); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_DOTS.add(DOTS184);

            dbg.location(171,83);
            pushFollow(FOLLOW_t_coordinate_in_t_curve3282);
            target=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(target.getTree());


            // AST REWRITE
            // elements: p2, target, p1
            // token labels: 
            // rule labels: retval, p2, p1, target
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);
            RewriteRuleSubtreeStream stream_p2=new RewriteRuleSubtreeStream(adaptor,"rule p2",p2!=null?p2.tree:null);
            RewriteRuleSubtreeStream stream_p1=new RewriteRuleSubtreeStream(adaptor,"rule p1",p1!=null?p1.tree:null);
            RewriteRuleSubtreeStream stream_target=new RewriteRuleSubtreeStream(adaptor,"rule target",target!=null?target.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 172:9: -> ^( CURVE ^( PC $p1) ( ^( PD $p2) )? ^( PE $target) )
            {
                dbg.location(172,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:172:17: ^( CURVE ^( PC $p1) ( ^( PD $p2) )? ^( PE $target) )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(172,19);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(CURVE, "CURVE"), root_1);

                dbg.location(172,25);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:172:25: ^( PC $p1)
                {
                CommonTree root_2 = (CommonTree)adaptor.nil();
                dbg.location(172,27);
                root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(PC, "PC"), root_2);

                dbg.location(172,30);
                adaptor.addChild(root_2, stream_p1.nextTree());

                adaptor.addChild(root_1, root_2);
                }
                dbg.location(172,35);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:172:35: ( ^( PD $p2) )?
                if ( stream_p2.hasNext() ) {
                    dbg.location(172,35);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:172:35: ^( PD $p2)
                    {
                    CommonTree root_2 = (CommonTree)adaptor.nil();
                    dbg.location(172,37);
                    root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(PD, "PD"), root_2);

                    dbg.location(172,40);
                    adaptor.addChild(root_2, stream_p2.nextTree());

                    adaptor.addChild(root_1, root_2);
                    }

                }
                stream_p2.reset();
                dbg.location(172,46);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:172:46: ^( PE $target)
                {
                CommonTree root_2 = (CommonTree)adaptor.nil();
                dbg.location(172,48);
                root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(PE, "PE"), root_2);

                dbg.location(172,51);
                adaptor.addChild(root_2, stream_target.nextTree());

                adaptor.addChild(root_1, root_2);
                }

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(173, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_curve");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_curve"

    public static class t_rectangle_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_rectangle"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:175:1: t_rectangle : RECTANGLE t_coordinate -> ^( RECTANGLE t_coordinate ) ;
    public final TikzGrammarParser.t_rectangle_return t_rectangle() throws RecognitionException {
        TikzGrammarParser.t_rectangle_return retval = new TikzGrammarParser.t_rectangle_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token RECTANGLE185=null;
        TikzGrammarParser.t_coordinate_return t_coordinate186 = null;


        CommonTree RECTANGLE185_tree=null;
        RewriteRuleTokenStream stream_RECTANGLE=new RewriteRuleTokenStream(adaptor,"token RECTANGLE");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        try { dbg.enterRule(getGrammarFileName(), "t_rectangle");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(175, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:176:9: ( RECTANGLE t_coordinate -> ^( RECTANGLE t_coordinate ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:176:17: RECTANGLE t_coordinate
            {
            dbg.location(176,17);
            RECTANGLE185=(Token)match(input,RECTANGLE,FOLLOW_RECTANGLE_in_t_rectangle3369); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_RECTANGLE.add(RECTANGLE185);

            dbg.location(176,27);
            pushFollow(FOLLOW_t_coordinate_in_t_rectangle3371);
            t_coordinate186=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate186.getTree());


            // AST REWRITE
            // elements: t_coordinate, RECTANGLE
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 177:9: -> ^( RECTANGLE t_coordinate )
            {
                dbg.location(177,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:177:17: ^( RECTANGLE t_coordinate )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(177,19);
                root_1 = (CommonTree)adaptor.becomeRoot(stream_RECTANGLE.nextNode(), root_1);

                dbg.location(177,29);
                adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(178, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_rectangle");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_rectangle"

    public static class t_grid_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_grid"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:180:1: t_grid : GRID t_coordinate -> ^( GRID t_coordinate ) ;
    public final TikzGrammarParser.t_grid_return t_grid() throws RecognitionException {
        TikzGrammarParser.t_grid_return retval = new TikzGrammarParser.t_grid_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token GRID187=null;
        TikzGrammarParser.t_coordinate_return t_coordinate188 = null;


        CommonTree GRID187_tree=null;
        RewriteRuleTokenStream stream_GRID=new RewriteRuleTokenStream(adaptor,"token GRID");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        try { dbg.enterRule(getGrammarFileName(), "t_grid");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(180, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:181:9: ( GRID t_coordinate -> ^( GRID t_coordinate ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:181:17: GRID t_coordinate
            {
            dbg.location(181,17);
            GRID187=(Token)match(input,GRID,FOLLOW_GRID_in_t_grid3431); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_GRID.add(GRID187);

            dbg.location(181,22);
            pushFollow(FOLLOW_t_coordinate_in_t_grid3433);
            t_coordinate188=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate188.getTree());


            // AST REWRITE
            // elements: t_coordinate, GRID
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 182:9: -> ^( GRID t_coordinate )
            {
                dbg.location(182,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:182:17: ^( GRID t_coordinate )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(182,19);
                root_1 = (CommonTree)adaptor.becomeRoot(stream_GRID.nextNode(), root_1);

                dbg.location(182,24);
                adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(183, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_grid");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_grid"

    public static class t_parabola_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_parabola"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:186:1: t_parabola : PARABOLA ( t_options )? BEND c1= t_coordinate (c2= t_coordinate )? -> ^( PARABOLA ( t_options )? $c1 ( $c2)? ) ;
    public final TikzGrammarParser.t_parabola_return t_parabola() throws RecognitionException {
        TikzGrammarParser.t_parabola_return retval = new TikzGrammarParser.t_parabola_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token PARABOLA189=null;
        Token BEND191=null;
        TikzGrammarParser.t_coordinate_return c1 = null;

        TikzGrammarParser.t_coordinate_return c2 = null;

        TikzGrammarParser.t_options_return t_options190 = null;


        CommonTree PARABOLA189_tree=null;
        CommonTree BEND191_tree=null;
        RewriteRuleTokenStream stream_PARABOLA=new RewriteRuleTokenStream(adaptor,"token PARABOLA");
        RewriteRuleTokenStream stream_BEND=new RewriteRuleTokenStream(adaptor,"token BEND");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        RewriteRuleSubtreeStream stream_t_options=new RewriteRuleSubtreeStream(adaptor,"rule t_options");
        try { dbg.enterRule(getGrammarFileName(), "t_parabola");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(186, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:187:9: ( PARABOLA ( t_options )? BEND c1= t_coordinate (c2= t_coordinate )? -> ^( PARABOLA ( t_options )? $c1 ( $c2)? ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:187:17: PARABOLA ( t_options )? BEND c1= t_coordinate (c2= t_coordinate )?
            {
            dbg.location(187,17);
            PARABOLA189=(Token)match(input,PARABOLA,FOLLOW_PARABOLA_in_t_parabola3494); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_PARABOLA.add(PARABOLA189);

            dbg.location(187,26);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:187:26: ( t_options )?
            int alt52=2;
            try { dbg.enterSubRule(52);
            try { dbg.enterDecision(52);

            int LA52_0 = input.LA(1);

            if ( (LA52_0==79) ) {
                alt52=1;
            }
            } finally {dbg.exitDecision(52);}

            switch (alt52) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                    {
                    dbg.location(187,26);
                    pushFollow(FOLLOW_t_options_in_t_parabola3496);
                    t_options190=t_options();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_options.add(t_options190.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(52);}

            dbg.location(187,37);
            BEND191=(Token)match(input,BEND,FOLLOW_BEND_in_t_parabola3499); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_BEND.add(BEND191);

            dbg.location(187,44);
            pushFollow(FOLLOW_t_coordinate_in_t_parabola3503);
            c1=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(c1.getTree());
            dbg.location(187,60);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:187:60: (c2= t_coordinate )?
            int alt53=2;
            try { dbg.enterSubRule(53);
            try { dbg.enterDecision(53);

            try {
                isCyclicDecision = true;
                alt53 = dfa53.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(53);}

            switch (alt53) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: c2= t_coordinate
                    {
                    dbg.location(187,60);
                    pushFollow(FOLLOW_t_coordinate_in_t_parabola3507);
                    c2=t_coordinate();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_t_coordinate.add(c2.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(53);}



            // AST REWRITE
            // elements: c1, c2, PARABOLA, t_options
            // token labels: 
            // rule labels: retval, c1, c2
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);
            RewriteRuleSubtreeStream stream_c1=new RewriteRuleSubtreeStream(adaptor,"rule c1",c1!=null?c1.tree:null);
            RewriteRuleSubtreeStream stream_c2=new RewriteRuleSubtreeStream(adaptor,"rule c2",c2!=null?c2.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 188:9: -> ^( PARABOLA ( t_options )? $c1 ( $c2)? )
            {
                dbg.location(188,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:188:17: ^( PARABOLA ( t_options )? $c1 ( $c2)? )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(188,19);
                root_1 = (CommonTree)adaptor.becomeRoot(stream_PARABOLA.nextNode(), root_1);

                dbg.location(188,28);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:188:28: ( t_options )?
                if ( stream_t_options.hasNext() ) {
                    dbg.location(188,28);
                    adaptor.addChild(root_1, stream_t_options.nextTree());

                }
                stream_t_options.reset();
                dbg.location(188,39);
                adaptor.addChild(root_1, stream_c1.nextTree());
                dbg.location(188,43);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:188:43: ( $c2)?
                if ( stream_c2.hasNext() ) {
                    dbg.location(188,43);
                    adaptor.addChild(root_1, stream_c2.nextTree());

                }
                stream_c2.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(189, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_parabola");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_parabola"

    public static class t_circle_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_circle"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:191:1: t_circle : CIRCLE t_coordinate -> ^( CIRCLE t_coordinate ) ;
    public final TikzGrammarParser.t_circle_return t_circle() throws RecognitionException {
        TikzGrammarParser.t_circle_return retval = new TikzGrammarParser.t_circle_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token CIRCLE192=null;
        TikzGrammarParser.t_coordinate_return t_coordinate193 = null;


        CommonTree CIRCLE192_tree=null;
        RewriteRuleTokenStream stream_CIRCLE=new RewriteRuleTokenStream(adaptor,"token CIRCLE");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        try { dbg.enterRule(getGrammarFileName(), "t_circle");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(191, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:191:9: ( CIRCLE t_coordinate -> ^( CIRCLE t_coordinate ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:191:17: CIRCLE t_coordinate
            {
            dbg.location(191,17);
            CIRCLE192=(Token)match(input,CIRCLE,FOLLOW_CIRCLE_in_t_circle3559); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_CIRCLE.add(CIRCLE192);

            dbg.location(191,24);
            pushFollow(FOLLOW_t_coordinate_in_t_circle3561);
            t_coordinate193=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate193.getTree());


            // AST REWRITE
            // elements: CIRCLE, t_coordinate
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 192:9: -> ^( CIRCLE t_coordinate )
            {
                dbg.location(192,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:192:17: ^( CIRCLE t_coordinate )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(192,20);
                root_1 = (CommonTree)adaptor.becomeRoot(stream_CIRCLE.nextNode(), root_1);

                dbg.location(192,27);
                adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(193, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_circle");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_circle"

    public static class t_ellipse_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_ellipse"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:195:1: t_ellipse : ELLIPSE t_coordinate -> ^( ELLIPSE t_coordinate ) ;
    public final TikzGrammarParser.t_ellipse_return t_ellipse() throws RecognitionException {
        TikzGrammarParser.t_ellipse_return retval = new TikzGrammarParser.t_ellipse_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token ELLIPSE194=null;
        TikzGrammarParser.t_coordinate_return t_coordinate195 = null;


        CommonTree ELLIPSE194_tree=null;
        RewriteRuleTokenStream stream_ELLIPSE=new RewriteRuleTokenStream(adaptor,"token ELLIPSE");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        try { dbg.enterRule(getGrammarFileName(), "t_ellipse");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(195, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:196:9: ( ELLIPSE t_coordinate -> ^( ELLIPSE t_coordinate ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:196:17: ELLIPSE t_coordinate
            {
            dbg.location(196,17);
            ELLIPSE194=(Token)match(input,ELLIPSE,FOLLOW_ELLIPSE_in_t_ellipse3623); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_ELLIPSE.add(ELLIPSE194);

            dbg.location(196,25);
            pushFollow(FOLLOW_t_coordinate_in_t_ellipse3625);
            t_coordinate195=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate195.getTree());


            // AST REWRITE
            // elements: ELLIPSE, t_coordinate
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 197:9: -> ^( ELLIPSE t_coordinate )
            {
                dbg.location(197,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:197:17: ^( ELLIPSE t_coordinate )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(197,20);
                root_1 = (CommonTree)adaptor.becomeRoot(stream_ELLIPSE.nextNode(), root_1);

                dbg.location(197,28);
                adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(198, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_ellipse");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_ellipse"

    public static class t_arc_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_arc"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:200:1: t_arc : ARC t_coordinate -> ^( ARC t_coordinate ) ;
    public final TikzGrammarParser.t_arc_return t_arc() throws RecognitionException {
        TikzGrammarParser.t_arc_return retval = new TikzGrammarParser.t_arc_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token ARC196=null;
        TikzGrammarParser.t_coordinate_return t_coordinate197 = null;


        CommonTree ARC196_tree=null;
        RewriteRuleTokenStream stream_ARC=new RewriteRuleTokenStream(adaptor,"token ARC");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        try { dbg.enterRule(getGrammarFileName(), "t_arc");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(200, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:200:9: ( ARC t_coordinate -> ^( ARC t_coordinate ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:200:17: ARC t_coordinate
            {
            dbg.location(200,17);
            ARC196=(Token)match(input,ARC,FOLLOW_ARC_in_t_arc3689); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_ARC.add(ARC196);

            dbg.location(200,21);
            pushFollow(FOLLOW_t_coordinate_in_t_arc3691);
            t_coordinate197=t_coordinate();

            state._fsp--;
            if (state.failed) return retval;
            if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate197.getTree());


            // AST REWRITE
            // elements: t_coordinate, ARC
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            if ( state.backtracking==0 ) {
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 201:9: -> ^( ARC t_coordinate )
            {
                dbg.location(201,17);
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:201:17: ^( ARC t_coordinate )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(201,20);
                root_1 = (CommonTree)adaptor.becomeRoot(stream_ARC.nextNode(), root_1);

                dbg.location(201,24);
                adaptor.addChild(root_1, stream_t_coordinate.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;}
            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(202, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_arc");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_arc"

    public static class t_plot_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "t_plot"
    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:204:1: t_plot : (line= LINE )? PLOT ( ( COORDINATES '{' ( t_coordinate )* '}' ) -> ^( PLOT ^( COORDINATES ( t_coordinate )* ) ) | ( FILE '{' string '}' ) -> ^( PLOT ^( FILE string ) ) | ( FUNCTION curly_brackets ) -> ^( PLOT ^( GNUPLOT curly_brackets ) ) | function -> ^( PLOT ^( function ) ) ) ;
    public final TikzGrammarParser.t_plot_return t_plot() throws RecognitionException {
        TikzGrammarParser.t_plot_return retval = new TikzGrammarParser.t_plot_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token line=null;
        Token PLOT198=null;
        Token COORDINATES199=null;
        Token char_literal200=null;
        Token char_literal202=null;
        Token FILE203=null;
        Token char_literal204=null;
        Token char_literal206=null;
        Token FUNCTION207=null;
        TikzGrammarParser.t_coordinate_return t_coordinate201 = null;

        TikzGrammarParser.string_return string205 = null;

        TikzGrammarParser.curly_brackets_return curly_brackets208 = null;

        TikzGrammarParser.function_return function209 = null;


        CommonTree line_tree=null;
        CommonTree PLOT198_tree=null;
        CommonTree COORDINATES199_tree=null;
        CommonTree char_literal200_tree=null;
        CommonTree char_literal202_tree=null;
        CommonTree FILE203_tree=null;
        CommonTree char_literal204_tree=null;
        CommonTree char_literal206_tree=null;
        CommonTree FUNCTION207_tree=null;
        RewriteRuleTokenStream stream_FUNCTION=new RewriteRuleTokenStream(adaptor,"token FUNCTION");
        RewriteRuleTokenStream stream_COORDINATES=new RewriteRuleTokenStream(adaptor,"token COORDINATES");
        RewriteRuleTokenStream stream_FILE=new RewriteRuleTokenStream(adaptor,"token FILE");
        RewriteRuleTokenStream stream_LINE=new RewriteRuleTokenStream(adaptor,"token LINE");
        RewriteRuleTokenStream stream_PLOT=new RewriteRuleTokenStream(adaptor,"token PLOT");
        RewriteRuleTokenStream stream_74=new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleTokenStream stream_75=new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleSubtreeStream stream_curly_brackets=new RewriteRuleSubtreeStream(adaptor,"rule curly_brackets");
        RewriteRuleSubtreeStream stream_t_coordinate=new RewriteRuleSubtreeStream(adaptor,"rule t_coordinate");
        RewriteRuleSubtreeStream stream_string=new RewriteRuleSubtreeStream(adaptor,"rule string");
        RewriteRuleSubtreeStream stream_function=new RewriteRuleSubtreeStream(adaptor,"rule function");
        try { dbg.enterRule(getGrammarFileName(), "t_plot");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(204, 1);

        try {
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:204:9: ( (line= LINE )? PLOT ( ( COORDINATES '{' ( t_coordinate )* '}' ) -> ^( PLOT ^( COORDINATES ( t_coordinate )* ) ) | ( FILE '{' string '}' ) -> ^( PLOT ^( FILE string ) ) | ( FUNCTION curly_brackets ) -> ^( PLOT ^( GNUPLOT curly_brackets ) ) | function -> ^( PLOT ^( function ) ) ) )
            dbg.enterAlt(1);

            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:204:17: (line= LINE )? PLOT ( ( COORDINATES '{' ( t_coordinate )* '}' ) -> ^( PLOT ^( COORDINATES ( t_coordinate )* ) ) | ( FILE '{' string '}' ) -> ^( PLOT ^( FILE string ) ) | ( FUNCTION curly_brackets ) -> ^( PLOT ^( GNUPLOT curly_brackets ) ) | function -> ^( PLOT ^( function ) ) )
            {
            dbg.location(204,21);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:204:21: (line= LINE )?
            int alt54=2;
            try { dbg.enterSubRule(54);
            try { dbg.enterDecision(54);

            int LA54_0 = input.LA(1);

            if ( (LA54_0==LINE) ) {
                alt54=1;
            }
            } finally {dbg.exitDecision(54);}

            switch (alt54) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: line= LINE
                    {
                    dbg.location(204,21);
                    line=(Token)match(input,LINE,FOLLOW_LINE_in_t_plot3757); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_LINE.add(line);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(54);}

            dbg.location(204,28);
            PLOT198=(Token)match(input,PLOT,FOLLOW_PLOT_in_t_plot3760); if (state.failed) return retval; 
            if ( state.backtracking==0 ) stream_PLOT.add(PLOT198);

            dbg.location(204,33);
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:204:33: ( ( COORDINATES '{' ( t_coordinate )* '}' ) -> ^( PLOT ^( COORDINATES ( t_coordinate )* ) ) | ( FILE '{' string '}' ) -> ^( PLOT ^( FILE string ) ) | ( FUNCTION curly_brackets ) -> ^( PLOT ^( GNUPLOT curly_brackets ) ) | function -> ^( PLOT ^( function ) ) )
            int alt56=4;
            try { dbg.enterSubRule(56);
            try { dbg.enterDecision(56);

            switch ( input.LA(1) ) {
            case COORDINATES:
                {
                alt56=1;
                }
                break;
            case FILE:
                {
                alt56=2;
                }
                break;
            case FUNCTION:
                {
                alt56=3;
                }
                break;
            case FUNC:
            case 77:
                {
                alt56=4;
                }
                break;
            default:
                if (state.backtracking>0) {state.failed=true; return retval;}
                NoViableAltException nvae =
                    new NoViableAltException("", 56, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(56);}

            switch (alt56) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:205:25: ( COORDINATES '{' ( t_coordinate )* '}' )
                    {
                    dbg.location(205,25);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:205:25: ( COORDINATES '{' ( t_coordinate )* '}' )
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:205:27: COORDINATES '{' ( t_coordinate )* '}'
                    {
                    dbg.location(205,27);
                    COORDINATES199=(Token)match(input,COORDINATES,FOLLOW_COORDINATES_in_t_plot3790); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_COORDINATES.add(COORDINATES199);

                    dbg.location(205,39);
                    char_literal200=(Token)match(input,74,FOLLOW_74_in_t_plot3792); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_74.add(char_literal200);

                    dbg.location(205,43);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:205:43: ( t_coordinate )*
                    try { dbg.enterSubRule(55);

                    loop55:
                    do {
                        int alt55=2;
                        try { dbg.enterDecision(55);

                        int LA55_0 = input.LA(1);

                        if ( (LA55_0==OPERATOR||LA55_0==COORDINATE||LA55_0==77) ) {
                            alt55=1;
                        }


                        } finally {dbg.exitDecision(55);}

                        switch (alt55) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_coordinate
                    	    {
                    	    dbg.location(205,43);
                    	    pushFollow(FOLLOW_t_coordinate_in_t_plot3794);
                    	    t_coordinate201=t_coordinate();

                    	    state._fsp--;
                    	    if (state.failed) return retval;
                    	    if ( state.backtracking==0 ) stream_t_coordinate.add(t_coordinate201.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop55;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(55);}

                    dbg.location(205,57);
                    char_literal202=(Token)match(input,75,FOLLOW_75_in_t_plot3797); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_75.add(char_literal202);


                    }



                    // AST REWRITE
                    // elements: t_coordinate, COORDINATES, PLOT
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 206:9: -> ^( PLOT ^( COORDINATES ( t_coordinate )* ) )
                    {
                        dbg.location(206,25);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:206:25: ^( PLOT ^( COORDINATES ( t_coordinate )* ) )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(206,28);
                        root_1 = (CommonTree)adaptor.becomeRoot(stream_PLOT.nextNode(), root_1);

                        dbg.location(206,33);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:206:33: ^( COORDINATES ( t_coordinate )* )
                        {
                        CommonTree root_2 = (CommonTree)adaptor.nil();
                        dbg.location(206,36);
                        root_2 = (CommonTree)adaptor.becomeRoot(stream_COORDINATES.nextNode(), root_2);

                        dbg.location(206,48);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:206:48: ( t_coordinate )*
                        while ( stream_t_coordinate.hasNext() ) {
                            dbg.location(206,48);
                            adaptor.addChild(root_2, stream_t_coordinate.nextTree());

                        }
                        stream_t_coordinate.reset();

                        adaptor.addChild(root_1, root_2);
                        }

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:207:27: ( FILE '{' string '}' )
                    {
                    dbg.location(207,27);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:207:27: ( FILE '{' string '}' )
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:207:29: FILE '{' string '}'
                    {
                    dbg.location(207,29);
                    FILE203=(Token)match(input,FILE,FOLLOW_FILE_in_t_plot3866); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_FILE.add(FILE203);

                    dbg.location(207,34);
                    char_literal204=(Token)match(input,74,FOLLOW_74_in_t_plot3868); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_74.add(char_literal204);

                    dbg.location(207,38);
                    pushFollow(FOLLOW_string_in_t_plot3870);
                    string205=string();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_string.add(string205.getTree());
                    dbg.location(207,45);
                    char_literal206=(Token)match(input,75,FOLLOW_75_in_t_plot3872); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_75.add(char_literal206);


                    }



                    // AST REWRITE
                    // elements: FILE, PLOT, string
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 208:9: -> ^( PLOT ^( FILE string ) )
                    {
                        dbg.location(208,25);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:208:25: ^( PLOT ^( FILE string ) )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(208,28);
                        root_1 = (CommonTree)adaptor.becomeRoot(stream_PLOT.nextNode(), root_1);

                        dbg.location(208,33);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:208:33: ^( FILE string )
                        {
                        CommonTree root_2 = (CommonTree)adaptor.nil();
                        dbg.location(208,36);
                        root_2 = (CommonTree)adaptor.becomeRoot(stream_FILE.nextNode(), root_2);

                        dbg.location(208,41);
                        adaptor.addChild(root_2, stream_string.nextTree());

                        adaptor.addChild(root_1, root_2);
                        }

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:209:27: ( FUNCTION curly_brackets )
                    {
                    dbg.location(209,27);
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:209:27: ( FUNCTION curly_brackets )
                    dbg.enterAlt(1);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:209:29: FUNCTION curly_brackets
                    {
                    dbg.location(209,29);
                    FUNCTION207=(Token)match(input,FUNCTION,FOLLOW_FUNCTION_in_t_plot3940); if (state.failed) return retval; 
                    if ( state.backtracking==0 ) stream_FUNCTION.add(FUNCTION207);

                    dbg.location(209,38);
                    pushFollow(FOLLOW_curly_brackets_in_t_plot3942);
                    curly_brackets208=curly_brackets();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_curly_brackets.add(curly_brackets208.getTree());

                    }



                    // AST REWRITE
                    // elements: curly_brackets, PLOT
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 210:9: -> ^( PLOT ^( GNUPLOT curly_brackets ) )
                    {
                        dbg.location(210,25);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:210:25: ^( PLOT ^( GNUPLOT curly_brackets ) )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(210,28);
                        root_1 = (CommonTree)adaptor.becomeRoot(stream_PLOT.nextNode(), root_1);

                        dbg.location(210,33);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:210:33: ^( GNUPLOT curly_brackets )
                        {
                        CommonTree root_2 = (CommonTree)adaptor.nil();
                        dbg.location(210,36);
                        root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(GNUPLOT, "GNUPLOT"), root_2);

                        dbg.location(210,44);
                        adaptor.addChild(root_2, stream_curly_brackets.nextTree());

                        adaptor.addChild(root_1, root_2);
                        }

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;
                case 4 :
                    dbg.enterAlt(4);

                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:211:27: function
                    {
                    dbg.location(211,27);
                    pushFollow(FOLLOW_function_in_t_plot4009);
                    function209=function();

                    state._fsp--;
                    if (state.failed) return retval;
                    if ( state.backtracking==0 ) stream_function.add(function209.getTree());


                    // AST REWRITE
                    // elements: PLOT, function
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    if ( state.backtracking==0 ) {
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 212:9: -> ^( PLOT ^( function ) )
                    {
                        dbg.location(212,25);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:212:25: ^( PLOT ^( function ) )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(212,28);
                        root_1 = (CommonTree)adaptor.becomeRoot(stream_PLOT.nextNode(), root_1);

                        dbg.location(212,33);
                        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:212:33: ^( function )
                        {
                        CommonTree root_2 = (CommonTree)adaptor.nil();
                        dbg.location(212,36);
                        root_2 = (CommonTree)adaptor.becomeRoot(stream_function.nextNode(), root_2);

                        adaptor.addChild(root_1, root_2);
                        }

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;}
                    }
                    break;

            }
            } finally {dbg.exitSubRule(56);}


            }

            retval.stop = input.LT(-1);

            if ( state.backtracking==0 ) {

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);
            }
        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(214, 9);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "t_plot");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "t_plot"

    // $ANTLR start synpred2_TikzGrammar
    public final void synpred2_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:18: ( function )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:18: function
        {
        dbg.location(13,18);
        pushFollow(FOLLOW_function_in_synpred2_TikzGrammar97);
        function();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred2_TikzGrammar

    // $ANTLR start synpred3_TikzGrammar
    public final void synpred3_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:29: ( square_brackets )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:29: square_brackets
        {
        dbg.location(13,29);
        pushFollow(FOLLOW_square_brackets_in_synpred3_TikzGrammar101);
        square_brackets();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred3_TikzGrammar

    // $ANTLR start synpred4_TikzGrammar
    public final void synpred4_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:47: ( curly_brackets )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:47: curly_brackets
        {
        dbg.location(13,47);
        pushFollow(FOLLOW_curly_brackets_in_synpred4_TikzGrammar105);
        curly_brackets();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred4_TikzGrammar

    // $ANTLR start synpred5_TikzGrammar
    public final void synpred5_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:64: ( t_block )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:64: t_block
        {
        dbg.location(13,64);
        pushFollow(FOLLOW_t_block_in_synpred5_TikzGrammar109);
        t_block();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred5_TikzGrammar

    // $ANTLR start synpred6_TikzGrammar
    public final void synpred6_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:74: ( t_list )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:13:74: t_list
        {
        dbg.location(13,74);
        pushFollow(FOLLOW_t_list_in_synpred6_TikzGrammar113);
        t_list();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred6_TikzGrammar

    // $ANTLR start synpred7_TikzGrammar
    public final void synpred7_TikzGrammar_fragment() throws RecognitionException {   
        List list_block_name=null;
        RuleReturnScope block_name = null;
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:18:62: ( '{' block_name+= string '}' )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:18:62: '{' block_name+= string '}'
        {
        dbg.location(18,62);
        match(input,74,FOLLOW_74_in_synpred7_TikzGrammar205); if (state.failed) return ;
        dbg.location(18,76);
        pushFollow(FOLLOW_string_in_synpred7_TikzGrammar209);
        block_name=string();

        state._fsp--;
        if (state.failed) return ;
        if (list_block_name==null) list_block_name=new ArrayList();
        list_block_name.add(block_name);

        dbg.location(18,85);
        match(input,75,FOLLOW_75_in_synpred7_TikzGrammar211); if (state.failed) return ;

        }
    }
    // $ANTLR end synpred7_TikzGrammar

    // $ANTLR start synpred8_TikzGrammar
    public final void synpred8_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:18:92: ( t_main_structures )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:18:92: t_main_structures
        {
        dbg.location(18,92);
        pushFollow(FOLLOW_t_main_structures_in_synpred8_TikzGrammar216);
        t_main_structures();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred8_TikzGrammar

    // $ANTLR start synpred9_TikzGrammar
    public final void synpred9_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:23:27: ( t_foreach )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:23:27: t_foreach
        {
        dbg.location(23,27);
        pushFollow(FOLLOW_t_foreach_in_synpred9_TikzGrammar314);
        t_foreach();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred9_TikzGrammar

    // $ANTLR start synpred10_TikzGrammar
    public final void synpred10_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:26:27: ( t_node )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:26:27: t_node
        {
        dbg.location(26,27);
        pushFollow(FOLLOW_t_node_in_synpred10_TikzGrammar376);
        t_node();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred10_TikzGrammar

    // $ANTLR start synpred11_TikzGrammar
    public final void synpred11_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:29:27: ( t_coordinate )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:29:27: t_coordinate
        {
        dbg.location(29,27);
        pushFollow(FOLLOW_t_coordinate_in_synpred11_TikzGrammar438);
        t_coordinate();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred11_TikzGrammar

    // $ANTLR start synpred12_TikzGrammar
    public final void synpred12_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:32:46: ( t_macro )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:32:46: t_macro
        {
        dbg.location(32,46);
        pushFollow(FOLLOW_t_macro_in_synpred12_TikzGrammar521);
        t_macro();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred12_TikzGrammar

    // $ANTLR start synpred13_TikzGrammar
    public final void synpred13_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:27: ( t_options )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:27: t_options
        {
        dbg.location(33,27);
        pushFollow(FOLLOW_t_options_in_synpred13_TikzGrammar561);
        t_options();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred13_TikzGrammar

    // $ANTLR start synpred14_TikzGrammar
    public final void synpred14_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:39: ( t_lineto )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:39: t_lineto
        {
        dbg.location(33,39);
        pushFollow(FOLLOW_t_lineto_in_synpred14_TikzGrammar565);
        t_lineto();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred14_TikzGrammar

    // $ANTLR start synpred15_TikzGrammar
    public final void synpred15_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:50: ( t_moveto )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:50: t_moveto
        {
        dbg.location(33,50);
        pushFollow(FOLLOW_t_moveto_in_synpred15_TikzGrammar569);
        t_moveto();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred15_TikzGrammar

    // $ANTLR start synpred16_TikzGrammar
    public final void synpred16_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:61: ( t_lineto_hv )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:33:61: t_lineto_hv
        {
        dbg.location(33,61);
        pushFollow(FOLLOW_t_lineto_hv_in_synpred16_TikzGrammar573);
        t_lineto_hv();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred16_TikzGrammar

    // $ANTLR start synpred17_TikzGrammar
    public final void synpred17_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:27: ( t_lineto_vh )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:27: t_lineto_vh
        {
        dbg.location(34,27);
        pushFollow(FOLLOW_t_lineto_vh_in_synpred17_TikzGrammar602);
        t_lineto_vh();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred17_TikzGrammar

    // $ANTLR start synpred18_TikzGrammar
    public final void synpred18_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:41: ( t_cycle )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:41: t_cycle
        {
        dbg.location(34,41);
        pushFollow(FOLLOW_t_cycle_in_synpred18_TikzGrammar606);
        t_cycle();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred18_TikzGrammar

    // $ANTLR start synpred19_TikzGrammar
    public final void synpred19_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:51: ( t_curve )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:51: t_curve
        {
        dbg.location(34,51);
        pushFollow(FOLLOW_t_curve_in_synpred19_TikzGrammar610);
        t_curve();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred19_TikzGrammar

    // $ANTLR start synpred20_TikzGrammar
    public final void synpred20_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:60: ( t_rectangle )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:60: t_rectangle
        {
        dbg.location(34,60);
        pushFollow(FOLLOW_t_rectangle_in_synpred20_TikzGrammar613);
        t_rectangle();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred20_TikzGrammar

    // $ANTLR start synpred21_TikzGrammar
    public final void synpred21_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:74: ( t_gird )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:74: t_gird
        {
        dbg.location(34,74);
        pushFollow(FOLLOW_t_gird_in_synpred21_TikzGrammar617);
        t_gird();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred21_TikzGrammar

    // $ANTLR start synpred22_TikzGrammar
    public final void synpred22_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:83: ( t_parabola )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:83: t_parabola
        {
        dbg.location(34,83);
        pushFollow(FOLLOW_t_parabola_in_synpred22_TikzGrammar621);
        t_parabola();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred22_TikzGrammar

    // $ANTLR start synpred23_TikzGrammar
    public final void synpred23_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:96: ( t_plot )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:96: t_plot
        {
        dbg.location(34,96);
        pushFollow(FOLLOW_t_plot_in_synpred23_TikzGrammar625);
        t_plot();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred23_TikzGrammar

    // $ANTLR start synpred24_TikzGrammar
    public final void synpred24_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:105: ( t_edge )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:34:105: t_edge
        {
        dbg.location(34,105);
        pushFollow(FOLLOW_t_edge_in_synpred24_TikzGrammar629);
        t_edge();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred24_TikzGrammar

    // $ANTLR start synpred25_TikzGrammar
    public final void synpred25_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:27: ( t_to_path )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:27: t_to_path
        {
        dbg.location(35,27);
        pushFollow(FOLLOW_t_to_path_in_synpred25_TikzGrammar658);
        t_to_path();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred25_TikzGrammar

    // $ANTLR start synpred26_TikzGrammar
    public final void synpred26_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:39: ( t_to_path )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:39: t_to_path
        {
        dbg.location(35,39);
        pushFollow(FOLLOW_t_to_path_in_synpred26_TikzGrammar662);
        t_to_path();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred26_TikzGrammar

    // $ANTLR start synpred27_TikzGrammar
    public final void synpred27_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:52: ( t_foreach )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:52: t_foreach
        {
        dbg.location(35,52);
        pushFollow(FOLLOW_t_foreach_in_synpred27_TikzGrammar667);
        t_foreach();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred27_TikzGrammar

    // $ANTLR start synpred28_TikzGrammar
    public final void synpred28_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:64: ( t_edge )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:64: t_edge
        {
        dbg.location(35,64);
        pushFollow(FOLLOW_t_edge_in_synpred28_TikzGrammar671);
        t_edge();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred28_TikzGrammar

    // $ANTLR start synpred29_TikzGrammar
    public final void synpred29_TikzGrammar_fragment() throws RecognitionException {   
        List list_add_blocks=null;
        RuleReturnScope add_blocks = null;
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:73: (add_blocks+= curly_brackets )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:73: add_blocks+= curly_brackets
        {
        dbg.location(35,83);
        pushFollow(FOLLOW_curly_brackets_in_synpred29_TikzGrammar677);
        add_blocks=curly_brackets();

        state._fsp--;
        if (state.failed) return ;
        if (list_add_blocks==null) list_add_blocks=new ArrayList();
        list_add_blocks.add(add_blocks);


        }
    }
    // $ANTLR end synpred29_TikzGrammar

    // $ANTLR start synpred30_TikzGrammar
    public final void synpred30_TikzGrammar_fragment() throws RecognitionException {   
        List list_add_blocks=null;
        RuleReturnScope add_blocks = null;
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:101: (add_blocks+= t_block )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:35:101: add_blocks+= t_block
        {
        dbg.location(35,111);
        pushFollow(FOLLOW_t_block_in_synpred30_TikzGrammar682);
        add_blocks=t_block();

        state._fsp--;
        if (state.failed) return ;
        if (list_add_blocks==null) list_add_blocks=new ArrayList();
        list_add_blocks.add(add_blocks);


        }
    }
    // $ANTLR end synpred30_TikzGrammar

    // $ANTLR start synpred31_TikzGrammar
    public final void synpred31_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:27: ( t_circle )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:27: t_circle
        {
        dbg.location(36,27);
        pushFollow(FOLLOW_t_circle_in_synpred31_TikzGrammar711);
        t_circle();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred31_TikzGrammar

    // $ANTLR start synpred32_TikzGrammar
    public final void synpred32_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:38: ( t_ellipse )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:38: t_ellipse
        {
        dbg.location(36,38);
        pushFollow(FOLLOW_t_ellipse_in_synpred32_TikzGrammar715);
        t_ellipse();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred32_TikzGrammar

    // $ANTLR start synpred33_TikzGrammar
    public final void synpred33_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:50: ( t_arc )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:50: t_arc
        {
        dbg.location(36,50);
        pushFollow(FOLLOW_t_arc_in_synpred33_TikzGrammar719);
        t_arc();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred33_TikzGrammar

    // $ANTLR start synpred34_TikzGrammar
    public final void synpred34_TikzGrammar_fragment() throws RecognitionException {   
        List list_str=null;
        RuleReturnScope str = null;
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:57: (str+= string )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:57: str+= string
        {
        dbg.location(36,60);
        pushFollow(FOLLOW_string_in_synpred34_TikzGrammar724);
        str=string();

        state._fsp--;
        if (state.failed) return ;
        if (list_str==null) list_str=new ArrayList();
        list_str.add(str);


        }
    }
    // $ANTLR end synpred34_TikzGrammar

    // $ANTLR start synpred35_TikzGrammar
    public final void synpred35_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:71: ( t_foreach )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:71: t_foreach
        {
        dbg.location(36,71);
        pushFollow(FOLLOW_t_foreach_in_synpred35_TikzGrammar728);
        t_foreach();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred35_TikzGrammar

    // $ANTLR start synpred36_TikzGrammar
    public final void synpred36_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:83: ( t_node )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:83: t_node
        {
        dbg.location(36,83);
        pushFollow(FOLLOW_t_node_in_synpred36_TikzGrammar732);
        t_node();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred36_TikzGrammar

    // $ANTLR start synpred37_TikzGrammar
    public final void synpred37_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:92: ( t_coordinate )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:36:92: t_coordinate
        {
        dbg.location(36,92);
        pushFollow(FOLLOW_t_coordinate_in_synpred37_TikzGrammar736);
        t_coordinate();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred37_TikzGrammar

    // $ANTLR start synpred38_TikzGrammar
    public final void synpred38_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:41:19: ( ';' )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:41:19: ';'
        {
        dbg.location(41,19);
        match(input,76,FOLLOW_76_in_synpred38_TikzGrammar961); if (state.failed) return ;

        }
    }
    // $ANTLR end synpred38_TikzGrammar

    // $ANTLR start synpred41_TikzGrammar
    public final void synpred41_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:27: ( function )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:27: function
        {
        dbg.location(50,27);
        pushFollow(FOLLOW_function_in_synpred41_TikzGrammar1066);
        function();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred41_TikzGrammar

    // $ANTLR start synpred42_TikzGrammar
    public final void synpred42_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:38: ( curly_brackets )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:38: curly_brackets
        {
        dbg.location(50,38);
        pushFollow(FOLLOW_curly_brackets_in_synpred42_TikzGrammar1070);
        curly_brackets();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred42_TikzGrammar

    // $ANTLR start synpred43_TikzGrammar
    public final void synpred43_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:55: ( t_list )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:55: t_list
        {
        dbg.location(50,55);
        pushFollow(FOLLOW_t_list_in_synpred43_TikzGrammar1074);
        t_list();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred43_TikzGrammar

    // $ANTLR start synpred44_TikzGrammar
    public final void synpred44_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:63: ( t_macro )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:50:63: t_macro
        {
        dbg.location(50,63);
        pushFollow(FOLLOW_t_macro_in_synpred44_TikzGrammar1077);
        t_macro();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred44_TikzGrammar

    // $ANTLR start synpred45_TikzGrammar
    public final void synpred45_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:63:20: ( t_list_elem )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:63:20: t_list_elem
        {
        dbg.location(63,20);
        pushFollow(FOLLOW_t_list_elem_in_synpred45_TikzGrammar1230);
        t_list_elem();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred45_TikzGrammar

    // $ANTLR start synpred48_TikzGrammar
    public final void synpred48_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:63:46: ( AND )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:63:46: AND
        {
        dbg.location(63,46);
        match(input,AND,FOLLOW_AND_in_synpred48_TikzGrammar1242); if (state.failed) return ;

        }
    }
    // $ANTLR end synpred48_TikzGrammar

    // $ANTLR start synpred50_TikzGrammar
    public final void synpred50_TikzGrammar_fragment() throws RecognitionException {   
        List list_elem_name=null;
        RuleReturnScope elem_name = null;
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:42: (elem_name+= string )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:42: elem_name+= string
        {
        dbg.location(68,51);
        pushFollow(FOLLOW_string_in_synpred50_TikzGrammar1313);
        elem_name=string();

        state._fsp--;
        if (state.failed) return ;
        if (list_elem_name==null) list_elem_name=new ArrayList();
        list_elem_name.add(elem_name);


        }
    }
    // $ANTLR end synpred50_TikzGrammar

    // $ANTLR start synpred56_TikzGrammar
    public final void synpred56_TikzGrammar_fragment() throws RecognitionException {   
        List list_elem_value=null;
        RuleReturnScope elem_value = null;
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:60: (elem_value+= string )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:60: elem_value+= string
        {
        dbg.location(69,70);
        pushFollow(FOLLOW_string_in_synpred56_TikzGrammar1373);
        elem_value=string();

        state._fsp--;
        if (state.failed) return ;
        if (list_elem_value==null) list_elem_value=new ArrayList();
        list_elem_value.add(elem_value);


        }
    }
    // $ANTLR end synpred56_TikzGrammar

    // $ANTLR start synpred57_TikzGrammar
    public final void synpred57_TikzGrammar_fragment() throws RecognitionException {   
        List list_elem_value=null;
        RuleReturnScope elem_value = null;
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:81: (elem_value+= function )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:81: elem_value+= function
        {
        dbg.location(69,91);
        pushFollow(FOLLOW_function_in_synpred57_TikzGrammar1379);
        elem_value=function();

        state._fsp--;
        if (state.failed) return ;
        if (list_elem_value==null) list_elem_value=new ArrayList();
        list_elem_value.add(elem_value);


        }
    }
    // $ANTLR end synpred57_TikzGrammar

    // $ANTLR start synpred60_TikzGrammar
    public final void synpred60_TikzGrammar_fragment() throws RecognitionException {   
        List list_elem_name=null;
        List list_elem_value=null;
        TikzGrammarParser.multioperator_return oper = null;

        RuleReturnScope elem_name = null;
        RuleReturnScope elem_value = null;
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:17: ( ( (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )? oper= multioperator (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto ) ) )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:17: ( (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )? oper= multioperator (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto ) )
        {
        dbg.location(68,17);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:17: ( (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )? oper= multioperator (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto ) )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:19: (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )? oper= multioperator (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto )
        {
        dbg.location(68,19);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:19: (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )?
        int alt57=7;
        try { dbg.enterSubRule(57);
        try { dbg.enterDecision(57);

        try {
            isCyclicDecision = true;
            alt57 = dfa57.predict(input);
        }
        catch (NoViableAltException nvae) {
            dbg.recognitionException(nvae);
            throw nvae;
        }
        } finally {dbg.exitDecision(57);}

        switch (alt57) {
            case 1 :
                dbg.enterAlt(1);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:21: elem_name+= t_macro
                {
                dbg.location(68,30);
                pushFollow(FOLLOW_t_macro_in_synpred60_TikzGrammar1307);
                elem_name=t_macro();

                state._fsp--;
                if (state.failed) return ;
                if (list_elem_name==null) list_elem_name=new ArrayList();
                list_elem_name.add(elem_name);


                }
                break;
            case 2 :
                dbg.enterAlt(2);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:42: elem_name+= string
                {
                dbg.location(68,51);
                pushFollow(FOLLOW_string_in_synpred60_TikzGrammar1313);
                elem_name=string();

                state._fsp--;
                if (state.failed) return ;
                if (list_elem_name==null) list_elem_name=new ArrayList();
                list_elem_name.add(elem_name);


                }
                break;
            case 3 :
                dbg.enterAlt(3);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:62: elem_name+= function
                {
                dbg.location(68,71);
                pushFollow(FOLLOW_function_in_synpred60_TikzGrammar1319);
                elem_name=function();

                state._fsp--;
                if (state.failed) return ;
                if (list_elem_name==null) list_elem_name=new ArrayList();
                list_elem_name.add(elem_name);


                }
                break;
            case 4 :
                dbg.enterAlt(4);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:84: elem_name+= curly_brackets
                {
                dbg.location(68,93);
                pushFollow(FOLLOW_curly_brackets_in_synpred60_TikzGrammar1325);
                elem_name=curly_brackets();

                state._fsp--;
                if (state.failed) return ;
                if (list_elem_name==null) list_elem_name=new ArrayList();
                list_elem_name.add(elem_name);


                }
                break;
            case 5 :
                dbg.enterAlt(5);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:113: elem_name+= square_brackets
                {
                dbg.location(68,122);
                pushFollow(FOLLOW_square_brackets_in_synpred60_TikzGrammar1332);
                elem_name=square_brackets();

                state._fsp--;
                if (state.failed) return ;
                if (list_elem_name==null) list_elem_name=new ArrayList();
                list_elem_name.add(elem_name);


                }
                break;
            case 6 :
                dbg.enterAlt(6);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:68:142: elem_name+= t_lineto
                {
                dbg.location(68,151);
                pushFollow(FOLLOW_t_lineto_in_synpred60_TikzGrammar1338);
                elem_name=t_lineto();

                state._fsp--;
                if (state.failed) return ;
                if (list_elem_name==null) list_elem_name=new ArrayList();
                list_elem_name.add(elem_name);


                }
                break;

        }
        } finally {dbg.exitSubRule(57);}

        dbg.location(69,21);
        pushFollow(FOLLOW_multioperator_in_synpred60_TikzGrammar1361);
        oper=multioperator();

        state._fsp--;
        if (state.failed) return ;
        dbg.location(69,36);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:36: (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto )
        int alt58=6;
        try { dbg.enterSubRule(58);
        try { dbg.enterDecision(58);

        switch ( input.LA(1) ) {
        case BACKSLASH:
            {
            alt58=1;
            }
            break;
        case BEGIN:
        case END:
        case AND:
        case OPERATOR:
        case STRING:
        case HVLINE:
        case VHLINE:
        case TO:
        case IN:
        case CYCLE:
        case FOREACH:
        case CS:
        case NODE:
        case AT:
        case FUNCTION:
        case FILE:
        case COORDINATES:
        case COORDINATE:
        case EDGE:
        case CONTROLS:
        case FROM:
        case PARENT:
        case DOTS:
        case RECTANGLE:
        case GRID:
        case PLOT:
        case CHILD:
        case CIRCLE:
        case ELLIPSE:
        case ARC:
        case PARABOLA:
        case BEND:
            {
            alt58=2;
            }
            break;
        case FUNC:
            {
            int LA58_3 = input.LA(2);

            if ( (LA58_3==EOF) ) {
                alt58=2;
            }
            else if ( (LA58_3==77) ) {
                alt58=3;
            }
            else {
                if (state.backtracking>0) {state.failed=true; return ;}
                NoViableAltException nvae =
                    new NoViableAltException("", 58, 3, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            }
            break;
        case 77:
            {
            alt58=3;
            }
            break;
        case 74:
            {
            alt58=4;
            }
            break;
        case 79:
            {
            alt58=5;
            }
            break;
        case LINE:
            {
            alt58=6;
            }
            break;
        default:
            if (state.backtracking>0) {state.failed=true; return ;}
            NoViableAltException nvae =
                new NoViableAltException("", 58, 0, input);

            dbg.recognitionException(nvae);
            throw nvae;
        }

        } finally {dbg.exitDecision(58);}

        switch (alt58) {
            case 1 :
                dbg.enterAlt(1);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:38: elem_value+= t_macro
                {
                dbg.location(69,48);
                pushFollow(FOLLOW_t_macro_in_synpred60_TikzGrammar1367);
                elem_value=t_macro();

                state._fsp--;
                if (state.failed) return ;
                if (list_elem_value==null) list_elem_value=new ArrayList();
                list_elem_value.add(elem_value);


                }
                break;
            case 2 :
                dbg.enterAlt(2);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:60: elem_value+= string
                {
                dbg.location(69,70);
                pushFollow(FOLLOW_string_in_synpred60_TikzGrammar1373);
                elem_value=string();

                state._fsp--;
                if (state.failed) return ;
                if (list_elem_value==null) list_elem_value=new ArrayList();
                list_elem_value.add(elem_value);


                }
                break;
            case 3 :
                dbg.enterAlt(3);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:81: elem_value+= function
                {
                dbg.location(69,91);
                pushFollow(FOLLOW_function_in_synpred60_TikzGrammar1379);
                elem_value=function();

                state._fsp--;
                if (state.failed) return ;
                if (list_elem_value==null) list_elem_value=new ArrayList();
                list_elem_value.add(elem_value);


                }
                break;
            case 4 :
                dbg.enterAlt(4);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:104: elem_value+= curly_brackets
                {
                dbg.location(69,114);
                pushFollow(FOLLOW_curly_brackets_in_synpred60_TikzGrammar1385);
                elem_value=curly_brackets();

                state._fsp--;
                if (state.failed) return ;
                if (list_elem_value==null) list_elem_value=new ArrayList();
                list_elem_value.add(elem_value);


                }
                break;
            case 5 :
                dbg.enterAlt(5);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:134: elem_value+= square_brackets
                {
                dbg.location(69,144);
                pushFollow(FOLLOW_square_brackets_in_synpred60_TikzGrammar1392);
                elem_value=square_brackets();

                state._fsp--;
                if (state.failed) return ;
                if (list_elem_value==null) list_elem_value=new ArrayList();
                list_elem_value.add(elem_value);


                }
                break;
            case 6 :
                dbg.enterAlt(6);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:69:164: elem_name+= t_lineto
                {
                dbg.location(69,173);
                pushFollow(FOLLOW_t_lineto_in_synpred60_TikzGrammar1398);
                elem_name=t_lineto();

                state._fsp--;
                if (state.failed) return ;
                if (list_elem_name==null) list_elem_name=new ArrayList();
                list_elem_name.add(elem_name);


                }
                break;

        }
        } finally {dbg.exitSubRule(58);}


        }


        }
    }
    // $ANTLR end synpred60_TikzGrammar

    // $ANTLR start synpred62_TikzGrammar
    public final void synpred62_TikzGrammar_fragment() throws RecognitionException {   
        List list_elem_name=null;
        RuleReturnScope elem_name = null;
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:71:42: (elem_name+= string )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:71:42: elem_name+= string
        {
        dbg.location(71,51);
        pushFollow(FOLLOW_string_in_synpred62_TikzGrammar1475);
        elem_name=string();

        state._fsp--;
        if (state.failed) return ;
        if (list_elem_name==null) list_elem_name=new ArrayList();
        list_elem_name.add(elem_name);


        }
    }
    // $ANTLR end synpred62_TikzGrammar

    // $ANTLR start synpred63_TikzGrammar
    public final void synpred63_TikzGrammar_fragment() throws RecognitionException {   
        List list_elem_name=null;
        RuleReturnScope elem_name = null;
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:71:62: (elem_name+= function )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:71:62: elem_name+= function
        {
        dbg.location(71,71);
        pushFollow(FOLLOW_function_in_synpred63_TikzGrammar1481);
        elem_name=function();

        state._fsp--;
        if (state.failed) return ;
        if (list_elem_name==null) list_elem_name=new ArrayList();
        list_elem_name.add(elem_name);


        }
    }
    // $ANTLR end synpred63_TikzGrammar

    // $ANTLR start synpred69_TikzGrammar
    public final void synpred69_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:83:17: ( OPERATOR )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:83:17: OPERATOR
        {
        dbg.location(83,17);
        match(input,OPERATOR,FOLLOW_OPERATOR_in_synpred69_TikzGrammar1707); if (state.failed) return ;

        }
    }
    // $ANTLR end synpred69_TikzGrammar

    // $ANTLR start synpred71_TikzGrammar
    public final void synpred71_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:28: ( STRING )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:28: STRING
        {
        dbg.location(88,28);
        match(input,STRING,FOLLOW_STRING_in_synpred71_TikzGrammar1762); if (state.failed) return ;

        }
    }
    // $ANTLR end synpred71_TikzGrammar

    // $ANTLR start synpred72_TikzGrammar
    public final void synpred72_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:17: ( ( ( OPERATOR )* ( STRING )+ ) )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:17: ( ( OPERATOR )* ( STRING )+ )
        {
        dbg.location(88,17);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:17: ( ( OPERATOR )* ( STRING )+ )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:18: ( OPERATOR )* ( STRING )+
        {
        dbg.location(88,18);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:18: ( OPERATOR )*
        try { dbg.enterSubRule(59);

        loop59:
        do {
            int alt59=2;
            try { dbg.enterDecision(59);

            int LA59_0 = input.LA(1);

            if ( (LA59_0==OPERATOR) ) {
                alt59=1;
            }


            } finally {dbg.exitDecision(59);}

            switch (alt59) {
        	case 1 :
        	    dbg.enterAlt(1);

        	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: OPERATOR
        	    {
        	    dbg.location(88,18);
        	    match(input,OPERATOR,FOLLOW_OPERATOR_in_synpred72_TikzGrammar1759); if (state.failed) return ;

        	    }
        	    break;

        	default :
        	    break loop59;
            }
        } while (true);
        } finally {dbg.exitSubRule(59);}

        dbg.location(88,28);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:88:28: ( STRING )+
        int cnt60=0;
        try { dbg.enterSubRule(60);

        loop60:
        do {
            int alt60=2;
            try { dbg.enterDecision(60);

            int LA60_0 = input.LA(1);

            if ( (LA60_0==STRING) ) {
                alt60=1;
            }


            } finally {dbg.exitDecision(60);}

            switch (alt60) {
        	case 1 :
        	    dbg.enterAlt(1);

        	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: STRING
        	    {
        	    dbg.location(88,28);
        	    match(input,STRING,FOLLOW_STRING_in_synpred72_TikzGrammar1762); if (state.failed) return ;

        	    }
        	    break;

        	default :
        	    if ( cnt60 >= 1 ) break loop60;
        	    if (state.backtracking>0) {state.failed=true; return ;}
                    EarlyExitException eee =
                        new EarlyExitException(60, input);
                    dbg.recognitionException(eee);

                    throw eee;
            }
            cnt60++;
        } while (true);
        } finally {dbg.exitSubRule(60);}


        }


        }
    }
    // $ANTLR end synpred72_TikzGrammar

    // $ANTLR start synpred73_TikzGrammar
    public final void synpred73_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:89:19: ( OPERATOR )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:89:19: OPERATOR
        {
        dbg.location(89,19);
        match(input,OPERATOR,FOLLOW_OPERATOR_in_synpred73_TikzGrammar1784); if (state.failed) return ;

        }
    }
    // $ANTLR end synpred73_TikzGrammar

    // $ANTLR start synpred74_TikzGrammar
    public final void synpred74_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:89:19: ( ( OPERATOR )+ )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:89:19: ( OPERATOR )+
        {
        dbg.location(89,19);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:89:19: ( OPERATOR )+
        int cnt61=0;
        try { dbg.enterSubRule(61);

        loop61:
        do {
            int alt61=2;
            try { dbg.enterDecision(61);

            int LA61_0 = input.LA(1);

            if ( (LA61_0==OPERATOR) ) {
                alt61=1;
            }


            } finally {dbg.exitDecision(61);}

            switch (alt61) {
        	case 1 :
        	    dbg.enterAlt(1);

        	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: OPERATOR
        	    {
        	    dbg.location(89,19);
        	    match(input,OPERATOR,FOLLOW_OPERATOR_in_synpred74_TikzGrammar1784); if (state.failed) return ;

        	    }
        	    break;

        	default :
        	    if ( cnt61 >= 1 ) break loop61;
        	    if (state.backtracking>0) {state.failed=true; return ;}
                    EarlyExitException eee =
                        new EarlyExitException(61, input);
                    dbg.recognitionException(eee);

                    throw eee;
            }
            cnt61++;
        } while (true);
        } finally {dbg.exitSubRule(61);}


        }
    }
    // $ANTLR end synpred74_TikzGrammar

    // $ANTLR start synpred107_TikzGrammar
    public final void synpred107_TikzGrammar_fragment() throws RecognitionException {   
        TikzGrammarParser.string_return cs_name = null;


        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:81: (cs_name= string CS )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:81: cs_name= string CS
        {
        dbg.location(97,88);
        pushFollow(FOLLOW_string_in_synpred107_TikzGrammar1995);
        cs_name=string();

        state._fsp--;
        if (state.failed) return ;
        dbg.location(97,96);
        match(input,CS,FOLLOW_CS_in_synpred107_TikzGrammar1997); if (state.failed) return ;

        }
    }
    // $ANTLR end synpred107_TikzGrammar

    // $ANTLR start synpred109_TikzGrammar
    public final void synpred109_TikzGrammar_fragment() throws RecognitionException {   
        TikzGrammarParser.string_return cs_name = null;


        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:56: ( AT ( multioperator )? '(' (cs_name= string CS )? ( t_options )* t_list ')' )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:56: AT ( multioperator )? '(' (cs_name= string CS )? ( t_options )* t_list ')'
        {
        dbg.location(97,56);
        match(input,AT,FOLLOW_AT_in_synpred109_TikzGrammar1983); if (state.failed) return ;
        dbg.location(97,59);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:59: ( multioperator )?
        int alt62=2;
        try { dbg.enterSubRule(62);
        try { dbg.enterDecision(62);

        int LA62_0 = input.LA(1);

        if ( (LA62_0==OPERATOR) ) {
            alt62=1;
        }
        } finally {dbg.exitDecision(62);}

        switch (alt62) {
            case 1 :
                dbg.enterAlt(1);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: multioperator
                {
                dbg.location(97,59);
                pushFollow(FOLLOW_multioperator_in_synpred109_TikzGrammar1985);
                multioperator();

                state._fsp--;
                if (state.failed) return ;

                }
                break;

        }
        } finally {dbg.exitSubRule(62);}

        dbg.location(97,75);
        match(input,77,FOLLOW_77_in_synpred109_TikzGrammar1989); if (state.failed) return ;
        dbg.location(97,79);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:79: (cs_name= string CS )?
        int alt63=2;
        try { dbg.enterSubRule(63);
        try { dbg.enterDecision(63);

        try {
            isCyclicDecision = true;
            alt63 = dfa63.predict(input);
        }
        catch (NoViableAltException nvae) {
            dbg.recognitionException(nvae);
            throw nvae;
        }
        } finally {dbg.exitDecision(63);}

        switch (alt63) {
            case 1 :
                dbg.enterAlt(1);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:81: cs_name= string CS
                {
                dbg.location(97,88);
                pushFollow(FOLLOW_string_in_synpred109_TikzGrammar1995);
                cs_name=string();

                state._fsp--;
                if (state.failed) return ;
                dbg.location(97,96);
                match(input,CS,FOLLOW_CS_in_synpred109_TikzGrammar1997); if (state.failed) return ;

                }
                break;

        }
        } finally {dbg.exitSubRule(63);}

        dbg.location(97,102);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:97:102: ( t_options )*
        try { dbg.enterSubRule(64);

        loop64:
        do {
            int alt64=2;
            try { dbg.enterDecision(64);

            int LA64_0 = input.LA(1);

            if ( (LA64_0==79) ) {
                int LA64_2 = input.LA(2);

                if ( ((LA64_2>=BACKSLASH && LA64_2<=LINE)||LA64_2==74||LA64_2==77||LA64_2==79||(LA64_2>=81 && LA64_2<=82)) ) {
                    alt64=1;
                }


            }


            } finally {dbg.exitDecision(64);}

            switch (alt64) {
        	case 1 :
        	    dbg.enterAlt(1);

        	    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
        	    {
        	    dbg.location(97,102);
        	    pushFollow(FOLLOW_t_options_in_synpred109_TikzGrammar2002);
        	    t_options();

        	    state._fsp--;
        	    if (state.failed) return ;

        	    }
        	    break;

        	default :
        	    break loop64;
            }
        } while (true);
        } finally {dbg.exitSubRule(64);}

        dbg.location(97,113);
        pushFollow(FOLLOW_t_list_in_synpred109_TikzGrammar2005);
        t_list();

        state._fsp--;
        if (state.failed) return ;
        dbg.location(97,120);
        match(input,78,FOLLOW_78_in_synpred109_TikzGrammar2007); if (state.failed) return ;

        }
    }
    // $ANTLR end synpred109_TikzGrammar

    // $ANTLR start synpred112_TikzGrammar
    public final void synpred112_TikzGrammar_fragment() throws RecognitionException {   
        TikzGrammarParser.string_return cs_name = null;


        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:99:38: (cs_name= string CS )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:99:38: cs_name= string CS
        {
        dbg.location(99,45);
        pushFollow(FOLLOW_string_in_synpred112_TikzGrammar2087);
        cs_name=string();

        state._fsp--;
        if (state.failed) return ;
        dbg.location(99,53);
        match(input,CS,FOLLOW_CS_in_synpred112_TikzGrammar2089); if (state.failed) return ;

        }
    }
    // $ANTLR end synpred112_TikzGrammar

    // $ANTLR start synpred115_TikzGrammar
    public final void synpred115_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:127:17: ( TO ( t_options )? t_coordinate )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:127:17: TO ( t_options )? t_coordinate
        {
        dbg.location(127,17);
        match(input,TO,FOLLOW_TO_in_synpred115_TikzGrammar2444); if (state.failed) return ;
        dbg.location(127,20);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:127:20: ( t_options )?
        int alt70=2;
        try { dbg.enterSubRule(70);
        try { dbg.enterDecision(70);

        int LA70_0 = input.LA(1);

        if ( (LA70_0==79) ) {
            alt70=1;
        }
        } finally {dbg.exitDecision(70);}

        switch (alt70) {
            case 1 :
                dbg.enterAlt(1);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                {
                dbg.location(127,20);
                pushFollow(FOLLOW_t_options_in_synpred115_TikzGrammar2446);
                t_options();

                state._fsp--;
                if (state.failed) return ;

                }
                break;

        }
        } finally {dbg.exitSubRule(70);}

        dbg.location(127,31);
        pushFollow(FOLLOW_t_coordinate_in_synpred115_TikzGrammar2449);
        t_coordinate();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred115_TikzGrammar

    // $ANTLR start synpred118_TikzGrammar
    public final void synpred118_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:129:62: ( t_coordinate )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:129:62: t_coordinate
        {
        dbg.location(129,62);
        pushFollow(FOLLOW_t_coordinate_in_synpred118_TikzGrammar2505);
        t_coordinate();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred118_TikzGrammar

    // $ANTLR start synpred119_TikzGrammar
    public final void synpred119_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:22: ( t_options )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:22: t_options
        {
        dbg.location(138,22);
        pushFollow(FOLLOW_t_options_in_synpred119_TikzGrammar2570);
        t_options();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred119_TikzGrammar

    // $ANTLR start synpred123_TikzGrammar
    public final void synpred123_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:97: ( CHILD )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:138:97: CHILD
        {
        dbg.location(138,97);
        match(input,CHILD,FOLLOW_CHILD_in_synpred123_TikzGrammar2595); if (state.failed) return ;

        }
    }
    // $ANTLR end synpred123_TikzGrammar

    // $ANTLR start synpred130_TikzGrammar
    public final void synpred130_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:157:25: ( ( ( t_options )? t_coordinate ) )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:157:25: ( ( t_options )? t_coordinate )
        {
        dbg.location(157,25);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:157:25: ( ( t_options )? t_coordinate )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:157:27: ( t_options )? t_coordinate
        {
        dbg.location(157,27);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:157:27: ( t_options )?
        int alt72=2;
        try { dbg.enterSubRule(72);
        try { dbg.enterDecision(72);

        int LA72_0 = input.LA(1);

        if ( (LA72_0==79) ) {
            alt72=1;
        }
        } finally {dbg.exitDecision(72);}

        switch (alt72) {
            case 1 :
                dbg.enterAlt(1);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                {
                dbg.location(157,27);
                pushFollow(FOLLOW_t_options_in_synpred130_TikzGrammar2958);
                t_options();

                state._fsp--;
                if (state.failed) return ;

                }
                break;

        }
        } finally {dbg.exitSubRule(72);}

        dbg.location(157,38);
        pushFollow(FOLLOW_t_coordinate_in_synpred130_TikzGrammar2961);
        t_coordinate();

        state._fsp--;
        if (state.failed) return ;

        }


        }
    }
    // $ANTLR end synpred130_TikzGrammar

    // $ANTLR start synpred133_TikzGrammar
    public final void synpred133_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:71: ( t_coordinate )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:71: t_coordinate
        {
        dbg.location(159,71);
        pushFollow(FOLLOW_t_coordinate_in_synpred133_TikzGrammar3036);
        t_coordinate();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred133_TikzGrammar

    // $ANTLR start synpred134_TikzGrammar
    public final void synpred134_TikzGrammar_fragment() throws RecognitionException {   
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:27: ( ( ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )? ) )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:27: ( ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )? )
        {
        dbg.location(159,27);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:27: ( ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )? )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:29: ( t_options )? NODE ( t_options )? curly_brackets ( t_coordinate )?
        {
        dbg.location(159,29);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:29: ( t_options )?
        int alt73=2;
        try { dbg.enterSubRule(73);
        try { dbg.enterDecision(73);

        int LA73_0 = input.LA(1);

        if ( (LA73_0==79) ) {
            alt73=1;
        }
        } finally {dbg.exitDecision(73);}

        switch (alt73) {
            case 1 :
                dbg.enterAlt(1);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                {
                dbg.location(159,29);
                pushFollow(FOLLOW_t_options_in_synpred134_TikzGrammar3026);
                t_options();

                state._fsp--;
                if (state.failed) return ;

                }
                break;

        }
        } finally {dbg.exitSubRule(73);}

        dbg.location(159,40);
        match(input,NODE,FOLLOW_NODE_in_synpred134_TikzGrammar3029); if (state.failed) return ;
        dbg.location(159,45);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:45: ( t_options )?
        int alt74=2;
        try { dbg.enterSubRule(74);
        try { dbg.enterDecision(74);

        int LA74_0 = input.LA(1);

        if ( (LA74_0==79) ) {
            alt74=1;
        }
        } finally {dbg.exitDecision(74);}

        switch (alt74) {
            case 1 :
                dbg.enterAlt(1);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_options
                {
                dbg.location(159,45);
                pushFollow(FOLLOW_t_options_in_synpred134_TikzGrammar3031);
                t_options();

                state._fsp--;
                if (state.failed) return ;

                }
                break;

        }
        } finally {dbg.exitSubRule(74);}

        dbg.location(159,56);
        pushFollow(FOLLOW_curly_brackets_in_synpred134_TikzGrammar3034);
        curly_brackets();

        state._fsp--;
        if (state.failed) return ;
        dbg.location(159,71);
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:159:71: ( t_coordinate )?
        int alt75=2;
        try { dbg.enterSubRule(75);
        try { dbg.enterDecision(75);

        int LA75_0 = input.LA(1);

        if ( (LA75_0==OPERATOR||LA75_0==COORDINATE||LA75_0==77) ) {
            alt75=1;
        }
        } finally {dbg.exitDecision(75);}

        switch (alt75) {
            case 1 :
                dbg.enterAlt(1);

                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:0:0: t_coordinate
                {
                dbg.location(159,71);
                pushFollow(FOLLOW_t_coordinate_in_synpred134_TikzGrammar3036);
                t_coordinate();

                state._fsp--;
                if (state.failed) return ;

                }
                break;

        }
        } finally {dbg.exitSubRule(75);}


        }


        }
    }
    // $ANTLR end synpred134_TikzGrammar

    // $ANTLR start synpred137_TikzGrammar
    public final void synpred137_TikzGrammar_fragment() throws RecognitionException {   
        TikzGrammarParser.t_coordinate_return c2 = null;


        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:187:60: (c2= t_coordinate )
        dbg.enterAlt(1);

        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\TikzGrammar.g:187:60: c2= t_coordinate
        {
        dbg.location(187,60);
        pushFollow(FOLLOW_t_coordinate_in_synpred137_TikzGrammar3507);
        c2=t_coordinate();

        state._fsp--;
        if (state.failed) return ;

        }
    }
    // $ANTLR end synpred137_TikzGrammar

    // Delegated rules

    public final boolean synpred33_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred33_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred18_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred18_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred119_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred119_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred32_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred32_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred74_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred74_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred10_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred10_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred8_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred8_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred13_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred13_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred45_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred45_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred60_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred60_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred38_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred38_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred19_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred19_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred16_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred16_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred9_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred9_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred35_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred35_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred69_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred69_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred12_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred12_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred31_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred31_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred73_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred73_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred34_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred34_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred7_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred7_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred11_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred11_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred48_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred48_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred115_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred115_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred118_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred118_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred25_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred25_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred6_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred6_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred133_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred133_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred27_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred27_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred24_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred24_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred23_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred23_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred72_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred72_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred5_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred5_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred20_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred20_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred63_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred63_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred42_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred42_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred22_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred22_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred2_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred2_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred123_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred123_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred71_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred71_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred21_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred21_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred36_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred36_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred56_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred56_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred57_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred57_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred14_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred14_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred130_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred130_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred37_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred37_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred109_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred109_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred43_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred43_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred26_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred26_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred30_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred30_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred4_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred4_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred107_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred107_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred44_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred44_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred50_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred50_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred3_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred3_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred134_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred134_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred137_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred137_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred28_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred28_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred62_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred62_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred29_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred29_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred112_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred112_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred17_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred17_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred41_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred41_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }
    public final boolean synpred15_TikzGrammar() {
        state.backtracking++;
        dbg.beginBacktrack(state.backtracking);
        int start = input.mark();
        try {
            synpred15_TikzGrammar_fragment(); // can never throw exception
        } catch (RecognitionException re) {
            System.err.println("impossible: "+re);
        }
        boolean success = !state.failed;
        input.rewind(start);
        dbg.endBacktrack(state.backtracking, success);
        state.backtracking--;
        state.failed=false;
        return success;
    }


    protected DFA2 dfa2 = new DFA2(this);
    protected DFA3 dfa3 = new DFA3(this);
    protected DFA4 dfa4 = new DFA4(this);
    protected DFA7 dfa7 = new DFA7(this);
    protected DFA5 dfa5 = new DFA5(this);
    protected DFA6 dfa6 = new DFA6(this);
    protected DFA11 dfa11 = new DFA11(this);
    protected DFA12 dfa12 = new DFA12(this);
    protected DFA16 dfa16 = new DFA16(this);
    protected DFA13 dfa13 = new DFA13(this);
    protected DFA14 dfa14 = new DFA14(this);
    protected DFA22 dfa22 = new DFA22(this);
    protected DFA27 dfa27 = new DFA27(this);
    protected DFA25 dfa25 = new DFA25(this);
    protected DFA29 dfa29 = new DFA29(this);
    protected DFA35 dfa35 = new DFA35(this);
    protected DFA49 dfa49 = new DFA49(this);
    protected DFA53 dfa53 = new DFA53(this);
    protected DFA57 dfa57 = new DFA57(this);
    protected DFA63 dfa63 = new DFA63(this);
    static final String DFA2_eotS =
        "\56\uffff";
    static final String DFA2_eofS =
        "\56\uffff";
    static final String DFA2_minS =
        "\1\4\5\0\50\uffff";
    static final String DFA2_maxS =
        "\1\122\5\0\50\uffff";
    static final String DFA2_acceptS =
        "\6\uffff\1\5\42\uffff\1\1\1\2\1\3\1\4\1\6";
    static final String DFA2_specialS =
        "\1\uffff\1\0\1\1\1\2\1\3\1\4\50\uffff}>";
    static final String[] DFA2_transitionS = {
            "\1\5\2\6\1\1\37\6\43\uffff\1\4\2\uffff\1\2\1\uffff\1\3\1\uffff"+
            "\2\6",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
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
            ""
    };

    static final short[] DFA2_eot = DFA.unpackEncodedString(DFA2_eotS);
    static final short[] DFA2_eof = DFA.unpackEncodedString(DFA2_eofS);
    static final char[] DFA2_min = DFA.unpackEncodedStringToUnsignedChars(DFA2_minS);
    static final char[] DFA2_max = DFA.unpackEncodedStringToUnsignedChars(DFA2_maxS);
    static final short[] DFA2_accept = DFA.unpackEncodedString(DFA2_acceptS);
    static final short[] DFA2_special = DFA.unpackEncodedString(DFA2_specialS);
    static final short[][] DFA2_transition;

    static {
        int numStates = DFA2_transitionS.length;
        DFA2_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA2_transition[i] = DFA.unpackEncodedString(DFA2_transitionS[i]);
        }
    }

    class DFA2 extends DFA {

        public DFA2(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 2;
            this.eot = DFA2_eot;
            this.eof = DFA2_eof;
            this.min = DFA2_min;
            this.max = DFA2_max;
            this.accept = DFA2_accept;
            this.special = DFA2_special;
            this.transition = DFA2_transition;
        }
        public String getDescription() {
            return "13:17: ( function | square_brackets | curly_brackets | t_block | t_list | t_macro )";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA2_1 = input.LA(1);

                         
                        int index2_1 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred2_TikzGrammar()) ) {s = 41;}

                        else if ( (synpred6_TikzGrammar()) ) {s = 6;}

                         
                        input.seek(index2_1);
                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA2_2 = input.LA(1);

                         
                        int index2_2 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred2_TikzGrammar()) ) {s = 41;}

                        else if ( (synpred6_TikzGrammar()) ) {s = 6;}

                         
                        input.seek(index2_2);
                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA2_3 = input.LA(1);

                         
                        int index2_3 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred3_TikzGrammar()) ) {s = 42;}

                        else if ( (synpred6_TikzGrammar()) ) {s = 6;}

                         
                        input.seek(index2_3);
                        if ( s>=0 ) return s;
                        break;
                    case 3 : 
                        int LA2_4 = input.LA(1);

                         
                        int index2_4 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred4_TikzGrammar()) ) {s = 43;}

                        else if ( (synpred6_TikzGrammar()) ) {s = 6;}

                         
                        input.seek(index2_4);
                        if ( s>=0 ) return s;
                        break;
                    case 4 : 
                        int LA2_5 = input.LA(1);

                         
                        int index2_5 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred5_TikzGrammar()) ) {s = 44;}

                        else if ( (synpred6_TikzGrammar()) ) {s = 6;}

                        else if ( (true) ) {s = 45;}

                         
                        input.seek(index2_5);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 2, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA3_eotS =
        "\50\uffff";
    static final String DFA3_eofS =
        "\50\uffff";
    static final String DFA3_minS =
        "\2\4\1\uffff\41\4\1\0\2\4\1\uffff";
    static final String DFA3_maxS =
        "\2\122\1\uffff\41\122\1\0\2\122\1\uffff";
    static final String DFA3_acceptS =
        "\2\uffff\1\2\44\uffff\1\1";
    static final String DFA3_specialS =
        "\44\uffff\1\0\3\uffff}>";
    static final String[] DFA3_transitionS = {
            "\43\2\43\uffff\1\1\2\uffff\1\2\1\uffff\1\2\1\uffff\2\2",
            "\1\2\1\6\1\7\1\3\1\26\1\4\1\5\1\10\1\11\1\12\1\13\1\14\1\15"+
            "\1\16\1\17\1\20\1\21\1\22\1\23\1\24\1\25\1\27\1\30\1\31\1\32"+
            "\1\33\1\34\1\35\1\36\1\37\1\40\1\41\1\42\1\43\1\2\43\uffff\2"+
            "\2\1\uffff\1\2\1\uffff\1\2\1\uffff\2\2",
            "",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\5\2\1\46\1\45\34\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff"+
            "\1\2\1\uffff\2\2",
            "\6\2\1\5\34\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1"+
            "\uffff\2\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\1\uffff",
            "\6\2\1\45\34\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff\1\2\1"+
            "\uffff\2\2",
            "\5\2\1\46\1\45\34\2\43\uffff\1\2\1\44\1\uffff\1\2\1\uffff"+
            "\1\2\1\uffff\2\2",
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
            return "18:60: ( '{' block_name+= string '}' )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA3_36 = input.LA(1);

                         
                        int index3_36 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred7_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 2;}

                         
                        input.seek(index3_36);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 3, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA4_eotS =
        "\52\uffff";
    static final String DFA4_eofS =
        "\52\uffff";
    static final String DFA4_minS =
        "\1\4\1\5\1\uffff\43\4\1\0\2\4\1\uffff";
    static final String DFA4_maxS =
        "\1\122\1\115\1\uffff\43\122\1\0\2\122\1\uffff";
    static final String DFA4_acceptS =
        "\2\uffff\1\1\46\uffff\1\2";
    static final String DFA4_specialS =
        "\46\uffff\1\0\3\uffff}>";
    static final String[] DFA4_transitionS = {
            "\1\1\42\2\43\uffff\1\2\2\uffff\1\2\1\uffff\1\2\1\uffff\2\2",
            "\1\2\1\3\37\2\47\uffff\1\2",
            "",
            "\43\2\43\uffff\1\4\1\uffff\2\2\1\uffff\1\2\1\uffff\2\2",
            "\1\2\1\10\1\11\1\5\1\30\1\6\1\7\1\12\1\13\1\14\1\15\1\16\1"+
            "\17\1\20\1\21\1\22\1\23\1\24\1\25\1\26\1\27\1\31\1\32\1\33\1"+
            "\34\1\35\1\36\1\37\1\40\1\41\1\42\1\43\1\44\1\45\1\2\43\uffff"+
            "\2\2\1\uffff\1\2\1\uffff\1\2\1\uffff\2\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\5\2\1\47\1\50\34\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff"+
            "\1\2\1\uffff\2\2",
            "\6\2\1\7\34\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1"+
            "\uffff\2\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\43\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1\uffff\2"+
            "\2",
            "\1\uffff",
            "\5\2\1\47\1\50\34\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff"+
            "\1\2\1\uffff\2\2",
            "\6\2\1\50\34\2\43\uffff\1\2\1\46\1\uffff\1\2\1\uffff\1\2\1"+
            "\uffff\2\2",
            ""
    };

    static final short[] DFA4_eot = DFA.unpackEncodedString(DFA4_eotS);
    static final short[] DFA4_eof = DFA.unpackEncodedString(DFA4_eofS);
    static final char[] DFA4_min = DFA.unpackEncodedStringToUnsignedChars(DFA4_minS);
    static final char[] DFA4_max = DFA.unpackEncodedStringToUnsignedChars(DFA4_maxS);
    static final short[] DFA4_accept = DFA.unpackEncodedString(DFA4_acceptS);
    static final short[] DFA4_special = DFA.unpackEncodedString(DFA4_specialS);
    static final short[][] DFA4_transition;

    static {
        int numStates = DFA4_transitionS.length;
        DFA4_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA4_transition[i] = DFA.unpackEncodedString(DFA4_transitionS[i]);
        }
    }

    class DFA4 extends DFA {

        public DFA4(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;
        }
        public String getDescription() {
            return "()* loopback of 18:92: ( t_main_structures )*";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA4_38 = input.LA(1);

                         
                        int index4_38 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred8_TikzGrammar()) ) {s = 2;}

                        else if ( (true) ) {s = 41;}

                         
                        input.seek(index4_38);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 4, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA7_eotS =
        "\45\uffff";
    static final String DFA7_eofS =
        "\45\uffff";
    static final String DFA7_minS =
        "\1\5\4\0\40\uffff";
    static final String DFA7_maxS =
        "\1\115\4\0\40\uffff";
    static final String DFA7_acceptS =
        "\5\uffff\1\3\1\4\34\uffff\1\1\1\2";
    static final String DFA7_specialS =
        "\1\uffff\1\0\1\1\1\2\1\3\40\uffff}>";
    static final String[] DFA7_transitionS = {
            "\4\6\1\4\6\6\1\1\1\6\1\2\4\6\1\3\16\6\47\uffff\1\5",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
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
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static final short[] DFA7_eot = DFA.unpackEncodedString(DFA7_eotS);
    static final short[] DFA7_eof = DFA.unpackEncodedString(DFA7_eofS);
    static final char[] DFA7_min = DFA.unpackEncodedStringToUnsignedChars(DFA7_minS);
    static final char[] DFA7_max = DFA.unpackEncodedStringToUnsignedChars(DFA7_maxS);
    static final short[] DFA7_accept = DFA.unpackEncodedString(DFA7_acceptS);
    static final short[] DFA7_special = DFA.unpackEncodedString(DFA7_specialS);
    static final short[][] DFA7_transition;

    static {
        int numStates = DFA7_transitionS.length;
        DFA7_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA7_transition[i] = DFA.unpackEncodedString(DFA7_transitionS[i]);
        }
    }

    class DFA7 extends DFA {

        public DFA7(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;
        }
        public String getDescription() {
            return "23:25: ( t_foreach -> t_foreach | t_node -> t_node | t_coordinate -> t_coordinate | (macro_name= string ( t_macro )? ( t_options | t_lineto | t_moveto | t_lineto_hv | t_lineto_vh | t_cycle | t_curve | t_rectangle | t_gird | t_parabola | t_plot | t_edge | t_to_path | t_to_path | t_foreach | t_edge | add_blocks+= curly_brackets | add_blocks+= t_block | t_circle | t_ellipse | t_arc | str+= string | t_foreach | t_node | t_coordinate )* ) -> ^( MACRO ^( NAME $macro_name) ( t_macro )? ( t_options )* ( t_moveto )* ( t_lineto )* ( t_lineto_hv )* ( t_lineto_vh )* ( t_cycle )* ( t_to_path )* ( t_foreach )* ( t_edge )* ( t_curve )* ( t_rectangle )* ( t_gird )* ( t_plot )* ( t_circle )* ( t_ellipse )* ( t_parabola )* ( t_arc )* ( $add_blocks)* ( $str)* ( t_foreach )* ( t_node )* ( t_coordinate )* ) )";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA7_1 = input.LA(1);

                         
                        int index7_1 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred9_TikzGrammar()) ) {s = 35;}

                        else if ( (true) ) {s = 6;}

                         
                        input.seek(index7_1);
                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA7_2 = input.LA(1);

                         
                        int index7_2 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred10_TikzGrammar()) ) {s = 36;}

                        else if ( (true) ) {s = 6;}

                         
                        input.seek(index7_2);
                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA7_3 = input.LA(1);

                         
                        int index7_3 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred11_TikzGrammar()) ) {s = 5;}

                        else if ( (true) ) {s = 6;}

                         
                        input.seek(index7_3);
                        if ( s>=0 ) return s;
                        break;
                    case 3 : 
                        int LA7_4 = input.LA(1);

                         
                        int index7_4 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred11_TikzGrammar()) ) {s = 5;}

                        else if ( (true) ) {s = 6;}

                         
                        input.seek(index7_4);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 7, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA5_eotS =
        "\57\uffff";
    static final String DFA5_eofS =
        "\1\2\56\uffff";
    static final String DFA5_minS =
        "\1\4\1\0\55\uffff";
    static final String DFA5_maxS =
        "\1\122\1\0\55\uffff";
    static final String DFA5_acceptS =
        "\2\uffff\1\2\53\uffff\1\1";
    static final String DFA5_specialS =
        "\1\uffff\1\0\55\uffff}>";
    static final String[] DFA5_transitionS = {
            "\1\1\42\2\43\uffff\11\2",
            "\1\uffff",
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
            "",
            "",
            "",
            "",
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
            return "32:46: ( t_macro )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA5_1 = input.LA(1);

                         
                        int index5_1 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred12_TikzGrammar()) ) {s = 46;}

                        else if ( (true) ) {s = 2;}

                         
                        input.seek(index5_1);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 5, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA6_eotS =
        "\101\uffff";
    static final String DFA6_eofS =
        "\1\1\100\uffff";
    static final String DFA6_minS =
        "\1\4\1\uffff\46\0\31\uffff";
    static final String DFA6_maxS =
        "\1\122\1\uffff\46\0\31\uffff";
    static final String DFA6_acceptS =
        "\1\uffff\1\32\46\uffff\1\26\1\3\1\31\1\1\1\21\1\22\1\4\1\5\1\15"+
        "\1\16\1\17\1\27\1\30\1\14\1\20\1\7\1\10\1\11\1\13\1\23\1\24\1\25"+
        "\1\12\1\2\1\6";
    static final String DFA6_specialS =
        "\2\uffff\1\33\1\22\1\31\1\20\1\17\1\30\1\42\1\4\1\24\1\43\1\27"+
        "\1\36\1\44\1\11\1\15\1\1\1\37\1\5\1\12\1\35\1\10\1\3\1\16\1\26\1"+
        "\40\1\2\1\21\1\23\1\34\1\45\1\14\1\32\1\7\1\41\1\0\1\25\1\6\1\13"+
        "\31\uffff}>";
    static final String[] DFA6_transitionS = {
            "\1\6\1\11\1\12\1\2\1\31\1\7\1\10\1\13\1\14\1\15\1\16\1\17\1"+
            "\20\1\21\1\22\1\23\1\24\1\25\1\26\1\27\1\30\1\32\1\33\1\34\1"+
            "\35\1\36\1\37\1\40\1\41\1\42\1\43\1\44\1\45\1\46\1\47\43\uffff"+
            "\1\5\2\1\1\3\1\1\1\4\3\1",
            "",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
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
            return "()* loopback of 33:25: ( t_options | t_lineto | t_moveto | t_lineto_hv | t_lineto_vh | t_cycle | t_curve | t_rectangle | t_gird | t_parabola | t_plot | t_edge | t_to_path | t_to_path | t_foreach | t_edge | add_blocks+= curly_brackets | add_blocks+= t_block | t_circle | t_ellipse | t_arc | str+= string | t_foreach | t_node | t_coordinate )*";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA6_36 = input.LA(1);

                         
                        int index6_36 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred33_TikzGrammar()) ) {s = 61;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_36);
                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA6_17 = input.LA(1);

                         
                        int index6_17 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_17);
                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA6_27 = input.LA(1);

                         
                        int index6_27 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_27);
                        if ( s>=0 ) return s;
                        break;
                    case 3 : 
                        int LA6_23 = input.LA(1);

                         
                        int index6_23 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred15_TikzGrammar()) ) {s = 41;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (synpred37_TikzGrammar()) ) {s = 42;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_23);
                        if ( s>=0 ) return s;
                        break;
                    case 4 : 
                        int LA6_9 = input.LA(1);

                         
                        int index6_9 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_9);
                        if ( s>=0 ) return s;
                        break;
                    case 5 : 
                        int LA6_19 = input.LA(1);

                         
                        int index6_19 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_19);
                        if ( s>=0 ) return s;
                        break;
                    case 6 : 
                        int LA6_38 = input.LA(1);

                         
                        int index6_38 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_38);
                        if ( s>=0 ) return s;
                        break;
                    case 7 : 
                        int LA6_34 = input.LA(1);

                         
                        int index6_34 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred31_TikzGrammar()) ) {s = 59;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_34);
                        if ( s>=0 ) return s;
                        break;
                    case 8 : 
                        int LA6_22 = input.LA(1);

                         
                        int index6_22 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_22);
                        if ( s>=0 ) return s;
                        break;
                    case 9 : 
                        int LA6_15 = input.LA(1);

                         
                        int index6_15 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_15);
                        if ( s>=0 ) return s;
                        break;
                    case 10 : 
                        int LA6_20 = input.LA(1);

                         
                        int index6_20 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_20);
                        if ( s>=0 ) return s;
                        break;
                    case 11 : 
                        int LA6_39 = input.LA(1);

                         
                        int index6_39 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred14_TikzGrammar()) ) {s = 63;}

                        else if ( (synpred18_TikzGrammar()) ) {s = 64;}

                        else if ( (synpred23_TikzGrammar()) ) {s = 58;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_39);
                        if ( s>=0 ) return s;
                        break;
                    case 12 : 
                        int LA6_32 = input.LA(1);

                         
                        int index6_32 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred23_TikzGrammar()) ) {s = 58;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_32);
                        if ( s>=0 ) return s;
                        break;
                    case 13 : 
                        int LA6_16 = input.LA(1);

                         
                        int index6_16 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred27_TikzGrammar()) ) {s = 50;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (synpred35_TikzGrammar()) ) {s = 51;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_16);
                        if ( s>=0 ) return s;
                        break;
                    case 14 : 
                        int LA6_24 = input.LA(1);

                         
                        int index6_24 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred24_TikzGrammar()) ) {s = 53;}

                        else if ( (synpred28_TikzGrammar()) ) {s = 54;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_24);
                        if ( s>=0 ) return s;
                        break;
                    case 15 : 
                        int LA6_6 = input.LA(1);

                         
                        int index6_6 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred30_TikzGrammar()) ) {s = 45;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_6);
                        if ( s>=0 ) return s;
                        break;
                    case 16 : 
                        int LA6_5 = input.LA(1);

                         
                        int index6_5 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred29_TikzGrammar()) ) {s = 44;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_5);
                        if ( s>=0 ) return s;
                        break;
                    case 17 : 
                        int LA6_28 = input.LA(1);

                         
                        int index6_28 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_28);
                        if ( s>=0 ) return s;
                        break;
                    case 18 : 
                        int LA6_3 = input.LA(1);

                         
                        int index6_3 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred15_TikzGrammar()) ) {s = 41;}

                        else if ( (synpred37_TikzGrammar()) ) {s = 42;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_3);
                        if ( s>=0 ) return s;
                        break;
                    case 19 : 
                        int LA6_29 = input.LA(1);

                         
                        int index6_29 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred19_TikzGrammar()) ) {s = 55;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_29);
                        if ( s>=0 ) return s;
                        break;
                    case 20 : 
                        int LA6_10 = input.LA(1);

                         
                        int index6_10 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_10);
                        if ( s>=0 ) return s;
                        break;
                    case 21 : 
                        int LA6_37 = input.LA(1);

                         
                        int index6_37 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred22_TikzGrammar()) ) {s = 62;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_37);
                        if ( s>=0 ) return s;
                        break;
                    case 22 : 
                        int LA6_25 = input.LA(1);

                         
                        int index6_25 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_25);
                        if ( s>=0 ) return s;
                        break;
                    case 23 : 
                        int LA6_12 = input.LA(1);

                         
                        int index6_12 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred17_TikzGrammar()) ) {s = 47;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_12);
                        if ( s>=0 ) return s;
                        break;
                    case 24 : 
                        int LA6_7 = input.LA(1);

                         
                        int index6_7 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred15_TikzGrammar()) ) {s = 41;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (synpred37_TikzGrammar()) ) {s = 42;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_7);
                        if ( s>=0 ) return s;
                        break;
                    case 25 : 
                        int LA6_4 = input.LA(1);

                         
                        int index6_4 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred13_TikzGrammar()) ) {s = 43;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_4);
                        if ( s>=0 ) return s;
                        break;
                    case 26 : 
                        int LA6_33 = input.LA(1);

                         
                        int index6_33 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_33);
                        if ( s>=0 ) return s;
                        break;
                    case 27 : 
                        int LA6_2 = input.LA(1);

                         
                        int index6_2 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_2);
                        if ( s>=0 ) return s;
                        break;
                    case 28 : 
                        int LA6_30 = input.LA(1);

                         
                        int index6_30 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred20_TikzGrammar()) ) {s = 56;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_30);
                        if ( s>=0 ) return s;
                        break;
                    case 29 : 
                        int LA6_21 = input.LA(1);

                         
                        int index6_21 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_21);
                        if ( s>=0 ) return s;
                        break;
                    case 30 : 
                        int LA6_13 = input.LA(1);

                         
                        int index6_13 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred25_TikzGrammar()) ) {s = 48;}

                        else if ( (synpred26_TikzGrammar()) ) {s = 49;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_13);
                        if ( s>=0 ) return s;
                        break;
                    case 31 : 
                        int LA6_18 = input.LA(1);

                         
                        int index6_18 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (synpred36_TikzGrammar()) ) {s = 52;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_18);
                        if ( s>=0 ) return s;
                        break;
                    case 32 : 
                        int LA6_26 = input.LA(1);

                         
                        int index6_26 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_26);
                        if ( s>=0 ) return s;
                        break;
                    case 33 : 
                        int LA6_35 = input.LA(1);

                         
                        int index6_35 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred32_TikzGrammar()) ) {s = 60;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_35);
                        if ( s>=0 ) return s;
                        break;
                    case 34 : 
                        int LA6_8 = input.LA(1);

                         
                        int index6_8 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_8);
                        if ( s>=0 ) return s;
                        break;
                    case 35 : 
                        int LA6_11 = input.LA(1);

                         
                        int index6_11 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred16_TikzGrammar()) ) {s = 46;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_11);
                        if ( s>=0 ) return s;
                        break;
                    case 36 : 
                        int LA6_14 = input.LA(1);

                         
                        int index6_14 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_14);
                        if ( s>=0 ) return s;
                        break;
                    case 37 : 
                        int LA6_31 = input.LA(1);

                         
                        int index6_31 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred21_TikzGrammar()) ) {s = 57;}

                        else if ( (synpred34_TikzGrammar()) ) {s = 40;}

                        else if ( (true) ) {s = 1;}

                         
                        input.seek(index6_31);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 6, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA11_eotS =
        "\55\uffff";
    static final String DFA11_eofS =
        "\55\uffff";
    static final String DFA11_minS =
        "\1\4\1\uffff\4\0\47\uffff";
    static final String DFA11_maxS =
        "\1\122\1\uffff\4\0\47\uffff";
    static final String DFA11_acceptS =
        "\1\uffff\1\5\4\uffff\1\3\43\uffff\1\1\1\2\1\4";
    static final String DFA11_specialS =
        "\2\uffff\1\0\1\1\1\2\1\3\47\uffff}>";
    static final String[] DFA11_transitionS = {
            "\1\5\2\6\1\2\37\6\43\uffff\1\4\2\uffff\1\3\1\1\1\6\1\uffff"+
            "\2\6",
            "",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
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
            ""
    };

    static final short[] DFA11_eot = DFA.unpackEncodedString(DFA11_eotS);
    static final short[] DFA11_eof = DFA.unpackEncodedString(DFA11_eofS);
    static final char[] DFA11_min = DFA.unpackEncodedStringToUnsignedChars(DFA11_minS);
    static final char[] DFA11_max = DFA.unpackEncodedStringToUnsignedChars(DFA11_maxS);
    static final short[] DFA11_accept = DFA.unpackEncodedString(DFA11_acceptS);
    static final short[] DFA11_special = DFA.unpackEncodedString(DFA11_specialS);
    static final short[][] DFA11_transition;

    static {
        int numStates = DFA11_transitionS.length;
        DFA11_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA11_transition[i] = DFA.unpackEncodedString(DFA11_transitionS[i]);
        }
    }

    class DFA11 extends DFA {

        public DFA11(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;
        }
        public String getDescription() {
            return "()* loopback of 50:26: ( function | curly_brackets | t_list | t_macro )*";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA11_2 = input.LA(1);

                         
                        int index11_2 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred41_TikzGrammar()) ) {s = 42;}

                        else if ( (synpred43_TikzGrammar()) ) {s = 6;}

                         
                        input.seek(index11_2);
                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA11_3 = input.LA(1);

                         
                        int index11_3 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred41_TikzGrammar()) ) {s = 42;}

                        else if ( (synpred43_TikzGrammar()) ) {s = 6;}

                         
                        input.seek(index11_3);
                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA11_4 = input.LA(1);

                         
                        int index11_4 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred42_TikzGrammar()) ) {s = 43;}

                        else if ( (synpred43_TikzGrammar()) ) {s = 6;}

                         
                        input.seek(index11_4);
                        if ( s>=0 ) return s;
                        break;
                    case 3 : 
                        int LA11_5 = input.LA(1);

                         
                        int index11_5 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred43_TikzGrammar()) ) {s = 6;}

                        else if ( (synpred44_TikzGrammar()) ) {s = 44;}

                         
                        input.seek(index11_5);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 11, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA12_eotS =
        "\33\uffff";
    static final String DFA12_eofS =
        "\1\1\32\uffff";
    static final String DFA12_minS =
        "\1\4\1\uffff\31\0";
    static final String DFA12_maxS =
        "\1\117\1\uffff\31\0";
    static final String DFA12_acceptS =
        "\1\uffff\1\5\31\uffff";
    static final String DFA12_specialS =
        "\33\uffff}>";
    static final String[] DFA12_transitionS = {
            "\1\6\1\11\1\12\1\2\1\31\1\7\1\10\1\13\1\14\1\15\1\16\1\17\1"+
            "\20\1\21\1\22\1\23\1\24\1\25\1\26\1\27\1\30\61\uffff\1\5\2\uffff"+
            "\1\3\1\uffff\1\4",
            "",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff"
    };

    static final short[] DFA12_eot = DFA.unpackEncodedString(DFA12_eotS);
    static final short[] DFA12_eof = DFA.unpackEncodedString(DFA12_eofS);
    static final char[] DFA12_min = DFA.unpackEncodedStringToUnsignedChars(DFA12_minS);
    static final char[] DFA12_max = DFA.unpackEncodedStringToUnsignedChars(DFA12_maxS);
    static final short[] DFA12_accept = DFA.unpackEncodedString(DFA12_acceptS);
    static final short[] DFA12_special = DFA.unpackEncodedString(DFA12_specialS);
    static final short[][] DFA12_transition;

    static {
        int numStates = DFA12_transitionS.length;
        DFA12_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA12_transition[i] = DFA.unpackEncodedString(DFA12_transitionS[i]);
        }
    }

    class DFA12 extends DFA {

        public DFA12(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;
        }
        public String getDescription() {
            return "()+ loopback of 63:17: ( t_list_elem | ',' | ':' | AND )+";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
    static final String DFA16_eotS =
        "\51\uffff";
    static final String DFA16_eofS =
        "\51\uffff";
    static final String DFA16_minS =
        "\1\4\46\0\2\uffff";
    static final String DFA16_maxS =
        "\1\117\46\0\2\uffff";
    static final String DFA16_acceptS =
        "\47\uffff\1\1\1\2";
    static final String DFA16_specialS =
        "\1\uffff\1\0\1\1\1\2\1\3\1\4\1\5\1\6\1\7\1\10\1\11\1\12\1\13\1"+
        "\14\1\15\1\16\1\17\1\20\1\21\1\22\1\23\1\24\1\25\1\26\1\27\1\30"+
        "\1\31\1\32\1\33\1\34\1\35\1\36\1\37\1\40\1\41\1\42\1\43\1\44\1\45"+
        "\2\uffff}>";
    static final String[] DFA16_transitionS = {
            "\1\1\1\4\1\5\1\17\1\25\1\2\1\3\1\6\1\7\1\10\1\11\1\12\1\13"+
            "\1\14\1\15\1\16\1\20\1\21\1\22\1\23\1\24\1\26\1\27\1\30\1\31"+
            "\1\32\1\33\1\34\1\35\1\36\1\37\1\40\1\41\1\42\1\46\43\uffff"+
            "\1\44\2\uffff\1\43\1\uffff\1\45",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
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
            return "67:1: t_list_elem : ( ( (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )? oper= multioperator (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto ) ) -> ^( OPERATION $oper ^( NAME ( $elem_name)? ) ^( VALUE $elem_value) ) | (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto ) -> ^( NAME $elem_name) );";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA16_1 = input.LA(1);

                         
                        int index16_1 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_1);
                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA16_2 = input.LA(1);

                         
                        int index16_2 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_2);
                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA16_3 = input.LA(1);

                         
                        int index16_3 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_3);
                        if ( s>=0 ) return s;
                        break;
                    case 3 : 
                        int LA16_4 = input.LA(1);

                         
                        int index16_4 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_4);
                        if ( s>=0 ) return s;
                        break;
                    case 4 : 
                        int LA16_5 = input.LA(1);

                         
                        int index16_5 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_5);
                        if ( s>=0 ) return s;
                        break;
                    case 5 : 
                        int LA16_6 = input.LA(1);

                         
                        int index16_6 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_6);
                        if ( s>=0 ) return s;
                        break;
                    case 6 : 
                        int LA16_7 = input.LA(1);

                         
                        int index16_7 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_7);
                        if ( s>=0 ) return s;
                        break;
                    case 7 : 
                        int LA16_8 = input.LA(1);

                         
                        int index16_8 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_8);
                        if ( s>=0 ) return s;
                        break;
                    case 8 : 
                        int LA16_9 = input.LA(1);

                         
                        int index16_9 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_9);
                        if ( s>=0 ) return s;
                        break;
                    case 9 : 
                        int LA16_10 = input.LA(1);

                         
                        int index16_10 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_10);
                        if ( s>=0 ) return s;
                        break;
                    case 10 : 
                        int LA16_11 = input.LA(1);

                         
                        int index16_11 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_11);
                        if ( s>=0 ) return s;
                        break;
                    case 11 : 
                        int LA16_12 = input.LA(1);

                         
                        int index16_12 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_12);
                        if ( s>=0 ) return s;
                        break;
                    case 12 : 
                        int LA16_13 = input.LA(1);

                         
                        int index16_13 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_13);
                        if ( s>=0 ) return s;
                        break;
                    case 13 : 
                        int LA16_14 = input.LA(1);

                         
                        int index16_14 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_14);
                        if ( s>=0 ) return s;
                        break;
                    case 14 : 
                        int LA16_15 = input.LA(1);

                         
                        int index16_15 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_15);
                        if ( s>=0 ) return s;
                        break;
                    case 15 : 
                        int LA16_16 = input.LA(1);

                         
                        int index16_16 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_16);
                        if ( s>=0 ) return s;
                        break;
                    case 16 : 
                        int LA16_17 = input.LA(1);

                         
                        int index16_17 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_17);
                        if ( s>=0 ) return s;
                        break;
                    case 17 : 
                        int LA16_18 = input.LA(1);

                         
                        int index16_18 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_18);
                        if ( s>=0 ) return s;
                        break;
                    case 18 : 
                        int LA16_19 = input.LA(1);

                         
                        int index16_19 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_19);
                        if ( s>=0 ) return s;
                        break;
                    case 19 : 
                        int LA16_20 = input.LA(1);

                         
                        int index16_20 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_20);
                        if ( s>=0 ) return s;
                        break;
                    case 20 : 
                        int LA16_21 = input.LA(1);

                         
                        int index16_21 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_21);
                        if ( s>=0 ) return s;
                        break;
                    case 21 : 
                        int LA16_22 = input.LA(1);

                         
                        int index16_22 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_22);
                        if ( s>=0 ) return s;
                        break;
                    case 22 : 
                        int LA16_23 = input.LA(1);

                         
                        int index16_23 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_23);
                        if ( s>=0 ) return s;
                        break;
                    case 23 : 
                        int LA16_24 = input.LA(1);

                         
                        int index16_24 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_24);
                        if ( s>=0 ) return s;
                        break;
                    case 24 : 
                        int LA16_25 = input.LA(1);

                         
                        int index16_25 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_25);
                        if ( s>=0 ) return s;
                        break;
                    case 25 : 
                        int LA16_26 = input.LA(1);

                         
                        int index16_26 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_26);
                        if ( s>=0 ) return s;
                        break;
                    case 26 : 
                        int LA16_27 = input.LA(1);

                         
                        int index16_27 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_27);
                        if ( s>=0 ) return s;
                        break;
                    case 27 : 
                        int LA16_28 = input.LA(1);

                         
                        int index16_28 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_28);
                        if ( s>=0 ) return s;
                        break;
                    case 28 : 
                        int LA16_29 = input.LA(1);

                         
                        int index16_29 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_29);
                        if ( s>=0 ) return s;
                        break;
                    case 29 : 
                        int LA16_30 = input.LA(1);

                         
                        int index16_30 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_30);
                        if ( s>=0 ) return s;
                        break;
                    case 30 : 
                        int LA16_31 = input.LA(1);

                         
                        int index16_31 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_31);
                        if ( s>=0 ) return s;
                        break;
                    case 31 : 
                        int LA16_32 = input.LA(1);

                         
                        int index16_32 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_32);
                        if ( s>=0 ) return s;
                        break;
                    case 32 : 
                        int LA16_33 = input.LA(1);

                         
                        int index16_33 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_33);
                        if ( s>=0 ) return s;
                        break;
                    case 33 : 
                        int LA16_34 = input.LA(1);

                         
                        int index16_34 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_34);
                        if ( s>=0 ) return s;
                        break;
                    case 34 : 
                        int LA16_35 = input.LA(1);

                         
                        int index16_35 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_35);
                        if ( s>=0 ) return s;
                        break;
                    case 35 : 
                        int LA16_36 = input.LA(1);

                         
                        int index16_36 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_36);
                        if ( s>=0 ) return s;
                        break;
                    case 36 : 
                        int LA16_37 = input.LA(1);

                         
                        int index16_37 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_37);
                        if ( s>=0 ) return s;
                        break;
                    case 37 : 
                        int LA16_38 = input.LA(1);

                         
                        int index16_38 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred60_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 40;}

                         
                        input.seek(index16_38);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 16, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA13_eotS =
        "\12\uffff";
    static final String DFA13_eofS =
        "\12\uffff";
    static final String DFA13_minS =
        "\1\4\1\uffff\1\0\1\uffff\1\11\5\uffff";
    static final String DFA13_maxS =
        "\1\117\1\uffff\1\0\1\uffff\1\115\5\uffff";
    static final String DFA13_acceptS =
        "\1\uffff\1\1\1\uffff\1\2\1\uffff\1\3\1\4\1\5\1\6\1\7";
    static final String DFA13_specialS =
        "\2\uffff\1\0\7\uffff}>";
    static final String[] DFA13_transitionS = {
            "\1\1\2\3\1\4\1\3\1\2\34\3\1\10\43\uffff\1\6\2\uffff\1\5\1\uffff"+
            "\1\7",
            "",
            "\1\uffff",
            "",
            "\1\3\103\uffff\1\5",
            "",
            "",
            "",
            "",
            ""
    };

    static final short[] DFA13_eot = DFA.unpackEncodedString(DFA13_eotS);
    static final short[] DFA13_eof = DFA.unpackEncodedString(DFA13_eofS);
    static final char[] DFA13_min = DFA.unpackEncodedStringToUnsignedChars(DFA13_minS);
    static final char[] DFA13_max = DFA.unpackEncodedStringToUnsignedChars(DFA13_maxS);
    static final short[] DFA13_accept = DFA.unpackEncodedString(DFA13_acceptS);
    static final short[] DFA13_special = DFA.unpackEncodedString(DFA13_specialS);
    static final short[][] DFA13_transition;

    static {
        int numStates = DFA13_transitionS.length;
        DFA13_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA13_transition[i] = DFA.unpackEncodedString(DFA13_transitionS[i]);
        }
    }

    class DFA13 extends DFA {

        public DFA13(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 13;
            this.eot = DFA13_eot;
            this.eof = DFA13_eof;
            this.min = DFA13_min;
            this.max = DFA13_max;
            this.accept = DFA13_accept;
            this.special = DFA13_special;
            this.transition = DFA13_transition;
        }
        public String getDescription() {
            return "68:19: (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA13_2 = input.LA(1);

                         
                        int index13_2 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred50_TikzGrammar()) ) {s = 3;}

                        else if ( (true) ) {s = 9;}

                         
                        input.seek(index13_2);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 13, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA14_eotS =
        "\47\uffff";
    static final String DFA14_eofS =
        "\47\uffff";
    static final String DFA14_minS =
        "\1\4\16\uffff\1\0\27\uffff";
    static final String DFA14_maxS =
        "\1\117\16\uffff\1\0\27\uffff";
    static final String DFA14_acceptS =
        "\1\uffff\1\1\1\2\40\uffff\1\3\1\4\1\5\1\6";
    static final String DFA14_specialS =
        "\17\uffff\1\0\27\uffff}>";
    static final String[] DFA14_transitionS = {
            "\1\1\2\2\1\17\36\2\1\46\43\uffff\1\44\2\uffff\1\43\1\uffff"+
            "\1\45",
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
            "",
            "\1\uffff",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
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
            return "69:36: (elem_value+= t_macro | elem_value+= string | elem_value+= function | elem_value+= curly_brackets | elem_value+= square_brackets | elem_name+= t_lineto )";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA14_15 = input.LA(1);

                         
                        int index14_15 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred56_TikzGrammar()) ) {s = 2;}

                        else if ( (synpred57_TikzGrammar()) ) {s = 35;}

                         
                        input.seek(index14_15);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 14, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA22_eotS =
        "\43\uffff";
    static final String DFA22_eofS =
        "\43\uffff";
    static final String DFA22_minS =
        "\1\5\1\0\41\uffff";
    static final String DFA22_maxS =
        "\1\45\1\0\41\uffff";
    static final String DFA22_acceptS =
        "\2\uffff\1\1\1\3\1\4\1\5\1\6\1\7\1\10\1\11\1\12\1\13\1\14\1\15"+
        "\1\16\1\17\1\20\1\21\1\22\1\23\1\24\1\25\1\26\1\27\1\30\1\31\1\32"+
        "\1\33\1\34\1\35\1\36\1\37\1\40\1\41\1\2";
    static final String DFA22_specialS =
        "\1\uffff\1\0\41\uffff}>";
    static final String[] DFA22_transitionS = {
            "\1\3\1\4\1\16\1\24\1\1\1\2\1\5\1\6\1\7\1\10\1\11\1\12\1\13"+
            "\1\14\1\15\1\17\1\20\1\21\1\22\1\23\1\25\1\26\1\27\1\30\1\31"+
            "\1\32\1\33\1\34\1\35\1\36\1\37\1\40\1\41",
            "\1\uffff",
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
            "",
            "",
            "",
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
            return "87:1: string : ( ( ( OPERATOR )* ( STRING )+ ) | ( OPERATOR )+ | BEGIN | END | HVLINE | VHLINE | TO | IN | CYCLE | FOREACH | CS | NODE | AT | FUNC | FUNCTION | FILE | COORDINATES | COORDINATE | EDGE | AND | CONTROLS | FROM | PARENT | DOTS | RECTANGLE | GRID | PLOT | CHILD | CIRCLE | ELLIPSE | ARC | PARABOLA | BEND );";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA22_1 = input.LA(1);

                         
                        int index22_1 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred72_TikzGrammar()) ) {s = 2;}

                        else if ( (synpred74_TikzGrammar()) ) {s = 34;}

                         
                        input.seek(index22_1);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 22, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA27_eotS =
        "\57\uffff";
    static final String DFA27_eofS =
        "\1\2\56\uffff";
    static final String DFA27_minS =
        "\1\4\1\0\55\uffff";
    static final String DFA27_maxS =
        "\1\122\1\0\55\uffff";
    static final String DFA27_acceptS =
        "\2\uffff\1\2\53\uffff\1\1";
    static final String DFA27_specialS =
        "\1\uffff\1\0\55\uffff}>";
    static final String[] DFA27_transitionS = {
            "\17\2\1\1\23\2\43\uffff\11\2",
            "\1\uffff",
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
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static final short[] DFA27_eot = DFA.unpackEncodedString(DFA27_eotS);
    static final short[] DFA27_eof = DFA.unpackEncodedString(DFA27_eofS);
    static final char[] DFA27_min = DFA.unpackEncodedStringToUnsignedChars(DFA27_minS);
    static final char[] DFA27_max = DFA.unpackEncodedStringToUnsignedChars(DFA27_maxS);
    static final short[] DFA27_accept = DFA.unpackEncodedString(DFA27_acceptS);
    static final short[] DFA27_special = DFA.unpackEncodedString(DFA27_specialS);
    static final short[][] DFA27_transition;

    static {
        int numStates = DFA27_transitionS.length;
        DFA27_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA27_transition[i] = DFA.unpackEncodedString(DFA27_transitionS[i]);
        }
    }

    class DFA27 extends DFA {

        public DFA27(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 27;
            this.eot = DFA27_eot;
            this.eof = DFA27_eof;
            this.min = DFA27_min;
            this.max = DFA27_max;
            this.accept = DFA27_accept;
            this.special = DFA27_special;
            this.transition = DFA27_transition;
        }
        public String getDescription() {
            return "97:54: ( AT ( multioperator )? '(' (cs_name= string CS )? ( t_options )* t_list ')' )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA27_1 = input.LA(1);

                         
                        int index27_1 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred109_TikzGrammar()) ) {s = 46;}

                        else if ( (true) ) {s = 2;}

                         
                        input.seek(index27_1);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 27, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA25_eotS =
        "\50\uffff";
    static final String DFA25_eofS =
        "\50\uffff";
    static final String DFA25_minS =
        "\42\4\1\uffff\2\4\2\0\1\uffff";
    static final String DFA25_maxS =
        "\42\122\1\uffff\2\122\2\0\1\uffff";
    static final String DFA25_acceptS =
        "\42\uffff\1\2\4\uffff\1\1";
    static final String DFA25_specialS =
        "\45\uffff\1\1\1\0\1\uffff}>";
    static final String[] DFA25_transitionS = {
            "\1\42\1\3\1\4\1\16\1\24\1\1\1\2\1\5\1\6\1\7\1\10\1\11\1\12"+
            "\1\13\1\14\1\15\1\17\1\20\1\21\1\22\1\23\1\25\1\26\1\27\1\30"+
            "\1\31\1\32\1\33\1\34\1\35\1\36\1\37\1\40\1\41\1\42\43\uffff"+
            "\1\42\2\uffff\1\42\1\uffff\1\42\1\uffff\2\42",
            "\5\42\1\43\1\44\6\42\1\45\25\42\43\uffff\1\42\2\uffff\3\42"+
            "\1\uffff\2\42",
            "\6\42\1\2\6\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff"+
            "\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "",
            "\5\42\1\43\1\44\6\42\1\45\25\42\43\uffff\1\42\2\uffff\3\42"+
            "\1\uffff\2\42",
            "\6\42\1\44\6\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff"+
            "\2\42",
            "\1\uffff",
            "\1\uffff",
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
            return "97:79: (cs_name= string CS )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA25_38 = input.LA(1);

                         
                        int index25_38 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred107_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 34;}

                         
                        input.seek(index25_38);
                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA25_37 = input.LA(1);

                         
                        int index25_37 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred107_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 34;}

                         
                        input.seek(index25_37);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 25, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA29_eotS =
        "\50\uffff";
    static final String DFA29_eofS =
        "\50\uffff";
    static final String DFA29_minS =
        "\42\4\1\uffff\2\4\2\0\1\uffff";
    static final String DFA29_maxS =
        "\42\122\1\uffff\2\122\2\0\1\uffff";
    static final String DFA29_acceptS =
        "\42\uffff\1\2\4\uffff\1\1";
    static final String DFA29_specialS =
        "\45\uffff\1\0\1\1\1\uffff}>";
    static final String[] DFA29_transitionS = {
            "\1\42\1\3\1\4\1\16\1\24\1\1\1\2\1\5\1\6\1\7\1\10\1\11\1\12"+
            "\1\13\1\14\1\15\1\17\1\20\1\21\1\22\1\23\1\25\1\26\1\27\1\30"+
            "\1\31\1\32\1\33\1\34\1\35\1\36\1\37\1\40\1\41\1\42\43\uffff"+
            "\1\42\2\uffff\1\42\1\uffff\1\42\1\uffff\2\42",
            "\5\42\1\43\1\44\6\42\1\45\25\42\43\uffff\1\42\2\uffff\3\42"+
            "\1\uffff\2\42",
            "\6\42\1\2\6\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff"+
            "\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "",
            "\5\42\1\43\1\44\6\42\1\45\25\42\43\uffff\1\42\2\uffff\3\42"+
            "\1\uffff\2\42",
            "\6\42\1\44\6\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff"+
            "\2\42",
            "\1\uffff",
            "\1\uffff",
            ""
    };

    static final short[] DFA29_eot = DFA.unpackEncodedString(DFA29_eotS);
    static final short[] DFA29_eof = DFA.unpackEncodedString(DFA29_eofS);
    static final char[] DFA29_min = DFA.unpackEncodedStringToUnsignedChars(DFA29_minS);
    static final char[] DFA29_max = DFA.unpackEncodedStringToUnsignedChars(DFA29_maxS);
    static final short[] DFA29_accept = DFA.unpackEncodedString(DFA29_acceptS);
    static final short[] DFA29_special = DFA.unpackEncodedString(DFA29_specialS);
    static final short[][] DFA29_transition;

    static {
        int numStates = DFA29_transitionS.length;
        DFA29_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA29_transition[i] = DFA.unpackEncodedString(DFA29_transitionS[i]);
        }
    }

    class DFA29 extends DFA {

        public DFA29(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 29;
            this.eot = DFA29_eot;
            this.eof = DFA29_eof;
            this.min = DFA29_min;
            this.max = DFA29_max;
            this.accept = DFA29_accept;
            this.special = DFA29_special;
            this.transition = DFA29_transition;
        }
        public String getDescription() {
            return "99:36: (cs_name= string CS )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA29_37 = input.LA(1);

                         
                        int index29_37 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred112_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 34;}

                         
                        input.seek(index29_37);
                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA29_38 = input.LA(1);

                         
                        int index29_38 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred112_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 34;}

                         
                        input.seek(index29_38);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 29, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA35_eotS =
        "\57\uffff";
    static final String DFA35_eofS =
        "\1\4\56\uffff";
    static final String DFA35_minS =
        "\1\4\3\0\53\uffff";
    static final String DFA35_maxS =
        "\1\122\3\0\53\uffff";
    static final String DFA35_acceptS =
        "\4\uffff\1\2\51\uffff\1\1";
    static final String DFA35_specialS =
        "\1\uffff\1\0\1\1\1\2\53\uffff}>";
    static final String[] DFA35_transitionS = {
            "\5\4\1\2\15\4\1\1\17\4\43\uffff\3\4\1\3\5\4",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
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
            "",
            "",
            "",
            ""
    };

    static final short[] DFA35_eot = DFA.unpackEncodedString(DFA35_eotS);
    static final short[] DFA35_eof = DFA.unpackEncodedString(DFA35_eofS);
    static final char[] DFA35_min = DFA.unpackEncodedStringToUnsignedChars(DFA35_minS);
    static final char[] DFA35_max = DFA.unpackEncodedStringToUnsignedChars(DFA35_maxS);
    static final short[] DFA35_accept = DFA.unpackEncodedString(DFA35_acceptS);
    static final short[] DFA35_special = DFA.unpackEncodedString(DFA35_specialS);
    static final short[][] DFA35_transition;

    static {
        int numStates = DFA35_transitionS.length;
        DFA35_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA35_transition[i] = DFA.unpackEncodedString(DFA35_transitionS[i]);
        }
    }

    class DFA35 extends DFA {

        public DFA35(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 35;
            this.eot = DFA35_eot;
            this.eof = DFA35_eof;
            this.min = DFA35_min;
            this.max = DFA35_max;
            this.accept = DFA35_accept;
            this.special = DFA35_special;
            this.transition = DFA35_transition;
        }
        public String getDescription() {
            return "129:62: ( t_coordinate )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA35_1 = input.LA(1);

                         
                        int index35_1 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred118_TikzGrammar()) ) {s = 46;}

                        else if ( (true) ) {s = 4;}

                         
                        input.seek(index35_1);
                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA35_2 = input.LA(1);

                         
                        int index35_2 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred118_TikzGrammar()) ) {s = 46;}

                        else if ( (true) ) {s = 4;}

                         
                        input.seek(index35_2);
                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA35_3 = input.LA(1);

                         
                        int index35_3 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred118_TikzGrammar()) ) {s = 46;}

                        else if ( (true) ) {s = 4;}

                         
                        input.seek(index35_3);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 35, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA49_eotS =
        "\57\uffff";
    static final String DFA49_eofS =
        "\1\4\56\uffff";
    static final String DFA49_minS =
        "\1\4\3\0\53\uffff";
    static final String DFA49_maxS =
        "\1\122\3\0\53\uffff";
    static final String DFA49_acceptS =
        "\4\uffff\1\2\51\uffff\1\1";
    static final String DFA49_specialS =
        "\1\uffff\1\0\1\1\1\2\53\uffff}>";
    static final String[] DFA49_transitionS = {
            "\5\4\1\2\15\4\1\1\17\4\43\uffff\3\4\1\3\5\4",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
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
            "",
            "",
            "",
            ""
    };

    static final short[] DFA49_eot = DFA.unpackEncodedString(DFA49_eotS);
    static final short[] DFA49_eof = DFA.unpackEncodedString(DFA49_eofS);
    static final char[] DFA49_min = DFA.unpackEncodedStringToUnsignedChars(DFA49_minS);
    static final char[] DFA49_max = DFA.unpackEncodedStringToUnsignedChars(DFA49_maxS);
    static final short[] DFA49_accept = DFA.unpackEncodedString(DFA49_acceptS);
    static final short[] DFA49_special = DFA.unpackEncodedString(DFA49_specialS);
    static final short[][] DFA49_transition;

    static {
        int numStates = DFA49_transitionS.length;
        DFA49_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA49_transition[i] = DFA.unpackEncodedString(DFA49_transitionS[i]);
        }
    }

    class DFA49 extends DFA {

        public DFA49(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 49;
            this.eot = DFA49_eot;
            this.eof = DFA49_eof;
            this.min = DFA49_min;
            this.max = DFA49_max;
            this.accept = DFA49_accept;
            this.special = DFA49_special;
            this.transition = DFA49_transition;
        }
        public String getDescription() {
            return "159:71: ( t_coordinate )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA49_1 = input.LA(1);

                         
                        int index49_1 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred133_TikzGrammar()) ) {s = 46;}

                        else if ( (true) ) {s = 4;}

                         
                        input.seek(index49_1);
                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA49_2 = input.LA(1);

                         
                        int index49_2 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred133_TikzGrammar()) ) {s = 46;}

                        else if ( (true) ) {s = 4;}

                         
                        input.seek(index49_2);
                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA49_3 = input.LA(1);

                         
                        int index49_3 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred133_TikzGrammar()) ) {s = 46;}

                        else if ( (true) ) {s = 4;}

                         
                        input.seek(index49_3);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 49, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA53_eotS =
        "\57\uffff";
    static final String DFA53_eofS =
        "\1\4\56\uffff";
    static final String DFA53_minS =
        "\1\4\3\0\53\uffff";
    static final String DFA53_maxS =
        "\1\122\3\0\53\uffff";
    static final String DFA53_acceptS =
        "\4\uffff\1\2\51\uffff\1\1";
    static final String DFA53_specialS =
        "\1\uffff\1\0\1\1\1\2\53\uffff}>";
    static final String[] DFA53_transitionS = {
            "\5\4\1\2\15\4\1\1\17\4\43\uffff\3\4\1\3\5\4",
            "\1\uffff",
            "\1\uffff",
            "\1\uffff",
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
            "",
            "",
            "",
            ""
    };

    static final short[] DFA53_eot = DFA.unpackEncodedString(DFA53_eotS);
    static final short[] DFA53_eof = DFA.unpackEncodedString(DFA53_eofS);
    static final char[] DFA53_min = DFA.unpackEncodedStringToUnsignedChars(DFA53_minS);
    static final char[] DFA53_max = DFA.unpackEncodedStringToUnsignedChars(DFA53_maxS);
    static final short[] DFA53_accept = DFA.unpackEncodedString(DFA53_acceptS);
    static final short[] DFA53_special = DFA.unpackEncodedString(DFA53_specialS);
    static final short[][] DFA53_transition;

    static {
        int numStates = DFA53_transitionS.length;
        DFA53_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA53_transition[i] = DFA.unpackEncodedString(DFA53_transitionS[i]);
        }
    }

    class DFA53 extends DFA {

        public DFA53(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 53;
            this.eot = DFA53_eot;
            this.eof = DFA53_eof;
            this.min = DFA53_min;
            this.max = DFA53_max;
            this.accept = DFA53_accept;
            this.special = DFA53_special;
            this.transition = DFA53_transition;
        }
        public String getDescription() {
            return "187:60: (c2= t_coordinate )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA53_1 = input.LA(1);

                         
                        int index53_1 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred137_TikzGrammar()) ) {s = 46;}

                        else if ( (true) ) {s = 4;}

                         
                        input.seek(index53_1);
                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA53_2 = input.LA(1);

                         
                        int index53_2 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred137_TikzGrammar()) ) {s = 46;}

                        else if ( (true) ) {s = 4;}

                         
                        input.seek(index53_2);
                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA53_3 = input.LA(1);

                         
                        int index53_3 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred137_TikzGrammar()) ) {s = 46;}

                        else if ( (true) ) {s = 4;}

                         
                        input.seek(index53_3);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 53, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA57_eotS =
        "\12\uffff";
    static final String DFA57_eofS =
        "\12\uffff";
    static final String DFA57_minS =
        "\1\4\1\uffff\1\0\1\uffff\1\11\5\uffff";
    static final String DFA57_maxS =
        "\1\117\1\uffff\1\0\1\uffff\1\115\5\uffff";
    static final String DFA57_acceptS =
        "\1\uffff\1\1\1\uffff\1\2\1\uffff\1\3\1\4\1\5\1\6\1\7";
    static final String DFA57_specialS =
        "\2\uffff\1\0\7\uffff}>";
    static final String[] DFA57_transitionS = {
            "\1\1\2\3\1\4\1\3\1\2\34\3\1\10\43\uffff\1\6\2\uffff\1\5\1\uffff"+
            "\1\7",
            "",
            "\1\uffff",
            "",
            "\1\3\103\uffff\1\5",
            "",
            "",
            "",
            "",
            ""
    };

    static final short[] DFA57_eot = DFA.unpackEncodedString(DFA57_eotS);
    static final short[] DFA57_eof = DFA.unpackEncodedString(DFA57_eofS);
    static final char[] DFA57_min = DFA.unpackEncodedStringToUnsignedChars(DFA57_minS);
    static final char[] DFA57_max = DFA.unpackEncodedStringToUnsignedChars(DFA57_maxS);
    static final short[] DFA57_accept = DFA.unpackEncodedString(DFA57_acceptS);
    static final short[] DFA57_special = DFA.unpackEncodedString(DFA57_specialS);
    static final short[][] DFA57_transition;

    static {
        int numStates = DFA57_transitionS.length;
        DFA57_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA57_transition[i] = DFA.unpackEncodedString(DFA57_transitionS[i]);
        }
    }

    class DFA57 extends DFA {

        public DFA57(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 57;
            this.eot = DFA57_eot;
            this.eof = DFA57_eof;
            this.min = DFA57_min;
            this.max = DFA57_max;
            this.accept = DFA57_accept;
            this.special = DFA57_special;
            this.transition = DFA57_transition;
        }
        public String getDescription() {
            return "68:19: (elem_name+= t_macro | elem_name+= string | elem_name+= function | elem_name+= curly_brackets | elem_name+= square_brackets | elem_name+= t_lineto )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA57_2 = input.LA(1);

                         
                        int index57_2 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred50_TikzGrammar()) ) {s = 3;}

                        else if ( (true) ) {s = 9;}

                         
                        input.seek(index57_2);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 57, _s, input);
            error(nvae);
            throw nvae;
        }
    }
    static final String DFA63_eotS =
        "\50\uffff";
    static final String DFA63_eofS =
        "\50\uffff";
    static final String DFA63_minS =
        "\42\4\1\uffff\2\4\2\0\1\uffff";
    static final String DFA63_maxS =
        "\42\122\1\uffff\2\122\2\0\1\uffff";
    static final String DFA63_acceptS =
        "\42\uffff\1\2\4\uffff\1\1";
    static final String DFA63_specialS =
        "\45\uffff\1\0\1\1\1\uffff}>";
    static final String[] DFA63_transitionS = {
            "\1\42\1\3\1\4\1\16\1\24\1\1\1\2\1\5\1\6\1\7\1\10\1\11\1\12"+
            "\1\13\1\14\1\15\1\17\1\20\1\21\1\22\1\23\1\25\1\26\1\27\1\30"+
            "\1\31\1\32\1\33\1\34\1\35\1\36\1\37\1\40\1\41\1\42\43\uffff"+
            "\1\42\2\uffff\1\42\1\uffff\1\42\1\uffff\2\42",
            "\5\42\1\43\1\44\6\42\1\45\25\42\43\uffff\1\42\2\uffff\3\42"+
            "\1\uffff\2\42",
            "\6\42\1\2\6\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff"+
            "\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "\15\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff\2\42",
            "",
            "\5\42\1\43\1\44\6\42\1\45\25\42\43\uffff\1\42\2\uffff\3\42"+
            "\1\uffff\2\42",
            "\6\42\1\44\6\42\1\46\25\42\43\uffff\1\42\2\uffff\3\42\1\uffff"+
            "\2\42",
            "\1\uffff",
            "\1\uffff",
            ""
    };

    static final short[] DFA63_eot = DFA.unpackEncodedString(DFA63_eotS);
    static final short[] DFA63_eof = DFA.unpackEncodedString(DFA63_eofS);
    static final char[] DFA63_min = DFA.unpackEncodedStringToUnsignedChars(DFA63_minS);
    static final char[] DFA63_max = DFA.unpackEncodedStringToUnsignedChars(DFA63_maxS);
    static final short[] DFA63_accept = DFA.unpackEncodedString(DFA63_acceptS);
    static final short[] DFA63_special = DFA.unpackEncodedString(DFA63_specialS);
    static final short[][] DFA63_transition;

    static {
        int numStates = DFA63_transitionS.length;
        DFA63_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA63_transition[i] = DFA.unpackEncodedString(DFA63_transitionS[i]);
        }
    }

    class DFA63 extends DFA {

        public DFA63(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 63;
            this.eot = DFA63_eot;
            this.eof = DFA63_eof;
            this.min = DFA63_min;
            this.max = DFA63_max;
            this.accept = DFA63_accept;
            this.special = DFA63_special;
            this.transition = DFA63_transition;
        }
        public String getDescription() {
            return "97:79: (cs_name= string CS )?";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            TokenStream input = (TokenStream)_input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA63_37 = input.LA(1);

                         
                        int index63_37 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred107_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 34;}

                         
                        input.seek(index63_37);
                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA63_38 = input.LA(1);

                         
                        int index63_38 = input.index();
                        input.rewind();
                        s = -1;
                        if ( (synpred107_TikzGrammar()) ) {s = 39;}

                        else if ( (true) ) {s = 34;}

                         
                        input.seek(index63_38);
                        if ( s>=0 ) return s;
                        break;
            }
            if (state.backtracking>0) {state.failed=true; return -1;}
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 63, _s, input);
            error(nvae);
            throw nvae;
        }
    }
 

    public static final BitSet FOLLOW_t_main_structures_in_t_file52 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000006A400L});
    public static final BitSet FOLLOW_function_in_t_main_structures97 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_square_brackets_in_t_main_structures101 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_curly_brackets_in_t_main_structures105 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_block_in_t_main_structures109 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_list_in_t_main_structures113 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_macro_in_t_main_structures117 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BACKSLASH_in_t_block191 = new BitSet(new long[]{0x0000000000000020L});
    public static final BitSet FOLLOW_BEGIN_in_t_block193 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000400L});
    public static final BitSet FOLLOW_74_in_t_block195 = new BitSet(new long[]{0x0000003FFFFFFFE0L});
    public static final BitSet FOLLOW_string_in_t_block199 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000800L});
    public static final BitSet FOLLOW_75_in_t_block201 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_74_in_t_block205 = new BitSet(new long[]{0x0000003FFFFFFFE0L});
    public static final BitSet FOLLOW_string_in_t_block209 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000800L});
    public static final BitSet FOLLOW_75_in_t_block211 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_t_main_structures_in_t_block216 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_BACKSLASH_in_t_block219 = new BitSet(new long[]{0x0000000000000040L});
    public static final BitSet FOLLOW_END_in_t_block221 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000400L});
    public static final BitSet FOLLOW_74_in_t_block223 = new BitSet(new long[]{0x0000003FFFFFFFE0L});
    public static final BitSet FOLLOW_string_in_t_block225 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000800L});
    public static final BitSet FOLLOW_75_in_t_block227 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BACKSLASH_in_t_macro285 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_foreach_in_t_macro314 = new BitSet(new long[]{0x0000000000000002L,0x0000000000001000L});
    public static final BitSet FOLLOW_t_node_in_t_macro376 = new BitSet(new long[]{0x0000000000000002L,0x0000000000001000L});
    public static final BitSet FOLLOW_t_coordinate_in_t_macro438 = new BitSet(new long[]{0x0000000000000002L,0x0000000000001000L});
    public static final BitSet FOLLOW_string_in_t_macro519 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_macro_in_t_macro521 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_options_in_t_macro561 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_lineto_in_t_macro565 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_moveto_in_t_macro569 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_lineto_hv_in_t_macro573 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_lineto_vh_in_t_macro602 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_cycle_in_t_macro606 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_curve_in_t_macro610 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_rectangle_in_t_macro613 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_gird_in_t_macro617 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_parabola_in_t_macro621 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_plot_in_t_macro625 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_edge_in_t_macro629 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_to_path_in_t_macro658 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_to_path_in_t_macro662 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_foreach_in_t_macro667 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_edge_in_t_macro671 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_curly_brackets_in_t_macro677 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_block_in_t_macro682 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_circle_in_t_macro711 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_ellipse_in_t_macro715 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_arc_in_t_macro719 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_string_in_t_macro724 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_foreach_in_t_macro728 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_node_in_t_macro732 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_macro736 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000B400L});
    public static final BitSet FOLLOW_76_in_t_macro961 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_74_in_curly_brackets993 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006AC00L});
    public static final BitSet FOLLOW_t_main_structures_in_curly_brackets995 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006AC00L});
    public static final BitSet FOLLOW_75_in_curly_brackets998 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FUNC_in_function1061 = new BitSet(new long[]{0x0000000000000000L,0x0000000000002000L});
    public static final BitSet FOLLOW_77_in_function1064 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006E400L});
    public static final BitSet FOLLOW_function_in_function1066 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006E400L});
    public static final BitSet FOLLOW_curly_brackets_in_function1070 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006E400L});
    public static final BitSet FOLLOW_t_list_in_function1074 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006E400L});
    public static final BitSet FOLLOW_t_macro_in_function1077 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006E400L});
    public static final BitSet FOLLOW_78_in_function1081 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_79_in_square_brackets1165 = new BitSet(new long[]{0x0000000000000000L,0x0000000000010000L});
    public static final BitSet FOLLOW_80_in_square_brackets1187 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_list_elem_in_t_list1230 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000006A400L});
    public static final BitSet FOLLOW_81_in_t_list1234 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000006A400L});
    public static final BitSet FOLLOW_82_in_t_list1238 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000006A400L});
    public static final BitSet FOLLOW_AND_in_t_list1242 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000006A400L});
    public static final BitSet FOLLOW_t_macro_in_t_list_elem1307 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_string_in_t_list_elem1313 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_function_in_t_list_elem1319 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_curly_brackets_in_t_list_elem1325 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_square_brackets_in_t_list_elem1332 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_lineto_in_t_list_elem1338 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_multioperator_in_t_list_elem1361 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_macro_in_t_list_elem1367 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_string_in_t_list_elem1373 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_function_in_t_list_elem1379 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_curly_brackets_in_t_list_elem1385 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_square_brackets_in_t_list_elem1392 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_lineto_in_t_list_elem1398 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_macro_in_t_list_elem1469 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_string_in_t_list_elem1475 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_function_in_t_list_elem1481 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_curly_brackets_in_t_list_elem1487 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_square_brackets_in_t_list_elem1494 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_lineto_in_t_list_elem1501 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_79_in_t_options1594 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_t_list_elem_in_t_options1598 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000007A400L});
    public static final BitSet FOLLOW_81_in_t_options1602 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000007A400L});
    public static final BitSet FOLLOW_82_in_t_options1606 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000007A400L});
    public static final BitSet FOLLOW_80_in_t_options1611 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_OPERATOR_in_multioperator1707 = new BitSet(new long[]{0x0000000000000202L});
    public static final BitSet FOLLOW_OPERATOR_in_string1759 = new BitSet(new long[]{0x0000000000000600L});
    public static final BitSet FOLLOW_STRING_in_string1762 = new BitSet(new long[]{0x0000000000000402L});
    public static final BitSet FOLLOW_OPERATOR_in_string1784 = new BitSet(new long[]{0x0000000000000202L});
    public static final BitSet FOLLOW_BEGIN_in_string1821 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_string1823 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_HVLINE_in_string1825 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_VHLINE_in_string1827 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TO_in_string1829 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_IN_in_string1831 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_CYCLE_in_string1833 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FOREACH_in_string1835 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_CS_in_string1837 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_string1839 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_AT_in_string1858 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FUNC_in_string1860 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FUNCTION_in_string1862 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FILE_in_string1864 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_COORDINATES_in_string1866 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_COORDINATE_in_string1868 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_EDGE_in_string1870 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_AND_in_string1872 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_CONTROLS_in_string1874 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FROM_in_string1876 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_PARENT_in_string1878 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_DOTS_in_string1897 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RECTANGLE_in_string1899 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_GRID_in_string1901 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_PLOT_in_string1903 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_CHILD_in_string1905 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_CIRCLE_in_string1907 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ELLIPSE_in_string1909 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ARC_in_string1911 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_PARABOLA_in_string1913 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEND_in_string1915 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_COORDINATE_in_t_coordinate1970 = new BitSet(new long[]{0x0000000000000000L,0x000000000000A000L});
    public static final BitSet FOLLOW_t_options_in_t_coordinate1972 = new BitSet(new long[]{0x0000000000000000L,0x000000000000A000L});
    public static final BitSet FOLLOW_77_in_t_coordinate1975 = new BitSet(new long[]{0x0000003FFFFFFFE0L});
    public static final BitSet FOLLOW_string_in_t_coordinate1977 = new BitSet(new long[]{0x0000000000000000L,0x0000000000004000L});
    public static final BitSet FOLLOW_78_in_t_coordinate1979 = new BitSet(new long[]{0x0000000000080002L});
    public static final BitSet FOLLOW_AT_in_t_coordinate1983 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_multioperator_in_t_coordinate1985 = new BitSet(new long[]{0x0000000000000000L,0x0000000000002000L});
    public static final BitSet FOLLOW_77_in_t_coordinate1989 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_string_in_t_coordinate1995 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_CS_in_t_coordinate1997 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_t_options_in_t_coordinate2002 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_t_list_in_t_coordinate2005 = new BitSet(new long[]{0x0000000000000000L,0x0000000000004000L});
    public static final BitSet FOLLOW_78_in_t_coordinate2007 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_multioperator_in_t_coordinate2078 = new BitSet(new long[]{0x0000000000000000L,0x0000000000002000L});
    public static final BitSet FOLLOW_77_in_t_coordinate2081 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_string_in_t_coordinate2087 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_CS_in_t_coordinate2089 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_t_options_in_t_coordinate2094 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_t_list_in_t_coordinate2097 = new BitSet(new long[]{0x0000000000000000L,0x0000000000004000L});
    public static final BitSet FOLLOW_78_in_t_coordinate2099 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_coordinate_in_t_moveto2165 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LINE_in_t_lineto2211 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_lineto2213 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_HVLINE_in_t_lineto_hv2267 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_lineto_hv2269 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_VHLINE_in_t_lineto_vh2331 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_lineto_vh2333 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LINE_in_t_cycle2387 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_CYCLE_in_t_cycle2389 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TO_in_t_to_path2444 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_options_in_t_to_path2446 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_to_path2449 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TO_in_t_to_path2493 = new BitSet(new long[]{0x0000000000040000L,0x0000000000008000L});
    public static final BitSet FOLLOW_t_options_in_t_to_path2495 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_NODE_in_t_to_path2498 = new BitSet(new long[]{0x0000000000000000L,0x0000000000008400L});
    public static final BitSet FOLLOW_t_options_in_t_to_path2500 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000400L});
    public static final BitSet FOLLOW_curly_brackets_in_t_to_path2503 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_to_path2505 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_t_node2568 = new BitSet(new long[]{0x0000000000080000L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_options_in_t_node2570 = new BitSet(new long[]{0x0000000000080000L,0x000000000000A400L});
    public static final BitSet FOLLOW_77_in_t_node2575 = new BitSet(new long[]{0x0000003FFFFFFFE0L});
    public static final BitSet FOLLOW_string_in_t_node2577 = new BitSet(new long[]{0x0000000000000000L,0x0000000000004000L});
    public static final BitSet FOLLOW_78_in_t_node2579 = new BitSet(new long[]{0x0000000000080000L,0x0000000000008400L});
    public static final BitSet FOLLOW_AT_in_t_node2584 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_node2586 = new BitSet(new long[]{0x0000000000000000L,0x0000000000008400L});
    public static final BitSet FOLLOW_t_options_in_t_node2590 = new BitSet(new long[]{0x0000000000000000L,0x0000000000008400L});
    public static final BitSet FOLLOW_curly_brackets_in_t_node2593 = new BitSet(new long[]{0x0000000100000002L});
    public static final BitSet FOLLOW_CHILD_in_t_node2595 = new BitSet(new long[]{0x0000000100000002L});
    public static final BitSet FOLLOW_CHILD_in_t_child2688 = new BitSet(new long[]{0x0000000000010002L,0x0000000000008400L});
    public static final BitSet FOLLOW_t_options_in_t_child2690 = new BitSet(new long[]{0x0000000000010002L,0x0000000000000400L});
    public static final BitSet FOLLOW_t_foreach_in_t_child2697 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_curly_brackets_in_t_child2701 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FOREACH_in_t_foreach2761 = new BitSet(new long[]{0x0000000000000010L});
    public static final BitSet FOLLOW_BACKSLASH_in_t_foreach2764 = new BitSet(new long[]{0x0000003FFFFFFFE0L});
    public static final BitSet FOLLOW_string_in_t_foreach2766 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_IN_in_t_foreach2768 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000400L});
    public static final BitSet FOLLOW_74_in_t_foreach2770 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_t_list_in_t_foreach2772 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000800L});
    public static final BitSet FOLLOW_75_in_t_foreach2774 = new BitSet(new long[]{0x0000000000000010L,0x0000000000000400L});
    public static final BitSet FOLLOW_curly_brackets_in_t_foreach2778 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_macro_in_t_foreach2782 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BACKSLASH_in_t_againpath2853 = new BitSet(new long[]{0x0000008000000000L});
    public static final BitSet FOLLOW_AGAINPATH_in_t_againpath2855 = new BitSet(new long[]{0x0000000000000010L});
    public static final BitSet FOLLOW_BACKSLASH_in_t_againpath2857 = new BitSet(new long[]{0x0000003FFFFFFFE0L});
    public static final BitSet FOLLOW_string_in_t_againpath2859 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_EDGE_in_t_edge2927 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_options_in_t_edge2958 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_edge2961 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_options_in_t_edge3026 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_NODE_in_t_edge3029 = new BitSet(new long[]{0x0000000000000000L,0x0000000000008400L});
    public static final BitSet FOLLOW_t_options_in_t_edge3031 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000400L});
    public static final BitSet FOLLOW_curly_brackets_in_t_edge3034 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_edge3036 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_EDGE_in_t_edge3112 = new BitSet(new long[]{0x0000000004000000L});
    public static final BitSet FOLLOW_FROM_in_t_edge3114 = new BitSet(new long[]{0x0000000008000000L});
    public static final BitSet FOLLOW_PARENT_in_t_edge3116 = new BitSet(new long[]{0x0000000000000000L,0x0000000000008000L});
    public static final BitSet FOLLOW_t_options_in_t_edge3118 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_GRID_in_t_gird3205 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_gird3207 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_DOTS_in_t_curve3259 = new BitSet(new long[]{0x0000000002000000L});
    public static final BitSet FOLLOW_CONTROLS_in_t_curve3261 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_curve3265 = new BitSet(new long[]{0x0000000010000100L});
    public static final BitSet FOLLOW_AND_in_t_curve3269 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_curve3273 = new BitSet(new long[]{0x0000000010000000L});
    public static final BitSet FOLLOW_DOTS_in_t_curve3278 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_curve3282 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RECTANGLE_in_t_rectangle3369 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_rectangle3371 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_GRID_in_t_grid3431 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_grid3433 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_PARABOLA_in_t_parabola3494 = new BitSet(new long[]{0x0000002000000000L,0x0000000000008000L});
    public static final BitSet FOLLOW_t_options_in_t_parabola3496 = new BitSet(new long[]{0x0000002000000000L});
    public static final BitSet FOLLOW_BEND_in_t_parabola3499 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_parabola3503 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_parabola3507 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_CIRCLE_in_t_circle3559 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_circle3561 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ELLIPSE_in_t_ellipse3623 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_ellipse3625 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ARC_in_t_arc3689 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_t_arc3691 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LINE_in_t_plot3757 = new BitSet(new long[]{0x0000000080000000L});
    public static final BitSet FOLLOW_PLOT_in_t_plot3760 = new BitSet(new long[]{0x0000000000700080L,0x0000000000002000L});
    public static final BitSet FOLLOW_COORDINATES_in_t_plot3790 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000400L});
    public static final BitSet FOLLOW_74_in_t_plot3792 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000AC00L});
    public static final BitSet FOLLOW_t_coordinate_in_t_plot3794 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000AC00L});
    public static final BitSet FOLLOW_75_in_t_plot3797 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FILE_in_t_plot3866 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000400L});
    public static final BitSet FOLLOW_74_in_t_plot3868 = new BitSet(new long[]{0x0000003FFFFFFFE0L});
    public static final BitSet FOLLOW_string_in_t_plot3870 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000800L});
    public static final BitSet FOLLOW_75_in_t_plot3872 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FUNCTION_in_t_plot3940 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000400L});
    public static final BitSet FOLLOW_curly_brackets_in_t_plot3942 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_function_in_t_plot4009 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_function_in_synpred2_TikzGrammar97 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_square_brackets_in_synpred3_TikzGrammar101 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_curly_brackets_in_synpred4_TikzGrammar105 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_block_in_synpred5_TikzGrammar109 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_list_in_synpred6_TikzGrammar113 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_74_in_synpred7_TikzGrammar205 = new BitSet(new long[]{0x0000003FFFFFFFE0L});
    public static final BitSet FOLLOW_string_in_synpred7_TikzGrammar209 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000800L});
    public static final BitSet FOLLOW_75_in_synpred7_TikzGrammar211 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_main_structures_in_synpred8_TikzGrammar216 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_foreach_in_synpred9_TikzGrammar314 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_node_in_synpred10_TikzGrammar376 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_coordinate_in_synpred11_TikzGrammar438 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_macro_in_synpred12_TikzGrammar521 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_options_in_synpred13_TikzGrammar561 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_lineto_in_synpred14_TikzGrammar565 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_moveto_in_synpred15_TikzGrammar569 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_lineto_hv_in_synpred16_TikzGrammar573 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_lineto_vh_in_synpred17_TikzGrammar602 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_cycle_in_synpred18_TikzGrammar606 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_curve_in_synpred19_TikzGrammar610 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_rectangle_in_synpred20_TikzGrammar613 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_gird_in_synpred21_TikzGrammar617 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_parabola_in_synpred22_TikzGrammar621 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_plot_in_synpred23_TikzGrammar625 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_edge_in_synpred24_TikzGrammar629 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_to_path_in_synpred25_TikzGrammar658 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_to_path_in_synpred26_TikzGrammar662 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_foreach_in_synpred27_TikzGrammar667 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_edge_in_synpred28_TikzGrammar671 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_curly_brackets_in_synpred29_TikzGrammar677 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_block_in_synpred30_TikzGrammar682 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_circle_in_synpred31_TikzGrammar711 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_ellipse_in_synpred32_TikzGrammar715 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_arc_in_synpred33_TikzGrammar719 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_string_in_synpred34_TikzGrammar724 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_foreach_in_synpred35_TikzGrammar728 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_node_in_synpred36_TikzGrammar732 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_coordinate_in_synpred37_TikzGrammar736 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_76_in_synpred38_TikzGrammar961 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_function_in_synpred41_TikzGrammar1066 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_curly_brackets_in_synpred42_TikzGrammar1070 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_list_in_synpred43_TikzGrammar1074 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_macro_in_synpred44_TikzGrammar1077 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_list_elem_in_synpred45_TikzGrammar1230 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_AND_in_synpred48_TikzGrammar1242 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_string_in_synpred50_TikzGrammar1313 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_string_in_synpred56_TikzGrammar1373 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_function_in_synpred57_TikzGrammar1379 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_macro_in_synpred60_TikzGrammar1307 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_string_in_synpred60_TikzGrammar1313 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_function_in_synpred60_TikzGrammar1319 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_curly_brackets_in_synpred60_TikzGrammar1325 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_square_brackets_in_synpred60_TikzGrammar1332 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_lineto_in_synpred60_TikzGrammar1338 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_multioperator_in_synpred60_TikzGrammar1361 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_macro_in_synpred60_TikzGrammar1367 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_string_in_synpred60_TikzGrammar1373 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_function_in_synpred60_TikzGrammar1379 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_curly_brackets_in_synpred60_TikzGrammar1385 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_square_brackets_in_synpred60_TikzGrammar1392 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_lineto_in_synpred60_TikzGrammar1398 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_string_in_synpred62_TikzGrammar1475 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_function_in_synpred63_TikzGrammar1481 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_OPERATOR_in_synpred69_TikzGrammar1707 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_STRING_in_synpred71_TikzGrammar1762 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_OPERATOR_in_synpred72_TikzGrammar1759 = new BitSet(new long[]{0x0000000000000600L});
    public static final BitSet FOLLOW_STRING_in_synpred72_TikzGrammar1762 = new BitSet(new long[]{0x0000000000000402L});
    public static final BitSet FOLLOW_OPERATOR_in_synpred73_TikzGrammar1784 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_OPERATOR_in_synpred74_TikzGrammar1784 = new BitSet(new long[]{0x0000000000000202L});
    public static final BitSet FOLLOW_string_in_synpred107_TikzGrammar1995 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_CS_in_synpred107_TikzGrammar1997 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_AT_in_synpred109_TikzGrammar1983 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_multioperator_in_synpred109_TikzGrammar1985 = new BitSet(new long[]{0x0000000000000000L,0x0000000000002000L});
    public static final BitSet FOLLOW_77_in_synpred109_TikzGrammar1989 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_string_in_synpred109_TikzGrammar1995 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_CS_in_synpred109_TikzGrammar1997 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_t_options_in_synpred109_TikzGrammar2002 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000006A400L});
    public static final BitSet FOLLOW_t_list_in_synpred109_TikzGrammar2005 = new BitSet(new long[]{0x0000000000000000L,0x0000000000004000L});
    public static final BitSet FOLLOW_78_in_synpred109_TikzGrammar2007 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_string_in_synpred112_TikzGrammar2087 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_CS_in_synpred112_TikzGrammar2089 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TO_in_synpred115_TikzGrammar2444 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_options_in_synpred115_TikzGrammar2446 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_synpred115_TikzGrammar2449 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_coordinate_in_synpred118_TikzGrammar2505 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_options_in_synpred119_TikzGrammar2570 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_CHILD_in_synpred123_TikzGrammar2595 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_options_in_synpred130_TikzGrammar2958 = new BitSet(new long[]{0x0000007FFFFFFFF0L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_synpred130_TikzGrammar2961 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_coordinate_in_synpred133_TikzGrammar3036 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_options_in_synpred134_TikzGrammar3026 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_NODE_in_synpred134_TikzGrammar3029 = new BitSet(new long[]{0x0000000000000000L,0x0000000000008400L});
    public static final BitSet FOLLOW_t_options_in_synpred134_TikzGrammar3031 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000400L});
    public static final BitSet FOLLOW_curly_brackets_in_synpred134_TikzGrammar3034 = new BitSet(new long[]{0x0000007FFFFFFFF2L,0x000000000000A400L});
    public static final BitSet FOLLOW_t_coordinate_in_synpred134_TikzGrammar3036 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_t_coordinate_in_synpred137_TikzGrammar3507 = new BitSet(new long[]{0x0000000000000002L});

}