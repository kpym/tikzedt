// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-12-02 14:06:47

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;

import org.antlr.runtime.tree.*;

public class simpletikzParser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BEGIN", "END", "BEGINTP", "ENDTP", "BEGINSCOPE", "ENDSCOPE", "NODE", "DRAW", "PATH", "FILL", "LPAR", "RPAR", "LBR", "RBR", "LBRR", "RBRR", "KOMMA", "SCALE", "EQU", "SEMIC", "COLON", "STYLESEP", "AT", "LABEL", "EVERYLOOP", "ST_INNERSEP", "ST_OUTERSEP", "ST_FILL", "ST_DRAW", "ST_SHAPE", "ST_MINSIZE", "ST_LINEWIDTH", "ST_DASHSTYLE", "LOOP", "IN", "OUT", "UN_PTS", "UN_CM", "IM_PATH", "IM_NODE", "IM_COORD", "IM_NODENAME", "IM_NUMBERUNIT", "IM_PICTURE", "IM_DOCUMENT", "IM_SCOPE", "IM_STARTTAG", "IM_ENDTAG", "IM_OPTIONS", "OPTIONS", "STRING", "ID", "FLOAT", "INT", "SOMETHING", "EXPONENT", "COMMENT", "WS", "ESC_SEQ", "'node'", "'--'", "'edge'", "'->'", "'|-'", "'-|'", "'to'", "'+'", "'++'", "'ex'", "'mm'"
    };
    public static final int T__68=68;
    public static final int T__69=69;
    public static final int T__66=66;
    public static final int EXPONENT=59;
    public static final int T__67=67;
    public static final int T__64=64;
    public static final int IM_STARTTAG=50;
    public static final int T__65=65;
    public static final int T__63=63;
    public static final int IM_PATH=42;
    public static final int RBR=17;
    public static final int ST_DASHSTYLE=36;
    public static final int ST_LINEWIDTH=35;
    public static final int ST_FILL=31;
    public static final int FLOAT=56;
    public static final int BEGINTP=6;
    public static final int SOMETHING=58;
    public static final int ID=55;
    public static final int EOF=-1;
    public static final int LBR=16;
    public static final int IM_ENDTAG=51;
    public static final int AT=26;
    public static final int IM_DOCUMENT=48;
    public static final int RBRR=19;
    public static final int ESC_SEQ=62;
    public static final int IN=38;
    public static final int LPAR=14;
    public static final int EVERYLOOP=28;
    public static final int ENDTP=7;
    public static final int FILL=13;
    public static final int PATH=12;
    public static final int LOOP=37;
    public static final int BEGIN=4;
    public static final int ST_OUTERSEP=30;
    public static final int COMMENT=60;
    public static final int ST_INNERSEP=29;
    public static final int IM_OPTIONS=52;
    public static final int NODE=10;
    public static final int UN_PTS=40;
    public static final int STYLESEP=25;
    public static final int IM_COORD=44;
    public static final int IM_PICTURE=47;
    public static final int INT=57;
    public static final int BEGINSCOPE=8;
    public static final int LBRR=18;
    public static final int UN_CM=41;
    public static final int IM_NODE=43;
    public static final int COLON=24;
    public static final int ENDSCOPE=9;
    public static final int ST_DRAW=32;
    public static final int IM_SCOPE=49;
    public static final int IM_NUMBERUNIT=46;
    public static final int SCALE=21;
    public static final int WS=61;
    public static final int T__71=71;
    public static final int T__72=72;
    public static final int T__70=70;
    public static final int OUT=39;
    public static final int ST_MINSIZE=34;
    public static final int LABEL=27;
    public static final int KOMMA=20;
    public static final int ST_SHAPE=33;
    public static final int EQU=22;
    public static final int RPAR=15;
    public static final int END=5;
    public static final int SEMIC=23;
    public static final int IM_NODENAME=45;
    public static final int T__73=73;
    public static final int OPTIONS=53;
    public static final int STRING=54;
    public static final int DRAW=11;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "number", "coordornode", "tikzpicture_end", "coord", 
        "path_start_tag", "tikzscope", "numberunit", "tikzdocument", "unit", 
        "tikzbody", "tikzpicture", "path_start", "edgeop", "tikzpath", "tikznode", 
        "tikzpathi", "tikznodee", "tikznodei", "path_end", "nodename", "tikzpicture_start", 
        "node_start", "coord_modifier"
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


    public static class tikzpath_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpath"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:1: tikzpath : path_start tikzpathi path_end -> ^( IM_PATH path_start tikzpathi path_end ) ;
    public final simpletikzParser.tikzpath_return tikzpath() throws RecognitionException {
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_return path_start1 = null;

        simpletikzParser.tikzpathi_return tikzpathi2 = null;

        simpletikzParser.path_end_return path_end3 = null;


        RewriteRuleSubtreeStream stream_path_end=new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_path_start=new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try { dbg.enterRule(getGrammarFileName(), "tikzpath");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(72, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:2: ( path_start tikzpathi path_end -> ^( IM_PATH path_start tikzpathi path_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:4: path_start tikzpathi path_end
            {
            dbg.location(73,4);
            pushFollow(FOLLOW_path_start_in_tikzpath417);
            path_start1=path_start();

            state._fsp--;

            stream_path_start.add(path_start1.getTree());
            dbg.location(73,15);
            pushFollow(FOLLOW_tikzpathi_in_tikzpath419);
            tikzpathi2=tikzpathi();

            state._fsp--;

            stream_tikzpathi.add(tikzpathi2.getTree());
            dbg.location(73,25);
            pushFollow(FOLLOW_path_end_in_tikzpath421);
            path_end3=path_end();

            state._fsp--;

            stream_path_end.add(path_end3.getTree());


            // AST REWRITE
            // elements: tikzpathi, path_end, path_start
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 73:34: -> ^( IM_PATH path_start tikzpathi path_end )
            {
                dbg.location(73,37);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:37: ^( IM_PATH path_start tikzpathi path_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(73,39);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(73,47);
                adaptor.addChild(root_1, stream_path_start.nextTree());
                dbg.location(73,58);
                adaptor.addChild(root_1, stream_tikzpathi.nextTree());
                dbg.location(73,68);
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
        dbg.location(74, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:75:1: path_end : SEMIC -> ^( IM_ENDTAG SEMIC ) ;
    public final simpletikzParser.path_end_return path_end() throws RecognitionException {
        simpletikzParser.path_end_return retval = new simpletikzParser.path_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token SEMIC4=null;

        Object SEMIC4_tree=null;
        RewriteRuleTokenStream stream_SEMIC=new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try { dbg.enterRule(getGrammarFileName(), "path_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(75, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:2: ( SEMIC -> ^( IM_ENDTAG SEMIC ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:4: SEMIC
            {
            dbg.location(76,4);
            SEMIC4=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_path_end444);  
            stream_SEMIC.add(SEMIC4);



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
            // 76:10: -> ^( IM_ENDTAG SEMIC )
            {
                dbg.location(76,13);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:13: ^( IM_ENDTAG SEMIC )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(76,15);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(76,25);
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
        dbg.location(77, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:1: tikzpathi : ( OPTIONS )? coordornode ( coordornode | ( OPTIONS )? edgeop coordornode )* ;
    public final simpletikzParser.tikzpathi_return tikzpathi() throws RecognitionException {
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token OPTIONS5=null;
        Token OPTIONS8=null;
        simpletikzParser.coordornode_return coordornode6 = null;

        simpletikzParser.coordornode_return coordornode7 = null;

        simpletikzParser.edgeop_return edgeop9 = null;

        simpletikzParser.coordornode_return coordornode10 = null;


        Object OPTIONS5_tree=null;
        Object OPTIONS8_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "tikzpathi");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(79, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:2: ( ( OPTIONS )? coordornode ( coordornode | ( OPTIONS )? edgeop coordornode )* )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:4: ( OPTIONS )? coordornode ( coordornode | ( OPTIONS )? edgeop coordornode )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(80,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:4: ( OPTIONS )?
            int alt1=2;
            try { dbg.enterSubRule(1);
            try { dbg.enterDecision(1);

            int LA1_0 = input.LA(1);

            if ( (LA1_0==OPTIONS) ) {
                alt1=1;
            }
            } finally {dbg.exitDecision(1);}

            switch (alt1) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:5: OPTIONS
                    {
                    dbg.location(80,12);
                    OPTIONS5=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpathi464); 

                    }
                    break;

            }
            } finally {dbg.exitSubRule(1);}

            dbg.location(80,16);
            pushFollow(FOLLOW_coordornode_in_tikzpathi469);
            coordornode6=coordornode();

            state._fsp--;

            adaptor.addChild(root_0, coordornode6.getTree());
            dbg.location(80,28);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:28: ( coordornode | ( OPTIONS )? edgeop coordornode )*
            try { dbg.enterSubRule(3);

            loop3:
            do {
                int alt3=3;
                try { dbg.enterDecision(3);

                int LA3_0 = input.LA(1);

                if ( (LA3_0==LPAR||LA3_0==63||(LA3_0>=70 && LA3_0<=71)) ) {
                    alt3=1;
                }
                else if ( (LA3_0==OPTIONS||(LA3_0>=64 && LA3_0<=69)) ) {
                    alt3=2;
                }


                } finally {dbg.exitDecision(3);}

                switch (alt3) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:29: coordornode
            	    {
            	    dbg.location(80,29);
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi472);
            	    coordornode7=coordornode();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode7.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:43: ( OPTIONS )? edgeop coordornode
            	    {
            	    dbg.location(80,43);
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:43: ( OPTIONS )?
            	    int alt2=2;
            	    try { dbg.enterSubRule(2);
            	    try { dbg.enterDecision(2);

            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0==OPTIONS) ) {
            	        alt2=1;
            	    }
            	    } finally {dbg.exitDecision(2);}

            	    switch (alt2) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:44: OPTIONS
            	            {
            	            dbg.location(80,51);
            	            OPTIONS8=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpathi477); 

            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(2);}

            	    dbg.location(80,61);
            	    pushFollow(FOLLOW_edgeop_in_tikzpathi482);
            	    edgeop9=edgeop();

            	    state._fsp--;

            	    dbg.location(80,63);
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi485);
            	    coordornode10=coordornode();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode10.getTree());

            	    }
            	    break;

            	default :
            	    break loop3;
                }
            } while (true);
            } finally {dbg.exitSubRule(3);}


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
        dbg.location(81, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:1: coordornode : ( coord | tikznodei );
    public final simpletikzParser.coordornode_return coordornode() throws RecognitionException {
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coord_return coord11 = null;

        simpletikzParser.tikznodei_return tikznodei12 = null;



        try { dbg.enterRule(getGrammarFileName(), "coordornode");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(83, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:2: ( coord | tikznodei )
            int alt4=2;
            try { dbg.enterDecision(4);

            int LA4_0 = input.LA(1);

            if ( (LA4_0==LPAR||(LA4_0>=70 && LA4_0<=71)) ) {
                alt4=1;
            }
            else if ( (LA4_0==63) ) {
                alt4=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 4, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(4);}

            switch (alt4) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:4: coord
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(84,4);
                    pushFollow(FOLLOW_coord_in_coordornode500);
                    coord11=coord();

                    state._fsp--;

                    adaptor.addChild(root_0, coord11.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:12: tikznodei
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(84,12);
                    pushFollow(FOLLOW_tikznodei_in_coordornode504);
                    tikznodei12=tikznodei();

                    state._fsp--;

                    adaptor.addChild(root_0, tikznodei12.getTree());

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
        dbg.location(85, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:1: tikznodei : 'node' tikznode ;
    public final simpletikzParser.tikznodei_return tikznodei() throws RecognitionException {
        simpletikzParser.tikznodei_return retval = new simpletikzParser.tikznodei_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal13=null;
        simpletikzParser.tikznode_return tikznode14 = null;


        Object string_literal13_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "tikznodei");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(87, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:88:2: ( 'node' tikznode )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:88:4: 'node' tikznode
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(88,10);
            string_literal13=(Token)match(input,63,FOLLOW_63_in_tikznodei516); 
            dbg.location(88,12);
            pushFollow(FOLLOW_tikznode_in_tikznodei519);
            tikznode14=tikznode();

            state._fsp--;

            adaptor.addChild(root_0, tikznode14.getTree());

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
        dbg.location(89, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:1: tikznodee : node_start tikznode ( tikzpathi )? path_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end ) ;
    public final simpletikzParser.tikznodee_return tikznodee() throws RecognitionException {
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.node_start_return node_start15 = null;

        simpletikzParser.tikznode_return tikznode16 = null;

        simpletikzParser.tikzpathi_return tikzpathi17 = null;

        simpletikzParser.path_end_return path_end18 = null;


        RewriteRuleSubtreeStream stream_node_start=new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_path_end=new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_tikznode=new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try { dbg.enterRule(getGrammarFileName(), "tikznodee");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(90, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:2: ( node_start tikznode ( tikzpathi )? path_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:4: node_start tikznode ( tikzpathi )? path_end
            {
            dbg.location(91,4);
            pushFollow(FOLLOW_node_start_in_tikznodee529);
            node_start15=node_start();

            state._fsp--;

            stream_node_start.add(node_start15.getTree());
            dbg.location(91,15);
            pushFollow(FOLLOW_tikznode_in_tikznodee531);
            tikznode16=tikznode();

            state._fsp--;

            stream_tikznode.add(tikznode16.getTree());
            dbg.location(91,24);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:24: ( tikzpathi )?
            int alt5=2;
            try { dbg.enterSubRule(5);
            try { dbg.enterDecision(5);

            int LA5_0 = input.LA(1);

            if ( (LA5_0==LPAR||LA5_0==OPTIONS||LA5_0==63||(LA5_0>=70 && LA5_0<=71)) ) {
                alt5=1;
            }
            } finally {dbg.exitDecision(5);}

            switch (alt5) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:24: tikzpathi
                    {
                    dbg.location(91,24);
                    pushFollow(FOLLOW_tikzpathi_in_tikznodee533);
                    tikzpathi17=tikzpathi();

                    state._fsp--;

                    stream_tikzpathi.add(tikzpathi17.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(5);}

            dbg.location(91,35);
            pushFollow(FOLLOW_path_end_in_tikznodee536);
            path_end18=path_end();

            state._fsp--;

            stream_path_end.add(path_end18.getTree());


            // AST REWRITE
            // elements: path_end, tikzpathi, tikznode, node_start
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 91:44: -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end )
            {
                dbg.location(91,47);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:47: ^( IM_PATH node_start tikznode ( tikzpathi )? path_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(91,49);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(91,57);
                adaptor.addChild(root_1, stream_node_start.nextTree());
                dbg.location(91,68);
                adaptor.addChild(root_1, stream_tikznode.nextTree());
                dbg.location(91,77);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:77: ( tikzpathi )?
                if ( stream_tikzpathi.hasNext() ) {
                    dbg.location(91,77);
                    adaptor.addChild(root_1, stream_tikzpathi.nextTree());

                }
                stream_tikzpathi.reset();
                dbg.location(91,88);
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
        dbg.location(92, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public final simpletikzParser.node_start_return node_start() throws RecognitionException {
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token NODE19=null;

        Object NODE19_tree=null;
        RewriteRuleTokenStream stream_NODE=new RewriteRuleTokenStream(adaptor,"token NODE");

        try { dbg.enterRule(getGrammarFileName(), "node_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(93, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:4: NODE
            {
            dbg.location(94,4);
            NODE19=(Token)match(input,NODE,FOLLOW_NODE_in_node_start562);  
            stream_NODE.add(NODE19);



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
            // 94:9: -> ^( IM_STARTTAG NODE )
            {
                dbg.location(94,12);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:12: ^( IM_STARTTAG NODE )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(94,14);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(94,26);
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
        dbg.location(95, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:1: tikznode : ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING ) ;
    public final simpletikzParser.tikznode_return tikznode() throws RecognitionException {
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token OPTIONS20=null;
        Token string_literal22=null;
        Token STRING24=null;
        simpletikzParser.nodename_return nodename21 = null;

        simpletikzParser.coord_return coord23 = null;


        Object OPTIONS20_tree=null;
        Object string_literal22_tree=null;
        Object STRING24_tree=null;
        RewriteRuleTokenStream stream_AT=new RewriteRuleTokenStream(adaptor,"token AT");
        RewriteRuleTokenStream stream_OPTIONS=new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleTokenStream stream_STRING=new RewriteRuleTokenStream(adaptor,"token STRING");
        RewriteRuleSubtreeStream stream_coord=new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try { dbg.enterRule(getGrammarFileName(), "tikznode");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(96, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:2: ( ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:4: ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING
            {
            dbg.location(97,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:4: ( OPTIONS )?
            int alt6=2;
            try { dbg.enterSubRule(6);
            try { dbg.enterDecision(6);

            int LA6_0 = input.LA(1);

            if ( (LA6_0==OPTIONS) ) {
                alt6=1;
            }
            } finally {dbg.exitDecision(6);}

            switch (alt6) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:4: OPTIONS
                    {
                    dbg.location(97,4);
                    OPTIONS20=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikznode580);  
                    stream_OPTIONS.add(OPTIONS20);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(6);}

            dbg.location(97,13);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:13: ( nodename )?
            int alt7=2;
            try { dbg.enterSubRule(7);
            try { dbg.enterDecision(7);

            int LA7_0 = input.LA(1);

            if ( (LA7_0==LPAR) ) {
                alt7=1;
            }
            } finally {dbg.exitDecision(7);}

            switch (alt7) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:13: nodename
                    {
                    dbg.location(97,13);
                    pushFollow(FOLLOW_nodename_in_tikznode583);
                    nodename21=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename21.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(7);}

            dbg.location(97,23);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:23: ( 'at' coord )?
            int alt8=2;
            try { dbg.enterSubRule(8);
            try { dbg.enterDecision(8);

            int LA8_0 = input.LA(1);

            if ( (LA8_0==AT) ) {
                alt8=1;
            }
            } finally {dbg.exitDecision(8);}

            switch (alt8) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:24: 'at' coord
                    {
                    dbg.location(97,24);
                    string_literal22=(Token)match(input,AT,FOLLOW_AT_in_tikznode587);  
                    stream_AT.add(string_literal22);

                    dbg.location(97,29);
                    pushFollow(FOLLOW_coord_in_tikznode589);
                    coord23=coord();

                    state._fsp--;

                    stream_coord.add(coord23.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(8);}

            dbg.location(97,37);
            STRING24=(Token)match(input,STRING,FOLLOW_STRING_in_tikznode593);  
            stream_STRING.add(STRING24);



            // AST REWRITE
            // elements: nodename, coord, OPTIONS, STRING
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 97:45: -> ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING )
            {
                dbg.location(97,48);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:48: ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(97,50);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODE, "IM_NODE"), root_1);

                dbg.location(97,58);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:58: ( OPTIONS )?
                if ( stream_OPTIONS.hasNext() ) {
                    dbg.location(97,58);
                    adaptor.addChild(root_1, stream_OPTIONS.nextNode());

                }
                stream_OPTIONS.reset();
                dbg.location(97,67);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:67: ( nodename )?
                if ( stream_nodename.hasNext() ) {
                    dbg.location(97,67);
                    adaptor.addChild(root_1, stream_nodename.nextTree());

                }
                stream_nodename.reset();
                dbg.location(97,77);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:77: ( coord )?
                if ( stream_coord.hasNext() ) {
                    dbg.location(97,77);
                    adaptor.addChild(root_1, stream_coord.nextTree());

                }
                stream_coord.reset();
                dbg.location(97,84);
                adaptor.addChild(root_1, stream_STRING.nextNode());

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
        dbg.location(98, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:1: edgeop : ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' );
    public final simpletikzParser.edgeop_return edgeop() throws RecognitionException {
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set25=null;

        Object set25_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "edgeop");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(100, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:101:2: ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(101,2);
            set25=(Token)input.LT(1);
            if ( (input.LA(1)>=64 && input.LA(1)<=69) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set25));
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
        dbg.location(102, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:1: nodename : lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) ;
    public final simpletikzParser.nodename_return nodename() throws RecognitionException {
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token id=null;
        Token RPAR26=null;

        Object lc_tree=null;
        Object id_tree=null;
        Object RPAR26_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try { dbg.enterRule(getGrammarFileName(), "nodename");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(104, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:2: (lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:4: lc= LPAR id= ID RPAR
            {
            dbg.location(105,6);
            lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_nodename661);  
            stream_LPAR.add(lc);

            dbg.location(105,14);
            id=(Token)match(input,ID,FOLLOW_ID_in_nodename665);  
            stream_ID.add(id);

            dbg.location(105,18);
            RPAR26=(Token)match(input,RPAR,FOLLOW_RPAR_in_nodename667);  
            stream_RPAR.add(RPAR26);



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
            // 105:24: -> ^( IM_NODENAME[$lc] $id)
            {
                dbg.location(105,27);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:27: ^( IM_NODENAME[$lc] $id)
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(105,29);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODENAME, lc), root_1);

                dbg.location(105,46);
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
        dbg.location(106, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) );
    public final simpletikzParser.coord_return coord() throws RecognitionException {
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token KOMMA30=null;
        Token RPAR32=null;
        simpletikzParser.nodename_return nodename27 = null;

        simpletikzParser.coord_modifier_return coord_modifier28 = null;

        simpletikzParser.numberunit_return numberunit29 = null;

        simpletikzParser.numberunit_return numberunit31 = null;


        Object lc_tree=null;
        Object KOMMA30_tree=null;
        Object RPAR32_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_numberunit=new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier=new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try { dbg.enterRule(getGrammarFileName(), "coord");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(108, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) )
            int alt10=2;
            try { dbg.enterDecision(10);

            int LA10_0 = input.LA(1);

            if ( (LA10_0==LPAR) ) {
                int LA10_1 = input.LA(2);

                if ( (LA10_1==ID) ) {
                    alt10=1;
                }
                else if ( ((LA10_1>=FLOAT && LA10_1<=INT)) ) {
                    alt10=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 10, 1, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
            }
            else if ( ((LA10_0>=70 && LA10_0<=71)) ) {
                alt10=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 10, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(10);}

            switch (alt10) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:6: nodename
                    {
                    dbg.location(109,6);
                    pushFollow(FOLLOW_nodename_in_coord692);
                    nodename27=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename27.getTree());


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
                    // 109:23: -> ^( IM_COORD nodename )
                    {
                        dbg.location(109,26);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:109:26: ^( IM_COORD nodename )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(109,28);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, "IM_COORD"), root_1);

                        dbg.location(109,37);
                        adaptor.addChild(root_1, stream_nodename.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:110:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    {
                    dbg.location(110,5);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:110:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:110:7: ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR
                    {
                    dbg.location(110,7);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:110:7: ( coord_modifier )?
                    int alt9=2;
                    try { dbg.enterSubRule(9);
                    try { dbg.enterDecision(9);

                    int LA9_0 = input.LA(1);

                    if ( ((LA9_0>=70 && LA9_0<=71)) ) {
                        alt9=1;
                    }
                    } finally {dbg.exitDecision(9);}

                    switch (alt9) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:110:7: coord_modifier
                            {
                            dbg.location(110,7);
                            pushFollow(FOLLOW_coord_modifier_in_coord716);
                            coord_modifier28=coord_modifier();

                            state._fsp--;

                            stream_coord_modifier.add(coord_modifier28.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(9);}

                    dbg.location(110,25);
                    lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_coord721);  
                    stream_LPAR.add(lc);

                    dbg.location(110,31);
                    pushFollow(FOLLOW_numberunit_in_coord723);
                    numberunit29=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit29.getTree());
                    dbg.location(110,42);
                    KOMMA30=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_coord725);  
                    stream_KOMMA.add(KOMMA30);

                    dbg.location(110,48);
                    pushFollow(FOLLOW_numberunit_in_coord727);
                    numberunit31=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit31.getTree());
                    dbg.location(110,59);
                    RPAR32=(Token)match(input,RPAR,FOLLOW_RPAR_in_coord729);  
                    stream_RPAR.add(RPAR32);


                    }



                    // AST REWRITE
                    // elements: numberunit, coord_modifier
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 110:66: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    {
                        dbg.location(110,69);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:110:69: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(110,71);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, lc), root_1);

                        dbg.location(110,85);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:110:85: ( coord_modifier )?
                        if ( stream_coord_modifier.hasNext() ) {
                            dbg.location(110,85);
                            adaptor.addChild(root_1, stream_coord_modifier.nextTree());

                        }
                        stream_coord_modifier.reset();
                        dbg.location(110,101);
                        if ( !(stream_numberunit.hasNext()) ) {
                            throw new RewriteEarlyExitException();
                        }
                        while ( stream_numberunit.hasNext() ) {
                            dbg.location(110,101);
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
        dbg.location(111, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:1: coord_modifier : ( '+' | '++' );
    public final simpletikzParser.coord_modifier_return coord_modifier() throws RecognitionException {
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set33=null;

        Object set33_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "coord_modifier");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(113, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:114:2: ( '+' | '++' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(114,2);
            set33=(Token)input.LT(1);
            if ( (input.LA(1)>=70 && input.LA(1)<=71) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set33));
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
        dbg.location(115, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public final simpletikzParser.numberunit_return numberunit() throws RecognitionException {
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.number_return number34 = null;

        simpletikzParser.unit_return unit35 = null;


        RewriteRuleSubtreeStream stream_unit=new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
        try { dbg.enterRule(getGrammarFileName(), "numberunit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(117, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:4: number ( unit )?
            {
            dbg.location(118,4);
            pushFollow(FOLLOW_number_in_numberunit771);
            number34=number();

            state._fsp--;

            stream_number.add(number34.getTree());
            dbg.location(118,11);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:11: ( unit )?
            int alt11=2;
            try { dbg.enterSubRule(11);
            try { dbg.enterDecision(11);

            int LA11_0 = input.LA(1);

            if ( (LA11_0==IN||(LA11_0>=UN_PTS && LA11_0<=UN_CM)||(LA11_0>=72 && LA11_0<=73)) ) {
                alt11=1;
            }
            } finally {dbg.exitDecision(11);}

            switch (alt11) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:11: unit
                    {
                    dbg.location(118,11);
                    pushFollow(FOLLOW_unit_in_numberunit773);
                    unit35=unit();

                    state._fsp--;

                    stream_unit.add(unit35.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(11);}



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
            // 118:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            {
                dbg.location(118,20);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:20: ^( IM_NUMBERUNIT number ( unit )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(118,22);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

                dbg.location(118,36);
                adaptor.addChild(root_1, stream_number.nextTree());
                dbg.location(118,43);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:118:43: ( unit )?
                if ( stream_unit.hasNext() ) {
                    dbg.location(118,43);
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
        dbg.location(119, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:1: number : ( FLOAT | INT ) ;
    public final simpletikzParser.number_return number() throws RecognitionException {
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set36=null;

        Object set36_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "number");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(120, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:2: ( ( FLOAT | INT ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:4: ( FLOAT | INT )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(121,4);
            set36=(Token)input.LT(1);
            if ( (input.LA(1)>=FLOAT && input.LA(1)<=INT) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set36));
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
        dbg.location(122, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:123:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' );
    public final simpletikzParser.unit_return unit() throws RecognitionException {
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set37=null;

        Object set37_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(123, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(124,2);
            set37=(Token)input.LT(1);
            if ( input.LA(1)==IN||(input.LA(1)>=UN_PTS && input.LA(1)<=UN_CM)||(input.LA(1)>=72 && input.LA(1)<=73) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set37));
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
        dbg.location(125, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:127:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public final simpletikzParser.path_start_return path_start() throws RecognitionException {
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag38 = null;


        RewriteRuleSubtreeStream stream_path_start_tag=new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try { dbg.enterRule(getGrammarFileName(), "path_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(127, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:4: path_start_tag
            {
            dbg.location(128,4);
            pushFollow(FOLLOW_path_start_tag_in_path_start840);
            path_start_tag38=path_start_tag();

            state._fsp--;

            stream_path_start_tag.add(path_start_tag38.getTree());


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
            // 128:19: -> ^( IM_STARTTAG path_start_tag )
            {
                dbg.location(128,22);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:22: ^( IM_STARTTAG path_start_tag )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(128,24);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(128,36);
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
        dbg.location(129, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:1: path_start_tag : ( DRAW | FILL | PATH );
    public final simpletikzParser.path_start_tag_return path_start_tag() throws RecognitionException {
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set39=null;

        Object set39_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "path_start_tag");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(130, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:2: ( DRAW | FILL | PATH )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(131,2);
            set39=(Token)input.LT(1);
            if ( (input.LA(1)>=DRAW && input.LA(1)<=FILL) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set39));
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
        dbg.location(132, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "path_start_tag");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "path_start_tag"

    public static class tikzdocument_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzdocument"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:1: tikzdocument : ( SOMETHING )* tikzpicture ( SOMETHING )* -> ^( IM_DOCUMENT tikzpicture ) ;
    public final simpletikzParser.tikzdocument_return tikzdocument() throws RecognitionException {
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token SOMETHING40=null;
        Token SOMETHING42=null;
        simpletikzParser.tikzpicture_return tikzpicture41 = null;


        Object SOMETHING40_tree=null;
        Object SOMETHING42_tree=null;
        RewriteRuleTokenStream stream_SOMETHING=new RewriteRuleTokenStream(adaptor,"token SOMETHING");
        RewriteRuleSubtreeStream stream_tikzpicture=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        try { dbg.enterRule(getGrammarFileName(), "tikzdocument");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(134, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:2: ( ( SOMETHING )* tikzpicture ( SOMETHING )* -> ^( IM_DOCUMENT tikzpicture ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:4: ( SOMETHING )* tikzpicture ( SOMETHING )*
            {
            dbg.location(135,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:4: ( SOMETHING )*
            try { dbg.enterSubRule(12);

            loop12:
            do {
                int alt12=2;
                try { dbg.enterDecision(12);

                int LA12_0 = input.LA(1);

                if ( (LA12_0==SOMETHING) ) {
                    alt12=1;
                }


                } finally {dbg.exitDecision(12);}

                switch (alt12) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:4: SOMETHING
            	    {
            	    dbg.location(135,4);
            	    SOMETHING40=(Token)match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzdocument877);  
            	    stream_SOMETHING.add(SOMETHING40);


            	    }
            	    break;

            	default :
            	    break loop12;
                }
            } while (true);
            } finally {dbg.exitSubRule(12);}

            dbg.location(135,15);
            pushFollow(FOLLOW_tikzpicture_in_tikzdocument880);
            tikzpicture41=tikzpicture();

            state._fsp--;

            stream_tikzpicture.add(tikzpicture41.getTree());
            dbg.location(135,28);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:28: ( SOMETHING )*
            try { dbg.enterSubRule(13);

            loop13:
            do {
                int alt13=2;
                try { dbg.enterDecision(13);

                int LA13_0 = input.LA(1);

                if ( (LA13_0==SOMETHING) ) {
                    alt13=1;
                }


                } finally {dbg.exitDecision(13);}

                switch (alt13) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:28: SOMETHING
            	    {
            	    dbg.location(135,28);
            	    SOMETHING42=(Token)match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzdocument883);  
            	    stream_SOMETHING.add(SOMETHING42);


            	    }
            	    break;

            	default :
            	    break loop13;
                }
            } while (true);
            } finally {dbg.exitSubRule(13);}



            // AST REWRITE
            // elements: tikzpicture
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 135:40: -> ^( IM_DOCUMENT tikzpicture )
            {
                dbg.location(135,43);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:43: ^( IM_DOCUMENT tikzpicture )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(135,45);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

                dbg.location(135,57);
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
        dbg.location(136, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzdocument");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzdocument"

    public static class tikzpicture_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpicture"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:1: tikzpicture : tikzpicture_start ( OPTIONS )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikzbody )? tikzpicture_end ) ;
    public final simpletikzParser.tikzpicture_return tikzpicture() throws RecognitionException {
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token OPTIONS44=null;
        simpletikzParser.tikzpicture_start_return tikzpicture_start43 = null;

        simpletikzParser.tikzbody_return tikzbody45 = null;

        simpletikzParser.tikzpicture_end_return tikzpicture_end46 = null;


        Object OPTIONS44_tree=null;
        RewriteRuleTokenStream stream_OPTIONS=new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_tikzpicture_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        try { dbg.enterRule(getGrammarFileName(), "tikzpicture");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(138, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:2: ( tikzpicture_start ( OPTIONS )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikzbody )? tikzpicture_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:5: tikzpicture_start ( OPTIONS )? ( tikzbody )? tikzpicture_end
            {
            dbg.location(139,5);
            pushFollow(FOLLOW_tikzpicture_start_in_tikzpicture906);
            tikzpicture_start43=tikzpicture_start();

            state._fsp--;

            stream_tikzpicture_start.add(tikzpicture_start43.getTree());
            dbg.location(139,23);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:23: ( OPTIONS )?
            int alt14=2;
            try { dbg.enterSubRule(14);
            try { dbg.enterDecision(14);

            int LA14_0 = input.LA(1);

            if ( (LA14_0==OPTIONS) ) {
                alt14=1;
            }
            } finally {dbg.exitDecision(14);}

            switch (alt14) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:23: OPTIONS
                    {
                    dbg.location(139,23);
                    OPTIONS44=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpicture908);  
                    stream_OPTIONS.add(OPTIONS44);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(14);}

            dbg.location(139,32);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:32: ( tikzbody )?
            int alt15=2;
            try { dbg.enterSubRule(15);
            try { dbg.enterDecision(15);

            int LA15_0 = input.LA(1);

            if ( (LA15_0==BEGINSCOPE||(LA15_0>=NODE && LA15_0<=FILL)) ) {
                alt15=1;
            }
            } finally {dbg.exitDecision(15);}

            switch (alt15) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:32: tikzbody
                    {
                    dbg.location(139,32);
                    pushFollow(FOLLOW_tikzbody_in_tikzpicture911);
                    tikzbody45=tikzbody();

                    state._fsp--;

                    stream_tikzbody.add(tikzbody45.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(15);}

            dbg.location(139,42);
            pushFollow(FOLLOW_tikzpicture_end_in_tikzpicture914);
            tikzpicture_end46=tikzpicture_end();

            state._fsp--;

            stream_tikzpicture_end.add(tikzpicture_end46.getTree());


            // AST REWRITE
            // elements: tikzpicture_start, tikzbody, tikzpicture_end
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 139:59: -> ^( IM_PICTURE tikzpicture_start ( tikzbody )? tikzpicture_end )
            {
                dbg.location(139,62);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:62: ^( IM_PICTURE tikzpicture_start ( tikzbody )? tikzpicture_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(139,64);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PICTURE, "IM_PICTURE"), root_1);

                dbg.location(139,76);
                adaptor.addChild(root_1, stream_tikzpicture_start.nextTree());
                dbg.location(139,94);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:94: ( tikzbody )?
                if ( stream_tikzbody.hasNext() ) {
                    dbg.location(139,94);
                    adaptor.addChild(root_1, stream_tikzbody.nextTree());

                }
                stream_tikzbody.reset();
                dbg.location(139,104);
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
        dbg.location(140, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:1: tikzpicture_start : BEGINTP -> ^( IM_STARTTAG BEGINTP ) ;
    public final simpletikzParser.tikzpicture_start_return tikzpicture_start() throws RecognitionException {
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGINTP47=null;

        Object BEGINTP47_tree=null;
        RewriteRuleTokenStream stream_BEGINTP=new RewriteRuleTokenStream(adaptor,"token BEGINTP");

        try { dbg.enterRule(getGrammarFileName(), "tikzpicture_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(141, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:2: ( BEGINTP -> ^( IM_STARTTAG BEGINTP ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:4: BEGINTP
            {
            dbg.location(142,4);
            BEGINTP47=(Token)match(input,BEGINTP,FOLLOW_BEGINTP_in_tikzpicture_start939);  
            stream_BEGINTP.add(BEGINTP47);



            // AST REWRITE
            // elements: BEGINTP
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 142:12: -> ^( IM_STARTTAG BEGINTP )
            {
                dbg.location(142,15);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:15: ^( IM_STARTTAG BEGINTP )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(142,17);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(142,29);
                adaptor.addChild(root_1, stream_BEGINTP.nextNode());

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
        dbg.location(143, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:1: tikzpicture_end : ENDTP -> ^( IM_ENDTAG ENDTP ) ;
    public final simpletikzParser.tikzpicture_end_return tikzpicture_end() throws RecognitionException {
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token ENDTP48=null;

        Object ENDTP48_tree=null;
        RewriteRuleTokenStream stream_ENDTP=new RewriteRuleTokenStream(adaptor,"token ENDTP");

        try { dbg.enterRule(getGrammarFileName(), "tikzpicture_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(144, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:145:2: ( ENDTP -> ^( IM_ENDTAG ENDTP ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:145:4: ENDTP
            {
            dbg.location(145,4);
            ENDTP48=(Token)match(input,ENDTP,FOLLOW_ENDTP_in_tikzpicture_end957);  
            stream_ENDTP.add(ENDTP48);



            // AST REWRITE
            // elements: ENDTP
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 145:10: -> ^( IM_ENDTAG ENDTP )
            {
                dbg.location(145,13);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:145:13: ^( IM_ENDTAG ENDTP )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(145,15);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(145,25);
                adaptor.addChild(root_1, stream_ENDTP.nextNode());

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
        dbg.location(146, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:1: tikzbody : ( tikzscope | tikzpath | tikznodee )+ ;
    public final simpletikzParser.tikzbody_return tikzbody() throws RecognitionException {
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope49 = null;

        simpletikzParser.tikzpath_return tikzpath50 = null;

        simpletikzParser.tikznodee_return tikznodee51 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzbody");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(147, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:2: ( ( tikzscope | tikzpath | tikznodee )+ )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:4: ( tikzscope | tikzpath | tikznodee )+
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(148,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:4: ( tikzscope | tikzpath | tikznodee )+
            int cnt16=0;
            try { dbg.enterSubRule(16);

            loop16:
            do {
                int alt16=4;
                try { dbg.enterDecision(16);

                switch ( input.LA(1) ) {
                case BEGINSCOPE:
                    {
                    alt16=1;
                    }
                    break;
                case DRAW:
                case PATH:
                case FILL:
                    {
                    alt16=2;
                    }
                    break;
                case NODE:
                    {
                    alt16=3;
                    }
                    break;

                }

                } finally {dbg.exitDecision(16);}

                switch (alt16) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:6: tikzscope
            	    {
            	    dbg.location(148,6);
            	    pushFollow(FOLLOW_tikzscope_in_tikzbody977);
            	    tikzscope49=tikzscope();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzscope49.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:18: tikzpath
            	    {
            	    dbg.location(148,18);
            	    pushFollow(FOLLOW_tikzpath_in_tikzbody981);
            	    tikzpath50=tikzpath();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzpath50.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:29: tikznodee
            	    {
            	    dbg.location(148,29);
            	    pushFollow(FOLLOW_tikznodee_in_tikzbody985);
            	    tikznodee51=tikznodee();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikznodee51.getTree());

            	    }
            	    break;

            	default :
            	    if ( cnt16 >= 1 ) break loop16;
                        EarlyExitException eee =
                            new EarlyExitException(16, input);
                        dbg.recognitionException(eee);

                        throw eee;
                }
                cnt16++;
            } while (true);
            } finally {dbg.exitSubRule(16);}


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
            dbg.exitRule(getGrammarFileName(), "tikzbody");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzbody"

    public static class tikzscope_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzscope"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:1: tikzscope : BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE -> ^( IM_SCOPE ^( IM_STARTTAG BEGINSCOPE ) tikzbody ^( IM_ENDTAG ENDSCOPE ) ) ;
    public final simpletikzParser.tikzscope_return tikzscope() throws RecognitionException {
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGINSCOPE52=null;
        Token OPTIONS53=null;
        Token ENDSCOPE55=null;
        simpletikzParser.tikzbody_return tikzbody54 = null;


        Object BEGINSCOPE52_tree=null;
        Object OPTIONS53_tree=null;
        Object ENDSCOPE55_tree=null;
        RewriteRuleTokenStream stream_ENDSCOPE=new RewriteRuleTokenStream(adaptor,"token ENDSCOPE");
        RewriteRuleTokenStream stream_BEGINSCOPE=new RewriteRuleTokenStream(adaptor,"token BEGINSCOPE");
        RewriteRuleTokenStream stream_OPTIONS=new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        try { dbg.enterRule(getGrammarFileName(), "tikzscope");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(151, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:2: ( BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE -> ^( IM_SCOPE ^( IM_STARTTAG BEGINSCOPE ) tikzbody ^( IM_ENDTAG ENDSCOPE ) ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:4: BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE
            {
            dbg.location(152,4);
            BEGINSCOPE52=(Token)match(input,BEGINSCOPE,FOLLOW_BEGINSCOPE_in_tikzscope998);  
            stream_BEGINSCOPE.add(BEGINSCOPE52);

            dbg.location(152,15);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:15: ( OPTIONS )?
            int alt17=2;
            try { dbg.enterSubRule(17);
            try { dbg.enterDecision(17);

            int LA17_0 = input.LA(1);

            if ( (LA17_0==OPTIONS) ) {
                alt17=1;
            }
            } finally {dbg.exitDecision(17);}

            switch (alt17) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:15: OPTIONS
                    {
                    dbg.location(152,15);
                    OPTIONS53=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzscope1000);  
                    stream_OPTIONS.add(OPTIONS53);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(17);}

            dbg.location(152,24);
            pushFollow(FOLLOW_tikzbody_in_tikzscope1003);
            tikzbody54=tikzbody();

            state._fsp--;

            stream_tikzbody.add(tikzbody54.getTree());
            dbg.location(152,33);
            ENDSCOPE55=(Token)match(input,ENDSCOPE,FOLLOW_ENDSCOPE_in_tikzscope1005);  
            stream_ENDSCOPE.add(ENDSCOPE55);



            // AST REWRITE
            // elements: ENDSCOPE, BEGINSCOPE, tikzbody
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 152:43: -> ^( IM_SCOPE ^( IM_STARTTAG BEGINSCOPE ) tikzbody ^( IM_ENDTAG ENDSCOPE ) )
            {
                dbg.location(152,46);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:46: ^( IM_SCOPE ^( IM_STARTTAG BEGINSCOPE ) tikzbody ^( IM_ENDTAG ENDSCOPE ) )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(152,48);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_SCOPE, "IM_SCOPE"), root_1);

                dbg.location(152,57);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:57: ^( IM_STARTTAG BEGINSCOPE )
                {
                Object root_2 = (Object)adaptor.nil();
                dbg.location(152,59);
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_2);

                dbg.location(152,71);
                adaptor.addChild(root_2, stream_BEGINSCOPE.nextNode());

                adaptor.addChild(root_1, root_2);
                }
                dbg.location(152,83);
                adaptor.addChild(root_1, stream_tikzbody.nextTree());
                dbg.location(152,92);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:92: ^( IM_ENDTAG ENDSCOPE )
                {
                Object root_2 = (Object)adaptor.nil();
                dbg.location(152,94);
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_2);

                dbg.location(152,104);
                adaptor.addChild(root_2, stream_ENDSCOPE.nextNode());

                adaptor.addChild(root_1, root_2);
                }

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
        dbg.location(153, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzscope");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzscope"

    // Delegated rules


 

    public static final BitSet FOLLOW_path_start_in_tikzpath417 = new BitSet(new long[]{0x8020000000004000L,0x00000000000000C0L});
    public static final BitSet FOLLOW_tikzpathi_in_tikzpath419 = new BitSet(new long[]{0x0000000000800000L});
    public static final BitSet FOLLOW_path_end_in_tikzpath421 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SEMIC_in_path_end444 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_OPTIONS_in_tikzpathi464 = new BitSet(new long[]{0x8020000000004000L,0x00000000000000C0L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi469 = new BitSet(new long[]{0x8020000000004002L,0x00000000000000FFL});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi472 = new BitSet(new long[]{0x8020000000004002L,0x00000000000000FFL});
    public static final BitSet FOLLOW_OPTIONS_in_tikzpathi477 = new BitSet(new long[]{0x8020000000004000L,0x00000000000000FFL});
    public static final BitSet FOLLOW_edgeop_in_tikzpathi482 = new BitSet(new long[]{0x8020000000004000L,0x00000000000000C0L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi485 = new BitSet(new long[]{0x8020000000004002L,0x00000000000000FFL});
    public static final BitSet FOLLOW_coord_in_coordornode500 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikznodei_in_coordornode504 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_63_in_tikznodei516 = new BitSet(new long[]{0x0060000004004000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodei519 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_node_start_in_tikznodee529 = new BitSet(new long[]{0x0060000004004000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodee531 = new BitSet(new long[]{0x8020000000804000L,0x00000000000000C0L});
    public static final BitSet FOLLOW_tikzpathi_in_tikznodee533 = new BitSet(new long[]{0x0000000000800000L});
    public static final BitSet FOLLOW_path_end_in_tikznodee536 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_node_start562 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_OPTIONS_in_tikznode580 = new BitSet(new long[]{0x0040000004004000L});
    public static final BitSet FOLLOW_nodename_in_tikznode583 = new BitSet(new long[]{0x0040000004000000L});
    public static final BitSet FOLLOW_AT_in_tikznode587 = new BitSet(new long[]{0x0000000000004000L,0x00000000000000C0L});
    public static final BitSet FOLLOW_coord_in_tikznode589 = new BitSet(new long[]{0x0040000000000000L});
    public static final BitSet FOLLOW_STRING_in_tikznode593 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_edgeop0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LPAR_in_nodename661 = new BitSet(new long[]{0x0080000000000000L});
    public static final BitSet FOLLOW_ID_in_nodename665 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_RPAR_in_nodename667 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_coord692 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_modifier_in_coord716 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_LPAR_in_coord721 = new BitSet(new long[]{0x0300000000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord723 = new BitSet(new long[]{0x0000000000100000L});
    public static final BitSet FOLLOW_KOMMA_in_coord725 = new BitSet(new long[]{0x0300000000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord727 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_RPAR_in_coord729 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_number_in_numberunit771 = new BitSet(new long[]{0x0000034000000002L,0x0000000000000300L});
    public static final BitSet FOLLOW_unit_in_numberunit773 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_number796 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_unit0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_tag_in_path_start840 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SOMETHING_in_tikzdocument877 = new BitSet(new long[]{0x0400000000000040L});
    public static final BitSet FOLLOW_tikzpicture_in_tikzdocument880 = new BitSet(new long[]{0x0400000000000002L});
    public static final BitSet FOLLOW_SOMETHING_in_tikzdocument883 = new BitSet(new long[]{0x0400000000000002L});
    public static final BitSet FOLLOW_tikzpicture_start_in_tikzpicture906 = new BitSet(new long[]{0x0020000000003D80L});
    public static final BitSet FOLLOW_OPTIONS_in_tikzpicture908 = new BitSet(new long[]{0x0020000000003D80L});
    public static final BitSet FOLLOW_tikzbody_in_tikzpicture911 = new BitSet(new long[]{0x0020000000003D80L});
    public static final BitSet FOLLOW_tikzpicture_end_in_tikzpicture914 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGINTP_in_tikzpicture_start939 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ENDTP_in_tikzpicture_end957 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody977 = new BitSet(new long[]{0x0000000000003D02L});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody981 = new BitSet(new long[]{0x0000000000003D02L});
    public static final BitSet FOLLOW_tikznodee_in_tikzbody985 = new BitSet(new long[]{0x0000000000003D02L});
    public static final BitSet FOLLOW_BEGINSCOPE_in_tikzscope998 = new BitSet(new long[]{0x0020000000003D00L});
    public static final BitSet FOLLOW_OPTIONS_in_tikzscope1000 = new BitSet(new long[]{0x0000000000003D00L});
    public static final BitSet FOLLOW_tikzbody_in_tikzscope1003 = new BitSet(new long[]{0x0000000000000200L});
    public static final BitSet FOLLOW_ENDSCOPE_in_tikzscope1005 = new BitSet(new long[]{0x0000000000000002L});

}