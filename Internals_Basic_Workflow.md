## How the basic rendering ##

The user has exactly two ways to modify the current document:
  1. He can edit it in the text editor.
  1. He can use the overlay and modify it with the mouse.

In either case, after the change the new document is passed to the TikzDisplay control, who saves the code in a temporary file, runs pdflatex to compile it and displays the result once (and if) latex successfully returns.

In case the user made a change using the editor, in addition the new document is passed to the Parser. The parser (class TikzParser) does the following things:
  1. It runs a second, Antlr-generated parser (SimpletikzParser) on the input file. This parser produces an abstract syntax tree (AST).
  1. The AST thus produced is subsequently translated again into a Tikz\_ParseTree, the internal representation of the document.

The Tikz\_ParseTree is then passed to the PdfOverlay Control, who is responsible for displaying the overlay (the red crosses etc...)

Note that the Tikz\_ParseTree is re-generated completely, even if the user changes just one letter. (TODO: Make the parsing asynchronous, otherwise the user will experience delays for big files or slow machines.)
Currently this works well.

In case the user modifies the current document through the overlay, the Pasetree is not updated. (Nevertheless, of course, it is compiled.)