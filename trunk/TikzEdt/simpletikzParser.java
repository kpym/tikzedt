// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-11-25 01:48:24

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;

import org.antlr.runtime.tree.*;

public class simpletikzParser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BEGIN", "END", "BEGINTP", "ENDTP", "BEGINSCOPE", "ENDSCOPE", "NODE", "DRAW", "PATH", "FILL", "LPAR", "RPAR", "LBR", "RBR", "LBRR", "RBRR", "KOMMA", "SCALE", "EQU", "SEMIC", "COLON", "STYLESEP", "AT", "LABEL", "EVERYLOOP", "ST_INNERSEP", "ST_OUTERSEP", "ST_FILL", "ST_DRAW", "ST_SHAPE", "ST_MINSIZE", "ST_LINEWIDTH", "ST_DASHSTYLE", "LOOP", "IN", "OUT", "UN_PTS", "UN_CM", "IM_PATH", "IM_NODE", "IM_COORD", "IM_NODENAME", "IM_NUMBERUNIT", "IM_PICTURE", "IM_DOCUMENT", "IM_SCOPE", "IM_STARTTAG", "IM_ENDTAG", "OPTIONS", "STRING", "ID", "FLOAT", "INT", "SOMETHING", "EXPONENT", "COMMENT", "WS", "ESC_SEQ", "'node'", "'--'", "'edge'", "'->'", "'|-'", "'-|'", "'to'", "'+'", "'++'", "'ex'", "'mm'"
    };
    public static final int T__68=68;
    public static final int T__69=69;
    public static final int T__66=66;
    public static final int EXPONENT=58;
    public static final int T__67=67;
    public static final int T__64=64;
    public static final int IM_STARTTAG=50;
    public static final int T__65=65;
    public static final int T__62=62;
    public static final int T__63=63;
    public static final int IM_PATH=42;
    public static final int RBR=17;
    public static final int ST_DASHSTYLE=36;
    public static final int ST_LINEWIDTH=35;
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
    public static final int INT=56;
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
    public static final int WS=60;
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
    public static final int OPTIONS=52;
    public static final int STRING=53;
    public static final int DRAW=11;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "tikzscope", "coord", "tikzpath", "tikznode", "tikzpicture", 
        "nodename", "unit", "coord_modifier", "path_start", "tikznodei", 
        "tikznodee", "numberunit", "tikzbody", "edgeop", "tikzpathi", "number", 
        "tikzdocument", "coordornode"
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:71:1: tikzpath : path_start tikzpathi ;
    public final simpletikzParser.tikzpath_return tikzpath() throws RecognitionException {
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_return path_start1 = null;

        simpletikzParser.tikzpathi_return tikzpathi2 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzpath");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(71, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:2: ( path_start tikzpathi )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:72:4: path_start tikzpathi
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(72,14);
            pushFollow(FOLLOW_path_start_in_tikzpath414);
            path_start1=path_start();

            state._fsp--;

            dbg.location(72,16);
            pushFollow(FOLLOW_tikzpathi_in_tikzpath417);
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
        dbg.location(73, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:75:1: tikzpathi : ( OPTIONS )? coordornode ( coordornode | ( OPTIONS )? edgeop coordornode )* SEMIC -> ^( IM_PATH ( coordornode )+ ) ;
    public final simpletikzParser.tikzpathi_return tikzpathi() throws RecognitionException {
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token OPTIONS3=null;
        Token OPTIONS6=null;
        Token SEMIC9=null;
        simpletikzParser.coordornode_return coordornode4 = null;

        simpletikzParser.coordornode_return coordornode5 = null;

        simpletikzParser.edgeop_return edgeop7 = null;

        simpletikzParser.coordornode_return coordornode8 = null;


        Object OPTIONS3_tree=null;
        Object OPTIONS6_tree=null;
        Object SEMIC9_tree=null;
        RewriteRuleTokenStream stream_SEMIC=new RewriteRuleTokenStream(adaptor,"token SEMIC");
        RewriteRuleTokenStream stream_OPTIONS=new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_coordornode=new RewriteRuleSubtreeStream(adaptor,"rule coordornode");
        RewriteRuleSubtreeStream stream_edgeop=new RewriteRuleSubtreeStream(adaptor,"rule edgeop");
        try { dbg.enterRule(getGrammarFileName(), "tikzpathi");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(75, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:2: ( ( OPTIONS )? coordornode ( coordornode | ( OPTIONS )? edgeop coordornode )* SEMIC -> ^( IM_PATH ( coordornode )+ ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:4: ( OPTIONS )? coordornode ( coordornode | ( OPTIONS )? edgeop coordornode )* SEMIC
            {
            dbg.location(76,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:4: ( OPTIONS )?
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:4: OPTIONS
                    {
                    dbg.location(76,4);
                    OPTIONS3=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpathi428);  
                    stream_OPTIONS.add(OPTIONS3);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(1);}

            dbg.location(76,13);
            pushFollow(FOLLOW_coordornode_in_tikzpathi431);
            coordornode4=coordornode();

            state._fsp--;

            stream_coordornode.add(coordornode4.getTree());
            dbg.location(76,25);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:25: ( coordornode | ( OPTIONS )? edgeop coordornode )*
            try { dbg.enterSubRule(3);

            loop3:
            do {
                int alt3=3;
                try { dbg.enterDecision(3);

                int LA3_0 = input.LA(1);

                if ( (LA3_0==LPAR||LA3_0==62||(LA3_0>=69 && LA3_0<=70)) ) {
                    alt3=1;
                }
                else if ( (LA3_0==OPTIONS||(LA3_0>=63 && LA3_0<=68)) ) {
                    alt3=2;
                }


                } finally {dbg.exitDecision(3);}

                switch (alt3) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:26: coordornode
            	    {
            	    dbg.location(76,26);
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi434);
            	    coordornode5=coordornode();

            	    state._fsp--;

            	    stream_coordornode.add(coordornode5.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:40: ( OPTIONS )? edgeop coordornode
            	    {
            	    dbg.location(76,40);
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:40: ( OPTIONS )?
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

            	            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:40: OPTIONS
            	            {
            	            dbg.location(76,40);
            	            OPTIONS6=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpathi438);  
            	            stream_OPTIONS.add(OPTIONS6);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(2);}

            	    dbg.location(76,49);
            	    pushFollow(FOLLOW_edgeop_in_tikzpathi441);
            	    edgeop7=edgeop();

            	    state._fsp--;

            	    stream_edgeop.add(edgeop7.getTree());
            	    dbg.location(76,56);
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi443);
            	    coordornode8=coordornode();

            	    state._fsp--;

            	    stream_coordornode.add(coordornode8.getTree());

            	    }
            	    break;

            	default :
            	    break loop3;
                }
            } while (true);
            } finally {dbg.exitSubRule(3);}

            dbg.location(76,71);
            SEMIC9=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_tikzpathi448);  
            stream_SEMIC.add(SEMIC9);



            // AST REWRITE
            // elements: coordornode
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 76:79: -> ^( IM_PATH ( coordornode )+ )
            {
                dbg.location(76,82);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:76:82: ^( IM_PATH ( coordornode )+ )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(76,84);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(76,92);
                if ( !(stream_coordornode.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_coordornode.hasNext() ) {
                    dbg.location(76,92);
                    adaptor.addChild(root_1, stream_coordornode.nextTree());

                }
                stream_coordornode.reset();

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:1: coordornode : ( coord | tikznodei );
    public final simpletikzParser.coordornode_return coordornode() throws RecognitionException {
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coord_return coord10 = null;

        simpletikzParser.tikznodei_return tikznodei11 = null;



        try { dbg.enterRule(getGrammarFileName(), "coordornode");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(79, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:2: ( coord | tikznodei )
            int alt4=2;
            try { dbg.enterDecision(4);

            int LA4_0 = input.LA(1);

            if ( (LA4_0==LPAR||(LA4_0>=69 && LA4_0<=70)) ) {
                alt4=1;
            }
            else if ( (LA4_0==62) ) {
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:4: coord
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(80,4);
                    pushFollow(FOLLOW_coord_in_coordornode471);
                    coord10=coord();

                    state._fsp--;

                    adaptor.addChild(root_0, coord10.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:12: tikznodei
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(80,12);
                    pushFollow(FOLLOW_tikznodei_in_coordornode475);
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
        dbg.location(81, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:1: tikznodei : 'node' tikznode ;
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
        dbg.location(83, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:2: ( 'node' tikznode )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:4: 'node' tikznode
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(84,10);
            string_literal12=(Token)match(input,62,FOLLOW_62_in_tikznodei487); 
            dbg.location(84,12);
            pushFollow(FOLLOW_tikznode_in_tikznodei490);
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
        dbg.location(85, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:1: tikznodee : NODE tikznode tikzpathi ;
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
        dbg.location(86, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:2: ( NODE tikznode tikzpathi )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:4: NODE tikznode tikzpathi
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(87,4);
            NODE14=(Token)match(input,NODE,FOLLOW_NODE_in_tikznodee500); 
            NODE14_tree = (Object)adaptor.create(NODE14);
            adaptor.addChild(root_0, NODE14_tree);

            dbg.location(87,9);
            pushFollow(FOLLOW_tikznode_in_tikznodee502);
            tikznode15=tikznode();

            state._fsp--;

            adaptor.addChild(root_0, tikznode15.getTree());
            dbg.location(87,18);
            pushFollow(FOLLOW_tikzpathi_in_tikznodee504);
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
        dbg.location(88, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:1: tikznode : ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING ) ;
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
        dbg.location(89, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:2: ( ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING -> ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:4: ( OPTIONS )? ( nodename )? ( 'at' coord )? STRING
            {
            dbg.location(90,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:4: ( OPTIONS )?
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:4: OPTIONS
                    {
                    dbg.location(90,4);
                    OPTIONS17=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikznode514);  
                    stream_OPTIONS.add(OPTIONS17);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(5);}

            dbg.location(90,13);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:13: ( nodename )?
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:13: nodename
                    {
                    dbg.location(90,13);
                    pushFollow(FOLLOW_nodename_in_tikznode517);
                    nodename18=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename18.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(6);}

            dbg.location(90,23);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:23: ( 'at' coord )?
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:24: 'at' coord
                    {
                    dbg.location(90,24);
                    string_literal19=(Token)match(input,AT,FOLLOW_AT_in_tikznode521);  
                    stream_AT.add(string_literal19);

                    dbg.location(90,29);
                    pushFollow(FOLLOW_coord_in_tikznode523);
                    coord20=coord();

                    state._fsp--;

                    stream_coord.add(coord20.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(7);}

            dbg.location(90,37);
            STRING21=(Token)match(input,STRING,FOLLOW_STRING_in_tikznode527);  
            stream_STRING.add(STRING21);



            // AST REWRITE
            // elements: nodename, STRING, coord, OPTIONS
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 90:45: -> ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING )
            {
                dbg.location(90,48);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:48: ^( IM_NODE ( OPTIONS )? ( nodename )? ( coord )? STRING )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(90,50);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODE, "IM_NODE"), root_1);

                dbg.location(90,58);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:58: ( OPTIONS )?
                if ( stream_OPTIONS.hasNext() ) {
                    dbg.location(90,58);
                    adaptor.addChild(root_1, stream_OPTIONS.nextNode());

                }
                stream_OPTIONS.reset();
                dbg.location(90,67);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:67: ( nodename )?
                if ( stream_nodename.hasNext() ) {
                    dbg.location(90,67);
                    adaptor.addChild(root_1, stream_nodename.nextTree());

                }
                stream_nodename.reset();
                dbg.location(90,77);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:77: ( coord )?
                if ( stream_coord.hasNext() ) {
                    dbg.location(90,77);
                    adaptor.addChild(root_1, stream_coord.nextTree());

                }
                stream_coord.reset();
                dbg.location(90,84);
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
        dbg.location(91, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:1: edgeop : ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' );
    public final simpletikzParser.edgeop_return edgeop() throws RecognitionException {
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set22=null;

        Object set22_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "edgeop");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(93, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:2: ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(94,2);
            set22=(Token)input.LT(1);
            if ( (input.LA(1)>=63 && input.LA(1)<=68) ) {
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
        dbg.location(95, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:1: nodename : lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) ;
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
        dbg.location(97, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:2: (lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:4: lc= LPAR id= ID RPAR
            {
            dbg.location(98,6);
            lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_nodename595);  
            stream_LPAR.add(lc);

            dbg.location(98,14);
            id=(Token)match(input,ID,FOLLOW_ID_in_nodename599);  
            stream_ID.add(id);

            dbg.location(98,18);
            RPAR23=(Token)match(input,RPAR,FOLLOW_RPAR_in_nodename601);  
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
            // 98:24: -> ^( IM_NODENAME[$lc] $id)
            {
                dbg.location(98,27);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:27: ^( IM_NODENAME[$lc] $id)
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(98,29);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODENAME, lc), root_1);

                dbg.location(98,46);
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
        dbg.location(99, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:101:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) );
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
        dbg.location(101, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) )
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
            else if ( ((LA9_0>=69 && LA9_0<=70)) ) {
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:6: nodename
                    {
                    dbg.location(102,6);
                    pushFollow(FOLLOW_nodename_in_coord626);
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
                    // 102:23: -> ^( IM_COORD nodename )
                    {
                        dbg.location(102,26);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:26: ^( IM_COORD nodename )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(102,28);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, "IM_COORD"), root_1);

                        dbg.location(102,37);
                        adaptor.addChild(root_1, stream_nodename.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    {
                    dbg.location(103,5);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:7: ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR
                    {
                    dbg.location(103,7);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:7: ( coord_modifier )?
                    int alt8=2;
                    try { dbg.enterSubRule(8);
                    try { dbg.enterDecision(8);

                    int LA8_0 = input.LA(1);

                    if ( ((LA8_0>=69 && LA8_0<=70)) ) {
                        alt8=1;
                    }
                    } finally {dbg.exitDecision(8);}

                    switch (alt8) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:7: coord_modifier
                            {
                            dbg.location(103,7);
                            pushFollow(FOLLOW_coord_modifier_in_coord650);
                            coord_modifier25=coord_modifier();

                            state._fsp--;

                            stream_coord_modifier.add(coord_modifier25.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(8);}

                    dbg.location(103,25);
                    lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_coord655);  
                    stream_LPAR.add(lc);

                    dbg.location(103,31);
                    pushFollow(FOLLOW_numberunit_in_coord657);
                    numberunit26=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit26.getTree());
                    dbg.location(103,42);
                    KOMMA27=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_coord659);  
                    stream_KOMMA.add(KOMMA27);

                    dbg.location(103,48);
                    pushFollow(FOLLOW_numberunit_in_coord661);
                    numberunit28=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit28.getTree());
                    dbg.location(103,59);
                    RPAR29=(Token)match(input,RPAR,FOLLOW_RPAR_in_coord663);  
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
                    // 103:66: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    {
                        dbg.location(103,69);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:69: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(103,71);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, lc), root_1);

                        dbg.location(103,85);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:103:85: ( coord_modifier )?
                        if ( stream_coord_modifier.hasNext() ) {
                            dbg.location(103,85);
                            adaptor.addChild(root_1, stream_coord_modifier.nextTree());

                        }
                        stream_coord_modifier.reset();
                        dbg.location(103,101);
                        if ( !(stream_numberunit.hasNext()) ) {
                            throw new RewriteEarlyExitException();
                        }
                        while ( stream_numberunit.hasNext() ) {
                            dbg.location(103,101);
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
        dbg.location(104, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:106:1: coord_modifier : ( '+' | '++' );
    public final simpletikzParser.coord_modifier_return coord_modifier() throws RecognitionException {
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set30=null;

        Object set30_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "coord_modifier");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(106, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:2: ( '+' | '++' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(107,2);
            set30=(Token)input.LT(1);
            if ( (input.LA(1)>=69 && input.LA(1)<=70) ) {
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
        dbg.location(108, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:110:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public final simpletikzParser.numberunit_return numberunit() throws RecognitionException {
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.number_return number31 = null;

        simpletikzParser.unit_return unit32 = null;


        RewriteRuleSubtreeStream stream_unit=new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
        try { dbg.enterRule(getGrammarFileName(), "numberunit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(110, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:4: number ( unit )?
            {
            dbg.location(111,4);
            pushFollow(FOLLOW_number_in_numberunit705);
            number31=number();

            state._fsp--;

            stream_number.add(number31.getTree());
            dbg.location(111,11);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:11: ( unit )?
            int alt10=2;
            try { dbg.enterSubRule(10);
            try { dbg.enterDecision(10);

            int LA10_0 = input.LA(1);

            if ( (LA10_0==IN||(LA10_0>=UN_PTS && LA10_0<=UN_CM)||(LA10_0>=71 && LA10_0<=72)) ) {
                alt10=1;
            }
            } finally {dbg.exitDecision(10);}

            switch (alt10) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:11: unit
                    {
                    dbg.location(111,11);
                    pushFollow(FOLLOW_unit_in_numberunit707);
                    unit32=unit();

                    state._fsp--;

                    stream_unit.add(unit32.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(10);}



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
            // 111:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            {
                dbg.location(111,20);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:20: ^( IM_NUMBERUNIT number ( unit )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(111,22);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

                dbg.location(111,36);
                adaptor.addChild(root_1, stream_number.nextTree());
                dbg.location(111,43);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:43: ( unit )?
                if ( stream_unit.hasNext() ) {
                    dbg.location(111,43);
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
        dbg.location(112, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:1: number : ( FLOAT | INT ) ;
    public final simpletikzParser.number_return number() throws RecognitionException {
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set33=null;

        Object set33_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "number");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(113, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:114:2: ( ( FLOAT | INT ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:114:4: ( FLOAT | INT )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(114,4);
            set33=(Token)input.LT(1);
            if ( (input.LA(1)>=FLOAT && input.LA(1)<=INT) ) {
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' );
    public final simpletikzParser.unit_return unit() throws RecognitionException {
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set34=null;

        Object set34_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(116, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(117,2);
            set34=(Token)input.LT(1);
            if ( input.LA(1)==IN||(input.LA(1)>=UN_PTS && input.LA(1)<=UN_CM)||(input.LA(1)>=71 && input.LA(1)<=72) ) {
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
        dbg.location(118, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:1: path_start : ( DRAW | FILL | PATH );
    public final simpletikzParser.path_start_return path_start() throws RecognitionException {
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set35=null;

        Object set35_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "path_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(120, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:2: ( DRAW | FILL | PATH )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(121,2);
            set35=(Token)input.LT(1);
            if ( (input.LA(1)>=DRAW && input.LA(1)<=FILL) ) {
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
        dbg.location(122, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "path_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "path_start"

    public static class tikzdocument_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzdocument"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:1: tikzdocument : ( SOMETHING )* tikzpicture ( SOMETHING )* -> ^( IM_DOCUMENT tikzpicture ) ;
    public final simpletikzParser.tikzdocument_return tikzdocument() throws RecognitionException {
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token SOMETHING36=null;
        Token SOMETHING38=null;
        simpletikzParser.tikzpicture_return tikzpicture37 = null;


        Object SOMETHING36_tree=null;
        Object SOMETHING38_tree=null;
        RewriteRuleTokenStream stream_SOMETHING=new RewriteRuleTokenStream(adaptor,"token SOMETHING");
        RewriteRuleSubtreeStream stream_tikzpicture=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        try { dbg.enterRule(getGrammarFileName(), "tikzdocument");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(124, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:2: ( ( SOMETHING )* tikzpicture ( SOMETHING )* -> ^( IM_DOCUMENT tikzpicture ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:4: ( SOMETHING )* tikzpicture ( SOMETHING )*
            {
            dbg.location(125,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:4: ( SOMETHING )*
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

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:4: SOMETHING
            	    {
            	    dbg.location(125,4);
            	    SOMETHING36=(Token)match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzdocument793);  
            	    stream_SOMETHING.add(SOMETHING36);


            	    }
            	    break;

            	default :
            	    break loop11;
                }
            } while (true);
            } finally {dbg.exitSubRule(11);}

            dbg.location(125,15);
            pushFollow(FOLLOW_tikzpicture_in_tikzdocument796);
            tikzpicture37=tikzpicture();

            state._fsp--;

            stream_tikzpicture.add(tikzpicture37.getTree());
            dbg.location(125,28);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:28: ( SOMETHING )*
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

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:28: SOMETHING
            	    {
            	    dbg.location(125,28);
            	    SOMETHING38=(Token)match(input,SOMETHING,FOLLOW_SOMETHING_in_tikzdocument799);  
            	    stream_SOMETHING.add(SOMETHING38);


            	    }
            	    break;

            	default :
            	    break loop12;
                }
            } while (true);
            } finally {dbg.exitSubRule(12);}



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
            // 125:40: -> ^( IM_DOCUMENT tikzpicture )
            {
                dbg.location(125,43);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:43: ^( IM_DOCUMENT tikzpicture )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(125,45);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

                dbg.location(125,57);
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
        dbg.location(126, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:1: tikzpicture : BEGINTP ( OPTIONS )? ( tikzbody )? ENDTP -> ^( IM_PICTURE ( tikzbody )? ) ;
    public final simpletikzParser.tikzpicture_return tikzpicture() throws RecognitionException {
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGINTP39=null;
        Token OPTIONS40=null;
        Token ENDTP42=null;
        simpletikzParser.tikzbody_return tikzbody41 = null;


        Object BEGINTP39_tree=null;
        Object OPTIONS40_tree=null;
        Object ENDTP42_tree=null;
        RewriteRuleTokenStream stream_BEGINTP=new RewriteRuleTokenStream(adaptor,"token BEGINTP");
        RewriteRuleTokenStream stream_ENDTP=new RewriteRuleTokenStream(adaptor,"token ENDTP");
        RewriteRuleTokenStream stream_OPTIONS=new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        try { dbg.enterRule(getGrammarFileName(), "tikzpicture");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(128, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:2: ( BEGINTP ( OPTIONS )? ( tikzbody )? ENDTP -> ^( IM_PICTURE ( tikzbody )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:5: BEGINTP ( OPTIONS )? ( tikzbody )? ENDTP
            {
            dbg.location(129,5);
            BEGINTP39=(Token)match(input,BEGINTP,FOLLOW_BEGINTP_in_tikzpicture822);  
            stream_BEGINTP.add(BEGINTP39);

            dbg.location(129,13);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:13: ( OPTIONS )?
            int alt13=2;
            try { dbg.enterSubRule(13);
            try { dbg.enterDecision(13);

            int LA13_0 = input.LA(1);

            if ( (LA13_0==OPTIONS) ) {
                alt13=1;
            }
            } finally {dbg.exitDecision(13);}

            switch (alt13) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:13: OPTIONS
                    {
                    dbg.location(129,13);
                    OPTIONS40=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzpicture824);  
                    stream_OPTIONS.add(OPTIONS40);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(13);}

            dbg.location(129,22);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:22: ( tikzbody )?
            int alt14=2;
            try { dbg.enterSubRule(14);
            try { dbg.enterDecision(14);

            int LA14_0 = input.LA(1);

            if ( (LA14_0==BEGINSCOPE||(LA14_0>=NODE && LA14_0<=FILL)) ) {
                alt14=1;
            }
            } finally {dbg.exitDecision(14);}

            switch (alt14) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:22: tikzbody
                    {
                    dbg.location(129,22);
                    pushFollow(FOLLOW_tikzbody_in_tikzpicture827);
                    tikzbody41=tikzbody();

                    state._fsp--;

                    stream_tikzbody.add(tikzbody41.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(14);}

            dbg.location(129,32);
            ENDTP42=(Token)match(input,ENDTP,FOLLOW_ENDTP_in_tikzpicture830);  
            stream_ENDTP.add(ENDTP42);



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
            // 129:39: -> ^( IM_PICTURE ( tikzbody )? )
            {
                dbg.location(129,42);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:42: ^( IM_PICTURE ( tikzbody )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(129,44);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PICTURE, "IM_PICTURE"), root_1);

                dbg.location(129,55);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:55: ( tikzbody )?
                if ( stream_tikzbody.hasNext() ) {
                    dbg.location(129,55);
                    adaptor.addChild(root_1, stream_tikzbody.nextTree());

                }
                stream_tikzbody.reset();

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:1: tikzbody : ( tikzscope | tikzpath | tikznodee )+ ;
    public final simpletikzParser.tikzbody_return tikzbody() throws RecognitionException {
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope43 = null;

        simpletikzParser.tikzpath_return tikzpath44 = null;

        simpletikzParser.tikznodee_return tikznodee45 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzbody");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(132, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:2: ( ( tikzscope | tikzpath | tikznodee )+ )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:4: ( tikzscope | tikzpath | tikznodee )+
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(133,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:4: ( tikzscope | tikzpath | tikznodee )+
            int cnt15=0;
            try { dbg.enterSubRule(15);

            loop15:
            do {
                int alt15=4;
                try { dbg.enterDecision(15);

                switch ( input.LA(1) ) {
                case BEGINSCOPE:
                    {
                    alt15=1;
                    }
                    break;
                case DRAW:
                case PATH:
                case FILL:
                    {
                    alt15=2;
                    }
                    break;
                case NODE:
                    {
                    alt15=3;
                    }
                    break;

                }

                } finally {dbg.exitDecision(15);}

                switch (alt15) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:6: tikzscope
            	    {
            	    dbg.location(133,6);
            	    pushFollow(FOLLOW_tikzscope_in_tikzbody853);
            	    tikzscope43=tikzscope();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzscope43.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:18: tikzpath
            	    {
            	    dbg.location(133,18);
            	    pushFollow(FOLLOW_tikzpath_in_tikzbody857);
            	    tikzpath44=tikzpath();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzpath44.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:29: tikznodee
            	    {
            	    dbg.location(133,29);
            	    pushFollow(FOLLOW_tikznodee_in_tikzbody861);
            	    tikznodee45=tikznodee();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikznodee45.getTree());

            	    }
            	    break;

            	default :
            	    if ( cnt15 >= 1 ) break loop15;
                        EarlyExitException eee =
                            new EarlyExitException(15, input);
                        dbg.recognitionException(eee);

                        throw eee;
                }
                cnt15++;
            } while (true);
            } finally {dbg.exitSubRule(15);}


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
        dbg.location(134, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:136:1: tikzscope : BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE -> ^( IM_SCOPE tikzbody ) ;
    public final simpletikzParser.tikzscope_return tikzscope() throws RecognitionException {
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGINSCOPE46=null;
        Token OPTIONS47=null;
        Token ENDSCOPE49=null;
        simpletikzParser.tikzbody_return tikzbody48 = null;


        Object BEGINSCOPE46_tree=null;
        Object OPTIONS47_tree=null;
        Object ENDSCOPE49_tree=null;
        RewriteRuleTokenStream stream_ENDSCOPE=new RewriteRuleTokenStream(adaptor,"token ENDSCOPE");
        RewriteRuleTokenStream stream_BEGINSCOPE=new RewriteRuleTokenStream(adaptor,"token BEGINSCOPE");
        RewriteRuleTokenStream stream_OPTIONS=new RewriteRuleTokenStream(adaptor,"token OPTIONS");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        try { dbg.enterRule(getGrammarFileName(), "tikzscope");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(136, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:2: ( BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE -> ^( IM_SCOPE tikzbody ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:4: BEGINSCOPE ( OPTIONS )? tikzbody ENDSCOPE
            {
            dbg.location(137,4);
            BEGINSCOPE46=(Token)match(input,BEGINSCOPE,FOLLOW_BEGINSCOPE_in_tikzscope874);  
            stream_BEGINSCOPE.add(BEGINSCOPE46);

            dbg.location(137,15);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:15: ( OPTIONS )?
            int alt16=2;
            try { dbg.enterSubRule(16);
            try { dbg.enterDecision(16);

            int LA16_0 = input.LA(1);

            if ( (LA16_0==OPTIONS) ) {
                alt16=1;
            }
            } finally {dbg.exitDecision(16);}

            switch (alt16) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:15: OPTIONS
                    {
                    dbg.location(137,15);
                    OPTIONS47=(Token)match(input,OPTIONS,FOLLOW_OPTIONS_in_tikzscope876);  
                    stream_OPTIONS.add(OPTIONS47);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(16);}

            dbg.location(137,24);
            pushFollow(FOLLOW_tikzbody_in_tikzscope879);
            tikzbody48=tikzbody();

            state._fsp--;

            stream_tikzbody.add(tikzbody48.getTree());
            dbg.location(137,33);
            ENDSCOPE49=(Token)match(input,ENDSCOPE,FOLLOW_ENDSCOPE_in_tikzscope881);  
            stream_ENDSCOPE.add(ENDSCOPE49);



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
            // 137:43: -> ^( IM_SCOPE tikzbody )
            {
                dbg.location(137,46);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:46: ^( IM_SCOPE tikzbody )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(137,48);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_SCOPE, "IM_SCOPE"), root_1);

                dbg.location(137,57);
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
        dbg.location(138, 2);

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


 

    public static final BitSet FOLLOW_path_start_in_tikzpath414 = new BitSet(new long[]{0x4010000000004000L,0x0000000000000060L});
    public static final BitSet FOLLOW_tikzpathi_in_tikzpath417 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_OPTIONS_in_tikzpathi428 = new BitSet(new long[]{0x4010000000004000L,0x0000000000000060L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi431 = new BitSet(new long[]{0xC010000000804000L,0x000000000000007FL});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi434 = new BitSet(new long[]{0xC010000000804000L,0x000000000000007FL});
    public static final BitSet FOLLOW_OPTIONS_in_tikzpathi438 = new BitSet(new long[]{0xC010000000004000L,0x000000000000007FL});
    public static final BitSet FOLLOW_edgeop_in_tikzpathi441 = new BitSet(new long[]{0x4010000000004000L,0x0000000000000060L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi443 = new BitSet(new long[]{0xC010000000804000L,0x000000000000007FL});
    public static final BitSet FOLLOW_SEMIC_in_tikzpathi448 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_in_coordornode471 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikznodei_in_coordornode475 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_62_in_tikznodei487 = new BitSet(new long[]{0x0030000004004000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodei490 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_tikznodee500 = new BitSet(new long[]{0x0030000004004000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodee502 = new BitSet(new long[]{0x4010000000004000L,0x0000000000000060L});
    public static final BitSet FOLLOW_tikzpathi_in_tikznodee504 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_OPTIONS_in_tikznode514 = new BitSet(new long[]{0x0020000004004000L});
    public static final BitSet FOLLOW_nodename_in_tikznode517 = new BitSet(new long[]{0x0020000004000000L});
    public static final BitSet FOLLOW_AT_in_tikznode521 = new BitSet(new long[]{0x0000000000004000L,0x0000000000000060L});
    public static final BitSet FOLLOW_coord_in_tikznode523 = new BitSet(new long[]{0x0020000000000000L});
    public static final BitSet FOLLOW_STRING_in_tikznode527 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_edgeop0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LPAR_in_nodename595 = new BitSet(new long[]{0x0040000000000000L});
    public static final BitSet FOLLOW_ID_in_nodename599 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_RPAR_in_nodename601 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_coord626 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_modifier_in_coord650 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_LPAR_in_coord655 = new BitSet(new long[]{0x0180000000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord657 = new BitSet(new long[]{0x0000000000100000L});
    public static final BitSet FOLLOW_KOMMA_in_coord659 = new BitSet(new long[]{0x0180000000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord661 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_RPAR_in_coord663 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_number_in_numberunit705 = new BitSet(new long[]{0x0000034000000002L,0x0000000000000180L});
    public static final BitSet FOLLOW_unit_in_numberunit707 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_number730 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_unit0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_path_start0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SOMETHING_in_tikzdocument793 = new BitSet(new long[]{0x0200000000000040L});
    public static final BitSet FOLLOW_tikzpicture_in_tikzdocument796 = new BitSet(new long[]{0x0200000000000002L});
    public static final BitSet FOLLOW_SOMETHING_in_tikzdocument799 = new BitSet(new long[]{0x0200000000000002L});
    public static final BitSet FOLLOW_BEGINTP_in_tikzpicture822 = new BitSet(new long[]{0x0010000000003D80L});
    public static final BitSet FOLLOW_OPTIONS_in_tikzpicture824 = new BitSet(new long[]{0x0000000000003D80L});
    public static final BitSet FOLLOW_tikzbody_in_tikzpicture827 = new BitSet(new long[]{0x0000000000000080L});
    public static final BitSet FOLLOW_ENDTP_in_tikzpicture830 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody853 = new BitSet(new long[]{0x0000000000003D02L});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody857 = new BitSet(new long[]{0x0000000000003D02L});
    public static final BitSet FOLLOW_tikznodee_in_tikzbody861 = new BitSet(new long[]{0x0000000000003D02L});
    public static final BitSet FOLLOW_BEGINSCOPE_in_tikzscope874 = new BitSet(new long[]{0x0010000000003D00L});
    public static final BitSet FOLLOW_OPTIONS_in_tikzscope876 = new BitSet(new long[]{0x0000000000003D00L});
    public static final BitSet FOLLOW_tikzbody_in_tikzscope879 = new BitSet(new long[]{0x0000000000000200L});
    public static final BitSet FOLLOW_ENDSCOPE_in_tikzscope881 = new BitSet(new long[]{0x0000000000000002L});

}