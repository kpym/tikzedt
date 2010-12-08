grammar simpletikz;

options 
{
	output=AST;
	language = 'CSharp2';
}


tokens {
	BEGIN	 	= '\\begin';
	END 		= '\\end';
	BEGINTP	 	= '\\begin{tikzpicture}';
	ENDTP 		= '\\end{tikzpicture}';
	BEGINSCOPE	= '\\begin{scope}';
	ENDSCOPE 	= '\\end{scope}';
	USETIKZLIB	= '\\usetikzlibrary';
	NODE		= '\\node';
	DRAW		= '\\draw';
	PATH		= '\\path';
	FILL		= '\\fill';
	LPAR		= '(';
	RPAR		= ')';
	LBR		= '[';
	RBR		= ']';
	LBRR		= '{';
	RBRR		= '}';
	KOMMA		= ',';
	//SCALE		= 'scale';
	EQU		= '=';
	SEMIC		= ';';
	COLON		= ':';
	//STYLESEP	= '/.style';
	//AT		= 'at';
	//LABEL		= 'label';
	//EVERYLOOP	= 'every loop';
	
	// styles
	//ST_INNERSEP	= 'inner sep';
	//ST_OUTERSEP	= 'outer sep';
	//ST_FILL		= 'fill';
	//ST_DRAW		= 'draw';
	//ST_SHAPE	= 'shape';
	//ST_MINSIZE	= 'minimum size';
	//ST_LINEWIDTH	= 'line width';
	//ST_DASHSTYLE	= 'dash style';
	
	// edge option
	//LOOP		= 'loop';
	//IN		= 'in';
	//OUT		= 'out';
	
	// units
	//UN_PTS		= 'pt';
	//UN_CM		= 'cm';
//	UN_IN		= 'in';

// imaginary
IM_PATH;
IM_NODE;
IM_COORD;
IM_NODENAME;
IM_NUMBERUNIT;
IM_PICTURE;
IM_DOCUMENT;
IM_SCOPE;
IM_STARTTAG;
IM_ENDTAG;
IM_OPTIONS;
IM_OPTION_STYLE;
IM_OPTION_KV; 	// key or key value pair
IM_ID;
IM_TIKZSET;
IM_USETIKZLIB;
IM_STRING;
}


tikzdocument
	:	(tikz_something | usetikzlib)* tikzpicture  tikz_something*		-> ^(IM_DOCUMENT usetikzlib* tikzpicture)
	;

tikzpath 
	:	path_start tikzpathi path_end	-> ^(IM_PATH path_start tikzpathi path_end )
	;
path_end
	:	SEMIC -> ^(IM_ENDTAG SEMIC)
	;

tikzpathi
	:	 coordornode (coordornode | tikz_options? edgeop! coordornode )* 
	;

coordornode
	:	coord | tikznodei
	;
	
tikznodei
	:	'node'! tikznode
	;
tikznodee
	:	node_start tikznode tikzpathi? path_end -> ^(IM_PATH node_start tikznode tikzpathi? path_end) //almost hack like this
	;
node_start
	:	NODE -> ^(IM_STARTTAG NODE)
	;
tikznode
	:	nodename? ('at' coord)? tikzstring		-> ^(IM_NODE nodename? coord? tikzstring)			
	;
	
edgeop	
	:	'--' | 'edge' | '->' | '|-' | '-|' | 'to' | 'grid' | 'rectangle'
	;	

nodename
	:	lc=LPAR id=ID RPAR		-> ^(IM_NODENAME[$lc] $id)
	;

coord	
	:	  nodename 								-> ^(IM_COORD nodename)
		| ( coord_modifier? lc=LPAR numberunit KOMMA numberunit RPAR)		-> ^(IM_COORD[$lc] coord_modifier? numberunit+ )
	;

coord_modifier
	:	'+' | '++'
	;

numberunit
	:	number unit? -> ^(IM_NUMBERUNIT number unit?) /// check
	;
number
	:	(FLOAT | INT)
	;
unit
	:	'cm' | 'in' | 'ex' | 'mm' | 'pt'
	;

path_start 
	:	path_start_tag -> ^(IM_STARTTAG path_start_tag)
	;
path_start_tag
	:	DRAW | FILL | PATH
	;

