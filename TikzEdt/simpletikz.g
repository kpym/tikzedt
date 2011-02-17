grammar simpletikz;

options 
{
	output=AST;
	language = 'CSharp2';
	//backtrack=true;
}


tokens {
	//BEGIN	 	= '\\begin';	//todooooo
	//END 		= '\\end';    //todooooo
	//BEGINTP	 	= '\\begin{tikzpicture}';
	//ENDTP 		= '\\end{tikzpicture}';
	//BEGINSCOPE	= '\\begin{scope}';
	//ENDSCOPE 	= '\\end{scope}';
	//TIKZPICTURE	= 'tikzpicture';	
	//SCOPE		= 'scope';
	
	//USETIKZLIB	= '\\usetikzlibrary';
	//TIKZSTYLE	= '\\tikzstyle';
	//TIKZSET		= '\\tikzset';
	//NODE		= '\\node';
	//COORDINATE	= '\\coordinate';
	//DRAW		= '\\draw';
	//PATH		= '\\path';
	//FILL		= '\\fill';
	//CLIP		= '\\clip';
	//STYLETAG	= '/.style';
	//LPAR		= '(';
	//RPAR		= ')';
	//LBR		= '[';
	//RBR		= ']';
	//LBRR		= '{';
	//RBRR		= '}';
	//KOMMA		= ',';
	//SCALE		= 'scale';
	//EQU		= '=';
	//SEMIC		= ';';
	//COLON		= ':';
	//BACKSLASH	= '\\'; // blame antlr
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
IM_SIZE;
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
IM_STYLE;
IM_CONTROLS;	
IM_TIKZEDT_CMD;
IM_DONTCARE;
IM_ARC;
}

@parser::members {

  //@Override
  protected override object RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow)
    {
        throw new MismatchedTokenException(ttype, input);
    }

  //@Override
  public override Object RecoverFromMismatchedSet(IIntStream input, RecognitionException e, BitSet follow) {
    throw e;
  }

}

@rulecatch {
    catch (RecognitionException e) {
        throw e;
    }
}

@lexer::members {
    //@Override
    public override void ReportError(RecognitionException e) {
    	//if there is no Node we forward what the parser was looking for.
        if(e.Node == null)    
	    e.Node = ExpectedToken;
        throw e;
    }
    
    //Here we store what the parser is looking for next.
    //It it does not succeed, we can use this variable to tell the user what
    //the parser was looking for.
    string ExpectedToken;
    //@Override
    public override void Match(string s)
    {
        ExpectedToken = s;
        base.Match(s);
    }
}    
  
/* comment out above for java*/


tikzdocument
	:	(dontcare_preamble | tikz_styleorsetorcmd | otherbegin)*  tikzpicture .*	-> ^(IM_DOCUMENT tikz_styleorsetorcmd* tikzpicture)
	;

tikzdocument_wo_tikzpicture
	:	(dontcare_preamble | tikz_styleorsetorcmd | otherbegin)*  EOF	-> ^(IM_DOCUMENT tikz_styleorsetorcmd*)
	;
	
tikz_cmd_comment
	:	TIKZEDT_CMD_COMMENT  	 -> ^(IM_TIKZEDT_CMD TIKZEDT_CMD_COMMENT)
	;

tikz_styleorsetorcmd
	:	tikz_style | tikz_set | tikz_cmd_comment
	;

dontcare_preamble
	:	~('\\begin' | '\\tikzstyle' | '\\tikzset' | TIKZEDT_CMD_COMMENT)
	;
otherbegin
	:	'\\begin' '{' idd2 '}'	// todo: sufficient to have ID???
	;

tikz_style
	:	'\\tikzstyle' '{' idd '}' ('=' | '+=') tikz_options -> ^(IM_STYLE idd tikz_options)
	;

tikz_options
	: 	squarebr_start (option (',' option)* ','?)? squarebr_end		-> ^(IM_OPTIONS squarebr_start option* squarebr_end)
	;

