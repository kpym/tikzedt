// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g 2010-12-24 01:56:41

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;

import org.antlr.runtime.tree.*;

public class simpletikzParser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BEGIN", "END", "USETIKZLIB", "TIKZSTYLE", "TIKZSET", "NODE", "DRAW", "PATH", "FILL", "CLIP", "LPAR", "RPAR", "LBR", "RBR", "LBRR", "RBRR", "KOMMA", "EQU", "SEMIC", "COLON", "IM_PATH", "IM_NODE", "IM_COORD", "IM_SIZE", "IM_NODENAME", "IM_NUMBERUNIT", "IM_PICTURE", "IM_DOCUMENT", "IM_SCOPE", "IM_STARTTAG", "IM_ENDTAG", "IM_OPTIONS", "IM_OPTION_STYLE", "IM_OPTION_KV", "IM_ID", "IM_TIKZSET", "IM_USETIKZLIB", "IM_STRING", "IM_STYLE", "IM_TIKZEDT_CMD", "TIKZEDT_CMD_COMMENT", "INT", "FLOAT_WO_EXP", "ID", "WS", "COMMENT", "EXPONENT", "ESC_SEQ", "MATHSTRING", "COMMAND", "SOMETHING", "'/.style'", "'cm'", "'in'", "'ex'", "'mm'", "'pt'", "'em'", "'node'", "'at'", "'circle'", "'ellipse'", "'arc'", "'and'", "'--'", "'->'", "'|-'", "'-|'", "'+'", "'++'", "'tikzpicture'", "'scope'"
    };
    public static final int T__68=68;
    public static final int T__69=69;
    public static final int T__66=66;
    public static final int EXPONENT=50;
    public static final int T__67=67;
    public static final int T__64=64;
    public static final int TIKZEDT_CMD_COMMENT=44;
    public static final int IM_STARTTAG=33;
    public static final int T__65=65;
    public static final int T__62=62;
    public static final int T__63=63;
    public static final int IM_PATH=24;
    public static final int RBR=17;
    public static final int IM_ID=38;
    public static final int SOMETHING=54;
    public static final int ID=47;
    public static final int T__61=61;
    public static final int T__60=60;
    public static final int EOF=-1;
    public static final int MATHSTRING=52;
    public static final int LBR=16;
    public static final int COMMAND=53;
    public static final int IM_ENDTAG=34;
    public static final int IM_USETIKZLIB=40;
    public static final int T__55=55;
    public static final int T__56=56;
    public static final int T__57=57;
    public static final int IM_DOCUMENT=31;
    public static final int T__58=58;
    public static final int RBRR=19;
    public static final int ESC_SEQ=51;
    public static final int IM_STRING=41;
    public static final int LPAR=14;
    public static final int FILL=12;
    public static final int PATH=11;
    public static final int IM_TIKZSET=39;
    public static final int T__59=59;
    public static final int BEGIN=4;
    public static final int IM_OPTION_KV=37;
    public static final int CLIP=13;
    public static final int COMMENT=49;
    public static final int IM_TIKZEDT_CMD=43;
    public static final int IM_OPTIONS=35;
    public static final int IM_OPTION_STYLE=36;
    public static final int NODE=9;
    public static final int TIKZSTYLE=7;
    public static final int TIKZSET=8;
    public static final int IM_COORD=26;
    public static final int IM_PICTURE=30;
    public static final int INT=45;
    public static final int LBRR=18;
    public static final int IM_NODE=25;
    public static final int USETIKZLIB=6;
    public static final int IM_STYLE=42;
    public static final int COLON=23;
    public static final int IM_SCOPE=32;
    public static final int IM_NUMBERUNIT=29;
    public static final int WS=48;
    public static final int T__71=71;
    public static final int T__72=72;
    public static final int T__70=70;
    public static final int KOMMA=20;
    public static final int EQU=21;
    public static final int IM_SIZE=27;
    public static final int RPAR=15;
    public static final int END=5;
    public static final int SEMIC=22;
    public static final int T__75=75;
    public static final int T__74=74;
    public static final int IM_NODENAME=28;
    public static final int T__73=73;
    public static final int FLOAT_WO_EXP=46;
    public static final int DRAW=10;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "option", "circle", "tikznode_int", "tikzscope", 
        "tikznode_core", "idd", "coord_modifier", "arc", "tikz_set", "path_start", 
        "nodename", "numberunit", "tikzbody", "tikzpicture", "tikz_set_start", 
        "coord_sep", "dontcare_body", "tikzpath", "tikz_style", "tikznode_decorator", 
        "size", "tikznode_ext", "otherend", "tikzstring", "edgeop", "otherbegin", 
        "tikz_options_dontcare", "no_rlbracket", "semicolon_end", "unit", 
        "no_rlbrace", "option_style", "path_start_tag", "tikzscope_end", 
        "option_kv", "tikzdocument", "number", "tikz_cmd_comment", "tikz_options", 
        "tikz_styleorset", "roundbr_end", "tikzscope_start", "coord", "iddornumberunitorstring", 
        "dontcare_preamble", "dontcare_body_nobr", "node_start", "squarebr_end", 
        "squarebr_start", "tikzpicture_end", "tikzpicture_start", "tikzpath_element"
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
    public String getGrammarFileName() { return "C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g"; }


    public static class tikzdocument_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzdocument"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:89:1: tikzdocument : ( tikz_cmd_comment )* ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture ) ;
    public final simpletikzParser.tikzdocument_return tikzdocument() throws RecognitionException {
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token wildcard6=null;
        simpletikzParser.tikz_cmd_comment_return tikz_cmd_comment1 = null;

        simpletikzParser.dontcare_preamble_return dontcare_preamble2 = null;

        simpletikzParser.tikz_styleorset_return tikz_styleorset3 = null;

        simpletikzParser.otherbegin_return otherbegin4 = null;

        simpletikzParser.tikzpicture_return tikzpicture5 = null;


        Object wildcard6_tree=null;
        RewriteRuleSubtreeStream stream_dontcare_preamble=new RewriteRuleSubtreeStream(adaptor,"rule dontcare_preamble");
        RewriteRuleSubtreeStream stream_tikzpicture=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        RewriteRuleSubtreeStream stream_tikz_cmd_comment=new RewriteRuleSubtreeStream(adaptor,"rule tikz_cmd_comment");
        RewriteRuleSubtreeStream stream_otherbegin=new RewriteRuleSubtreeStream(adaptor,"rule otherbegin");
        RewriteRuleSubtreeStream stream_tikz_styleorset=new RewriteRuleSubtreeStream(adaptor,"rule tikz_styleorset");
        try { dbg.enterRule(getGrammarFileName(), "tikzdocument");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(89, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:90:2: ( ( tikz_cmd_comment )* ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture ( . )* -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:90:4: ( tikz_cmd_comment )* ( dontcare_preamble | tikz_styleorset | otherbegin )* tikzpicture ( . )*
            {
            dbg.location(90,4);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:90:4: ( tikz_cmd_comment )*
            try { dbg.enterSubRule(1);

            loop1:
            do {
                int alt1=2;
                try { dbg.enterDecision(1);

                int LA1_0 = input.LA(1);

                if ( (LA1_0==TIKZEDT_CMD_COMMENT) ) {
                    alt1=1;
                }


                } finally {dbg.exitDecision(1);}

                switch (alt1) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:90:4: tikz_cmd_comment
            	    {
            	    dbg.location(90,4);
            	    pushFollow(FOLLOW_tikz_cmd_comment_in_tikzdocument346);
            	    tikz_cmd_comment1=tikz_cmd_comment();

            	    state._fsp--;

            	    stream_tikz_cmd_comment.add(tikz_cmd_comment1.getTree());

            	    }
            	    break;

            	default :
            	    break loop1;
                }
            } while (true);
            } finally {dbg.exitSubRule(1);}

            dbg.location(90,22);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:90:22: ( dontcare_preamble | tikz_styleorset | otherbegin )*
            try { dbg.enterSubRule(2);

            loop2:
            do {
                int alt2=4;
                try { dbg.enterDecision(2);

                switch ( input.LA(1) ) {
                case BEGIN:
                    {
                    int LA2_1 = input.LA(2);

                    if ( (LA2_1==LBRR) ) {
                        int LA2_4 = input.LA(3);

                        if ( (LA2_4==ID||(LA2_4>=68 && LA2_4<=71)) ) {
                            alt2=3;
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
                case CLIP:
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
                case IM_SIZE:
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
                case IM_TIKZEDT_CMD:
                case INT:
                case FLOAT_WO_EXP:
                case ID:
                case WS:
                case COMMENT:
                case EXPONENT:
                case ESC_SEQ:
                case MATHSTRING:
                case COMMAND:
                case SOMETHING:
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
                case 71:
                case 72:
                case 73:
                case 74:
                case 75:
                    {
                    alt2=1;
                    }
                    break;
                case TIKZSTYLE:
                case TIKZSET:
                    {
                    alt2=2;
                    }
                    break;

                }

                } finally {dbg.exitDecision(2);}

                switch (alt2) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:90:23: dontcare_preamble
            	    {
            	    dbg.location(90,23);
            	    pushFollow(FOLLOW_dontcare_preamble_in_tikzdocument350);
            	    dontcare_preamble2=dontcare_preamble();

            	    state._fsp--;

            	    stream_dontcare_preamble.add(dontcare_preamble2.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:90:43: tikz_styleorset
            	    {
            	    dbg.location(90,43);
            	    pushFollow(FOLLOW_tikz_styleorset_in_tikzdocument354);
            	    tikz_styleorset3=tikz_styleorset();

            	    state._fsp--;

            	    stream_tikz_styleorset.add(tikz_styleorset3.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:90:61: otherbegin
            	    {
            	    dbg.location(90,61);
            	    pushFollow(FOLLOW_otherbegin_in_tikzdocument358);
            	    otherbegin4=otherbegin();

            	    state._fsp--;

            	    stream_otherbegin.add(otherbegin4.getTree());

            	    }
            	    break;

            	default :
            	    break loop2;
                }
            } while (true);
            } finally {dbg.exitSubRule(2);}

            dbg.location(90,75);
            pushFollow(FOLLOW_tikzpicture_in_tikzdocument363);
            tikzpicture5=tikzpicture();

            state._fsp--;

            stream_tikzpicture.add(tikzpicture5.getTree());
            dbg.location(90,87);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:90:87: ( . )*
            try { dbg.enterSubRule(3);

            loop3:
            do {
                int alt3=2;
                try { dbg.enterDecision(3);

                int LA3_0 = input.LA(1);

                if ( ((LA3_0>=BEGIN && LA3_0<=75)) ) {
                    alt3=1;
                }
                else if ( (LA3_0==EOF) ) {
                    alt3=2;
                }


                } finally {dbg.exitDecision(3);}

                switch (alt3) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:90:87: .
            	    {
            	    dbg.location(90,87);
            	    wildcard6=(Token)input.LT(1);
            	    matchAny(input); 
            	    wildcard6_tree = (Object)adaptor.create(wildcard6);
            	    adaptor.addChild(root_0, wildcard6_tree);


            	    }
            	    break;

            	default :
            	    break loop3;
                }
            } while (true);
            } finally {dbg.exitSubRule(3);}



            // AST REWRITE
            // elements: tikzpicture, tikz_styleorset
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 90:90: -> ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture )
            {
                dbg.location(90,93);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:90:93: ^( IM_DOCUMENT ( tikz_styleorset )* tikzpicture )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(90,95);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

                dbg.location(90,107);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:90:107: ( tikz_styleorset )*
                while ( stream_tikz_styleorset.hasNext() ) {
                    dbg.location(90,107);
                    adaptor.addChild(root_1, stream_tikz_styleorset.nextTree());

                }
                stream_tikz_styleorset.reset();
                dbg.location(90,124);
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

    public static class tikz_cmd_comment_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_cmd_comment"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:93:1: tikz_cmd_comment : TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) ;
    public final simpletikzParser.tikz_cmd_comment_return tikz_cmd_comment() throws RecognitionException {
        simpletikzParser.tikz_cmd_comment_return retval = new simpletikzParser.tikz_cmd_comment_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token TIKZEDT_CMD_COMMENT7=null;

        Object TIKZEDT_CMD_COMMENT7_tree=null;
        RewriteRuleTokenStream stream_TIKZEDT_CMD_COMMENT=new RewriteRuleTokenStream(adaptor,"token TIKZEDT_CMD_COMMENT");

        try { dbg.enterRule(getGrammarFileName(), "tikz_cmd_comment");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(93, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:94:2: ( TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:94:4: TIKZEDT_CMD_COMMENT
            {
            dbg.location(94,4);
            TIKZEDT_CMD_COMMENT7=(Token)match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment389);  
            stream_TIKZEDT_CMD_COMMENT.add(TIKZEDT_CMD_COMMENT7);



            // AST REWRITE
            // elements: TIKZEDT_CMD_COMMENT
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 94:27: -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
            {
                dbg.location(94,30);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:94:30: ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(94,32);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_TIKZEDT_CMD, "IM_TIKZEDT_CMD"), root_1);

                dbg.location(94,47);
                adaptor.addChild(root_1, stream_TIKZEDT_CMD_COMMENT.nextNode());

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
            dbg.exitRule(getGrammarFileName(), "tikz_cmd_comment");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikz_cmd_comment"

    public static class tikz_styleorset_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_styleorset"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:97:1: tikz_styleorset : ( tikz_style | tikz_set );
    public final simpletikzParser.tikz_styleorset_return tikz_styleorset() throws RecognitionException {
        simpletikzParser.tikz_styleorset_return retval = new simpletikzParser.tikz_styleorset_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikz_style_return tikz_style8 = null;

        simpletikzParser.tikz_set_return tikz_set9 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikz_styleorset");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(97, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:98:2: ( tikz_style | tikz_set )
            int alt4=2;
            try { dbg.enterDecision(4);

            int LA4_0 = input.LA(1);

            if ( (LA4_0==TIKZSTYLE) ) {
                alt4=1;
            }
            else if ( (LA4_0==TIKZSET) ) {
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

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:98:4: tikz_style
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(98,4);
                    pushFollow(FOLLOW_tikz_style_in_tikz_styleorset411);
                    tikz_style8=tikz_style();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_style8.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:98:17: tikz_set
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(98,17);
                    pushFollow(FOLLOW_tikz_set_in_tikz_styleorset415);
                    tikz_set9=tikz_set();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_set9.getTree());

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
        dbg.location(99, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:101:1: dontcare_preamble : ~ ( BEGIN | TIKZSTYLE | TIKZSET | TIKZEDT_CMD_COMMENT ) ;
    public final simpletikzParser.dontcare_preamble_return dontcare_preamble() throws RecognitionException {
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set10=null;

        Object set10_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "dontcare_preamble");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(101, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:102:2: (~ ( BEGIN | TIKZSTYLE | TIKZSET | TIKZEDT_CMD_COMMENT ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:102:4: ~ ( BEGIN | TIKZSTYLE | TIKZSET | TIKZEDT_CMD_COMMENT )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(102,4);
            set10=(Token)input.LT(1);
            if ( (input.LA(1)>=END && input.LA(1)<=USETIKZLIB)||(input.LA(1)>=NODE && input.LA(1)<=IM_TIKZEDT_CMD)||(input.LA(1)>=INT && input.LA(1)<=75) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set10));
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
        dbg.location(103, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:104:1: otherbegin : BEGIN LBRR idd RBRR ;
    public final simpletikzParser.otherbegin_return otherbegin() throws RecognitionException {
        simpletikzParser.otherbegin_return retval = new simpletikzParser.otherbegin_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGIN11=null;
        Token LBRR12=null;
        Token RBRR14=null;
        simpletikzParser.idd_return idd13 = null;


        Object BEGIN11_tree=null;
        Object LBRR12_tree=null;
        Object RBRR14_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "otherbegin");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(104, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:105:2: ( BEGIN LBRR idd RBRR )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:105:4: BEGIN LBRR idd RBRR
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(105,4);
            BEGIN11=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_otherbegin451); 
            BEGIN11_tree = (Object)adaptor.create(BEGIN11);
            adaptor.addChild(root_0, BEGIN11_tree);

            dbg.location(105,10);
            LBRR12=(Token)match(input,LBRR,FOLLOW_LBRR_in_otherbegin453); 
            LBRR12_tree = (Object)adaptor.create(LBRR12);
            adaptor.addChild(root_0, LBRR12_tree);

            dbg.location(105,15);
            pushFollow(FOLLOW_idd_in_otherbegin455);
            idd13=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd13.getTree());
            dbg.location(105,19);
            RBRR14=(Token)match(input,RBRR,FOLLOW_RBRR_in_otherbegin457); 
            RBRR14_tree = (Object)adaptor.create(RBRR14);
            adaptor.addChild(root_0, RBRR14_tree);


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:108:1: tikz_style : TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) ;
    public final simpletikzParser.tikz_style_return tikz_style() throws RecognitionException {
        simpletikzParser.tikz_style_return retval = new simpletikzParser.tikz_style_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token TIKZSTYLE15=null;
        Token LBRR16=null;
        Token RBRR18=null;
        Token char_literal19=null;
        simpletikzParser.idd_return idd17 = null;

        simpletikzParser.tikz_options_return tikz_options20 = null;


        Object TIKZSTYLE15_tree=null;
        Object LBRR16_tree=null;
        Object RBRR18_tree=null;
        Object char_literal19_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSTYLE=new RewriteRuleTokenStream(adaptor,"token TIKZSTYLE");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikz_style");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(108, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:109:2: ( TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:109:4: TIKZSTYLE LBRR idd RBRR '=' tikz_options
            {
            dbg.location(109,4);
            TIKZSTYLE15=(Token)match(input,TIKZSTYLE,FOLLOW_TIKZSTYLE_in_tikz_style468);  
            stream_TIKZSTYLE.add(TIKZSTYLE15);

            dbg.location(109,14);
            LBRR16=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikz_style470);  
            stream_LBRR.add(LBRR16);

            dbg.location(109,19);
            pushFollow(FOLLOW_idd_in_tikz_style472);
            idd17=idd();

            state._fsp--;

            stream_idd.add(idd17.getTree());
            dbg.location(109,23);
            RBRR18=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikz_style474);  
            stream_RBRR.add(RBRR18);

            dbg.location(109,28);
            char_literal19=(Token)match(input,EQU,FOLLOW_EQU_in_tikz_style476);  
            stream_EQU.add(char_literal19);

            dbg.location(109,32);
            pushFollow(FOLLOW_tikz_options_in_tikz_style478);
            tikz_options20=tikz_options();

            state._fsp--;

            stream_tikz_options.add(tikz_options20.getTree());


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
            // 109:45: -> ^( IM_STYLE idd tikz_options )
            {
                dbg.location(109,48);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:109:48: ^( IM_STYLE idd tikz_options )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(109,50);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STYLE, "IM_STYLE"), root_1);

                dbg.location(109,59);
                adaptor.addChild(root_1, stream_idd.nextTree());
                dbg.location(109,63);
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
        dbg.location(110, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:112:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
    public final simpletikzParser.tikz_options_return tikz_options() throws RecognitionException {
        simpletikzParser.tikz_options_return retval = new simpletikzParser.tikz_options_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal23=null;
        Token char_literal25=null;
        simpletikzParser.squarebr_start_return squarebr_start21 = null;

        simpletikzParser.option_return option22 = null;

        simpletikzParser.option_return option24 = null;

        simpletikzParser.squarebr_end_return squarebr_end26 = null;


        Object char_literal23_tree=null;
        Object char_literal25_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_squarebr_start=new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_squarebr_end=new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try { dbg.enterRule(getGrammarFileName(), "tikz_options");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(112, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:113:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:113:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            dbg.location(113,5);
            pushFollow(FOLLOW_squarebr_start_in_tikz_options500);
            squarebr_start21=squarebr_start();

            state._fsp--;

            stream_squarebr_start.add(squarebr_start21.getTree());
            dbg.location(113,20);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:113:20: ( option ( ',' option )* ( ',' )? )?
            int alt7=2;
            try { dbg.enterSubRule(7);
            try { dbg.enterDecision(7);

            int LA7_0 = input.LA(1);

            if ( (LA7_0==ID||(LA7_0>=68 && LA7_0<=71)) ) {
                alt7=1;
            }
            } finally {dbg.exitDecision(7);}

            switch (alt7) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:113:21: option ( ',' option )* ( ',' )?
                    {
                    dbg.location(113,21);
                    pushFollow(FOLLOW_option_in_tikz_options503);
                    option22=option();

                    state._fsp--;

                    stream_option.add(option22.getTree());
                    dbg.location(113,28);
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:113:28: ( ',' option )*
                    try { dbg.enterSubRule(5);

                    loop5:
                    do {
                        int alt5=2;
                        try { dbg.enterDecision(5);

                        int LA5_0 = input.LA(1);

                        if ( (LA5_0==KOMMA) ) {
                            int LA5_1 = input.LA(2);

                            if ( (LA5_1==ID||(LA5_1>=68 && LA5_1<=71)) ) {
                                alt5=1;
                            }


                        }


                        } finally {dbg.exitDecision(5);}

                        switch (alt5) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:113:29: ',' option
                    	    {
                    	    dbg.location(113,29);
                    	    char_literal23=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options506);  
                    	    stream_KOMMA.add(char_literal23);

                    	    dbg.location(113,33);
                    	    pushFollow(FOLLOW_option_in_tikz_options508);
                    	    option24=option();

                    	    state._fsp--;

                    	    stream_option.add(option24.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop5;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(5);}

                    dbg.location(113,42);
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:113:42: ( ',' )?
                    int alt6=2;
                    try { dbg.enterSubRule(6);
                    try { dbg.enterDecision(6);

                    int LA6_0 = input.LA(1);

                    if ( (LA6_0==KOMMA) ) {
                        alt6=1;
                    }
                    } finally {dbg.exitDecision(6);}

                    switch (alt6) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:113:42: ','
                            {
                            dbg.location(113,42);
                            char_literal25=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options512);  
                            stream_KOMMA.add(char_literal25);


                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(6);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(7);}

            dbg.location(113,49);
            pushFollow(FOLLOW_squarebr_end_in_tikz_options517);
            squarebr_end26=squarebr_end();

            state._fsp--;

            stream_squarebr_end.add(squarebr_end26.getTree());


            // AST REWRITE
            // elements: squarebr_start, option, squarebr_end
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 113:63: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            {
                dbg.location(113,66);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:113:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(113,68);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTIONS, "IM_OPTIONS"), root_1);

                dbg.location(113,79);
                adaptor.addChild(root_1, stream_squarebr_start.nextTree());
                dbg.location(113,94);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:113:94: ( option )*
                while ( stream_option.hasNext() ) {
                    dbg.location(113,94);
                    adaptor.addChild(root_1, stream_option.nextTree());

                }
                stream_option.reset();
                dbg.location(113,102);
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
        dbg.location(114, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:116:1: option : ( option_style | option_kv );
    public final simpletikzParser.option_return option() throws RecognitionException {
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.option_style_return option_style27 = null;

        simpletikzParser.option_kv_return option_kv28 = null;



        try { dbg.enterRule(getGrammarFileName(), "option");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(116, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:117:2: ( option_style | option_kv )
            int alt8=2;
            try { dbg.enterDecision(8);

            try {
                isCyclicDecision = true;
                alt8 = dfa8.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(8);}

            switch (alt8) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:117:4: option_style
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(117,4);
                    pushFollow(FOLLOW_option_style_in_option542);
                    option_style27=option_style();

                    state._fsp--;

                    adaptor.addChild(root_0, option_style27.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:118:5: option_kv
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(118,5);
                    pushFollow(FOLLOW_option_kv_in_option551);
                    option_kv28=option_kv();

                    state._fsp--;

                    adaptor.addChild(root_0, option_kv28.getTree());

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
        dbg.location(119, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:121:1: option_kv : idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) ;
    public final simpletikzParser.option_kv_return option_kv() throws RecognitionException {
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal30=null;
        simpletikzParser.idd_return idd29 = null;

        simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring31 = null;


        Object char_literal30_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_iddornumberunitorstring=new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunitorstring");
        try { dbg.enterRule(getGrammarFileName(), "option_kv");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(121, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:122:2: ( idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:122:4: idd ( '=' iddornumberunitorstring )?
            {
            dbg.location(122,4);
            pushFollow(FOLLOW_idd_in_option_kv565);
            idd29=idd();

            state._fsp--;

            stream_idd.add(idd29.getTree());
            dbg.location(122,8);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:122:8: ( '=' iddornumberunitorstring )?
            int alt9=2;
            try { dbg.enterSubRule(9);
            try { dbg.enterDecision(9);

            int LA9_0 = input.LA(1);

            if ( (LA9_0==EQU) ) {
                alt9=1;
            }
            } finally {dbg.exitDecision(9);}

            switch (alt9) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:122:9: '=' iddornumberunitorstring
                    {
                    dbg.location(122,9);
                    char_literal30=(Token)match(input,EQU,FOLLOW_EQU_in_option_kv568);  
                    stream_EQU.add(char_literal30);

                    dbg.location(122,13);
                    pushFollow(FOLLOW_iddornumberunitorstring_in_option_kv570);
                    iddornumberunitorstring31=iddornumberunitorstring();

                    state._fsp--;

                    stream_iddornumberunitorstring.add(iddornumberunitorstring31.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(9);}



            // AST REWRITE
            // elements: idd, iddornumberunitorstring
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 122:40: -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
            {
                dbg.location(122,43);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:122:43: ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(122,45);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

                dbg.location(122,58);
                adaptor.addChild(root_1, stream_idd.nextTree());
                dbg.location(122,62);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:122:62: ( iddornumberunitorstring )?
                if ( stream_iddornumberunitorstring.hasNext() ) {
                    dbg.location(122,62);
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
        dbg.location(123, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:125:1: tikzstring : LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) ;
    public final simpletikzParser.tikzstring_return tikzstring() throws RecognitionException {
        simpletikzParser.tikzstring_return retval = new simpletikzParser.tikzstring_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LBRR32=null;
        Token RBRR36=null;
        simpletikzParser.no_rlbrace_return no_rlbrace33 = null;

        simpletikzParser.tikzstring_return tikzstring34 = null;

        simpletikzParser.no_rlbrace_return no_rlbrace35 = null;


        Object LBRR32_tree=null;
        Object RBRR36_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleSubtreeStream stream_tikzstring=new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace=new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try { dbg.enterRule(getGrammarFileName(), "tikzstring");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(125, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:126:2: ( LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:126:4: LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR
            {
            dbg.location(126,4);
            LBRR32=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzstring598);  
            stream_LBRR.add(LBRR32);

            dbg.location(126,9);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:126:9: ( no_rlbrace )*
            try { dbg.enterSubRule(10);

            loop10:
            do {
                int alt10=2;
                try { dbg.enterDecision(10);

                int LA10_0 = input.LA(1);

                if ( ((LA10_0>=BEGIN && LA10_0<=RBR)||(LA10_0>=KOMMA && LA10_0<=75)) ) {
                    alt10=1;
                }


                } finally {dbg.exitDecision(10);}

                switch (alt10) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:126:9: no_rlbrace
            	    {
            	    dbg.location(126,9);
            	    pushFollow(FOLLOW_no_rlbrace_in_tikzstring600);
            	    no_rlbrace33=no_rlbrace();

            	    state._fsp--;

            	    stream_no_rlbrace.add(no_rlbrace33.getTree());

            	    }
            	    break;

            	default :
            	    break loop10;
                }
            } while (true);
            } finally {dbg.exitSubRule(10);}

            dbg.location(126,21);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:126:21: ( tikzstring ( no_rlbrace )* )*
            try { dbg.enterSubRule(12);

            loop12:
            do {
                int alt12=2;
                try { dbg.enterDecision(12);

                int LA12_0 = input.LA(1);

                if ( (LA12_0==LBRR) ) {
                    alt12=1;
                }


                } finally {dbg.exitDecision(12);}

                switch (alt12) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:126:22: tikzstring ( no_rlbrace )*
            	    {
            	    dbg.location(126,22);
            	    pushFollow(FOLLOW_tikzstring_in_tikzstring604);
            	    tikzstring34=tikzstring();

            	    state._fsp--;

            	    stream_tikzstring.add(tikzstring34.getTree());
            	    dbg.location(126,33);
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:126:33: ( no_rlbrace )*
            	    try { dbg.enterSubRule(11);

            	    loop11:
            	    do {
            	        int alt11=2;
            	        try { dbg.enterDecision(11);

            	        int LA11_0 = input.LA(1);

            	        if ( ((LA11_0>=BEGIN && LA11_0<=RBR)||(LA11_0>=KOMMA && LA11_0<=75)) ) {
            	            alt11=1;
            	        }


            	        } finally {dbg.exitDecision(11);}

            	        switch (alt11) {
            	    	case 1 :
            	    	    dbg.enterAlt(1);

            	    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:126:33: no_rlbrace
            	    	    {
            	    	    dbg.location(126,33);
            	    	    pushFollow(FOLLOW_no_rlbrace_in_tikzstring606);
            	    	    no_rlbrace35=no_rlbrace();

            	    	    state._fsp--;

            	    	    stream_no_rlbrace.add(no_rlbrace35.getTree());

            	    	    }
            	    	    break;

            	    	default :
            	    	    break loop11;
            	        }
            	    } while (true);
            	    } finally {dbg.exitSubRule(11);}


            	    }
            	    break;

            	default :
            	    break loop12;
                }
            } while (true);
            } finally {dbg.exitSubRule(12);}

            dbg.location(126,47);
            RBRR36=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzstring611);  
            stream_RBRR.add(RBRR36);



            // AST REWRITE
            // elements: RBRR, LBRR
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 126:52: -> ^( IM_STRING LBRR RBRR )
            {
                dbg.location(126,55);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:126:55: ^( IM_STRING LBRR RBRR )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(126,57);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STRING, "IM_STRING"), root_1);

                dbg.location(126,67);
                adaptor.addChild(root_1, stream_LBRR.nextNode());
                dbg.location(126,72);
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
        dbg.location(127, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:129:1: no_rlbrace : ~ ( LBRR | RBRR ) ;
    public final simpletikzParser.no_rlbrace_return no_rlbrace() throws RecognitionException {
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set37=null;

        Object set37_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "no_rlbrace");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(129, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:130:2: (~ ( LBRR | RBRR ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:130:4: ~ ( LBRR | RBRR )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(130,4);
            set37=(Token)input.LT(1);
            if ( (input.LA(1)>=BEGIN && input.LA(1)<=RBR)||(input.LA(1)>=KOMMA && input.LA(1)<=75) ) {
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
        dbg.location(131, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:132:1: iddornumberunitorstring : ( idd | numberunit | tikzstring );
    public final simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring() throws RecognitionException {
        simpletikzParser.iddornumberunitorstring_return retval = new simpletikzParser.iddornumberunitorstring_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.idd_return idd38 = null;

        simpletikzParser.numberunit_return numberunit39 = null;

        simpletikzParser.tikzstring_return tikzstring40 = null;



        try { dbg.enterRule(getGrammarFileName(), "iddornumberunitorstring");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(132, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:133:2: ( idd | numberunit | tikzstring )
            int alt13=3;
            try { dbg.enterDecision(13);

            switch ( input.LA(1) ) {
            case ID:
            case 68:
            case 69:
            case 70:
            case 71:
                {
                alt13=1;
                }
                break;
            case INT:
            case FLOAT_WO_EXP:
                {
                alt13=2;
                }
                break;
            case LBRR:
                {
                alt13=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 13, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(13);}

            switch (alt13) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:133:4: idd
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(133,4);
                    pushFollow(FOLLOW_idd_in_iddornumberunitorstring651);
                    idd38=idd();

                    state._fsp--;

                    adaptor.addChild(root_0, idd38.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:133:10: numberunit
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(133,10);
                    pushFollow(FOLLOW_numberunit_in_iddornumberunitorstring655);
                    numberunit39=numberunit();

                    state._fsp--;

                    adaptor.addChild(root_0, numberunit39.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:133:23: tikzstring
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(133,23);
                    pushFollow(FOLLOW_tikzstring_in_iddornumberunitorstring659);
                    tikzstring40=tikzstring();

                    state._fsp--;

                    adaptor.addChild(root_0, tikzstring40.getTree());

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
        dbg.location(134, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:135:1: option_style : idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public final simpletikzParser.option_style_return option_style() throws RecognitionException {
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal42=null;
        Token char_literal43=null;
        Token LBRR44=null;
        Token char_literal46=null;
        Token char_literal48=null;
        Token RBRR49=null;
        simpletikzParser.idd_return idd41 = null;

        simpletikzParser.option_kv_return option_kv45 = null;

        simpletikzParser.option_kv_return option_kv47 = null;


        Object string_literal42_tree=null;
        Object char_literal43_tree=null;
        Object LBRR44_tree=null;
        Object char_literal46_tree=null;
        Object char_literal48_tree=null;
        Object RBRR49_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_55=new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv=new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try { dbg.enterRule(getGrammarFileName(), "option_style");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(135, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:136:2: ( idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:136:4: idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR
            {
            dbg.location(136,4);
            pushFollow(FOLLOW_idd_in_option_style669);
            idd41=idd();

            state._fsp--;

            stream_idd.add(idd41.getTree());
            dbg.location(136,8);
            string_literal42=(Token)match(input,55,FOLLOW_55_in_option_style671);  
            stream_55.add(string_literal42);

            dbg.location(136,18);
            char_literal43=(Token)match(input,EQU,FOLLOW_EQU_in_option_style673);  
            stream_EQU.add(char_literal43);

            dbg.location(136,22);
            LBRR44=(Token)match(input,LBRR,FOLLOW_LBRR_in_option_style675);  
            stream_LBRR.add(LBRR44);

            dbg.location(136,27);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:136:27: ( option_kv ( ',' option_kv )* )?
            int alt15=2;
            try { dbg.enterSubRule(15);
            try { dbg.enterDecision(15);

            int LA15_0 = input.LA(1);

            if ( (LA15_0==ID||(LA15_0>=68 && LA15_0<=71)) ) {
                alt15=1;
            }
            } finally {dbg.exitDecision(15);}

            switch (alt15) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:136:28: option_kv ( ',' option_kv )*
                    {
                    dbg.location(136,28);
                    pushFollow(FOLLOW_option_kv_in_option_style678);
                    option_kv45=option_kv();

                    state._fsp--;

                    stream_option_kv.add(option_kv45.getTree());
                    dbg.location(136,38);
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:136:38: ( ',' option_kv )*
                    try { dbg.enterSubRule(14);

                    loop14:
                    do {
                        int alt14=2;
                        try { dbg.enterDecision(14);

                        int LA14_0 = input.LA(1);

                        if ( (LA14_0==KOMMA) ) {
                            int LA14_1 = input.LA(2);

                            if ( (LA14_1==ID||(LA14_1>=68 && LA14_1<=71)) ) {
                                alt14=1;
                            }


                        }


                        } finally {dbg.exitDecision(14);}

                        switch (alt14) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:136:39: ',' option_kv
                    	    {
                    	    dbg.location(136,39);
                    	    char_literal46=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_option_style681);  
                    	    stream_KOMMA.add(char_literal46);

                    	    dbg.location(136,43);
                    	    pushFollow(FOLLOW_option_kv_in_option_style683);
                    	    option_kv47=option_kv();

                    	    state._fsp--;

                    	    stream_option_kv.add(option_kv47.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop14;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(14);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(15);}

            dbg.location(136,58);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:136:58: ( ',' )?
            int alt16=2;
            try { dbg.enterSubRule(16);
            try { dbg.enterDecision(16);

            int LA16_0 = input.LA(1);

            if ( (LA16_0==KOMMA) ) {
                alt16=1;
            }
            } finally {dbg.exitDecision(16);}

            switch (alt16) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:136:58: ','
                    {
                    dbg.location(136,58);
                    char_literal48=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_option_style690);  
                    stream_KOMMA.add(char_literal48);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(16);}

            dbg.location(136,63);
            RBRR49=(Token)match(input,RBRR,FOLLOW_RBRR_in_option_style693);  
            stream_RBRR.add(RBRR49);



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
            // 136:69: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            {
                dbg.location(136,72);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:136:72: ^( IM_OPTION_STYLE idd ( option_kv )* )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(136,74);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

                dbg.location(136,90);
                adaptor.addChild(root_1, stream_idd.nextTree());
                dbg.location(136,94);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:136:94: ( option_kv )*
                while ( stream_option_kv.hasNext() ) {
                    dbg.location(136,94);
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
        dbg.location(137, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:144:1: idd : ( edgeop ( edgeop )* -> ^( IM_ID ( edgeop )* ) | edgeop INT -> ^( IM_ID edgeop INT ) );
    public final simpletikzParser.idd_return idd() throws RecognitionException {
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token INT53=null;
        simpletikzParser.edgeop_return edgeop50 = null;

        simpletikzParser.edgeop_return edgeop51 = null;

        simpletikzParser.edgeop_return edgeop52 = null;


        Object INT53_tree=null;
        RewriteRuleTokenStream stream_INT=new RewriteRuleTokenStream(adaptor,"token INT");
        RewriteRuleSubtreeStream stream_edgeop=new RewriteRuleSubtreeStream(adaptor,"rule edgeop");
        try { dbg.enterRule(getGrammarFileName(), "idd");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(144, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:145:2: ( edgeop ( edgeop )* -> ^( IM_ID ( edgeop )* ) | edgeop INT -> ^( IM_ID edgeop INT ) )
            int alt18=2;
            try { dbg.enterDecision(18);

            int LA18_0 = input.LA(1);

            if ( (LA18_0==ID||(LA18_0>=68 && LA18_0<=71)) ) {
                int LA18_1 = input.LA(2);

                if ( (LA18_1==RPAR||LA18_1==RBR||(LA18_1>=RBRR && LA18_1<=EQU)||LA18_1==ID||LA18_1==55||(LA18_1>=68 && LA18_1<=71)) ) {
                    alt18=1;
                }
                else if ( (LA18_1==INT) ) {
                    alt18=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 18, 1, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
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

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:145:4: edgeop ( edgeop )*
                    {
                    dbg.location(145,4);
                    pushFollow(FOLLOW_edgeop_in_idd724);
                    edgeop50=edgeop();

                    state._fsp--;

                    stream_edgeop.add(edgeop50.getTree());
                    dbg.location(145,11);
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:145:11: ( edgeop )*
                    try { dbg.enterSubRule(17);

                    loop17:
                    do {
                        int alt17=2;
                        try { dbg.enterDecision(17);

                        int LA17_0 = input.LA(1);

                        if ( (LA17_0==ID||(LA17_0>=68 && LA17_0<=71)) ) {
                            alt17=1;
                        }


                        } finally {dbg.exitDecision(17);}

                        switch (alt17) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:145:12: edgeop
                    	    {
                    	    dbg.location(145,12);
                    	    pushFollow(FOLLOW_edgeop_in_idd727);
                    	    edgeop51=edgeop();

                    	    state._fsp--;

                    	    stream_edgeop.add(edgeop51.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop17;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(17);}



                    // AST REWRITE
                    // elements: edgeop
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 145:21: -> ^( IM_ID ( edgeop )* )
                    {
                        dbg.location(145,24);
                        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:145:24: ^( IM_ID ( edgeop )* )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(145,26);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ID, "IM_ID"), root_1);

                        dbg.location(145,32);
                        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:145:32: ( edgeop )*
                        while ( stream_edgeop.hasNext() ) {
                            dbg.location(145,32);
                            adaptor.addChild(root_1, stream_edgeop.nextTree());

                        }
                        stream_edgeop.reset();

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:146:4: edgeop INT
                    {
                    dbg.location(146,4);
                    pushFollow(FOLLOW_edgeop_in_idd743);
                    edgeop52=edgeop();

                    state._fsp--;

                    stream_edgeop.add(edgeop52.getTree());
                    dbg.location(146,11);
                    INT53=(Token)match(input,INT,FOLLOW_INT_in_idd745);  
                    stream_INT.add(INT53);



                    // AST REWRITE
                    // elements: INT, edgeop
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 146:16: -> ^( IM_ID edgeop INT )
                    {
                        dbg.location(146,19);
                        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:146:19: ^( IM_ID edgeop INT )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(146,21);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ID, "IM_ID"), root_1);

                        dbg.location(146,27);
                        adaptor.addChild(root_1, stream_edgeop.nextTree());
                        dbg.location(146,34);
                        adaptor.addChild(root_1, stream_INT.nextNode());

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
        dbg.location(147, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:151:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public final simpletikzParser.numberunit_return numberunit() throws RecognitionException {
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.number_return number54 = null;

        simpletikzParser.unit_return unit55 = null;


        RewriteRuleSubtreeStream stream_unit=new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
        try { dbg.enterRule(getGrammarFileName(), "numberunit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(151, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:152:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:152:4: number ( unit )?
            {
            dbg.location(152,4);
            pushFollow(FOLLOW_number_in_numberunit773);
            number54=number();

            state._fsp--;

            stream_number.add(number54.getTree());
            dbg.location(152,11);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:152:11: ( unit )?
            int alt19=2;
            try { dbg.enterSubRule(19);
            try { dbg.enterDecision(19);

            int LA19_0 = input.LA(1);

            if ( ((LA19_0>=56 && LA19_0<=61)) ) {
                alt19=1;
            }
            } finally {dbg.exitDecision(19);}

            switch (alt19) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:152:11: unit
                    {
                    dbg.location(152,11);
                    pushFollow(FOLLOW_unit_in_numberunit775);
                    unit55=unit();

                    state._fsp--;

                    stream_unit.add(unit55.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(19);}



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
            // 152:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            {
                dbg.location(152,20);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:152:20: ^( IM_NUMBERUNIT number ( unit )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(152,22);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

                dbg.location(152,36);
                adaptor.addChild(root_1, stream_number.nextTree());
                dbg.location(152,43);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:152:43: ( unit )?
                if ( stream_unit.hasNext() ) {
                    dbg.location(152,43);
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
        dbg.location(153, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:156:1: number : ( FLOAT_WO_EXP | INT ) ;
    public final simpletikzParser.number_return number() throws RecognitionException {
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set56=null;

        Object set56_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "number");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(156, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:2: ( ( FLOAT_WO_EXP | INT ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:157:4: ( FLOAT_WO_EXP | INT )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(157,4);
            set56=(Token)input.LT(1);
            if ( (input.LA(1)>=INT && input.LA(1)<=FLOAT_WO_EXP) ) {
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
        dbg.location(158, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:160:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public final simpletikzParser.unit_return unit() throws RecognitionException {
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set57=null;

        Object set57_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(160, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:161:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(161,2);
            set57=(Token)input.LT(1);
            if ( (input.LA(1)>=56 && input.LA(1)<=61) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set57));
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
        dbg.location(162, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:164:1: tikz_set : tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public final simpletikzParser.tikz_set_return tikz_set() throws RecognitionException {
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal60=null;
        simpletikzParser.tikz_set_start_return tikz_set_start58 = null;

        simpletikzParser.option_return option59 = null;

        simpletikzParser.option_return option61 = null;

        simpletikzParser.roundbr_end_return roundbr_end62 = null;


        Object char_literal60_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_tikz_set_start=new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end=new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try { dbg.enterRule(getGrammarFileName(), "tikz_set");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(164, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:2: ( tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:5: tikz_set_start ( option ( ',' option )* )? roundbr_end
            {
            dbg.location(165,5);
            pushFollow(FOLLOW_tikz_set_start_in_tikz_set856);
            tikz_set_start58=tikz_set_start();

            state._fsp--;

            stream_tikz_set_start.add(tikz_set_start58.getTree());
            dbg.location(165,20);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:20: ( option ( ',' option )* )?
            int alt21=2;
            try { dbg.enterSubRule(21);
            try { dbg.enterDecision(21);

            int LA21_0 = input.LA(1);

            if ( (LA21_0==ID||(LA21_0>=68 && LA21_0<=71)) ) {
                alt21=1;
            }
            } finally {dbg.exitDecision(21);}

            switch (alt21) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:21: option ( ',' option )*
                    {
                    dbg.location(165,21);
                    pushFollow(FOLLOW_option_in_tikz_set859);
                    option59=option();

                    state._fsp--;

                    stream_option.add(option59.getTree());
                    dbg.location(165,28);
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:28: ( ',' option )*
                    try { dbg.enterSubRule(20);

                    loop20:
                    do {
                        int alt20=2;
                        try { dbg.enterDecision(20);

                        int LA20_0 = input.LA(1);

                        if ( (LA20_0==KOMMA) ) {
                            alt20=1;
                        }


                        } finally {dbg.exitDecision(20);}

                        switch (alt20) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:29: ',' option
                    	    {
                    	    dbg.location(165,29);
                    	    char_literal60=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_set862);  
                    	    stream_KOMMA.add(char_literal60);

                    	    dbg.location(165,33);
                    	    pushFollow(FOLLOW_option_in_tikz_set864);
                    	    option61=option();

                    	    state._fsp--;

                    	    stream_option.add(option61.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop20;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(20);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(21);}

            dbg.location(165,44);
            pushFollow(FOLLOW_roundbr_end_in_tikz_set870);
            roundbr_end62=roundbr_end();

            state._fsp--;

            stream_roundbr_end.add(roundbr_end62.getTree());


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
            // 165:56: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            {
                dbg.location(165,59);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:59: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(165,61);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_TIKZSET, "IM_TIKZSET"), root_1);

                dbg.location(165,72);
                adaptor.addChild(root_1, stream_tikz_set_start.nextTree());
                dbg.location(165,87);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:165:87: ( option )*
                while ( stream_option.hasNext() ) {
                    dbg.location(165,87);
                    adaptor.addChild(root_1, stream_option.nextTree());

                }
                stream_option.reset();
                dbg.location(165,95);
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
        dbg.location(166, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:170:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public final simpletikzParser.tikzpicture_return tikzpicture() throws RecognitionException {
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start63 = null;

        simpletikzParser.tikz_options_return tikz_options64 = null;

        simpletikzParser.tikzbody_return tikzbody65 = null;

        simpletikzParser.tikzpicture_end_return tikzpicture_end66 = null;


        RewriteRuleSubtreeStream stream_tikzpicture_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikzpicture");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(170, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:171:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:171:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            dbg.location(171,5);
            pushFollow(FOLLOW_tikzpicture_start_in_tikzpicture898);
            tikzpicture_start63=tikzpicture_start();

            state._fsp--;

            stream_tikzpicture_start.add(tikzpicture_start63.getTree());
            dbg.location(171,23);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:171:23: ( tikz_options )?
            int alt22=2;
            try { dbg.enterSubRule(22);
            try { dbg.enterDecision(22);

            int LA22_0 = input.LA(1);

            if ( (LA22_0==LBR) ) {
                alt22=1;
            }
            } finally {dbg.exitDecision(22);}

            switch (alt22) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:171:23: tikz_options
                    {
                    dbg.location(171,23);
                    pushFollow(FOLLOW_tikz_options_in_tikzpicture900);
                    tikz_options64=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options64.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(22);}

            dbg.location(171,37);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:171:37: ( tikzbody )?
            int alt23=2;
            try { dbg.enterSubRule(23);
            try { dbg.enterDecision(23);

            int LA23_0 = input.LA(1);

            if ( (LA23_0==BEGIN||(LA23_0>=USETIKZLIB && LA23_0<=RPAR)||(LA23_0>=RBR && LA23_0<=75)) ) {
                alt23=1;
            }
            else if ( (LA23_0==END) ) {
                int LA23_2 = input.LA(2);

                if ( (LA23_2==LBRR) ) {
                    int LA23_3 = input.LA(3);

                    if ( (LA23_3==ID||(LA23_3>=68 && LA23_3<=71)) ) {
                        alt23=1;
                    }
                }
            }
            } finally {dbg.exitDecision(23);}

            switch (alt23) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:171:37: tikzbody
                    {
                    dbg.location(171,37);
                    pushFollow(FOLLOW_tikzbody_in_tikzpicture903);
                    tikzbody65=tikzbody();

                    state._fsp--;

                    stream_tikzbody.add(tikzbody65.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(23);}

            dbg.location(171,47);
            pushFollow(FOLLOW_tikzpicture_end_in_tikzpicture906);
            tikzpicture_end66=tikzpicture_end();

            state._fsp--;

            stream_tikzpicture_end.add(tikzpicture_end66.getTree());


            // AST REWRITE
            // elements: tikzpicture_start, tikzbody, tikz_options, tikzpicture_end
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 171:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            {
                dbg.location(171,67);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:171:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(171,69);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PICTURE, "IM_PICTURE"), root_1);

                dbg.location(171,80);
                adaptor.addChild(root_1, stream_tikzpicture_start.nextTree());
                dbg.location(171,98);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:171:98: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(171,98);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                dbg.location(171,112);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:171:112: ( tikzbody )?
                if ( stream_tikzbody.hasNext() ) {
                    dbg.location(171,112);
                    adaptor.addChild(root_1, stream_tikzbody.nextTree());

                }
                stream_tikzbody.reset();
                dbg.location(171,122);
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
        dbg.location(172, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:174:1: tikzbody : ( tikzscope | tikzpath | tikznode_ext | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznode_ext | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )* ;
    public final simpletikzParser.tikzbody_return tikzbody() throws RecognitionException {
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope67 = null;

        simpletikzParser.tikzpath_return tikzpath68 = null;

        simpletikzParser.tikznode_ext_return tikznode_ext69 = null;

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr70 = null;

        simpletikzParser.tikz_set_return tikz_set71 = null;

        simpletikzParser.tikz_style_return tikz_style72 = null;

        simpletikzParser.otherbegin_return otherbegin73 = null;

        simpletikzParser.otherend_return otherend74 = null;

        simpletikzParser.tikzscope_return tikzscope75 = null;

        simpletikzParser.tikzpath_return tikzpath76 = null;

        simpletikzParser.tikznode_ext_return tikznode_ext77 = null;

        simpletikzParser.dontcare_body_return dontcare_body78 = null;

        simpletikzParser.tikz_set_return tikz_set79 = null;

        simpletikzParser.tikz_style_return tikz_style80 = null;

        simpletikzParser.otherbegin_return otherbegin81 = null;

        simpletikzParser.otherend_return otherend82 = null;



        try { dbg.enterRule(getGrammarFileName(), "tikzbody");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(174, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:175:2: ( ( tikzscope | tikzpath | tikznode_ext | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznode_ext | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )* )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:175:4: ( tikzscope | tikzpath | tikznode_ext | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznode_ext | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(175,4);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:175:4: ( tikzscope | tikzpath | tikznode_ext | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend )
            int alt24=8;
            try { dbg.enterSubRule(24);
            try { dbg.enterDecision(24);

            try {
                isCyclicDecision = true;
                alt24 = dfa24.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(24);}

            switch (alt24) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:175:6: tikzscope
                    {
                    dbg.location(175,6);
                    pushFollow(FOLLOW_tikzscope_in_tikzbody936);
                    tikzscope67=tikzscope();

                    state._fsp--;

                    adaptor.addChild(root_0, tikzscope67.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:175:18: tikzpath
                    {
                    dbg.location(175,18);
                    pushFollow(FOLLOW_tikzpath_in_tikzbody940);
                    tikzpath68=tikzpath();

                    state._fsp--;

                    adaptor.addChild(root_0, tikzpath68.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:175:29: tikznode_ext
                    {
                    dbg.location(175,29);
                    pushFollow(FOLLOW_tikznode_ext_in_tikzbody944);
                    tikznode_ext69=tikznode_ext();

                    state._fsp--;

                    adaptor.addChild(root_0, tikznode_ext69.getTree());

                    }
                    break;
                case 4 :
                    dbg.enterAlt(4);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:175:44: dontcare_body_nobr
                    {
                    dbg.location(175,44);
                    pushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody948);
                    dontcare_body_nobr70=dontcare_body_nobr();

                    state._fsp--;

                    adaptor.addChild(root_0, dontcare_body_nobr70.getTree());

                    }
                    break;
                case 5 :
                    dbg.enterAlt(5);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:175:65: tikz_set
                    {
                    dbg.location(175,65);
                    pushFollow(FOLLOW_tikz_set_in_tikzbody952);
                    tikz_set71=tikz_set();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_set71.getTree());

                    }
                    break;
                case 6 :
                    dbg.enterAlt(6);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:175:76: tikz_style
                    {
                    dbg.location(175,76);
                    pushFollow(FOLLOW_tikz_style_in_tikzbody956);
                    tikz_style72=tikz_style();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_style72.getTree());

                    }
                    break;
                case 7 :
                    dbg.enterAlt(7);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:175:89: otherbegin
                    {
                    dbg.location(175,89);
                    pushFollow(FOLLOW_otherbegin_in_tikzbody960);
                    otherbegin73=otherbegin();

                    state._fsp--;

                    adaptor.addChild(root_0, otherbegin73.getTree());

                    }
                    break;
                case 8 :
                    dbg.enterAlt(8);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:175:101: otherend
                    {
                    dbg.location(175,101);
                    pushFollow(FOLLOW_otherend_in_tikzbody963);
                    otherend74=otherend();

                    state._fsp--;

                    adaptor.addChild(root_0, otherend74.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(24);}

            dbg.location(176,3);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:176:3: ( tikzscope | tikzpath | tikznode_ext | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*
            try { dbg.enterSubRule(25);

            loop25:
            do {
                int alt25=9;
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

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:176:5: tikzscope
            	    {
            	    dbg.location(176,5);
            	    pushFollow(FOLLOW_tikzscope_in_tikzbody973);
            	    tikzscope75=tikzscope();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzscope75.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:176:17: tikzpath
            	    {
            	    dbg.location(176,17);
            	    pushFollow(FOLLOW_tikzpath_in_tikzbody977);
            	    tikzpath76=tikzpath();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzpath76.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:176:28: tikznode_ext
            	    {
            	    dbg.location(176,28);
            	    pushFollow(FOLLOW_tikznode_ext_in_tikzbody981);
            	    tikznode_ext77=tikznode_ext();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikznode_ext77.getTree());

            	    }
            	    break;
            	case 4 :
            	    dbg.enterAlt(4);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:176:43: dontcare_body
            	    {
            	    dbg.location(176,43);
            	    pushFollow(FOLLOW_dontcare_body_in_tikzbody985);
            	    dontcare_body78=dontcare_body();

            	    state._fsp--;

            	    adaptor.addChild(root_0, dontcare_body78.getTree());

            	    }
            	    break;
            	case 5 :
            	    dbg.enterAlt(5);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:176:59: tikz_set
            	    {
            	    dbg.location(176,59);
            	    pushFollow(FOLLOW_tikz_set_in_tikzbody989);
            	    tikz_set79=tikz_set();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikz_set79.getTree());

            	    }
            	    break;
            	case 6 :
            	    dbg.enterAlt(6);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:176:70: tikz_style
            	    {
            	    dbg.location(176,70);
            	    pushFollow(FOLLOW_tikz_style_in_tikzbody993);
            	    tikz_style80=tikz_style();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikz_style80.getTree());

            	    }
            	    break;
            	case 7 :
            	    dbg.enterAlt(7);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:176:83: otherbegin
            	    {
            	    dbg.location(176,83);
            	    pushFollow(FOLLOW_otherbegin_in_tikzbody997);
            	    otherbegin81=otherbegin();

            	    state._fsp--;

            	    adaptor.addChild(root_0, otherbegin81.getTree());

            	    }
            	    break;
            	case 8 :
            	    dbg.enterAlt(8);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:176:95: otherend
            	    {
            	    dbg.location(176,95);
            	    pushFollow(FOLLOW_otherend_in_tikzbody1000);
            	    otherend82=otherend();

            	    state._fsp--;

            	    adaptor.addChild(root_0, otherend82.getTree());

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
        dbg.location(177, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:179:1: dontcare_body_nobr : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET | LBR ) ) ;
    public final simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() throws RecognitionException {
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set83=null;

        Object set83_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "dontcare_body_nobr");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(179, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:180:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET | LBR ) ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:180:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET | LBR ) )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(180,4);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:180:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET | LBR ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:180:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET | LBR )
            {
            dbg.location(180,5);
            set83=(Token)input.LT(1);
            if ( input.LA(1)==USETIKZLIB||(input.LA(1)>=LPAR && input.LA(1)<=RPAR)||(input.LA(1)>=RBR && input.LA(1)<=75) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set83));
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
        dbg.location(181, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:182:1: dontcare_body : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET ) ) ;
    public final simpletikzParser.dontcare_body_return dontcare_body() throws RecognitionException {
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set84=null;

        Object set84_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "dontcare_body");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(182, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:183:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET ) ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:183:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET ) )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(183,4);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:183:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:183:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | CLIP | TIKZSTYLE | TIKZSET )
            {
            dbg.location(183,5);
            set84=(Token)input.LT(1);
            if ( input.LA(1)==USETIKZLIB||(input.LA(1)>=LPAR && input.LA(1)<=75) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set84));
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
        dbg.location(184, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:185:1: otherend : END '{' idd '}' ;
    public final simpletikzParser.otherend_return otherend() throws RecognitionException {
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token END85=null;
        Token char_literal86=null;
        Token char_literal88=null;
        simpletikzParser.idd_return idd87 = null;


        Object END85_tree=null;
        Object char_literal86_tree=null;
        Object char_literal88_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "otherend");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(185, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:186:2: ( END '{' idd '}' )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:186:4: END '{' idd '}'
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(186,4);
            END85=(Token)match(input,END,FOLLOW_END_in_otherend1121); 
            END85_tree = (Object)adaptor.create(END85);
            adaptor.addChild(root_0, END85_tree);

            dbg.location(186,8);
            char_literal86=(Token)match(input,LBRR,FOLLOW_LBRR_in_otherend1123); 
            char_literal86_tree = (Object)adaptor.create(char_literal86);
            adaptor.addChild(root_0, char_literal86_tree);

            dbg.location(186,12);
            pushFollow(FOLLOW_idd_in_otherend1125);
            idd87=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd87.getTree());
            dbg.location(186,16);
            char_literal88=(Token)match(input,RBRR,FOLLOW_RBRR_in_otherend1127); 
            char_literal88_tree = (Object)adaptor.create(char_literal88);
            adaptor.addChild(root_0, char_literal88_tree);


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:200:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public final simpletikzParser.tikzscope_return tikzscope() throws RecognitionException {
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start89 = null;

        simpletikzParser.tikz_options_return tikz_options90 = null;

        simpletikzParser.tikzbody_return tikzbody91 = null;

        simpletikzParser.tikzscope_end_return tikzscope_end92 = null;


        RewriteRuleSubtreeStream stream_tikzscope_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try { dbg.enterRule(getGrammarFileName(), "tikzscope");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(200, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:201:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:201:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            dbg.location(201,4);
            pushFollow(FOLLOW_tikzscope_start_in_tikzscope1154);
            tikzscope_start89=tikzscope_start();

            state._fsp--;

            stream_tikzscope_start.add(tikzscope_start89.getTree());
            dbg.location(201,20);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:201:20: ( tikz_options )?
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

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:201:20: tikz_options
                    {
                    dbg.location(201,20);
                    pushFollow(FOLLOW_tikz_options_in_tikzscope1156);
                    tikz_options90=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options90.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(26);}

            dbg.location(201,34);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:201:34: ( tikzbody )?
            int alt27=2;
            try { dbg.enterSubRule(27);
            try { dbg.enterDecision(27);

            int LA27_0 = input.LA(1);

            if ( (LA27_0==BEGIN||(LA27_0>=USETIKZLIB && LA27_0<=RPAR)||(LA27_0>=RBR && LA27_0<=75)) ) {
                alt27=1;
            }
            else if ( (LA27_0==END) ) {
                int LA27_2 = input.LA(2);

                if ( (LA27_2==LBRR) ) {
                    int LA27_3 = input.LA(3);

                    if ( (LA27_3==ID||(LA27_3>=68 && LA27_3<=71)) ) {
                        alt27=1;
                    }
                }
            }
            } finally {dbg.exitDecision(27);}

            switch (alt27) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:201:34: tikzbody
                    {
                    dbg.location(201,34);
                    pushFollow(FOLLOW_tikzbody_in_tikzscope1159);
                    tikzbody91=tikzbody();

                    state._fsp--;

                    stream_tikzbody.add(tikzbody91.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(27);}

            dbg.location(201,44);
            pushFollow(FOLLOW_tikzscope_end_in_tikzscope1162);
            tikzscope_end92=tikzscope_end();

            state._fsp--;

            stream_tikzscope_end.add(tikzscope_end92.getTree());


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
            // 201:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            {
                dbg.location(201,62);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:201:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(201,64);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_SCOPE, "IM_SCOPE"), root_1);

                dbg.location(201,73);
                adaptor.addChild(root_1, stream_tikzscope_start.nextTree());
                dbg.location(201,89);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:201:89: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    dbg.location(201,89);
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                dbg.location(201,103);
                adaptor.addChild(root_1, stream_tikzbody.nextTree());
                dbg.location(201,112);
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
        dbg.location(202, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzscope");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzscope"

    public static class tikzpath_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpath"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:227:1: tikzpath : path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) ;
    public final simpletikzParser.tikzpath_return tikzpath() throws RecognitionException {
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_return path_start93 = null;

        simpletikzParser.tikzpath_element_return tikzpath_element94 = null;

        simpletikzParser.semicolon_end_return semicolon_end95 = null;


        RewriteRuleSubtreeStream stream_tikzpath_element=new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_path_start=new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_semicolon_end=new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try { dbg.enterRule(getGrammarFileName(), "tikzpath");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(227, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:228:2: ( path_start ( tikzpath_element )* semicolon_end -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:228:4: path_start ( tikzpath_element )* semicolon_end
            {
            dbg.location(228,4);
            pushFollow(FOLLOW_path_start_in_tikzpath1217);
            path_start93=path_start();

            state._fsp--;

            stream_path_start.add(path_start93.getTree());
            dbg.location(228,15);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:228:15: ( tikzpath_element )*
            try { dbg.enterSubRule(28);

            loop28:
            do {
                int alt28=2;
                try { dbg.enterDecision(28);

                int LA28_0 = input.LA(1);

                if ( (LA28_0==LPAR||LA28_0==LBR||LA28_0==LBRR||LA28_0==ID||LA28_0==62||(LA28_0>=64 && LA28_0<=66)||(LA28_0>=68 && LA28_0<=73)) ) {
                    alt28=1;
                }


                } finally {dbg.exitDecision(28);}

                switch (alt28) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:228:15: tikzpath_element
            	    {
            	    dbg.location(228,15);
            	    pushFollow(FOLLOW_tikzpath_element_in_tikzpath1219);
            	    tikzpath_element94=tikzpath_element();

            	    state._fsp--;

            	    stream_tikzpath_element.add(tikzpath_element94.getTree());

            	    }
            	    break;

            	default :
            	    break loop28;
                }
            } while (true);
            } finally {dbg.exitSubRule(28);}

            dbg.location(228,33);
            pushFollow(FOLLOW_semicolon_end_in_tikzpath1222);
            semicolon_end95=semicolon_end();

            state._fsp--;

            stream_semicolon_end.add(semicolon_end95.getTree());


            // AST REWRITE
            // elements: tikzpath_element, path_start, semicolon_end
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 228:47: -> ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
            {
                dbg.location(228,50);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:228:50: ^( IM_PATH path_start ( tikzpath_element )* semicolon_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(228,52);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(228,60);
                adaptor.addChild(root_1, stream_path_start.nextTree());
                dbg.location(228,71);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:228:71: ( tikzpath_element )*
                while ( stream_tikzpath_element.hasNext() ) {
                    dbg.location(228,71);
                    adaptor.addChild(root_1, stream_tikzpath_element.nextTree());

                }
                stream_tikzpath_element.reset();
                dbg.location(228,89);
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
        dbg.location(229, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzpath");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzpath"

    public static class tikzpath_element_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpath_element"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:231:1: tikzpath_element : ( tikz_options | coord | tikznode_int | circle | arc | LBRR ( tikzpath_element )* RBRR | edgeop );
    public final simpletikzParser.tikzpath_element_return tikzpath_element() throws RecognitionException {
        simpletikzParser.tikzpath_element_return retval = new simpletikzParser.tikzpath_element_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LBRR101=null;
        Token RBRR103=null;
        simpletikzParser.tikz_options_return tikz_options96 = null;

        simpletikzParser.coord_return coord97 = null;

        simpletikzParser.tikznode_int_return tikznode_int98 = null;

        simpletikzParser.circle_return circle99 = null;

        simpletikzParser.arc_return arc100 = null;

        simpletikzParser.tikzpath_element_return tikzpath_element102 = null;

        simpletikzParser.edgeop_return edgeop104 = null;


        Object LBRR101_tree=null;
        Object RBRR103_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "tikzpath_element");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(231, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:232:2: ( tikz_options | coord | tikznode_int | circle | arc | LBRR ( tikzpath_element )* RBRR | edgeop )
            int alt30=7;
            try { dbg.enterDecision(30);

            switch ( input.LA(1) ) {
            case LBR:
                {
                alt30=1;
                }
                break;
            case LPAR:
            case 72:
            case 73:
                {
                alt30=2;
                }
                break;
            case 62:
                {
                alt30=3;
                }
                break;
            case 64:
            case 65:
                {
                alt30=4;
                }
                break;
            case 66:
                {
                alt30=5;
                }
                break;
            case LBRR:
                {
                alt30=6;
                }
                break;
            case ID:
            case 68:
            case 69:
            case 70:
            case 71:
                {
                alt30=7;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 30, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(30);}

            switch (alt30) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:233:5: tikz_options
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(233,5);
                    pushFollow(FOLLOW_tikz_options_in_tikzpath_element1251);
                    tikz_options96=tikz_options();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_options96.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:234:5: coord
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(234,5);
                    pushFollow(FOLLOW_coord_in_tikzpath_element1258);
                    coord97=coord();

                    state._fsp--;

                    adaptor.addChild(root_0, coord97.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:235:5: tikznode_int
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(235,5);
                    pushFollow(FOLLOW_tikznode_int_in_tikzpath_element1264);
                    tikznode_int98=tikznode_int();

                    state._fsp--;

                    adaptor.addChild(root_0, tikznode_int98.getTree());

                    }
                    break;
                case 4 :
                    dbg.enterAlt(4);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:236:5: circle
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(236,5);
                    pushFollow(FOLLOW_circle_in_tikzpath_element1270);
                    circle99=circle();

                    state._fsp--;

                    adaptor.addChild(root_0, circle99.getTree());

                    }
                    break;
                case 5 :
                    dbg.enterAlt(5);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:237:5: arc
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(237,5);
                    pushFollow(FOLLOW_arc_in_tikzpath_element1276);
                    arc100=arc();

                    state._fsp--;

                    adaptor.addChild(root_0, arc100.getTree());

                    }
                    break;
                case 6 :
                    dbg.enterAlt(6);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:238:5: LBRR ( tikzpath_element )* RBRR
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(238,5);
                    LBRR101=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzpath_element1282); 
                    LBRR101_tree = (Object)adaptor.create(LBRR101);
                    adaptor.addChild(root_0, LBRR101_tree);

                    dbg.location(238,10);
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:238:10: ( tikzpath_element )*
                    try { dbg.enterSubRule(29);

                    loop29:
                    do {
                        int alt29=2;
                        try { dbg.enterDecision(29);

                        int LA29_0 = input.LA(1);

                        if ( (LA29_0==LPAR||LA29_0==LBR||LA29_0==LBRR||LA29_0==ID||LA29_0==62||(LA29_0>=64 && LA29_0<=66)||(LA29_0>=68 && LA29_0<=73)) ) {
                            alt29=1;
                        }


                        } finally {dbg.exitDecision(29);}

                        switch (alt29) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:238:10: tikzpath_element
                    	    {
                    	    dbg.location(238,10);
                    	    pushFollow(FOLLOW_tikzpath_element_in_tikzpath_element1284);
                    	    tikzpath_element102=tikzpath_element();

                    	    state._fsp--;

                    	    adaptor.addChild(root_0, tikzpath_element102.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop29;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(29);}

                    dbg.location(238,28);
                    RBRR103=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzpath_element1287); 
                    RBRR103_tree = (Object)adaptor.create(RBRR103);
                    adaptor.addChild(root_0, RBRR103_tree);


                    }
                    break;
                case 7 :
                    dbg.enterAlt(7);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:239:5: edgeop
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(239,5);
                    pushFollow(FOLLOW_edgeop_in_tikzpath_element1293);
                    edgeop104=edgeop();

                    state._fsp--;

                    adaptor.addChild(root_0, edgeop104.getTree());

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
        dbg.location(240, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikzpath_element");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikzpath_element"

    public static class tikznode_ext_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznode_ext"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:241:1: tikznode_ext : node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) ;
    public final simpletikzParser.tikznode_ext_return tikznode_ext() throws RecognitionException {
        simpletikzParser.tikznode_ext_return retval = new simpletikzParser.tikznode_ext_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.node_start_return node_start105 = null;

        simpletikzParser.tikznode_core_return tikznode_core106 = null;

        simpletikzParser.tikzpath_element_return tikzpath_element107 = null;

        simpletikzParser.semicolon_end_return semicolon_end108 = null;


        RewriteRuleSubtreeStream stream_tikzpath_element=new RewriteRuleSubtreeStream(adaptor,"rule tikzpath_element");
        RewriteRuleSubtreeStream stream_node_start=new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode_core=new RewriteRuleSubtreeStream(adaptor,"rule tikznode_core");
        RewriteRuleSubtreeStream stream_semicolon_end=new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        try { dbg.enterRule(getGrammarFileName(), "tikznode_ext");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(241, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:242:2: ( node_start tikznode_core ( tikzpath_element )* semicolon_end -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:242:4: node_start tikznode_core ( tikzpath_element )* semicolon_end
            {
            dbg.location(242,4);
            pushFollow(FOLLOW_node_start_in_tikznode_ext1304);
            node_start105=node_start();

            state._fsp--;

            stream_node_start.add(node_start105.getTree());
            dbg.location(242,15);
            pushFollow(FOLLOW_tikznode_core_in_tikznode_ext1306);
            tikznode_core106=tikznode_core();

            state._fsp--;

            stream_tikznode_core.add(tikznode_core106.getTree());
            dbg.location(242,29);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:242:29: ( tikzpath_element )*
            try { dbg.enterSubRule(31);

            loop31:
            do {
                int alt31=2;
                try { dbg.enterDecision(31);

                int LA31_0 = input.LA(1);

                if ( (LA31_0==LPAR||LA31_0==LBR||LA31_0==LBRR||LA31_0==ID||LA31_0==62||(LA31_0>=64 && LA31_0<=66)||(LA31_0>=68 && LA31_0<=73)) ) {
                    alt31=1;
                }


                } finally {dbg.exitDecision(31);}

                switch (alt31) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:242:29: tikzpath_element
            	    {
            	    dbg.location(242,29);
            	    pushFollow(FOLLOW_tikzpath_element_in_tikznode_ext1308);
            	    tikzpath_element107=tikzpath_element();

            	    state._fsp--;

            	    stream_tikzpath_element.add(tikzpath_element107.getTree());

            	    }
            	    break;

            	default :
            	    break loop31;
                }
            } while (true);
            } finally {dbg.exitSubRule(31);}

            dbg.location(242,47);
            pushFollow(FOLLOW_semicolon_end_in_tikznode_ext1311);
            semicolon_end108=semicolon_end();

            state._fsp--;

            stream_semicolon_end.add(semicolon_end108.getTree());


            // AST REWRITE
            // elements: semicolon_end, node_start, tikznode_core, tikzpath_element
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 242:61: -> ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
            {
                dbg.location(242,64);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:242:64: ^( IM_PATH node_start tikznode_core ( tikzpath_element )* semicolon_end )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(242,66);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                dbg.location(242,74);
                adaptor.addChild(root_1, stream_node_start.nextTree());
                dbg.location(242,85);
                adaptor.addChild(root_1, stream_tikznode_core.nextTree());
                dbg.location(242,99);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:242:99: ( tikzpath_element )*
                while ( stream_tikzpath_element.hasNext() ) {
                    dbg.location(242,99);
                    adaptor.addChild(root_1, stream_tikzpath_element.nextTree());

                }
                stream_tikzpath_element.reset();
                dbg.location(242,117);
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
        dbg.location(243, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikznode_ext");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikznode_ext"

    public static class tikznode_int_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznode_int"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:244:1: tikznode_int : 'node' tikznode_core ;
    public final simpletikzParser.tikznode_int_return tikznode_int() throws RecognitionException {
        simpletikzParser.tikznode_int_return retval = new simpletikzParser.tikznode_int_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal109=null;
        simpletikzParser.tikznode_core_return tikznode_core110 = null;


        Object string_literal109_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "tikznode_int");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(244, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:245:2: ( 'node' tikznode_core )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:245:4: 'node' tikznode_core
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(245,10);
            string_literal109=(Token)match(input,62,FOLLOW_62_in_tikznode_int1336); 
            dbg.location(245,12);
            pushFollow(FOLLOW_tikznode_core_in_tikznode_int1339);
            tikznode_core110=tikznode_core();

            state._fsp--;

            adaptor.addChild(root_0, tikznode_core110.getTree());

            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(246, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikznode_int");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikznode_int"

    public static class tikznode_core_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznode_core"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:247:1: tikznode_core : ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) ;
    public final simpletikzParser.tikznode_core_return tikznode_core() throws RecognitionException {
        simpletikzParser.tikznode_core_return retval = new simpletikzParser.tikznode_core_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikznode_decorator_return tikznode_decorator111 = null;

        simpletikzParser.tikzstring_return tikzstring112 = null;


        RewriteRuleSubtreeStream stream_tikzstring=new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_tikznode_decorator=new RewriteRuleSubtreeStream(adaptor,"rule tikznode_decorator");
        try { dbg.enterRule(getGrammarFileName(), "tikznode_core");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(247, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:248:2: ( ( tikznode_decorator )* tikzstring -> ^( IM_NODE ( tikznode_decorator )* tikzstring ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:248:4: ( tikznode_decorator )* tikzstring
            {
            dbg.location(248,4);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:248:4: ( tikznode_decorator )*
            try { dbg.enterSubRule(32);

            loop32:
            do {
                int alt32=2;
                try { dbg.enterDecision(32);

                int LA32_0 = input.LA(1);

                if ( (LA32_0==LPAR||LA32_0==LBR||LA32_0==63) ) {
                    alt32=1;
                }


                } finally {dbg.exitDecision(32);}

                switch (alt32) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:248:4: tikznode_decorator
            	    {
            	    dbg.location(248,4);
            	    pushFollow(FOLLOW_tikznode_decorator_in_tikznode_core1349);
            	    tikznode_decorator111=tikznode_decorator();

            	    state._fsp--;

            	    stream_tikznode_decorator.add(tikznode_decorator111.getTree());

            	    }
            	    break;

            	default :
            	    break loop32;
                }
            } while (true);
            } finally {dbg.exitSubRule(32);}

            dbg.location(248,24);
            pushFollow(FOLLOW_tikzstring_in_tikznode_core1352);
            tikzstring112=tikzstring();

            state._fsp--;

            stream_tikzstring.add(tikzstring112.getTree());


            // AST REWRITE
            // elements: tikzstring, tikznode_decorator
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 248:36: -> ^( IM_NODE ( tikznode_decorator )* tikzstring )
            {
                dbg.location(248,39);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:248:39: ^( IM_NODE ( tikznode_decorator )* tikzstring )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(248,41);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODE, "IM_NODE"), root_1);

                dbg.location(248,49);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:248:49: ( tikznode_decorator )*
                while ( stream_tikznode_decorator.hasNext() ) {
                    dbg.location(248,49);
                    adaptor.addChild(root_1, stream_tikznode_decorator.nextTree());

                }
                stream_tikznode_decorator.reset();
                dbg.location(248,69);
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
        dbg.location(249, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikznode_core");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikznode_core"

    public static class tikznode_decorator_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznode_decorator"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:253:1: tikznode_decorator : ( nodename | 'at' coord | tikz_options );
    public final simpletikzParser.tikznode_decorator_return tikznode_decorator() throws RecognitionException {
        simpletikzParser.tikznode_decorator_return retval = new simpletikzParser.tikznode_decorator_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal114=null;
        simpletikzParser.nodename_return nodename113 = null;

        simpletikzParser.coord_return coord115 = null;

        simpletikzParser.tikz_options_return tikz_options116 = null;


        Object string_literal114_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "tikznode_decorator");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(253, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:254:2: ( nodename | 'at' coord | tikz_options )
            int alt33=3;
            try { dbg.enterDecision(33);

            switch ( input.LA(1) ) {
            case LPAR:
                {
                alt33=1;
                }
                break;
            case 63:
                {
                alt33=2;
                }
                break;
            case LBR:
                {
                alt33=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 33, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(33);}

            switch (alt33) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:254:6: nodename
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(254,6);
                    pushFollow(FOLLOW_nodename_in_tikznode_decorator1379);
                    nodename113=nodename();

                    state._fsp--;

                    adaptor.addChild(root_0, nodename113.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:255:5: 'at' coord
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(255,9);
                    string_literal114=(Token)match(input,63,FOLLOW_63_in_tikznode_decorator1386); 
                    dbg.location(255,11);
                    pushFollow(FOLLOW_coord_in_tikznode_decorator1389);
                    coord115=coord();

                    state._fsp--;

                    adaptor.addChild(root_0, coord115.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:256:5: tikz_options
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(256,5);
                    pushFollow(FOLLOW_tikz_options_in_tikznode_decorator1395);
                    tikz_options116=tikz_options();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_options116.getTree());

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
        dbg.location(257, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikznode_decorator");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikznode_decorator"

    public static class tikz_options_dontcare_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_options_dontcare"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:258:1: tikz_options_dontcare : LBR ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* RBR -> ^( IM_OPTIONS ) ;
    public final simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare() throws RecognitionException {
        simpletikzParser.tikz_options_dontcare_return retval = new simpletikzParser.tikz_options_dontcare_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LBR117=null;
        Token RBR121=null;
        simpletikzParser.no_rlbracket_return no_rlbracket118 = null;

        simpletikzParser.tikz_options_dontcare_return tikz_options_dontcare119 = null;

        simpletikzParser.no_rlbracket_return no_rlbracket120 = null;


        Object LBR117_tree=null;
        Object RBR121_tree=null;
        RewriteRuleTokenStream stream_RBR=new RewriteRuleTokenStream(adaptor,"token RBR");
        RewriteRuleTokenStream stream_LBR=new RewriteRuleTokenStream(adaptor,"token LBR");
        RewriteRuleSubtreeStream stream_tikz_options_dontcare=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options_dontcare");
        RewriteRuleSubtreeStream stream_no_rlbracket=new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try { dbg.enterRule(getGrammarFileName(), "tikz_options_dontcare");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(258, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:259:2: ( LBR ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* RBR -> ^( IM_OPTIONS ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:259:4: LBR ( no_rlbracket )* ( tikz_options_dontcare ( no_rlbracket )* )* RBR
            {
            dbg.location(259,4);
            LBR117=(Token)match(input,LBR,FOLLOW_LBR_in_tikz_options_dontcare1405);  
            stream_LBR.add(LBR117);

            dbg.location(259,8);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:259:8: ( no_rlbracket )*
            try { dbg.enterSubRule(34);

            loop34:
            do {
                int alt34=2;
                try { dbg.enterDecision(34);

                int LA34_0 = input.LA(1);

                if ( ((LA34_0>=BEGIN && LA34_0<=RPAR)||(LA34_0>=LBRR && LA34_0<=75)) ) {
                    alt34=1;
                }


                } finally {dbg.exitDecision(34);}

                switch (alt34) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:259:8: no_rlbracket
            	    {
            	    dbg.location(259,8);
            	    pushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare1407);
            	    no_rlbracket118=no_rlbracket();

            	    state._fsp--;

            	    stream_no_rlbracket.add(no_rlbracket118.getTree());

            	    }
            	    break;

            	default :
            	    break loop34;
                }
            } while (true);
            } finally {dbg.exitSubRule(34);}

            dbg.location(259,22);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:259:22: ( tikz_options_dontcare ( no_rlbracket )* )*
            try { dbg.enterSubRule(36);

            loop36:
            do {
                int alt36=2;
                try { dbg.enterDecision(36);

                int LA36_0 = input.LA(1);

                if ( (LA36_0==LBR) ) {
                    alt36=1;
                }


                } finally {dbg.exitDecision(36);}

                switch (alt36) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:259:23: tikz_options_dontcare ( no_rlbracket )*
            	    {
            	    dbg.location(259,23);
            	    pushFollow(FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare1411);
            	    tikz_options_dontcare119=tikz_options_dontcare();

            	    state._fsp--;

            	    stream_tikz_options_dontcare.add(tikz_options_dontcare119.getTree());
            	    dbg.location(259,45);
            	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:259:45: ( no_rlbracket )*
            	    try { dbg.enterSubRule(35);

            	    loop35:
            	    do {
            	        int alt35=2;
            	        try { dbg.enterDecision(35);

            	        int LA35_0 = input.LA(1);

            	        if ( ((LA35_0>=BEGIN && LA35_0<=RPAR)||(LA35_0>=LBRR && LA35_0<=75)) ) {
            	            alt35=1;
            	        }


            	        } finally {dbg.exitDecision(35);}

            	        switch (alt35) {
            	    	case 1 :
            	    	    dbg.enterAlt(1);

            	    	    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:259:45: no_rlbracket
            	    	    {
            	    	    dbg.location(259,45);
            	    	    pushFollow(FOLLOW_no_rlbracket_in_tikz_options_dontcare1413);
            	    	    no_rlbracket120=no_rlbracket();

            	    	    state._fsp--;

            	    	    stream_no_rlbracket.add(no_rlbracket120.getTree());

            	    	    }
            	    	    break;

            	    	default :
            	    	    break loop35;
            	        }
            	    } while (true);
            	    } finally {dbg.exitSubRule(35);}


            	    }
            	    break;

            	default :
            	    break loop36;
                }
            } while (true);
            } finally {dbg.exitSubRule(36);}

            dbg.location(259,61);
            RBR121=(Token)match(input,RBR,FOLLOW_RBR_in_tikz_options_dontcare1418);  
            stream_RBR.add(RBR121);



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
            // 259:65: -> ^( IM_OPTIONS )
            {
                dbg.location(259,68);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:259:68: ^( IM_OPTIONS )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(259,70);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTIONS, "IM_OPTIONS"), root_1);

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
        dbg.location(260, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "tikz_options_dontcare");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "tikz_options_dontcare"

    public static class no_rlbracket_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "no_rlbracket"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:261:1: no_rlbracket : ~ ( LBR | RBR ) ;
    public final simpletikzParser.no_rlbracket_return no_rlbracket() throws RecognitionException {
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set122=null;

        Object set122_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "no_rlbracket");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(261, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:262:2: (~ ( LBR | RBR ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:262:4: ~ ( LBR | RBR )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(262,4);
            set122=(Token)input.LT(1);
            if ( (input.LA(1)>=BEGIN && input.LA(1)<=RPAR)||(input.LA(1)>=LBRR && input.LA(1)<=75) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set122));
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
        dbg.location(263, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "no_rlbracket");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "no_rlbracket"

    public static class nodename_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "nodename"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:264:1: nodename : LPAR idd RPAR -> ^( IM_NODENAME idd ) ;
    public final simpletikzParser.nodename_return nodename() throws RecognitionException {
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LPAR123=null;
        Token RPAR125=null;
        simpletikzParser.idd_return idd124 = null;


        Object LPAR123_tree=null;
        Object RPAR125_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        try { dbg.enterRule(getGrammarFileName(), "nodename");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(264, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:265:2: ( LPAR idd RPAR -> ^( IM_NODENAME idd ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:265:4: LPAR idd RPAR
            {
            dbg.location(265,4);
            LPAR123=(Token)match(input,LPAR,FOLLOW_LPAR_in_nodename1453);  
            stream_LPAR.add(LPAR123);

            dbg.location(265,9);
            pushFollow(FOLLOW_idd_in_nodename1455);
            idd124=idd();

            state._fsp--;

            stream_idd.add(idd124.getTree());
            dbg.location(265,13);
            RPAR125=(Token)match(input,RPAR,FOLLOW_RPAR_in_nodename1457);  
            stream_RPAR.add(RPAR125);



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
            // 265:19: -> ^( IM_NODENAME idd )
            {
                dbg.location(265,22);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:265:22: ^( IM_NODENAME idd )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(265,24);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODENAME, "IM_NODENAME"), root_1);

                dbg.location(265,36);
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
        dbg.location(266, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "nodename");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "nodename"

    public static class circle_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "circle"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:268:1: circle : ( 'circle' | 'ellipse' ) ( size )? ->;
    public final simpletikzParser.circle_return circle() throws RecognitionException {
        simpletikzParser.circle_return retval = new simpletikzParser.circle_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal126=null;
        Token string_literal127=null;
        simpletikzParser.size_return size128 = null;


        Object string_literal126_tree=null;
        Object string_literal127_tree=null;
        RewriteRuleTokenStream stream_64=new RewriteRuleTokenStream(adaptor,"token 64");
        RewriteRuleTokenStream stream_65=new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_size=new RewriteRuleSubtreeStream(adaptor,"rule size");
        try { dbg.enterRule(getGrammarFileName(), "circle");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(268, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:269:2: ( ( 'circle' | 'ellipse' ) ( size )? ->)
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:269:4: ( 'circle' | 'ellipse' ) ( size )?
            {
            dbg.location(269,4);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:269:4: ( 'circle' | 'ellipse' )
            int alt37=2;
            try { dbg.enterSubRule(37);
            try { dbg.enterDecision(37);

            int LA37_0 = input.LA(1);

            if ( (LA37_0==64) ) {
                alt37=1;
            }
            else if ( (LA37_0==65) ) {
                alt37=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 37, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(37);}

            switch (alt37) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:269:5: 'circle'
                    {
                    dbg.location(269,5);
                    string_literal126=(Token)match(input,64,FOLLOW_64_in_circle1479);  
                    stream_64.add(string_literal126);


                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:269:16: 'ellipse'
                    {
                    dbg.location(269,16);
                    string_literal127=(Token)match(input,65,FOLLOW_65_in_circle1483);  
                    stream_65.add(string_literal127);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(37);}

            dbg.location(269,27);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:269:27: ( size )?
            int alt38=2;
            try { dbg.enterSubRule(38);
            try { dbg.enterDecision(38);

            int LA38_0 = input.LA(1);

            if ( (LA38_0==LPAR) ) {
                int LA38_1 = input.LA(2);

                if ( ((LA38_1>=INT && LA38_1<=FLOAT_WO_EXP)) ) {
                    int LA38_3 = input.LA(3);

                    if ( ((LA38_3>=56 && LA38_3<=61)) ) {
                        int LA38_4 = input.LA(4);

                        if ( (LA38_4==RPAR||LA38_4==67) ) {
                            alt38=1;
                        }
                    }
                    else if ( (LA38_3==RPAR||LA38_3==67) ) {
                        alt38=1;
                    }
                }
            }
            } finally {dbg.exitDecision(38);}

            switch (alt38) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:269:27: size
                    {
                    dbg.location(269,27);
                    pushFollow(FOLLOW_size_in_circle1486);
                    size128=size();

                    state._fsp--;

                    stream_size.add(size128.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(38);}



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
            // 269:33: ->
            {
                dbg.location(270,2);
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
        dbg.location(270, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "circle");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "circle"

    public static class arc_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "arc"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:271:1: arc : 'arc' ( LPAR numberunit ':' numberunit ':' numberunit RPAR )? ->;
    public final simpletikzParser.arc_return arc() throws RecognitionException {
        simpletikzParser.arc_return retval = new simpletikzParser.arc_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal129=null;
        Token LPAR130=null;
        Token char_literal132=null;
        Token char_literal134=null;
        Token RPAR136=null;
        simpletikzParser.numberunit_return numberunit131 = null;

        simpletikzParser.numberunit_return numberunit133 = null;

        simpletikzParser.numberunit_return numberunit135 = null;


        Object string_literal129_tree=null;
        Object LPAR130_tree=null;
        Object char_literal132_tree=null;
        Object char_literal134_tree=null;
        Object RPAR136_tree=null;
        RewriteRuleTokenStream stream_COLON=new RewriteRuleTokenStream(adaptor,"token COLON");
        RewriteRuleTokenStream stream_66=new RewriteRuleTokenStream(adaptor,"token 66");
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_numberunit=new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try { dbg.enterRule(getGrammarFileName(), "arc");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(271, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:272:2: ( 'arc' ( LPAR numberunit ':' numberunit ':' numberunit RPAR )? ->)
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:272:4: 'arc' ( LPAR numberunit ':' numberunit ':' numberunit RPAR )?
            {
            dbg.location(272,4);
            string_literal129=(Token)match(input,66,FOLLOW_66_in_arc1500);  
            stream_66.add(string_literal129);

            dbg.location(272,10);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:272:10: ( LPAR numberunit ':' numberunit ':' numberunit RPAR )?
            int alt39=2;
            try { dbg.enterSubRule(39);
            try { dbg.enterDecision(39);

            int LA39_0 = input.LA(1);

            if ( (LA39_0==LPAR) ) {
                int LA39_1 = input.LA(2);

                if ( ((LA39_1>=INT && LA39_1<=FLOAT_WO_EXP)) ) {
                    int LA39_3 = input.LA(3);

                    if ( ((LA39_3>=56 && LA39_3<=61)) ) {
                        int LA39_4 = input.LA(4);

                        if ( (LA39_4==COLON) ) {
                            int LA39_5 = input.LA(5);

                            if ( ((LA39_5>=INT && LA39_5<=FLOAT_WO_EXP)) ) {
                                int LA39_6 = input.LA(6);

                                if ( ((LA39_6>=56 && LA39_6<=61)) ) {
                                    int LA39_7 = input.LA(7);

                                    if ( (LA39_7==COLON) ) {
                                        alt39=1;
                                    }
                                }
                                else if ( (LA39_6==COLON) ) {
                                    alt39=1;
                                }
                            }
                        }
                    }
                    else if ( (LA39_3==COLON) ) {
                        int LA39_5 = input.LA(4);

                        if ( ((LA39_5>=INT && LA39_5<=FLOAT_WO_EXP)) ) {
                            int LA39_6 = input.LA(5);

                            if ( ((LA39_6>=56 && LA39_6<=61)) ) {
                                int LA39_7 = input.LA(6);

                                if ( (LA39_7==COLON) ) {
                                    alt39=1;
                                }
                            }
                            else if ( (LA39_6==COLON) ) {
                                alt39=1;
                            }
                        }
                    }
                }
            }
            } finally {dbg.exitDecision(39);}

            switch (alt39) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:272:11: LPAR numberunit ':' numberunit ':' numberunit RPAR
                    {
                    dbg.location(272,11);
                    LPAR130=(Token)match(input,LPAR,FOLLOW_LPAR_in_arc1503);  
                    stream_LPAR.add(LPAR130);

                    dbg.location(272,16);
                    pushFollow(FOLLOW_numberunit_in_arc1505);
                    numberunit131=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit131.getTree());
                    dbg.location(272,27);
                    char_literal132=(Token)match(input,COLON,FOLLOW_COLON_in_arc1507);  
                    stream_COLON.add(char_literal132);

                    dbg.location(272,31);
                    pushFollow(FOLLOW_numberunit_in_arc1509);
                    numberunit133=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit133.getTree());
                    dbg.location(272,42);
                    char_literal134=(Token)match(input,COLON,FOLLOW_COLON_in_arc1511);  
                    stream_COLON.add(char_literal134);

                    dbg.location(272,46);
                    pushFollow(FOLLOW_numberunit_in_arc1513);
                    numberunit135=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit135.getTree());
                    dbg.location(272,57);
                    RPAR136=(Token)match(input,RPAR,FOLLOW_RPAR_in_arc1515);  
                    stream_RPAR.add(RPAR136);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(39);}



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
            // 272:64: ->
            {
                dbg.location(273,2);
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
        dbg.location(273, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "arc");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "arc"

    public static class size_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "size"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:275:2: size : LPAR numberunit ( 'and' numberunit )? RPAR -> ^( IM_SIZE numberunit ) ;
    public final simpletikzParser.size_return size() throws RecognitionException {
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LPAR137=null;
        Token string_literal139=null;
        Token RPAR141=null;
        simpletikzParser.numberunit_return numberunit138 = null;

        simpletikzParser.numberunit_return numberunit140 = null;


        Object LPAR137_tree=null;
        Object string_literal139_tree=null;
        Object RPAR141_tree=null;
        RewriteRuleTokenStream stream_67=new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_numberunit=new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        try { dbg.enterRule(getGrammarFileName(), "size");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(275, 2);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:276:2: ( LPAR numberunit ( 'and' numberunit )? RPAR -> ^( IM_SIZE numberunit ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:276:6: LPAR numberunit ( 'and' numberunit )? RPAR
            {
            dbg.location(276,6);
            LPAR137=(Token)match(input,LPAR,FOLLOW_LPAR_in_size1534);  
            stream_LPAR.add(LPAR137);

            dbg.location(276,11);
            pushFollow(FOLLOW_numberunit_in_size1536);
            numberunit138=numberunit();

            state._fsp--;

            stream_numberunit.add(numberunit138.getTree());
            dbg.location(276,22);
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:276:22: ( 'and' numberunit )?
            int alt40=2;
            try { dbg.enterSubRule(40);
            try { dbg.enterDecision(40);

            int LA40_0 = input.LA(1);

            if ( (LA40_0==67) ) {
                alt40=1;
            }
            } finally {dbg.exitDecision(40);}

            switch (alt40) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:276:23: 'and' numberunit
                    {
                    dbg.location(276,23);
                    string_literal139=(Token)match(input,67,FOLLOW_67_in_size1539);  
                    stream_67.add(string_literal139);

                    dbg.location(276,29);
                    pushFollow(FOLLOW_numberunit_in_size1541);
                    numberunit140=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit140.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(40);}

            dbg.location(276,42);
            RPAR141=(Token)match(input,RPAR,FOLLOW_RPAR_in_size1545);  
            stream_RPAR.add(RPAR141);



            // AST REWRITE
            // elements: numberunit
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 276:48: -> ^( IM_SIZE numberunit )
            {
                dbg.location(276,51);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:276:51: ^( IM_SIZE numberunit )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(276,53);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_SIZE, "IM_SIZE"), root_1);

                dbg.location(276,61);
                adaptor.addChild(root_1, stream_numberunit.nextTree());

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
        dbg.location(277, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "size");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "size"

    public static class coord_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coord"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:282:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) );
    public final simpletikzParser.coord_return coord() throws RecognitionException {
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LPAR144=null;
        Token RPAR148=null;
        simpletikzParser.nodename_return nodename142 = null;

        simpletikzParser.coord_modifier_return coord_modifier143 = null;

        simpletikzParser.numberunit_return numberunit145 = null;

        simpletikzParser.coord_sep_return coord_sep146 = null;

        simpletikzParser.numberunit_return numberunit147 = null;


        Object LPAR144_tree=null;
        Object RPAR148_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_numberunit=new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_sep=new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier=new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try { dbg.enterRule(getGrammarFileName(), "coord");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(282, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:283:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep ) )
            int alt42=2;
            try { dbg.enterDecision(42);

            int LA42_0 = input.LA(1);

            if ( (LA42_0==LPAR) ) {
                int LA42_1 = input.LA(2);

                if ( ((LA42_1>=INT && LA42_1<=FLOAT_WO_EXP)) ) {
                    alt42=2;
                }
                else if ( (LA42_1==ID||(LA42_1>=68 && LA42_1<=71)) ) {
                    alt42=1;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 42, 1, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
            }
            else if ( ((LA42_0>=72 && LA42_0<=73)) ) {
                alt42=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 42, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(42);}

            switch (alt42) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:283:6: nodename
                    {
                    dbg.location(283,6);
                    pushFollow(FOLLOW_nodename_in_coord1573);
                    nodename142=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename142.getTree());


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
                    // 283:23: -> ^( IM_COORD nodename )
                    {
                        dbg.location(283,26);
                        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:283:26: ^( IM_COORD nodename )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(283,28);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, "IM_COORD"), root_1);

                        dbg.location(283,37);
                        adaptor.addChild(root_1, stream_nodename.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:284:5: ( ( coord_modifier )? LPAR numberunit coord_sep numberunit RPAR )
                    {
                    dbg.location(284,5);
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:284:5: ( ( coord_modifier )? LPAR numberunit coord_sep numberunit RPAR )
                    dbg.enterAlt(1);

                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:284:7: ( coord_modifier )? LPAR numberunit coord_sep numberunit RPAR
                    {
                    dbg.location(284,7);
                    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:284:7: ( coord_modifier )?
                    int alt41=2;
                    try { dbg.enterSubRule(41);
                    try { dbg.enterDecision(41);

                    int LA41_0 = input.LA(1);

                    if ( ((LA41_0>=72 && LA41_0<=73)) ) {
                        alt41=1;
                    }
                    } finally {dbg.exitDecision(41);}

                    switch (alt41) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:284:7: coord_modifier
                            {
                            dbg.location(284,7);
                            pushFollow(FOLLOW_coord_modifier_in_coord1597);
                            coord_modifier143=coord_modifier();

                            state._fsp--;

                            stream_coord_modifier.add(coord_modifier143.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(41);}

                    dbg.location(284,23);
                    LPAR144=(Token)match(input,LPAR,FOLLOW_LPAR_in_coord1600);  
                    stream_LPAR.add(LPAR144);

                    dbg.location(284,28);
                    pushFollow(FOLLOW_numberunit_in_coord1602);
                    numberunit145=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit145.getTree());
                    dbg.location(284,39);
                    pushFollow(FOLLOW_coord_sep_in_coord1604);
                    coord_sep146=coord_sep();

                    state._fsp--;

                    stream_coord_sep.add(coord_sep146.getTree());
                    dbg.location(284,49);
                    pushFollow(FOLLOW_numberunit_in_coord1606);
                    numberunit147=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit147.getTree());
                    dbg.location(284,60);
                    RPAR148=(Token)match(input,RPAR,FOLLOW_RPAR_in_coord1608);  
                    stream_RPAR.add(RPAR148);


                    }



                    // AST REWRITE
                    // elements: coord_modifier, numberunit, coord_sep
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 284:67: -> ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                    {
                        dbg.location(284,70);
                        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:284:70: ^( IM_COORD ( coord_modifier )? ( numberunit )+ coord_sep )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(284,72);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, "IM_COORD"), root_1);

                        dbg.location(284,81);
                        // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:284:81: ( coord_modifier )?
                        if ( stream_coord_modifier.hasNext() ) {
                            dbg.location(284,81);
                            adaptor.addChild(root_1, stream_coord_modifier.nextTree());

                        }
                        stream_coord_modifier.reset();
                        dbg.location(284,97);
                        if ( !(stream_numberunit.hasNext()) ) {
                            throw new RewriteEarlyExitException();
                        }
                        while ( stream_numberunit.hasNext() ) {
                            dbg.location(284,97);
                            adaptor.addChild(root_1, stream_numberunit.nextTree());

                        }
                        stream_numberunit.reset();
                        dbg.location(284,109);
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
        dbg.location(285, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:286:1: coord_sep : ( ',' | ':' ) ;
    public final simpletikzParser.coord_sep_return coord_sep() throws RecognitionException {
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set149=null;

        Object set149_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "coord_sep");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(286, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:287:2: ( ( ',' | ':' ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:287:4: ( ',' | ':' )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(287,4);
            set149=(Token)input.LT(1);
            if ( input.LA(1)==KOMMA||input.LA(1)==COLON ) {
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
        dbg.location(288, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "coord_sep");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "coord_sep"

    public static class edgeop_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "edgeop"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:291:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public final simpletikzParser.edgeop_return edgeop() throws RecognitionException {
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set150=null;

        Object set150_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "edgeop");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(291, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:292:2: ( '--' | '->' | '|-' | '-|' | ID )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(292,2);
            set150=(Token)input.LT(1);
            if ( input.LA(1)==ID||(input.LA(1)>=68 && input.LA(1)<=71) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set150));
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
        dbg.location(293, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:296:1: coord_modifier : ( '+' | '++' );
    public final simpletikzParser.coord_modifier_return coord_modifier() throws RecognitionException {
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set151=null;

        Object set151_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "coord_modifier");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(296, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:297:2: ( '+' | '++' )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(297,2);
            set151=(Token)input.LT(1);
            if ( (input.LA(1)>=72 && input.LA(1)<=73) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set151));
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
        dbg.location(298, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "coord_modifier");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "coord_modifier"

    public static class squarebr_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "squarebr_start"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:339:1: squarebr_start : LBR -> ^( IM_STARTTAG LBR ) ;
    public final simpletikzParser.squarebr_start_return squarebr_start() throws RecognitionException {
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LBR152=null;

        Object LBR152_tree=null;
        RewriteRuleTokenStream stream_LBR=new RewriteRuleTokenStream(adaptor,"token LBR");

        try { dbg.enterRule(getGrammarFileName(), "squarebr_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(339, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:340:2: ( LBR -> ^( IM_STARTTAG LBR ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:340:4: LBR
            {
            dbg.location(340,4);
            LBR152=(Token)match(input,LBR,FOLLOW_LBR_in_squarebr_start1708);  
            stream_LBR.add(LBR152);



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
            // 340:8: -> ^( IM_STARTTAG LBR )
            {
                dbg.location(340,11);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:340:11: ^( IM_STARTTAG LBR )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(340,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(340,25);
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
        dbg.location(341, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:342:1: squarebr_end : RBR -> ^( IM_ENDTAG RBR ) ;
    public final simpletikzParser.squarebr_end_return squarebr_end() throws RecognitionException {
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token RBR153=null;

        Object RBR153_tree=null;
        RewriteRuleTokenStream stream_RBR=new RewriteRuleTokenStream(adaptor,"token RBR");

        try { dbg.enterRule(getGrammarFileName(), "squarebr_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(342, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:343:2: ( RBR -> ^( IM_ENDTAG RBR ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:343:4: RBR
            {
            dbg.location(343,4);
            RBR153=(Token)match(input,RBR,FOLLOW_RBR_in_squarebr_end1726);  
            stream_RBR.add(RBR153);



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
            // 343:8: -> ^( IM_ENDTAG RBR )
            {
                dbg.location(343,11);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:343:11: ^( IM_ENDTAG RBR )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(343,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(343,23);
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
        dbg.location(344, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:345:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public final simpletikzParser.semicolon_end_return semicolon_end() throws RecognitionException {
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal154=null;

        Object char_literal154_tree=null;
        RewriteRuleTokenStream stream_SEMIC=new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try { dbg.enterRule(getGrammarFileName(), "semicolon_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(345, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:346:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:346:4: ';'
            {
            dbg.location(346,4);
            char_literal154=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_semicolon_end1745);  
            stream_SEMIC.add(char_literal154);



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
            // 346:8: -> ^( IM_ENDTAG ';' )
            {
                dbg.location(346,11);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:346:11: ^( IM_ENDTAG ';' )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(346,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(346,23);
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
        dbg.location(347, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:348:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public final simpletikzParser.roundbr_end_return roundbr_end() throws RecognitionException {
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal155=null;

        Object char_literal155_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");

        try { dbg.enterRule(getGrammarFileName(), "roundbr_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(348, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:349:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:349:4: '}'
            {
            dbg.location(349,4);
            char_literal155=(Token)match(input,RBRR,FOLLOW_RBRR_in_roundbr_end1763);  
            stream_RBRR.add(char_literal155);



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
            // 349:8: -> ^( IM_ENDTAG '}' )
            {
                dbg.location(349,11);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:349:11: ^( IM_ENDTAG '}' )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(349,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(349,23);
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
        dbg.location(350, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:351:1: tikz_set_start : TIKZSET '{' -> ^( IM_STARTTAG ) ;
    public final simpletikzParser.tikz_set_start_return tikz_set_start() throws RecognitionException {
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token TIKZSET156=null;
        Token char_literal157=null;

        Object TIKZSET156_tree=null;
        Object char_literal157_tree=null;
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSET=new RewriteRuleTokenStream(adaptor,"token TIKZSET");

        try { dbg.enterRule(getGrammarFileName(), "tikz_set_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(351, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:352:2: ( TIKZSET '{' -> ^( IM_STARTTAG ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:352:4: TIKZSET '{'
            {
            dbg.location(352,4);
            TIKZSET156=(Token)match(input,TIKZSET,FOLLOW_TIKZSET_in_tikz_set_start1781);  
            stream_TIKZSET.add(TIKZSET156);

            dbg.location(352,12);
            char_literal157=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikz_set_start1783);  
            stream_LBRR.add(char_literal157);



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
            // 352:17: -> ^( IM_STARTTAG )
            {
                dbg.location(352,20);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:352:20: ^( IM_STARTTAG )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(352,22);
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
        dbg.location(353, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:354:1: tikzpicture_start : BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public final simpletikzParser.tikzpicture_start_return tikzpicture_start() throws RecognitionException {
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGIN158=null;
        Token char_literal159=null;
        Token string_literal160=null;
        Token char_literal161=null;

        Object BEGIN158_tree=null;
        Object char_literal159_tree=null;
        Object string_literal160_tree=null;
        Object char_literal161_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_BEGIN=new RewriteRuleTokenStream(adaptor,"token BEGIN");
        RewriteRuleTokenStream stream_74=new RewriteRuleTokenStream(adaptor,"token 74");

        try { dbg.enterRule(getGrammarFileName(), "tikzpicture_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(354, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:355:2: ( BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:355:4: BEGIN '{' 'tikzpicture' '}'
            {
            dbg.location(355,4);
            BEGIN158=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_tikzpicture_start1802);  
            stream_BEGIN.add(BEGIN158);

            dbg.location(355,10);
            char_literal159=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_start1804);  
            stream_LBRR.add(char_literal159);

            dbg.location(355,14);
            string_literal160=(Token)match(input,74,FOLLOW_74_in_tikzpicture_start1806);  
            stream_74.add(string_literal160);

            dbg.location(355,28);
            char_literal161=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_start1808);  
            stream_RBRR.add(char_literal161);



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
            // 355:32: -> ^( IM_STARTTAG BEGIN )
            {
                dbg.location(355,35);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:355:35: ^( IM_STARTTAG BEGIN )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(355,37);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(355,49);
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
        dbg.location(356, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:357:1: tikzpicture_end : END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) ;
    public final simpletikzParser.tikzpicture_end_return tikzpicture_end() throws RecognitionException {
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token END162=null;
        Token char_literal163=null;
        Token string_literal164=null;
        Token char_literal165=null;

        Object END162_tree=null;
        Object char_literal163_tree=null;
        Object string_literal164_tree=null;
        Object char_literal165_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END=new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_74=new RewriteRuleTokenStream(adaptor,"token 74");

        try { dbg.enterRule(getGrammarFileName(), "tikzpicture_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(357, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:358:2: ( END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:358:4: END '{' 'tikzpicture' '}'
            {
            dbg.location(358,4);
            END162=(Token)match(input,END,FOLLOW_END_in_tikzpicture_end1826);  
            stream_END.add(END162);

            dbg.location(358,8);
            char_literal163=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_end1828);  
            stream_LBRR.add(char_literal163);

            dbg.location(358,12);
            string_literal164=(Token)match(input,74,FOLLOW_74_in_tikzpicture_end1830);  
            stream_74.add(string_literal164);

            dbg.location(358,26);
            char_literal165=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_end1832);  
            stream_RBRR.add(char_literal165);



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
            // 358:30: -> ^( IM_ENDTAG END )
            {
                dbg.location(358,33);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:358:33: ^( IM_ENDTAG END )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(358,35);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(358,45);
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
        dbg.location(359, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:360:1: tikzscope_start : BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public final simpletikzParser.tikzscope_start_return tikzscope_start() throws RecognitionException {
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGIN166=null;
        Token char_literal167=null;
        Token string_literal168=null;
        Token char_literal169=null;

        Object BEGIN166_tree=null;
        Object char_literal167_tree=null;
        Object string_literal168_tree=null;
        Object char_literal169_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_BEGIN=new RewriteRuleTokenStream(adaptor,"token BEGIN");
        RewriteRuleTokenStream stream_75=new RewriteRuleTokenStream(adaptor,"token 75");

        try { dbg.enterRule(getGrammarFileName(), "tikzscope_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(360, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:361:2: ( BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:361:4: BEGIN '{' 'scope' '}'
            {
            dbg.location(361,4);
            BEGIN166=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_tikzscope_start1850);  
            stream_BEGIN.add(BEGIN166);

            dbg.location(361,10);
            char_literal167=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzscope_start1852);  
            stream_LBRR.add(char_literal167);

            dbg.location(361,14);
            string_literal168=(Token)match(input,75,FOLLOW_75_in_tikzscope_start1854);  
            stream_75.add(string_literal168);

            dbg.location(361,22);
            char_literal169=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzscope_start1856);  
            stream_RBRR.add(char_literal169);



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
            // 361:26: -> ^( IM_STARTTAG BEGIN )
            {
                dbg.location(361,29);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:361:29: ^( IM_STARTTAG BEGIN )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(361,31);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(361,43);
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
        dbg.location(362, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:363:1: tikzscope_end : END '{' 'scope' '}' -> ^( IM_ENDTAG END ) ;
    public final simpletikzParser.tikzscope_end_return tikzscope_end() throws RecognitionException {
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token END170=null;
        Token char_literal171=null;
        Token string_literal172=null;
        Token char_literal173=null;

        Object END170_tree=null;
        Object char_literal171_tree=null;
        Object string_literal172_tree=null;
        Object char_literal173_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END=new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_75=new RewriteRuleTokenStream(adaptor,"token 75");

        try { dbg.enterRule(getGrammarFileName(), "tikzscope_end");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(363, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:364:2: ( END '{' 'scope' '}' -> ^( IM_ENDTAG END ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:364:4: END '{' 'scope' '}'
            {
            dbg.location(364,4);
            END170=(Token)match(input,END,FOLLOW_END_in_tikzscope_end1874);  
            stream_END.add(END170);

            dbg.location(364,8);
            char_literal171=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzscope_end1876);  
            stream_LBRR.add(char_literal171);

            dbg.location(364,12);
            string_literal172=(Token)match(input,75,FOLLOW_75_in_tikzscope_end1878);  
            stream_75.add(string_literal172);

            dbg.location(364,20);
            char_literal173=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzscope_end1880);  
            stream_RBRR.add(char_literal173);



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
            // 364:24: -> ^( IM_ENDTAG END )
            {
                dbg.location(364,27);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:364:27: ^( IM_ENDTAG END )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(364,29);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

                dbg.location(364,39);
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
        dbg.location(365, 2);

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
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:366:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public final simpletikzParser.path_start_return path_start() throws RecognitionException {
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag174 = null;


        RewriteRuleSubtreeStream stream_path_start_tag=new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try { dbg.enterRule(getGrammarFileName(), "path_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(366, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:367:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:367:4: path_start_tag
            {
            dbg.location(367,4);
            pushFollow(FOLLOW_path_start_tag_in_path_start1899);
            path_start_tag174=path_start_tag();

            state._fsp--;

            stream_path_start_tag.add(path_start_tag174.getTree());


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
            // 367:19: -> ^( IM_STARTTAG path_start_tag )
            {
                dbg.location(367,22);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:367:22: ^( IM_STARTTAG path_start_tag )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(367,24);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(367,36);
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
        dbg.location(368, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "path_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "path_start"

    public static class node_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "node_start"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:369:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public final simpletikzParser.node_start_return node_start() throws RecognitionException {
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token NODE175=null;

        Object NODE175_tree=null;
        RewriteRuleTokenStream stream_NODE=new RewriteRuleTokenStream(adaptor,"token NODE");

        try { dbg.enterRule(getGrammarFileName(), "node_start");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(369, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:370:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:370:4: NODE
            {
            dbg.location(370,4);
            NODE175=(Token)match(input,NODE,FOLLOW_NODE_in_node_start1917);  
            stream_NODE.add(NODE175);



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
            // 370:9: -> ^( IM_STARTTAG NODE )
            {
                dbg.location(370,12);
                // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:370:12: ^( IM_STARTTAG NODE )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(370,14);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STARTTAG, "IM_STARTTAG"), root_1);

                dbg.location(370,26);
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
        dbg.location(371, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "node_start");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "node_start"

    public static class path_start_tag_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "path_start_tag"
    // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:372:1: path_start_tag : ( DRAW | FILL | PATH | CLIP );
    public final simpletikzParser.path_start_tag_return path_start_tag() throws RecognitionException {
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set176=null;

        Object set176_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "path_start_tag");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(372, 1);

        try {
            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:373:2: ( DRAW | FILL | PATH | CLIP )
            dbg.enterAlt(1);

            // C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(373,2);
            set176=(Token)input.LT(1);
            if ( (input.LA(1)>=DRAW && input.LA(1)<=CLIP) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set176));
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
        dbg.location(374, 2);

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


    protected DFA8 dfa8 = new DFA8(this);
    protected DFA24 dfa24 = new DFA24(this);
    protected DFA25 dfa25 = new DFA25(this);
    static final String DFA8_eotS =
        "\6\uffff";
    static final String DFA8_eofS =
        "\6\uffff";
    static final String DFA8_minS =
        "\1\57\3\21\2\uffff";
    static final String DFA8_maxS =
        "\2\107\1\67\1\107\2\uffff";
    static final String DFA8_acceptS =
        "\4\uffff\1\2\1\1";
    static final String DFA8_specialS =
        "\6\uffff}>";
    static final String[] DFA8_transitionS = {
            "\1\1\24\uffff\4\1",
            "\1\4\1\uffff\3\4\27\uffff\1\2\1\uffff\1\3\7\uffff\1\5\14\uffff"+
            "\4\3",
            "\1\4\1\uffff\3\4\41\uffff\1\5",
            "\1\4\1\uffff\3\4\31\uffff\1\3\7\uffff\1\5\14\uffff\4\3",
            "",
            ""
    };

    static final short[] DFA8_eot = DFA.unpackEncodedString(DFA8_eotS);
    static final short[] DFA8_eof = DFA.unpackEncodedString(DFA8_eofS);
    static final char[] DFA8_min = DFA.unpackEncodedStringToUnsignedChars(DFA8_minS);
    static final char[] DFA8_max = DFA.unpackEncodedStringToUnsignedChars(DFA8_maxS);
    static final short[] DFA8_accept = DFA.unpackEncodedString(DFA8_acceptS);
    static final short[] DFA8_special = DFA.unpackEncodedString(DFA8_specialS);
    static final short[][] DFA8_transition;

    static {
        int numStates = DFA8_transitionS.length;
        DFA8_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA8_transition[i] = DFA.unpackEncodedString(DFA8_transitionS[i]);
        }
    }

    class DFA8 extends DFA {

        public DFA8(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;
        }
        public String getDescription() {
            return "116:1: option : ( option_style | option_kv );";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
    static final String DFA24_eotS =
        "\13\uffff";
    static final String DFA24_eofS =
        "\13\uffff";
    static final String DFA24_minS =
        "\1\4\1\22\6\uffff\1\57\2\uffff";
    static final String DFA24_maxS =
        "\1\113\1\22\6\uffff\1\113\2\uffff";
    static final String DFA24_acceptS =
        "\2\uffff\1\2\1\3\1\4\1\5\1\6\1\10\1\uffff\1\1\1\7";
    static final String DFA24_specialS =
        "\13\uffff}>";
    static final String[] DFA24_transitionS = {
            "\1\1\1\7\1\4\1\6\1\5\1\3\4\2\2\4\1\uffff\73\4",
            "\1\10",
            "",
            "",
            "",
            "",
            "",
            "",
            "\1\12\24\uffff\4\12\3\uffff\1\11",
            "",
            ""
    };

    static final short[] DFA24_eot = DFA.unpackEncodedString(DFA24_eotS);
    static final short[] DFA24_eof = DFA.unpackEncodedString(DFA24_eofS);
    static final char[] DFA24_min = DFA.unpackEncodedStringToUnsignedChars(DFA24_minS);
    static final char[] DFA24_max = DFA.unpackEncodedStringToUnsignedChars(DFA24_maxS);
    static final short[] DFA24_accept = DFA.unpackEncodedString(DFA24_acceptS);
    static final short[] DFA24_special = DFA.unpackEncodedString(DFA24_specialS);
    static final short[][] DFA24_transition;

    static {
        int numStates = DFA24_transitionS.length;
        DFA24_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA24_transition[i] = DFA.unpackEncodedString(DFA24_transitionS[i]);
        }
    }

    class DFA24 extends DFA {

        public DFA24(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 24;
            this.eot = DFA24_eot;
            this.eof = DFA24_eof;
            this.min = DFA24_min;
            this.max = DFA24_max;
            this.accept = DFA24_accept;
            this.special = DFA24_special;
            this.transition = DFA24_transition;
        }
        public String getDescription() {
            return "175:4: ( tikzscope | tikzpath | tikznode_ext | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend )";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
    static final String DFA25_eotS =
        "\16\uffff";
    static final String DFA25_eofS =
        "\16\uffff";
    static final String DFA25_minS =
        "\1\4\2\22\5\uffff\2\57\4\uffff";
    static final String DFA25_maxS =
        "\1\113\2\22\5\uffff\2\113\4\uffff";
    static final String DFA25_acceptS =
        "\3\uffff\1\2\1\3\1\4\1\5\1\6\2\uffff\1\11\1\10\1\1\1\7";
    static final String DFA25_specialS =
        "\16\uffff}>";
    static final String[] DFA25_transitionS = {
            "\1\2\1\1\1\5\1\7\1\6\1\4\4\3\76\5",
            "\1\10",
            "\1\11",
            "",
            "",
            "",
            "",
            "",
            "\1\13\24\uffff\4\13\2\uffff\2\12",
            "\1\15\24\uffff\4\15\3\uffff\1\14",
            "",
            "",
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
            return "()* loopback of 176:3: ( tikzscope | tikzpath | tikznode_ext | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
 

    public static final BitSet FOLLOW_tikz_cmd_comment_in_tikzdocument346 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_dontcare_preamble_in_tikzdocument350 = new BitSet(new long[]{0xFFFFEFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikz_styleorset_in_tikzdocument354 = new BitSet(new long[]{0xFFFFEFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_otherbegin_in_tikzdocument358 = new BitSet(new long[]{0xFFFFEFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikzpicture_in_tikzdocument363 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment389 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_style_in_tikz_styleorset411 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_set_in_tikz_styleorset415 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_dontcare_preamble426 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_otherbegin451 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_LBRR_in_otherbegin453 = new BitSet(new long[]{0x0000800000000000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_idd_in_otherbegin455 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_RBRR_in_otherbegin457 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TIKZSTYLE_in_tikz_style468 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_LBRR_in_tikz_style470 = new BitSet(new long[]{0x0000800000000000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_idd_in_tikz_style472 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_RBRR_in_tikz_style474 = new BitSet(new long[]{0x0000000000200000L});
    public static final BitSet FOLLOW_EQU_in_tikz_style476 = new BitSet(new long[]{0x0000000000010000L});
    public static final BitSet FOLLOW_tikz_options_in_tikz_style478 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_squarebr_start_in_tikz_options500 = new BitSet(new long[]{0x0000800000020000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_option_in_tikz_options503 = new BitSet(new long[]{0x0000800000120000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_options506 = new BitSet(new long[]{0x0000800000000000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_option_in_tikz_options508 = new BitSet(new long[]{0x0000800000120000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_options512 = new BitSet(new long[]{0x0000800000020000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_squarebr_end_in_tikz_options517 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_style_in_option542 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_kv_in_option551 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_kv565 = new BitSet(new long[]{0x0000000000200002L});
    public static final BitSet FOLLOW_EQU_in_option_kv568 = new BitSet(new long[]{0x0000E00000040000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_iddornumberunitorstring_in_option_kv570 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBRR_in_tikzstring598 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_no_rlbrace_in_tikzstring600 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikzstring_in_tikzstring604 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_no_rlbrace_in_tikzstring606 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_RBRR_in_tikzstring611 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_no_rlbrace634 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_iddornumberunitorstring651 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_numberunit_in_iddornumberunitorstring655 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzstring_in_iddornumberunitorstring659 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_style669 = new BitSet(new long[]{0x0080000000000000L});
    public static final BitSet FOLLOW_55_in_option_style671 = new BitSet(new long[]{0x0000000000200000L});
    public static final BitSet FOLLOW_EQU_in_option_style673 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_LBRR_in_option_style675 = new BitSet(new long[]{0x0000800000180000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_option_kv_in_option_style678 = new BitSet(new long[]{0x0000000000180000L});
    public static final BitSet FOLLOW_KOMMA_in_option_style681 = new BitSet(new long[]{0x0000800000000000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_option_kv_in_option_style683 = new BitSet(new long[]{0x0000000000180000L});
    public static final BitSet FOLLOW_KOMMA_in_option_style690 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_RBRR_in_option_style693 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_edgeop_in_idd724 = new BitSet(new long[]{0x0000800000000002L,0x00000000000000F0L});
    public static final BitSet FOLLOW_edgeop_in_idd727 = new BitSet(new long[]{0x0000800000000002L,0x00000000000000F0L});
    public static final BitSet FOLLOW_edgeop_in_idd743 = new BitSet(new long[]{0x0000200000000000L});
    public static final BitSet FOLLOW_INT_in_idd745 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_number_in_numberunit773 = new BitSet(new long[]{0x3F00000000000002L});
    public static final BitSet FOLLOW_unit_in_numberunit775 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_number801 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_unit0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_set_start_in_tikz_set856 = new BitSet(new long[]{0x0000800000080000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_option_in_tikz_set859 = new BitSet(new long[]{0x0000800000180000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_set862 = new BitSet(new long[]{0x0000800000000000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_option_in_tikz_set864 = new BitSet(new long[]{0x0000800000180000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_roundbr_end_in_tikz_set870 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzpicture_start_in_tikzpicture898 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikz_options_in_tikzpicture900 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikzbody_in_tikzpicture903 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikzpicture_end_in_tikzpicture906 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody936 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody940 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikznode_ext_in_tikzbody944 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_dontcare_body_nobr_in_tikzbody948 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikz_set_in_tikzbody952 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikz_style_in_tikzbody956 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_otherbegin_in_tikzbody960 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_otherend_in_tikzbody963 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody973 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody977 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikznode_ext_in_tikzbody981 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_dontcare_body_in_tikzbody985 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikz_set_in_tikzbody989 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikz_style_in_tikzbody993 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_otherbegin_in_tikzbody997 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_otherend_in_tikzbody1000 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_set_in_dontcare_body_nobr1016 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_dontcare_body1070 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_otherend1121 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_LBRR_in_otherend1123 = new BitSet(new long[]{0x0000800000000000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_idd_in_otherend1125 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_RBRR_in_otherend1127 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzscope_start_in_tikzscope1154 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikz_options_in_tikzscope1156 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikzbody_in_tikzscope1159 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikzscope_end_in_tikzscope1162 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_in_tikzpath1217 = new BitSet(new long[]{0x4000800000454000L,0x00000000000003F7L});
    public static final BitSet FOLLOW_tikzpath_element_in_tikzpath1219 = new BitSet(new long[]{0x4000800000454000L,0x00000000000003F7L});
    public static final BitSet FOLLOW_semicolon_end_in_tikzpath1222 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_options_in_tikzpath_element1251 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_in_tikzpath_element1258 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikznode_int_in_tikzpath_element1264 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_circle_in_tikzpath_element1270 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_arc_in_tikzpath_element1276 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBRR_in_tikzpath_element1282 = new BitSet(new long[]{0x40008000000D4000L,0x00000000000003F7L});
    public static final BitSet FOLLOW_tikzpath_element_in_tikzpath_element1284 = new BitSet(new long[]{0x40008000000D4000L,0x00000000000003F7L});
    public static final BitSet FOLLOW_RBRR_in_tikzpath_element1287 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_edgeop_in_tikzpath_element1293 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_node_start_in_tikznode_ext1304 = new BitSet(new long[]{0x8000E00000054000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_tikznode_core_in_tikznode_ext1306 = new BitSet(new long[]{0x4000800000454000L,0x00000000000003F7L});
    public static final BitSet FOLLOW_tikzpath_element_in_tikznode_ext1308 = new BitSet(new long[]{0x4000800000454000L,0x00000000000003F7L});
    public static final BitSet FOLLOW_semicolon_end_in_tikznode_ext1311 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_62_in_tikznode_int1336 = new BitSet(new long[]{0x8000E00000054000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_tikznode_core_in_tikznode_int1339 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikznode_decorator_in_tikznode_core1349 = new BitSet(new long[]{0x8000E00000054000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_tikzstring_in_tikznode_core1352 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_tikznode_decorator1379 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_63_in_tikznode_decorator1386 = new BitSet(new long[]{0x0000000000004000L,0x0000000000000300L});
    public static final BitSet FOLLOW_coord_in_tikznode_decorator1389 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_options_in_tikznode_decorator1395 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBR_in_tikz_options_dontcare1405 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare1407 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_tikz_options_dontcare_in_tikz_options_dontcare1411 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_no_rlbracket_in_tikz_options_dontcare1413 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x0000000000000FFFL});
    public static final BitSet FOLLOW_RBR_in_tikz_options_dontcare1418 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_no_rlbracket1436 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LPAR_in_nodename1453 = new BitSet(new long[]{0x0000800000000000L,0x00000000000000F0L});
    public static final BitSet FOLLOW_idd_in_nodename1455 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_RPAR_in_nodename1457 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_64_in_circle1479 = new BitSet(new long[]{0x0000000000004002L});
    public static final BitSet FOLLOW_65_in_circle1483 = new BitSet(new long[]{0x0000000000004002L});
    public static final BitSet FOLLOW_size_in_circle1486 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_66_in_arc1500 = new BitSet(new long[]{0x0000000000004002L});
    public static final BitSet FOLLOW_LPAR_in_arc1503 = new BitSet(new long[]{0x0000600000000000L});
    public static final BitSet FOLLOW_numberunit_in_arc1505 = new BitSet(new long[]{0x0000000000800000L});
    public static final BitSet FOLLOW_COLON_in_arc1507 = new BitSet(new long[]{0x0000600000000000L});
    public static final BitSet FOLLOW_numberunit_in_arc1509 = new BitSet(new long[]{0x0000000000800000L});
    public static final BitSet FOLLOW_COLON_in_arc1511 = new BitSet(new long[]{0x0000600000000000L});
    public static final BitSet FOLLOW_numberunit_in_arc1513 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_RPAR_in_arc1515 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LPAR_in_size1534 = new BitSet(new long[]{0x0000600000000000L});
    public static final BitSet FOLLOW_numberunit_in_size1536 = new BitSet(new long[]{0x0000000000008000L,0x0000000000000008L});
    public static final BitSet FOLLOW_67_in_size1539 = new BitSet(new long[]{0x0000600000000000L});
    public static final BitSet FOLLOW_numberunit_in_size1541 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_RPAR_in_size1545 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_coord1573 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_modifier_in_coord1597 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_LPAR_in_coord1600 = new BitSet(new long[]{0x0000600000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord1602 = new BitSet(new long[]{0x0000000000900000L});
    public static final BitSet FOLLOW_coord_sep_in_coord1604 = new BitSet(new long[]{0x0000600000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord1606 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_RPAR_in_coord1608 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_sep1634 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_edgeop0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBR_in_squarebr_start1708 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RBR_in_squarebr_end1726 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SEMIC_in_semicolon_end1745 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RBRR_in_roundbr_end1763 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TIKZSET_in_tikz_set_start1781 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_LBRR_in_tikz_set_start1783 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_tikzpicture_start1802 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_LBRR_in_tikzpicture_start1804 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000400L});
    public static final BitSet FOLLOW_74_in_tikzpicture_start1806 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_RBRR_in_tikzpicture_start1808 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_tikzpicture_end1826 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_LBRR_in_tikzpicture_end1828 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000400L});
    public static final BitSet FOLLOW_74_in_tikzpicture_end1830 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_RBRR_in_tikzpicture_end1832 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_tikzscope_start1850 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_LBRR_in_tikzscope_start1852 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000800L});
    public static final BitSet FOLLOW_75_in_tikzscope_start1854 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_RBRR_in_tikzscope_start1856 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_tikzscope_end1874 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_LBRR_in_tikzscope_end1876 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000800L});
    public static final BitSet FOLLOW_75_in_tikzscope_end1878 = new BitSet(new long[]{0x0000000000080000L});
    public static final BitSet FOLLOW_RBRR_in_tikzscope_end1880 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_tag_in_path_start1899 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_node_start1917 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new long[]{0x0000000000000002L});

}