<h2><?=$pagetitle?></h2>

TikzEdt is a combined WYSIWYG/text editor designed for editing <a href="http://en.wikipedia.org/wiki/PGF/TikZ">Tikz</a> code. Here is how the editor looks like:
<img src ="img/instantpreview.png" style="margin-top:20px;width:600px;" alt="Screenshot"/>
<table>
  <tr>
    <td style="width:50%;">Here you can edit the Tikz code.</td>
    <td style="width:50%;">Here you see the compiled picture and may do WYSIWYG editing.</td>
  </tr>
</table>

<h4>Features:</h4>
<ul>
<li>  Syntax highlighting and code completion, based on AvalonEdit.</li>
<li>  Real time rendering, using pdflatex and mupdf.</li>
<li>  It contains a Tikz parser, built using the Antlr parser generator.</li>
<li>  Parsed coordinates are displayed as an overlay on the rendered image. The overlay can be edited with the mouse in a WYSIWYG manner. The source code is updated accordingly.</li>
<li>  It comes with a snippet library to store frequently used commands and styles, containing many pre-defined examples. </li>
<li>  Export to many common image formats.</li>
</ul>



<h4>What TikzEdt can and cannot do for you:</h4>
<ul>
  <li>It can help you draw simple Tikz diagrams quickly using WYSIWYG tools. You save time compared to writing the code by hand.</li>
  <li>You can freely switch between code writing and WYSIWYG editing. In particular, you may choose to not use the WYSIWYG features and use TikzEdt purely as a text editor with instant preview.</li>
  <li>Tikz/Pgf is a very rich language with lots of libraries. By far not all Tikz commands are available through WYSIWYG tools, and not all elements of a Tikz picture can be modified using the WYSIWYG interface alone. TikzEdt only lets you edit coordinates.
      Hence TikzEdt does not spare you from learning Tikz, although it may help you in getting started.</li>
  <li>If you are looking for a pure WYSIWYG vector graphics editor and don't care at all about Tikz/Latex, you might be better off using a program dedicated to that purpose, like Inkscape.</li>
  <li>TikzEdt is currently (regrettably) only natively available for Windows.</li>
</ul>


Please use <a href="http://code.google.com/p/tikzedt/issues/list">our google code site</a> to report bugs.