option
	:	option_style 		
		| option_kv		
	;
	
option_kv
	:	idd ('=' iddornumberunitorstringorrange )? -> ^(IM_OPTION_KV idd iddornumberunitorstringorrange?)  
	;
	
tikzstring
	:	'{' no_rlbrace* (tikzstring no_rlbrace*)* '}' -> ^(IM_STRING '{' '}' ) //todo
	;

no_rlbrace
	:	~('{' | '}')
	;
iddornumberunitorstringorrange
	:	 range | numberunit | bracedcoord | idd | tikzstring  // changed here (numberunit)=>
		;
bracedcoord
	:	'{'!  coord '}'!
	;
range
	: numberunit ':' numberunit	->	^(IM_STRING numberunit ':' numberunit )
	;	
option_style
	:	idd ('/.style' | ('/.append' 'style')) '=' '{' (option_kv (',' option_kv)*)?  ','? '}'  -> ^(IM_OPTION_STYLE idd option_kv*)  // '{' option '}' todo: optional ,
	;


	
// id composed of more than one word
//edgeop contains all those word. => use edgeop here, too
//also possible with number, e.g. level 2
//idd
//	:	edgeop (edgeop)*	-> ^(IM_ID edgeop*)
//	|	edgeop INT		-> ^(IM_ID edgeop INT)
//	;
idd
	:	idd_heavenknowswhythisisnecessary  -> ^(IM_ID )
	;
idd_heavenknowswhythisisnecessary
 	:	 ~( '(' | ')' | '[' |	']' | '{' | '}' | ',' | '='	| ';'	| ':' | '/.style' | '/.append' )+ ;
idd2
	:	ID+ -> ^(IM_ID )
	;

numberunitorvariable
	:	numberunit
	|	COMMAND	//numberunit can often also be a variable which looks just like a command!
	;
	
numberunit
	:	number unit? -> ^(IM_NUMBERUNIT number unit?) /// check       
	;
	
//float exponent interfers with units starting with 'e'
number
	:	(FLOAT_WO_EXP | INT)
	;	
	
unit
	:	 'cm' | 'in' | 'ex' | 'mm' | 'pt' | 'em'
	;
			
tikz_set
	:	 tikz_set_start (option (',' option)* ','?)? roundbr_end -> ^(IM_TIKZSET tikz_set_start option* roundbr_end)
	;

// *** Things that go within the picture ****

tikzpicture 
	:	 tikzpicture_start tikz_options? tikzbody? tikzpicture_end		-> ^(IM_PICTURE tikzpicture_start tikz_options? tikzbody? tikzpicture_end)
	;

tikzbody
	:	( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin! | otherend! | dontcare_body_nobr! )  // necessary to prevent conflict with options
		( tikzscope | tikzpath | tikznode_ext | tikzmatrix_ext | tikzcoordinate_ext | tikz_set | tikz_style | otherbegin! | otherend! | dontcare_body! )*
	;
	
dontcare_body_nobr
	:	(~ ('\\begin' | '\\end' | '\\node' | '\\matrix' | '\\coordinate' | '\\draw' | '\\path' | '\\fill' | '\\clip' | '\\tikzstyle' | '\\tikzset' | '['))	// necessary to prevent conflict with options
	;	
dontcare_body
	:	(~ ('\\begin' | '\\end' | '\\node' | '\\matrix' | '\\coordinate' | '\\draw' | '\\path' | '\\fill' | '\\clip' | '\\tikzstyle' | '\\tikzset' ))   
	;
otherend
	:	'\\end' '{' idd2 '}'
	;
	
	
// circle and ellipse seem to be the same command

	
//tikzpathi, e.g. (6,2) node[ext] {ddd} -- (6,0) node[ext] {ddd} -> (5,5) circle (3);
//tikzpathi
//	: coordornode_new (edgeop! coordornode_new)*
//	;
//this construct does not work. why?
//	 coordornode (coordornode | tikz_options? edgeop! coordornode )* 
		
