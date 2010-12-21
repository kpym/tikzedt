// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g 2010-12-21 08:51:34

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class latexLexer : Lexer {
    public const int SOMETHING_IN_BRACKETS = 6;
    public const int TIKZEDT_CMD_COMMENT = 10;
    public const int T__20 = 20;
    public const int HEX_DIGIT = 16;
    public const int INT = 14;
    public const int FLOAT = 15;
    public const int ID = 5;
    public const int EOF = -1;
    public const int SOMETHING_IN_CURLY_BRACKETS = 7;
    public const int TEX_CMD = 9;
    public const int DOUBLENEWLINE = 11;
    public const int T__19 = 19;
    public const int WS = 12;
    public const int T__18 = 18;
    public const int NEWLINE = 8;
    public const int T__17 = 17;
    public const int TIKZEDT = 4;
    public const int COMMENT = 13;

    // delegates
    // delegators

    public latexLexer() 
    {
		InitializeCyclicDFAs();
    }
    public latexLexer(ICharStream input)
		: this(input, null) {
    }
    public latexLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g";} 
    }

    // $ANTLR start "TIKZEDT"
    public void mTIKZEDT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TIKZEDT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:7:9: ( '!TIKZEDT' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:7:11: '!TIKZEDT'
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

    // $ANTLR start "T__17"
    public void mT__17() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__17;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:8:7: ( '\\\\begin{' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:8:9: '\\\\begin{'
            {
            	Match("\\begin{"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__17"

    // $ANTLR start "T__18"
    public void mT__18() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__18;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:9:7: ( '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:9:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__18"

    // $ANTLR start "T__19"
    public void mT__19() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__19;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:10:7: ( '\\\\end{' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:10:9: '\\\\end{'
            {
            	Match("\\end{"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:11:7: ( '=' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:11:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__20"

    // $ANTLR start "TIKZEDT_CMD_COMMENT"
    public void mTIKZEDT_CMD_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TIKZEDT_CMD_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:112:5: ( '%' ( WS )+ TIKZEDT (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:112:9: '%' ( WS )+ TIKZEDT (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
            {
            	Match('%'); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:112:13: ( WS )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == '\t' || LA1_0 == ' ') )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:112:13: WS
            			    {
            			    	mWS(); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	mTIKZEDT(); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:112:27: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '\u0000' && LA2_0 <= '\t') || (LA2_0 >= '\u000B' && LA2_0 <= '\f') || (LA2_0 >= '\u000E' && LA2_0 <= '\uFFFF')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:112:27: ~ ( '\\n' | '\\r' )
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
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:112:41: ( '\\r' )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == '\r') )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:112:41: '\\r'
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

    // $ANTLR start "SOMETHING_IN_BRACKETS"
    public void mSOMETHING_IN_BRACKETS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SOMETHING_IN_BRACKETS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:116:2: ( '[' (~ ( '[' | ']' ) )* ']' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:116:4: '[' (~ ( '[' | ']' ) )* ']'
            {
            	Match('['); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:116:8: (~ ( '[' | ']' ) )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= '\u0000' && LA4_0 <= 'Z') || LA4_0 == '\\' || (LA4_0 >= '^' && LA4_0 <= '\uFFFF')) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:116:8: ~ ( '[' | ']' )
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
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	Match(']'); 

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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:124:2: ( '{' (~ ( '{' | '}' ) )* '}' )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:124:4: '{' (~ ( '{' | '}' ) )* '}'
            {
            	Match('{'); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:124:8: (~ ( '{' | '}' ) )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= '\u0000' && LA5_0 <= 'z') || LA5_0 == '|' || (LA5_0 >= '~' && LA5_0 <= '\uFFFF')) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:124:8: ~ ( '{' | '}' )
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
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	Match('}'); 

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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:128:5: ( '%' (~ ( NEWLINE ) )* NEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:128:9: '%' (~ ( NEWLINE ) )* NEWLINE
            {
            	Match('%'); 
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:128:13: (~ ( NEWLINE ) )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= '\u0000' && LA6_0 <= '\t') || (LA6_0 >= '\u000B' && LA6_0 <= '\f') || (LA6_0 >= '\u000E' && LA6_0 <= '\uFFFF')) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:128:13: ~ ( NEWLINE )
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
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	mNEWLINE(); 
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

    // $ANTLR start "TEX_CMD"
    public void mTEX_CMD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TEX_CMD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:131:1: ( '\\\\' ID )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:131:2: '\\\\' ID
            {
            	Match('\\'); 
            	mID(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TEX_CMD"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:132:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:132:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
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

            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:132:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= '0' && LA7_0 <= '9') || (LA7_0 >= 'A' && LA7_0 <= 'Z') || LA7_0 == '_' || (LA7_0 >= 'a' && LA7_0 <= 'z')) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:
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
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:135:5: ( ( '0' .. '9' )+ )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:135:7: ( '0' .. '9' )+
            {
            	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:135:7: ( '0' .. '9' )+
            	int cnt8 = 0;
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( ((LA8_0 >= '0' && LA8_0 <= '9')) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:135:7: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt8 >= 1 ) goto loop8;
            		            EarlyExitException eee8 =
            		                new EarlyExitException(8, input);
            		            throw eee8;
            	    }
            	    cnt8++;
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:139:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( ((LA12_0 >= '0' && LA12_0 <= '9')) )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == '.') )
            {
                alt12 = 2;
            }
            else 
            {
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:139:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:139:9: ( '0' .. '9' )+
                    	int cnt9 = 0;
                    	do 
                    	{
                    	    int alt9 = 2;
                    	    int LA9_0 = input.LA(1);

                    	    if ( ((LA9_0 >= '0' && LA9_0 <= '9')) )
                    	    {
                    	        alt9 = 1;
                    	    }


                    	    switch (alt9) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:139:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt9 >= 1 ) goto loop9;
                    		            EarlyExitException eee9 =
                    		                new EarlyExitException(9, input);
                    		            throw eee9;
                    	    }
                    	    cnt9++;
                    	} while (true);

                    	loop9:
                    		;	// Stops C# compiler whining that label 'loop9' has no statements

                    	Match('.'); 
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:139:25: ( '0' .. '9' )*
                    	do 
                    	{
                    	    int alt10 = 2;
                    	    int LA10_0 = input.LA(1);

                    	    if ( ((LA10_0 >= '0' && LA10_0 <= '9')) )
                    	    {
                    	        alt10 = 1;
                    	    }


                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:139:26: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop10;
                    	    }
                    	} while (true);

                    	loop10:
                    		;	// Stops C# compiler whining that label 'loop10' has no statements


                    }
                    break;
                case 2 :
                    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:140:9: '.' ( '0' .. '9' )+
                    {
                    	Match('.'); 
                    	// C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:140:13: ( '0' .. '9' )+
                    	int cnt11 = 0;
                    	do 
                    	{
                    	    int alt11 = 2;
                    	    int LA11_0 = input.LA(1);

                    	    if ( ((LA11_0 >= '0' && LA11_0 <= '9')) )
                    	    {
                    	        alt11 = 1;
                    	    }


                    	    switch (alt11) 
                    		{
                    			case 1 :
                    			    // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:140:14: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt11 >= 1 ) goto loop11;
                    		            EarlyExitException eee11 =
                    		                new EarlyExitException(11, input);
                    		            throw eee11;
                    	    }
                    	    cnt11++;
                    	} while (true);

                    	loop11:
                    		;	// Stops C# compiler whining that label 'loop11' has no statements


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

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:145:9: ( ( '\\r' | '\\n' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:145:11: ( '\\r' | '\\n' )
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

    // $ANTLR start "DOUBLENEWLINE"
    public void mDOUBLENEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOUBLENEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:150:14: ( NEWLINE NEWLINE )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:150:16: NEWLINE NEWLINE
            {
            	mNEWLINE(); 
            	mNEWLINE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOUBLENEWLINE"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:152:5: ( ( ' ' | '\\t' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:152:9: ( ' ' | '\\t' )
            {
            	if ( input.LA(1) == '\t' || input.LA(1) == ' ' ) 
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
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:159:11: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:159:13: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
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
        // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:8: ( TIKZEDT | T__17 | T__18 | T__19 | T__20 | TIKZEDT_CMD_COMMENT | SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | COMMENT | TEX_CMD | ID | INT | FLOAT | NEWLINE | DOUBLENEWLINE | WS )
        int alt13 = 16;
        alt13 = dfa13.Predict(input);
        switch (alt13) 
        {
            case 1 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:10: TIKZEDT
                {
                	mTIKZEDT(); 

                }
                break;
            case 2 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:18: T__17
                {
                	mT__17(); 

                }
                break;
            case 3 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:24: T__18
                {
                	mT__18(); 

                }
                break;
            case 4 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:30: T__19
                {
                	mT__19(); 

                }
                break;
            case 5 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:36: T__20
                {
                	mT__20(); 

                }
                break;
            case 6 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:42: TIKZEDT_CMD_COMMENT
                {
                	mTIKZEDT_CMD_COMMENT(); 

                }
                break;
            case 7 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:62: SOMETHING_IN_BRACKETS
                {
                	mSOMETHING_IN_BRACKETS(); 

                }
                break;
            case 8 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:84: SOMETHING_IN_CURLY_BRACKETS
                {
                	mSOMETHING_IN_CURLY_BRACKETS(); 

                }
                break;
            case 9 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:112: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 10 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:120: TEX_CMD
                {
                	mTEX_CMD(); 

                }
                break;
            case 11 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:128: ID
                {
                	mID(); 

                }
                break;
            case 12 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:131: INT
                {
                	mINT(); 

                }
                break;
            case 13 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:135: FLOAT
                {
                	mFLOAT(); 

                }
                break;
            case 14 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:141: NEWLINE
                {
                	mNEWLINE(); 

                }
                break;
            case 15 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:149: DOUBLENEWLINE
                {
                	mDOUBLENEWLINE(); 

                }
                break;
            case 16 :
                // C:\\Eigene Dateien\\Eigene Programme\\C#\\tikzedt\\TikzEdt\\latex.g:1:163: WS
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
        "\x09\uffff\x01\x12\x01\uffff\x01\x13\x01\uffff\x02\x0f\x06\uffff"+
        "\x02\x0f\x01\uffff\x02\x0f\x01\uffff\x01\x0f\x02\uffff\x01\x0f\x06"+
        "\uffff\x01\x11\x03\uffff";
    const string DFA13_eofS =
        "\x29\uffff";
    const string DFA13_minS =
        "\x01\x09\x01\uffff\x01\x41\x02\uffff\x01\x00\x03\uffff\x01\x2e"+
        "\x01\uffff\x01\x0a\x01\uffff\x01\x65\x01\x6e\x01\uffff\x01\x00\x04"+
        "\uffff\x01\x67\x01\x64\x01\x00\x01\x69\x01\x7b\x01\x00\x01\x6e\x01"+
        "\uffff\x01\x00\x01\x7b\x01\x00\x01\uffff\x04\x00\x01\x0a\x01\x00"+
        "\x02\uffff";
    const string DFA13_maxS =
        "\x01\x7d\x01\uffff\x01\x7a\x02\uffff\x01\uffff\x03\uffff\x01\x39"+
        "\x01\uffff\x01\x0d\x01\uffff\x01\x65\x01\x6e\x01\uffff\x01\uffff"+
        "\x04\uffff\x01\x67\x01\x64\x01\uffff\x01\x69\x01\x7b\x01\uffff\x01"+
        "\x6e\x01\uffff\x01\uffff\x01\x7b\x01\uffff\x01\uffff\x04\uffff\x01"+
        "\x0a\x01\uffff\x02\uffff";
    const string DFA13_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x05\x01\uffff\x01\x07"+
        "\x01\x08\x01\x0b\x01\uffff\x01\x0d\x01\uffff\x01\x10\x02\uffff\x01"+
        "\x0a\x01\uffff\x01\x09\x01\x0c\x01\x0e\x01\x0f\x07\uffff\x01\x04"+
        "\x03\uffff\x01\x02\x06\uffff\x02\x06";
    const string DFA13_specialS =
        "\x05\uffff\x01\x08\x0a\uffff\x01\x0a\x06\uffff\x01\x02\x02\uffff"+
        "\x01\x01\x02\uffff\x01\x04\x01\uffff\x01\x03\x01\uffff\x01\x06\x01"+
        "\x05\x01\x07\x01\x00\x01\uffff\x01\x09\x02\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x01\x0c\x01\x0b\x02\uffff\x01\x0b\x12\uffff\x01\x0c\x01\x01"+
            "\x03\uffff\x01\x05\x08\uffff\x01\x0a\x01\uffff\x0a\x09\x03\uffff"+
            "\x01\x04\x03\uffff\x1a\x08\x01\x06\x01\x02\x02\uffff\x01\x08"+
            "\x01\uffff\x1a\x08\x01\x07\x01\uffff\x01\x03",
            "",
            "\x1a\x0f\x04\uffff\x01\x0f\x01\uffff\x01\x0f\x01\x0d\x02\x0f"+
            "\x01\x0e\x15\x0f",
            "",
            "",
            "\x09\x11\x01\x10\x16\x11\x01\x10\uffdf\x11",
            "",
            "",
            "",
            "\x01\x0a\x01\uffff\x0a\x09",
            "",
            "\x01\x14\x02\uffff\x01\x14",
            "",
            "\x01\x15",
            "\x01\x16",
            "",
            "\x09\x11\x01\x10\x16\x11\x01\x10\x01\x17\uffde\x11",
            "",
            "",
            "",
            "",
            "\x01\x18",
            "\x01\x19",
            "\x54\x11\x01\x1a\uffab\x11",
            "\x01\x1b",
            "\x01\x1c",
            "\x49\x11\x01\x1d\uffb6\x11",
            "\x01\x1e",
            "",
            "\x4b\x11\x01\x1f\uffb4\x11",
            "\x01\x20",
            "\x5a\x11\x01\x21\uffa5\x11",
            "",
            "\x45\x11\x01\x22\uffba\x11",
            "\x44\x11\x01\x23\uffbb\x11",
            "\x54\x11\x01\x24\uffab\x11",
            "\x0a\x26\x01\x27\x02\x26\x01\x25\ufff2\x26",
            "\x01\x28",
            "\x0a\x26\x01\x27\x02\x26\x01\x25\ufff2\x26",
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
            get { return "1:1: Tokens : ( TIKZEDT | T__17 | T__18 | T__19 | T__20 | TIKZEDT_CMD_COMMENT | SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | COMMENT | TEX_CMD | ID | INT | FLOAT | NEWLINE | DOUBLENEWLINE | WS );"; }
        }

    }


    protected internal int DFA13_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA13_36 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_36 == '\r') ) { s = 37; }

                   	else if ( ((LA13_36 >= '\u0000' && LA13_36 <= '\t') || (LA13_36 >= '\u000B' && LA13_36 <= '\f') || (LA13_36 >= '\u000E' && LA13_36 <= '\uFFFF')) ) { s = 38; }

                   	else if ( (LA13_36 == '\n') ) { s = 39; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA13_26 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_26 == 'I') ) { s = 29; }

                   	else if ( ((LA13_26 >= '\u0000' && LA13_26 <= 'H') || (LA13_26 >= 'J' && LA13_26 <= '\uFFFF')) ) { s = 17; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA13_23 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_23 == 'T') ) { s = 26; }

                   	else if ( ((LA13_23 >= '\u0000' && LA13_23 <= 'S') || (LA13_23 >= 'U' && LA13_23 <= '\uFFFF')) ) { s = 17; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA13_31 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_31 == 'Z') ) { s = 33; }

                   	else if ( ((LA13_31 >= '\u0000' && LA13_31 <= 'Y') || (LA13_31 >= '[' && LA13_31 <= '\uFFFF')) ) { s = 17; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA13_29 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_29 == 'K') ) { s = 31; }

                   	else if ( ((LA13_29 >= '\u0000' && LA13_29 <= 'J') || (LA13_29 >= 'L' && LA13_29 <= '\uFFFF')) ) { s = 17; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA13_34 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_34 == 'D') ) { s = 35; }

                   	else if ( ((LA13_34 >= '\u0000' && LA13_34 <= 'C') || (LA13_34 >= 'E' && LA13_34 <= '\uFFFF')) ) { s = 17; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA13_33 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_33 == 'E') ) { s = 34; }

                   	else if ( ((LA13_33 >= '\u0000' && LA13_33 <= 'D') || (LA13_33 >= 'F' && LA13_33 <= '\uFFFF')) ) { s = 17; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA13_35 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_35 == 'T') ) { s = 36; }

                   	else if ( ((LA13_35 >= '\u0000' && LA13_35 <= 'S') || (LA13_35 >= 'U' && LA13_35 <= '\uFFFF')) ) { s = 17; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA13_5 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_5 == '\t' || LA13_5 == ' ') ) { s = 16; }

                   	else if ( ((LA13_5 >= '\u0000' && LA13_5 <= '\b') || (LA13_5 >= '\n' && LA13_5 <= '\u001F') || (LA13_5 >= '!' && LA13_5 <= '\uFFFF')) ) { s = 17; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA13_38 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_38 == '\r') ) { s = 37; }

                   	else if ( (LA13_38 == '\n') ) { s = 39; }

                   	else if ( ((LA13_38 >= '\u0000' && LA13_38 <= '\t') || (LA13_38 >= '\u000B' && LA13_38 <= '\f') || (LA13_38 >= '\u000E' && LA13_38 <= '\uFFFF')) ) { s = 38; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA13_16 = input.LA(1);

                   	s = -1;
                   	if ( (LA13_16 == '!') ) { s = 23; }

                   	else if ( (LA13_16 == '\t' || LA13_16 == ' ') ) { s = 16; }

                   	else if ( ((LA13_16 >= '\u0000' && LA13_16 <= '\b') || (LA13_16 >= '\n' && LA13_16 <= '\u001F') || (LA13_16 >= '\"' && LA13_16 <= '\uFFFF')) ) { s = 17; }

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae13 =
            new NoViableAltException(dfa.Description, 13, _s, input);
        dfa.Error(nvae13);
        throw nvae13;
    }
 
    
}
