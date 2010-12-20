grammar tikzedt;

/*
This tikzedt grammar only parses and processes only the for TikzEdt TEX commands.
However, it allows any other commands (and comments) anywhere in between.

Processes commands are
% !TIKZEDT 	- (Cmd, Setting) for controlling behaviour of TikzEdt for this document
\input		- (Filename) recursive search
\usepackage	- (completeString) for precompilation
\usetikzlibrary - (completeString) for precompilation
\documentclass	- (completeString) is standalone document?
\tikzstyle	- (Name) provide names of style for autocompletion
\begin{tikzpicture}	- (completeString) warn user if there is not exactly 1
+ following [options]	- (ScaleFactor, StyleNames) ScaleFactor for Overlay, StyleNames for autocompletion
\node		- (Coord, Name, Option, Label) these nodes are shown on PDFOverlay
\draw, \path	- (completeString) explicit included nodes are ignored here. warn user that they should be referenced.

*/

options 
{
	output=AST;
	language = 'CSharp2';
	//backtrack=true;
}


tokens {
	TIKZEDT		= '!TIKZEDT';
	INPUT		= '\\input';  // [...] {...}
	USEPACKAGE	= '\\usepackage'; // {...}
	USETIKZLIB	= '\\usetikzlibrary'; // {...}
	DOCUMENTCLASS	= '\\documentclass'; // [...] {...}
	TIKZSTYLES	= '\\tikzstyle'; // [...]={...}
	BEGIN		= '\\begin'; //{tikzpicture}[ OPTIONS WITH STYLES AND SCALE ]
	TIKZPICTURE	= '{tikzpicture}'; //together with begin
	NODE		= '\\node'; //[options] (name) at (COORD) {LABEL};	
					//other parameters are possible! all end with ;
	DRAW		= '\\draw'; // any parameters. end always ;
	PATH		= '\\path'; // any parameters. end always ;	
	
	
	

	STYLESEP	= '/.style';
	
IM_COMMENT;	
}

tikzdocument
	:	 (doublenewline | known_cmd | unknown_cmd)*
//	:	 (doublenewline | known_cmd | TIKZEDT_CMD_COMMENT | comment | unknown_cmd)*
	;
	
//in LaTeX a double newline breaks everything. (single linebreak within command is allowed!)

doublenewline
	:	(NEWLINE){2}  
	;
	
NEWLINE
	:	'\r'? '\n' 
	;


	
unknown_cmd
	:	~(INPUT | NEWLINE)+ NEWLINE?
	;

known_cmd
	:	INPUT SOMETHING_IN_BRACKETS? SOMETHING_IN_CURLY_BRACKETS
	;
	
SOMETHING_IN_BRACKETS
	:	'[' ~('['|']')* ']'
	;
	
SOMETHING_IN_CURLY_BRACKETS
	:	'{' ~('{'|'}')* '}'
	;
	
	
TIKZEDT_CMD_COMMENT
    :   '%' WS TIKZEDT   ~('\n'|'\r')* '\r'? '\n'
    ;
 
comment
	: COMMENT ->^(IM_COMMENT)
	;

COMMENT
    :   '%' ~('\n'|'\r')* '\r'? '\n' 
    ;
//{$channel=HIDDEN;}    
    
    
ws 	:	 WS;
    
WS  :   ( ' '
        | '\t'
        | NEWLINE
        ) //{$channel=HIDDEN;}
    ;
    


WORD  :	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.'|'!')*
    ;

INT :	'-'? '0'..'9'+
    ;

//float's exponent interfers with units starting with 'e'.
//FLOAT
//    :   '-'? ('0'..'9')+ '.' ('0'..'9')* EXPONENT?
//    |   '-'? '.' ('0'..'9')+ EXPONENT?
//    |   '-'? ('0'..'9')+ EXPONENT
//    |   '-'? '.' ('0'..'9')+
//    ;

FLOAT_WO_EXP    
    :   '-'? ('0'..'9')+ '.' ('0'..'9')* 
    |   '-'? '.' ('0'..'9')+
    ;

SOMETHING 
	:	. ;