tikzscope
	:	tikzscope_start tikz_options? tikzbody? tikzscope_end		-> ^(IM_SCOPE tikzscope_start tikz_options? tikzbody tikzscope_end)
	;

//for "circle" we need size instead of a coordinate
//coordornode
//	:	coord | size | tikznode
//	;
	
	
//coordinates can look like this: (6,2) node[ext] {ddd}
//coordinates are connect e.g. by --, ->, rectangle, circle
//after "circle" the next coordinate is usually just a size.
//coordornode_new
//	:	coord (ID (nodetype)? (tikzstring)?)?		-> ^(coord)
//	|	size
//	;
	




//tikznodee
//	:	node_start tikznode tikzpathi? semicolon_end -> ^(IM_PATH node_start tikznode tikzpathi? semicolon_end) //almost hack like this
//	;
	
// ****** The path commands ********
tikzpath 
	:	path_start tikzpath_element* semicolon_end	-> ^(IM_PATH path_start tikzpath_element* semicolon_end )
	|	path_start 'let' let_assignment* 'in' (COMMAND tikzstring)? tikzpath_element* semicolon_end	-> ^(IM_PATH path_start tikzpath_element* semicolon_end )

	;
	
let_assignment
	:	COMMAND '=' tikzpath_element*
	;

tikzpath_element
	: tikzpath_element_single ','?
	;
	
tikzpath_element_single
	:
		  tikz_options 
		| coord
		| controls
		| tikznode_int
		| tikzcoordinate_int
		| circle!
		| arc
		| roundbr_start tikzpath_element* roundbr_end -> ^(IM_PATH roundbr_start tikzpath_element* roundbr_end)
		|	 '(' tikzpath_element* ')' -> ^(IM_PATH '(' tikzpath_element* ')')
		| edgeop!
	;
	
controls		// for bezier path, e.g.,  .. (1,1) and (2,2) ..
	:	controls_start coord ('and' coord)? controls_end -> ^(IM_CONTROLS controls_start coord+ controls_end)
	;	
	
tikznode_ext
	:	node_start tikznode_core tikzpath_element* semicolon_end	-> ^(IM_PATH node_start tikznode_core tikzpath_element* semicolon_end)
	;
	
tikzmatrix_ext
	:	matrix_start tikznode_core tikzpath_element* semicolon_end	-> ^(IM_PATH matrix_start tikznode_core tikzpath_element* semicolon_end)
	;
	
// the coordinate business is a hack
tikzcoordinate_ext
	:	coordinate_start //{greedy=false} tikznode_decorator* {greedy=true}
				( ((tikzcoordinate_core3)=> tikzcoordinate_core3)
	 			   | ((tikzcoordinate_core2)=> tikzcoordinate_core2) 
	 			   | ((tikzcoordinate_core1)=> tikzcoordinate_core1) )?
				 tikzpath_element* semicolon_end	
				 -> ^(IM_PATH coordinate_start  
				 tikzcoordinate_core3?
				 tikzcoordinate_core2?
				 tikzcoordinate_core1?
				 tikzpath_element* semicolon_end)
	;
tikzcoordinate_int
	:	'coordinate'! ( ((tikzcoordinate_core3)=> tikzcoordinate_core3)
	 			   | ((tikzcoordinate_core2)=> tikzcoordinate_core2) 
	 			   | ((tikzcoordinate_core1)=> tikzcoordinate_core1) )?  //-> ^(IM_NODE tikznode_decorator*)
	;
tikznode_int
	:	'node'! tikznode_core
	;
tikznode_core
	:	tikznode_decorator* tikzstring		-> ^(IM_NODE tikznode_decorator* tikzstring)
	;
