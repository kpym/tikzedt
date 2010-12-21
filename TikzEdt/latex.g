grammar latex;

/*
This is a basic but complete latex grammar.

It just knows:

tikzedt_cmd_comment (must be a beginning of document)
tex commands (starting with \ ; ending after last [],{},= or after a double linebreak)
no commands (everything else)
and blocks (starting with \begin and ending with \end, nested blocks allowed)

In a second step these blocks can be handled individually depending on the type of block.
This is necessary because each block comes with its own syntax.

It should successfully accept any TEX file.
)
*/

options 
{
	output=AST;
	language = 'CSharp2';
	//backtrack=true;
}


tokens {
	TIKZEDT		= '!TIKZEDT';
}



tikzdocument
/*NOTE: This line throws warnings because the non-greedy options do not work.
It complains that something matching <tikzedt_cmd_comment> (first alternative)
could also match <broken_cmd> from the second alternative
(this is supposed to be like this since <broken_cmd> should eat everything that is left)*/
	:	( tikzedt_cmd_comment)*
		
			(	
				
				statement
			)*
		
		EOF
	;
	
statement
	:
	begin_end_block	
	/*begin_cmd
	|end_cmd*/
	| latex_cmd
	| doublenewline
	| newline 
	| broken_cmd 
	;
/*
begin_end_block
	:	'\\begin{' id1=ID '}' 
		(
			options { greedy=false; } :   .
		)*
		'\\end{' id2=ID '}' 
	;
*/	

begin_end_block
	:	'\\begin{' ID '}' 
		(
			options { greedy=false; } :  statement
		)*
		'\\end{' ID '}' 
	
	;


/*
begin_cmd
	:	'\\begin' (SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )*  ;

end_cmd
	:	'\\end' (SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )*  ;
*/
	
latex_cmd
	:	cmd_name (SOMETHING_IN_BRACKETS | SOMETHING_IN_CURLY_BRACKETS | '=' | NEWLINE )*  ;


cmd_name	: TEX_CMD;
	
tikzedt_cmd_comment
	:	TIKZEDT_CMD_COMMENT; /*NEWLINE already included*/
	
	
newline
	:	 NEWLINE ;
	
doublenewline
	:	 DOUBLENEWLINE;	
	
	
	
broken_cmd 
	:	~(  NEWLINE )+ NEWLINE
         ;



TIKZEDT_CMD_COMMENT
    :   '%' WS+ TIKZEDT   ~('\n'|'\r')* '\r'? '\n'
    ;
    
SOMETHING_IN_BRACKETS
	:	'[' ~('['|']')* ']'
	;
/*
nodetype
	:	'[' ~('[' | ']')* (nodetype ~('[' | ']')*)* ']'
	;*/
	
SOMETHING_IN_CURLY_BRACKETS
	:	'{' ~('{'|'}')* '}'
	;

COMMENT
    :   '%' ~(NEWLINE)* NEWLINE {$channel=HIDDEN;}
    ;
TEX_CMD
:'\\'ID;
ID  :	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*
    ;

INT :	'0'..'9'+
    ;

FLOAT
    :   ('0'..'9')+ '.' ('0'..'9')*
    |   '.' ('0'..'9')+
    ;


//single newline can occur anywhere
NEWLINE :	('\r'
	|	'\n'
	) 
    ;  
//double newline in latex means always separation of a command.
DOUBLENEWLINE:	NEWLINE NEWLINE;

WS  :   ( ' '
        | '\t'
        ) {$channel=HIDDEN;}
    ;


fragment
HEX_DIGIT : ('0'..'9'|'a'..'f'|'A'..'F') ;


