// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g 2010-12-18 17:40:43

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;


import org.antlr.runtime.tree.*;

public class simpletikzParser extends Parser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BEGIN", "END", "USETIKZLIB", "TIKZSTYLE", "TIKZSET", "NODE", "DRAW", "PATH", "FILL", "LPAR", "RPAR", "LBR", "RBR", "LBRR", "RBRR", "KOMMA", "EQU", "SEMIC", "COLON", "IM_PATH", "IM_NODE", "IM_COORD", "IM_NODENAME", "IM_NUMBERUNIT", "IM_PICTURE", "IM_DOCUMENT", "IM_SCOPE", "IM_STARTTAG", "IM_ENDTAG", "IM_OPTIONS", "IM_TIKZEDT_CMD", "IM_OPTION_STYLE", "IM_OPTION_KV", "IM_ID", "IM_TIKZSET", "IM_USETIKZLIB", "IM_STRING", "IM_STYLE", "TIKZEDT_CMD_COMMENT", "INT", "FLOAT_WO_EXP", "ID", "WS", "COMMENT", "EXPONENT", "ESC_SEQ", "MATHSTRING", "COMMAND", "SOMETHING", "'/.style'", "'cm'", "'in'", "'ex'", "'mm'", "'pt'", "'em'", "'at'", "'--'", "'->'", "'|-'", "'-|'", "'+'", "'++'", "'tikzpicture'", "'scope'"
    };
    public static final int T__68=68;
    public static final int T__66=66;
    public static final int EXPONENT=48;
    public static final int T__67=67;
    public static final int T__64=64;
    public static final int TIKZEDT_CMD_COMMENT=42;
    public static final int IM_STARTTAG=31;
    public static final int T__65=65;
    public static final int T__62=62;
    public static final int T__63=63;
    public static final int RBR=16;
    public static final int IM_PATH=23;
    public static final int IM_ID=37;
    public static final int SOMETHING=52;
    public static final int ID=45;
    public static final int T__61=61;
    public static final int T__60=60;
    public static final int EOF=-1;
    public static final int MATHSTRING=50;
    public static final int LBR=15;
    public static final int COMMAND=51;
    public static final int IM_ENDTAG=32;
    public static final int IM_USETIKZLIB=39;
    public static final int T__55=55;
    public static final int T__56=56;
    public static final int T__57=57;
    public static final int IM_DOCUMENT=29;
    public static final int T__58=58;
    public static final int RBRR=18;
    public static final int ESC_SEQ=49;
    public static final int IM_STRING=40;
    public static final int T__53=53;
    public static final int LPAR=13;
    public static final int T__54=54;
    public static final int FILL=12;
    public static final int PATH=11;
    public static final int IM_TIKZSET=38;
    public static final int T__59=59;
    public static final int BEGIN=4;
    public static final int IM_OPTION_KV=36;
    public static final int COMMENT=47;
    public static final int IM_TIKZEDT_CMD=34;
    public static final int IM_OPTIONS=33;
    public static final int IM_OPTION_STYLE=35;
    public static final int NODE=9;
    public static final int TIKZSTYLE=7;
    public static final int TIKZSET=8;
    public static final int IM_COORD=25;
    public static final int IM_PICTURE=28;
    public static final int INT=43;
    public static final int LBRR=17;
    public static final int USETIKZLIB=6;
    public static final int IM_NODE=24;
    public static final int IM_STYLE=41;
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
    public static final int FLOAT_WO_EXP=44;
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:88:1: tikzdocument : ( tikz_styleorsetorcmd | dontcare_preamble | otherbegin )* ( tikzpicture )? -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ( tikzpicture )? ) ;
    public final simpletikzParser.tikzdocument_return tikzdocument() throws RecognitionException {
        simpletikzParser.tikzdocument_return retval = new simpletikzParser.tikzdocument_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikz_styleorsetorcmd_return tikz_styleorsetorcmd1 = null;

        simpletikzParser.dontcare_preamble_return dontcare_preamble2 = null;

        simpletikzParser.otherbegin_return otherbegin3 = null;

        simpletikzParser.tikzpicture_return tikzpicture4 = null;


        RewriteRuleSubtreeStream stream_dontcare_preamble=new RewriteRuleSubtreeStream(adaptor,"rule dontcare_preamble");
        RewriteRuleSubtreeStream stream_tikzpicture=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture");
        RewriteRuleSubtreeStream stream_otherbegin=new RewriteRuleSubtreeStream(adaptor,"rule otherbegin");
        RewriteRuleSubtreeStream stream_tikz_styleorsetorcmd=new RewriteRuleSubtreeStream(adaptor,"rule tikz_styleorsetorcmd");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:2: ( ( tikz_styleorsetorcmd | dontcare_preamble | otherbegin )* ( tikzpicture )? -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ( tikzpicture )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:5: ( tikz_styleorsetorcmd | dontcare_preamble | otherbegin )* ( tikzpicture )?
            {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:5: ( tikz_styleorsetorcmd | dontcare_preamble | otherbegin )*
            loop1:
            do {
                int alt1=4;
                switch ( input.LA(1) ) {
                case BEGIN:
                    {
                    int LA1_1 = input.LA(2);

                    if ( (LA1_1==LBRR) ) {
                        int LA1_5 = input.LA(3);

                        if ( (LA1_5==ID||(LA1_5>=61 && LA1_5<=64)) ) {
                            alt1=3;
                        }


                    }


                    }
                    break;
                case TIKZSTYLE:
                case TIKZSET:
                case TIKZEDT_CMD_COMMENT:
                    {
                    alt1=1;
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
                case IM_TIKZEDT_CMD:
                case IM_OPTION_STYLE:
                case IM_OPTION_KV:
                case IM_ID:
                case IM_TIKZSET:
                case IM_USETIKZLIB:
                case IM_STRING:
                case IM_STYLE:
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
                    {
                    alt1=2;
                    }
                    break;

                }

                switch (alt1) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:7: tikz_styleorsetorcmd
            	    {
            	    pushFollow(FOLLOW_tikz_styleorsetorcmd_in_tikzdocument338);
            	    tikz_styleorsetorcmd1=tikz_styleorsetorcmd();

            	    state._fsp--;

            	    stream_tikz_styleorsetorcmd.add(tikz_styleorsetorcmd1.getTree());

            	    }
            	    break;
            	case 2 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:30: dontcare_preamble
            	    {
            	    pushFollow(FOLLOW_dontcare_preamble_in_tikzdocument342);
            	    dontcare_preamble2=dontcare_preamble();

            	    state._fsp--;

            	    stream_dontcare_preamble.add(dontcare_preamble2.getTree());

            	    }
            	    break;
            	case 3 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:50: otherbegin
            	    {
            	    pushFollow(FOLLOW_otherbegin_in_tikzdocument346);
            	    otherbegin3=otherbegin();

            	    state._fsp--;

            	    stream_otherbegin.add(otherbegin3.getTree());

            	    }
            	    break;

            	default :
            	    break loop1;
                }
            } while (true);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:64: ( tikzpicture )?
            int alt2=2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0==BEGIN) ) {
                alt2=1;
            }
            switch (alt2) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:64: tikzpicture
                    {
                    pushFollow(FOLLOW_tikzpicture_in_tikzdocument351);
                    tikzpicture4=tikzpicture();

                    state._fsp--;

                    stream_tikzpicture.add(tikzpicture4.getTree());

                    }
                    break;

            }



            // AST REWRITE
            // elements: tikzpicture, tikz_styleorsetorcmd
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 89:80: -> ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ( tikzpicture )? )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:83: ^( IM_DOCUMENT ( tikz_styleorsetorcmd )* ( tikzpicture )? )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_DOCUMENT, "IM_DOCUMENT"), root_1);

                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:97: ( tikz_styleorsetorcmd )*
                while ( stream_tikz_styleorsetorcmd.hasNext() ) {
                    adaptor.addChild(root_1, stream_tikz_styleorsetorcmd.nextTree());

                }
                stream_tikz_styleorsetorcmd.reset();
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:89:119: ( tikzpicture )?
                if ( stream_tikzpicture.hasNext() ) {
                    adaptor.addChild(root_1, stream_tikzpicture.nextTree());

                }
                stream_tikzpicture.reset();

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

    public static class tikz_styleorsetorcmd_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_styleorsetorcmd"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:92:1: tikz_styleorsetorcmd : ( tikz_style | tikz_set | tikz_cmd_comment );
    public final simpletikzParser.tikz_styleorsetorcmd_return tikz_styleorsetorcmd() throws RecognitionException {
        simpletikzParser.tikz_styleorsetorcmd_return retval = new simpletikzParser.tikz_styleorsetorcmd_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikz_style_return tikz_style5 = null;

        simpletikzParser.tikz_set_return tikz_set6 = null;

        simpletikzParser.tikz_cmd_comment_return tikz_cmd_comment7 = null;



        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:2: ( tikz_style | tikz_set | tikz_cmd_comment )
            int alt3=3;
            switch ( input.LA(1) ) {
            case TIKZSTYLE:
                {
                alt3=1;
                }
                break;
            case TIKZSET:
                {
                alt3=2;
                }
                break;
            case TIKZEDT_CMD_COMMENT:
                {
                alt3=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 3, 0, input);

                throw nvae;
            }

            switch (alt3) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:4: tikz_style
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_tikz_style_in_tikz_styleorsetorcmd378);
                    tikz_style5=tikz_style();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_style5.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:17: tikz_set
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_tikz_set_in_tikz_styleorsetorcmd382);
                    tikz_set6=tikz_set();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_set6.getTree());

                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:93:28: tikz_cmd_comment
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd386);
                    tikz_cmd_comment7=tikz_cmd_comment();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_cmd_comment7.getTree());

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
    // $ANTLR end "tikz_styleorsetorcmd"

    public static class dontcare_preamble_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "dontcare_preamble"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:96:1: dontcare_preamble : ~ ( BEGIN | TIKZSTYLE | TIKZSET | TIKZEDT_CMD_COMMENT ) ;
    public final simpletikzParser.dontcare_preamble_return dontcare_preamble() throws RecognitionException {
        simpletikzParser.dontcare_preamble_return retval = new simpletikzParser.dontcare_preamble_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set8=null;

        Object set8_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:2: (~ ( BEGIN | TIKZSTYLE | TIKZSET | TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:97:4: ~ ( BEGIN | TIKZSTYLE | TIKZSET | TIKZEDT_CMD_COMMENT )
            {
            root_0 = (Object)adaptor.nil();

            set8=(Token)input.LT(1);
            if ( (input.LA(1)>=END && input.LA(1)<=USETIKZLIB)||(input.LA(1)>=NODE && input.LA(1)<=IM_STYLE)||(input.LA(1)>=INT && input.LA(1)<=68) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set8));
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
    // $ANTLR end "dontcare_preamble"

    public static class otherbegin_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "otherbegin"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:99:1: otherbegin : BEGIN LBRR idd RBRR ;
    public final simpletikzParser.otherbegin_return otherbegin() throws RecognitionException {
        simpletikzParser.otherbegin_return retval = new simpletikzParser.otherbegin_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGIN9=null;
        Token LBRR10=null;
        Token RBRR12=null;
        simpletikzParser.idd_return idd11 = null;


        Object BEGIN9_tree=null;
        Object LBRR10_tree=null;
        Object RBRR12_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:2: ( BEGIN LBRR idd RBRR )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:100:4: BEGIN LBRR idd RBRR
            {
            root_0 = (Object)adaptor.nil();

            BEGIN9=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_otherbegin422); 
            BEGIN9_tree = (Object)adaptor.create(BEGIN9);
            adaptor.addChild(root_0, BEGIN9_tree);

            LBRR10=(Token)match(input,LBRR,FOLLOW_LBRR_in_otherbegin424); 
            LBRR10_tree = (Object)adaptor.create(LBRR10);
            adaptor.addChild(root_0, LBRR10_tree);

            pushFollow(FOLLOW_idd_in_otherbegin426);
            idd11=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd11.getTree());
            RBRR12=(Token)match(input,RBRR,FOLLOW_RBRR_in_otherbegin428); 
            RBRR12_tree = (Object)adaptor.create(RBRR12);
            adaptor.addChild(root_0, RBRR12_tree);


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
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

    public static class tikz_cmd_comment_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_cmd_comment"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:104:1: tikz_cmd_comment : TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) ;
    public final simpletikzParser.tikz_cmd_comment_return tikz_cmd_comment() throws RecognitionException {
        simpletikzParser.tikz_cmd_comment_return retval = new simpletikzParser.tikz_cmd_comment_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token TIKZEDT_CMD_COMMENT13=null;

        Object TIKZEDT_CMD_COMMENT13_tree=null;
        RewriteRuleTokenStream stream_TIKZEDT_CMD_COMMENT=new RewriteRuleTokenStream(adaptor,"token TIKZEDT_CMD_COMMENT");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:2: ( TIKZEDT_CMD_COMMENT -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:4: TIKZEDT_CMD_COMMENT
            {
            TIKZEDT_CMD_COMMENT13=(Token)match(input,TIKZEDT_CMD_COMMENT,FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment441);  
            stream_TIKZEDT_CMD_COMMENT.add(TIKZEDT_CMD_COMMENT13);



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
            // 105:25: -> ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:105:28: ^( IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_TIKZEDT_CMD, "IM_TIKZEDT_CMD"), root_1);

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
        return retval;
    }
    // $ANTLR end "tikz_cmd_comment"

    public static class tikz_style_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_style"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:112:1: tikz_style : TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) ;
    public final simpletikzParser.tikz_style_return tikz_style() throws RecognitionException {
        simpletikzParser.tikz_style_return retval = new simpletikzParser.tikz_style_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token TIKZSTYLE14=null;
        Token LBRR15=null;
        Token RBRR17=null;
        Token char_literal18=null;
        simpletikzParser.idd_return idd16 = null;

        simpletikzParser.tikz_options_return tikz_options19 = null;


        Object TIKZSTYLE14_tree=null;
        Object LBRR15_tree=null;
        Object RBRR17_tree=null;
        Object char_literal18_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSTYLE=new RewriteRuleTokenStream(adaptor,"token TIKZSTYLE");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:2: ( TIKZSTYLE LBRR idd RBRR '=' tikz_options -> ^( IM_STYLE idd tikz_options ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:4: TIKZSTYLE LBRR idd RBRR '=' tikz_options
            {
            TIKZSTYLE14=(Token)match(input,TIKZSTYLE,FOLLOW_TIKZSTYLE_in_tikz_style466);  
            stream_TIKZSTYLE.add(TIKZSTYLE14);

            LBRR15=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikz_style468);  
            stream_LBRR.add(LBRR15);

            pushFollow(FOLLOW_idd_in_tikz_style470);
            idd16=idd();

            state._fsp--;

            stream_idd.add(idd16.getTree());
            RBRR17=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikz_style472);  
            stream_RBRR.add(RBRR17);

            char_literal18=(Token)match(input,EQU,FOLLOW_EQU_in_tikz_style474);  
            stream_EQU.add(char_literal18);

            pushFollow(FOLLOW_tikz_options_in_tikz_style476);
            tikz_options19=tikz_options();

            state._fsp--;

            stream_tikz_options.add(tikz_options19.getTree());


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
            // 113:45: -> ^( IM_STYLE idd tikz_options )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:113:48: ^( IM_STYLE idd tikz_options )
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

    public static class tikz_options_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_options"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:116:1: tikz_options : squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) ;
    public final simpletikzParser.tikz_options_return tikz_options() throws RecognitionException {
        simpletikzParser.tikz_options_return retval = new simpletikzParser.tikz_options_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal22=null;
        Token char_literal24=null;
        simpletikzParser.squarebr_start_return squarebr_start20 = null;

        simpletikzParser.option_return option21 = null;

        simpletikzParser.option_return option23 = null;

        simpletikzParser.squarebr_end_return squarebr_end25 = null;


        Object char_literal22_tree=null;
        Object char_literal24_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_squarebr_start=new RewriteRuleSubtreeStream(adaptor,"rule squarebr_start");
        RewriteRuleSubtreeStream stream_squarebr_end=new RewriteRuleSubtreeStream(adaptor,"rule squarebr_end");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:2: ( squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:5: squarebr_start ( option ( ',' option )* ( ',' )? )? squarebr_end
            {
            pushFollow(FOLLOW_squarebr_start_in_tikz_options498);
            squarebr_start20=squarebr_start();

            state._fsp--;

            stream_squarebr_start.add(squarebr_start20.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:20: ( option ( ',' option )* ( ',' )? )?
            int alt6=2;
            int LA6_0 = input.LA(1);

            if ( (LA6_0==ID||(LA6_0>=61 && LA6_0<=64)) ) {
                alt6=1;
            }
            switch (alt6) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:21: option ( ',' option )* ( ',' )?
                    {
                    pushFollow(FOLLOW_option_in_tikz_options501);
                    option21=option();

                    state._fsp--;

                    stream_option.add(option21.getTree());
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:28: ( ',' option )*
                    loop4:
                    do {
                        int alt4=2;
                        int LA4_0 = input.LA(1);

                        if ( (LA4_0==KOMMA) ) {
                            int LA4_1 = input.LA(2);

                            if ( (LA4_1==ID||(LA4_1>=61 && LA4_1<=64)) ) {
                                alt4=1;
                            }


                        }


                        switch (alt4) {
                    	case 1 :
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:29: ',' option
                    	    {
                    	    char_literal22=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options504);  
                    	    stream_KOMMA.add(char_literal22);

                    	    pushFollow(FOLLOW_option_in_tikz_options506);
                    	    option23=option();

                    	    state._fsp--;

                    	    stream_option.add(option23.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop4;
                        }
                    } while (true);

                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:42: ( ',' )?
                    int alt5=2;
                    int LA5_0 = input.LA(1);

                    if ( (LA5_0==KOMMA) ) {
                        alt5=1;
                    }
                    switch (alt5) {
                        case 1 :
                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:42: ','
                            {
                            char_literal24=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_options510);  
                            stream_KOMMA.add(char_literal24);


                            }
                            break;

                    }


                    }
                    break;

            }

            pushFollow(FOLLOW_squarebr_end_in_tikz_options515);
            squarebr_end25=squarebr_end();

            state._fsp--;

            stream_squarebr_end.add(squarebr_end25.getTree());


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
            // 117:63: -> ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:66: ^( IM_OPTIONS squarebr_start ( option )* squarebr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTIONS, "IM_OPTIONS"), root_1);

                adaptor.addChild(root_1, stream_squarebr_start.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:117:94: ( option )*
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

    public static class option_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "option"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:120:1: option : ( option_style | option_kv );
    public final simpletikzParser.option_return option() throws RecognitionException {
        simpletikzParser.option_return retval = new simpletikzParser.option_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.option_style_return option_style26 = null;

        simpletikzParser.option_kv_return option_kv27 = null;



        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:2: ( option_style | option_kv )
            int alt7=2;
            alt7 = dfa7.predict(input);
            switch (alt7) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:121:4: option_style
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_option_style_in_option540);
                    option_style26=option_style();

                    state._fsp--;

                    adaptor.addChild(root_0, option_style26.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:122:5: option_kv
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_option_kv_in_option549);
                    option_kv27=option_kv();

                    state._fsp--;

                    adaptor.addChild(root_0, option_kv27.getTree());

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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:125:1: option_kv : idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) ;
    public final simpletikzParser.option_kv_return option_kv() throws RecognitionException {
        simpletikzParser.option_kv_return retval = new simpletikzParser.option_kv_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal29=null;
        simpletikzParser.idd_return idd28 = null;

        simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring30 = null;


        Object char_literal29_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_iddornumberunitorstring=new RewriteRuleSubtreeStream(adaptor,"rule iddornumberunitorstring");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:2: ( idd ( '=' iddornumberunitorstring )? -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:4: idd ( '=' iddornumberunitorstring )?
            {
            pushFollow(FOLLOW_idd_in_option_kv563);
            idd28=idd();

            state._fsp--;

            stream_idd.add(idd28.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:8: ( '=' iddornumberunitorstring )?
            int alt8=2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0==EQU) ) {
                alt8=1;
            }
            switch (alt8) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:9: '=' iddornumberunitorstring
                    {
                    char_literal29=(Token)match(input,EQU,FOLLOW_EQU_in_option_kv566);  
                    stream_EQU.add(char_literal29);

                    pushFollow(FOLLOW_iddornumberunitorstring_in_option_kv568);
                    iddornumberunitorstring30=iddornumberunitorstring();

                    state._fsp--;

                    stream_iddornumberunitorstring.add(iddornumberunitorstring30.getTree());

                    }
                    break;

            }



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
            // 126:40: -> ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:43: ^( IM_OPTION_KV idd ( iddornumberunitorstring )? )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_KV, "IM_OPTION_KV"), root_1);

                adaptor.addChild(root_1, stream_idd.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:126:62: ( iddornumberunitorstring )?
                if ( stream_iddornumberunitorstring.hasNext() ) {
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
        return retval;
    }
    // $ANTLR end "option_kv"

    public static class nodetype_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "nodetype"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:129:1: nodetype : LBR ( no_rlbracket )* ( nodetype ( no_rlbracket )* )* RBR -> ^( IM_STRING LBR RBR ) ;
    public final simpletikzParser.nodetype_return nodetype() throws RecognitionException {
        simpletikzParser.nodetype_return retval = new simpletikzParser.nodetype_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LBR31=null;
        Token RBR35=null;
        simpletikzParser.no_rlbracket_return no_rlbracket32 = null;

        simpletikzParser.nodetype_return nodetype33 = null;

        simpletikzParser.no_rlbracket_return no_rlbracket34 = null;


        Object LBR31_tree=null;
        Object RBR35_tree=null;
        RewriteRuleTokenStream stream_RBR=new RewriteRuleTokenStream(adaptor,"token RBR");
        RewriteRuleTokenStream stream_LBR=new RewriteRuleTokenStream(adaptor,"token LBR");
        RewriteRuleSubtreeStream stream_nodetype=new RewriteRuleSubtreeStream(adaptor,"rule nodetype");
        RewriteRuleSubtreeStream stream_no_rlbracket=new RewriteRuleSubtreeStream(adaptor,"rule no_rlbracket");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:2: ( LBR ( no_rlbracket )* ( nodetype ( no_rlbracket )* )* RBR -> ^( IM_STRING LBR RBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:4: LBR ( no_rlbracket )* ( nodetype ( no_rlbracket )* )* RBR
            {
            LBR31=(Token)match(input,LBR,FOLLOW_LBR_in_nodetype596);  
            stream_LBR.add(LBR31);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:8: ( no_rlbracket )*
            loop9:
            do {
                int alt9=2;
                int LA9_0 = input.LA(1);

                if ( ((LA9_0>=BEGIN && LA9_0<=RPAR)||(LA9_0>=LBRR && LA9_0<=68)) ) {
                    alt9=1;
                }


                switch (alt9) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:8: no_rlbracket
            	    {
            	    pushFollow(FOLLOW_no_rlbracket_in_nodetype598);
            	    no_rlbracket32=no_rlbracket();

            	    state._fsp--;

            	    stream_no_rlbracket.add(no_rlbracket32.getTree());

            	    }
            	    break;

            	default :
            	    break loop9;
                }
            } while (true);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:22: ( nodetype ( no_rlbracket )* )*
            loop11:
            do {
                int alt11=2;
                int LA11_0 = input.LA(1);

                if ( (LA11_0==LBR) ) {
                    alt11=1;
                }


                switch (alt11) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:23: nodetype ( no_rlbracket )*
            	    {
            	    pushFollow(FOLLOW_nodetype_in_nodetype602);
            	    nodetype33=nodetype();

            	    state._fsp--;

            	    stream_nodetype.add(nodetype33.getTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:32: ( no_rlbracket )*
            	    loop10:
            	    do {
            	        int alt10=2;
            	        int LA10_0 = input.LA(1);

            	        if ( ((LA10_0>=BEGIN && LA10_0<=RPAR)||(LA10_0>=LBRR && LA10_0<=68)) ) {
            	            alt10=1;
            	        }


            	        switch (alt10) {
            	    	case 1 :
            	    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:32: no_rlbracket
            	    	    {
            	    	    pushFollow(FOLLOW_no_rlbracket_in_nodetype604);
            	    	    no_rlbracket34=no_rlbracket();

            	    	    state._fsp--;

            	    	    stream_no_rlbracket.add(no_rlbracket34.getTree());

            	    	    }
            	    	    break;

            	    	default :
            	    	    break loop10;
            	        }
            	    } while (true);


            	    }
            	    break;

            	default :
            	    break loop11;
                }
            } while (true);

            RBR35=(Token)match(input,RBR,FOLLOW_RBR_in_nodetype609);  
            stream_RBR.add(RBR35);



            // AST REWRITE
            // elements: LBR, RBR
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 130:52: -> ^( IM_STRING LBR RBR )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:130:55: ^( IM_STRING LBR RBR )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STRING, "IM_STRING"), root_1);

                adaptor.addChild(root_1, stream_LBR.nextNode());
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
    // $ANTLR end "nodetype"

    public static class no_rlbracket_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "no_rlbracket"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:133:1: no_rlbracket : ~ ( LBR | RBR ) ;
    public final simpletikzParser.no_rlbracket_return no_rlbracket() throws RecognitionException {
        simpletikzParser.no_rlbracket_return retval = new simpletikzParser.no_rlbracket_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set36=null;

        Object set36_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:2: (~ ( LBR | RBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:134:4: ~ ( LBR | RBR )
            {
            root_0 = (Object)adaptor.nil();

            set36=(Token)input.LT(1);
            if ( (input.LA(1)>=BEGIN && input.LA(1)<=RPAR)||(input.LA(1)>=LBRR && input.LA(1)<=68) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set36));
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
    // $ANTLR end "no_rlbracket"

    public static class tikzstring_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzstring"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:136:1: tikzstring : LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) ;
    public final simpletikzParser.tikzstring_return tikzstring() throws RecognitionException {
        simpletikzParser.tikzstring_return retval = new simpletikzParser.tikzstring_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LBRR37=null;
        Token RBRR41=null;
        simpletikzParser.no_rlbrace_return no_rlbrace38 = null;

        simpletikzParser.tikzstring_return tikzstring39 = null;

        simpletikzParser.no_rlbrace_return no_rlbrace40 = null;


        Object LBRR37_tree=null;
        Object RBRR41_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleSubtreeStream stream_tikzstring=new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_no_rlbrace=new RewriteRuleSubtreeStream(adaptor,"rule no_rlbrace");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:2: ( LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR -> ^( IM_STRING LBRR RBRR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:4: LBRR ( no_rlbrace )* ( tikzstring ( no_rlbrace )* )* RBRR
            {
            LBRR37=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzstring649);  
            stream_LBRR.add(LBRR37);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:9: ( no_rlbrace )*
            loop12:
            do {
                int alt12=2;
                int LA12_0 = input.LA(1);

                if ( ((LA12_0>=BEGIN && LA12_0<=RBR)||(LA12_0>=KOMMA && LA12_0<=68)) ) {
                    alt12=1;
                }


                switch (alt12) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:9: no_rlbrace
            	    {
            	    pushFollow(FOLLOW_no_rlbrace_in_tikzstring651);
            	    no_rlbrace38=no_rlbrace();

            	    state._fsp--;

            	    stream_no_rlbrace.add(no_rlbrace38.getTree());

            	    }
            	    break;

            	default :
            	    break loop12;
                }
            } while (true);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:21: ( tikzstring ( no_rlbrace )* )*
            loop14:
            do {
                int alt14=2;
                int LA14_0 = input.LA(1);

                if ( (LA14_0==LBRR) ) {
                    alt14=1;
                }


                switch (alt14) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:22: tikzstring ( no_rlbrace )*
            	    {
            	    pushFollow(FOLLOW_tikzstring_in_tikzstring655);
            	    tikzstring39=tikzstring();

            	    state._fsp--;

            	    stream_tikzstring.add(tikzstring39.getTree());
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:33: ( no_rlbrace )*
            	    loop13:
            	    do {
            	        int alt13=2;
            	        int LA13_0 = input.LA(1);

            	        if ( ((LA13_0>=BEGIN && LA13_0<=RBR)||(LA13_0>=KOMMA && LA13_0<=68)) ) {
            	            alt13=1;
            	        }


            	        switch (alt13) {
            	    	case 1 :
            	    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:33: no_rlbrace
            	    	    {
            	    	    pushFollow(FOLLOW_no_rlbrace_in_tikzstring657);
            	    	    no_rlbrace40=no_rlbrace();

            	    	    state._fsp--;

            	    	    stream_no_rlbrace.add(no_rlbrace40.getTree());

            	    	    }
            	    	    break;

            	    	default :
            	    	    break loop13;
            	        }
            	    } while (true);


            	    }
            	    break;

            	default :
            	    break loop14;
                }
            } while (true);

            RBRR41=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzstring662);  
            stream_RBRR.add(RBRR41);



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
            // 137:52: -> ^( IM_STRING LBRR RBRR )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:137:55: ^( IM_STRING LBRR RBRR )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_STRING, "IM_STRING"), root_1);

                adaptor.addChild(root_1, stream_LBRR.nextNode());
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
        return retval;
    }
    // $ANTLR end "tikzstring"

    public static class no_rlbrace_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "no_rlbrace"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:140:1: no_rlbrace : ~ ( LBRR | RBRR ) ;
    public final simpletikzParser.no_rlbrace_return no_rlbrace() throws RecognitionException {
        simpletikzParser.no_rlbrace_return retval = new simpletikzParser.no_rlbrace_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set42=null;

        Object set42_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:2: (~ ( LBRR | RBRR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:141:4: ~ ( LBRR | RBRR )
            {
            root_0 = (Object)adaptor.nil();

            set42=(Token)input.LT(1);
            if ( (input.LA(1)>=BEGIN && input.LA(1)<=RBR)||(input.LA(1)>=KOMMA && input.LA(1)<=68) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set42));
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
    // $ANTLR end "no_rlbrace"

    public static class iddornumberunitorstring_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "iddornumberunitorstring"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:143:1: iddornumberunitorstring : ( idd | numberunit | tikzstring );
    public final simpletikzParser.iddornumberunitorstring_return iddornumberunitorstring() throws RecognitionException {
        simpletikzParser.iddornumberunitorstring_return retval = new simpletikzParser.iddornumberunitorstring_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.idd_return idd43 = null;

        simpletikzParser.numberunit_return numberunit44 = null;

        simpletikzParser.tikzstring_return tikzstring45 = null;



        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:2: ( idd | numberunit | tikzstring )
            int alt15=3;
            switch ( input.LA(1) ) {
            case ID:
            case 61:
            case 62:
            case 63:
            case 64:
                {
                alt15=1;
                }
                break;
            case INT:
            case FLOAT_WO_EXP:
                {
                alt15=2;
                }
                break;
            case LBRR:
                {
                alt15=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 15, 0, input);

                throw nvae;
            }

            switch (alt15) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:4: idd
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_idd_in_iddornumberunitorstring702);
                    idd43=idd();

                    state._fsp--;

                    adaptor.addChild(root_0, idd43.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:10: numberunit
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_numberunit_in_iddornumberunitorstring706);
                    numberunit44=numberunit();

                    state._fsp--;

                    adaptor.addChild(root_0, numberunit44.getTree());

                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:144:23: tikzstring
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_tikzstring_in_iddornumberunitorstring710);
                    tikzstring45=tikzstring();

                    state._fsp--;

                    adaptor.addChild(root_0, tikzstring45.getTree());

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
    // $ANTLR end "iddornumberunitorstring"

    public static class option_style_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "option_style"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:146:1: option_style : idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) ;
    public final simpletikzParser.option_style_return option_style() throws RecognitionException {
        simpletikzParser.option_style_return retval = new simpletikzParser.option_style_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal47=null;
        Token char_literal48=null;
        Token LBRR49=null;
        Token char_literal51=null;
        Token char_literal53=null;
        Token RBRR54=null;
        simpletikzParser.idd_return idd46 = null;

        simpletikzParser.option_kv_return option_kv50 = null;

        simpletikzParser.option_kv_return option_kv52 = null;


        Object string_literal47_tree=null;
        Object char_literal48_tree=null;
        Object LBRR49_tree=null;
        Object char_literal51_tree=null;
        Object char_literal53_tree=null;
        Object RBRR54_tree=null;
        RewriteRuleTokenStream stream_EQU=new RewriteRuleTokenStream(adaptor,"token EQU");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleTokenStream stream_53=new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_idd=new RewriteRuleSubtreeStream(adaptor,"rule idd");
        RewriteRuleSubtreeStream stream_option_kv=new RewriteRuleSubtreeStream(adaptor,"rule option_kv");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:2: ( idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR -> ^( IM_OPTION_STYLE idd ( option_kv )* ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:4: idd '/.style' '=' LBRR ( option_kv ( ',' option_kv )* )? ( ',' )? RBRR
            {
            pushFollow(FOLLOW_idd_in_option_style720);
            idd46=idd();

            state._fsp--;

            stream_idd.add(idd46.getTree());
            string_literal47=(Token)match(input,53,FOLLOW_53_in_option_style722);  
            stream_53.add(string_literal47);

            char_literal48=(Token)match(input,EQU,FOLLOW_EQU_in_option_style724);  
            stream_EQU.add(char_literal48);

            LBRR49=(Token)match(input,LBRR,FOLLOW_LBRR_in_option_style726);  
            stream_LBRR.add(LBRR49);

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:27: ( option_kv ( ',' option_kv )* )?
            int alt17=2;
            int LA17_0 = input.LA(1);

            if ( (LA17_0==ID||(LA17_0>=61 && LA17_0<=64)) ) {
                alt17=1;
            }
            switch (alt17) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:28: option_kv ( ',' option_kv )*
                    {
                    pushFollow(FOLLOW_option_kv_in_option_style729);
                    option_kv50=option_kv();

                    state._fsp--;

                    stream_option_kv.add(option_kv50.getTree());
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:38: ( ',' option_kv )*
                    loop16:
                    do {
                        int alt16=2;
                        int LA16_0 = input.LA(1);

                        if ( (LA16_0==KOMMA) ) {
                            int LA16_1 = input.LA(2);

                            if ( (LA16_1==ID||(LA16_1>=61 && LA16_1<=64)) ) {
                                alt16=1;
                            }


                        }


                        switch (alt16) {
                    	case 1 :
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:39: ',' option_kv
                    	    {
                    	    char_literal51=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_option_style732);  
                    	    stream_KOMMA.add(char_literal51);

                    	    pushFollow(FOLLOW_option_kv_in_option_style734);
                    	    option_kv52=option_kv();

                    	    state._fsp--;

                    	    stream_option_kv.add(option_kv52.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop16;
                        }
                    } while (true);


                    }
                    break;

            }

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:58: ( ',' )?
            int alt18=2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0==KOMMA) ) {
                alt18=1;
            }
            switch (alt18) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:58: ','
                    {
                    char_literal53=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_option_style741);  
                    stream_KOMMA.add(char_literal53);


                    }
                    break;

            }

            RBRR54=(Token)match(input,RBRR,FOLLOW_RBRR_in_option_style744);  
            stream_RBRR.add(RBRR54);



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
            // 147:69: -> ^( IM_OPTION_STYLE idd ( option_kv )* )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:72: ^( IM_OPTION_STYLE idd ( option_kv )* )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_OPTION_STYLE, "IM_OPTION_STYLE"), root_1);

                adaptor.addChild(root_1, stream_idd.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:147:94: ( option_kv )*
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:155:1: idd : ( edgeop ( edgeop )* -> ^( IM_ID ( edgeop )* ) | edgeop INT -> ^( IM_ID edgeop INT ) );
    public final simpletikzParser.idd_return idd() throws RecognitionException {
        simpletikzParser.idd_return retval = new simpletikzParser.idd_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token INT58=null;
        simpletikzParser.edgeop_return edgeop55 = null;

        simpletikzParser.edgeop_return edgeop56 = null;

        simpletikzParser.edgeop_return edgeop57 = null;


        Object INT58_tree=null;
        RewriteRuleTokenStream stream_INT=new RewriteRuleTokenStream(adaptor,"token INT");
        RewriteRuleSubtreeStream stream_edgeop=new RewriteRuleSubtreeStream(adaptor,"rule edgeop");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:2: ( edgeop ( edgeop )* -> ^( IM_ID ( edgeop )* ) | edgeop INT -> ^( IM_ID edgeop INT ) )
            int alt20=2;
            int LA20_0 = input.LA(1);

            if ( (LA20_0==ID||(LA20_0>=61 && LA20_0<=64)) ) {
                int LA20_1 = input.LA(2);

                if ( (LA20_1==RBR||(LA20_1>=RBRR && LA20_1<=EQU)||LA20_1==ID||LA20_1==53||(LA20_1>=61 && LA20_1<=64)) ) {
                    alt20=1;
                }
                else if ( (LA20_1==INT) ) {
                    alt20=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 20, 1, input);

                    throw nvae;
                }
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 20, 0, input);

                throw nvae;
            }
            switch (alt20) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:4: edgeop ( edgeop )*
                    {
                    pushFollow(FOLLOW_edgeop_in_idd775);
                    edgeop55=edgeop();

                    state._fsp--;

                    stream_edgeop.add(edgeop55.getTree());
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:11: ( edgeop )*
                    loop19:
                    do {
                        int alt19=2;
                        int LA19_0 = input.LA(1);

                        if ( (LA19_0==ID||(LA19_0>=61 && LA19_0<=64)) ) {
                            alt19=1;
                        }


                        switch (alt19) {
                    	case 1 :
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:12: edgeop
                    	    {
                    	    pushFollow(FOLLOW_edgeop_in_idd778);
                    	    edgeop56=edgeop();

                    	    state._fsp--;

                    	    stream_edgeop.add(edgeop56.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop19;
                        }
                    } while (true);



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
                    // 156:21: -> ^( IM_ID ( edgeop )* )
                    {
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:24: ^( IM_ID ( edgeop )* )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ID, "IM_ID"), root_1);

                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:156:32: ( edgeop )*
                        while ( stream_edgeop.hasNext() ) {
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:4: edgeop INT
                    {
                    pushFollow(FOLLOW_edgeop_in_idd794);
                    edgeop57=edgeop();

                    state._fsp--;

                    stream_edgeop.add(edgeop57.getTree());
                    INT58=(Token)match(input,INT,FOLLOW_INT_in_idd796);  
                    stream_INT.add(INT58);



                    // AST REWRITE
                    // elements: edgeop, INT
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 157:16: -> ^( IM_ID edgeop INT )
                    {
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:157:19: ^( IM_ID edgeop INT )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ID, "IM_ID"), root_1);

                        adaptor.addChild(root_1, stream_edgeop.nextTree());
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
        return retval;
    }
    // $ANTLR end "idd"

    public static class numberunit_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "numberunit"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:163:1: numberunit : number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) ;
    public final simpletikzParser.numberunit_return numberunit() throws RecognitionException {
        simpletikzParser.numberunit_return retval = new simpletikzParser.numberunit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.number_return number59 = null;

        simpletikzParser.unit_return unit60 = null;


        RewriteRuleSubtreeStream stream_unit=new RewriteRuleSubtreeStream(adaptor,"rule unit");
        RewriteRuleSubtreeStream stream_number=new RewriteRuleSubtreeStream(adaptor,"rule number");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:2: ( number ( unit )? -> ^( IM_NUMBERUNIT number ( unit )? ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:4: number ( unit )?
            {
            pushFollow(FOLLOW_number_in_numberunit825);
            number59=number();

            state._fsp--;

            stream_number.add(number59.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:11: ( unit )?
            int alt21=2;
            int LA21_0 = input.LA(1);

            if ( ((LA21_0>=54 && LA21_0<=59)) ) {
                alt21=1;
            }
            switch (alt21) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:11: unit
                    {
                    pushFollow(FOLLOW_unit_in_numberunit827);
                    unit60=unit();

                    state._fsp--;

                    stream_unit.add(unit60.getTree());

                    }
                    break;

            }



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
            // 164:17: -> ^( IM_NUMBERUNIT number ( unit )? )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:20: ^( IM_NUMBERUNIT number ( unit )? )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NUMBERUNIT, "IM_NUMBERUNIT"), root_1);

                adaptor.addChild(root_1, stream_number.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:164:43: ( unit )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:168:1: number : ( FLOAT_WO_EXP | INT ) ;
    public final simpletikzParser.number_return number() throws RecognitionException {
        simpletikzParser.number_return retval = new simpletikzParser.number_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set61=null;

        Object set61_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:2: ( ( FLOAT_WO_EXP | INT ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:169:4: ( FLOAT_WO_EXP | INT )
            {
            root_0 = (Object)adaptor.nil();

            set61=(Token)input.LT(1);
            if ( (input.LA(1)>=INT && input.LA(1)<=FLOAT_WO_EXP) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set61));
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:172:1: unit : ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' );
    public final simpletikzParser.unit_return unit() throws RecognitionException {
        simpletikzParser.unit_return retval = new simpletikzParser.unit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set62=null;

        Object set62_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:173:2: ( 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            set62=(Token)input.LT(1);
            if ( (input.LA(1)>=54 && input.LA(1)<=59) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set62));
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

    public static class tikz_set_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_set"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:176:1: tikz_set : tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) ;
    public final simpletikzParser.tikz_set_return tikz_set() throws RecognitionException {
        simpletikzParser.tikz_set_return retval = new simpletikzParser.tikz_set_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal65=null;
        simpletikzParser.tikz_set_start_return tikz_set_start63 = null;

        simpletikzParser.option_return option64 = null;

        simpletikzParser.option_return option66 = null;

        simpletikzParser.roundbr_end_return roundbr_end67 = null;


        Object char_literal65_tree=null;
        RewriteRuleTokenStream stream_KOMMA=new RewriteRuleTokenStream(adaptor,"token KOMMA");
        RewriteRuleSubtreeStream stream_tikz_set_start=new RewriteRuleSubtreeStream(adaptor,"rule tikz_set_start");
        RewriteRuleSubtreeStream stream_roundbr_end=new RewriteRuleSubtreeStream(adaptor,"rule roundbr_end");
        RewriteRuleSubtreeStream stream_option=new RewriteRuleSubtreeStream(adaptor,"rule option");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:2: ( tikz_set_start ( option ( ',' option )* )? roundbr_end -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:5: tikz_set_start ( option ( ',' option )* )? roundbr_end
            {
            pushFollow(FOLLOW_tikz_set_start_in_tikz_set908);
            tikz_set_start63=tikz_set_start();

            state._fsp--;

            stream_tikz_set_start.add(tikz_set_start63.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:20: ( option ( ',' option )* )?
            int alt23=2;
            int LA23_0 = input.LA(1);

            if ( (LA23_0==ID||(LA23_0>=61 && LA23_0<=64)) ) {
                alt23=1;
            }
            switch (alt23) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:21: option ( ',' option )*
                    {
                    pushFollow(FOLLOW_option_in_tikz_set911);
                    option64=option();

                    state._fsp--;

                    stream_option.add(option64.getTree());
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:28: ( ',' option )*
                    loop22:
                    do {
                        int alt22=2;
                        int LA22_0 = input.LA(1);

                        if ( (LA22_0==KOMMA) ) {
                            alt22=1;
                        }


                        switch (alt22) {
                    	case 1 :
                    	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:29: ',' option
                    	    {
                    	    char_literal65=(Token)match(input,KOMMA,FOLLOW_KOMMA_in_tikz_set914);  
                    	    stream_KOMMA.add(char_literal65);

                    	    pushFollow(FOLLOW_option_in_tikz_set916);
                    	    option66=option();

                    	    state._fsp--;

                    	    stream_option.add(option66.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop22;
                        }
                    } while (true);


                    }
                    break;

            }

            pushFollow(FOLLOW_roundbr_end_in_tikz_set922);
            roundbr_end67=roundbr_end();

            state._fsp--;

            stream_roundbr_end.add(roundbr_end67.getTree());


            // AST REWRITE
            // elements: roundbr_end, tikz_set_start, option
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 177:56: -> ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:59: ^( IM_TIKZSET tikz_set_start ( option )* roundbr_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_TIKZSET, "IM_TIKZSET"), root_1);

                adaptor.addChild(root_1, stream_tikz_set_start.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:177:87: ( option )*
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

    public static class tikzpicture_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpicture"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:182:1: tikzpicture : tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) ;
    public final simpletikzParser.tikzpicture_return tikzpicture() throws RecognitionException {
        simpletikzParser.tikzpicture_return retval = new simpletikzParser.tikzpicture_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzpicture_start_return tikzpicture_start68 = null;

        simpletikzParser.tikz_options_return tikz_options69 = null;

        simpletikzParser.tikzbody_return tikzbody70 = null;

        simpletikzParser.tikzpicture_end_return tikzpicture_end71 = null;


        RewriteRuleSubtreeStream stream_tikzpicture_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_end");
        RewriteRuleSubtreeStream stream_tikzpicture_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzpicture_start");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:2: ( tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:5: tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end
            {
            pushFollow(FOLLOW_tikzpicture_start_in_tikzpicture950);
            tikzpicture_start68=tikzpicture_start();

            state._fsp--;

            stream_tikzpicture_start.add(tikzpicture_start68.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:23: ( tikz_options )?
            int alt24=2;
            int LA24_0 = input.LA(1);

            if ( (LA24_0==LBR) ) {
                alt24=1;
            }
            switch (alt24) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:23: tikz_options
                    {
                    pushFollow(FOLLOW_tikz_options_in_tikzpicture952);
                    tikz_options69=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options69.getTree());

                    }
                    break;

            }

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:37: ( tikzbody )?
            int alt25=2;
            int LA25_0 = input.LA(1);

            if ( (LA25_0==BEGIN||(LA25_0>=USETIKZLIB && LA25_0<=RPAR)||(LA25_0>=RBR && LA25_0<=68)) ) {
                alt25=1;
            }
            else if ( (LA25_0==END) ) {
                int LA25_2 = input.LA(2);

                if ( (LA25_2==LBRR) ) {
                    int LA25_3 = input.LA(3);

                    if ( (LA25_3==ID||(LA25_3>=61 && LA25_3<=64)) ) {
                        alt25=1;
                    }
                }
            }
            switch (alt25) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:37: tikzbody
                    {
                    pushFollow(FOLLOW_tikzbody_in_tikzpicture955);
                    tikzbody70=tikzbody();

                    state._fsp--;

                    stream_tikzbody.add(tikzbody70.getTree());

                    }
                    break;

            }

            pushFollow(FOLLOW_tikzpicture_end_in_tikzpicture958);
            tikzpicture_end71=tikzpicture_end();

            state._fsp--;

            stream_tikzpicture_end.add(tikzpicture_end71.getTree());


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
            // 183:64: -> ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:67: ^( IM_PICTURE tikzpicture_start ( tikz_options )? ( tikzbody )? tikzpicture_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PICTURE, "IM_PICTURE"), root_1);

                adaptor.addChild(root_1, stream_tikzpicture_start.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:98: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:183:112: ( tikzbody )?
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

    public static class tikzbody_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzbody"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:186:1: tikzbody : ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )* ;
    public final simpletikzParser.tikzbody_return tikzbody() throws RecognitionException {
        simpletikzParser.tikzbody_return retval = new simpletikzParser.tikzbody_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_return tikzscope72 = null;

        simpletikzParser.tikzpath_return tikzpath73 = null;

        simpletikzParser.tikznodee_return tikznodee74 = null;

        simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr75 = null;

        simpletikzParser.tikz_set_return tikz_set76 = null;

        simpletikzParser.tikz_style_return tikz_style77 = null;

        simpletikzParser.otherbegin_return otherbegin78 = null;

        simpletikzParser.otherend_return otherend79 = null;

        simpletikzParser.tikzscope_return tikzscope80 = null;

        simpletikzParser.tikzpath_return tikzpath81 = null;

        simpletikzParser.tikznodee_return tikznodee82 = null;

        simpletikzParser.dontcare_body_return dontcare_body83 = null;

        simpletikzParser.tikz_set_return tikz_set84 = null;

        simpletikzParser.tikz_style_return tikz_style85 = null;

        simpletikzParser.otherbegin_return otherbegin86 = null;

        simpletikzParser.otherend_return otherend87 = null;



        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:2: ( ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend ) ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*
            {
            root_0 = (Object)adaptor.nil();

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend )
            int alt26=8;
            alt26 = dfa26.predict(input);
            switch (alt26) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:6: tikzscope
                    {
                    pushFollow(FOLLOW_tikzscope_in_tikzbody988);
                    tikzscope72=tikzscope();

                    state._fsp--;

                    adaptor.addChild(root_0, tikzscope72.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:18: tikzpath
                    {
                    pushFollow(FOLLOW_tikzpath_in_tikzbody992);
                    tikzpath73=tikzpath();

                    state._fsp--;

                    adaptor.addChild(root_0, tikzpath73.getTree());

                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:29: tikznodee
                    {
                    pushFollow(FOLLOW_tikznodee_in_tikzbody996);
                    tikznodee74=tikznodee();

                    state._fsp--;

                    adaptor.addChild(root_0, tikznodee74.getTree());

                    }
                    break;
                case 4 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:41: dontcare_body_nobr
                    {
                    pushFollow(FOLLOW_dontcare_body_nobr_in_tikzbody1000);
                    dontcare_body_nobr75=dontcare_body_nobr();

                    state._fsp--;

                    adaptor.addChild(root_0, dontcare_body_nobr75.getTree());

                    }
                    break;
                case 5 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:62: tikz_set
                    {
                    pushFollow(FOLLOW_tikz_set_in_tikzbody1004);
                    tikz_set76=tikz_set();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_set76.getTree());

                    }
                    break;
                case 6 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:73: tikz_style
                    {
                    pushFollow(FOLLOW_tikz_style_in_tikzbody1008);
                    tikz_style77=tikz_style();

                    state._fsp--;

                    adaptor.addChild(root_0, tikz_style77.getTree());

                    }
                    break;
                case 7 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:86: otherbegin
                    {
                    pushFollow(FOLLOW_otherbegin_in_tikzbody1012);
                    otherbegin78=otherbegin();

                    state._fsp--;

                    adaptor.addChild(root_0, otherbegin78.getTree());

                    }
                    break;
                case 8 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:187:98: otherend
                    {
                    pushFollow(FOLLOW_otherend_in_tikzbody1015);
                    otherend79=otherend();

                    state._fsp--;

                    adaptor.addChild(root_0, otherend79.getTree());

                    }
                    break;

            }

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:3: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*
            loop27:
            do {
                int alt27=9;
                alt27 = dfa27.predict(input);
                switch (alt27) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:5: tikzscope
            	    {
            	    pushFollow(FOLLOW_tikzscope_in_tikzbody1025);
            	    tikzscope80=tikzscope();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzscope80.getTree());

            	    }
            	    break;
            	case 2 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:17: tikzpath
            	    {
            	    pushFollow(FOLLOW_tikzpath_in_tikzbody1029);
            	    tikzpath81=tikzpath();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikzpath81.getTree());

            	    }
            	    break;
            	case 3 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:28: tikznodee
            	    {
            	    pushFollow(FOLLOW_tikznodee_in_tikzbody1033);
            	    tikznodee82=tikznodee();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikznodee82.getTree());

            	    }
            	    break;
            	case 4 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:40: dontcare_body
            	    {
            	    pushFollow(FOLLOW_dontcare_body_in_tikzbody1037);
            	    dontcare_body83=dontcare_body();

            	    state._fsp--;

            	    adaptor.addChild(root_0, dontcare_body83.getTree());

            	    }
            	    break;
            	case 5 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:61: tikz_set
            	    {
            	    pushFollow(FOLLOW_tikz_set_in_tikzbody1046);
            	    tikz_set84=tikz_set();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikz_set84.getTree());

            	    }
            	    break;
            	case 6 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:72: tikz_style
            	    {
            	    pushFollow(FOLLOW_tikz_style_in_tikzbody1050);
            	    tikz_style85=tikz_style();

            	    state._fsp--;

            	    adaptor.addChild(root_0, tikz_style85.getTree());

            	    }
            	    break;
            	case 7 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:85: otherbegin
            	    {
            	    pushFollow(FOLLOW_otherbegin_in_tikzbody1054);
            	    otherbegin86=otherbegin();

            	    state._fsp--;

            	    adaptor.addChild(root_0, otherbegin86.getTree());

            	    }
            	    break;
            	case 8 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:188:97: otherend
            	    {
            	    pushFollow(FOLLOW_otherend_in_tikzbody1057);
            	    otherend87=otherend();

            	    state._fsp--;

            	    adaptor.addChild(root_0, otherend87.getTree());

            	    }
            	    break;

            	default :
            	    break loop27;
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
    // $ANTLR end "tikzbody"

    public static class dontcare_body_nobr_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "dontcare_body_nobr"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:191:1: dontcare_body_nobr : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) ) ;
    public final simpletikzParser.dontcare_body_nobr_return dontcare_body_nobr() throws RecognitionException {
        simpletikzParser.dontcare_body_nobr_return retval = new simpletikzParser.dontcare_body_nobr_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set88=null;

        Object set88_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) )
            {
            root_0 = (Object)adaptor.nil();

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:192:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET | LBR )
            {
            set88=(Token)input.LT(1);
            if ( input.LA(1)==USETIKZLIB||(input.LA(1)>=LPAR && input.LA(1)<=RPAR)||(input.LA(1)>=RBR && input.LA(1)<=68) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set88));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
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
        return retval;
    }
    // $ANTLR end "dontcare_body_nobr"

    public static class dontcare_body_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "dontcare_body"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:194:1: dontcare_body : (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) ) ;
    public final simpletikzParser.dontcare_body_return dontcare_body() throws RecognitionException {
        simpletikzParser.dontcare_body_return retval = new simpletikzParser.dontcare_body_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set89=null;

        Object set89_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:2: ( (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )
            {
            root_0 = (Object)adaptor.nil();

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:4: (~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:195:5: ~ ( BEGIN | END | NODE | DRAW | PATH | FILL | TIKZSTYLE | TIKZSET )
            {
            set89=(Token)input.LT(1);
            if ( input.LA(1)==USETIKZLIB||(input.LA(1)>=LPAR && input.LA(1)<=68) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set89));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
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
        return retval;
    }
    // $ANTLR end "dontcare_body"

    public static class otherend_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "otherend"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:197:1: otherend : END '{' idd '}' ;
    public final simpletikzParser.otherend_return otherend() throws RecognitionException {
        simpletikzParser.otherend_return retval = new simpletikzParser.otherend_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token END90=null;
        Token char_literal91=null;
        Token char_literal93=null;
        simpletikzParser.idd_return idd92 = null;


        Object END90_tree=null;
        Object char_literal91_tree=null;
        Object char_literal93_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:2: ( END '{' idd '}' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:198:4: END '{' idd '}'
            {
            root_0 = (Object)adaptor.nil();

            END90=(Token)match(input,END,FOLLOW_END_in_otherend1167); 
            END90_tree = (Object)adaptor.create(END90);
            adaptor.addChild(root_0, END90_tree);

            char_literal91=(Token)match(input,LBRR,FOLLOW_LBRR_in_otherend1169); 
            char_literal91_tree = (Object)adaptor.create(char_literal91);
            adaptor.addChild(root_0, char_literal91_tree);

            pushFollow(FOLLOW_idd_in_otherend1171);
            idd92=idd();

            state._fsp--;

            adaptor.addChild(root_0, idd92.getTree());
            char_literal93=(Token)match(input,RBRR,FOLLOW_RBRR_in_otherend1173); 
            char_literal93_tree = (Object)adaptor.create(char_literal93);
            adaptor.addChild(root_0, char_literal93_tree);


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
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

    public static class tikzpath_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpath"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:201:1: tikzpath : path_start ( tikz_options )? tikzpathi semicolon_end -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end ) ;
    public final simpletikzParser.tikzpath_return tikzpath() throws RecognitionException {
        simpletikzParser.tikzpath_return retval = new simpletikzParser.tikzpath_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_return path_start94 = null;

        simpletikzParser.tikz_options_return tikz_options95 = null;

        simpletikzParser.tikzpathi_return tikzpathi96 = null;

        simpletikzParser.semicolon_end_return semicolon_end97 = null;


        RewriteRuleSubtreeStream stream_path_start=new RewriteRuleSubtreeStream(adaptor,"rule path_start");
        RewriteRuleSubtreeStream stream_semicolon_end=new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:2: ( path_start ( tikz_options )? tikzpathi semicolon_end -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:4: path_start ( tikz_options )? tikzpathi semicolon_end
            {
            pushFollow(FOLLOW_path_start_in_tikzpath1186);
            path_start94=path_start();

            state._fsp--;

            stream_path_start.add(path_start94.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:15: ( tikz_options )?
            int alt28=2;
            int LA28_0 = input.LA(1);

            if ( (LA28_0==LBR) ) {
                alt28=1;
            }
            switch (alt28) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:15: tikz_options
                    {
                    pushFollow(FOLLOW_tikz_options_in_tikzpath1188);
                    tikz_options95=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options95.getTree());

                    }
                    break;

            }

            pushFollow(FOLLOW_tikzpathi_in_tikzpath1191);
            tikzpathi96=tikzpathi();

            state._fsp--;

            stream_tikzpathi.add(tikzpathi96.getTree());
            pushFollow(FOLLOW_semicolon_end_in_tikzpath1193);
            semicolon_end97=semicolon_end();

            state._fsp--;

            stream_semicolon_end.add(semicolon_end97.getTree());


            // AST REWRITE
            // elements: path_start, semicolon_end, tikzpathi, tikz_options
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 202:53: -> ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:56: ^( IM_PATH path_start ( tikz_options )? tikzpathi semicolon_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                adaptor.addChild(root_1, stream_path_start.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:202:77: ( tikz_options )?
                if ( stream_tikz_options.hasNext() ) {
                    adaptor.addChild(root_1, stream_tikz_options.nextTree());

                }
                stream_tikz_options.reset();
                adaptor.addChild(root_1, stream_tikzpathi.nextTree());
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
        return retval;
    }
    // $ANTLR end "tikzpath"

    public static class tikzpathi_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpathi"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:207:1: tikzpathi : coordornode_new ( edgeop coordornode_new )* ;
    public final simpletikzParser.tikzpathi_return tikzpathi() throws RecognitionException {
        simpletikzParser.tikzpathi_return retval = new simpletikzParser.tikzpathi_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coordornode_new_return coordornode_new98 = null;

        simpletikzParser.edgeop_return edgeop99 = null;

        simpletikzParser.coordornode_new_return coordornode_new100 = null;



        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:2: ( coordornode_new ( edgeop coordornode_new )* )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:4: coordornode_new ( edgeop coordornode_new )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_coordornode_new_in_tikzpathi1224);
            coordornode_new98=coordornode_new();

            state._fsp--;

            adaptor.addChild(root_0, coordornode_new98.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:20: ( edgeop coordornode_new )*
            loop29:
            do {
                int alt29=2;
                int LA29_0 = input.LA(1);

                if ( (LA29_0==ID||(LA29_0>=61 && LA29_0<=64)) ) {
                    alt29=1;
                }


                switch (alt29) {
            	case 1 :
            	    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:208:21: edgeop coordornode_new
            	    {
            	    pushFollow(FOLLOW_edgeop_in_tikzpathi1227);
            	    edgeop99=edgeop();

            	    state._fsp--;

            	    pushFollow(FOLLOW_coordornode_new_in_tikzpathi1230);
            	    coordornode_new100=coordornode_new();

            	    state._fsp--;

            	    adaptor.addChild(root_0, coordornode_new100.getTree());

            	    }
            	    break;

            	default :
            	    break loop29;
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

    public static class tikzscope_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzscope"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:213:1: tikzscope : tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) ;
    public final simpletikzParser.tikzscope_return tikzscope() throws RecognitionException {
        simpletikzParser.tikzscope_return retval = new simpletikzParser.tikzscope_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.tikzscope_start_return tikzscope_start101 = null;

        simpletikzParser.tikz_options_return tikz_options102 = null;

        simpletikzParser.tikzbody_return tikzbody103 = null;

        simpletikzParser.tikzscope_end_return tikzscope_end104 = null;


        RewriteRuleSubtreeStream stream_tikzscope_start=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_start");
        RewriteRuleSubtreeStream stream_tikzscope_end=new RewriteRuleSubtreeStream(adaptor,"rule tikzscope_end");
        RewriteRuleSubtreeStream stream_tikzbody=new RewriteRuleSubtreeStream(adaptor,"rule tikzbody");
        RewriteRuleSubtreeStream stream_tikz_options=new RewriteRuleSubtreeStream(adaptor,"rule tikz_options");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:2: ( tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:4: tikzscope_start ( tikz_options )? ( tikzbody )? tikzscope_end
            {
            pushFollow(FOLLOW_tikzscope_start_in_tikzscope1247);
            tikzscope_start101=tikzscope_start();

            state._fsp--;

            stream_tikzscope_start.add(tikzscope_start101.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:20: ( tikz_options )?
            int alt30=2;
            int LA30_0 = input.LA(1);

            if ( (LA30_0==LBR) ) {
                alt30=1;
            }
            switch (alt30) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:20: tikz_options
                    {
                    pushFollow(FOLLOW_tikz_options_in_tikzscope1249);
                    tikz_options102=tikz_options();

                    state._fsp--;

                    stream_tikz_options.add(tikz_options102.getTree());

                    }
                    break;

            }

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:34: ( tikzbody )?
            int alt31=2;
            int LA31_0 = input.LA(1);

            if ( (LA31_0==BEGIN||(LA31_0>=USETIKZLIB && LA31_0<=RPAR)||(LA31_0>=RBR && LA31_0<=68)) ) {
                alt31=1;
            }
            else if ( (LA31_0==END) ) {
                int LA31_2 = input.LA(2);

                if ( (LA31_2==LBRR) ) {
                    int LA31_3 = input.LA(3);

                    if ( (LA31_3==ID||(LA31_3>=61 && LA31_3<=64)) ) {
                        alt31=1;
                    }
                }
            }
            switch (alt31) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:34: tikzbody
                    {
                    pushFollow(FOLLOW_tikzbody_in_tikzscope1252);
                    tikzbody103=tikzbody();

                    state._fsp--;

                    stream_tikzbody.add(tikzbody103.getTree());

                    }
                    break;

            }

            pushFollow(FOLLOW_tikzscope_end_in_tikzscope1255);
            tikzscope_end104=tikzscope_end();

            state._fsp--;

            stream_tikzscope_end.add(tikzscope_end104.getTree());


            // AST REWRITE
            // elements: tikzbody, tikz_options, tikzscope_end, tikzscope_start
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 214:59: -> ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:62: ^( IM_SCOPE tikzscope_start ( tikz_options )? tikzbody tikzscope_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_SCOPE, "IM_SCOPE"), root_1);

                adaptor.addChild(root_1, stream_tikzscope_start.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:214:89: ( tikz_options )?
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

    public static class coordornode_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coordornode"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:218:1: coordornode : ( coord | size | tikznodei );
    public final simpletikzParser.coordornode_return coordornode() throws RecognitionException {
        simpletikzParser.coordornode_return retval = new simpletikzParser.coordornode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.coord_return coord105 = null;

        simpletikzParser.size_return size106 = null;

        simpletikzParser.tikznodei_return tikznodei107 = null;



        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:219:2: ( coord | size | tikznodei )
            int alt32=3;
            switch ( input.LA(1) ) {
            case LPAR:
                {
                int LA32_1 = input.LA(2);

                if ( (LA32_1==ID) ) {
                    alt32=1;
                }
                else if ( ((LA32_1>=INT && LA32_1<=FLOAT_WO_EXP)) ) {
                    switch ( input.LA(3) ) {
                    case 54:
                    case 55:
                    case 56:
                    case 57:
                    case 58:
                    case 59:
                        {
                        int LA32_7 = input.LA(4);

                        if ( (LA32_7==KOMMA||LA32_7==COLON) ) {
                            alt32=1;
                        }
                        else if ( (LA32_7==RPAR) ) {
                            alt32=2;
                        }
                        else {
                            NoViableAltException nvae =
                                new NoViableAltException("", 32, 7, input);

                            throw nvae;
                        }
                        }
                        break;
                    case KOMMA:
                    case COLON:
                        {
                        alt32=1;
                        }
                        break;
                    case RPAR:
                        {
                        alt32=2;
                        }
                        break;
                    default:
                        NoViableAltException nvae =
                            new NoViableAltException("", 32, 5, input);

                        throw nvae;
                    }

                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 32, 1, input);

                    throw nvae;
                }
                }
                break;
            case 65:
            case 66:
                {
                int LA32_2 = input.LA(2);

                if ( (LA32_2==LPAR) ) {
                    int LA32_6 = input.LA(3);

                    if ( ((LA32_6>=INT && LA32_6<=FLOAT_WO_EXP)) ) {
                        switch ( input.LA(4) ) {
                        case 54:
                        case 55:
                        case 56:
                        case 57:
                        case 58:
                        case 59:
                            {
                            int LA32_7 = input.LA(5);

                            if ( (LA32_7==KOMMA||LA32_7==COLON) ) {
                                alt32=1;
                            }
                            else if ( (LA32_7==RPAR) ) {
                                alt32=2;
                            }
                            else {
                                NoViableAltException nvae =
                                    new NoViableAltException("", 32, 7, input);

                                throw nvae;
                            }
                            }
                            break;
                        case KOMMA:
                        case COLON:
                            {
                            alt32=1;
                            }
                            break;
                        case RPAR:
                            {
                            alt32=2;
                            }
                            break;
                        default:
                            NoViableAltException nvae =
                                new NoViableAltException("", 32, 5, input);

                            throw nvae;
                        }

                    }
                    else {
                        NoViableAltException nvae =
                            new NoViableAltException("", 32, 6, input);

                        throw nvae;
                    }
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 32, 2, input);

                    throw nvae;
                }
                }
                break;
            case NODE:
                {
                alt32=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 32, 0, input);

                throw nvae;
            }

            switch (alt32) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:219:4: coord
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_coord_in_coordornode1283);
                    coord105=coord();

                    state._fsp--;

                    adaptor.addChild(root_0, coord105.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:219:12: size
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_size_in_coordornode1287);
                    size106=size();

                    state._fsp--;

                    adaptor.addChild(root_0, size106.getTree());

                    }
                    break;
                case 3 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:219:19: tikznodei
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_tikznodei_in_coordornode1291);
                    tikznodei107=tikznodei();

                    state._fsp--;

                    adaptor.addChild(root_0, tikznodei107.getTree());

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

    public static class coordornode_new_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coordornode_new"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:226:1: coordornode_new : ( coord ( ID ( nodetype )? ( tikzstring )? )? | size );
    public final simpletikzParser.coordornode_new_return coordornode_new() throws RecognitionException {
        simpletikzParser.coordornode_new_return retval = new simpletikzParser.coordornode_new_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token ID109=null;
        simpletikzParser.coord_return coord108 = null;

        simpletikzParser.nodetype_return nodetype110 = null;

        simpletikzParser.tikzstring_return tikzstring111 = null;

        simpletikzParser.size_return size112 = null;


        Object ID109_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:2: ( coord ( ID ( nodetype )? ( tikzstring )? )? | size )
            int alt36=2;
            int LA36_0 = input.LA(1);

            if ( (LA36_0==LPAR) ) {
                int LA36_1 = input.LA(2);

                if ( (LA36_1==ID) ) {
                    alt36=1;
                }
                else if ( ((LA36_1>=INT && LA36_1<=FLOAT_WO_EXP)) ) {
                    switch ( input.LA(3) ) {
                    case 54:
                    case 55:
                    case 56:
                    case 57:
                    case 58:
                    case 59:
                        {
                        int LA36_6 = input.LA(4);

                        if ( (LA36_6==KOMMA||LA36_6==COLON) ) {
                            alt36=1;
                        }
                        else if ( (LA36_6==RPAR) ) {
                            alt36=2;
                        }
                        else {
                            NoViableAltException nvae =
                                new NoViableAltException("", 36, 6, input);

                            throw nvae;
                        }
                        }
                        break;
                    case KOMMA:
                    case COLON:
                        {
                        alt36=1;
                        }
                        break;
                    case RPAR:
                        {
                        alt36=2;
                        }
                        break;
                    default:
                        NoViableAltException nvae =
                            new NoViableAltException("", 36, 4, input);

                        throw nvae;
                    }

                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 36, 1, input);

                    throw nvae;
                }
            }
            else if ( ((LA36_0>=65 && LA36_0<=66)) ) {
                int LA36_2 = input.LA(2);

                if ( (LA36_2==LPAR) ) {
                    int LA36_5 = input.LA(3);

                    if ( ((LA36_5>=INT && LA36_5<=FLOAT_WO_EXP)) ) {
                        switch ( input.LA(4) ) {
                        case 54:
                        case 55:
                        case 56:
                        case 57:
                        case 58:
                        case 59:
                            {
                            int LA36_6 = input.LA(5);

                            if ( (LA36_6==KOMMA||LA36_6==COLON) ) {
                                alt36=1;
                            }
                            else if ( (LA36_6==RPAR) ) {
                                alt36=2;
                            }
                            else {
                                NoViableAltException nvae =
                                    new NoViableAltException("", 36, 6, input);

                                throw nvae;
                            }
                            }
                            break;
                        case KOMMA:
                        case COLON:
                            {
                            alt36=1;
                            }
                            break;
                        case RPAR:
                            {
                            alt36=2;
                            }
                            break;
                        default:
                            NoViableAltException nvae =
                                new NoViableAltException("", 36, 4, input);

                            throw nvae;
                        }

                    }
                    else {
                        NoViableAltException nvae =
                            new NoViableAltException("", 36, 5, input);

                        throw nvae;
                    }
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 36, 2, input);

                    throw nvae;
                }
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 36, 0, input);

                throw nvae;
            }
            switch (alt36) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:4: coord ( ID ( nodetype )? ( tikzstring )? )?
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_coord_in_coordornode_new1308);
                    coord108=coord();

                    state._fsp--;

                    adaptor.addChild(root_0, coord108.getTree());
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:10: ( ID ( nodetype )? ( tikzstring )? )?
                    int alt35=2;
                    int LA35_0 = input.LA(1);

                    if ( (LA35_0==ID) ) {
                        int LA35_1 = input.LA(2);

                        if ( (LA35_1==LBR||LA35_1==LBRR||LA35_1==SEMIC||LA35_1==ID||(LA35_1>=61 && LA35_1<=64)) ) {
                            alt35=1;
                        }
                    }
                    switch (alt35) {
                        case 1 :
                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:11: ID ( nodetype )? ( tikzstring )?
                            {
                            ID109=(Token)match(input,ID,FOLLOW_ID_in_coordornode_new1311); 
                            ID109_tree = (Object)adaptor.create(ID109);
                            adaptor.addChild(root_0, ID109_tree);

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:14: ( nodetype )?
                            int alt33=2;
                            int LA33_0 = input.LA(1);

                            if ( (LA33_0==LBR) ) {
                                alt33=1;
                            }
                            switch (alt33) {
                                case 1 :
                                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:15: nodetype
                                    {
                                    pushFollow(FOLLOW_nodetype_in_coordornode_new1314);
                                    nodetype110=nodetype();

                                    state._fsp--;

                                    adaptor.addChild(root_0, nodetype110.getTree());

                                    }
                                    break;

                            }

                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:26: ( tikzstring )?
                            int alt34=2;
                            int LA34_0 = input.LA(1);

                            if ( (LA34_0==LBRR) ) {
                                alt34=1;
                            }
                            switch (alt34) {
                                case 1 :
                                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:227:27: tikzstring
                                    {
                                    pushFollow(FOLLOW_tikzstring_in_coordornode_new1319);
                                    tikzstring111=tikzstring();

                                    state._fsp--;

                                    adaptor.addChild(root_0, tikzstring111.getTree());

                                    }
                                    break;

                            }


                            }
                            break;

                    }


                    }
                    break;
                case 2 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:228:4: size
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_size_in_coordornode_new1328);
                    size112=size();

                    state._fsp--;

                    adaptor.addChild(root_0, size112.getTree());

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
    // $ANTLR end "coordornode_new"

    public static class tikznodei_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznodei"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:231:1: tikznodei : '\\\\node' tikznode ;
    public final simpletikzParser.tikznodei_return tikznodei() throws RecognitionException {
        simpletikzParser.tikznodei_return retval = new simpletikzParser.tikznodei_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal113=null;
        simpletikzParser.tikznode_return tikznode114 = null;


        Object string_literal113_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:232:2: ( '\\\\node' tikznode )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:232:4: '\\\\node' tikznode
            {
            root_0 = (Object)adaptor.nil();

            string_literal113=(Token)match(input,NODE,FOLLOW_NODE_in_tikznodei1341); 
            pushFollow(FOLLOW_tikznode_in_tikznodei1344);
            tikznode114=tikznode();

            state._fsp--;

            adaptor.addChild(root_0, tikznode114.getTree());

            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
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

    public static class nodename_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "nodename"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:235:1: nodename : LPAR id= ID RPAR -> ^( IM_NODENAME $id) ;
    public final simpletikzParser.nodename_return nodename() throws RecognitionException {
        simpletikzParser.nodename_return retval = new simpletikzParser.nodename_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token id=null;
        Token LPAR115=null;
        Token RPAR116=null;

        Object id_tree=null;
        Object LPAR115_tree=null;
        Object RPAR116_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:236:2: ( LPAR id= ID RPAR -> ^( IM_NODENAME $id) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:236:4: LPAR id= ID RPAR
            {
            LPAR115=(Token)match(input,LPAR,FOLLOW_LPAR_in_nodename1356);  
            stream_LPAR.add(LPAR115);

            id=(Token)match(input,ID,FOLLOW_ID_in_nodename1360);  
            stream_ID.add(id);

            RPAR116=(Token)match(input,RPAR,FOLLOW_RPAR_in_nodename1362);  
            stream_RPAR.add(RPAR116);



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
            // 236:21: -> ^( IM_NODENAME $id)
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:236:24: ^( IM_NODENAME $id)
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODENAME, "IM_NODENAME"), root_1);

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

    public static class size_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "size"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:239:1: size : ( ( coord_modifier )? lc= LPAR numberunit RPAR ) ;
    public final simpletikzParser.size_return size() throws RecognitionException {
        simpletikzParser.size_return retval = new simpletikzParser.size_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token RPAR119=null;
        simpletikzParser.coord_modifier_return coord_modifier117 = null;

        simpletikzParser.numberunit_return numberunit118 = null;


        Object lc_tree=null;
        Object RPAR119_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:2: ( ( ( coord_modifier )? lc= LPAR numberunit RPAR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:6: ( ( coord_modifier )? lc= LPAR numberunit RPAR )
            {
            root_0 = (Object)adaptor.nil();

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:6: ( ( coord_modifier )? lc= LPAR numberunit RPAR )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:8: ( coord_modifier )? lc= LPAR numberunit RPAR
            {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:8: ( coord_modifier )?
            int alt37=2;
            int LA37_0 = input.LA(1);

            if ( ((LA37_0>=65 && LA37_0<=66)) ) {
                alt37=1;
            }
            switch (alt37) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:240:8: coord_modifier
                    {
                    pushFollow(FOLLOW_coord_modifier_in_size1388);
                    coord_modifier117=coord_modifier();

                    state._fsp--;

                    adaptor.addChild(root_0, coord_modifier117.getTree());

                    }
                    break;

            }

            lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_size1393); 
            lc_tree = (Object)adaptor.create(lc);
            adaptor.addChild(root_0, lc_tree);

            pushFollow(FOLLOW_numberunit_in_size1395);
            numberunit118=numberunit();

            state._fsp--;

            adaptor.addChild(root_0, numberunit118.getTree());
            RPAR119=(Token)match(input,RPAR,FOLLOW_RPAR_in_size1397); 
            RPAR119_tree = (Object)adaptor.create(RPAR119);
            adaptor.addChild(root_0, RPAR119_tree);


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
    // $ANTLR end "size"

    public static class coord_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coord"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:246:1: coord : ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep ) );
    public final simpletikzParser.coord_return coord() throws RecognitionException {
        simpletikzParser.coord_return retval = new simpletikzParser.coord_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token lc=null;
        Token RPAR125=null;
        simpletikzParser.nodename_return nodename120 = null;

        simpletikzParser.coord_modifier_return coord_modifier121 = null;

        simpletikzParser.numberunit_return numberunit122 = null;

        simpletikzParser.coord_sep_return coord_sep123 = null;

        simpletikzParser.numberunit_return numberunit124 = null;


        Object lc_tree=null;
        Object RPAR125_tree=null;
        RewriteRuleTokenStream stream_RPAR=new RewriteRuleTokenStream(adaptor,"token RPAR");
        RewriteRuleTokenStream stream_LPAR=new RewriteRuleTokenStream(adaptor,"token LPAR");
        RewriteRuleSubtreeStream stream_numberunit=new RewriteRuleSubtreeStream(adaptor,"rule numberunit");
        RewriteRuleSubtreeStream stream_coord_sep=new RewriteRuleSubtreeStream(adaptor,"rule coord_sep");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        RewriteRuleSubtreeStream stream_coord_modifier=new RewriteRuleSubtreeStream(adaptor,"rule coord_modifier");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:247:2: ( nodename -> ^( IM_COORD nodename ) | ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR ) -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep ) )
            int alt39=2;
            int LA39_0 = input.LA(1);

            if ( (LA39_0==LPAR) ) {
                int LA39_1 = input.LA(2);

                if ( (LA39_1==ID) ) {
                    alt39=1;
                }
                else if ( ((LA39_1>=INT && LA39_1<=FLOAT_WO_EXP)) ) {
                    alt39=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 39, 1, input);

                    throw nvae;
                }
            }
            else if ( ((LA39_0>=65 && LA39_0<=66)) ) {
                alt39=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 39, 0, input);

                throw nvae;
            }
            switch (alt39) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:247:6: nodename
                    {
                    pushFollow(FOLLOW_nodename_in_coord1419);
                    nodename120=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename120.getTree());


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
                    // 247:23: -> ^( IM_COORD nodename )
                    {
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:247:26: ^( IM_COORD nodename )
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
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:5: ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR )
                    {
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:5: ( ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR )
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:7: ( coord_modifier )? lc= LPAR numberunit coord_sep numberunit RPAR
                    {
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:7: ( coord_modifier )?
                    int alt38=2;
                    int LA38_0 = input.LA(1);

                    if ( ((LA38_0>=65 && LA38_0<=66)) ) {
                        alt38=1;
                    }
                    switch (alt38) {
                        case 1 :
                            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:7: coord_modifier
                            {
                            pushFollow(FOLLOW_coord_modifier_in_coord1443);
                            coord_modifier121=coord_modifier();

                            state._fsp--;

                            stream_coord_modifier.add(coord_modifier121.getTree());

                            }
                            break;

                    }

                    lc=(Token)match(input,LPAR,FOLLOW_LPAR_in_coord1448);  
                    stream_LPAR.add(lc);

                    pushFollow(FOLLOW_numberunit_in_coord1450);
                    numberunit122=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit122.getTree());
                    pushFollow(FOLLOW_coord_sep_in_coord1452);
                    coord_sep123=coord_sep();

                    state._fsp--;

                    stream_coord_sep.add(coord_sep123.getTree());
                    pushFollow(FOLLOW_numberunit_in_coord1454);
                    numberunit124=numberunit();

                    state._fsp--;

                    stream_numberunit.add(numberunit124.getTree());
                    RPAR125=(Token)match(input,RPAR,FOLLOW_RPAR_in_coord1456);  
                    stream_RPAR.add(RPAR125);


                    }



                    // AST REWRITE
                    // elements: coord_sep, coord_modifier, numberunit
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 248:70: -> ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep )
                    {
                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:73: ^( IM_COORD[$lc] ( coord_modifier )? ( numberunit )+ coord_sep )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_COORD, lc), root_1);

                        // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:248:89: ( coord_modifier )?
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
        return retval;
    }
    // $ANTLR end "coord"

    public static class coord_sep_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coord_sep"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:250:1: coord_sep : ( ',' | ':' ) ;
    public final simpletikzParser.coord_sep_return coord_sep() throws RecognitionException {
        simpletikzParser.coord_sep_return retval = new simpletikzParser.coord_sep_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set126=null;

        Object set126_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:2: ( ( ',' | ':' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:251:4: ( ',' | ':' )
            {
            root_0 = (Object)adaptor.nil();

            set126=(Token)input.LT(1);
            if ( input.LA(1)==KOMMA||input.LA(1)==COLON ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set126));
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
    // $ANTLR end "coord_sep"

    public static class tikznode_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznode"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:254:1: tikznode : ( nodename )? ( 'at' coord )? ( nodetype )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ) ;
    public final simpletikzParser.tikznode_return tikznode() throws RecognitionException {
        simpletikzParser.tikznode_return retval = new simpletikzParser.tikznode_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal128=null;
        simpletikzParser.nodename_return nodename127 = null;

        simpletikzParser.coord_return coord129 = null;

        simpletikzParser.nodetype_return nodetype130 = null;

        simpletikzParser.tikzstring_return tikzstring131 = null;


        Object string_literal128_tree=null;
        RewriteRuleTokenStream stream_60=new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleSubtreeStream stream_coord=new RewriteRuleSubtreeStream(adaptor,"rule coord");
        RewriteRuleSubtreeStream stream_nodetype=new RewriteRuleSubtreeStream(adaptor,"rule nodetype");
        RewriteRuleSubtreeStream stream_tikzstring=new RewriteRuleSubtreeStream(adaptor,"rule tikzstring");
        RewriteRuleSubtreeStream stream_nodename=new RewriteRuleSubtreeStream(adaptor,"rule nodename");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:2: ( ( nodename )? ( 'at' coord )? ( nodetype )? tikzstring -> ^( IM_NODE ( nodename )? ( coord )? tikzstring ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:4: ( nodename )? ( 'at' coord )? ( nodetype )? tikzstring
            {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:4: ( nodename )?
            int alt40=2;
            int LA40_0 = input.LA(1);

            if ( (LA40_0==LPAR) ) {
                alt40=1;
            }
            switch (alt40) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:4: nodename
                    {
                    pushFollow(FOLLOW_nodename_in_tikznode1503);
                    nodename127=nodename();

                    state._fsp--;

                    stream_nodename.add(nodename127.getTree());

                    }
                    break;

            }

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:14: ( 'at' coord )?
            int alt41=2;
            int LA41_0 = input.LA(1);

            if ( (LA41_0==60) ) {
                alt41=1;
            }
            switch (alt41) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:15: 'at' coord
                    {
                    string_literal128=(Token)match(input,60,FOLLOW_60_in_tikznode1507);  
                    stream_60.add(string_literal128);

                    pushFollow(FOLLOW_coord_in_tikznode1509);
                    coord129=coord();

                    state._fsp--;

                    stream_coord.add(coord129.getTree());

                    }
                    break;

            }

            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:28: ( nodetype )?
            int alt42=2;
            int LA42_0 = input.LA(1);

            if ( (LA42_0==LBR) ) {
                alt42=1;
            }
            switch (alt42) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:28: nodetype
                    {
                    pushFollow(FOLLOW_nodetype_in_tikznode1513);
                    nodetype130=nodetype();

                    state._fsp--;

                    stream_nodetype.add(nodetype130.getTree());

                    }
                    break;

            }

            pushFollow(FOLLOW_tikzstring_in_tikznode1516);
            tikzstring131=tikzstring();

            state._fsp--;

            stream_tikzstring.add(tikzstring131.getTree());


            // AST REWRITE
            // elements: nodename, tikzstring, coord
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 255:50: -> ^( IM_NODE ( nodename )? ( coord )? tikzstring )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:53: ^( IM_NODE ( nodename )? ( coord )? tikzstring )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_NODE, "IM_NODE"), root_1);

                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:63: ( nodename )?
                if ( stream_nodename.hasNext() ) {
                    adaptor.addChild(root_1, stream_nodename.nextTree());

                }
                stream_nodename.reset();
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:255:73: ( coord )?
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:259:1: edgeop : ( '--' | '->' | '|-' | '-|' | ID );
    public final simpletikzParser.edgeop_return edgeop() throws RecognitionException {
        simpletikzParser.edgeop_return retval = new simpletikzParser.edgeop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set132=null;

        Object set132_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:260:2: ( '--' | '->' | '|-' | '-|' | ID )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            set132=(Token)input.LT(1);
            if ( input.LA(1)==ID||(input.LA(1)>=61 && input.LA(1)<=64) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set132));
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

    public static class coord_modifier_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "coord_modifier"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:264:1: coord_modifier : ( '+' | '++' );
    public final simpletikzParser.coord_modifier_return coord_modifier() throws RecognitionException {
        simpletikzParser.coord_modifier_return retval = new simpletikzParser.coord_modifier_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set133=null;

        Object set133_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:265:2: ( '+' | '++' )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            set133=(Token)input.LT(1);
            if ( (input.LA(1)>=65 && input.LA(1)<=66) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set133));
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

    public static class tikznodee_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikznodee"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:268:1: tikznodee : node_start tikznode ( tikzpathi )? semicolon_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end ) ;
    public final simpletikzParser.tikznodee_return tikznodee() throws RecognitionException {
        simpletikzParser.tikznodee_return retval = new simpletikzParser.tikznodee_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.node_start_return node_start134 = null;

        simpletikzParser.tikznode_return tikznode135 = null;

        simpletikzParser.tikzpathi_return tikzpathi136 = null;

        simpletikzParser.semicolon_end_return semicolon_end137 = null;


        RewriteRuleSubtreeStream stream_node_start=new RewriteRuleSubtreeStream(adaptor,"rule node_start");
        RewriteRuleSubtreeStream stream_tikznode=new RewriteRuleSubtreeStream(adaptor,"rule tikznode");
        RewriteRuleSubtreeStream stream_semicolon_end=new RewriteRuleSubtreeStream(adaptor,"rule semicolon_end");
        RewriteRuleSubtreeStream stream_tikzpathi=new RewriteRuleSubtreeStream(adaptor,"rule tikzpathi");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:2: ( node_start tikznode ( tikzpathi )? semicolon_end -> ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:4: node_start tikznode ( tikzpathi )? semicolon_end
            {
            pushFollow(FOLLOW_node_start_in_tikznodee1591);
            node_start134=node_start();

            state._fsp--;

            stream_node_start.add(node_start134.getTree());
            pushFollow(FOLLOW_tikznode_in_tikznodee1593);
            tikznode135=tikznode();

            state._fsp--;

            stream_tikznode.add(tikznode135.getTree());
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:24: ( tikzpathi )?
            int alt43=2;
            int LA43_0 = input.LA(1);

            if ( (LA43_0==LPAR||(LA43_0>=65 && LA43_0<=66)) ) {
                alt43=1;
            }
            switch (alt43) {
                case 1 :
                    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:24: tikzpathi
                    {
                    pushFollow(FOLLOW_tikzpathi_in_tikznodee1595);
                    tikzpathi136=tikzpathi();

                    state._fsp--;

                    stream_tikzpathi.add(tikzpathi136.getTree());

                    }
                    break;

            }

            pushFollow(FOLLOW_semicolon_end_in_tikznodee1598);
            semicolon_end137=semicolon_end();

            state._fsp--;

            stream_semicolon_end.add(semicolon_end137.getTree());


            // AST REWRITE
            // elements: semicolon_end, node_start, tikznode, tikzpathi
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 269:49: -> ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:52: ^( IM_PATH node_start tikznode ( tikzpathi )? semicolon_end )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_PATH, "IM_PATH"), root_1);

                adaptor.addChild(root_1, stream_node_start.nextTree());
                adaptor.addChild(root_1, stream_tikznode.nextTree());
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:269:82: ( tikzpathi )?
                if ( stream_tikzpathi.hasNext() ) {
                    adaptor.addChild(root_1, stream_tikzpathi.nextTree());

                }
                stream_tikzpathi.reset();
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
        return retval;
    }
    // $ANTLR end "tikznodee"

    public static class node_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "node_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:272:1: node_start : NODE -> ^( IM_STARTTAG NODE ) ;
    public final simpletikzParser.node_start_return node_start() throws RecognitionException {
        simpletikzParser.node_start_return retval = new simpletikzParser.node_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token NODE138=null;

        Object NODE138_tree=null;
        RewriteRuleTokenStream stream_NODE=new RewriteRuleTokenStream(adaptor,"token NODE");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:273:2: ( NODE -> ^( IM_STARTTAG NODE ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:273:4: NODE
            {
            NODE138=(Token)match(input,NODE,FOLLOW_NODE_in_node_start1626);  
            stream_NODE.add(NODE138);



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
            // 273:9: -> ^( IM_STARTTAG NODE )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:273:12: ^( IM_STARTTAG NODE )
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

    public static class squarebr_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "squarebr_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:315:1: squarebr_start : LBR -> ^( IM_STARTTAG LBR ) ;
    public final simpletikzParser.squarebr_start_return squarebr_start() throws RecognitionException {
        simpletikzParser.squarebr_start_return retval = new simpletikzParser.squarebr_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token LBR139=null;

        Object LBR139_tree=null;
        RewriteRuleTokenStream stream_LBR=new RewriteRuleTokenStream(adaptor,"token LBR");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:316:2: ( LBR -> ^( IM_STARTTAG LBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:316:4: LBR
            {
            LBR139=(Token)match(input,LBR,FOLLOW_LBR_in_squarebr_start1652);  
            stream_LBR.add(LBR139);



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
            // 316:8: -> ^( IM_STARTTAG LBR )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:316:11: ^( IM_STARTTAG LBR )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:318:1: squarebr_end : RBR -> ^( IM_ENDTAG RBR ) ;
    public final simpletikzParser.squarebr_end_return squarebr_end() throws RecognitionException {
        simpletikzParser.squarebr_end_return retval = new simpletikzParser.squarebr_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token RBR140=null;

        Object RBR140_tree=null;
        RewriteRuleTokenStream stream_RBR=new RewriteRuleTokenStream(adaptor,"token RBR");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:319:2: ( RBR -> ^( IM_ENDTAG RBR ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:319:4: RBR
            {
            RBR140=(Token)match(input,RBR,FOLLOW_RBR_in_squarebr_end1670);  
            stream_RBR.add(RBR140);



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
            // 319:8: -> ^( IM_ENDTAG RBR )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:319:11: ^( IM_ENDTAG RBR )
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

    public static class semicolon_end_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "semicolon_end"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:321:1: semicolon_end : ';' -> ^( IM_ENDTAG ';' ) ;
    public final simpletikzParser.semicolon_end_return semicolon_end() throws RecognitionException {
        simpletikzParser.semicolon_end_return retval = new simpletikzParser.semicolon_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal141=null;

        Object char_literal141_tree=null;
        RewriteRuleTokenStream stream_SEMIC=new RewriteRuleTokenStream(adaptor,"token SEMIC");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:322:2: ( ';' -> ^( IM_ENDTAG ';' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:322:4: ';'
            {
            char_literal141=(Token)match(input,SEMIC,FOLLOW_SEMIC_in_semicolon_end1689);  
            stream_SEMIC.add(char_literal141);



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
            // 322:8: -> ^( IM_ENDTAG ';' )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:322:11: ^( IM_ENDTAG ';' )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:324:1: roundbr_end : '}' -> ^( IM_ENDTAG '}' ) ;
    public final simpletikzParser.roundbr_end_return roundbr_end() throws RecognitionException {
        simpletikzParser.roundbr_end_return retval = new simpletikzParser.roundbr_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal142=null;

        Object char_literal142_tree=null;
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:325:2: ( '}' -> ^( IM_ENDTAG '}' ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:325:4: '}'
            {
            char_literal142=(Token)match(input,RBRR,FOLLOW_RBRR_in_roundbr_end1707);  
            stream_RBRR.add(char_literal142);



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
            // 325:8: -> ^( IM_ENDTAG '}' )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:325:11: ^( IM_ENDTAG '}' )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IM_ENDTAG, "IM_ENDTAG"), root_1);

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
        return retval;
    }
    // $ANTLR end "roundbr_end"

    public static class tikz_set_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikz_set_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:327:1: tikz_set_start : TIKZSET '{' -> ^( IM_STARTTAG ) ;
    public final simpletikzParser.tikz_set_start_return tikz_set_start() throws RecognitionException {
        simpletikzParser.tikz_set_start_return retval = new simpletikzParser.tikz_set_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token TIKZSET143=null;
        Token char_literal144=null;

        Object TIKZSET143_tree=null;
        Object char_literal144_tree=null;
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_TIKZSET=new RewriteRuleTokenStream(adaptor,"token TIKZSET");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:328:2: ( TIKZSET '{' -> ^( IM_STARTTAG ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:328:4: TIKZSET '{'
            {
            TIKZSET143=(Token)match(input,TIKZSET,FOLLOW_TIKZSET_in_tikz_set_start1725);  
            stream_TIKZSET.add(TIKZSET143);

            char_literal144=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikz_set_start1727);  
            stream_LBRR.add(char_literal144);



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
            // 328:17: -> ^( IM_STARTTAG )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:328:20: ^( IM_STARTTAG )
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

    public static class tikzpicture_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzpicture_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:330:1: tikzpicture_start : BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public final simpletikzParser.tikzpicture_start_return tikzpicture_start() throws RecognitionException {
        simpletikzParser.tikzpicture_start_return retval = new simpletikzParser.tikzpicture_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGIN145=null;
        Token char_literal146=null;
        Token string_literal147=null;
        Token char_literal148=null;

        Object BEGIN145_tree=null;
        Object char_literal146_tree=null;
        Object string_literal147_tree=null;
        Object char_literal148_tree=null;
        RewriteRuleTokenStream stream_67=new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_BEGIN=new RewriteRuleTokenStream(adaptor,"token BEGIN");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:331:2: ( BEGIN '{' 'tikzpicture' '}' -> ^( IM_STARTTAG BEGIN ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:331:4: BEGIN '{' 'tikzpicture' '}'
            {
            BEGIN145=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_tikzpicture_start1746);  
            stream_BEGIN.add(BEGIN145);

            char_literal146=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_start1748);  
            stream_LBRR.add(char_literal146);

            string_literal147=(Token)match(input,67,FOLLOW_67_in_tikzpicture_start1750);  
            stream_67.add(string_literal147);

            char_literal148=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_start1752);  
            stream_RBRR.add(char_literal148);



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
            // 331:32: -> ^( IM_STARTTAG BEGIN )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:331:35: ^( IM_STARTTAG BEGIN )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:333:1: tikzpicture_end : END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) ;
    public final simpletikzParser.tikzpicture_end_return tikzpicture_end() throws RecognitionException {
        simpletikzParser.tikzpicture_end_return retval = new simpletikzParser.tikzpicture_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token END149=null;
        Token char_literal150=null;
        Token string_literal151=null;
        Token char_literal152=null;

        Object END149_tree=null;
        Object char_literal150_tree=null;
        Object string_literal151_tree=null;
        Object char_literal152_tree=null;
        RewriteRuleTokenStream stream_67=new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END=new RewriteRuleTokenStream(adaptor,"token END");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:334:2: ( END '{' 'tikzpicture' '}' -> ^( IM_ENDTAG END ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:334:4: END '{' 'tikzpicture' '}'
            {
            END149=(Token)match(input,END,FOLLOW_END_in_tikzpicture_end1770);  
            stream_END.add(END149);

            char_literal150=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzpicture_end1772);  
            stream_LBRR.add(char_literal150);

            string_literal151=(Token)match(input,67,FOLLOW_67_in_tikzpicture_end1774);  
            stream_67.add(string_literal151);

            char_literal152=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzpicture_end1776);  
            stream_RBRR.add(char_literal152);



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
            // 334:30: -> ^( IM_ENDTAG END )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:334:33: ^( IM_ENDTAG END )
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

    public static class tikzscope_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "tikzscope_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:336:1: tikzscope_start : BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) ;
    public final simpletikzParser.tikzscope_start_return tikzscope_start() throws RecognitionException {
        simpletikzParser.tikzscope_start_return retval = new simpletikzParser.tikzscope_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token BEGIN153=null;
        Token char_literal154=null;
        Token string_literal155=null;
        Token char_literal156=null;

        Object BEGIN153_tree=null;
        Object char_literal154_tree=null;
        Object string_literal155_tree=null;
        Object char_literal156_tree=null;
        RewriteRuleTokenStream stream_68=new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_BEGIN=new RewriteRuleTokenStream(adaptor,"token BEGIN");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:2: ( BEGIN '{' 'scope' '}' -> ^( IM_STARTTAG BEGIN ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:4: BEGIN '{' 'scope' '}'
            {
            BEGIN153=(Token)match(input,BEGIN,FOLLOW_BEGIN_in_tikzscope_start1794);  
            stream_BEGIN.add(BEGIN153);

            char_literal154=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzscope_start1796);  
            stream_LBRR.add(char_literal154);

            string_literal155=(Token)match(input,68,FOLLOW_68_in_tikzscope_start1798);  
            stream_68.add(string_literal155);

            char_literal156=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzscope_start1800);  
            stream_RBRR.add(char_literal156);



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
            // 337:26: -> ^( IM_STARTTAG BEGIN )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:337:29: ^( IM_STARTTAG BEGIN )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:339:1: tikzscope_end : END '{' 'scope' '}' -> ^( IM_ENDTAG END ) ;
    public final simpletikzParser.tikzscope_end_return tikzscope_end() throws RecognitionException {
        simpletikzParser.tikzscope_end_return retval = new simpletikzParser.tikzscope_end_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token END157=null;
        Token char_literal158=null;
        Token string_literal159=null;
        Token char_literal160=null;

        Object END157_tree=null;
        Object char_literal158_tree=null;
        Object string_literal159_tree=null;
        Object char_literal160_tree=null;
        RewriteRuleTokenStream stream_68=new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_RBRR=new RewriteRuleTokenStream(adaptor,"token RBRR");
        RewriteRuleTokenStream stream_LBRR=new RewriteRuleTokenStream(adaptor,"token LBRR");
        RewriteRuleTokenStream stream_END=new RewriteRuleTokenStream(adaptor,"token END");

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:340:2: ( END '{' 'scope' '}' -> ^( IM_ENDTAG END ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:340:4: END '{' 'scope' '}'
            {
            END157=(Token)match(input,END,FOLLOW_END_in_tikzscope_end1818);  
            stream_END.add(END157);

            char_literal158=(Token)match(input,LBRR,FOLLOW_LBRR_in_tikzscope_end1820);  
            stream_LBRR.add(char_literal158);

            string_literal159=(Token)match(input,68,FOLLOW_68_in_tikzscope_end1822);  
            stream_68.add(string_literal159);

            char_literal160=(Token)match(input,RBRR,FOLLOW_RBRR_in_tikzscope_end1824);  
            stream_RBRR.add(char_literal160);



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
            // 340:24: -> ^( IM_ENDTAG END )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:340:27: ^( IM_ENDTAG END )
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

    public static class path_start_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "path_start"
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:342:1: path_start : path_start_tag -> ^( IM_STARTTAG path_start_tag ) ;
    public final simpletikzParser.path_start_return path_start() throws RecognitionException {
        simpletikzParser.path_start_return retval = new simpletikzParser.path_start_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        simpletikzParser.path_start_tag_return path_start_tag161 = null;


        RewriteRuleSubtreeStream stream_path_start_tag=new RewriteRuleSubtreeStream(adaptor,"rule path_start_tag");
        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:343:2: ( path_start_tag -> ^( IM_STARTTAG path_start_tag ) )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:343:4: path_start_tag
            {
            pushFollow(FOLLOW_path_start_tag_in_path_start1843);
            path_start_tag161=path_start_tag();

            state._fsp--;

            stream_path_start_tag.add(path_start_tag161.getTree());


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
            // 343:19: -> ^( IM_STARTTAG path_start_tag )
            {
                // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:343:22: ^( IM_STARTTAG path_start_tag )
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
    // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:346:1: path_start_tag : ( DRAW | FILL | PATH );
    public final simpletikzParser.path_start_tag_return path_start_tag() throws RecognitionException {
        simpletikzParser.path_start_tag_return retval = new simpletikzParser.path_start_tag_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set162=null;

        Object set162_tree=null;

        try {
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:347:2: ( DRAW | FILL | PATH )
            // C:\\Users\\tw\\Documents\\Visual Studio 2010\\Projects\\TikzEdt\\TikzEdt\\simpletikz.g:
            {
            root_0 = (Object)adaptor.nil();

            set162=(Token)input.LT(1);
            if ( (input.LA(1)>=DRAW && input.LA(1)<=FILL) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set162));
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

    // Delegated rules


    protected DFA7 dfa7 = new DFA7(this);
    protected DFA26 dfa26 = new DFA26(this);
    protected DFA27 dfa27 = new DFA27(this);
    static final String DFA7_eotS =
        "\6\uffff";
    static final String DFA7_eofS =
        "\6\uffff";
    static final String DFA7_minS =
        "\1\55\2\20\2\uffff\1\20";
    static final String DFA7_maxS =
        "\3\100\2\uffff\1\65";
    static final String DFA7_acceptS =
        "\3\uffff\1\1\1\2\1\uffff";
    static final String DFA7_specialS =
        "\6\uffff}>";
    static final String[] DFA7_transitionS = {
            "\1\1\17\uffff\4\1",
            "\1\4\1\uffff\3\4\26\uffff\1\5\1\uffff\1\2\7\uffff\1\3\7\uffff"+
            "\4\2",
            "\1\4\1\uffff\3\4\30\uffff\1\2\7\uffff\1\3\7\uffff\4\2",
            "",
            "",
            "\1\4\1\uffff\3\4\40\uffff\1\3"
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
            return "120:1: option : ( option_style | option_kv );";
        }
    }
    static final String DFA26_eotS =
        "\13\uffff";
    static final String DFA26_eofS =
        "\13\uffff";
    static final String DFA26_minS =
        "\1\4\1\21\6\uffff\1\55\2\uffff";
    static final String DFA26_maxS =
        "\1\104\1\21\6\uffff\1\104\2\uffff";
    static final String DFA26_acceptS =
        "\2\uffff\1\2\1\3\1\4\1\5\1\6\1\10\1\uffff\1\1\1\7";
    static final String DFA26_specialS =
        "\13\uffff}>";
    static final String[] DFA26_transitionS = {
            "\1\1\1\7\1\4\1\6\1\5\1\3\3\2\2\4\1\uffff\65\4",
            "\1\10",
            "",
            "",
            "",
            "",
            "",
            "",
            "\1\12\17\uffff\4\12\3\uffff\1\11",
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
            return "187:4: ( tikzscope | tikzpath | tikznodee | dontcare_body_nobr | tikz_set | tikz_style | otherbegin | otherend )";
        }
    }
    static final String DFA27_eotS =
        "\16\uffff";
    static final String DFA27_eofS =
        "\16\uffff";
    static final String DFA27_minS =
        "\1\4\2\21\5\uffff\2\55\4\uffff";
    static final String DFA27_maxS =
        "\1\104\2\21\5\uffff\2\104\4\uffff";
    static final String DFA27_acceptS =
        "\3\uffff\1\2\1\3\1\4\1\5\1\6\2\uffff\1\11\1\10\1\1\1\7";
    static final String DFA27_specialS =
        "\16\uffff}>";
    static final String[] DFA27_transitionS = {
            "\1\2\1\1\1\5\1\7\1\6\1\4\3\3\70\5",
            "\1\10",
            "\1\11",
            "",
            "",
            "",
            "",
            "",
            "\1\13\17\uffff\4\13\2\uffff\2\12",
            "\1\15\17\uffff\4\15\3\uffff\1\14",
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
            return "()* loopback of 188:3: ( tikzscope | tikzpath | tikznodee | dontcare_body | tikz_set | tikz_style | otherbegin | otherend )*";
        }
    }
 

    public static final BitSet FOLLOW_tikz_styleorsetorcmd_in_tikzdocument338 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000001FL});
    public static final BitSet FOLLOW_dontcare_preamble_in_tikzdocument342 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000001FL});
    public static final BitSet FOLLOW_otherbegin_in_tikzdocument346 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikzpicture_in_tikzdocument351 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_style_in_tikz_styleorsetorcmd378 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_set_in_tikz_styleorsetorcmd382 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_cmd_comment_in_tikz_styleorsetorcmd386 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_dontcare_preamble397 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_otherbegin422 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_otherbegin424 = new BitSet(new long[]{0xE000200000000000L,0x0000000000000001L});
    public static final BitSet FOLLOW_idd_in_otherbegin426 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_otherbegin428 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TIKZEDT_CMD_COMMENT_in_tikz_cmd_comment441 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TIKZSTYLE_in_tikz_style466 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_tikz_style468 = new BitSet(new long[]{0xE000200000000000L,0x0000000000000001L});
    public static final BitSet FOLLOW_idd_in_tikz_style470 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_tikz_style472 = new BitSet(new long[]{0x0000000000100000L});
    public static final BitSet FOLLOW_EQU_in_tikz_style474 = new BitSet(new long[]{0x0000000000008000L});
    public static final BitSet FOLLOW_tikz_options_in_tikz_style476 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_squarebr_start_in_tikz_options498 = new BitSet(new long[]{0xE000200000010000L,0x0000000000000001L});
    public static final BitSet FOLLOW_option_in_tikz_options501 = new BitSet(new long[]{0xE000200000090000L,0x0000000000000001L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_options504 = new BitSet(new long[]{0xE000200000000000L,0x0000000000000001L});
    public static final BitSet FOLLOW_option_in_tikz_options506 = new BitSet(new long[]{0xE000200000090000L,0x0000000000000001L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_options510 = new BitSet(new long[]{0xE000200000010000L,0x0000000000000001L});
    public static final BitSet FOLLOW_squarebr_end_in_tikz_options515 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_style_in_option540 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_option_kv_in_option549 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_kv563 = new BitSet(new long[]{0x0000000000100002L});
    public static final BitSet FOLLOW_EQU_in_option_kv566 = new BitSet(new long[]{0xE000380000020000L,0x0000000000000001L});
    public static final BitSet FOLLOW_iddornumberunitorstring_in_option_kv568 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBR_in_nodetype596 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_no_rlbracket_in_nodetype598 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_nodetype_in_nodetype602 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_no_rlbracket_in_nodetype604 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_RBR_in_nodetype609 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_no_rlbracket632 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBRR_in_tikzstring649 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_no_rlbrace_in_tikzstring651 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikzstring_in_tikzstring655 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_no_rlbrace_in_tikzstring657 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_RBRR_in_tikzstring662 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_no_rlbrace685 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_iddornumberunitorstring702 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_numberunit_in_iddornumberunitorstring706 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzstring_in_iddornumberunitorstring710 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_idd_in_option_style720 = new BitSet(new long[]{0x0020000000000000L});
    public static final BitSet FOLLOW_53_in_option_style722 = new BitSet(new long[]{0x0000000000100000L});
    public static final BitSet FOLLOW_EQU_in_option_style724 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_option_style726 = new BitSet(new long[]{0xE0002000000C0000L,0x0000000000000001L});
    public static final BitSet FOLLOW_option_kv_in_option_style729 = new BitSet(new long[]{0x00000000000C0000L});
    public static final BitSet FOLLOW_KOMMA_in_option_style732 = new BitSet(new long[]{0xE000200000000000L,0x0000000000000001L});
    public static final BitSet FOLLOW_option_kv_in_option_style734 = new BitSet(new long[]{0x00000000000C0000L});
    public static final BitSet FOLLOW_KOMMA_in_option_style741 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_option_style744 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_edgeop_in_idd775 = new BitSet(new long[]{0xE000200000000002L,0x0000000000000001L});
    public static final BitSet FOLLOW_edgeop_in_idd778 = new BitSet(new long[]{0xE000200000000002L,0x0000000000000001L});
    public static final BitSet FOLLOW_edgeop_in_idd794 = new BitSet(new long[]{0x0000080000000000L});
    public static final BitSet FOLLOW_INT_in_idd796 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_number_in_numberunit825 = new BitSet(new long[]{0x0FC0000000000002L});
    public static final BitSet FOLLOW_unit_in_numberunit827 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_number853 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_unit0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikz_set_start_in_tikz_set908 = new BitSet(new long[]{0xE000200000040000L,0x0000000000000001L});
    public static final BitSet FOLLOW_option_in_tikz_set911 = new BitSet(new long[]{0xE0002000000C0000L,0x0000000000000001L});
    public static final BitSet FOLLOW_KOMMA_in_tikz_set914 = new BitSet(new long[]{0xE000200000000000L,0x0000000000000001L});
    public static final BitSet FOLLOW_option_in_tikz_set916 = new BitSet(new long[]{0xE0002000000C0000L,0x0000000000000001L});
    public static final BitSet FOLLOW_roundbr_end_in_tikz_set922 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzpicture_start_in_tikzpicture950 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikz_options_in_tikzpicture952 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikzbody_in_tikzpicture955 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikzpicture_end_in_tikzpicture958 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody988 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody992 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikznodee_in_tikzbody996 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_dontcare_body_nobr_in_tikzbody1000 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikz_set_in_tikzbody1004 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikz_style_in_tikzbody1008 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_otherbegin_in_tikzbody1012 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_otherend_in_tikzbody1015 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikzscope_in_tikzbody1025 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikzpath_in_tikzbody1029 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikznodee_in_tikzbody1033 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000001FL});
    public static final BitSet FOLLOW_dontcare_body_in_tikzbody1037 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikz_set_in_tikzbody1046 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikz_style_in_tikzbody1050 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000001FL});
    public static final BitSet FOLLOW_otherbegin_in_tikzbody1054 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000001FL});
    public static final BitSet FOLLOW_otherend_in_tikzbody1057 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF2L,0x000000000000001FL});
    public static final BitSet FOLLOW_set_in_dontcare_body_nobr1073 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_dontcare_body1123 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_otherend1167 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_otherend1169 = new BitSet(new long[]{0xE000200000000000L,0x0000000000000001L});
    public static final BitSet FOLLOW_idd_in_otherend1171 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_otherend1173 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_in_tikzpath1186 = new BitSet(new long[]{0x000000000000A000L,0x0000000000000006L});
    public static final BitSet FOLLOW_tikz_options_in_tikzpath1188 = new BitSet(new long[]{0x000000000000A000L,0x0000000000000006L});
    public static final BitSet FOLLOW_tikzpathi_in_tikzpath1191 = new BitSet(new long[]{0x0000000000200000L});
    public static final BitSet FOLLOW_semicolon_end_in_tikzpath1193 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coordornode_new_in_tikzpathi1224 = new BitSet(new long[]{0xE000200000000002L,0x0000000000000001L});
    public static final BitSet FOLLOW_edgeop_in_tikzpathi1227 = new BitSet(new long[]{0x000000000000A000L,0x0000000000000006L});
    public static final BitSet FOLLOW_coordornode_new_in_tikzpathi1230 = new BitSet(new long[]{0xE000200000000002L,0x0000000000000001L});
    public static final BitSet FOLLOW_tikzscope_start_in_tikzscope1247 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikz_options_in_tikzscope1249 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikzbody_in_tikzscope1252 = new BitSet(new long[]{0xFFFFFFFFFFFFFFF0L,0x000000000000001FL});
    public static final BitSet FOLLOW_tikzscope_end_in_tikzscope1255 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_in_coordornode1283 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_size_in_coordornode1287 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_tikznodei_in_coordornode1291 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_in_coordornode_new1308 = new BitSet(new long[]{0x0000200000000002L});
    public static final BitSet FOLLOW_ID_in_coordornode_new1311 = new BitSet(new long[]{0xE000380000028002L,0x0000000000000001L});
    public static final BitSet FOLLOW_nodetype_in_coordornode_new1314 = new BitSet(new long[]{0xE000380000020002L,0x0000000000000001L});
    public static final BitSet FOLLOW_tikzstring_in_coordornode_new1319 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_size_in_coordornode_new1328 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_tikznodei1341 = new BitSet(new long[]{0xF00038000002A000L,0x0000000000000001L});
    public static final BitSet FOLLOW_tikznode_in_tikznodei1344 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LPAR_in_nodename1356 = new BitSet(new long[]{0x0000200000000000L});
    public static final BitSet FOLLOW_ID_in_nodename1360 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_RPAR_in_nodename1362 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_modifier_in_size1388 = new BitSet(new long[]{0x0000000000002000L});
    public static final BitSet FOLLOW_LPAR_in_size1393 = new BitSet(new long[]{0x0000180000000000L});
    public static final BitSet FOLLOW_numberunit_in_size1395 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_RPAR_in_size1397 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_coord1419 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_coord_modifier_in_coord1443 = new BitSet(new long[]{0x0000000000002000L});
    public static final BitSet FOLLOW_LPAR_in_coord1448 = new BitSet(new long[]{0x0000180000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord1450 = new BitSet(new long[]{0x0000000000480000L});
    public static final BitSet FOLLOW_coord_sep_in_coord1452 = new BitSet(new long[]{0x0000180000000000L});
    public static final BitSet FOLLOW_numberunit_in_coord1454 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_RPAR_in_coord1456 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_sep1483 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_nodename_in_tikznode1503 = new BitSet(new long[]{0xF000380000028000L,0x0000000000000001L});
    public static final BitSet FOLLOW_60_in_tikznode1507 = new BitSet(new long[]{0x0000000000002000L,0x0000000000000006L});
    public static final BitSet FOLLOW_coord_in_tikznode1509 = new BitSet(new long[]{0xE000380000028000L,0x0000000000000001L});
    public static final BitSet FOLLOW_nodetype_in_tikznode1513 = new BitSet(new long[]{0xE000380000020000L,0x0000000000000001L});
    public static final BitSet FOLLOW_tikzstring_in_tikznode1516 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_edgeop0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_coord_modifier0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_node_start_in_tikznodee1591 = new BitSet(new long[]{0xF00038000002A000L,0x0000000000000001L});
    public static final BitSet FOLLOW_tikznode_in_tikznodee1593 = new BitSet(new long[]{0x000000000020A000L,0x0000000000000006L});
    public static final BitSet FOLLOW_tikzpathi_in_tikznodee1595 = new BitSet(new long[]{0x0000000000200000L});
    public static final BitSet FOLLOW_semicolon_end_in_tikznodee1598 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NODE_in_node_start1626 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LBR_in_squarebr_start1652 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RBR_in_squarebr_end1670 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SEMIC_in_semicolon_end1689 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RBRR_in_roundbr_end1707 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TIKZSET_in_tikz_set_start1725 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_tikz_set_start1727 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_tikzpicture_start1746 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_tikzpicture_start1748 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000008L});
    public static final BitSet FOLLOW_67_in_tikzpicture_start1750 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_tikzpicture_start1752 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_tikzpicture_end1770 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_tikzpicture_end1772 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000008L});
    public static final BitSet FOLLOW_67_in_tikzpicture_end1774 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_tikzpicture_end1776 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BEGIN_in_tikzscope_start1794 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_tikzscope_start1796 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000010L});
    public static final BitSet FOLLOW_68_in_tikzscope_start1798 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_tikzscope_start1800 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_END_in_tikzscope_end1818 = new BitSet(new long[]{0x0000000000020000L});
    public static final BitSet FOLLOW_LBRR_in_tikzscope_end1820 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000010L});
    public static final BitSet FOLLOW_68_in_tikzscope_end1822 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_RBRR_in_tikzscope_end1824 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_path_start_tag_in_path_start1843 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_path_start_tag0 = new BitSet(new long[]{0x0000000000000002L});

}