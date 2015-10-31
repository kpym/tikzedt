

# TikzEdt #

TikzEdt is an editor for the Tikz language, used to encode vector graphics in Latex documents.

## What TikzEdt can and cannot do for you ##
Typically, when producing graphics for use in LaTeX documents, you have the choice between:
  1. Using a scripting language, like Tikz or pstricks to directly code the image.
  1. Using an external WYSIWYG drawing program (like Inkscape, OpenOffice Draw, or even MS Powerpoint), export your dawing as pdf or eps, and include it in your tex-file.

Both approaches have advantages and disadvantages. Usually the manually coded graphics are higher quality, but more effort to produce. In particular, positioning items in Code such that proportions "look good" can be painful. Real time preview programs like [ktikz](http://www.hackenberger.at/blog/ktikz-editor-for-the-tikz-language) already help a lot.
The goal of TikzEdt is to go one step further and combine WYSIWYG and code editing, so that ideally you can generate graphics coded in Tikz in little more time that would need with a vector drawing program, but still retain the full flexibility and high quality look of Tikz drawings.

TikzEdt is however not a replacement for full-featured WYSIWYG vector graphics programs. It assists you writing Tikz code, but you will still have to learn the Tikz language, since  only a few Tikz commands are accessible through TikzEdt's WYSIWYG tools. If you do not want to deal with TikZ coding, you probably are better off using Inkscape or one of its commercial counterparts.

# Getting started #

To use TikzEdt, you need to install pdflatex. The authors use the [http://miktex.org/](MiKTeX.md) distribution. We strongly recommend to do a full installation of all packages, or at least of all tikz-related packages.  Also, you need .NET 4. the setup program will complain and direct you to the appropriate download page if you don't have it installed already.

## The first run ##
If you start up TikzEdt for the first time, it will ask you for allowance to compile the Snippet library. You should click "Yes". Each snippet comes with a small preview image, which itself is coded in TikZ. TikzEdt needs to compile all those code snippets and produce the preview images to display. All this happens in the background, you will probably only notice the progress indicator in the status bar.

## Hello World ##

Start TikzEdt and enter the following code:

```
\begin{tikzpicture}
  \node (h) at (1,1) {hello};
  \node (w) at (3,3) {world};
  \draw (h) edge (w);
\end{tikzpicture}
```

If all goes well, you will see on the right hand side the compiled preview of your document, plus two red crosses at the location of the nodes. Try dragging the red crosses with the mouse and watch the code update itself.

# Overview of features #
TikzEdt assists you in the following ways:
  1. By providing a good text editor with syntax highlighting and code completion (CTRL-SPACE), powered by AvalonEdit. You can customize the syntax highlighting and code completion by editing the appropriate xml-files.
  1. By providing real time preview of the compiled TikZ picture as you type. The preview is speeded up by using precompiled headers.
  1. By an extensible snippet library that you can display or hide by pressing the button on the left. Insert snippets by double click or using the context menu. You can write your own snippets usinging the snippet editor (Menu Settings->Snippet Editor), or directly editing the xml file.
  1. By the wysiwig tools accessible through an overlay displayed on top of the compiled tikz image.

Except the last, these features are pretty standard, so let us discuss only the WYSIWYG part in more detail. This is also the part that is programmatically most difficult to realize and took most of our time.

## The WYSIWYG tools ##
There are currently 6 WYSIWYG tools.

![http://lh6.ggpht.com/_t8n2oghTr8Y/TUE_eaWjsiI/AAAAAAAAABk/_3lhD1usJoQ/toolstoolbar.png](http://lh6.ggpht.com/_t8n2oghTr8Y/TUE_eaWjsiI/AAAAAAAAABk/_3lhD1usJoQ/toolstoolbar.png)

| Move | This tool allows you to select and shift around coordinates. Just mark some items and drag&drop. |
|:-----|:-------------------------------------------------------------------------------------------------|
| Node | Insert new nodes, like `\node at (3,4) {?}`. Replace the ? by whatever text you want to show at that position. |
| Edge | This tool connects two coordinates or nodes by a Tikz edge, like `\draw (v1) edge (mynode)`. If you select unnamed coordinates to connect, a `node` tag is inserted, with a unique name like `v13`.  |
| Path | This tool produces a series of lines.                                                            |
| Rectangle | Produces a rectangle, press CTRL to make a square.                                               |
| Ellipse | Produces an ellipse, press CTRL to make a circle.                                                |

The code will be inserted by default at the end of the tikzpicture.
You can also select Tikz `scope`s for editing by double clicking or through the context menu. Then a thick border is drawn around the scope and items are inserted at the end of the scope. For example:

```
\begin{tikzpicture}
  % some stuff
  \begin{scope}
    % some more here
    % --- when the scope is selected for editing, items are inserted here ---
  \end{scope}
  % blablabla
  % --- when the scope is selected, items are inserted here ---
\end{tikzpicture}
```

## Which Tikz objects appear in the overlay ##
You will note that not all elements in your tikz file are represented in the overlay. This is for two reasons:
  * It does not make sense to move with the mouse some Tikz elements. For example, if you draw a Tikz `matrix`, the position of the matrix elements cannot be changed directly, but is determined by the typesetter. Hence it does not make sense to make those positions editable.
  * The position of coordinates has to be determined by TikzEdt. The authors cannot reimplement completely Latex/Tikz and hence not all constructions are WYSIWYG-supported.

What appears in the overlay are coordinates, which are editable, and whose absolute position can be "easily" determined. To see what this means in practice, let us consider examples.

```
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
```
Here the child nodes are not displayed since its position can be neither modified nor determined by TikzEdt. Also note that expressions using the Tikz math engine are not evaluated by TikzEdt and hence those nodes are not displayed in the TikzEdt overlay. But probably, you wouldn't want to WYSIWYG edit those nodes anyway.

## Can the overlay fail? ##
Determining and modifying the positions of nodes is rather intricate programmatically. We tried to make sure that
(i) even if only part of the TikZ code can be understood by TikzEdt, WYSIWYG editing of the remainder of the code still works, and (ii) that your code will never get corrupted by the WYSIWYG editor.
In the current beta phase, in case you encounter problems (we don't hope so, of course), you should:
  1. Either turn off the WYSIWYG features by switching to "Preview Mode", and use TikzEdt as just a text editor with preview.
  1. Or enclose the conflicting part of your code in `%/*` ... `%*/`. The part ... in the middle will be ignored by the parser and will not appear on the overlay.
  1. In any case, we are happy if you [report](http://code.google.com/p/tikzedt/issues) the problem and send us the conflicting file, so that we can improve the program.
## Coordinate systems and tranformations ##

TikzEdt supports TikZ coordinate transformations, but currently not canvas transformations. In particular, you can use the WYSIWYG features with polar coordinates, and things should behave as you expect.
For example, try to move the node in this example:
```
\begin{tikzpicture}
  \draw (-4,4) rectangle (4,4);
  \node[draw, fill, minimum size=5] at (30:2); 
\end{tikzpicture}
```


## Additional features ##
There are some additional features:
  * `\begin{}`-completion: If you type `\begin{bla}` + RETURN, TikzEdt automatically inserts an `\end{bla}`, as in Kile. If you don't like this feature, you can turn it off in the settings dialog.
  * Put the caret at some position in the text editor and right click->Mark item in overlay. Then the location of the item is highlighted in the preview on the right. (Note: Make sure the caret is really at the right position, not just the mouse....)
  * The other way around, you can jump to the source code corresponding to some item in the overlay using the context menu or mouse wheel.

# Portable version #
You can start TikzEdt with the -portable flag.

# FAQ #

Q: Latex reports an error "...default stile file not found ...".

A: Compile->Regenerate precompiled headers