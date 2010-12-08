// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-12-07 10:23:12

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;

import org.antlr.runtime.tree.*;

public class simpletikzParser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BEGIN", "END", "BEGINTP", "ENDTP", "BEGINSCOPE", "ENDSCOPE", "USETIKZLIB", "NODE", "DRAW", "PATH", "FILL", "LPAR", "RPAR", "LBR", "RBR", "LBRR", "RBRR", "KOMMA", "EQU", "SEMIC", "COLON", "IM_PATH", "IM_NODE", "IM_COORD", "IM_NODENAME", "IM_NUMBERUNIT", "IM_PICTURE", "IM_DOCUMENT", "IM_SCOPE", "IM_STARTTAG", "IM_ENDTAG", "IM_OPTIONS", "IM_OPTION_STYLE", "IM_OPTION_KV", "IM_ID", "IM_TIKZSET", "IM_USETIKZLIB", "IM_STRING", "ID", "FLOAT", "INT", "MATHSTRING", "EXPONENT", "COMMENT", "WS", "ESC_SEQ", "SOMETHING", "'node'", "'at'", "'--'", "'edge'", "'->'", "'|-'", "'-|'", "'to'", "'grid'", "'rectangle'", "'+'", "'++'", "'cm'", "'in'", "'ex'", "'mm'", "'pt'", "'\\\\'", "'\\\\tikzset'", "'/.style'"
    };
    public static final int T__68=68;
    public static final int T__69=69;
    public static final int T__66=66;
    public static final int EXPONENT=46;
    public static final int T__67=67;
    public static final int T__64=64;
    public static final int IM_STARTTAG=33;
    public static final int T__65=65;
    public static final int T__62=62;
    public static final int T__63=63;
    public static final int IM_PATH=25;
    public static final int RBR=18;
    public static final int IM_ID=38;
    public static final int FLOAT=43;
    public static final int BEGINTP=6;
    public static final int SOMETHING=50;
    public static final int ID=42;
    public static final int T__61=61;
    public static final int T__60=60;
    public static final int EOF=-1;
    public static final int MATHSTRING=45;
    public static final int LBR=17;
    public static final int IM_ENDTAG=34;
    public static final int IM_USETIKZLIB=40;
    public static final int T__55=55;
    public static final int T__56=56;
    public static final int T__57=57;
    public static final int IM_DOCUMENT=31;
    public static final int T__58=58;
    public static final int RBRR=20;
    public static final int ESC_SEQ=49;
    public static final int IM_STRING=41;
    public static final int T__51=51;
    public static final int T__52=52;
    public static final int T__53=53;
    public static final int LPAR=15;
    public static final int T__54=54;
    public static final int ENDTP=7;
    public static final int FILL=14;
    public static final int PATH=13;
    public static final int IM_TIKZSET=39;
    public static final int T__59=59;
    public static final int BEGIN=4;
    public static final int IM_OPTION_KV=37;
    public static final int COMMENT=47;
    public static final int IM_OPTIONS=35;
    public static final int IM_OPTION_STYLE=36;
    public static final int NODE=11;
    public static final int IM_COORD=27;
    public static final int IM_PICTURE=30;
    public static final int INT=44;
    public static final int BEGINSCOPE=8;
    public static final int LBRR=19;
    public static final int IM_NODE=26;
    public static final int USETIKZLIB=10;
    public static final int COLON=24;
    public static final int ENDSCOPE=9;
    public static final int IM_SCOPE=32;
    public static final int IM_NUMBERUNIT=29;
    public static final int WS=48;
    public static final int T__70=70;
    public static final int KOMMA=21;
    public static final int EQU=22;
    public static final int RPAR=16;
    public static final int END=5;
    public static final int SEMIC=23;
    public static final int IM_NODENAME=28;
    public static final int DRAW=12;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "tikzscope_start", "node_start", "tikzscope", "coordornode", 
        "option_style", "unit", "semicolon_end", "tikzbody", "path_start", 
        "tikzscope_end", "option", "edgeop", "tikz_set", "path_start_tag", 
        "tikznodei", "path_end", "tikzpicture_start", "tikz_something", 
        "coord_modifier", "tikzpicture", "string", "tikzpathi", "idd", "usetikzlib_start", 
        "numberunit", "tikzpath", "tikzdocument", "tikz_options", "nodename", 
        "tikzpicture_end", "usetikzlib", "tikznode", "number", "tikznodee", 
        "option_kv", "roundbr_end", "coord"
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:79:1: tikzdocument : ( tikz_something | usetikzlib )* tikzpicture ( tikz_something )* -> ^( IM_DOCUMENT ( usetikzlib )* tikzpicture ) ;
    public final simpletikzParser.tikzdocument_return tikzdocument() throws RecognitionException {
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikz_something_return tikz_something1 = null;

        simpletikzParser.usetikzlib_return usetikzlib2 = null;

        simpletikzParser.tikzpicture_return tikzpicture3 = null;

        simpletikzParser.tikz_something_return tikz_something4 = null;


        RewriteRuleSubtreeStream stream_tikz_something=new RewriteRuleSubtreeStream(adaptor,"rule tikz_something");
        RewriteRuleSubtreeStream stream_tikzpicture=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        RewriteRuleSubtreeStream stream_usetikzlib=new RewriteRuleSubtreeStream(adaptor,"rule usetikzlib");
        try { dbg.enterRule(getGrammarFileName(), "tikzdocument");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(79, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:2: ( ( tikz_something | usetikzlib )* tikzpicture ( tikz_something )* -> ^( IM_DOCUMENT ( usetikzlib )* tikzpicture ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:4: ( tikz_something | usetikzlib )* tikzpicture ( tikz_something )*
            {
            dbg.location(80,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:4: ( tikz_something | usetikzlib )*
            try { dbg.enterSubRule(1);

            loop1:
            do {
                int alt1=3;
                try { dbg.enterDecision(1);

                int LA1_0 = input.LA(1);

                if ( (LA1_0==ID||LA1_0==68) ) {
                    alt1=1;
                }
                else if ( (LA1_0==USETIKZLIB) ) {
                    alt1=2;
                }


                } finally {dbg.exitDecision(1);}

                switch (alt1) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:5: tikz_something
            	    {
            	    dbg.location(80,5);
            	    pushFollow(FOLLOW_tikz_something_in_tikzdocument327);
            	    tikz_something1=tikz_something();

            	    state._fsp--;

            	    stream_tikz_something.add(tikz_something1.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:22: usetikzlib
            	    {
            	    dbg.location(80,22);
            	    pushFollow(FOLLOW_usetikzlib_in_tikzdocument331);
            	    usetikzlib2=usetikzlib();

            	    state._fsp--;

            	    stream_usetikzlib.add(usetikzlib2.getTree());

            	    }
            	    break;

            	default :
            	    break loop1;
                }
            } while (true);
            } finally {dbg.exitSubRule(1);}

            dbg.location(80,35);
            pushFollow(FOLLOW_tikzpicture_in_tikzdocument335);
            tikzpicture3=tikzpicture();

            state._fsp--;

            stream_tikzpicture.add(tikzpicture3.getTree());
            dbg.location(80,48);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:48: ( tikz_something )*
            try { dbg.enterSubRule(2);

            loop2:
            do {
                int alt2=2;
                try { dbg.enterDecision(2);

                int LA2_0 = input.LA(1);

                if ( (LA2_0==ID||LA2_0==68) ) {
                    alt2=1;
                }


                } finally {dbg.exitDecision(2);}

                switch (alt2) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:48: tikz_something
            	    {
            	    dbg.location(80,48);
            	    pushFollow(FOLLOW_tikz_something_in_tikzdocument338);
            	    tikz_something4=tikz_something();

            	    state._fsp--;

            	    stream_tikz_something.add(tikz_something4.getTree());

            	    }
            	    break;

            	default :
            	    break loop2;
                }
            } while (true);
            } finally {dbg.exitSubRule(2);}



            // AST REWRITE
            // elements: usetikzlib, tikzpicture
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 80:65: -> ^( IM_DOCUMENT ( usetikzlib )* tikzpicture )
            {
                dbg.location(80,68);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:68: ^( IM_DOCUMENT ( usetikzlib )* tikzpicture )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(80,70);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

                dbg.location(80,82);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:80:82: ( usetikzlib )*
                while ( stream_usetikzlib.hasNext() ) {
                    dbg.location(80,82);
                    adaptor.addChild(root_1, stream_usetikzlib.nextTree());

                }
                stream_usetikzlib.reset();
                dbg.location(80,94);
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
        dbg.location(81, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzdocument");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzdocument"

    public static class tikzpath_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpath"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:83:1: tikzpath : path_start tikzpathi path_end -> ^( IM_PATH path_start tikzpathi path_end ) ;
    public final simpletikzParser.tikzpath_return tikzpath() throws RecognitionException {
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_return path_start5 = null;

        simpletikzParser.tikzpathi_return tikzpathi6 = null;

        simpletikzParser.path_end_return path_end7 = null;


        RewriteRuleSubtreeStream stream_path_end=new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_path_start=new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try { dbg.enterRule(getGrammarFileName(), "tikzpath");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(83, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:2: ( path_start tikzpathi path_end -> ^( IM_PATH path_start tikzpathi path_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:4: path_start tikzpathi path_end
            {
            dbg.location(84,4);
            pushFollow(FOLLOW_path_start_in_tikzpath363);
            path_start5=path_start();

            state._fsp--;

            stream_path_start.add(path_start5.getTree());
            dbg.location(84,15);
            pushFollow(FOLLOW_tikzpathi_in_tikzpath365);
            tikzpathi6=tikzpathi();

            state._fsp--;

            stream_tikzpathi.add(tikzpathi6.getTree());
            dbg.location(84,25);
            pushFollow(FOLLOW_path_end_in_tikzpath367);
            path_end7=path_end();

            state._fsp--;

            stream_path_end.add(path_end7.getTree());


            // AST REWRITE
            // elements: path_start, path_end, tikzpathi
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 84:34: -> ^( IM_PATH path_start tikzpathi path_end )
            {
                dbg.location(84,37);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:84:37: ^( IM_PATH path_start tikzpathi path_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(84,39);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(84,47);
                adaptor.addChild(root_1, stream_path_start.nextTree());
                dbg.location(84,58);
                adaptor.addChild(root_1, stream_tikzpathi.nextTree());
                dbg.location(84,68);
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
        dbg.location(85, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:86:1: path_end : SEMIC -> ^( IM_ENDTAG SEMIC ) ;
    public final simpletikzParser.path_end_return path_end() throws RecognitionException {
        simpletikzParser.path_end_return retval = new simpletikzParser.path_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token SEMIC8=null;

        Object SEMIC8_tree=null;
        RewriteRuleTokenStream stream_SEMIC=new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try { dbg.enterRule(getGrammarFileName(), "path_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(86, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:2: ( SEMIC -> ^( IM_ENDTAG SEMIC ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:4: SEMIC
            {
            dbg.location(87,4);
            SEMIC8=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_path_end390);  
            stream_SEMIC.add(SEMIC8);



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
            // 87:10: -> ^( IM_ENDTAG SEMIC )
            {
                dbg.location(87,13);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:87:13: ^( IM_ENDTAG SEMIC )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(87,15);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(87,25);
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
        dbg.location(88, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:90:1: tikzpathi : coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* ;
    public final simpletikzParser.tikzpathi_return tikzpathi() throws RecognitionException {
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coordornode_return coordornode9 = null;

        simpletikzParser.coordornode_return coordornode10 = null;

        simpletikzParser.tikz_options_return tikz_options11 = null;

        simpletikzParser.edgeop_return edgeop12 = null;

        simpletikzParser.coordornode_return coordornode13 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzpathi");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(90, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:2: ( coordornode ( coordornode | ( tikz_options )? edgeop coordornode )* )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:5: coordornode ( coordornode | ( tikz_options )? edgeop coordornode )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(91,5);
            pushFollow(FOLLOW_coordornode_in_tikzpathi410);
            coordornode9=coordornode();

            state._fsp--;

            adaptor.addChild(root_0, coordornode9.getTree());
            dbg.location(91,17);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:17: ( coordornode | ( tikz_options )? edgeop coordornode )*
            try { dbg.enterSubRule(4);

            loop4:
            do {
                int alt4=3;
                try { dbg.enterDecision(4);

                int LA4_0 = input.LA(1);

                if ( (LA4_0==LPAR||LA4_0==51||(LA4_0>=61 && LA4_0<=62)) ) {
                    alt4=1;
                }
                else if ( (LA4_0==LBR||(LA4_0>=53 && LA4_0<=60)) ) {
                    alt4=2;
                }


                } finally {dbg.exitDecision(4);}

                switch (alt4) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:18: coordornode
            	    {
            	    dbg.location(91,18);
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi413);
            	    coordornode10=coordornode();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode10.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:32: ( tikz_options )? edgeop coordornode
            	    {
            	    dbg.location(91,32);
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:32: ( tikz_options )?
            	    int alt3=2;
            	    try { dbg.enterSubRule(3);
            	    try { dbg.enterDecision(3);

            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0==LBR) ) {
            	        alt3=1;
            	    }
            	    } finally {dbg.exitDecision(3);}

            	    switch (alt3) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:91:32: tikz_options
            	            {
            	            dbg.location(91,32);
            	            pushFollow(FOLLOW_tikz_options_in_tikzpathi417);
            	            tikz_options11=tikz_options();

            	            state._fsp--;

            	            adaptor.addChild(root_0, tikz_options11.getTree());

            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(3);}

            	    dbg.location(91,52);
            	    pushFollow(FOLLOW_edgeop_in_tikzpathi420);
            	    edgeop12=edgeop();

            	    state._fsp--;

            	    dbg.location(91,54);
            	    pushFollow(FOLLOW_coordornode_in_tikzpathi423);
            	    coordornode13=coordornode();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode13.getTree());

            	    }
            	    break;

            	default :
            	    break loop4;
                }
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
        dbg.location(92, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:94:1: coordornode : ( coord | tikznodei );
    public final simpletikzParser.coordornode_return coordornode() throws RecognitionException {
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coord_return coord14 = null;

        simpletikzParser.tikznodei_return tikznodei15 = null;



        try { dbg.enterRule(getGrammarFileName(), "coordornode");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(94, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:95:2: ( coord | tikznodei )
            int alt5=2;
            try { dbg.enterDecision(5);

            int LA5_0 = input.LA(1);

            if ( (LA5_0==LPAR||(LA5_0>=61 && LA5_0<=62)) ) {
                alt5=1;
            }
            else if ( (LA5_0==51) ) {
                alt5=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 5, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(5);}

            switch (alt5) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:95:4: coord
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(95,4);
                    pushFollow(FOLLOW_coord_in_coordornode438);
                    coord14=coord();

                    state._fsp--;

                    adaptor.addChild(root_0, coord14.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:95:12: tikznodei
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(95,12);
                    pushFollow(FOLLOW_tikznodei_in_coordornode442);
                    tikznodei15=tikznodei();

                    state._fsp--;

                    adaptor.addChild(root_0, tikznodei15.getTree());

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
        dbg.location(96, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:98:1: tikznodei : 'node' tikznode ;
    public final simpletikzParser.tikznodei_return tikznodei() throws RecognitionException {
        simpletikzParser.tikznodei_return retval = new simpletikzParser.tikznodei_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal16=null;
        simpletikzParser.tikznode_return tikznode17 = null;


        Object string_literal16_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "tikznodei");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(98, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:99:2: ( 'node' tikznode )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:99:4: 'node' tikznode
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(99,10);
            string_literal16=(Token)match(input,51,FOLLOW_51_in_tikznodei454); 
            dbg.location(99,12);
            pushFollow(FOLLOW_tikznode_in_tikznodei457);
            tikznode17=tikznode();

            state._fsp--;

            adaptor.addChild(root_0, tikznode17.getTree());

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
        dbg.location(100, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:101:1: tikznodee : node_start tikznode ( tikzpathi )? path_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end ) ;
    public final simpletikzParser.tikznodee_return tikznodee() throws RecognitionException {
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.node_start_return node_start18 = null;

        simpletikzParser.tikznode_return tikznode19 = null;

        simpletikzParser.tikzpathi_return tikzpathi20 = null;

        simpletikzParser.path_end_return path_end21 = null;


        RewriteRuleSubtreeStream stream_node_start=new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_path_end=new RewriteRuleSubtreeStream(adaptor,"rule path_end");
        RewriteRuleSubtreeStream stream_tikznode=new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try { dbg.enterRule(getGrammarFileName(), "tikznodee");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(101, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:2: ( node_start tikznode ( tikzpathi )? path_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:4: node_start tikznode ( tikzpathi )? path_end
            {
            dbg.location(102,4);
            pushFollow(FOLLOW_node_start_in_tikznodee467);
            node_start18=node_start();

            state._fsp--;

            stream_node_start.add(node_start18.getTree());
            dbg.location(102,15);
            pushFollow(FOLLOW_tikznode_in_tikznodee469);
            tikznode19=tikznode();

            state._fsp--;

            stream_tikznode.add(tikznode19.getTree());
            dbg.location(102,24);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:24: ( tikzpathi )?
            int alt6=2;
            try { dbg.enterSubRule(6);
            try { dbg.enterDecision(6);

            int LA6_0 = input.LA(1);

            if ( (LA6_0==LPAR||LA6_0==51||(LA6_0>=61 && LA6_0<=62)) ) {
                alt6=1;
            }
            } finally {dbg.exitDecision(6);}

            switch (alt6) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:24: tikzpathi
                    {
                    dbg.location(102,24);
                    pushFollow(FOLLOW_tikzpathi_in_tikznodee471);
                    tikzpathi20=tikzpathi();

                    state._fsp--;

                    stream_tikzpathi.add(tikzpathi20.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(6);}

            dbg.location(102,35);
            pushFollow(FOLLOW_path_end_in_tikznodee474);
            path_end21=path_end();

            state._fsp--;

            stream_path_end.add(path_end21.getTree());


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
            // 102:44: -> ^( IM_PATH node_start tikznode ( tikzpathi )? path_end )
            {
                dbg.location(102,47);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:47: ^( IM_PATH node_start tikznode ( tikzpathi )? path_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(102,49);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(102,57);
                adaptor.addChild(root_1, stream_node_start.nextTree());
                dbg.location(102,68);
                adaptor.addChild(root_1, stream_tikznode.nextTree());
                dbg.location(102,77);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:102:77: ( tikzpathi )?
                if ( stream_tikzpathi.hasNext() ) {
                    dbg.location(102,77);
                    adaptor.addChild(root_1, stream_tikzpathi.nextTree());

                }
                stream_tikzpathi.reset();
                dbg.location(102,88);
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
        dbg.location(103, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public final simpletikzParser.node_start_return node_start() throws RecognitionException {
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token NODE22=null;

        Object NODE22_tree=null;
        RewriteRuleTokenStream stream_NODE=new RewriteRuleTokenStream(adaptor,"token NODE");

        try { dbg.enterRule(getGrammarFileName(), "node_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(104, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:4: NODE
            {
            dbg.location(105,4);
            NODE22=(Token)match(input,NODE,FOLLOW_NODE_in_node_start500);  
            stream_NODE.add(NODE22);



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
            // 105:9: -> ^( IM_STARTTAG NODE )
            {
                dbg.location(105,12);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:12: ^( IM_STARTTAG NODE )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(105,14);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(105,26);
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
        dbg.location(106, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:107:1: tikznode : ( nodename )? ( 'at' coord )? string -> ^( IM_NODE ( nodename )? ( coord )? string ) ;
    public final simpletikzParser.tikznode_return tikznode() throws RecognitionException {
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal24=null;
        simpletikzParser.nodename_return nodename23 = null;

        simpletikzParser.coord_return coord25 = null;

        simpletikzParser.string_return string26 = null;


        Object string_literal24_tree=null;
        RewriteRuleTokenStream stream_52=new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_coord=new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_string=new RewriteRuleSubtreeStream(adaptor,"rule string");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try { dbg.enterRule(getGrammarFileName(), "tikznode");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(107, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:2: ( ( nodename )? ( 'at' coord )? string -> ^( IM_NODE ( nodename )? ( coord )? string ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:4: ( nodename )? ( 'at' coord )? string
            {
            dbg.location(108,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:4: ( nodename )?
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:4: nodename
                    {
                    dbg.location(108,4);
                    pushFollow(FOLLOW_nodename_in_tikznode518);
                    nodename23=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename23.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(7);}

            dbg.location(108,14);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:14: ( 'at' coord )?
            int alt8=2;
            try { dbg.enterSubRule(8);
            try { dbg.enterDecision(8);

            int LA8_0 = input.LA(1);

            if ( (LA8_0==52) ) {
                alt8=1;
            }
            } finally {dbg.exitDecision(8);}

            switch (alt8) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:15: 'at' coord
                    {
                    dbg.location(108,15);
                    string_literal24=(Token)match(input,52,FOLLOW_52_in_tikznode522);  
                    stream_52.add(string_literal24);

                    dbg.location(108,20);
                    pushFollow(FOLLOW_coord_in_tikznode524);
                    coord25=coord();

                    state._fsp--;

                    stream_coord.add(coord25.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(8);}

            dbg.location(108,28);
            pushFollow(FOLLOW_string_in_tikznode528);
            string26=string();

            state._fsp--;

            stream_string.add(string26.getTree());


            // AST REWRITE
            // elements: coord, string, nodename
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 108:36: -> ^( IM_NODE ( nodename )? ( coord )? string )
            {
                dbg.location(108,39);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:39: ^( IM_NODE ( nodename )? ( coord )? string )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(108,41);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODE, "IM_NODE"), root_1);

                dbg.location(108,49);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:49: ( nodename )?
                if ( stream_nodename.hasNext() ) {
                    dbg.location(108,49);
                    adaptor.addChild(root_1, stream_nodename.nextTree());

                }
                stream_nodename.reset();
                dbg.location(108,59);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:108:59: ( coord )?
                if ( stream_coord.hasNext() ) {
                    dbg.location(108,59);
                    adaptor.addChild(root_1, stream_coord.nextTree());

                }
                stream_coord.reset();
                dbg.location(108,66);
                adaptor.addChild(root_1, stream_string.nextTree());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:111:1: edgeop : ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' | 'grid' | 'rectangle' );
    public final simpletikzParser.edgeop_return edgeop() throws RecognitionException {
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set27=null;

        Object set27_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "edgeop");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(111, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:2: ( '--' | 'edge' | '->' | '|-' | '-|' | 'to' | 'grid' | 'rectangle' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(112,2);
            set27=(Token)input.LT(1);
            if ( (input.LA(1)>=53 && input.LA(1)<=60) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set27));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:115:1: nodename : lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) ;
    public final simpletikzParser.nodename_return nodename() throws RecognitionException {
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token id=null;
        Token RPAR28=null;

        Object lc_tree=null;
        Object id_tree=null;
        Object RPAR28_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try { dbg.enterRule(getGrammarFileName(), "nodename");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(115, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:2: (lc= LPAR id= ID RPAR -> ^( IM_NODENAME[$lc] $id) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:4: lc= LPAR id= ID RPAR
            {
            dbg.location(116,6);
            lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_nodename601);  
            stream_LPAR.add(lc);

            dbg.location(116,14);
            id=(Token)match(input,ID,FOLLOW_ID_in_nodename605);  
            stream_ID.add(id);

            dbg.location(116,18);
            RPAR28=(Token)match(input,RPAR,FOLLOW_RPAR_in_nodename607);  
            stream_RPAR.add(RPAR28);



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
            // 116:24: -> ^( IM_NODENAME[$lc] $id)
            {
                dbg.location(116,27);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:27: ^( IM_NODENAME[$lc] $id)
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(116,29);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODENAME, lc), root_1);

                dbg.location(116,46);
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
        dbg.location(117, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:119:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) );
    public final simpletikzParser.coord_return coord() throws RecognitionException {
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token KOMMA32=null;
        Token RPAR34=null;
        simpletikzParser.nodename_return nodename29 = null;

        simpletikzParser.coord_modifier_return coord_modifier30 = null;

        simpletikzParser.numberunit_return numberunit31 = null;

        simpletikzParser.numberunit_return numberunit33 = null;


        Object lc_tree=null;
        Object KOMMA32_tree=null;
        Object RPAR34_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_numberunit=new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier=new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try { dbg.enterRule(getGrammarFileName(), "coord");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(119, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ ) )
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
            else if ( ((LA10_0>=61 && LA10_0<=62)) ) {
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:6: nodename
                    {
                    dbg.location(120,6);
                    pushFollow(FOLLOW_nodename_in_coord632);
                    nodename29=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename29.getTree());


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
                    // 120:23: -> ^( IM_COORD nodename )
                    {
                        dbg.location(120,26);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:26: ^( IM_COORD nodename )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(120,28);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, "IM_COORD"), root_1);

                        dbg.location(120,37);
                        adaptor.addChild(root_1, stream_nodename.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    {
                    dbg.location(121,5);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:5: ( ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR )
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:7: ( coord_modifier )? lc= LPAR numberunit KOMMA numberunit RPAR
                    {
                    dbg.location(121,7);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:7: ( coord_modifier )?
                    int alt9=2;
                    try { dbg.enterSubRule(9);
                    try { dbg.enterDecision(9);

                    int LA9_0 = input.LA(1);

                    if ( ((LA9_0>=61 && LA9_0<=62)) ) {
                        alt9=1;
                    }
                    } finally {dbg.exitDecision(9);}

                    switch (alt9) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:7: coord_modifier
                            {
                            dbg.location(121,7);
                            pushFollow(FOLLOW_coord_modifier_in_coord656);
                            coord_modifier30=coord_modifier();

                            state._fsp--;

                            stream_coord_modifier.add(coord_modifier30.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(9);}

                    dbg.location(121,25);
                    lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_coord661);  
                    stream_LPAR.add(lc);

                    dbg.location(121,31);
                    pushFollow(FOLLOW_numberunit_in_coord663);
                    numberunit31=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit31.getTree());
                    dbg.location(121,42);
                    KOMMA32=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_coord665);  
                    stream_KOMMA.add(KOMMA32);

                    dbg.location(121,48);
                    pushFollow(FOLLOW_numberunit_in_coord667);
                    numberunit33=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit33.getTree());
                    dbg.location(121,59);
                    RPAR34=(Token)match(input,RPAR,FOLLOW_RPAR_in_coord669);  
                    stream_RPAR.add(RPAR34);


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
                    // 121:66: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                    {
                        dbg.location(121,69);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:69: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(121,71);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, lc), root_1);

                        dbg.location(121,85);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:85: ( coord_modifier )?
                        if ( stream_coord_modifier.hasNext() ) {
                            dbg.location(121,85);
                            adaptor.addChild(root_1, stream_coord_modifier.nextTree());

                        }
                        stream_coord_modifier.reset();
                        dbg.location(121,101);
                        if ( !(stream_numberunit.hasNext()) ) {
                            throw new RewriteEarlyExitException();
                        }
                        while ( stream_numberunit.hasNext() ) {
                            dbg.location(121,101);
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
        dbg.location(122, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:124:1: coord_modifier : ( '+' | '++' );
    public final simpletikzParser.coord_modifier_return coord_modifier() throws RecognitionException {
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set35=null;

        Object set35_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "coord_modifier");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(124, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:2: ( '+' | '++' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(125,2);
            set35=(Token)input.LT(1);
            if ( (input.LA(1)>=61 && input.LA(1)<=62) ) {
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
        dbg.location(126, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:128:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public final simpletikzParser.numberunit_return numberunit() throws RecognitionException {
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.number_return number36 = null;

        simpletikzParser.unit_return unit37 = null;


        RewriteRuleSubtreeStream stream_unit=new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
        try { dbg.enterRule(getGrammarFileName(), "numberunit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(128, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:4: number ( unit )?
            {
            dbg.location(129,4);
            pushFollow(FOLLOW_number_in_numberunit711);
            number36=number();

            state._fsp--;

            stream_number.add(number36.getTree());
            dbg.location(129,11);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:11: ( unit )?
            int alt11=2;
            try { dbg.enterSubRule(11);
            try { dbg.enterDecision(11);

            int LA11_0 = input.LA(1);

            if ( ((LA11_0>=63 && LA11_0<=67)) ) {
                alt11=1;
            }
            } finally {dbg.exitDecision(11);}

            switch (alt11) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:11: unit
                    {
                    dbg.location(129,11);
                    pushFollow(FOLLOW_unit_in_numberunit713);
                    unit37=unit();

                    state._fsp--;

                    stream_unit.add(unit37.getTree());

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
            // 129:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            {
                dbg.location(129,20);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:20: ^( IM_NUMBERUNIT number ( unit )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(129,22);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

                dbg.location(129,36);
                adaptor.addChild(root_1, stream_number.nextTree());
                dbg.location(129,43);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:43: ( unit )?
                if ( stream_unit.hasNext() ) {
                    dbg.location(129,43);
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
        dbg.location(130, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:131:1: number : ( FLOAT | INT ) ;
    public final simpletikzParser.number_return number() throws RecognitionException {
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set38=null;

        Object set38_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "number");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(131, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:2: ( ( FLOAT | INT ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:132:4: ( FLOAT | INT )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(132,4);
            set38=(Token)input.LT(1);
            if ( (input.LA(1)>=FLOAT && input.LA(1)<=INT) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set38));
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
        dbg.location(133, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' );
    public final simpletikzParser.unit_return unit() throws RecognitionException {
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set39=null;

        Object set39_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(134, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:135:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(135,2);
            set39=(Token)input.LT(1);
            if ( (input.LA(1)>=63 && input.LA(1)<=67) ) {
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
        dbg.location(136, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:138:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public final simpletikzParser.path_start_return path_start() throws RecognitionException {
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag40 = null;


        RewriteRuleSubtreeStream stream_path_start_tag=new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try { dbg.enterRule(getGrammarFileName(), "path_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(138, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:4: path_start_tag
            {
            dbg.location(139,4);
            pushFollow(FOLLOW_path_start_tag_in_path_start780);
            path_start_tag40=path_start_tag();

            state._fsp--;

            stream_path_start_tag.add(path_start_tag40.getTree());


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
            // 139:19: -> ^( IM_STARTTAG path_start_tag )
            {
                dbg.location(139,22);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:139:22: ^( IM_STARTTAG path_start_tag )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(139,24);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(139,36);
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
        dbg.location(140, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:1: path_start_tag : ( DRAW | FILL | PATH );
    public final simpletikzParser.path_start_tag_return path_start_tag() throws RecognitionException {
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set41=null;

        Object set41_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "path_start_tag");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(141, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:142:2: ( DRAW | FILL | PATH )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(142,2);
            set41=(Token)input.LT(1);
            if ( (input.LA(1)>=DRAW && input.LA(1)<=FILL) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set41));
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
        dbg.location(143, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:145:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public final simpletikzParser.tikzpicture_return tikzpicture() throws RecognitionException {
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start42 = null;

        simpletikzParser.tikz_options_return tikz_options43 = null;

        simpletikzParser.tikzbody_return tikzbody44 = null;

        simpletikzParser.tikzpicture_end_return tikzpicture_end45 = null;


        RewriteRuleSubtreeStream stream_tikzpicture_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikzpicture");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(145, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            dbg.location(146,5);
            pushFollow(FOLLOW_tikzpicture_start_in_tikzpicture819);
            tikzpicture_start42=tikzpicture_start();

            state._fsp--;

            stream_tikzpicture_start.add(tikzpicture_start42.getTree());
            dbg.location(146,23);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:23: ( tikz_options )?
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:23: tikz_options
                    {
                    dbg.location(146,23);
                    pushFollow(FOLLOW_tikz_options_in_tikzpicture821);
                    tikz_options43=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options43.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(12);}

            dbg.location(146,37);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:37: ( tikzbody )?
            int alt13=2;
            try { dbg.enterSubRule(13);
            try { dbg.enterDecision(13);

            int LA13_0 = input.LA(1);

            if ( (LA13_0==BEGINSCOPE||(LA13_0>=NODE && LA13_0<=FILL)||LA13_0==ID||LA13_0==68) ) {
                alt13=1;
            }
            } finally {dbg.exitDecision(13);}

            switch (alt13) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:37: tikzbody
                    {
                    dbg.location(146,37);
                    pushFollow(FOLLOW_tikzbody_in_tikzpicture824);
                    tikzbody44=tikzbody();

                    state._fsp--;

                    stream_tikzbody.add(tikzbody44.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(13);}

            dbg.location(146,47);
            pushFollow(FOLLOW_tikzpicture_end_in_tikzpicture827);
            tikzpicture_end45=tikzpicture_end();

            state._fsp--;

            stream_tikzpicture_end.add(tikzpicture_end45.getTree());


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
            // 146:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            {
                dbg.location(146,67);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(146,69);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PICTURE, "IM_PICTURE"), root_1);

                dbg.location(146,80);
                adaptor.addChild(root_1, stream_tikzpicture_start.nextTree());
                dbg.location(146,98);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:98: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(146,98);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                dbg.location(146,112);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:112: ( tikzbody )?
                if ( stream_tikzbody.hasNext() ) {
                    dbg.location(146,112);
                    adaptor.addChild(root_1, stream_tikzbody.nextTree());

                }
                stream_tikzbody.reset();
                dbg.location(146,122);
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
        dbg.location(147, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:148:1: tikzpicture_start : BEGINTP -> ^( IM_STARTTAG BEGINTP ) ;
    public final simpletikzParser.tikzpicture_start_return tikzpicture_start() throws RecognitionException {
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGINTP46=null;

        Object BEGINTP46_tree=null;
        RewriteRuleTokenStream stream_BEGINTP=new RewriteRuleTokenStream(adaptor,"token BEGINTP");

        try { dbg.enterRule(getGrammarFileName(), "tikzpicture_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(148, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:149:2: ( BEGINTP -> ^( IM_STARTTAG BEGINTP ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:149:4: BEGINTP
            {
            dbg.location(149,4);
            BEGINTP46=(Token)match(input,BEGINTP,FOLLOW_BEGINTP_in_tikzpicture_start854);  
            stream_BEGINTP.add(BEGINTP46);



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
            // 149:12: -> ^( IM_STARTTAG BEGINTP )
            {
                dbg.location(149,15);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:149:15: ^( IM_STARTTAG BEGINTP )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(149,17);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(149,29);
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
        dbg.location(150, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:151:1: tikzpicture_end : ENDTP -> ^( IM_ENDTAG ENDTP ) ;
    public final simpletikzParser.tikzpicture_end_return tikzpicture_end() throws RecognitionException {
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token ENDTP47=null;

        Object ENDTP47_tree=null;
        RewriteRuleTokenStream stream_ENDTP=new RewriteRuleTokenStream(adaptor,"token ENDTP");

        try { dbg.enterRule(getGrammarFileName(), "tikzpicture_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(151, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:2: ( ENDTP -> ^( IM_ENDTAG ENDTP ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:4: ENDTP
            {
            dbg.location(152,4);
            ENDTP47=(Token)match(input,ENDTP,FOLLOW_ENDTP_in_tikzpicture_end872);  
            stream_ENDTP.add(ENDTP47);



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
            // 152:10: -> ^( IM_ENDTAG ENDTP )
            {
                dbg.location(152,13);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:152:13: ^( IM_ENDTAG ENDTP )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(152,15);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(152,25);
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
        dbg.location(153, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:154:1: tikzbody : ( tikzscope | tikzpath | tikznodee | tikz_something )+ ;
    public final simpletikzParser.tikzbody_return tikzbody() throws RecognitionException {
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope48 = null;

        simpletikzParser.tikzpath_return tikzpath49 = null;

        simpletikzParser.tikznodee_return tikznodee50 = null;

        simpletikzParser.tikz_something_return tikz_something51 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzbody");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(154, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:2: ( ( tikzscope | tikzpath | tikznodee | tikz_something )+ )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:4: ( tikzscope | tikzpath | tikznodee | tikz_something )+
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(155,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:4: ( tikzscope | tikzpath | tikznodee | tikz_something )+
            int cnt14=0;
            try { dbg.enterSubRule(14);

            loop14:
            do {
                int alt14=5;
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
                case ID:
                case 68:
                    {
                    alt14=4;
                    }
                    break;

                }

                } finally {dbg.exitDecision(14);}

                switch (alt14) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:6: tikzscope
            	    {
            	    dbg.location(155,6);
            	    pushFollow(FOLLOW_tikzscope_in_tikzbody892);
            	    tikzscope48=tikzscope();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzscope48.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:18: tikzpath
            	    {
            	    dbg.location(155,18);
            	    pushFollow(FOLLOW_tikzpath_in_tikzbody896);
            	    tikzpath49=tikzpath();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzpath49.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:29: tikznodee
            	    {
            	    dbg.location(155,29);
            	    pushFollow(FOLLOW_tikznodee_in_tikzbody900);
            	    tikznodee50=tikznodee();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikznodee50.getTree());

            	    }
            	    break;
            	case 4 :
            	    dbg.enterAlt(4);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:41: tikz_something
            	    {
            	    dbg.location(155,41);
            	    pushFollow(FOLLOW_tikz_something_in_tikzbody904);
            	    tikz_something51=tikz_something();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikz_something51.getTree());

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
        dbg.location(156, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzbody");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzbody"

    public static class tikz_something_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_something"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:158:1: tikz_something : ( ID | '\\\\' ID )+ ->;
    public final simpletikzParser.tikz_something_return tikz_something() throws RecognitionException {
        simpletikzParser.tikz_something_return retval = new simpletikzParser.tikz_something_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token ID52=null;
        Token char_literal53=null;
        Token ID54=null;

        Object ID52_tree=null;
        Object char_literal53_tree=null;
        Object ID54_tree=null;
        RewriteRuleTokenStream stream_68=new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try { dbg.enterRule(getGrammarFileName(), "tikz_something");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(158, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:159:2: ( ( ID | '\\\\' ID )+ ->)
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:159:4: ( ID | '\\\\' ID )+
            {
            dbg.location(159,4);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:159:4: ( ID | '\\\\' ID )+
            int cnt15=0;
            try { dbg.enterSubRule(15);

            loop15:
            do {
                int alt15=3;
                try { dbg.enterDecision(15);

                int LA15_0 = input.LA(1);

                if ( (LA15_0==ID) ) {
                    alt15=1;
                }
                else if ( (LA15_0==68) ) {
                    alt15=2;
                }


                } finally {dbg.exitDecision(15);}

                switch (alt15) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:159:6: ID
            	    {
            	    dbg.location(159,6);
            	    ID52=(Token)match(input,ID,FOLLOW_ID_in_tikz_something919);  
            	    stream_ID.add(ID52);


            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:159:11: '\\\\' ID
            	    {
            	    dbg.location(159,11);
            	    char_literal53=(Token)match(input,68,FOLLOW_68_in_tikz_something923);  
            	    stream_68.add(char_literal53);

            	    dbg.location(159,16);
            	    ID54=(Token)match(input,ID,FOLLOW_ID_in_tikz_something925);  
            	    stream_ID.add(ID54);


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
            // 159:22: ->
            {
                dbg.location(160,2);
                root_0 = null;
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
        dbg.location(160, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_something");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikz_something"

    public static class tikzscope_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzscope"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:162:1: tikzscope : tikzscope_start ( tikz_options )? tikzbody tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public final simpletikzParser.tikzscope_return tikzscope() throws RecognitionException {
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start55 = null;

        simpletikzParser.tikz_options_return tikz_options56 = null;

        simpletikzParser.tikzbody_return tikzbody57 = null;

        simpletikzParser.tikzscope_end_return tikzscope_end58 = null;


        RewriteRuleSubtreeStream stream_tikzscope_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikzscope");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(162, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:163:2: ( tikzscope_start ( tikz_options )? tikzbody tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:163:4: tikzscope_start ( tikz_options )? tikzbody tikzscope_end
            {
            dbg.location(163,4);
            pushFollow(FOLLOW_tikzscope_start_in_tikzscope942);
            tikzscope_start55=tikzscope_start();

            state._fsp--;

            stream_tikzscope_start.add(tikzscope_start55.getTree());
            dbg.location(163,20);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:163:20: ( tikz_options )?
            int alt16=2;
            try { dbg.enterSubRule(16);
            try { dbg.enterDecision(16);

            int LA16_0 = input.LA(1);

            if ( (LA16_0==LBR) ) {
                alt16=1;
            }
            } finally {dbg.exitDecision(16);}

            switch (alt16) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:163:20: tikz_options
                    {
                    dbg.location(163,20);
                    pushFollow(FOLLOW_tikz_options_in_tikzscope944);
                    tikz_options56=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options56.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(16);}

            dbg.location(163,34);
            pushFollow(FOLLOW_tikzbody_in_tikzscope947);
            tikzbody57=tikzbody();

            state._fsp--;

            stream_tikzbody.add(tikzbody57.getTree());
            dbg.location(163,43);
            pushFollow(FOLLOW_tikzscope_end_in_tikzscope949);
            tikzscope_end58=tikzscope_end();

            state._fsp--;

            stream_tikzscope_end.add(tikzscope_end58.getTree());


            // AST REWRITE
            // elements: tikzbody, tikz_options, tikzscope_start, tikzscope_end
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 163:58: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            {
                dbg.location(163,61);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:163:61: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(163,63);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_SCOPE, "IM_SCOPE"), root_1);

                dbg.location(163,72);
                adaptor.addChild(root_1, stream_tikzscope_start.nextTree());
                dbg.location(163,88);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:163:88: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(163,88);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                dbg.location(163,102);
                adaptor.addChild(root_1, stream_tikzbody.nextTree());
                dbg.location(163,111);
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
        dbg.location(164, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:165:1: tikzscope_start : BEGINSCOPE -> ^( IM_STARTTAG BEGINSCOPE ) ;
    public final simpletikzParser.tikzscope_start_return tikzscope_start() throws RecognitionException {
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGINSCOPE59=null;

        Object BEGINSCOPE59_tree=null;
        RewriteRuleTokenStream stream_BEGINSCOPE=new RewriteRuleTokenStream(adaptor,"token BEGINSCOPE");

        try { dbg.enterRule(getGrammarFileName(), "tikzscope_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(165, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:2: ( BEGINSCOPE -> ^( IM_STARTTAG BEGINSCOPE ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:4: BEGINSCOPE
            {
            dbg.location(166,4);
            BEGINSCOPE59=(Token)match(input,BEGINSCOPE,FOLLOW_BEGINSCOPE_in_tikzscope_start975);  
            stream_BEGINSCOPE.add(BEGINSCOPE59);



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
            // 166:15: -> ^( IM_STARTTAG BEGINSCOPE )
            {
                dbg.location(166,18);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:166:18: ^( IM_STARTTAG BEGINSCOPE )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(166,20);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(166,32);
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
        dbg.location(167, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:1: tikzscope_end : ENDSCOPE -> ^( IM_ENDTAG ENDSCOPE ) ;
    public final simpletikzParser.tikzscope_end_return tikzscope_end() throws RecognitionException {
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token ENDSCOPE60=null;

        Object ENDSCOPE60_tree=null;
        RewriteRuleTokenStream stream_ENDSCOPE=new RewriteRuleTokenStream(adaptor,"token ENDSCOPE");

        try { dbg.enterRule(getGrammarFileName(), "tikzscope_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(168, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:2: ( ENDSCOPE -> ^( IM_ENDTAG ENDSCOPE ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:4: ENDSCOPE
            {
            dbg.location(169,4);
            ENDSCOPE60=(Token)match(input,ENDSCOPE,FOLLOW_ENDSCOPE_in_tikzscope_end993);  
            stream_ENDSCOPE.add(ENDSCOPE60);



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
            // 169:13: -> ^( IM_ENDTAG ENDSCOPE )
            {
                dbg.location(169,16);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:16: ^( IM_ENDTAG ENDSCOPE )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(169,18);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(169,28);
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
        dbg.location(170, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:1: tikz_options : LBR ( option ( ',' option )* )? RBR -> ^( IM_OPTIONS ( option )* ) ;
    public final simpletikzParser.tikz_options_return tikz_options() throws RecognitionException {
        simpletikzParser.tikz_options_return retval = new simpletikzParser.tikz_options_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LBR61=null;
        Token char_literal63=null;
        Token RBR65=null;
        simpletikzParser.option_return option62 = null;

        simpletikzParser.option_return option64 = null;


        Object LBR61_tree=null;
        Object char_literal63_tree=null;
        Object RBR65_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleTokenStream stream_RBR=new RewriteRuleTokenStream(adaptor,"token RBR");
        RewriteRuleTokenStream stream_LBR=new RewriteRuleTokenStream(adaptor,"token LBR");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try { dbg.enterRule(getGrammarFileName(), "tikz_options");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(172, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:2: ( LBR ( option ( ',' option )* )? RBR -> ^( IM_OPTIONS ( option )* ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:5: LBR ( option ( ',' option )* )? RBR
            {
            dbg.location(173,5);
            LBR61=(Token)match(input,LBR,FOLLOW_LBR_in_tikz_options1013);  
            stream_LBR.add(LBR61);

            dbg.location(173,9);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:9: ( option ( ',' option )* )?
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:10: option ( ',' option )*
                    {
                    dbg.location(173,10);
                    pushFollow(FOLLOW_option_in_tikz_options1016);
                    option62=option();

                    state._fsp--;

                    stream_option.add(option62.getTree());
                    dbg.location(173,17);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:17: ( ',' option )*
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

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:18: ',' option
                    	    {
                    	    dbg.location(173,18);
                    	    char_literal63=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options1019);  
                    	    stream_KOMMA.add(char_literal63);

                    	    dbg.location(173,22);
                    	    pushFollow(FOLLOW_option_in_tikz_options1021);
                    	    option64=option();

                    	    state._fsp--;

                    	    stream_option.add(option64.getTree());

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

            dbg.location(173,33);
            RBR65=(Token)match(input,RBR,FOLLOW_RBR_in_tikz_options1027);  
            stream_RBR.add(RBR65);



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
            // 173:38: -> ^( IM_OPTIONS ( option )* )
            {
                dbg.location(173,41);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:41: ^( IM_OPTIONS ( option )* )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(173,43);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTIONS, "IM_OPTIONS"), root_1);

                dbg.location(173,54);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:54: ( option )*
                while ( stream_option.hasNext() ) {
                    dbg.location(173,54);
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
        dbg.location(174, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_options");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikz_options"

    public static class tikz_set_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_set"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:1: tikz_set : '\\\\tikzset' '{' ( option ( ',' option )* )? '}' -> ^( IM_TIKZSET ( option )* ) ;
    public final simpletikzParser.tikz_set_return tikz_set() throws RecognitionException {
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal66=null;
        Token char_literal67=null;
        Token char_literal69=null;
        Token char_literal71=null;
        simpletikzParser.option_return option68 = null;

        simpletikzParser.option_return option70 = null;


        Object string_literal66_tree=null;
        Object char_literal67_tree=null;
        Object char_literal69_tree=null;
        Object char_literal71_tree=null;
        RewriteRuleTokenStream stream_69=new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try { dbg.enterRule(getGrammarFileName(), "tikz_set");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(176, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:2: ( '\\\\tikzset' '{' ( option ( ',' option )* )? '}' -> ^( IM_TIKZSET ( option )* ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:4: '\\\\tikzset' '{' ( option ( ',' option )* )? '}'
            {
            dbg.location(177,4);
            string_literal66=(Token)match(input,69,FOLLOW_69_in_tikz_set1049);  
            stream_69.add(string_literal66);

            dbg.location(177,16);
            char_literal67=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikz_set1051);  
            stream_LBRR.add(char_literal67);

            dbg.location(177,20);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:20: ( option ( ',' option )* )?
            int alt20=2;
            try { dbg.enterSubRule(20);
            try { dbg.enterDecision(20);

            int LA20_0 = input.LA(1);

            if ( (LA20_0==ID) ) {
                alt20=1;
            }
            } finally {dbg.exitDecision(20);}

            switch (alt20) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:21: option ( ',' option )*
                    {
                    dbg.location(177,21);
                    pushFollow(FOLLOW_option_in_tikz_set1054);
                    option68=option();

                    state._fsp--;

                    stream_option.add(option68.getTree());
                    dbg.location(177,28);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:28: ( ',' option )*
                    try { dbg.enterSubRule(19);

                    loop19:
                    do {
                        int alt19=2;
                        try { dbg.enterDecision(19);

                        int LA19_0 = input.LA(1);

                        if ( (LA19_0==KOMMA) ) {
                            alt19=1;
                        }


                        } finally {dbg.exitDecision(19);}

                        switch (alt19) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:29: ',' option
                    	    {
                    	    dbg.location(177,29);
                    	    char_literal69=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_set1057);  
                    	    stream_KOMMA.add(char_literal69);

                    	    dbg.location(177,33);
                    	    pushFollow(FOLLOW_option_in_tikz_set1059);
                    	    option70=option();

                    	    state._fsp--;

                    	    stream_option.add(option70.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop19;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(19);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(20);}

            dbg.location(177,44);
            char_literal71=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikz_set1065);  
            stream_RBRR.add(char_literal71);



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
            // 177:48: -> ^( IM_TIKZSET ( option )* )
            {
                dbg.location(177,51);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:51: ^( IM_TIKZSET ( option )* )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(177,53);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_TIKZSET, "IM_TIKZSET"), root_1);

                dbg.location(177,64);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:64: ( option )*
                while ( stream_option.hasNext() ) {
                    dbg.location(177,64);
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
        dbg.location(178, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_set");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikz_set"

    public static class usetikzlib_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "usetikzlib"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:179:1: usetikzlib : usetikzlib_start idd ( ',' idd )* roundbr_end -> ^( IM_USETIKZLIB usetikzlib_start ( idd )* roundbr_end ) ;
    public final simpletikzParser.usetikzlib_return usetikzlib() throws RecognitionException {
        simpletikzParser.usetikzlib_return retval = new simpletikzParser.usetikzlib_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal74=null;
        simpletikzParser.usetikzlib_start_return usetikzlib_start72 = null;

        simpletikzParser.idd_return idd73 = null;

        simpletikzParser.idd_return idd75 = null;

        simpletikzParser.roundbr_end_return roundbr_end76 = null;


        Object char_literal74_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_usetikzlib_start=new RewriteRuleSubtreeStream(adaptor,"rule usetikzlib_start");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_roundbr_end=new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        try { dbg.enterRule(getGrammarFileName(), "usetikzlib");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(179, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:2: ( usetikzlib_start idd ( ',' idd )* roundbr_end -> ^( IM_USETIKZLIB usetikzlib_start ( idd )* roundbr_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:4: usetikzlib_start idd ( ',' idd )* roundbr_end
            {
            dbg.location(180,4);
            pushFollow(FOLLOW_usetikzlib_start_in_usetikzlib1084);
            usetikzlib_start72=usetikzlib_start();

            state._fsp--;

            stream_usetikzlib_start.add(usetikzlib_start72.getTree());
            dbg.location(180,21);
            pushFollow(FOLLOW_idd_in_usetikzlib1086);
            idd73=idd();

            state._fsp--;

            stream_idd.add(idd73.getTree());
            dbg.location(180,25);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:25: ( ',' idd )*
            try { dbg.enterSubRule(21);

            loop21:
            do {
                int alt21=2;
                try { dbg.enterDecision(21);

                int LA21_0 = input.LA(1);

                if ( (LA21_0==KOMMA) ) {
                    alt21=1;
                }


                } finally {dbg.exitDecision(21);}

                switch (alt21) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:26: ',' idd
            	    {
            	    dbg.location(180,26);
            	    char_literal74=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_usetikzlib1089);  
            	    stream_KOMMA.add(char_literal74);

            	    dbg.location(180,30);
            	    pushFollow(FOLLOW_idd_in_usetikzlib1091);
            	    idd75=idd();

            	    state._fsp--;

            	    stream_idd.add(idd75.getTree());

            	    }
            	    break;

            	default :
            	    break loop21;
                }
            } while (true);
            } finally {dbg.exitSubRule(21);}

            dbg.location(180,36);
            pushFollow(FOLLOW_roundbr_end_in_usetikzlib1095);
            roundbr_end76=roundbr_end();

            state._fsp--;

            stream_roundbr_end.add(roundbr_end76.getTree());


            // AST REWRITE
            // elements: idd, usetikzlib_start, roundbr_end
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 180:48: -> ^( IM_USETIKZLIB usetikzlib_start ( idd )* roundbr_end )
            {
                dbg.location(180,51);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:51: ^( IM_USETIKZLIB usetikzlib_start ( idd )* roundbr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(180,53);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_USETIKZLIB, "IM_USETIKZLIB"), root_1);

                dbg.location(180,67);
                adaptor.addChild(root_1, stream_usetikzlib_start.nextTree());
                dbg.location(180,84);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:180:84: ( idd )*
                while ( stream_idd.hasNext() ) {
                    dbg.location(180,84);
                    adaptor.addChild(root_1, stream_idd.nextTree());

                }
                stream_idd.reset();
                dbg.location(180,89);
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
        dbg.location(181, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:1: usetikzlib_start : USETIKZLIB '{' -> ^( IM_STARTTAG USETIKZLIB ) ;
    public final simpletikzParser.usetikzlib_start_return usetikzlib_start() throws RecognitionException {
        simpletikzParser.usetikzlib_start_return retval = new simpletikzParser.usetikzlib_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token USETIKZLIB77=null;
        Token char_literal78=null;

        Object USETIKZLIB77_tree=null;
        Object char_literal78_tree=null;
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_USETIKZLIB=new RewriteRuleTokenStream(adaptor,"token USETIKZLIB");

        try { dbg.enterRule(getGrammarFileName(), "usetikzlib_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(182, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:2: ( USETIKZLIB '{' -> ^( IM_STARTTAG USETIKZLIB ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:4: USETIKZLIB '{'
            {
            dbg.location(183,4);
            USETIKZLIB77=(Token)match(input,USETIKZLIB,FOLLOW_USETIKZLIB_in_usetikzlib_start1118);  
            stream_USETIKZLIB.add(USETIKZLIB77);

            dbg.location(183,15);
            char_literal78=(Token)match(input,LBRR,FOLLOW_LBRR_in_usetikzlib_start1120);  
            stream_LBRR.add(char_literal78);



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
            // 183:19: -> ^( IM_STARTTAG USETIKZLIB )
            {
                dbg.location(183,22);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:22: ^( IM_STARTTAG USETIKZLIB )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(183,24);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(183,36);
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
        dbg.location(184, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:185:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public final simpletikzParser.semicolon_end_return semicolon_end() throws RecognitionException {
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal79=null;

        Object char_literal79_tree=null;
        RewriteRuleTokenStream stream_SEMIC=new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try { dbg.enterRule(getGrammarFileName(), "semicolon_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(185, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:4: ';'
            {
            dbg.location(186,4);
            char_literal79=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_semicolon_end1139);  
            stream_SEMIC.add(char_literal79);



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
            // 186:8: -> ^( IM_ENDTAG ';' )
            {
                dbg.location(186,11);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:11: ^( IM_ENDTAG ';' )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(186,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(186,23);
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
        dbg.location(187, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public final simpletikzParser.roundbr_end_return roundbr_end() throws RecognitionException {
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal80=null;

        Object char_literal80_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");

        try { dbg.enterRule(getGrammarFileName(), "roundbr_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(188, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:189:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:189:4: '}'
            {
            dbg.location(189,4);
            char_literal80=(Token)match(input,RBRR,FOLLOW_RBRR_in_roundbr_end1157);  
            stream_RBRR.add(char_literal80);



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
            // 189:8: -> ^( IM_ENDTAG '}' )
            {
                dbg.location(189,11);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:189:11: ^( IM_ENDTAG '}' )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(189,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(189,23);
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
        dbg.location(190, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:1: option : ( option_style -> ^( IM_OPTION_STYLE option_style ) | option_kv -> ^( IM_OPTION_KV option_kv ) );
    public final simpletikzParser.option_return option() throws RecognitionException {
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.option_style_return option_style81 = null;

        simpletikzParser.option_kv_return option_kv82 = null;


        RewriteRuleSubtreeStream stream_option_style=new RewriteRuleSubtreeStream(adaptor,"rule option_style");
        RewriteRuleSubtreeStream stream_option_kv=new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try { dbg.enterRule(getGrammarFileName(), "option");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(192, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:193:2: ( option_style -> ^( IM_OPTION_STYLE option_style ) | option_kv -> ^( IM_OPTION_KV option_kv ) )
            int alt22=2;
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

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:193:4: option_style
                    {
                    dbg.location(193,4);
                    pushFollow(FOLLOW_option_style_in_option1177);
                    option_style81=option_style();

                    state._fsp--;

                    stream_option_style.add(option_style81.getTree());


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
                    // 193:19: -> ^( IM_OPTION_STYLE option_style )
                    {
                        dbg.location(193,22);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:193:22: ^( IM_OPTION_STYLE option_style )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(193,24);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

                        dbg.location(193,40);
                        adaptor.addChild(root_1, stream_option_style.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:194:5: option_kv
                    {
                    dbg.location(194,5);
                    pushFollow(FOLLOW_option_kv_in_option1193);
                    option_kv82=option_kv();

                    state._fsp--;

                    stream_option_kv.add(option_kv82.getTree());


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
                    // 194:16: -> ^( IM_OPTION_KV option_kv )
                    {
                        dbg.location(194,19);
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:194:19: ^( IM_OPTION_KV option_kv )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(194,21);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

                        dbg.location(194,34);
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
        dbg.location(195, 2);

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:197:1: option_kv : idd ( '=' ( idd | numberunit ) )? ;
    public final simpletikzParser.option_kv_return option_kv() throws RecognitionException {
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal84=null;
        simpletikzParser.idd_return idd83 = null;

        simpletikzParser.idd_return idd85 = null;

        simpletikzParser.numberunit_return numberunit86 = null;


        Object char_literal84_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "option_kv");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(197, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:2: ( idd ( '=' ( idd | numberunit ) )? )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:4: idd ( '=' ( idd | numberunit ) )?
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(198,4);
            pushFollow(FOLLOW_idd_in_option_kv1214);
            idd83=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd83.getTree());
            dbg.location(198,8);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:8: ( '=' ( idd | numberunit ) )?
            int alt24=2;
            try { dbg.enterSubRule(24);
            try { dbg.enterDecision(24);

            int LA24_0 = input.LA(1);

            if ( (LA24_0==EQU) ) {
                alt24=1;
            }
            } finally {dbg.exitDecision(24);}

            switch (alt24) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:9: '=' ( idd | numberunit )
                    {
                    dbg.location(198,12);
                    char_literal84=(Token)match(input,EQU,FOLLOW_EQU_in_option_kv1217); 
                    dbg.location(198,14);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:14: ( idd | numberunit )
                    int alt23=2;
                    try { dbg.enterSubRule(23);
                    try { dbg.enterDecision(23);

                    int LA23_0 = input.LA(1);

                    if ( (LA23_0==ID) ) {
                        alt23=1;
                    }
                    else if ( ((LA23_0>=FLOAT && LA23_0<=INT)) ) {
                        alt23=2;
                    }
                    else {
                        NoViableAltException nvae =
                            new NoViableAltException("", 23, 0, input);

                        dbg.recognitionException(nvae);
                        throw nvae;
                    }
                    } finally {dbg.exitDecision(23);}

                    switch (alt23) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:15: idd
                            {
                            dbg.location(198,15);
                            pushFollow(FOLLOW_idd_in_option_kv1221);
                            idd85=idd();

                            state._fsp--;

                            adaptor.addChild(root_0, idd85.getTree());

                            }
                            break;
                        case 2 :
                            dbg.enterAlt(2);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:21: numberunit
                            {
                            dbg.location(198,21);
                            pushFollow(FOLLOW_numberunit_in_option_kv1225);
                            numberunit86=numberunit();

                            state._fsp--;

                            adaptor.addChild(root_0, numberunit86.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(23);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(24);}


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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:200:1: option_style : idd '/.style' '=' '{' ( option ( ',' option )* )? '}' ;
    public final simpletikzParser.option_style_return option_style() throws RecognitionException {
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal88=null;
        Token char_literal89=null;
        Token char_literal90=null;
        Token char_literal92=null;
        Token char_literal94=null;
        simpletikzParser.idd_return idd87 = null;

        simpletikzParser.option_return option91 = null;

        simpletikzParser.option_return option93 = null;


        Object string_literal88_tree=null;
        Object char_literal89_tree=null;
        Object char_literal90_tree=null;
        Object char_literal92_tree=null;
        Object char_literal94_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "option_style");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(200, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:2: ( idd '/.style' '=' '{' ( option ( ',' option )* )? '}' )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:4: idd '/.style' '=' '{' ( option ( ',' option )* )? '}'
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(201,4);
            pushFollow(FOLLOW_idd_in_option_style1238);
            idd87=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd87.getTree());
            dbg.location(201,17);
            string_literal88=(Token)match(input,70,FOLLOW_70_in_option_style1240); 
            dbg.location(201,22);
            char_literal89=(Token)match(input,EQU,FOLLOW_EQU_in_option_style1243); 
            dbg.location(201,27);
            char_literal90=(Token)match(input,LBRR,FOLLOW_LBRR_in_option_style1246); 
            dbg.location(201,29);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:29: ( option ( ',' option )* )?
            int alt26=2;
            try { dbg.enterSubRule(26);
            try { dbg.enterDecision(26);

            int LA26_0 = input.LA(1);

            if ( (LA26_0==ID) ) {
                alt26=1;
            }
            } finally {dbg.exitDecision(26);}

            switch (alt26) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:30: option ( ',' option )*
                    {
                    dbg.location(201,30);
                    pushFollow(FOLLOW_option_in_option_style1250);
                    option91=option();

                    state._fsp--;

                    adaptor.addChild(root_0, option91.getTree());
                    dbg.location(201,37);
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:37: ( ',' option )*
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

                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:38: ',' option
                    	    {
                    	    dbg.location(201,38);
                    	    char_literal92=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_option_style1253); 
                    	    char_literal92_tree = (Object)adaptor.create(char_literal92);
                    	    adaptor.addChild(root_0, char_literal92_tree);

                    	    dbg.location(201,42);
                    	    pushFollow(FOLLOW_option_in_option_style1255);
                    	    option93=option();

                    	    state._fsp--;

                    	    adaptor.addChild(root_0, option93.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop25;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(25);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(26);}

            dbg.location(201,57);
            char_literal94=(Token)match(input,RBRR,FOLLOW_RBRR_in_option_style1262); 

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:205:1: idd : ID ( ID )* -> ^( IM_ID ( ID )* ) ;
    public final simpletikzParser.idd_return idd() throws RecognitionException {
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token ID95=null;
        Token ID96=null;

        Object ID95_tree=null;
        Object ID96_tree=null;
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try { dbg.enterRule(getGrammarFileName(), "idd");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(205, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:206:2: ( ID ( ID )* -> ^( IM_ID ( ID )* ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:206:4: ID ( ID )*
            {
            dbg.location(206,4);
            ID95=(Token)match(input,ID,FOLLOW_ID_in_idd1276);  
            stream_ID.add(ID95);

            dbg.location(206,7);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:206:7: ( ID )*
            try { dbg.enterSubRule(27);

            loop27:
            do {
                int alt27=2;
                try { dbg.enterDecision(27);

                int LA27_0 = input.LA(1);

                if ( (LA27_0==ID) ) {
                    alt27=1;
                }


                } finally {dbg.exitDecision(27);}

                switch (alt27) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:206:8: ID
            	    {
            	    dbg.location(206,8);
            	    ID96=(Token)match(input,ID,FOLLOW_ID_in_idd1279);  
            	    stream_ID.add(ID96);


            	    }
            	    break;

            	default :
            	    break loop27;
                }
            } while (true);
            } finally {dbg.exitSubRule(27);}



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
            // 206:13: -> ^( IM_ID ( ID )* )
            {
                dbg.location(206,16);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:206:16: ^( IM_ID ( ID )* )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(206,18);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ID, "IM_ID"), root_1);

                dbg.location(206,24);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:206:24: ( ID )*
                while ( stream_ID.hasNext() ) {
                    dbg.location(206,24);
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
        dbg.location(207, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "idd");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "idd"

    public static class string_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "string"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:209:1: string : '{' ( string | MATHSTRING | ID )* '}' -> ^( IM_STRING ) ;
    public final simpletikzParser.string_return string() throws RecognitionException {
        simpletikzParser.string_return retval = new simpletikzParser.string_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal97=null;
        Token MATHSTRING99=null;
        Token ID100=null;
        Token char_literal101=null;
        simpletikzParser.string_return string98 = null;


        Object char_literal97_tree=null;
        Object MATHSTRING99_tree=null;
        Object ID100_tree=null;
        Object char_literal101_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_MATHSTRING=new RewriteRuleTokenStream(adaptor,"token MATHSTRING");
        RewriteRuleSubtreeStream stream_string=new RewriteRuleSubtreeStream(adaptor,"rule string");
        try { dbg.enterRule(getGrammarFileName(), "string");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(209, 1);

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:210:2: ( '{' ( string | MATHSTRING | ID )* '}' -> ^( IM_STRING ) )
            dbg.enterAlt(1);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:210:4: '{' ( string | MATHSTRING | ID )* '}'
            {
            dbg.location(210,4);
            char_literal97=(Token)match(input,LBRR,FOLLOW_LBRR_in_string1301);  
            stream_LBRR.add(char_literal97);

            dbg.location(210,9);
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:210:9: ( string | MATHSTRING | ID )*
            try { dbg.enterSubRule(28);

            loop28:
            do {
                int alt28=4;
                try { dbg.enterDecision(28);

                switch ( input.LA(1) ) {
                case LBRR:
                    {
                    alt28=1;
                    }
                    break;
                case MATHSTRING:
                    {
                    alt28=2;
                    }
                    break;
                case ID:
                    {
                    alt28=3;
                    }
                    break;

                }

                } finally {dbg.exitDecision(28);}

                switch (alt28) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:210:10: string
            	    {
            	    dbg.location(210,10);
            	    pushFollow(FOLLOW_string_in_string1305);
            	    string98=string();

            	    state._fsp--;

            	    stream_string.add(string98.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:210:19: MATHSTRING
            	    {
            	    dbg.location(210,19);
            	    MATHSTRING99=(Token)match(input,MATHSTRING,FOLLOW_MATHSTRING_in_string1309);  
            	    stream_MATHSTRING.add(MATHSTRING99);


            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:210:32: ID
            	    {
            	    dbg.location(210,32);
            	    ID100=(Token)match(input,ID,FOLLOW_ID_in_string1313);  
            	    stream_ID.add(ID100);


            	    }
            	    break;

            	default :
            	    break loop28;
                }
            } while (true);
            } finally {dbg.exitSubRule(28);}

            dbg.location(210,37);
            char_literal101=(Token)match(input,RBRR,FOLLOW_RBRR_in_string1317);  
            stream_RBRR.add(char_literal101);



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
            // 210:41: -> ^( IM_STRING )
            {
                dbg.location(210,44);
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:210:44: ^( IM_STRING )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(210,46);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STRING, "IM_STRING"), root_1);

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
        dbg.location(211, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "string");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "string"

    // Delegated rules


    protected DFA22 dfa22 = new DFA22(this);
    static final String DFA22_eotS =
        "\5\uffff";
    static final String DFA22_eofS =
        "\5\uffff";
    static final String DFA22_minS =
        "\1\52\2\22\2\uffff";
    static final String DFA22_maxS =
        "\1\52\2\106\2\uffff";
    static final String DFA22_acceptS =
        "\3\uffff\1\2\1\1";
    static final String DFA22_specialS =
        "\5\uffff}>";
    static final String[] DFA22_transitionS = {
            "\1\1",
            "\1\3\1\uffff\3\3\23\uffff\1\2\33\uffff\1\4",
            "\1\3\1\uffff\3\3\23\uffff\1\2\33\uffff\1\4",
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
            return "192:1: option : ( option_style -> ^( IM_OPTION_STYLE option_style ) | option_kv -> ^( IM_OPTION_KV option_kv ) );";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
 

    public static final BitSet FOLLOW_tikz_something_in_tikzdocument327 = new BitSet(new long[]{0x0000040000000440L,0x0000000000000010L});
    public static final BitSet FOLLOW_usetikzlib_in_tikzdocument331 = new BitSet(new long[]{0x0000040000000440L,0x0000000000000010L});
    public static final BitSet FOLLOW_tikzpicture_in_tikzdocument335 = new BitSet(new long[]{0x0000040000000002L,0x0000000000000010L});
    public static final BitSet FOLLOW_tikz_something_in_tikzdocument338 = new BitSet(new long[]{0x0000040000000002L,0x0000000000000010L});
    public static final BitSet FOLLOW_path_start_in_tikzpath363 = new BitSet(new long[]{0x6008000000008000L});
    public static final BitSet FOLLOW_tikzpathi_in_tikzpath365 = new BitSet(new long[]{0x0000000000800000L});
    public static final BitSet FOLLOW_path_end_in_tikzpath367 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SEMIC_in_path_end390 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi410 = new BitSet(new long[]{0x7FE8000000028002L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi413 = new BitSet(new long[]{0x7FE8000000028002L});
    public static final BitSet FOLLOW_tikz_options_in_tikzpathi417 = new BitSet(new long[]{0x7FE8000000028000L});
    public static final BitSet FOLLOW_edgeop_in_tikzpathi420 = new BitSet(new long[]{0x6008000000008000L});
    public static final BitSet FOLLOW_coordornode_in_tikzpathi423 = new BitSet(new long[]{0x7FE8000000028002L});
    public static final BitSet FOLLOW_coord_in_coordornode438 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikznodei_in_coordornode442 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_51_in_tikznodei454 = new BitSet(new long[]{0x0010000000088000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodei457 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_node_start_in_tikznodee467 = new BitSet(new long[]{0x0010000000088000L});
    public static final BitSet FOLLOW_tikznode_in_tikznodee469 = new BitSet(new long[]{0x6008000000808000L});
    public static final BitSet FOLLOW_tikzpathi_in_tikznodee471 = new BitSet(new long[]{0x0000000000800000L});
    public static final BitSet FOLLOW_path_end_in_tikznodee474 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_node_start500 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_tikznode518 = new BitSet(new long[]{0x0010000000088000L});
    public static final BitSet FOLLOW_52_in_tikznode522 = new BitSet(new long[]{0x6000000000008000L});
    public static final BitSet FOLLOW_coord_in_tikznode524 = new BitSet(new long[]{0x0010000000088000L});
    public static final BitSet FOLLOW_string_in_tikznode528 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_edgeop0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LPAR_in_nodename601 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_ID_in_nodename605 = new BitSet(new long[]{0x0000000000010000L});
    public static final BitSet FOLLOW_RPAR_in_nodename607 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_coord632 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_modifier_in_coord656 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_LPAR_in_coord661 = new BitSet(new long[]{0x0000180000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord663 = new BitSet(new long[]{0x0000000000200000L});
    public static final BitSet FOLLOW_KOMMA_in_coord665 = new BitSet(new long[]{0x0000180000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord667 = new BitSet(new long[]{0x0000000000010000L});
    public static final BitSet FOLLOW_RPAR_in_coord669 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_number_in_numberunit711 = new BitSet(new long[]{0x8000000000000002L,0x000000000000000FL});
    public static final BitSet FOLLOW_unit_in_numberunit713 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_number736 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_unit0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_tag_in_path_start780 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzpicture_start_in_tikzpicture819 = new BitSet(new long[]{0x0000040000027980L,0x0000000000000010L});
    public static final BitSet FOLLOW_tikz_options_in_tikzpicture821 = new BitSet(new long[]{0x0000040000027980L,0x0000000000000010L});
    public static final BitSet FOLLOW_tikzbody_in_tikzpicture824 = new BitSet(new long[]{0x0000040000027980L,0x0000000000000010L});
    public static final BitSet FOLLOW_tikzpicture_end_in_tikzpicture827 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGINTP_in_tikzpicture_start854 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ENDTP_in_tikzpicture_end872 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody892 = new BitSet(new long[]{0x0000040000007902L,0x0000000000000010L});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody896 = new BitSet(new long[]{0x0000040000007902L,0x0000000000000010L});
    public static final BitSet FOLLOW_tikznodee_in_tikzbody900 = new BitSet(new long[]{0x0000040000007902L,0x0000000000000010L});
    public static final BitSet FOLLOW_tikz_something_in_tikzbody904 = new BitSet(new long[]{0x0000040000007902L,0x0000000000000010L});
    public static final BitSet FOLLOW_ID_in_tikz_something919 = new BitSet(new long[]{0x0000040000000002L,0x0000000000000010L});
    public static final BitSet FOLLOW_68_in_tikz_something923 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_ID_in_tikz_something925 = new BitSet(new long[]{0x0000040000000002L,0x0000000000000010L});
    public static final BitSet FOLLOW_tikzscope_start_in_tikzscope942 = new BitSet(new long[]{0x0000040000027900L,0x0000000000000010L});
    public static final BitSet FOLLOW_tikz_options_in_tikzscope944 = new BitSet(new long[]{0x0000040000007900L,0x0000000000000010L});
    public static final BitSet FOLLOW_tikzbody_in_tikzscope947 = new BitSet(new long[]{0x0000000000000200L});
    public static final BitSet FOLLOW_tikzscope_end_in_tikzscope949 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGINSCOPE_in_tikzscope_start975 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ENDSCOPE_in_tikzscope_end993 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBR_in_tikz_options1013 = new BitSet(new long[]{0x0000040000040000L});
    public static final BitSet FOLLOW_option_in_tikz_options1016 = new BitSet(new long[]{0x0000000000240000L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_options1019 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_option_in_tikz_options1021 = new BitSet(new long[]{0x0000000000240000L});
    public static final BitSet FOLLOW_RBR_in_tikz_options1027 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_69_in_tikz_set1049 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_LBRR_in_tikz_set1051 = new BitSet(new long[]{0x0000040000100000L});
    public static final BitSet FOLLOW_option_in_tikz_set1054 = new BitSet(new long[]{0x0000000000300000L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_set1057 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_option_in_tikz_set1059 = new BitSet(new long[]{0x0000000000300000L});
    public static final BitSet FOLLOW_RBRR_in_tikz_set1065 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_usetikzlib_start_in_usetikzlib1084 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_idd_in_usetikzlib1086 = new BitSet(new long[]{0x0000000000300000L});
    public static final BitSet FOLLOW_KOMMA_in_usetikzlib1089 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_idd_in_usetikzlib1091 = new BitSet(new long[]{0x0000000000300000L});
    public static final BitSet FOLLOW_roundbr_end_in_usetikzlib1095 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_USETIKZLIB_in_usetikzlib_start1118 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_LBRR_in_usetikzlib_start1120 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SEMIC_in_semicolon_end1139 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RBRR_in_roundbr_end1157 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_style_in_option1177 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_kv_in_option1193 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_kv1214 = new BitSet(new long[]{0x0000000000400002L});
    public static final BitSet FOLLOW_EQU_in_option_kv1217 = new BitSet(new long[]{0x00001C0000000000L});
    public static final BitSet FOLLOW_idd_in_option_kv1221 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_numberunit_in_option_kv1225 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_style1238 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000040L});
    public static final BitSet FOLLOW_70_in_option_style1240 = new BitSet(new long[]{0x0000000000400000L});
    public static final BitSet FOLLOW_EQU_in_option_style1243 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_LBRR_in_option_style1246 = new BitSet(new long[]{0x0000040000100000L});
    public static final BitSet FOLLOW_option_in_option_style1250 = new BitSet(new long[]{0x0000000000300000L});
    public static final BitSet FOLLOW_KOMMA_in_option_style1253 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_option_in_option_style1255 = new BitSet(new long[]{0x0000000000300000L});
    public static final BitSet FOLLOW_RBRR_in_option_style1262 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ID_in_idd1276 = new BitSet(new long[]{0x0000040000000002L});
    public static final BitSet FOLLOW_ID_in_idd1279 = new BitSet(new long[]{0x0000040000000002L});
    public static final BitSet FOLLOW_LBRR_in_string1301 = new BitSet(new long[]{0x0010240000188000L});
    public static final BitSet FOLLOW_string_in_string1305 = new BitSet(new long[]{0x0010240000188000L});
    public static final BitSet FOLLOW_MATHSTRING_in_string1309 = new BitSet(new long[]{0x0010240000188000L});
    public static final BitSet FOLLOW_ID_in_string1313 = new BitSet(new long[]{0x0010240000188000L});
    public static final BitSet FOLLOW_RBRR_in_string1317 = new BitSet(new long[]{0x0000000000000002L});

}