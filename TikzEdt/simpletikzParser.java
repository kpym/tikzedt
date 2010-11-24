// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-11-23 15:42:06

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;

import org.antlr.runtime.tree.*;

public class simpletikzParser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BEGIN", "END", "BEGINTP", "ENDTP", "BEGINSCOPE", "ENDSCOPE", "NODE", "DRAW", "PATH", "FILL", "LPAR", "RPAR", "LBR", "RBR", "LBRR", "RBRR", "KOMMA", "SCALE", "EQU", "SEMIC", "COLON", "STYLESEP", "AT", "LABEL", "EVERYLOOP", "ST_INNERSEP", "ST_OUTERSEP", "ST_FILL", "ST_DRAW", "ST_SHAPE", "ST_MINSIZE", "ST_LINEWIDTH", "ST_DASHSTYLE", "LOOP", "IN", "OUT", "UN_PTS", "UN_CM", "IM_PATH", "IM_NODE", "IM_COORD", "IM_COORDDECO", "IM_NODENAME", "IM_PICTURE", "IM_SCOPE", "OPTIONS", "STRING", "ID", "FLOAT", "INT", "SOMETHING", "EXPONENT", "COMMENT", "WS", "ESC_SEQ", "'node'", "'--'", "'edge'", "'->'", "'|-'", "'-|'", "'to'", "'+'", "'++'", "'ex'", "'mm'"
    };
    public static final int T__68=68;
    public static final int T__69=69;
    public static final int T__66=66;
    public static final int EXPONENT=55;
    public static final int T__67=67;
    public static final int T__64=64;
    public static final int T__65=65;
    public static final int T__62=62;
    public static final int T__63=63;
    public static final int IM_PATH=42;
    public static final int RBR=17;
    public static final int ST_DASHSTYLE=36;
    public static final int ST_LINEWIDTH=35;
    public static final int ST_FILL=31;
    public static final int FLOAT=52;
    public static final int BEGINTP=6;
    public static final int SOMETHING=54;
    public static final int ID=51;
    public static final int T__61=61;
    public static final int EOF=-1;
    public static final int T__60=60;
    public static final int LBR=16;
    public static final int AT=26;
    public static final int RBRR=19;
    public static final int ESC_SEQ=58;
    public static final int IN=38;
    public static final int LPAR=14;
    public static final int EVERYLOOP=28;
    public static final int ENDTP=7;
    public static final int FILL=13;
    public static final int PATH=12;
    public static final int T__59=59;
    public static final int LOOP=37;
    public static final int BEGIN=4;
    public static final int ST_OUTERSEP=30;
    public static final int COMMENT=56;
    public static final int ST_INNERSEP=29;
    public static final int NODE=10;
    public static final int UN_PTS=40;
    public static final int IM_COORDDECO=45;
    public static final int STYLESEP=25;
    public static final int IM_COORD=44;
    public static final int IM_PICTURE=47;
    public static final int INT=53;
    public static final int BEGINSCOPE=8;
    public static final int LBRR=18;
    public static final int UN_CM=41;
    public static final int IM_NODE=43;
    public static final int COLON=24;
    public static final int ENDSCOPE=9;
    public static final int ST_DRAW=32;
    public static final int IM_SCOPE=48;
    public static final int SCALE=21;
    public static final int WS=57;
    public static final int OUT=39;
    public static final int ST_MINSIZE=34;
    public static final int LABEL=27;
    public static final int KOMMA=20;
    public static final int ST_SHAPE=33;
    public static final int EQU=22;
    public static final int RPAR=15;
    public static final int END=5;
    public static final int SEMIC=23;
    public static final int IM_NODENAME=46;
    public static final int OPTIONS=49;
    public static final int STRING=50;
    public static final int DRAW=11;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "tikzpath", "tikzpathi", "coordwithdeco", "tikznodei", 
        "coord", "tikzpicture", "numberunit", "nodename", "tikzscope", "coord_modifier", 
        "tikznodee", "edgeop", "tikzbody", "tikznode", "unit", "path_start"
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:68:1: tikzpath : path_start tikzpathi ;
    public final simpletikzParser.tikzpath_return tikzpath() throws RecognitionException {
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_return path_start1 = null;

        simpletikzParser.tikzpathi_return tikzpathi2 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzpath");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(68, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:69:2: ( path_start tikzpathi )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:69:4: path_start tikzpathi
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(69,14);
            pushFollow(FOLLOW_path_start_in_tikzpath405);
            path_start1=path_start();

            state._fsp--;

            dbg.location(69,16);
            pushFollow(FOLLOW_tikzpathi_in_tikzpath408);
            tikzpathi2=tikzpathi();

            state._fsp--;

            adaptor.addChild(root_0, tikzpathi2.getTree());

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
        dbg.location(70, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:1: tikzpathi : ( OPTIONS )? coordwithdeco ( coordwithdeco | ( OPTIONS )? edgeop coordwithdeco )* SEMIC -> ^( IM_PATH ( coordwithdeco )+ ) ;
    public final simpletikzParser.tikzpathi_return tikzpathi() throws RecognitionException {
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token OPTIONS3=null;
        Token OPTIONS6=null;
        Token SEMIC9=null;
        simpletikzParser.coordwithdeco_return coordwithdeco4 = null;

        simpletikzParser.coordwithdeco_return coordwithdeco5 = null;

        simpletikzParser.edgeop_return edgeop7 = null;

        simpletikzParser.coordwithdeco_return coordwithdeco8 = null;


        Object OPTIONS3_tree=null;
        Object OPTIONS6_tree=null;
        Object SEMIC9_tree=null;
        RewriteRuleTokenStream stream_SEMIC=new RewriteRuleTokenStream(adaptor,"token SEMIC");
        RewriteRuleTokenStream stream_OPTIONS=new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_edgeop=new RewriteRuleSubtreeStream(adaptor,"rule edgeop");
        RewriteRuleSubtreeStream stream_coordwithdeco=new RewriteRuleSubtreeStream(adaptor,"rule coordwithdeco");
        try { dbg.enterRule(getGrammarFileName(), "tikzpathi");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(72, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:2: ( ( OPTIONS )? coordwithdeco ( coordwithdeco | ( OPTIONS )? edgeop coordwithdeco )* SEMIC -> ^( IM_PATH ( coordwithdeco )+ ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:4: ( OPTIONS )? coordwithdeco ( coordwithdeco | ( OPTIONS )? edgeop coordwithdeco )* SEMIC
            {
            dbg.location(73,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:4: ( OPTIONS )?
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:4: OPTIONS
                    {
                    dbg.location(73,4);
                    OPTIONS3=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpathi419);  
                    stream_OPTIONS.add(OPTIONS3);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(1);}

            dbg.location(73,13);
            pushFollow(FOLLOW_coordwithdeco_in_tikzpathi422);
            coordwithdeco4=coordwithdeco();

            state._fsp--;

            stream_coordwithdeco.add(coordwithdeco4.getTree());
            dbg.location(73,27);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:27: ( coordwithdeco | ( OPTIONS )? edgeop coordwithdeco )*
            try { dbg.enterSubRule(3);

            loop3:
            do {
                int alt3=3;
                try { dbg.enterDecision(3);

                int LA3_0 = input.LA(1);

                if ( (LA3_0==LPAR||(LA3_0>=66 && LA3_0<=67)) ) {
                    alt3=1;
                }
                else if ( (LA3_0==OPTIONS||(LA3_0>=60 && LA3_0<=65)) ) {
                    alt3=2;
                }


                } finally {dbg.exitDecision(3);}

                switch (alt3) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:28: coordwithdeco
            	    {
            	    dbg.location(73,28);
            	    pushFollow(FOLLOW_coordwithdeco_in_tikzpathi425);
            	    coordwithdeco5=coordwithdeco();

            	    state._fsp--;

            	    stream_coordwithdeco.add(coordwithdeco5.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:44: ( OPTIONS )? edgeop coordwithdeco
            	    {
            	    dbg.location(73,44);
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:44: ( OPTIONS )?
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

            	            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:44: OPTIONS
            	            {
            	            dbg.location(73,44);
            	            OPTIONS6=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpathi429);  
            	            stream_OPTIONS.add(OPTIONS6);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(2);}

            	    dbg.location(73,53);
            	    pushFollow(FOLLOW_edgeop_in_tikzpathi432);
            	    edgeop7=edgeop();

            	    state._fsp--;

            	    stream_edgeop.add(edgeop7.getTree());
            	    dbg.location(73,60);
            	    pushFollow(FOLLOW_coordwithdeco_in_tikzpathi434);
            	    coordwithdeco8=coordwithdeco();

            	    state._fsp--;

            	    stream_coordwithdeco.add(coordwithdeco8.getTree());

            	    }
            	    break;

            	default :
            	    break loop3;
                }
            } while (true);
            } finally {dbg.exitSubRule(3);}

            dbg.location(73,77);
            SEMIC9=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_tikzpathi439);  
            stream_SEMIC.add(SEMIC9);



            // AST REWRITE
            // elements: coordwithdeco
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 73:85: -> ^( IM_PATH ( coordwithdeco )+ )
            {
                dbg.location(73,88);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:73:88: ^( IM_PATH ( coordwithdeco )+ )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(73,90);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(73,98);
                if ( !(stream_coordwithdeco.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_coordwithdeco.hasNext() ) {
                    dbg.location(73,98);
                    adaptor.addChild(root_1, stream_coordwithdeco.nextTree());

                }
                stream_coordwithdeco.reset();

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
            dbg.exitRule(getGrammarFileName(), "tikzpathi");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzpathi"

    public static class coordwithdeco_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coordwithdeco"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:1: coordwithdeco : coord ( tikznodei )* -> ^( IM_COORDDECO coord ( tikznodei )* ) ;
    public final simpletikzParser.coordwithdeco_return coordwithdeco() throws RecognitionException {
        simpletikzParser.coordwithdeco_return retval = new simpletikzParser.coordwithdeco_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coord_return coord10 = null;

        simpletikzParser.tikznodei_return tikznodei11 = null;


        RewriteRuleSubtreeStream stream_coord=new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_tikznodei=new RewriteRuleSubtreeStream(adaptor,"rule tikznodei");
        try { dbg.enterRule(getGrammarFileName(), "coordwithdeco");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(76, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:77:2: ( coord ( tikznodei )* -> ^( IM_COORDDECO coord ( tikznodei )* ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:77:4: coord ( tikznodei )*
            {
            dbg.location(77,4);
            pushFollow(FOLLOW_coord_in_coordwithdeco462);
            coord10=coord();

            state._fsp--;

            stream_coord.add(coord10.getTree());
            dbg.location(77,10);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:77:10: ( tikznodei )*
            try { dbg.enterSubRule(4);

            loop4:
            do {
                int alt4=2;
                try { dbg.enterDecision(4);

                int LA4_0 = input.LA(1);

                if ( (LA4_0==59) ) {
                    alt4=1;
                }


                } finally {dbg.exitDecision(4);}

                switch (alt4) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:77:10: tikznodei
            	    {
            	    dbg.location(77,10);
            	    pushFollow(FOLLOW_tikznodei_in_coordwithdeco464);
            	    tikznodei11=tikznodei();

            	    state._fsp--;

            	    stream_tikznodei.add(tikznodei11.getTree());

            	    }
            	    break;

            	default :
            	    break loop4;
                }
            } while (true);
            } finally {dbg.exitSubRule(4);}



            // AST REWRITE
            // elements: tikznodei, coord
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 77:21: -> ^( IM_COORDDECO coord ( tikznodei )* )
            {
                dbg.location(77,24);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:77:24: ^( IM_COORDDECO coord ( tikznodei )* )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(77,26);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORDDECO, "IM_COORDDECO"), root_1);

                dbg.location(77,39);
                adaptor.addChild(root_1, stream_coord.nextTree());
                dbg.location(77,45);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:77:45: ( tikznodei )*
                while ( stream_tikznodei.hasNext() ) {
                    dbg.location(77,45);
                    adaptor.addChild(root_1, stream_tikznodei.nextTree());

                }
                stream_tikznodei.reset();

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
        dbg.location(78, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "coordwithdeco");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "coordwithdeco"

    public static class tikznodei_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznodei"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:1: tikznodei : 'node' tikznode ;
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
        dbg.location(80, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:81:2: ( 'node' tikznode )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:81:4: 'node' tikznode
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(81,10);
            string_literal12=(Token)match(input,59,FOLLOW_59_in_tikznodei488); 
            dbg.location(81,12);
            pushFollow(FOLLOW_tikznode_in_tikznodei491);
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
        dbg.location(82, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:1: tikznodee : NODE tikznode tikzpathi ;
    public final simpletikzParser.tikznodee_return tikznodee() throws RecognitionException {
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token NODE14=null;
        simpletikzParser.tikznode_return tikznode15 = null;

        simpletikzParser.tikzpathi_return tikzpathi16 = null;


        Object NODE14_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "tikznodee");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(83, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:2: ( NODE tikznode tikzpathi )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:4: NODE tikznode tikzpathi
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(84,4);
            NODE14=(Token)match(input,NODE,FOLLOW_NODE_in_tikznodee501); 
            NODE14_tree = (Object)adaptor.create(NODE14);
            adaptor.addChild(root_0, NODE14_tree);

            dbg.location(84,9);
            pushFollow(FOLLOW_tikznode_in_tikznodee503);
            tikznode15=tikznode();

            state._fsp--;

            adaptor.addChild(root_0, tikznode15.getTree());
            dbg.location(84,18);
            pushFollow(FOLLOW_tikzpathi_in_tikznodee505);
            tikzpathi16=tikzpathi();

            state._fsp--;

            adaptor.addChild(root_0, tikzpathi16.getTree());

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
            dbg.exitRule(getGrammarFileName(), "tikznodee");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikznodee"

    public static class tikznode_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznode"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:1: tikznode : ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( nodename )? 'at' ( coord )? ) ;
    public final simpletikzParser.tikznode_return tikznode() throws RecognitionException {
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token OPTIONS17=null;
        Token string_literal19=null;
        Token STRING21=null;
        simpletikzParser.nodename_return nodename18 = null;

        simpletikzParser.coord_return coord20 = null;


        Object OPTIONS17_tree=null;
        Object string_literal19_tree=null;
        Object STRING21_tree=null;
        RewriteRuleTokenStream stream_AT=new RewriteRuleTokenStream(adaptor,"token AT");
        RewriteRuleTokenStream stream_OPTIONS=new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleTokenStream stream_STRING=new RewriteRuleTokenStream(adaptor,"token STRING");
        RewriteRuleSubtreeStream stream_coord=new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try { dbg.enterRule(getGrammarFileName(), "tikznode");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(86, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:2: ( ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( nodename )? 'at' ( coord )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:4: ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING
            {
            dbg.location(87,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:4: ( OPTIONS )?
            int alt5=2;
            try { dbg.enterSubRule(5);
            try { dbg.enterDecision(5);

            int LA5_0 = input.LA(1);

            if ( (LA5_0==OPTIONS) ) {
                alt5=1;
            }
            } finally {dbg.exitDecision(5);}

            switch (alt5) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:4: OPTIONS
                    {
                    dbg.location(87,4);
                    OPTIONS17=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikznode515);  
                    stream_OPTIONS.add(OPTIONS17);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(5);}

            dbg.location(87,13);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:13: ( nodename )?
            int alt6=2;
            try { dbg.enterSubRule(6);
            try { dbg.enterDecision(6);

            int LA6_0 = input.LA(1);

            if ( (LA6_0==LPAR) ) {
                alt6=1;
            }
            } finally {dbg.exitDecision(6);}

            switch (alt6) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:13: nodename
                    {
                    dbg.location(87,13);
                    pushFollow(FOLLOW_nodename_in_tikznode518);
                    nodename18=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename18.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(6);}

            dbg.location(87,23);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:23: ( 'at' coord )?
            int alt7=2;
            try { dbg.enterSubRule(7);
            try { dbg.enterDecision(7);

            int LA7_0 = input.LA(1);

            if ( (LA7_0==AT) ) {
                alt7=1;
            }
            } finally {dbg.exitDecision(7);}

            switch (alt7) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:24: 'at' coord
                    {
                    dbg.location(87,24);
                    string_literal19=(Token)match(input,AT,FOLLOW_AT_in_tikznode522);  
                    stream_AT.add(string_literal19);

                    dbg.location(87,29);
                    pushFollow(FOLLOW_coord_in_tikznode524);
                    coord20=coord();

                    state._fsp--;

                    stream_coord.add(coord20.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(7);}

            dbg.location(87,37);
            STRING21=(Token)match(input,STRING,FOLLOW_STRING_in_tikznode528);  
            stream_STRING.add(STRING21);



            // AST REWRITE
            // elements: AT, nodename, coord
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 87:45: -> ^( IM_NODE ( nodename )? 'at' ( coord )? )
            {
                dbg.location(87,48);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:48: ^( IM_NODE ( nodename )? 'at' ( coord )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(87,50);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODE, "IM_NODE"), root_1);

                dbg.location(87,58);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:58: ( nodename )?
                if ( stream_nodename.hasNext() ) {
                    dbg.location(87,58);
                    adaptor.addChild(root_1, stream_nodename.nextTree());

                }
                stream_nodename.reset();
                dbg.location(87,68);
                adaptor.addChild(root_1, stream_AT.nextNode());
                dbg.location(87,73);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:73: ( coord )?
                if ( stream_coord.hasNext() ) {
                    dbg.location(87,73);
                    adaptor.addChild(root_1, stream_coord.nextTree());

                }
                stream_coord.reset();

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
        dbg.location(88, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:1: edgeop : ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' );
    public final simpletikzParser.edgeop_return edgeop() throws RecognitionException {
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set22=null;

        Object set22_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "edgeop");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(90, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:2: ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(91,2);
            set22=(Token)input.LT(1);
            if ( (input.LA(1)>=60 && input.LA(1)<=65) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set22));
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
        dbg.location(92, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:1: nodename : lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) ;
    public final simpletikzParser.nodename_return nodename() throws RecognitionException {
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token id=null;
        Token RPAR23=null;

        Object lc_tree=null;
        Object id_tree=null;
        Object RPAR23_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try { dbg.enterRule(getGrammarFileName(), "nodename");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(94, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:95:2: (lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:95:4: lc= LPAR id= ID RPAR
            {
            dbg.location(95,6);
            lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_nodename593);  
            stream_LPAR.add(lc);

            dbg.location(95,14);
            id=(Token)match(input,ID,FOLLOW_ID_in_nodename597);  
            stream_ID.add(id);

            dbg.location(95,18);
            RPAR23=(Token)match(input,RPAR,FOLLOW_RPAR_in_nodename599);  
            stream_RPAR.add(RPAR23);



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
            // 95:24: -> ^( IM_NODENAME[$lc] $id)
            {
                dbg.location(95,27);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:95:27: ^( IM_NODENAME[$lc] $id)
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(95,29);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODENAME, lc), root_1);

                dbg.location(95,46);
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
        dbg.location(96, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) );
    public final simpletikzParser.coord_return coord() throws RecognitionException {
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token KOMMA27=null;
        Token RPAR29=null;
        simpletikzParser.nodename_return nodename24 = null;

        simpletikzParser.coord_modifier_return coord_modifier25 = null;

        simpletikzParser.numberunit_return numberunit26 = null;

        simpletikzParser.numberunit_return numberunit28 = null;


        Object lc_tree=null;
        Object KOMMA27_tree=null;
        Object RPAR29_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_numberunit=new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier=new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try { dbg.enterRule(getGrammarFileName(), "coord");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(98, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:99:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) )
            int alt9=2;
            try { dbg.enterDecision(9);

            int LA9_0 = input.LA(1);

            if ( (LA9_0==LPAR) ) {
                int LA9_1 = input.LA(2);

                if ( (LA9_1==ID) ) {
                    alt9=1;
                }
                else if ( ((LA9_1>=FLOAT && LA9_1<=INT)) ) {
                    alt9=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 9, 1, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
            }
            else if ( ((LA9_0>=66 && LA9_0<=67)) ) {
                alt9=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 9, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(9);}

            switch (alt9) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:99:6: nodename
                    {
                    dbg.location(99,6);
                    pushFollow(FOLLOW_nodename_in_coord624);
                    nodename24=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename24.getTree());


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
                    // 99:24: -> ^( IM_COORD nodename )
                    {
                        dbg.location(99,27);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:99:27: ^( IM_COORD nodename )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(99,29);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, "IM_COORD"), root_1);

                        dbg.location(99,38);
                        adaptor.addChild(root_1, stream_nodename.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    {
                    dbg.location(100,5);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:7: ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR
                    {
                    dbg.location(100,7);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:7: ( coord_modifier )?
                    int alt8=2;
                    try { dbg.enterSubRule(8);
                    try { dbg.enterDecision(8);

                    int LA8_0 = input.LA(1);

                    if ( ((LA8_0>=66 && LA8_0<=67)) ) {
                        alt8=1;
                    }
                    } finally {dbg.exitDecision(8);}

                    switch (alt8) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:7: coord_modifier
                            {
                            dbg.location(100,7);
                            pushFollow(FOLLOW_coord_modifier_in_coord649);
                            coord_modifier25=coord_modifier();

                            state._fsp--;

                            stream_coord_modifier.add(coord_modifier25.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(8);}

                    dbg.location(100,25);
                    lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_coord654);  
                    stream_LPAR.add(lc);

                    dbg.location(100,31);
                    pushFollow(FOLLOW_numberunit_in_coord656);
                    numberunit26=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit26.getTree());
                    dbg.location(100,42);
                    KOMMA27=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_coord658);  
                    stream_KOMMA.add(KOMMA27);

                    dbg.location(100,48);
                    pushFollow(FOLLOW_numberunit_in_coord660);
                    numberunit28=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit28.getTree());
                    dbg.location(100,59);
                    RPAR29=(Token)match(input,RPAR,FOLLOW_RPAR_in_coord662);  
                    stream_RPAR.add(RPAR29);


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
                    // 100:66: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    {
                        dbg.location(100,69);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:69: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(100,71);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, lc), root_1);

                        dbg.location(100,85);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:85: ( coord_modifier )?
                        if ( stream_coord_modifier.hasNext() ) {
                            dbg.location(100,85);
                            adaptor.addChild(root_1, stream_coord_modifier.nextTree());

                        }
                        stream_coord_modifier.reset();
                        dbg.location(100,101);
                        if ( !(stream_numberunit.hasNext()) ) {
                            throw new RewriteEarlyExitException();
                        }
                        while ( stream_numberunit.hasNext() ) {
                            dbg.location(100,101);
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
        dbg.location(101, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:1: coord_modifier : ( '+' | '++' );
    public final simpletikzParser.coord_modifier_return coord_modifier() throws RecognitionException {
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set30=null;

        Object set30_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "coord_modifier");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(103, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:2: ( '+' | '++' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(104,2);
            set30=(Token)input.LT(1);
            if ( (input.LA(1)>=66 && input.LA(1)<=67) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set30));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:1: numberunit : ( FLOAT | INT ) ( unit )? ;
    public final simpletikzParser.numberunit_return numberunit() throws RecognitionException {
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set31=null;
        simpletikzParser.unit_return unit32 = null;


        Object set31_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "numberunit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(107, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:2: ( ( FLOAT | INT ) ( unit )? )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:4: ( FLOAT | INT ) ( unit )?
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(108,4);
            set31=(Token)input.LT(1);
            if ( (input.LA(1)>=FLOAT && input.LA(1)<=INT) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set31));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                dbg.recognitionException(mse);
                throw mse;
            }

            dbg.location(108,16);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:16: ( unit )?
            int alt10=2;
            try { dbg.enterSubRule(10);
            try { dbg.enterDecision(10);

            int LA10_0 = input.LA(1);

            if ( (LA10_0==IN||(LA10_0>=UN_PTS && LA10_0<=UN_CM)||(LA10_0>=68 && LA10_0<=69)) ) {
                alt10=1;
            }
            } finally {dbg.exitDecision(10);}

            switch (alt10) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:16: unit
                    {
                    dbg.location(108,16);
                    pushFollow(FOLLOW_unit_in_numberunit710);
                    unit32=unit();

                    state._fsp--;

                    adaptor.addChild(root_0, unit32.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(10);}


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
            dbg.exitRule(getGrammarFileName(), "numberunit");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "numberunit"

    public static class unit_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "unit"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' );
    public final simpletikzParser.unit_return unit() throws RecognitionException {
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set33=null;

        Object set33_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(111, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(112,2);
            set33=(Token)input.LT(1);
            if ( input.LA(1)==IN||(input.LA(1)>=UN_PTS && input.LA(1)<=UN_CM)||(input.LA(1)>=68 && input.LA(1)<=69) ) {
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
        dbg.location(113, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:115:1: path_start : ( DRAW | FILL | PATH );
    public final simpletikzParser.path_start_return path_start() throws RecognitionException {
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set34=null;

        Object set34_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "path_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(115, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:2: ( DRAW | FILL | PATH )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(116,2);
            set34=(Token)input.LT(1);
            if ( (input.LA(1)>=DRAW && input.LA(1)<=FILL) ) {
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
        dbg.location(117, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "path_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "path_start"

    public static class tikzpicture_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpicture"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:119:1: tikzpicture : ( SOMETHING )* BEGINTP ( OPTIONS )? tikzbody ENDTP ( SOMETHING )* -> ^( IM_PICTURE tikzbody ) ;
    public final simpletikzParser.tikzpicture_return tikzpicture() throws RecognitionException {
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token SOMETHING35=null;
        Token BEGINTP36=null;
        Token OPTIONS37=null;
        Token ENDTP39=null;
        Token SOMETHING40=null;
        simpletikzParser.tikzbody_return tikzbody38 = null;


        Object SOMETHING35_tree=null;
        Object BEGINTP36_tree=null;
        Object OPTIONS37_tree=null;
        Object ENDTP39_tree=null;
        Object SOMETHING40_tree=null;
        RewriteRuleTokenStream stream_BEGINTP=new RewriteRuleTokenStream(adaptor,"token BEGINTP");
        RewriteRuleTokenStream stream_SOMETHING=new RewriteRuleTokenStream(adaptor,"token SOMETHING");
        RewriteRuleTokenStream stream_ENDTP=new RewriteRuleTokenStream(adaptor,"token ENDTP");
        RewriteRuleTokenStream stream_OPTIONS=new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        try { dbg.enterRule(getGrammarFileName(), "tikzpicture");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(119, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:2: ( ( SOMETHING )* BEGINTP ( OPTIONS )? tikzbody ENDTP ( SOMETHING )* -> ^( IM_PICTURE tikzbody ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:4: ( SOMETHING )* BEGINTP ( OPTIONS )? tikzbody ENDTP ( SOMETHING )*
            {
            dbg.location(120,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:4: ( SOMETHING )*
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

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:4: SOMETHING
            	    {
            	    dbg.location(120,4);
            	    SOMETHING35=(Token)match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzpicture770);  
            	    stream_SOMETHING.add(SOMETHING35);


            	    }
            	    break;

            	default :
            	    break loop11;
                }
            } while (true);
            } finally {dbg.exitSubRule(11);}

            dbg.location(120,15);
            BEGINTP36=(Token)match(input,BEGINTP,FOLLOW_BEGINTP_in_tikzpicture773);  
            stream_BEGINTP.add(BEGINTP36);

            dbg.location(120,23);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:23: ( OPTIONS )?
            int alt12=2;
            try { dbg.enterSubRule(12);
            try { dbg.enterDecision(12);

            int LA12_0 = input.LA(1);

            if ( (LA12_0==OPTIONS) ) {
                alt12=1;
            }
            } finally {dbg.exitDecision(12);}

            switch (alt12) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:23: OPTIONS
                    {
                    dbg.location(120,23);
                    OPTIONS37=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpicture775);  
                    stream_OPTIONS.add(OPTIONS37);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(12);}

            dbg.location(120,32);
            pushFollow(FOLLOW_tikzbody_in_tikzpicture778);
            tikzbody38=tikzbody();

            state._fsp--;

            stream_tikzbody.add(tikzbody38.getTree());
            dbg.location(120,41);
            ENDTP39=(Token)match(input,ENDTP,FOLLOW_ENDTP_in_tikzpicture780);  
            stream_ENDTP.add(ENDTP39);

            dbg.location(120,48);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:48: ( SOMETHING )*
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

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:48: SOMETHING
            	    {
            	    dbg.location(120,48);
            	    SOMETHING40=(Token)match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzpicture783);  
            	    stream_SOMETHING.add(SOMETHING40);


            	    }
            	    break;

            	default :
            	    break loop13;
                }
            } while (true);
            } finally {dbg.exitSubRule(13);}



            // AST REWRITE
            // elements: tikzbody
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 120:60: -> ^( IM_PICTURE tikzbody )
            {
                dbg.location(120,63);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:63: ^( IM_PICTURE tikzbody )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(120,65);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PICTURE, "IM_PICTURE"), root_1);

                dbg.location(120,76);
                adaptor.addChild(root_1, stream_tikzbody.nextTree());

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
        dbg.location(121, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:123:1: tikzbody : ( tikzscope | tikzpath | tikznodee )* ;
    public final simpletikzParser.tikzbody_return tikzbody() throws RecognitionException {
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope41 = null;

        simpletikzParser.tikzpath_return tikzpath42 = null;

        simpletikzParser.tikznodee_return tikznodee43 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzbody");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(123, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:2: ( ( tikzscope | tikzpath | tikznodee )* )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:4: ( tikzscope | tikzpath | tikznodee )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(124,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:4: ( tikzscope | tikzpath | tikznodee )*
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

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:6: tikzscope
            	    {
            	    dbg.location(124,6);
            	    pushFollow(FOLLOW_tikzscope_in_tikzbody806);
            	    tikzscope41=tikzscope();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzscope41.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:18: tikzpath
            	    {
            	    dbg.location(124,18);
            	    pushFollow(FOLLOW_tikzpath_in_tikzbody810);
            	    tikzpath42=tikzpath();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzpath42.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:29: tikznodee
            	    {
            	    dbg.location(124,29);
            	    pushFollow(FOLLOW_tikznodee_in_tikzbody814);
            	    tikznodee43=tikznodee();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikznodee43.getTree());

            	    }
            	    break;

            	default :
            	    break loop14;
                }
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
        dbg.location(125, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:127:1: tikzscope : BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE -> ^( IM_SCOPE tikzbody ) ;
    public final simpletikzParser.tikzscope_return tikzscope() throws RecognitionException {
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGINSCOPE44=null;
        Token OPTIONS45=null;
        Token ENDSCOPE47=null;
        simpletikzParser.tikzbody_return tikzbody46 = null;


        Object BEGINSCOPE44_tree=null;
        Object OPTIONS45_tree=null;
        Object ENDSCOPE47_tree=null;
        RewriteRuleTokenStream stream_ENDSCOPE=new RewriteRuleTokenStream(adaptor,"token ENDSCOPE");
        RewriteRuleTokenStream stream_BEGINSCOPE=new RewriteRuleTokenStream(adaptor,"token BEGINSCOPE");
        RewriteRuleTokenStream stream_OPTIONS=new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        try { dbg.enterRule(getGrammarFileName(), "tikzscope");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(127, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:2: ( BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE -> ^( IM_SCOPE tikzbody ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:4: BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE
            {
            dbg.location(128,4);
            BEGINSCOPE44=(Token)match(input,BEGINSCOPE,FOLLOW_BEGINSCOPE_in_tikzscope827);  
            stream_BEGINSCOPE.add(BEGINSCOPE44);

            dbg.location(128,15);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:15: ( OPTIONS )?
            int alt15=2;
            try { dbg.enterSubRule(15);
            try { dbg.enterDecision(15);

            int LA15_0 = input.LA(1);

            if ( (LA15_0==OPTIONS) ) {
                alt15=1;
            }
            } finally {dbg.exitDecision(15);}

            switch (alt15) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:15: OPTIONS
                    {
                    dbg.location(128,15);
                    OPTIONS45=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzscope829);  
                    stream_OPTIONS.add(OPTIONS45);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(15);}

            dbg.location(128,24);
            pushFollow(FOLLOW_tikzbody_in_tikzscope832);
            tikzbody46=tikzbody();

            state._fsp--;

            stream_tikzbody.add(tikzbody46.getTree());
            dbg.location(128,33);
            ENDSCOPE47=(Token)match(input,ENDSCOPE,FOLLOW_ENDSCOPE_in_tikzscope834);  
            stream_ENDSCOPE.add(ENDSCOPE47);



            // AST REWRITE
            // elements: tikzbody
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 128:43: -> ^( IM_SCOPE tikzbody )
            {
                dbg.location(128,46);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:46: ^( IM_SCOPE tikzbody )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(128,48);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_SCOPE, "IM_SCOPE"), root_1);

                dbg.location(128,57);
                adaptor.addChild(root_1, stream_tikzbody.nextTree());

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
            dbg.exitRule(getGrammarFileName(), "tikzscope");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzscope"

    // Delegated rules


 

    public static final BitSet FOLLOW_path_start_in_tikzpath405 = new BitSet(new long[]{0x0002000000004000L,0x000000000000000CL});
    public static final BitSet FOLLOW_tikzpathi_in_tikzpath408 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_OPTIONS_in_tikzpathi419 = new BitSet(new long[]{0x0002000000004000L,0x000000000000000CL});
    public static final BitSet FOLLOW_coordwithdeco_in_tikzpathi422 = new BitSet(new long[]{0xF002000000804000L,0x000000000000000FL});
    public static final BitSet FOLLOW_coordwithdeco_in_tikzpathi425 = new BitSet(new long[]{0xF002000000804000L,0x000000000000000FL});
    public static final BitSet FOLLOW_OPTIONS_in_tikzpathi429 = new BitSet(new long[]{0xF002000000004000L,0x000000000000000FL});
    public static final BitSet FOLLOW_edgeop_in_tikzpathi432 = new BitSet(new long[]{0x0002000000004000L,0x000000000000000CL});
    public static final BitSet FOLLOW_coordwithdeco_in_tikzpathi434 = new BitSet(new long[]{0xF002000000804000L,0x000000000000000FL});
    public static final BitSet FOLLOW_SEMIC_in_tikzpathi439 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_in_coordwithdeco462 = new BitSet(new long[]{0x0800000000000002L});
    public static final BitSet FOLLOW_tikznodei_in_coordwithdeco464 = new BitSet(new long[]{0x0800000000000002L});
    public static final BitSet FOLLOW_59_in_tikznodei488 = new BitSet(new long[]{0x0006000004004000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodei491 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_tikznodee501 = new BitSet(new long[]{0x0006000004004000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodee503 = new BitSet(new long[]{0x0002000000004000L,0x000000000000000CL});
    public static final BitSet FOLLOW_tikzpathi_in_tikznodee505 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_OPTIONS_in_tikznode515 = new BitSet(new long[]{0x0004000004004000L});
    public static final BitSet FOLLOW_nodename_in_tikznode518 = new BitSet(new long[]{0x0004000004000000L});
    public static final BitSet FOLLOW_AT_in_tikznode522 = new BitSet(new long[]{0x0002000000004000L,0x000000000000000CL});
    public static final BitSet FOLLOW_coord_in_tikznode524 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_STRING_in_tikznode528 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_edgeop0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LPAR_in_nodename593 = new BitSet(new long[]{0x0008000000000000L});
    public static final BitSet FOLLOW_ID_in_nodename597 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_RPAR_in_nodename599 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_coord624 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_modifier_in_coord649 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_LPAR_in_coord654 = new BitSet(new long[]{0x0030000000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord656 = new BitSet(new long[]{0x0000000000100000L});
    public static final BitSet FOLLOW_KOMMA_in_coord658 = new BitSet(new long[]{0x0030000000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord660 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_RPAR_in_coord662 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_numberunit704 = new BitSet(new long[]{0x0000034000000002L,0x0000000000000030L});
    public static final BitSet FOLLOW_unit_in_numberunit710 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_unit0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_path_start0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SOMETHING_in_tikzpicture770 = new BitSet(new long[]{0x0040000000000040L});
    public static final BitSet FOLLOW_BEGINTP_in_tikzpicture773 = new BitSet(new long[]{0x0002000000003D80L});
    public static final BitSet FOLLOW_OPTIONS_in_tikzpicture775 = new BitSet(new long[]{0x0000000000003D80L});
    public static final BitSet FOLLOW_tikzbody_in_tikzpicture778 = new BitSet(new long[]{0x0000000000000080L});
    public static final BitSet FOLLOW_ENDTP_in_tikzpicture780 = new BitSet(new long[]{0x0040000000000002L});
    public static final BitSet FOLLOW_SOMETHING_in_tikzpicture783 = new BitSet(new long[]{0x0040000000000002L});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody806 = new BitSet(new long[]{0x0000000000003D02L});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody810 = new BitSet(new long[]{0x0000000000003D02L});
    public static final BitSet FOLLOW_tikznodee_in_tikzbody814 = new BitSet(new long[]{0x0000000000003D02L});
    public static final BitSet FOLLOW_BEGINSCOPE_in_tikzscope827 = new BitSet(new long[]{0x0002000000003F00L});
    public static final BitSet FOLLOW_OPTIONS_in_tikzscope829 = new BitSet(new long[]{0x0000000000003F00L});
    public static final BitSet FOLLOW_tikzbody_in_tikzscope832 = new BitSet(new long[]{0x0000000000000200L});
    public static final BitSet FOLLOW_ENDSCOPE_in_tikzscope834 = new BitSet(new long[]{0x0000000000000002L});

}