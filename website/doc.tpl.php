<h2><?=$pagetitle?></h2>

This is the documentation for users. The Documentation for developers can be found
<a href="http://code.google.com/p/tikzedt/w/list">here.</a>

<ul id="toc">
<li>    <a href="#tikzedt">TikzEdt</a>
<ul>
<li>
  <a href="#whatcan"> What TikzEdt can and cannot do for you</a>
</ul>
<li>
  <a href="#getstarted"> Getting started</a>
<ul>
<!-- <li>
  <a href="#firstrun">     The first run</a> -->
<li>
  <a href="#helloworld">     Hello World</a>
</ul>
<li>
  <a href="#features">  Overview of features</a>
<ul>
<li>
  <a href="#tools">     The WYSIWYG tools</a>
<li>
  <a href="#overlay">      Which Tikz objects appear in the overlay</a>
<li>
  <a href="#canfail">      Can the overlay fail?</a>
<li>
  <a href="#coordtrafo">     Coordinate systems and tranformations</a>
<li>
  <a href="#additional">    Additional features</a>
</ul>
<li>
  <a href="#cmdline"> Command line arguments </a>
<li>
  <a href="#FAQ">  FAQ</a>
<li>
    <a href="#shortcuts"> List of shortcuts</a>
</ul>
	
<h2> <a name="tikzedt">TikzEdt</a> </h2>

TikzEdt is an editor for the Tikz language, used to encode vector graphics in Latex documents. 

<h4>
  <a name="whatcan"> What TikzEdt can and cannot do for you </a>
</h4>
Typically, when producing graphics for use in LaTeX documents, you have the choice between:
<ul>
 <li> Using a scripting language, like Tikz or pstricks to directly code the image.
 <li> Using an external WYSIWYG drawing program (like Inkscape, !OpenOffice Draw, or even MS Powerpoint), export your dawing as pdf or eps, and include it in your tex-file.
</ul>
Both approaches have advantages and disadvantages. Usually the manually coded graphics are higher quality, but more effort to produce. In particular, positioning items in code such that proportions "look good" can be painful. Real time preview programs like ktikz already help a lot. 
The goal of TikzEdt is to go one step further and combine WYSIWYG and code editing, so that ideally you can generate graphics coded in TikZ in little more effort than what would need with a vector drawing program, but still retain the full flexibility and high quality look of Tikz drawings.

TikzEdt is however not a replacement for full-featured WYSIWYG vector graphics editor. It assists you writing TikZ code, but still you will have to learn the TikZ language, since  only a few TikZ commands are accessible through TikzEdt's WYSIWYG tools. If you do not want to deal with TikZ coding, you probably are better off using Inkscape or one of its commercial counterparts.

<h2>
  <a name="getstarted">Getting started </a>
</h2>

To use TikzEdt, you need a working Latex installation. The authors use the <a href="http://miktex.org/">MiKTeX</a> distribution. We strongly recommend to do a full installation of all packages, or at least of all TikZ-related packages.  Also, you need .NET 4. the setup program will complain and direct you to the appropriate download page if you don't have it installed already.

<!-- 
<h4>
  <a name="firstrun"> The first run </a>
</h4>
If you start up TikzEdt for the first time, it will ask you for allowance to compile the Snippet library. You should click "Yes". Each snippet comes with a small preview image, which itself is coded in TikZ. !TikzEdt needs to compile all those code snippets and produce the preview images to display. All this happens in the background, you will probably only notice the progress indicator in the status bar.
-->
<h4>
  <a name="helloworld"> Hello World </a> </h4>

Start TikzEdt and enter the following code:

<pre class="prettyprint">
\begin{tikzpicture}
  \node (h) at (1,1) {hello};
  \node (w) at (3,3) {world};
  \draw (h) edge (w);
\end{tikzpicture}
</pre>

If all goes well, you will see the compiled preview of your document on the right hand side, plus two red crosses at the locations of the nodes. Try dragging the red crosses with the mouse and watch the code update itself.

<h2>
  <a name="features"> Overview of features </a>
