grammar simpletikz;

options 
{
	output=AST;
	//language = 'CSharp2';
}


tokens {
	BEGIN	 	= '\\begin';
	END 		= '\\end';
	BEGINTP	 	= '\\begin{tikzpicture}';
	ENDTP 		= '\\end{tikzpicture}';
	BEGINSCOPE	= '\\begin{scope}';
	ENDSCOPE 	= '\\end{scope}';
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
	SCALE		= 'scale';
	EQU		= '=';
	SEMIC		= ';';
	COLON		= ':';
	STYLESEP	= '/.style';
	AT		= 'at';
	LABEL		= 'label';
	EVERYLOOP	= 'every loop';
	
	// styles
	ST_INNERSEP	= 'inner sep';
	ST_OUTERSEP	= 'outer sep';
	ST_FILL		= 'fill';
	ST_DRAW		= 'draw';
	ST_SHAPE	= 'shape';
	ST_MINSIZE	= 'minimum size';
	ST_LINEWIDTH	= 'line width';
	ST_DASHSTYLE	= 'dash style';
	
	// edge option
	LOOP		= 'loop';
	IN		= 'in';
	OUT		= 'out';
	
	// units
	UN_PTS		= 'pt';
	UN_CM		= 'cm';
//	UN_IN		= 'in';

// imaginary
IM_PATH;
IM_NODE;
IM_COORD;
IM_COORDDECO;
IM_NODENAME;
IM_PICTURE;
IM_SCOPE;
}


tikzpath 
	:	path_start! tikzpathi
	;

tikzpathi
	:	OPTIONS? coordwithdeco (coordwithdeco | OPTIONS? edgeop coordwithdeco )* SEMIC 		-> ^(IM_PATH coordwithdeco+ )
	;

coordwithdeco
	:	coord tikznodei* -> ^(IM_COORDDECO coord tikznodei*)
	;
	
tikznodei
	:	'node'! tikznode
	;
tikznodee
	:	NODE tikznode tikzpathi
	;
tikznode
	:	OPTIONS? nodename? ('at' coord)? STRING		-> ^(IM_NODE nodename? 'at' coord?)			
	;
	
edgeop	
	:	'--' | 'edge' | '->' | '|-' | '-|' | 'to'
	;	

nodename
	:	lc=LPAR id=ID RPAR		-> ^(IM_NODENAME[$lc] $id)
	;

coord	
	:	  nodename 									-> ^(IM_COORD nodename)
		| ( coord_modifier? lc=LPAR numberunit KOMMA numberunit RPAR)		-> ^(IM_COORD[$lc] coord_modifier? numberunit+ )
	;

coord_modifier
	:	'+' | '++'
	;

numberunit
	:	(FLOAT|INT) unit?
	;

unit
	:	'cm' | 'in' | 'ex' | 'mm' | 'pt'
	;

path_start 
	:	DRAW | FILL | PATH
	;

tikzpicture 
	:	SOMETHING* BEGINTP OPTIONS? tikzbody ENDTP  SOMETHING*		-> ^(IM_PICTURE tikzbody)
	;

tikzbody
	:	( tikzscope | tikzpath | tikznodee)*
	;

tikzscope
	:	BEGINSCOPE OPTIONS? tikzbody ENDSCOPE		-> ^(IM_SCOPE tikzbody)
	;

//tikzbody2
//	:	'hallo'
//	;

ID  :	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*
    ;

INT :	'0'..'9'+
    ;

FLOAT
    :   ('0'..'9')+ '.' ('0'..'9')* EXPONENT?
    |   '.' ('0'..'9')+ EXPONENT?
    |   ('0'..'9')+ EXPONENT
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

OPTIONS :	'[' ~(']')* ']';

STRING	:	'{' ( ESC_SEQ | ~('\\' | '}') )* '}';   /// not correct like this

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
