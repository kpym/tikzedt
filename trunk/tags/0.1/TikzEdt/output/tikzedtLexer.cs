// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g 2010-12-20 22:48:27

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class tikzedtLexer : Lexer {
    public const int SOMETHING_IN_BRACKETS = 18;
    public const int TIKZEDT_CMD_COMMENT = 21;
    public const int NODE = 12;
    public const int TIKZPICTURE = 11;
    public const int STYLESEP = 15;
    public const int INPUT = 5;
    public const int HEX_DIGIT = 26;
    public const int FLOAT = 24;
    public const int INT = 23;
    public const int USEPACKAGE = 6;
    public const int ID = 22;
    public const int EOF = -1;
    public const int SOMETHING_IN_CURLY_BRACKETS = 19;
    public const int TIKZSTYLES = 9;
    public const int USETIKZLIB = 7;
    public const int WS = 20;
    public const int NEWLINE = 17;
    public const int PATH = 14;
    public const int BEGIN = 10;
    public const int IM_COMMENT = 16;
    public const int TIKZEDT = 4;
    public const int COMMENT = 25;
    public const int DRAW = 13;
    public const int DOCUMENTCLASS = 8;

    // delegates
    // delegators

    public tikzedtLexer() 
    {
		InitializeCyclicDFAs();
    }
    public tikzedtLexer(ICharStream input)
		: this(input, null) {
    }
    public tikzedtLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g";} 
    }

    // $ANTLR start "TIKZEDT"
    public void mTIKZEDT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TIKZEDT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:7:9: ( '!TIKZEDT' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:7:11: '!TIKZEDT'
            {
            	Match("!TIKZEDT"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TIKZEDT"

    // $ANTLR start "INPUT"
    public void mINPUT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INPUT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:8:7: ( '\\\\input' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:8:9: '\\\\input'
            {
            	Match("\\input"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INPUT"

    // $ANTLR start "USEPACKAGE"
    public void mUSEPACKAGE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = USEPACKAGE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:9:12: ( '\\\\usepackage' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:9:14: '\\\\usepackage'
            {
            	Match("\\usepackage"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "USEPACKAGE"

    // $ANTLR start "USETIKZLIB"
    public void mUSETIKZLIB() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = USETIKZLIB;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:10:12: ( '\\\\usetikzlibrary' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:10:14: '\\\\usetikzlibrary'
            {
            	Match("\\usetikzlibrary"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "USETIKZLIB"

    // $ANTLR start "DOCUMENTCLASS"
    public void mDOCUMENTCLASS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOCUMENTCLASS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:11:15: ( '\\\\documentclass' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:11:17: '\\\\documentclass'
            {
            	Match("\\documentclass"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOCUMENTCLASS"

    // $ANTLR start "TIKZSTYLES"
    public void mTIKZSTYLES() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TIKZSTYLES;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:12:12: ( '\\\\tikzstyle' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:12:14: '\\\\tikzstyle'
            {
            	Match("\\tikzstyle"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TIKZSTYLES"

    // $ANTLR start "BEGIN"
    public void mBEGIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BEGIN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:13:7: ( '\\\\begin' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:13:9: '\\\\begin'
            {
            	Match("\\begin"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BEGIN"

    // $ANTLR start "TIKZPICTURE"
    public void mTIKZPICTURE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TIKZPICTURE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:14:13: ( '{tikzpicture}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:14:15: '{tikzpicture}'
            {
            	Match("{tikzpicture}"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TIKZPICTURE"

    // $ANTLR start "NODE"
    public void mNODE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NODE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:15:6: ( '\\\\node' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:15:8: '\\\\node'
            {
            	Match("\\node"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NODE"

    // $ANTLR start "DRAW"
    public void mDRAW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DRAW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:16:6: ( '\\\\draw' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:16:8: '\\\\draw'
            {
            	Match("\\draw"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DRAW"

    // $ANTLR start "PATH"
    public void mPATH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PATH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:17:6: ( '\\\\path' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:17:8: '\\\\path'
            {
            	Match("\\path"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PATH"

    // $ANTLR start "STYLESEP"
    public void mSTYLESEP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STYLESEP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:18:10: ( '/.style' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:18:12: '/.style'
            {
            	Match("/.style"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STYLESEP"

    // $ANTLR start "TIKZEDT_CMD_COMMENT"
    public void mTIKZEDT_CMD_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TIKZEDT_CMD_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:73:5: ( '%' WS TIKZEDT (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:73:9: '%' WS TIKZEDT (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	mWS(); 
            	mTIKZEDT(); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:73:26: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '\u0000' && LA1_0 <= '\t') || (LA1_0 >= '\u000B' && LA1_0 <= '\f') || (LA1_0 >= '\u000E' && LA1_0 <= '\uFFFF')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:73:26: ~ ( '\\n' | '\\r' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:73:40: ( '\\r' )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == '\r') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:73:40: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	Match('\n'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TIKZEDT_CMD_COMMENT"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:76:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:76:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:76:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '0' && LA3_0 <= '9') || (LA3_0 >= 'A' && LA3_0 <= 'Z') || LA3_0 == '_' || (LA3_0 >= 'a' && LA3_0 <= 'z')) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:79:5: ( ( '0' .. '9' )+ )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:79:7: ( '0' .. '9' )+
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:79:7: ( '0' .. '9' )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:79:7: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "FLOAT"
    public void mFLOAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FLOAT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:83:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( ((LA8_0 >= '0' && LA8_0 <= '9')) )
            {
                alt8 = 1;
            }
            else if ( (LA8_0 == '.') )
            {
                alt8 = 2;
            }
            else 
            {
                NoViableAltException nvae_d8s0 =
                    new NoViableAltException("", 8, 0, input);

                throw nvae_d8s0;
            }
            switch (alt8) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:83:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:83:9: ( '0' .. '9' )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:83:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt5 >= 1 ) goto loop5;
                    		            EarlyExitException eee5 =
                    		                new EarlyExitException(5, input);
                    		            throw eee5;
                    	    }
                    	    cnt5++;
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements

                    	Match('.'); 
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:83:25: ( '0' .. '9' )*
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:83:26: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop6;
                    	    }
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements


                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:84:9: '.' ( '0' .. '9' )+
                    {
                    	Match('.'); 
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:84:13: ( '0' .. '9' )+
                    	int cnt7 = 0;
                    	do 
                    	{
                    	    int alt7 = 2;
                    	    int LA7_0 = input.LA(1);

                    	    if ( ((LA7_0 >= '0' && LA7_0 <= '9')) )
                    	    {
                    	        alt7 = 1;
                    	    }


                    	    switch (alt7) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:84:14: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt7 >= 1 ) goto loop7;
                    		            EarlyExitException eee7 =
                    		                new EarlyExitException(7, input);
                    		            throw eee7;
                    	    }
                    	    cnt7++;
                    	} while (true);

                    	loop7:
                    		;	// Stops C# compiler whining that label 'loop7' has no statements


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FLOAT"

    // $ANTLR start "SOMETHING_IN_BRACKETS"
    public void mSOMETHING_IN_BRACKETS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SOMETHING_IN_BRACKETS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:88:2: ( '[' (~ ( '[' | ']' ) )* ']' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:88:4: '[' (~ ( '[' | ']' ) )* ']'
            {
            	Match('['); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:88:8: (~ ( '[' | ']' ) )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= '\u0000' && LA9_0 <= 'Z') || LA9_0 == '\\' || (LA9_0 >= '^' && LA9_0 <= '\uFFFF')) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:88:8: ~ ( '[' | ']' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= 'Z') || input.LA(1) == '\\' || (input.LA(1) >= '^' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	Match(']'); 
            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SOMETHING_IN_BRACKETS"

    // $ANTLR start "SOMETHING_IN_CURLY_BRACKETS"
    public void mSOMETHING_IN_CURLY_BRACKETS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SOMETHING_IN_CURLY_BRACKETS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:92:2: ( '{' (~ ( '{' | '}' ) )* '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:92:4: '{' (~ ( '{' | '}' ) )* '}'
            {
            	Match('{'); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:92:8: (~ ( '{' | '}' ) )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= '\u0000' && LA10_0 <= 'z') || LA10_0 == '|' || (LA10_0 >= '~' && LA10_0 <= '\uFFFF')) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:92:8: ~ ( '{' | '}' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= 'z') || input.LA(1) == '|' || (input.LA(1) >= '~' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	Match('}'); 
            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SOMETHING_IN_CURLY_BRACKETS"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:96:5: ( '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:96:9: '%' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:96:13: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= '\u0000' && LA11_0 <= '\t') || (LA11_0 >= '\u000B' && LA11_0 <= '\f') || (LA11_0 >= '\u000E' && LA11_0 <= '\uFFFF')) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:96:13: ~ ( '\\n' | '\\r' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:96:27: ( '\\r' )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == '\r') )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:96:27: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	Match('\n'); 
            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:99:9: ( ( '\\r' | '\\n' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:99:11: ( '\\r' | '\\n' )
            {
            	if ( input.LA(1) == '\n' || input.LA(1) == '\r' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWLINE"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:104:5: ( ( ' ' | '\\t' | NEWLINE ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:104:9: ( ' ' | '\\t' | NEWLINE )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "HEX_DIGIT"
    public void mHEX_DIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:112:11: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:112:13: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HEX_DIGIT"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:8: ( TIKZEDT | INPUT | USEPACKAGE | USETIKZLIB | DOCUMENTCLASS | TIKZSTYLES | BEGIN | TIKZPICTURE | NODE | DRAW | PATH | STYLESEP | TIKZEDT_CMD_COMMENT | ID | INT | FLOAT | SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | COMMENT | NEWLINE | WS )
        int alt13 = 21;
        alt13 = dfa13.Predict(input);
        switch (alt13) 
        {
            case 1 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:10: TIKZEDT
                {
                	mTIKZEDT(); 

                }
                break;
            case 2 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:18: INPUT
                {
                	mINPUT(); 

                }
                break;
            case 3 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:24: USEPACKAGE
                {
                	mUSEPACKAGE(); 

                }
                break;
            case 4 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:35: USETIKZLIB
                {
                	mUSETIKZLIB(); 

                }
                break;
            case 5 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:46: DOCUMENTCLASS
                {
                	mDOCUMENTCLASS(); 

                }
                break;
            case 6 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:60: TIKZSTYLES
                {
                	mTIKZSTYLES(); 

                }
                break;
            case 7 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:71: BEGIN
                {
                	mBEGIN(); 

                }
                break;
            case 8 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:77: TIKZPICTURE
                {
                	mTIKZPICTURE(); 

                }
                break;
            case 9 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:89: NODE
                {
                	mNODE(); 

                }
                break;
            case 10 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:94: DRAW
                {
                	mDRAW(); 

                }
                break;
            case 11 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:99: PATH
                {
                	mPATH(); 

                }
                break;
            case 12 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:104: STYLESEP
                {
                	mSTYLESEP(); 

                }
                break;
            case 13 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:113: TIKZEDT_CMD_COMMENT
                {
                	mTIKZEDT_CMD_COMMENT(); 

                }
                break;
            case 14 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:133: ID
                {
                	mID(); 

                }
                break;
            case 15 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:136: INT
                {
                	mINT(); 

                }
                break;
            case 16 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:140: FLOAT
                {
                	mFLOAT(); 

                }
                break;
            case 17 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:146: SOMETHING_IN_BRACKETS
                {
                	mSOMETHING_IN_BRACKETS(); 

                }
                break;
            case 18 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:168: SOMETHING_IN_CURLY_BRACKETS
                {
                	mSOMETHING_IN_CURLY_BRACKETS(); 

                }
                break;
            case 19 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:196: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 20 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:204: NEWLINE
                {
                	mNEWLINE(); 

                }
                break;
            case 21 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\tikzedt.g:1:212: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA13 dfa13;
	private void InitializeCyclicDFAs()
	{
	    this.dfa13 = new DFA13(this);
	    this.dfa13.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA13_SpecialStateTransition);
	}

    const string DFA13_eotS =
        "\x07\uffff\x01\x19\x10\uffff\x01\x17\x20\uffff";
    const string DFA13_eofS =
        "\x39\uffff";
    const string DFA13_minS =
        "\x01\x09\x01\uffff\x01\x62\x01\x00\x01\uffff\x01\x00\x01\uffff"+
        "\x01\x2e\x05\uffff\x01\x73\x01\x6f\x04\uffff\x01\x00\x01\uffff\x01"+
        "\x00\x01\x0a\x01\uffff\x01\x21\x02\uffff\x01\x65\x02\uffff\x02\x00"+
        "\x01\uffff\x01\x70\x02\x00\x02\uffff\x0e\x00\x01\x0a\x01\uffff\x01"+
        "\x00\x02\uffff";
    const string DFA13_maxS =
        "\x01\x7b\x01\uffff\x01\x75\x01\uffff\x01\uffff\x01\uffff\x01\uffff"+
        "\x01\x39\x05\uffff\x01\x73\x01\x72\x04\uffff\x01\uffff\x01\uffff"+
        "\x01\uffff\x01\x21\x01\uffff\x01\x21\x02\uffff\x01\x65\x02\uffff"+
        "\x02\uffff\x01\uffff\x01\x74\x02\uffff\x02\uffff\x0e\uffff\x01\x0a"+
        "\x01\uffff\x01\uffff\x02\uffff";
    const string DFA13_acceptS =
        "\x01\uffff\x01\x01\x02\uffff\x01\x0c\x01\uffff\x01\x0e\x01\uffff"+
        "\x01\x10\x01\x11\x01\x14\x01\x15\x01\x02\x02\uffff\x01\x06\x01\x07"+
        "\x01\x09\x01\x0b\x01\uffff\x01\x12\x02\uffff\x01\x13\x01\uffff\x01"+
        "\x0f\x01\x14\x01\uffff\x01\x05\x01\x0a\x02\uffff\x01\x0d\x03\uffff"+
        "\x01\x03\x01\x04\x0f\uffff\x01\x0d\x01\uffff\x02\x08";
    const string DFA13_specialS =
        "\x03\uffff\x01\x04\x01\uffff\x01\x0d\x0d\uffff\x01\x00\x01\uffff"+
        "\x01\x0e\x08\uffff\x01\x01\x01\x0f\x02\uffff\x01\x02\x01\x10\x02"+
        "\uffff\x01\x03\x01\x11\x01\x09\x01\x12\x01\x0a\x01\x13\x01\x0b\x01"+
        "\x14\x01\x0c\x01\x15\x01\x05\x01\x16\x01\x06\x01\x08\x02\uffff\x01"+
        "\x07\x02\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x01\x0b\x01\x0a\x02\uffff\x01\x0a\x12\uffff\x01\x0b\x01\x01"+
            "\x03\uffff\x01\x05\x08\uffff\x01\x08\x01\x04\x0a\x07\x07\uffff"+
            "\x1a\x06\x01\x09\x01\x02\x02\uffff\x01\x06\x01\uffff\x1a\x06"+
            "\x01\x03",
            "",
            "\x01\x10\x01\uffff\x01\x0e\x04\uffff\x01\x0c\x04\uffff\x01"+
            "\x11\x01\uffff\x01\x12\x03\uffff\x01\x0f\x01\x0d",
            "\x74\x14\x01\x13\x06\x14\x01\uffff\uff84\x14",
            "",
            "\x09\x17\x01\x15\x01\x18\x02\x17\x01\x16\x12\x17\x01\x15\uffdf"+
            "\x17",
            "",
            "\x01\x08\x01\uffff\x0a\x07",
            "",
            "",
            "",
            "",
            "",
            "\x01\x1b",
            "\x01\x1c\x02\uffff\x01\x1d",
            "",
            "",
            "",
            "",
            "\x69\x14\x01\x1e\x11\x14\x01\uffff\uff84\x14",
            "",
            "\x21\x17\x01\x1f\uffde\x17",
            "\x01\x17\x16\uffff\x01\x20",
            "",
            "\x01\x20",
            "",
            "",
            "\x01\x21",
            "",
            "",
            "\x6b\x14\x01\x22\x0f\x14\x01\uffff\uff84\x14",
            "\x54\x17\x01\x23\uffab\x17",
            "",
            "\x01\x24\x03\uffff\x01\x25",
            "\x7a\x14\x01\x26\x01\uffff\uff84\x14",
            "\x49\x17\x01\x27\uffb6\x17",
            "",
            "",
            "\x70\x14\x01\x28\x0a\x14\x01\uffff\uff84\x14",
            "\x4b\x17\x01\x29\uffb4\x17",
            "\x69\x14\x01\x2a\x11\x14\x01\uffff\uff84\x14",
            "\x5a\x17\x01\x2b\uffa5\x17",
            "\x63\x14\x01\x2c\x17\x14\x01\uffff\uff84\x14",
            "\x45\x17\x01\x2d\uffba\x17",
            "\x74\x14\x01\x2e\x06\x14\x01\uffff\uff84\x14",
            "\x44\x17\x01\x2f\uffbb\x17",
            "\x75\x14\x01\x30\x05\x14\x01\uffff\uff84\x14",
            "\x54\x17\x01\x31\uffab\x17",
            "\x72\x14\x01\x32\x08\x14\x01\uffff\uff84\x14",
            "\x0a\x33\x01\x35\x02\x33\x01\x34\ufff2\x33",
            "\x65\x14\x01\x36\x15\x14\x01\uffff\uff84\x14",
            "\x0a\x33\x01\x35\x02\x33\x01\x34\ufff2\x33",
            "\x01\x35",
            "",
            "\x7b\x14\x01\uffff\x01\x14\x01\x37\uff82\x14",
            "",
            ""
    };

    static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
    static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
    static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
    static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
    static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
    static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
    static readonly short[][] DFA13_transition = DFA.UnpackEncodedStringArray(DFA13_transitionS);

    protected class DFA13 : DFA
    {
        public DFA13(BaseRecognizer recognizer)
        {
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

        override public string Description
        {
            get { return "1:1: Tokens : ( TIKZEDT | INPUT | USEPACKAGE | USETIKZLIB | DOCUMENTCLASS | TIKZSTYLES | BEGIN | TIKZPICTURE | NODE | DRAW | PATH | STYLESEP | TIKZEDT_CMD_COMMENT | ID | INT | FLOAT | SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | COMMENT | NEWLINE | WS );"; }
        }

    }


    protected internal int DFA13_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA13_19 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_19 == 'i') ) { s = 30; }

                   	else if ( ((LA13_19 >= '\u0000' && LA13_19 <= 'h') || (LA13_19 >= 'j' && LA13_19 <= 'z') || (LA13_19 >= '|' && LA13_19 <= '\uFFFF')) ) { s = 20; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA13_30 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_30 == 'k') ) { s = 34; }

                   	else if ( ((LA13_30 >= '\u0000' && LA13_30 <= 'j') || (LA13_30 >= 'l' && LA13_30 <= 'z') || (LA13_30 >= '|' && LA13_30 <= '\uFFFF')) ) { s = 20; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA13_34 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_34 == 'z') ) { s = 38; }

                   	else if ( ((LA13_34 >= '\u0000' && LA13_34 <= 'y') || (LA13_34 >= '|' && LA13_34 <= '\uFFFF')) ) { s = 20; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA13_38 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_38 == 'p') ) { s = 40; }

                   	else if ( ((LA13_38 >= '\u0000' && LA13_38 <= 'o') || (LA13_38 >= 'q' && LA13_38 <= 'z') || (LA13_38 >= '|' && LA13_38 <= '\uFFFF')) ) { s = 20; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA13_3 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_3 == 't') ) { s = 19; }

                   	else if ( ((LA13_3 >= '\u0000' && LA13_3 <= 's') || (LA13_3 >= 'u' && LA13_3 <= 'z') || (LA13_3 >= '|' && LA13_3 <= '\uFFFF')) ) { s = 20; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA13_48 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_48 == 'r') ) { s = 50; }

                   	else if ( ((LA13_48 >= '\u0000' && LA13_48 <= 'q') || (LA13_48 >= 's' && LA13_48 <= 'z') || (LA13_48 >= '|' && LA13_48 <= '\uFFFF')) ) { s = 20; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA13_50 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_50 == 'e') ) { s = 54; }

                   	else if ( ((LA13_50 >= '\u0000' && LA13_50 <= 'd') || (LA13_50 >= 'f' && LA13_50 <= 'z') || (LA13_50 >= '|' && LA13_50 <= '\uFFFF')) ) { s = 20; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA13_54 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_54 == '}') ) { s = 55; }

                   	else if ( ((LA13_54 >= '\u0000' && LA13_54 <= 'z') || LA13_54 == '|' || (LA13_54 >= '~' && LA13_54 <= '\uFFFF')) ) { s = 20; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA13_51 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_51 == '\r') ) { s = 52; }

                   	else if ( (LA13_51 == '\n') ) { s = 53; }

                   	else if ( ((LA13_51 >= '\u0000' && LA13_51 <= '\t') || (LA13_51 >= '\u000B' && LA13_51 <= '\f') || (LA13_51 >= '\u000E' && LA13_51 <= '\uFFFF')) ) { s = 51; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA13_40 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_40 == 'i') ) { s = 42; }

                   	else if ( ((LA13_40 >= '\u0000' && LA13_40 <= 'h') || (LA13_40 >= 'j' && LA13_40 <= 'z') || (LA13_40 >= '|' && LA13_40 <= '\uFFFF')) ) { s = 20; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA13_42 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_42 == 'c') ) { s = 44; }

                   	else if ( ((LA13_42 >= '\u0000' && LA13_42 <= 'b') || (LA13_42 >= 'd' && LA13_42 <= 'z') || (LA13_42 >= '|' && LA13_42 <= '\uFFFF')) ) { s = 20; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA13_44 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_44 == 't') ) { s = 46; }

                   	else if ( ((LA13_44 >= '\u0000' && LA13_44 <= 's') || (LA13_44 >= 'u' && LA13_44 <= 'z') || (LA13_44 >= '|' && LA13_44 <= '\uFFFF')) ) { s = 20; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA13_46 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_46 == 'u') ) { s = 48; }

                   	else if ( ((LA13_46 >= '\u0000' && LA13_46 <= 't') || (LA13_46 >= 'v' && LA13_46 <= 'z') || (LA13_46 >= '|' && LA13_46 <= '\uFFFF')) ) { s = 20; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA13_5 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_5 == '\t' || LA13_5 == ' ') ) { s = 21; }

                   	else if ( (LA13_5 == '\r') ) { s = 22; }

                   	else if ( ((LA13_5 >= '\u0000' && LA13_5 <= '\b') || (LA13_5 >= '\u000B' && LA13_5 <= '\f') || (LA13_5 >= '\u000E' && LA13_5 <= '\u001F') || (LA13_5 >= '!' && LA13_5 <= '\uFFFF')) ) { s = 23; }

                   	else if ( (LA13_5 == '\n') ) { s = 24; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA13_21 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_21 == '!') ) { s = 31; }

                   	else if ( ((LA13_21 >= '\u0000' && LA13_21 <= ' ') || (LA13_21 >= '\"' && LA13_21 <= '\uFFFF')) ) { s = 23; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA13_31 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_31 == 'T') ) { s = 35; }

                   	else if ( ((LA13_31 >= '\u0000' && LA13_31 <= 'S') || (LA13_31 >= 'U' && LA13_31 <= '\uFFFF')) ) { s = 23; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA13_35 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_35 == 'I') ) { s = 39; }

                   	else if ( ((LA13_35 >= '\u0000' && LA13_35 <= 'H') || (LA13_35 >= 'J' && LA13_35 <= '\uFFFF')) ) { s = 23; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA13_39 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_39 == 'K') ) { s = 41; }

                   	else if ( ((LA13_39 >= '\u0000' && LA13_39 <= 'J') || (LA13_39 >= 'L' && LA13_39 <= '\uFFFF')) ) { s = 23; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 18 : 
                   	int LA13_41 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_41 == 'Z') ) { s = 43; }

                   	else if ( ((LA13_41 >= '\u0000' && LA13_41 <= 'Y') || (LA13_41 >= '[' && LA13_41 <= '\uFFFF')) ) { s = 23; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 19 : 
                   	int LA13_43 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_43 == 'E') ) { s = 45; }

                   	else if ( ((LA13_43 >= '\u0000' && LA13_43 <= 'D') || (LA13_43 >= 'F' && LA13_43 <= '\uFFFF')) ) { s = 23; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 20 : 
                   	int LA13_45 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_45 == 'D') ) { s = 47; }

                   	else if ( ((LA13_45 >= '\u0000' && LA13_45 <= 'C') || (LA13_45 >= 'E' && LA13_45 <= '\uFFFF')) ) { s = 23; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 21 : 
                   	int LA13_47 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_47 == 'T') ) { s = 49; }

                   	else if ( ((LA13_47 >= '\u0000' && LA13_47 <= 'S') || (LA13_47 >= 'U' && LA13_47 <= '\uFFFF')) ) { s = 23; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 22 : 
                   	int LA13_49 = input.LA(1);

                   	s = -1;
                   	if ( ((LA13_49 >= '\u0000' && LA13_49 <= '\t') || (LA13_49 >= '\u000B' && LA13_49 <= '\f') || (LA13_49 >= '\u000E' && LA13_49 <= '\uFFFF')) ) { s = 51; }

                   	else if ( (LA13_49 == '\r') ) { s = 52; }

                   	else if ( (LA13_49 == '\n') ) { s = 53; }

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae13 =
            new NoViableAltException(dfa.Description, 13, _s, input);
        dfa.Error(nvae13);
        throw nvae13;
    }
 
    
}
