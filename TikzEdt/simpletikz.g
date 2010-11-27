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
IM_NODENAME;
IM_NUMBERUNIT;
IM_PICTURE;
IM_DOCUMENT;
IM_SCOPE;
IM_STARTTAG;
IM_ENDTAG;
IM_OPTIONS;
}


tikzpath 
	:	path_start tikzpathi path_end	-> ^(IM_PATH path_start tikzpathi path_end )
	;
path_end
	:	SEMIC -> ^(IM_ENDTAG SEMIC)
	;

tikzpathi
	:	(OPTIONS!)? coordornode (coordornode | (OPTIONS!)? edgeop! coordornode )* 
	;

coordornode
	:	coord | tikznodei
	;
	
tikznodei
	:	'node'! tikznode
	;
tikznodee
	:	node_start tikznode tikzpathi path_end -> ^(IM_PATH node_start tikznode tikzpathi path_end) //almost hack like this
	;
node_start
	:	NODE -> ^(IM_STARTTAG NODE)
	;
tikznode
	:	OPTIONS? nodename? ('at' coord)? STRING		-> ^(IM_NODE OPTIONS? nodename? coord? STRING)			
	;
	
edgeop	
	:	'--' | 'edge' | '->' | '|-' | '-|' | 'to'
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

tikzdocument
	:	SOMETHING* tikzpicture  SOMETHING*		-> ^(IM_DOCUMENT tikzpicture)
	;

tikzpicture 
	:	 tikzpicture_start OPTIONS? tikzbody? tikzpicture_end		-> ^(IM_PICTURE  tikzpicture_start tikzbody? tikzpicture_end)
	;
tikzpicture_start
	:	BEGINTP -> ^(IM_STARTTAG BEGINTP)
	;
tikzpicture_end
	:	ENDTP -> ^(IM_ENDTAG ENDTP)
	;
tikzbody
	:	( tikzscope | tikzpath | tikznodee)+
	;

tikzscope
	:	BEGINSCOPE OPTIONS? tikzbody ENDSCOPE		-> ^(IM_SCOPE ^(IM_STARTTAG BEGINSCOPE) tikzbody ^(IM_ENDTAG ENDSCOPE))
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