</h2>
TikzEdt assists you in the following ways:
<ul>
  <li> By providing a good text editor with syntax highlighting and code completion (CTRL-SPACE), powered by AvalonEdit. You can customize the syntax highlighting and code completion by editing the appropriate xml-files.
  <li> By providing real time preview of the compiled TikZ picture as you type. The preview is speeded up by using precompiled headers.
  <li> By an extensible snippet library that you can display or hide by pressing the "Snippets" button on the left of TikzEdt's window. Insert snippets by double click or using the context menu. You can write your own snippets usinging the snippet editor (Menu Settings->Snippet Editor), or by editing the xml file TheSnippets.xml.
  <li> By the WYSIWYG tools accessible through an overlay displayed on top of the compiled tikz image. 
</ul>
Except for the last, these features are pretty standard, so let us discuss only the WYSIWYG part in more detail. This is also the part that is hardest to implement and took most of our development time.

<h4>
  <a name="tools"> The WYSIWYG tools </a>
</h4>

<img src="img/toolstoolbar.png" />

<table id="hor-minimalist-b">
  <tr>
    <th width="100"> Name </th>
    <th> Description </th>
  </tr>
<tr>
<td> 1 Move </td><td> This tool allows you to select and shift around coordinates. Just mark some items and drag and drop. </td>
</tr><tr>
<td> 2 Node </td><td> Insert new nodes, like `\node at (3,4) {?}`. Replace the ? by whatever text you want to show at that position. </td>
</tr><tr>
<td> 3 Edge </td><td> This tool connects two coordinates or nodes by a Tikz edge, like `\draw (v1) edge (mynode)`. If you select unnamed coordinates to connect, a `node` tag is inserted, with a unique name like `v13`.  </td>
</tr><tr>
<td> 4 Path </td><td> This tool produces a series of lines.</td>
</tr>
  <tr>
    <td> 5 Smooth Curve </td>
    <td> Draw a smooth curve through specified points. Double click to closethe curve, right click or press ESC to stop drawing and leave the curve open. </td>
  </tr>
  <tr>
    <td> 6 Bezier Curve </td>
    <td> Draw a Bezier curve. </td>
  </tr>
  <tr>
<td> 7 Rectangle </td><td> Produces a rectangle, press CTRL to make a square. </td>
</tr><tr>
<td> 8 Ellipse <td> Produces an ellipse, press CTRL to make a circle. </td>
</tr>
  <tr>
    <td> 9 Arc/Pie </td>
    <td> Draw an arc segment. Press CTRL to draw a Pie segment instead. </td>
  </tr>
  <tr>
    <td> 10 Edit Arc/Pie </td>
    <td> Lets you edit arc segments in a better way than with the Move tool. </td>
  </tr>
  <tr>
    <td> 11 Grid </td>
    <td> Draw a grid. </td>
  </tr>
</table>

By default the code will be inserted at the end of the tikzpicture environment in your TikZ code.
You can also select Tikz scope's for editing by double clicking or through the context menu. Then a thick border is drawn around the scope and items are inserted at the end of the scope. For example:

<pre class="prettyprint">
\begin{tikzpicture}
  % some stuff
  \begin{scope}
    % some more here
    % --- when the scope is selected for editing, items are inserted here ---
  \end{scope}
  % blablabla
  % --- when the scope is selected, items are inserted here ---
\end{tikzpicture}
</pre>

<h4>
  <a name="overlay"> Which TikZ objects appear in the overlay </a>
</h4>
You will note that not all elements in your TikZ file are represented in the overlay. This has two reasons:
<ul>
  <li>
    It does not make sense to edit some Tikz elements move with the mouse. For example, if you draw a TikZ `\matrix`, the position of the matrix elements cannot be changed directly, but is determined during the typesetting. Hence it does not make sense to make those positions editable.
  </li>
  <li>
    The position of coordinates has to be determined by TikzEdt. The authors cannot reimplement Latex/Tikz completely and hence some TikZ features are not WYSIWYG-supported in TikzEdt.
  </li>
</ul>

Only coordinates, which are editable, and whose absolute position can be "easily" determined appear in the overlay and can hence be modified with the mouse by drag and drop.