tikzpicture 
	:	 tikzpicture_start tikz_options? tikzbody? tikzpicture_end		-> ^(IM_PICTURE tikzpicture_start tikz_options? tikzbody? tikzpicture_end)
	;
tikzpicture_start
	:	BEGINTP -> ^(IM_STARTTAG BEGINTP)
	;
tikzpicture_end
	:	ENDTP -> ^(IM_ENDTAG ENDTP)
	;
tikzbody
	:	( tikzscope | tikzpath | tikznodee | tikz_something)+
	;

tikz_something
	:	( ID | '\\' ID)+  -> 
	;

tikzscope
	:	tikzscope_start tikz_options? tikzbody tikzscope_end		-> ^(IM_SCOPE tikzscope_start tikz_options? tikzbody tikzscope_end)
	;
tikzscope_start
	:	BEGINSCOPE -> ^(IM_STARTTAG BEGINSCOPE)
	;
tikzscope_end
	:	ENDSCOPE -> ^(IM_ENDTAG ENDSCOPE)
	;

tikz_options
	: 	squarebr_start (option (',' option)*)? squarebr_end		-> ^(IM_OPTIONS squarebr_start option* squarebr_end)
	;
squarebr_start
	:	LBR -> ^(IM_STARTTAG LBR)
	;
squarebr_end
	:	RBR -> ^(IM_ENDTAG RBR)
	;	
	
tikz_set
	:	 tikz_set_start (option (',' option)*)? roundbr_end -> ^(IM_TIKZSET tikz_set_start option* roundbr_end)
	;
tikz_set_start
	:	'\\tikzset' '{'		-> ^(IM_STARTTAG ) // todo: check if suffices
	;
	
usetikzlib
	:	usetikzlib_start idd (',' idd)* roundbr_end -> ^(IM_USETIKZLIB usetikzlib_start idd* roundbr_end)
	;
usetikzlib_start
	:	USETIKZLIB '{' -> ^(IM_STARTTAG USETIKZLIB) // todo: check if necessary ...
	;
semicolon_end
	:	';'	-> ^(IM_ENDTAG ';')
	;
roundbr_end
	:	'}'	-> ^(IM_ENDTAG '}')
	;
	
option
	:	option_style 		-> ^(IM_OPTION_STYLE option_style)
		| option_kv		-> ^(IM_OPTION_KV option_kv)
	;
	
option_kv
	:	idd ('='! (idd | numberunit))?
	;
option_style
	:	idd '/.style'! '='! '{'! (option (',' option)*)?  '}'! // '{' option '}'
	;

// id composed of more than one word
idd
	:	ID (ID)*	-> ^(IM_ID ID*)
	;

tikzstring
	:	'{'  (tikzstring | MATHSTRING | ID)* '}' -> ^(IM_STRING '{' '}' ) //todo
	;

//tikzbody2
//	:	'hallo'
//	;

ID  :	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*
    ;

INT :	'-'? '0'..'9'+
    ;

FLOAT
    :   '-'? ('0'..'9')+ '.' ('0'..'9')* EXPONENT?
    |   '-'? '.' ('0'..'9')+ EXPONENT?
    |   '-'? ('0'..'9')+ EXPONENT
    ;

COMMENT
    :   '%' ~('\n'|'\r')* '\r'? '\n' {$channel=HIDDEN;}
    ;

WS  :   ( ' '
        | '\t'
        | '\r'
        | '\n'
        ) {$channel=HIDDEN;}
    ;

fragment
EXPONENT : ('e'|'E') ('+'|'-')? ('0'..'9')+ ;

//OPTIONS :	'[' ~(']')* ']';

//STRING	:	'{' ( ESC_SEQ | ~('\\' | '}') )* '}';   /// not correct like this
MATHSTRING 
	:	'$' ( ESC_SEQ | ~('\\' | '$') )* '$';
//STRING
//    :  '"' ( ESC_SEQ | ~('\\'|'"') )* '"'
//    ;

//CHAR:  '\'' ( ESC_SEQ | ~('\''|'\\') ) '\''
//    ;

fragment
ESC_SEQ
    :   '\\' .   // ( |'\"'|'\''|'\\')
    ;


SOMETHING 
	:	. ;
