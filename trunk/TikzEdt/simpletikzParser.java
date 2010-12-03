// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-12-02 20:51:03

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;

import org.antlr.runtime.tree.*;

public class simpletikzParser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BEGIN", "END", "BEGINTP", "ENDTP", "BEGINSCOPE", "ENDSCOPE", "NODE", "DRAW", "PATH", "FILL", "LPAR", "RPAR", "LBR", "RBR", "LBRR", "RBRR", "KOMMA", "SCALE", "EQU", "SEMIC", "COLON", "STYLESEP", "AT", "LABEL", "EVERYLOOP", "LOOP", "IN", "OUT", "UN_PTS", "UN_CM", "IM_PATH", "IM_NODE", "IM_COORD", "IM_NODENAME", "IM_NUMBERUNIT", "IM_PICTURE", "IM_DOCUMENT", "IM_SCOPE", "IM_STARTTAG", "IM_ENDTAG", "IM_OPTIONS", "IM_OPTION_STYLE", "IM_OPTION_KV", "IM_ID", "STRING", "ID", "FLOAT", "INT", "SOMETHING", "EXPONENT", "COMMENT", "WS", "ESC_SEQ", "'node'", "'--'", "'edge'", "'->'", "'|-'", "'-|'", "'to'", "'+'", "'++'", "'ex'", "'mm'"
    };
    public static final int T__66=66;
    public static final int EXPONENT=53;
    public static final int T__67=67;
    public static final int T__64=64;
    public static final int IM_STARTTAG=42;
    public static final int T__65=65;
    public static final int T__62=62;
    public static final int T__63=63;
    public static final int IM_PATH=34;
    public static final int RBR=17;
    public static final int IM_ID=47;
    public static final int FLOAT=50;
    public static final int BEGINTP=6;
    public static final int SOMETHING=52;
    public static final int ID=49;
    public static final int T__61=61;
    public static final int EOF=-1;
    public static final int T__60=60;
    public static final int LBR=16;
    public static final int IM_ENDTAG=43;
    public static final int AT=26;
    public static final int T__57=57;
    public static final int IM_DOCUMENT=40;
    public static final int T__58=58;
    public static final int RBRR=19;
    public static final int ESC_SEQ=56;
    public static final int IN=30;
    public static final int LPAR=14;
    public static final int EVERYLOOP=28;
    public static final int ENDTP=7;
    public static final int FILL=13;
    public static final int PATH=12;
    public static final int T__59=59;
    public static final int BEGIN=4;
    public static final int LOOP=29;
    public static final int IM_OPTION_KV=46;
    public static final int COMMENT=54;
    public static final int IM_OPTIONS=44;
    public static final int IM_OPTION_STYLE=45;
    public static final int NODE=10;
    public static final int UN_PTS=32;
    public static final int STYLESEP=25;
    public static final int IM_COORD=36;
    public static final int IM_PICTURE=39;
    public static final int INT=51;
    public static final int BEGINSCOPE=8;
    public static final int LBRR=18;
    public static final int UN_CM=33;
    public static final int IM_NODE=35;
    public static final int COLON=24;
    public static final int ENDSCOPE=9;
    public static final int IM_SCOPE=41;
    public static final int IM_NUMBERUNIT=38;
    public static final int SCALE=21;
    public static final int WS=55;
    public static final int LABEL=27;
    public static final int OUT=31;
    public static final int KOMMA=20;
    public static final int EQU=22;
    public static final int RPAR=15;
    public static final int END=5;
    public static final int SEMIC=23;
    public static final int IM_NODENAME=37;
    public static final int STRING=48;
    public static final int DRAW=11;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "option", "tikzscope_start", "idd", "tikzpathi", 
        "tikzbody", "option_style", "tikznodee", "path_end", "tikzpicture_end", 
        "numberunit", "nodename", "node_start", "number", "tikznodei", "tikz_options", 
        "edgeop", "tikznode", "option_kv", "tikzdocument", "coordornode", 
        "tikzscope", "tikzpicture", "path_start", "coord", "unit", "tikzpath", 
        "coord_modifier", "path_start_tag", "tikzpicture_start", "tikzscope_end"
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:75:1: tikzpath : path_start tikzpathi path_end -> ^( IM_PATH path_start tikzpathi path_end ) ;
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
        dbg.location(75, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:2: ( path_start tikzpathi path_end -> ^( IM_PATH path_start tikzpathi path_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:4: path_start tikzpathi path_end
            {
            dbg.location(76,4);
            pushFollow(FOLLOW_path_start_in_tikzpath378);
            path_start1=path_start();

            state._fsp--;

            stream_path_start.add(path_start1.getTree());
            dbg.location(76,15);
            pushFollow(FOLLOW_tikzpathi_in_tikzpath380);
            tikzpathi2=tikzpathi();

            state._fsp--;

            stream_tikzpathi.add(tikzpathi2.getTree());
            dbg.location(76,25);
            pushFollow(FOLLOW_path_end_in_tikzpath382);
            path_end3=path_end();

            state._fsp--;

            stream_path_end.add(path_end3.getTree());


            // AST REWRITE
            // elements: path_end, tikzpathi, path_start
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 76:34: -> ^( IM_PATH path_start tikzpathi path_end )
            {
                dbg.location(76,37);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:37: ^( IM_PATH path_start tikzpathi path_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(76,39);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(76,47);
                adaptor.addChild(root_1, stream_path_start.nextTree());
                dbg.location(76,58);
                adaptor.addChild(root_1, stream_tikzpathi.nextTree());
                dbg.location(76,68);
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
        dbg.location(77, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:78:1: path_end : SEMIC -> ^( IM_ENDTAG SEMIC ) ;
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
        dbg.location(78, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:2: ( SEMIC -> ^( IM_ENDTAG SEMIC ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:4: SEMIC
            {
            dbg.location(79,4);
            SEMIC4=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_path_end405);  
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
            // 79:10: -> ^( IM_ENDTAG SEMIC )
            {
                dbg.location(79,13);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:13: ^( IM_ENDTAG SEMIC )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(79,15);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(79,25);
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
        dbg.location(80, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:82:1: tikzpathi : coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* ;
    public final simpletikzParser.tikzpathi_return tikzpathi() throws RecognitionException {
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coordornode_return coordornode5 = null;

        simpletikzParser.coordornode_return coordornode6 = null;

        simpletikzParser.tikz_options_return tikz_options7 = null;

        simpletikzParser.edgeop_return edgeop8 = null;

        simpletikzParser.coordornode_return coordornode9 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzpathi");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(82, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:2: ( coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:5: coordornode ( coordornode | ( tikz_options )? edgeop coordornode )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(83,5);
            pushFollow(FOLLOW_coordornode_in_tikzpathi425);
            coordornode5=coordornode();

            state._fsp--;

            adaptor.addChild(root_0, coordornode5.getTree());
            dbg.location(83,17);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:17: ( coordornode | ( tikz_options )? edgeop coordornode )*
            try { dbg.enterSubRule(2);

            loop2:
            do {
                int alt2=3;
                try { dbg.enterDecision(2);

                int LA2_0 = input.LA(1);

                if ( (LA2_0==LPAR||LA2_0==57||(LA2_0>=64 && LA2_0<=65)) ) {
                    alt2=1;
                }
                else if ( (LA2_0==LBR||(LA2_0>=58 && LA2_0<=63)) ) {
                    alt2=2;
                }


                } finally {dbg.exitDecision(2);}

                switch (alt2) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:18: coordornode
            	    {
            	    dbg.location(83,18);
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi428);
            	    coordornode6=coordornode();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode6.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:32: ( tikz_options )? edgeop coordornode
            	    {
            	    dbg.location(83,32);
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:32: ( tikz_options )?
            	    int alt1=2;
            	    try { dbg.enterSubRule(1);
            	    try { dbg.enterDecision(1);

            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0==LBR) ) {
            	        alt1=1;
            	    }
            	    } finally {dbg.exitDecision(1);}

            	    switch (alt1) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:32: tikz_options
            	            {
            	            dbg.location(83,32);
            	            pushFollow(FOLLOW_tikz_options_in_tikzpathi432);
            	            tikz_options7=tikz_options();

            	            state._fsp--;

            	            adaptor.addChild(root_0, tikz_options7.getTree());

            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(1);}

            	    dbg.location(83,52);
            	    pushFollow(FOLLOW_edgeop_in_tikzpathi435);
            	    edgeop8=edgeop();

            	    state._fsp--;

            	    dbg.location(83,54);
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi438);
            	    coordornode9=coordornode();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode9.getTree());

            	    }
            	    break;

            	default :
            	    break loop2;
                }
            } while (true);
            } finally {dbg.exitSubRule(2);}


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
        dbg.location(84, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:1: coordornode : ( coord | tikznodei );
    public final simpletikzParser.coordornode_return coordornode() throws RecognitionException {
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coord_return coord10 = null;

        simpletikzParser.tikznodei_return tikznodei11 = null;



        try { dbg.enterRule(getGrammarFileName(), "coordornode");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(86, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:2: ( coord | tikznodei )
            int alt3=2;
            try { dbg.enterDecision(3);

            int LA3_0 = input.LA(1);

            if ( (LA3_0==LPAR||(LA3_0>=64 && LA3_0<=65)) ) {
                alt3=1;
            }
            else if ( (LA3_0==57) ) {
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:4: coord
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(87,4);
                    pushFollow(FOLLOW_coord_in_coordornode453);
                    coord10=coord();

                    state._fsp--;

                    adaptor.addChild(root_0, coord10.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:12: tikznodei
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(87,12);
                    pushFollow(FOLLOW_tikznodei_in_coordornode457);
                    tikznodei11=tikznodei();

                    state._fsp--;

                    adaptor.addChild(root_0, tikznodei11.getTree());

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
        dbg.location(88, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:1: tikznodei : 'node' tikznode ;
    public final simpletikzParser.tikznodei_return tikznodei() throws RecognitionException {
        simpletikzParser.tikznodei_return retval = new simpletikzParser.tikznodei_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal12=null;
        simpletikzParser.tikznode_return tikznode13 = null;


        Object string_literal12_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "tikznodei");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(90, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:2: ( 'node' tikznode )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:4: 'node' tikznode
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(91,10);
            string_literal12=(Token)match(input,57,FOLLOW_57_in_tikznodei469); 
            dbg.location(91,12);
            pushFollow(FOLLOW_tikznode_in_tikznodei472);
            tikznode13=tikznode();

            state._fsp--;

            adaptor.addChild(root_0, tikznode13.getTree());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:1: tikznodee : node_start tikznode ( tikzpathi )? path_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end ) ;
    public final simpletikzParser.tikznodee_return tikznodee() throws RecognitionException {
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.node_start_return node_start14 = null;

        simpletikzParser.tikznode_return tikznode15 = null;

        simpletikzParser.tikzpathi_return tikzpathi16 = null;

        simpletikzParser.path_end_return path_end17 = null;


        RewriteRuleSubtreeStream stream_node_start=new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_path_end=new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_tikznode=new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try { dbg.enterRule(getGrammarFileName(), "tikznodee");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(93, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:2: ( node_start tikznode ( tikzpathi )? path_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:4: node_start tikznode ( tikzpathi )? path_end
            {
            dbg.location(94,4);
            pushFollow(FOLLOW_node_start_in_tikznodee482);
            node_start14=node_start();

            state._fsp--;

            stream_node_start.add(node_start14.getTree());
            dbg.location(94,15);
            pushFollow(FOLLOW_tikznode_in_tikznodee484);
            tikznode15=tikznode();

            state._fsp--;

            stream_tikznode.add(tikznode15.getTree());
            dbg.location(94,24);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:24: ( tikzpathi )?
            int alt4=2;
            try { dbg.enterSubRule(4);
            try { dbg.enterDecision(4);

            int LA4_0 = input.LA(1);

            if ( (LA4_0==LPAR||LA4_0==57||(LA4_0>=64 && LA4_0<=65)) ) {
                alt4=1;
            }
            } finally {dbg.exitDecision(4);}

            switch (alt4) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:24: tikzpathi
                    {
                    dbg.location(94,24);
                    pushFollow(FOLLOW_tikzpathi_in_tikznodee486);
                    tikzpathi16=tikzpathi();

                    state._fsp--;

                    stream_tikzpathi.add(tikzpathi16.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(4);}

            dbg.location(94,35);
            pushFollow(FOLLOW_path_end_in_tikznodee489);
            path_end17=path_end();

            state._fsp--;

            stream_path_end.add(path_end17.getTree());


            // AST REWRITE
            // elements: node_start, tikzpathi, path_end, tikznode
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 94:44: -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end )
            {
                dbg.location(94,47);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:47: ^( IM_PATH node_start tikznode ( tikzpathi )? path_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(94,49);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(94,57);
                adaptor.addChild(root_1, stream_node_start.nextTree());
                dbg.location(94,68);
                adaptor.addChild(root_1, stream_tikznode.nextTree());
                dbg.location(94,77);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:77: ( tikzpathi )?
                if ( stream_tikzpathi.hasNext() ) {
                    dbg.location(94,77);
                    adaptor.addChild(root_1, stream_tikzpathi.nextTree());

                }
                stream_tikzpathi.reset();
                dbg.location(94,88);
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
        dbg.location(95, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public final simpletikzParser.node_start_return node_start() throws RecognitionException {
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token NODE18=null;

        Object NODE18_tree=null;
        RewriteRuleTokenStream stream_NODE=new RewriteRuleTokenStream(adaptor,"token NODE");

        try { dbg.enterRule(getGrammarFileName(), "node_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(96, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:4: NODE
            {
            dbg.location(97,4);
            NODE18=(Token)match(input,NODE,FOLLOW_NODE_in_node_start515);  
            stream_NODE.add(NODE18);



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
            // 97:9: -> ^( IM_STARTTAG NODE )
            {
                dbg.location(97,12);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:12: ^( IM_STARTTAG NODE )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(97,14);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(97,26);
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
        dbg.location(98, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:99:1: tikznode : ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( nodename )? ( coord )? STRING ) ;
    public final simpletikzParser.tikznode_return tikznode() throws RecognitionException {
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal20=null;
        Token STRING22=null;
        simpletikzParser.nodename_return nodename19 = null;

        simpletikzParser.coord_return coord21 = null;


        Object string_literal20_tree=null;
        Object STRING22_tree=null;
        RewriteRuleTokenStream stream_AT=new RewriteRuleTokenStream(adaptor,"token AT");
        RewriteRuleTokenStream stream_STRING=new RewriteRuleTokenStream(adaptor,"token STRING");
        RewriteRuleSubtreeStream stream_coord=new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try { dbg.enterRule(getGrammarFileName(), "tikznode");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(99, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:2: ( ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( nodename )? ( coord )? STRING ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:4: ( nodename )? ( 'at' coord )? STRING
            {
            dbg.location(100,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:4: ( nodename )?
            int alt5=2;
            try { dbg.enterSubRule(5);
            try { dbg.enterDecision(5);

            int LA5_0 = input.LA(1);

            if ( (LA5_0==LPAR) ) {
                alt5=1;
            }
            } finally {dbg.exitDecision(5);}

            switch (alt5) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:4: nodename
                    {
                    dbg.location(100,4);
                    pushFollow(FOLLOW_nodename_in_tikznode533);
                    nodename19=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename19.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(5);}

            dbg.location(100,14);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:14: ( 'at' coord )?
            int alt6=2;
            try { dbg.enterSubRule(6);
            try { dbg.enterDecision(6);

            int LA6_0 = input.LA(1);

            if ( (LA6_0==AT) ) {
                alt6=1;
            }
            } finally {dbg.exitDecision(6);}

            switch (alt6) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:15: 'at' coord
                    {
                    dbg.location(100,15);
                    string_literal20=(Token)match(input,AT,FOLLOW_AT_in_tikznode537);  
                    stream_AT.add(string_literal20);

                    dbg.location(100,20);
                    pushFollow(FOLLOW_coord_in_tikznode539);
                    coord21=coord();

                    state._fsp--;

                    stream_coord.add(coord21.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(6);}

            dbg.location(100,28);
            STRING22=(Token)match(input,STRING,FOLLOW_STRING_in_tikznode543);  
            stream_STRING.add(STRING22);



            // AST REWRITE
            // elements: nodename, coord, STRING
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 100:36: -> ^( IM_NODE ( nodename )? ( coord )? STRING )
            {
                dbg.location(100,39);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:39: ^( IM_NODE ( nodename )? ( coord )? STRING )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(100,41);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODE, "IM_NODE"), root_1);

                dbg.location(100,49);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:49: ( nodename )?
                if ( stream_nodename.hasNext() ) {
                    dbg.location(100,49);
                    adaptor.addChild(root_1, stream_nodename.nextTree());

                }
                stream_nodename.reset();
                dbg.location(100,59);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:59: ( coord )?
                if ( stream_coord.hasNext() ) {
                    dbg.location(100,59);
                    adaptor.addChild(root_1, stream_coord.nextTree());

                }
                stream_coord.reset();
                dbg.location(100,66);
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
        dbg.location(101, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:1: edgeop : ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' );
    public final simpletikzParser.edgeop_return edgeop() throws RecognitionException {
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set23=null;

        Object set23_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "edgeop");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(103, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:2: ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(104,2);
            set23=(Token)input.LT(1);
            if ( (input.LA(1)>=58 && input.LA(1)<=63) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set23));
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
        dbg.location(105, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:1: nodename : lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) ;
    public final simpletikzParser.nodename_return nodename() throws RecognitionException {
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token id=null;
        Token RPAR24=null;

        Object lc_tree=null;
        Object id_tree=null;
        Object RPAR24_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try { dbg.enterRule(getGrammarFileName(), "nodename");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(107, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:2: (lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:4: lc= LPAR id= ID RPAR
            {
            dbg.location(108,6);
            lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_nodename608);  
            stream_LPAR.add(lc);

            dbg.location(108,14);
            id=(Token)match(input,ID,FOLLOW_ID_in_nodename612);  
            stream_ID.add(id);

            dbg.location(108,18);
            RPAR24=(Token)match(input,RPAR,FOLLOW_RPAR_in_nodename614);  
            stream_RPAR.add(RPAR24);



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
            // 108:24: -> ^( IM_NODENAME[$lc] $id)
            {
                dbg.location(108,27);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:27: ^( IM_NODENAME[$lc] $id)
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(108,29);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODENAME, lc), root_1);

                dbg.location(108,46);
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
        dbg.location(109, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) );
    public final simpletikzParser.coord_return coord() throws RecognitionException {
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token KOMMA28=null;
        Token RPAR30=null;
        simpletikzParser.nodename_return nodename25 = null;

        simpletikzParser.coord_modifier_return coord_modifier26 = null;

        simpletikzParser.numberunit_return numberunit27 = null;

        simpletikzParser.numberunit_return numberunit29 = null;


        Object lc_tree=null;
        Object KOMMA28_tree=null;
        Object RPAR30_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_numberunit=new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier=new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try { dbg.enterRule(getGrammarFileName(), "coord");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(111, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) )
            int alt8=2;
            try { dbg.enterDecision(8);

            int LA8_0 = input.LA(1);

            if ( (LA8_0==LPAR) ) {
                int LA8_1 = input.LA(2);

                if ( (LA8_1==ID) ) {
                    alt8=1;
                }
                else if ( ((LA8_1>=FLOAT && LA8_1<=INT)) ) {
                    alt8=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 8, 1, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
            }
            else if ( ((LA8_0>=64 && LA8_0<=65)) ) {
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:6: nodename
                    {
                    dbg.location(112,6);
                    pushFollow(FOLLOW_nodename_in_coord639);
                    nodename25=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename25.getTree());


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
                    // 112:23: -> ^( IM_COORD nodename )
                    {
                        dbg.location(112,26);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:26: ^( IM_COORD nodename )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(112,28);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, "IM_COORD"), root_1);

                        dbg.location(112,37);
                        adaptor.addChild(root_1, stream_nodename.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    {
                    dbg.location(113,5);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:7: ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR
                    {
                    dbg.location(113,7);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:7: ( coord_modifier )?
                    int alt7=2;
                    try { dbg.enterSubRule(7);
                    try { dbg.enterDecision(7);

                    int LA7_0 = input.LA(1);

                    if ( ((LA7_0>=64 && LA7_0<=65)) ) {
                        alt7=1;
                    }
                    } finally {dbg.exitDecision(7);}

                    switch (alt7) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:7: coord_modifier
                            {
                            dbg.location(113,7);
                            pushFollow(FOLLOW_coord_modifier_in_coord663);
                            coord_modifier26=coord_modifier();

                            state._fsp--;

                            stream_coord_modifier.add(coord_modifier26.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(7);}

                    dbg.location(113,25);
                    lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_coord668);  
                    stream_LPAR.add(lc);

                    dbg.location(113,31);
                    pushFollow(FOLLOW_numberunit_in_coord670);
                    numberunit27=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit27.getTree());
                    dbg.location(113,42);
                    KOMMA28=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_coord672);  
                    stream_KOMMA.add(KOMMA28);

                    dbg.location(113,48);
                    pushFollow(FOLLOW_numberunit_in_coord674);
                    numberunit29=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit29.getTree());
                    dbg.location(113,59);
                    RPAR30=(Token)match(input,RPAR,FOLLOW_RPAR_in_coord676);  
                    stream_RPAR.add(RPAR30);


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
                    // 113:66: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    {
                        dbg.location(113,69);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:69: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(113,71);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, lc), root_1);

                        dbg.location(113,85);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:85: ( coord_modifier )?
                        if ( stream_coord_modifier.hasNext() ) {
                            dbg.location(113,85);
                            adaptor.addChild(root_1, stream_coord_modifier.nextTree());

                        }
                        stream_coord_modifier.reset();
                        dbg.location(113,101);
                        if ( !(stream_numberunit.hasNext()) ) {
                            throw new RewriteEarlyExitException();
                        }
                        while ( stream_numberunit.hasNext() ) {
                            dbg.location(113,101);
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
        dbg.location(114, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:1: coord_modifier : ( '+' | '++' );
    public final simpletikzParser.coord_modifier_return coord_modifier() throws RecognitionException {
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set31=null;

        Object set31_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "coord_modifier");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(116, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:2: ( '+' | '++' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(117,2);
            set31=(Token)input.LT(1);
            if ( (input.LA(1)>=64 && input.LA(1)<=65) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set31));
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
        dbg.location(118, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public final simpletikzParser.numberunit_return numberunit() throws RecognitionException {
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.number_return number32 = null;

        simpletikzParser.unit_return unit33 = null;


        RewriteRuleSubtreeStream stream_unit=new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
        try { dbg.enterRule(getGrammarFileName(), "numberunit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(120, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:4: number ( unit )?
            {
            dbg.location(121,4);
            pushFollow(FOLLOW_number_in_numberunit718);
            number32=number();

            state._fsp--;

            stream_number.add(number32.getTree());
            dbg.location(121,11);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:11: ( unit )?
            int alt9=2;
            try { dbg.enterSubRule(9);
            try { dbg.enterDecision(9);

            int LA9_0 = input.LA(1);

            if ( (LA9_0==IN||(LA9_0>=UN_PTS && LA9_0<=UN_CM)||(LA9_0>=66 && LA9_0<=67)) ) {
                alt9=1;
            }
            } finally {dbg.exitDecision(9);}

            switch (alt9) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:11: unit
                    {
                    dbg.location(121,11);
                    pushFollow(FOLLOW_unit_in_numberunit720);
                    unit33=unit();

                    state._fsp--;

                    stream_unit.add(unit33.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(9);}



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
            // 121:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            {
                dbg.location(121,20);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:20: ^( IM_NUMBERUNIT number ( unit )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(121,22);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

                dbg.location(121,36);
                adaptor.addChild(root_1, stream_number.nextTree());
                dbg.location(121,43);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:43: ( unit )?
                if ( stream_unit.hasNext() ) {
                    dbg.location(121,43);
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
        dbg.location(122, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:123:1: number : ( FLOAT | INT ) ;
    public final simpletikzParser.number_return number() throws RecognitionException {
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set34=null;

        Object set34_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "number");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(123, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:2: ( ( FLOAT | INT ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:4: ( FLOAT | INT )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(124,4);
            set34=(Token)input.LT(1);
            if ( (input.LA(1)>=FLOAT && input.LA(1)<=INT) ) {
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
        dbg.location(125, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' );
    public final simpletikzParser.unit_return unit() throws RecognitionException {
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set35=null;

        Object set35_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(126, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:127:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(127,2);
            set35=(Token)input.LT(1);
            if ( input.LA(1)==IN||(input.LA(1)>=UN_PTS && input.LA(1)<=UN_CM)||(input.LA(1)>=66 && input.LA(1)<=67) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set35));
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
        dbg.location(128, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public final simpletikzParser.path_start_return path_start() throws RecognitionException {
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag36 = null;


        RewriteRuleSubtreeStream stream_path_start_tag=new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try { dbg.enterRule(getGrammarFileName(), "path_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(130, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:4: path_start_tag
            {
            dbg.location(131,4);
            pushFollow(FOLLOW_path_start_tag_in_path_start787);
            path_start_tag36=path_start_tag();

            state._fsp--;

            stream_path_start_tag.add(path_start_tag36.getTree());


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
            // 131:19: -> ^( IM_STARTTAG path_start_tag )
            {
                dbg.location(131,22);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:22: ^( IM_STARTTAG path_start_tag )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(131,24);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(131,36);
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
        dbg.location(132, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:1: path_start_tag : ( DRAW | FILL | PATH );
    public final simpletikzParser.path_start_tag_return path_start_tag() throws RecognitionException {
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set37=null;

        Object set37_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "path_start_tag");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(133, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:2: ( DRAW | FILL | PATH )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(134,2);
            set37=(Token)input.LT(1);
            if ( (input.LA(1)>=DRAW && input.LA(1)<=FILL) ) {
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
        dbg.location(135, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:1: tikzdocument : ( SOMETHING )* tikzpicture ( SOMETHING )* -> ^( IM_DOCUMENT tikzpicture ) ;
    public final simpletikzParser.tikzdocument_return tikzdocument() throws RecognitionException {
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token SOMETHING38=null;
        Token SOMETHING40=null;
        simpletikzParser.tikzpicture_return tikzpicture39 = null;


        Object SOMETHING38_tree=null;
        Object SOMETHING40_tree=null;
        RewriteRuleTokenStream stream_SOMETHING=new RewriteRuleTokenStream(adaptor,"token SOMETHING");
        RewriteRuleSubtreeStream stream_tikzpicture=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        try { dbg.enterRule(getGrammarFileName(), "tikzdocument");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(137, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:2: ( ( SOMETHING )* tikzpicture ( SOMETHING )* -> ^( IM_DOCUMENT tikzpicture ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:4: ( SOMETHING )* tikzpicture ( SOMETHING )*
            {
            dbg.location(138,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:4: ( SOMETHING )*
            try { dbg.enterSubRule(10);

            loop10:
            do {
                int alt10=2;
                try { dbg.enterDecision(10);

                int LA10_0 = input.LA(1);

                if ( (LA10_0==SOMETHING) ) {
                    alt10=1;
                }


                } finally {dbg.exitDecision(10);}

                switch (alt10) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:4: SOMETHING
            	    {
            	    dbg.location(138,4);
            	    SOMETHING38=(Token)match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzdocument824);  
            	    stream_SOMETHING.add(SOMETHING38);


            	    }
            	    break;

            	default :
            	    break loop10;
                }
            } while (true);
            } finally {dbg.exitSubRule(10);}

            dbg.location(138,15);
            pushFollow(FOLLOW_tikzpicture_in_tikzdocument827);
            tikzpicture39=tikzpicture();

            state._fsp--;

            stream_tikzpicture.add(tikzpicture39.getTree());
            dbg.location(138,28);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:28: ( SOMETHING )*
            try { dbg.enterSubRule(11);

            loop11:
            do {
                int alt11=2;
                try { dbg.enterDecision(11);

                int LA11_0 = input.LA(1);

                if ( (LA11_0==SOMETHING) ) {
                    alt11=1;
                }


                } finally {dbg.exitDecision(11);}

                switch (alt11) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:28: SOMETHING
            	    {
            	    dbg.location(138,28);
            	    SOMETHING40=(Token)match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzdocument830);  
            	    stream_SOMETHING.add(SOMETHING40);


            	    }
            	    break;

            	default :
            	    break loop11;
                }
            } while (true);
            } finally {dbg.exitSubRule(11);}



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
            // 138:40: -> ^( IM_DOCUMENT tikzpicture )
            {
                dbg.location(138,43);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:43: ^( IM_DOCUMENT tikzpicture )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(138,45);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

                dbg.location(138,57);
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
        dbg.location(139, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public final simpletikzParser.tikzpicture_return tikzpicture() throws RecognitionException {
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start41 = null;

        simpletikzParser.tikz_options_return tikz_options42 = null;

        simpletikzParser.tikzbody_return tikzbody43 = null;

        simpletikzParser.tikzpicture_end_return tikzpicture_end44 = null;


        RewriteRuleSubtreeStream stream_tikzpicture_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikzpicture");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(141, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            dbg.location(142,5);
            pushFollow(FOLLOW_tikzpicture_start_in_tikzpicture853);
            tikzpicture_start41=tikzpicture_start();

            state._fsp--;

            stream_tikzpicture_start.add(tikzpicture_start41.getTree());
            dbg.location(142,23);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:23: ( tikz_options )?
            int alt12=2;
            try { dbg.enterSubRule(12);
            try { dbg.enterDecision(12);

            int LA12_0 = input.LA(1);

            if ( (LA12_0==LBR) ) {
                alt12=1;
            }
            } finally {dbg.exitDecision(12);}

            switch (alt12) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:23: tikz_options
                    {
                    dbg.location(142,23);
                    pushFollow(FOLLOW_tikz_options_in_tikzpicture855);
                    tikz_options42=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options42.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(12);}

            dbg.location(142,37);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:37: ( tikzbody )?
            int alt13=2;
            try { dbg.enterSubRule(13);
            try { dbg.enterDecision(13);

            int LA13_0 = input.LA(1);

            if ( (LA13_0==BEGINSCOPE||(LA13_0>=NODE && LA13_0<=FILL)) ) {
                alt13=1;
            }
            } finally {dbg.exitDecision(13);}

            switch (alt13) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:37: tikzbody
                    {
                    dbg.location(142,37);
                    pushFollow(FOLLOW_tikzbody_in_tikzpicture858);
                    tikzbody43=tikzbody();

                    state._fsp--;

                    stream_tikzbody.add(tikzbody43.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(13);}

            dbg.location(142,47);
            pushFollow(FOLLOW_tikzpicture_end_in_tikzpicture861);
            tikzpicture_end44=tikzpicture_end();

            state._fsp--;

            stream_tikzpicture_end.add(tikzpicture_end44.getTree());


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
            // 142:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            {
                dbg.location(142,67);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(142,69);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PICTURE, "IM_PICTURE"), root_1);

                dbg.location(142,80);
                adaptor.addChild(root_1, stream_tikzpicture_start.nextTree());
                dbg.location(142,98);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:98: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(142,98);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                dbg.location(142,112);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:112: ( tikzbody )?
                if ( stream_tikzbody.hasNext() ) {
                    dbg.location(142,112);
                    adaptor.addChild(root_1, stream_tikzbody.nextTree());

                }
                stream_tikzbody.reset();
                dbg.location(142,122);
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
        dbg.location(143, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:1: tikzpicture_start : BEGINTP -> ^( IM_STARTTAG BEGINTP ) ;
    public final simpletikzParser.tikzpicture_start_return tikzpicture_start() throws RecognitionException {
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGINTP45=null;

        Object BEGINTP45_tree=null;
        RewriteRuleTokenStream stream_BEGINTP=new RewriteRuleTokenStream(adaptor,"token BEGINTP");

        try { dbg.enterRule(getGrammarFileName(), "tikzpicture_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(144, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:145:2: ( BEGINTP -> ^( IM_STARTTAG BEGINTP ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:145:4: BEGINTP
            {
            dbg.location(145,4);
            BEGINTP45=(Token)match(input,BEGINTP,FOLLOW_BEGINTP_in_tikzpicture_start888);  
            stream_BEGINTP.add(BEGINTP45);



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
            // 145:12: -> ^( IM_STARTTAG BEGINTP )
            {
                dbg.location(145,15);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:145:15: ^( IM_STARTTAG BEGINTP )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(145,17);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(145,29);
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
        dbg.location(146, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:1: tikzpicture_end : ENDTP -> ^( IM_ENDTAG ENDTP ) ;
    public final simpletikzParser.tikzpicture_end_return tikzpicture_end() throws RecognitionException {
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token ENDTP46=null;

        Object ENDTP46_tree=null;
        RewriteRuleTokenStream stream_ENDTP=new RewriteRuleTokenStream(adaptor,"token ENDTP");

        try { dbg.enterRule(getGrammarFileName(), "tikzpicture_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(147, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:2: ( ENDTP -> ^( IM_ENDTAG ENDTP ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:4: ENDTP
            {
            dbg.location(148,4);
            ENDTP46=(Token)match(input,ENDTP,FOLLOW_ENDTP_in_tikzpicture_end906);  
            stream_ENDTP.add(ENDTP46);



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
            // 148:10: -> ^( IM_ENDTAG ENDTP )
            {
                dbg.location(148,13);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:13: ^( IM_ENDTAG ENDTP )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(148,15);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(148,25);
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
        dbg.location(149, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:150:1: tikzbody : ( tikzscope | tikzpath | tikznodee )+ ;
    public final simpletikzParser.tikzbody_return tikzbody() throws RecognitionException {
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope47 = null;

        simpletikzParser.tikzpath_return tikzpath48 = null;

        simpletikzParser.tikznodee_return tikznodee49 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzbody");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(150, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:2: ( ( tikzscope | tikzpath | tikznodee )+ )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:4: ( tikzscope | tikzpath | tikznodee )+
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(151,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:4: ( tikzscope | tikzpath | tikznodee )+
            int cnt14=0;
            try { dbg.enterSubRule(14);

            loop14:
            do {
                int alt14=4;
                try { dbg.enterDecision(14);

                switch ( input.LA(1) ) {
                case BEGINSCOPE:
                    {
                    alt14=1;
                    }
                    break;
                case DRAW:
                case PATH:
                case FILL:
                    {
                    alt14=2;
                    }
                    break;
                case NODE:
                    {
                    alt14=3;
                    }
                    break;

                }

                } finally {dbg.exitDecision(14);}

                switch (alt14) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:6: tikzscope
            	    {
            	    dbg.location(151,6);
            	    pushFollow(FOLLOW_tikzscope_in_tikzbody926);
            	    tikzscope47=tikzscope();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzscope47.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:18: tikzpath
            	    {
            	    dbg.location(151,18);
            	    pushFollow(FOLLOW_tikzpath_in_tikzbody930);
            	    tikzpath48=tikzpath();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzpath48.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:29: tikznodee
            	    {
            	    dbg.location(151,29);
            	    pushFollow(FOLLOW_tikznodee_in_tikzbody934);
            	    tikznodee49=tikznodee();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikznodee49.getTree());

            	    }
            	    break;

            	default :
            	    if ( cnt14 >= 1 ) break loop14;
                        EarlyExitException eee =
                            new EarlyExitException(14, input);
                        dbg.recognitionException(eee);

                        throw eee;
                }
                cnt14++;
            } while (true);
            } finally {dbg.exitSubRule(14);}


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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:154:1: tikzscope : tikzscope_start tikzbody tikzscope_end -> ^( IM_SCOPE tikzscope_start tikzbody tikzscope_end ) ;
    public final simpletikzParser.tikzscope_return tikzscope() throws RecognitionException {
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start50 = null;

        simpletikzParser.tikzbody_return tikzbody51 = null;

        simpletikzParser.tikzscope_end_return tikzscope_end52 = null;


        RewriteRuleSubtreeStream stream_tikzscope_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        try { dbg.enterRule(getGrammarFileName(), "tikzscope");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(154, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:2: ( tikzscope_start tikzbody tikzscope_end -> ^( IM_SCOPE tikzscope_start tikzbody tikzscope_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:4: tikzscope_start tikzbody tikzscope_end
            {
            dbg.location(155,4);
            pushFollow(FOLLOW_tikzscope_start_in_tikzscope947);
            tikzscope_start50=tikzscope_start();

            state._fsp--;

            stream_tikzscope_start.add(tikzscope_start50.getTree());
            dbg.location(155,20);
            pushFollow(FOLLOW_tikzbody_in_tikzscope949);
            tikzbody51=tikzbody();

            state._fsp--;

            stream_tikzbody.add(tikzbody51.getTree());
            dbg.location(155,29);
            pushFollow(FOLLOW_tikzscope_end_in_tikzscope951);
            tikzscope_end52=tikzscope_end();

            state._fsp--;

            stream_tikzscope_end.add(tikzscope_end52.getTree());


            // AST REWRITE
            // elements: tikzscope_start, tikzscope_end, tikzbody
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 155:44: -> ^( IM_SCOPE tikzscope_start tikzbody tikzscope_end )
            {
                dbg.location(155,47);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:47: ^( IM_SCOPE tikzscope_start tikzbody tikzscope_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(155,49);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_SCOPE, "IM_SCOPE"), root_1);

                dbg.location(155,58);
                adaptor.addChild(root_1, stream_tikzscope_start.nextTree());
                dbg.location(155,74);
                adaptor.addChild(root_1, stream_tikzbody.nextTree());
                dbg.location(155,83);
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
        dbg.location(156, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:1: tikzscope_start : BEGINSCOPE -> ^( IM_STARTTAG BEGINSCOPE ) ;
    public final simpletikzParser.tikzscope_start_return tikzscope_start() throws RecognitionException {
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGINSCOPE53=null;

        Object BEGINSCOPE53_tree=null;
        RewriteRuleTokenStream stream_BEGINSCOPE=new RewriteRuleTokenStream(adaptor,"token BEGINSCOPE");

        try { dbg.enterRule(getGrammarFileName(), "tikzscope_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(157, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:2: ( BEGINSCOPE -> ^( IM_STARTTAG BEGINSCOPE ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:4: BEGINSCOPE
            {
            dbg.location(158,4);
            BEGINSCOPE53=(Token)match(input,BEGINSCOPE,FOLLOW_BEGINSCOPE_in_tikzscope_start974);  
            stream_BEGINSCOPE.add(BEGINSCOPE53);



            // AST REWRITE
            // elements: BEGINSCOPE
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 158:15: -> ^( IM_STARTTAG BEGINSCOPE )
            {
                dbg.location(158,18);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:18: ^( IM_STARTTAG BEGINSCOPE )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(158,20);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(158,32);
                adaptor.addChild(root_1, stream_BEGINSCOPE.nextNode());

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
        dbg.location(159, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:160:1: tikzscope_end : ENDSCOPE -> ^( IM_ENDTAG ENDSCOPE ) ;
    public final simpletikzParser.tikzscope_end_return tikzscope_end() throws RecognitionException {
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token ENDSCOPE54=null;

        Object ENDSCOPE54_tree=null;
        RewriteRuleTokenStream stream_ENDSCOPE=new RewriteRuleTokenStream(adaptor,"token ENDSCOPE");

        try { dbg.enterRule(getGrammarFileName(), "tikzscope_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(160, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:2: ( ENDSCOPE -> ^( IM_ENDTAG ENDSCOPE ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:4: ENDSCOPE
            {
            dbg.location(161,4);
            ENDSCOPE54=(Token)match(input,ENDSCOPE,FOLLOW_ENDSCOPE_in_tikzscope_end992);  
            stream_ENDSCOPE.add(ENDSCOPE54);



            // AST REWRITE
            // elements: ENDSCOPE
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 161:13: -> ^( IM_ENDTAG ENDSCOPE )
            {
                dbg.location(161,16);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:161:16: ^( IM_ENDTAG ENDSCOPE )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(161,18);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(161,28);
                adaptor.addChild(root_1, stream_ENDSCOPE.nextNode());

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
        dbg.location(162, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:1: tikz_options : LBR ( option ( ',' option )* )? RBR -> ^( IM_OPTIONS ( option )* ) ;
    public final simpletikzParser.tikz_options_return tikz_options() throws RecognitionException {
        simpletikzParser.tikz_options_return retval = new simpletikzParser.tikz_options_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LBR55=null;
        Token char_literal57=null;
        Token RBR59=null;
        simpletikzParser.option_return option56 = null;

        simpletikzParser.option_return option58 = null;


        Object LBR55_tree=null;
        Object char_literal57_tree=null;
        Object RBR59_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleTokenStream stream_RBR=new RewriteRuleTokenStream(adaptor,"token RBR");
        RewriteRuleTokenStream stream_LBR=new RewriteRuleTokenStream(adaptor,"token LBR");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try { dbg.enterRule(getGrammarFileName(), "tikz_options");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(164, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:2: ( LBR ( option ( ',' option )* )? RBR -> ^( IM_OPTIONS ( option )* ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:5: LBR ( option ( ',' option )* )? RBR
            {
            dbg.location(165,5);
            LBR55=(Token)match(input,LBR,FOLLOW_LBR_in_tikz_options1012);  
            stream_LBR.add(LBR55);

            dbg.location(165,9);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:9: ( option ( ',' option )* )?
            int alt16=2;
            try { dbg.enterSubRule(16);
            try { dbg.enterDecision(16);

            int LA16_0 = input.LA(1);

            if ( (LA16_0==ID) ) {
                alt16=1;
            }
            } finally {dbg.exitDecision(16);}

            switch (alt16) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:10: option ( ',' option )*
                    {
                    dbg.location(165,10);
                    pushFollow(FOLLOW_option_in_tikz_options1015);
                    option56=option();

                    state._fsp--;

                    stream_option.add(option56.getTree());
                    dbg.location(165,17);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:17: ( ',' option )*
                    try { dbg.enterSubRule(15);

                    loop15:
                    do {
                        int alt15=2;
                        try { dbg.enterDecision(15);

                        int LA15_0 = input.LA(1);

                        if ( (LA15_0==KOMMA) ) {
                            alt15=1;
                        }


                        } finally {dbg.exitDecision(15);}

                        switch (alt15) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:18: ',' option
                    	    {
                    	    dbg.location(165,18);
                    	    char_literal57=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options1018);  
                    	    stream_KOMMA.add(char_literal57);

                    	    dbg.location(165,22);
                    	    pushFollow(FOLLOW_option_in_tikz_options1020);
                    	    option58=option();

                    	    state._fsp--;

                    	    stream_option.add(option58.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop15;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(15);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(16);}

            dbg.location(165,33);
            RBR59=(Token)match(input,RBR,FOLLOW_RBR_in_tikz_options1026);  
            stream_RBR.add(RBR59);



            // AST REWRITE
            // elements: option
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 165:38: -> ^( IM_OPTIONS ( option )* )
            {
                dbg.location(165,41);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:41: ^( IM_OPTIONS ( option )* )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(165,43);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTIONS, "IM_OPTIONS"), root_1);

                dbg.location(165,54);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:54: ( option )*
                while ( stream_option.hasNext() ) {
                    dbg.location(165,54);
                    adaptor.addChild(root_1, stream_option.nextTree());

                }
                stream_option.reset();

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
        dbg.location(166, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:1: option : ( option_style -> ^( IM_OPTION_STYLE option_style ) | option_kv -> ^( IM_OPTION_KV option_kv ) );
    public final simpletikzParser.option_return option() throws RecognitionException {
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.option_style_return option_style60 = null;

        simpletikzParser.option_kv_return option_kv61 = null;


        RewriteRuleSubtreeStream stream_option_style=new RewriteRuleSubtreeStream(adaptor,"rule option_style");
        RewriteRuleSubtreeStream stream_option_kv=new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try { dbg.enterRule(getGrammarFileName(), "option");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(168, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:2: ( option_style -> ^( IM_OPTION_STYLE option_style ) | option_kv -> ^( IM_OPTION_KV option_kv ) )
            int alt17=2;
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:4: option_style
                    {
                    dbg.location(169,4);
                    pushFollow(FOLLOW_option_style_in_option1048);
                    option_style60=option_style();

                    state._fsp--;

                    stream_option_style.add(option_style60.getTree());


                    // AST REWRITE
                    // elements: option_style
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 169:19: -> ^( IM_OPTION_STYLE option_style )
                    {
                        dbg.location(169,22);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:22: ^( IM_OPTION_STYLE option_style )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(169,24);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

                        dbg.location(169,40);
                        adaptor.addChild(root_1, stream_option_style.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:170:5: option_kv
                    {
                    dbg.location(170,5);
                    pushFollow(FOLLOW_option_kv_in_option1064);
                    option_kv61=option_kv();

                    state._fsp--;

                    stream_option_kv.add(option_kv61.getTree());


                    // AST REWRITE
                    // elements: option_kv
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 170:16: -> ^( IM_OPTION_KV option_kv )
                    {
                        dbg.location(170,19);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:170:19: ^( IM_OPTION_KV option_kv )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(170,21);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

                        dbg.location(170,34);
                        adaptor.addChild(root_1, stream_option_kv.nextTree());

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
        dbg.location(171, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:1: option_kv : idd ( '=' ( idd | numberunit ) )? ;
    public final simpletikzParser.option_kv_return option_kv() throws RecognitionException {
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal63=null;
        simpletikzParser.idd_return idd62 = null;

        simpletikzParser.idd_return idd64 = null;

        simpletikzParser.numberunit_return numberunit65 = null;


        Object char_literal63_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "option_kv");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(172, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:2: ( idd ( '=' ( idd | numberunit ) )? )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:4: idd ( '=' ( idd | numberunit ) )?
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(173,4);
            pushFollow(FOLLOW_idd_in_option_kv1083);
            idd62=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd62.getTree());
            dbg.location(173,8);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:8: ( '=' ( idd | numberunit ) )?
            int alt19=2;
            try { dbg.enterSubRule(19);
            try { dbg.enterDecision(19);

            int LA19_0 = input.LA(1);

            if ( (LA19_0==EQU) ) {
                alt19=1;
            }
            } finally {dbg.exitDecision(19);}

            switch (alt19) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:9: '=' ( idd | numberunit )
                    {
                    dbg.location(173,9);
                    char_literal63=(Token)match(input,EQU,FOLLOW_EQU_in_option_kv1086); 
                    char_literal63_tree = (Object)adaptor.create(char_literal63);
                    adaptor.addChild(root_0, char_literal63_tree);

                    dbg.location(173,13);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:13: ( idd | numberunit )
                    int alt18=2;
                    try { dbg.enterSubRule(18);
                    try { dbg.enterDecision(18);

                    int LA18_0 = input.LA(1);

                    if ( (LA18_0==ID) ) {
                        alt18=1;
                    }
                    else if ( ((LA18_0>=FLOAT && LA18_0<=INT)) ) {
                        alt18=2;
                    }
                    else {
                        NoViableAltException nvae =
                            new NoViableAltException("", 18, 0, input);

                        dbg.recognitionException(nvae);
                        throw nvae;
                    }
                    } finally {dbg.exitDecision(18);}

                    switch (alt18) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:14: idd
                            {
                            dbg.location(173,14);
                            pushFollow(FOLLOW_idd_in_option_kv1089);
                            idd64=idd();

                            state._fsp--;

                            adaptor.addChild(root_0, idd64.getTree());

                            }
                            break;
                        case 2 :
                            dbg.enterAlt(2);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:20: numberunit
                            {
                            dbg.location(173,20);
                            pushFollow(FOLLOW_numberunit_in_option_kv1093);
                            numberunit65=numberunit();

                            state._fsp--;

                            adaptor.addChild(root_0, numberunit65.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(18);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(19);}


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
            dbg.exitRule(getGrammarFileName(), "option_kv");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "option_kv"

    public static class option_style_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "option_style"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:175:1: option_style : idd '/.style' '=' STRING ;
    public final simpletikzParser.option_style_return option_style() throws RecognitionException {
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal67=null;
        Token char_literal68=null;
        Token STRING69=null;
        simpletikzParser.idd_return idd66 = null;


        Object string_literal67_tree=null;
        Object char_literal68_tree=null;
        Object STRING69_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "option_style");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(175, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:2: ( idd '/.style' '=' STRING )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:4: idd '/.style' '=' STRING
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(176,4);
            pushFollow(FOLLOW_idd_in_option_style1106);
            idd66=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd66.getTree());
            dbg.location(176,8);
            string_literal67=(Token)match(input,STYLESEP,FOLLOW_STYLESEP_in_option_style1108); 
            string_literal67_tree = (Object)adaptor.create(string_literal67);
            adaptor.addChild(root_0, string_literal67_tree);

            dbg.location(176,18);
            char_literal68=(Token)match(input,EQU,FOLLOW_EQU_in_option_style1110); 
            char_literal68_tree = (Object)adaptor.create(char_literal68);
            adaptor.addChild(root_0, char_literal68_tree);

            dbg.location(176,22);
            STRING69=(Token)match(input,STRING,FOLLOW_STRING_in_option_style1112); 
            STRING69_tree = (Object)adaptor.create(STRING69);
            adaptor.addChild(root_0, STRING69_tree);


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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:1: idd : ID ( ID )* -> ^( IM_ID ( ID )* ) ;
    public final simpletikzParser.idd_return idd() throws RecognitionException {
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token ID70=null;
        Token ID71=null;

        Object ID70_tree=null;
        Object ID71_tree=null;
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try { dbg.enterRule(getGrammarFileName(), "idd");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(180, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:2: ( ID ( ID )* -> ^( IM_ID ( ID )* ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:4: ID ( ID )*
            {
            dbg.location(181,4);
            ID70=(Token)match(input,ID,FOLLOW_ID_in_idd1125);  
            stream_ID.add(ID70);

            dbg.location(181,7);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:7: ( ID )*
            try { dbg.enterSubRule(20);

            loop20:
            do {
                int alt20=2;
                try { dbg.enterDecision(20);

                int LA20_0 = input.LA(1);

                if ( (LA20_0==ID) ) {
                    alt20=1;
                }


                } finally {dbg.exitDecision(20);}

                switch (alt20) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:8: ID
            	    {
            	    dbg.location(181,8);
            	    ID71=(Token)match(input,ID,FOLLOW_ID_in_idd1128);  
            	    stream_ID.add(ID71);


            	    }
            	    break;

            	default :
            	    break loop20;
                }
            } while (true);
            } finally {dbg.exitSubRule(20);}



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
            // 181:13: -> ^( IM_ID ( ID )* )
            {
                dbg.location(181,16);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:16: ^( IM_ID ( ID )* )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(181,18);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ID, "IM_ID"), root_1);

                dbg.location(181,24);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:181:24: ( ID )*
                while ( stream_ID.hasNext() ) {
                    dbg.location(181,24);
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
        dbg.location(182, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "idd");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "idd"

    // Delegated rules


    protected DFA17 dfa17 = new DFA17(this);
    static final String DFA17_eotS =
        "\5\uffff";
    static final String DFA17_eofS =
        "\5\uffff";
    static final String DFA17_minS =
        "\1\61\2\21\2\uffff";
    static final String DFA17_maxS =
        "\3\61\2\uffff";
    static final String DFA17_acceptS =
        "\3\uffff\1\1\1\2";
    static final String DFA17_specialS =
        "\5\uffff}>";
    static final String[] DFA17_transitionS = {
            "\1\1",
            "\1\4\2\uffff\1\4\1\uffff\1\4\2\uffff\1\3\27\uffff\1\2",
            "\1\4\2\uffff\1\4\1\uffff\1\4\2\uffff\1\3\27\uffff\1\2",
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
            return "168:1: option : ( option_style -> ^( IM_OPTION_STYLE option_style ) | option_kv -> ^( IM_OPTION_KV option_kv ) );";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
 

    public static final BitSet FOLLOW_path_start_in_tikzpath378 = new BitSet(new long[]{0x0200000000004000L,0x0000000000000003L});
    public static final BitSet FOLLOW_tikzpathi_in_tikzpath380 = new BitSet(new long[]{0x0000000000800000L});
    public static final BitSet FOLLOW_path_end_in_tikzpath382 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SEMIC_in_path_end405 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi425 = new BitSet(new long[]{0xFE00000000014002L,0x0000000000000003L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi428 = new BitSet(new long[]{0xFE00000000014002L,0x0000000000000003L});
    public static final BitSet FOLLOW_tikz_options_in_tikzpathi432 = new BitSet(new long[]{0xFE00000000014000L,0x0000000000000003L});
    public static final BitSet FOLLOW_edgeop_in_tikzpathi435 = new BitSet(new long[]{0x0200000000004000L,0x0000000000000003L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi438 = new BitSet(new long[]{0xFE00000000014002L,0x0000000000000003L});
    public static final BitSet FOLLOW_coord_in_coordornode453 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikznodei_in_coordornode457 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_57_in_tikznodei469 = new BitSet(new long[]{0x0001000004004000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodei472 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_node_start_in_tikznodee482 = new BitSet(new long[]{0x0001000004004000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodee484 = new BitSet(new long[]{0x0200000000804000L,0x0000000000000003L});
    public static final BitSet FOLLOW_tikzpathi_in_tikznodee486 = new BitSet(new long[]{0x0000000000800000L});
    public static final BitSet FOLLOW_path_end_in_tikznodee489 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_node_start515 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_tikznode533 = new BitSet(new long[]{0x0001000004000000L});
    public static final BitSet FOLLOW_AT_in_tikznode537 = new BitSet(new long[]{0x0000000000004000L,0x0000000000000003L});
    public static final BitSet FOLLOW_coord_in_tikznode539 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_STRING_in_tikznode543 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_edgeop0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LPAR_in_nodename608 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_ID_in_nodename612 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_RPAR_in_nodename614 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_coord639 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_modifier_in_coord663 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_LPAR_in_coord668 = new BitSet(new long[]{0x000C000000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord670 = new BitSet(new long[]{0x0000000000100000L});
    public static final BitSet FOLLOW_KOMMA_in_coord672 = new BitSet(new long[]{0x000C000000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord674 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_RPAR_in_coord676 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_number_in_numberunit718 = new BitSet(new long[]{0x0000000340000002L,0x000000000000000CL});
    public static final BitSet FOLLOW_unit_in_numberunit720 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_number743 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_unit0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_tag_in_path_start787 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SOMETHING_in_tikzdocument824 = new BitSet(new long[]{0x0010000000000040L});
    public static final BitSet FOLLOW_tikzpicture_in_tikzdocument827 = new BitSet(new long[]{0x0010000000000002L});
    public static final BitSet FOLLOW_SOMETHING_in_tikzdocument830 = new BitSet(new long[]{0x0010000000000002L});
    public static final BitSet FOLLOW_tikzpicture_start_in_tikzpicture853 = new BitSet(new long[]{0x0000000000013D80L});
    public static final BitSet FOLLOW_tikz_options_in_tikzpicture855 = new BitSet(new long[]{0x0000000000013D80L});
    public static final BitSet FOLLOW_tikzbody_in_tikzpicture858 = new BitSet(new long[]{0x0000000000013D80L});
    public static final BitSet FOLLOW_tikzpicture_end_in_tikzpicture861 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGINTP_in_tikzpicture_start888 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ENDTP_in_tikzpicture_end906 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody926 = new BitSet(new long[]{0x0000000000003D02L});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody930 = new BitSet(new long[]{0x0000000000003D02L});
    public static final BitSet FOLLOW_tikznodee_in_tikzbody934 = new BitSet(new long[]{0x0000000000003D02L});
    public static final BitSet FOLLOW_tikzscope_start_in_tikzscope947 = new BitSet(new long[]{0x0000000000003D00L});
    public static final BitSet FOLLOW_tikzbody_in_tikzscope949 = new BitSet(new long[]{0x0000000000000200L});
    public static final BitSet FOLLOW_tikzscope_end_in_tikzscope951 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGINSCOPE_in_tikzscope_start974 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ENDSCOPE_in_tikzscope_end992 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBR_in_tikz_options1012 = new BitSet(new long[]{0x0002000000020000L});
    public static final BitSet FOLLOW_option_in_tikz_options1015 = new BitSet(new long[]{0x0000000000120000L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_options1018 = new BitSet(new long[]{0x0002000000000000L});
    public static final BitSet FOLLOW_option_in_tikz_options1020 = new BitSet(new long[]{0x0000000000120000L});
    public static final BitSet FOLLOW_RBR_in_tikz_options1026 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_style_in_option1048 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_kv_in_option1064 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_kv1083 = new BitSet(new long[]{0x0000000000400002L});
    public static final BitSet FOLLOW_EQU_in_option_kv1086 = new BitSet(new long[]{0x000E000000000000L});
    public static final BitSet FOLLOW_idd_in_option_kv1089 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_numberunit_in_option_kv1093 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_style1106 = new BitSet(new long[]{0x0000000002000000L});
    public static final BitSet FOLLOW_STYLESEP_in_option_style1108 = new BitSet(new long[]{0x0000000000400000L});
    public static final BitSet FOLLOW_EQU_in_option_style1110 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_STRING_in_option_style1112 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ID_in_idd1125 = new BitSet(new long[]{0x0002000000000002L});
    public static final BitSet FOLLOW_ID_in_idd1128 = new BitSet(new long[]{0x0002000000000002L});

}