<!-- 
To see what this means in practice, let us consider examples.
<pre class="prettyprint">
\begin{tikzpicture}[xscale=3]
  \draw[yshift=1cm] (1,1) -- (3,3);   % these will appear
  \node (v1) at (1,3) {this appears as well};
  
  \begin{scope}[scale = .5, rotate=30]
    \draw (v1) -- +(1,1) -- ++(30:5);  % (1,1) and (30:5) appear
  \end{scope}

  \node at (0.23,0.01) {}  % appears
    child {node {} % does not appear
      child {node {}}
      child {node {}}
      child {node {}}
    }
</pre>
Here the child nodes are not displayed since its position can be neither modified nor determined by !TikzEdt. Also note that expressions using the Tikz math engine are not evaluated by !TikzEdt and hence those nodes are not displayed in the !TikzEdt overlay. But probably, you wouldn't want to WYSIWYG edit those nodes anyway. 
-->

<h4>
  <a name="canfail"> Can the overlay fail? </a>
</h4>
Determining and modifying the positions of nodes is rather intricate programmatically. We tried to make sure that 
(i) even if only part of the TikZ code can be understood by TikzEdt, WYSIWYG editing of the remainder of the code still works, and (ii) that your code will never get corrupted by the WYSIWYG editor.
In the current beta phase, in case you encounter problems (we don't hope so, of course), you should:
<ol>
  <li>
    Either turn off the WYSIWYG features by switching to "Preview Mode" in the "View" menu, and use TikzEdt merely as a text editor with preview.
  </li>
  <li>
    Or enclose the conflicting part of your code in %/* ... %*/. The part ... in the middle will be ignored by the parser and will not appear on the overlay.
  </li>
  <li>
    In any case, we are happy if you report the problem and send us the conflicting file, so that we can improve TikzEdt.
  </li>
</ol>
  
<h4>
  <a name="coordtrafo"> Coordinate systems and tranformations </a>
</h4>

TikzEdt supports TikZ coordinate transformations, but currently not canvas transformations. In particular, you can use the WYSIWYG features with polar coordinates, and things should behave as you expect.
For example, try to move the node in this example:
<pre class="prettyprint">
\begin{tikzpicture}
  \draw (-4,4) rectangle (4,4);
  \node[draw, fill, minimum size=5] at (30:2); 
\end{tikzpicture}
</pre>

<h4>
  <a name="additional">Additional features </a>
</h4>
There are some additional features:
<ul>
  <li>
    \begin{}-completion: If you type \begin{bla} + RETURN, TikzEdt automatically inserts an \end{bla}. This feature can be turned off in the settings dialog.
  </li>
  <li>
    Put the caret at some position in the text editor and right click->Mark item in overlay. Then the location of the item is highlighted in the preview on the right. (Note: Make sure the caret is really at the right position, not just the mouse....)
  </li>
  <li>
    The other way around, you can jump to the source code corresponding to some item in the overlay using the context menu or mouse double click.
  </li>
</ul>
  
<h2>
  <a name="cmdline"> Command line arguments </a>
</h2>
<table id="hor-minimalist-b">
  <tr>
    <th>Flag</th>
    <th>Description</th>
  </tr>
  <tr>
    <td>-p, --portable</td>
    <td>Use the application directory to store user settings. Note: the application directory must be writable.</td>
  </tr>
  <tr>
    <td>-h</td>
    <td>Turn on hardware rendering. This makes TikzEdt faster, but is less "safe" than software rendering.</td>
  </tr>
</table>
  
<h2>
  <a name="FAQ"> FAQ</a> </h2>

Q: Latex reports an error "...default stile file not found ...". 

A: Compile->Regenerate precompiled headers 

<h2><a name="shortcuts">List of shortcuts</a></h2>
<table id="hor-minimalist-b">
  <tr>
    <th>Shortcut</th>
    <th>Description</th>
  </tr>
  <tr>
    <td>ALT</td>
    <td>Hold ALT to temporarily disable rasterization of coordinates.</td>
  </tr>
  <tr>
    <td>SHIFT+ALT</td>
    <td>Hold SHIFT+ALT to temporarily half the coordinate raster.</td>
  </tr>
  <tr>
    <td>CTRL+T</td>
    <td>Comment out a section of code.</td>
  </tr>
  <tr>
    <td>CTRL+SHIFT+T</td>
    <td>Uncomment a section of code.</td>
  </tr>
</table>