# Why modes #

The following problems/use cases occured:
  1. The user enters some text and wants to see a preview. (even for an unsaved file)
  1. The user has a huge file and slow machine, or some other problem, so that the parser is too slow or doesn't work. (But still wants to edit the file and see the preview.)
  1. We want to automatically generate the preview, even for unsaved file, but we do not want to autosave the file. (The user might change something and exit w/o saving...)
  1. The user might need the final compiled pdf. It should be viewable in TikzEdt, but it should not be automatically overwritten. (The user might enter the program, change something, exit without pressing save or compile and should find his pdf file untouched.)
  1. The user might use include files etc., hence the preview files should be compiled in the source-file's directory to get relative paths right.

The (currently best) solution is to use three different modes of operation as follows.

# Fancy Modes #
  * Everything is enabled (parser, overlay, automatic compilation)
  * Preview file is stored in filename.temp\_preview.tex
  * rectangle for bounding box is inserted into code

# Standard Mode #
  * parser & overlay disabled
  * nothing is inserted into the code
  * Preview file is stored in filename.temp\_preview.tex
  * previews are automatically generated

# Production mode #
  * parser & overlay disabled
  * nothing is inserted into the code
  * the real output file (filename.pdf) is displayed, no separate preview file is generated.
  * The preview is not automatically updated. The user must manually hit the compile button or F5.