// this is a total hack to circumvent non LL* structure
tikzcoordinate_core3
	:	  tikznode_decorator tikznode_decorator tikznode_decorator		-> ^(IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator)
		//| tikznode_decorator tikznode_decorator 					-> ^(IM_NODE tikznode_decorator tikznode_decorator)
		//| tikznode_decorator							-> ^(IM_NODE tikznode_decorator )
	;
tikzcoordinate_core2
	:	 // tikznode_decorator tikznode_decorator tikznode_decorator		-> ^(IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator)
		 tikznode_decorator tikznode_decorator 					-> ^(IM_NODE tikznode_decorator tikznode_decorator)
		//| tikznode_decorator							-> ^(IM_NODE tikznode_decorator )
	;
tikzcoordinate_core1
	:	 // tikznode_decorator tikznode_decorator tikznode_decorator		-> ^(IM_NODE tikznode_decorator tikznode_decorator tikznode_decorator)
		 tikznode_decorator  							-> ^(IM_NODE tikznode_decorator )
		//| tikznode_decorator							-> ^(IM_NODE tikznode_decorator )
	;
	
//tikznode
//	:	nodename? ('at' coord)? tikz_options* 			
//	;
tikznode_decorator
	:	  nodename 
		| 'at'! coord
		| tikz_options_dontcare
	;
tikz_options_dontcare
	:	'[' no_rlbracket* (tikz_options_dontcare no_rlbracket*)* ']' -> ^(IM_OPTIONS ) //todo
	;
no_rlbracket
	:	~('[' | ']')
	;
nodename
	:	'(' idd ')'		-> ^(IM_NODENAME idd)
	;

// note that tikz is ambiguous. for example "3 and 4" is a valid node name, and furthermore the size is optional
// hence \draw (1,1) ellipse (1 and 3) -- (0,0); could mean to things....
// that is the reason we need the syntactic predicate to shut off the warning
circle
	:	('circle' | 'ellipse') ((size)=> size)?	->	// note: options not allowed in between
	;
arc
	:	'arc' ('(' numberunitorvariable ':' numberunitorvariable ':' numberunitorvariable ('and' numberunit)? ')')? -> ^(IM_ARC numberunitorvariable+)
	;
	
size
	:	  '(' numberunit ('and' numberunit)? ')'		-> ^(IM_SIZE numberunit*)	// for future use
	;
//Is this needed?
//-> ^(IM_COORD[$lc] coord_modifier? numberunit)
	

//note: the last option is for complex coordinates which TE cannot parse/understand
coord	
	:	  nodename 								-> ^(IM_COORD nodename)
		| ( coord_modifier? '(' numberunit coord_sep numberunit ')')		-> ^(IM_COORD coord_modifier? numberunit+ coord_sep)
		| ( coord_modifier? '(' coord_part coord_sep coord_part ')')		-> ^(IM_COORD coord_modifier? coord_part+ coord_sep)
	;
//note: idd includes numberunit
//note: '{' idd '}' is for some calculatation, like in  (\x,{5.5 - 1.5 * \x})
coord_part
	:	idd		-> ^(IM_DONTCARE idd )
	|	'{' idd '}'	-> ^(IM_DONTCARE '{' idd '}')
	;
coord_sep
	:	( ',' | ':' )	
	;

//these operators depend on used packets. => all all strings.	
edgeop	
	:	'--' | '->' | '|-' | '-|' | ID
	;	
//	:	'--' | 'edge' | '->' | '|-' | '-|' | 'to' | 'grid' | 'rectangle'

coord_modifier
	:	'+' | '++'
	;
	
