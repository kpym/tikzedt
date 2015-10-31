#A structural overview and TODO list.

# Components #

## Main Window and UI ##

**Responsibilities:**
  * Manage other components
  * look good

**TODO:**

### Code editor (avalonedit) ###
**TODO:**

## TikzDisplay ##
**TODO**
  * check mupdf licensing and deploy mudraw correctly

## Rasterizer ##
**TODO**

## TikzParser ##
**TODO**

### Tikz ParseTree ###
  * really fix [issue 22](https://code.google.com/p/tikzedt/issues/detail?id=22), i.e., handle relative namedcoordinates correctly.

## PdfOverlay ##
**TODO**
  * It seems that after undo the tool states are not reset

### Snippetmanager ###
**TODO**
  * support using several snippet files, maybe with an external editor, to allow for users retaining their custom snippets and still be able to update the predefined library.

### TexCompiler ###
**TODO**

## Deployment ##
**TODO**
  * Test file associations

## Usability ##
**TODO**

### Misc ###
**TODO**
  * arc creation broken
  * start path at end of arc->NotImplementedException
  * Inport settings etc. from previous version
  * usepolarcoordinates is not quite working
  * unit tests for overlay
  * .preview.pdf not deleted, not hidden
  * bug with scope display. (screwed)
  * changing compiler requires restart... notify user or remove
  * style parsing after dynamic preamble change
  * tooltips on nodes don't seem to work any more

### Vague things ###
  * improve workflow
  * Improve documentation
  * solution for different paths
  * add more snippets

### Linux issues ###
  * mac version
  * middle button pan
  * right button deselect not always working (?or cursor not updated)
  * mac installer package???
  * code completion

### For later ###
**TODO**
  * Move snippet compilation display to VM and check abort is handled correctly
  * Allow to set resolution before exporting file.
  * outsorce (and publish) code completions as separate lib
  * pdflatex hangs sometimes (??how to reproduce??)(pdf file access problem?)
  * "add as new snippet" command
  * support multiple tikzpictures
  * support tikzpictures anywhere on page (using http://tex.stackexchange.com/questions/10343/determining-the-position-of-a-box-e-g-on-a-page)
  * better error recovery: if error on \path is detected-> just drop this path instead of stopping parsing of whole file.
  * 3d support? (=ignore it automatically)
  * check math expressions in arc are handled correctly
  * SVG import (?)