/*


path_end
	:	';' -> ^(IM_ENDTAG ';')
	;



//tikz_something
//	:	( ID | '\\' ID)+  -> 
//	;



//documentclass
//	:	'\\documentclass' ('[' (~ ']')* ']')? '{' (~'}')*  '}'
//	;


	
usetikzlib
	:	usetikzlib_start idd (',' idd)* roundbr_end -> ^(IM_USETIKZLIB usetikzlib_start idd* roundbr_end)
	;
usetikzlib_start
	:	'\\usetikzlibrary' '{' -> ^(IM_STARTTAG '\\usetikzlibrary') // todo: check if necessary ...
	;



tikzstring
	:	'{'  (tikzstring | MATHSTRING | ID)* '}' -> ^(IM_STRING '{' '}' ) //todo
	;
*/
//tikzbody2
//	:	'hallo'
//	;

// ***** start and end tags *****
squarebr_start
	:	'[' -> ^(IM_STARTTAG '[')
	;
squarebr_end
	:	']' -> ^(IM_ENDTAG ']')
	;	
semicolon_end
	:	';'	-> ^(IM_ENDTAG ';')
	;
roundbr_start
	:	'{'	-> ^(IM_STARTTAG '{')
	;
roundbr_end
	:	'}'	-> ^(IM_ENDTAG '}')
	;
controls_start
	:	'..' 'controls'	-> ^(IM_STARTTAG '..')
	;
controls_end
	:	'..' -> ^(IM_ENDTAG '..')
	;
tikz_set_start
	:	'\\tikzset' '{'		-> ^(IM_STARTTAG ) // todo: check if suffices
	;
tikzpicture_start
	:	'\\begin' '{' 'tikzpicture' '}' -> ^(IM_STARTTAG '\\begin')
	;
tikzpicture_end
	:	'\\end' '{' 'tikzpicture' '}' -> ^(IM_ENDTAG '\\end')
	;
tikzscope_start
	:	'\\begin' '{' 'scope' '}' -> ^(IM_STARTTAG '\\begin')
	;
tikzscope_end
	:	'\\end' '{' 'scope' '}' -> ^(IM_ENDTAG '\\end')
	;
path_start 
	:	path_start_tag -> ^(IM_STARTTAG path_start_tag)
	;
node_start
	:	node_start_tag -> ^(IM_STARTTAG node_start_tag)
	;
matrix_start
	:	matrix_start_tag -> ^(IM_STARTTAG matrix_start_tag)
	;
node_start_tag
	:	'\\node'
	;
matrix_start_tag
	:	'\\matrix'
	;
coordinate_start
	:	'\\coordinate' -> ^(IM_STARTTAG '\\coordinate')
	;
path_start_tag
	:	'\\draw' | '\\fill' | '\\path' | '\\clip'
	;

ID  :	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_'|'.'|'!')*
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
    
TIKZEDT_CMD_COMMENT
    :   '%' WS '!TIKZEDT'   ~('\n'|'\r')* '\r'? '\n'
    ;

COMMENT
    :   '%' ~('\n'|'\r')* '\r'? '\n' {$channel=HIDDEN;}
    |   '%/*' ( options {greedy=false;} : . )* '%*/' ~('\n'|'\r')* '\r'? '\n' {$channel=HIDDEN;} // allows to ignore some parts of a file with which the parser might have problems
    ;

WS  :   ( ' '
        | '\t'
        | '\r'
        | '\n'
        ) {$channel=HIDDEN;}
    ;

fragment EXPONENT : ('e'|'E') ('+'|'-')? ('0'..'9')+ ;


//OPTIONS :	'[' ~(']')* ']';

//STRING	:	'{' ( ESC_SEQ | ~('\\' | '}') )* '}';   /// not correct like this
MATHSTRING 
	:	'$' ( ESC_SEQ | ~('\\' | '$') )* '$';
//STRING
//    :  '"' ( ESC_SEQ | ~('\\'|'"') )* '"'
//    ;

//CHAR:  '\'' ( ESC_SEQ | ~('\''|'\\') ) '\''
//    ;



COMMAND
	: '\\' ID
	;
	
//fragment // this is a hack	
ESC_SEQ
    :   '\\' .   // ( |'\"'|'\''|'\\')
    ;



SOMETHING 
	:	. ;