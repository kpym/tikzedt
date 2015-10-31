### The SimpletikzParser ###
The heart of the Parser is the Antlr generated class SimpleTikzparser, who parses an input document and returns an Abstract Syntax Tree (AST) describing it.
The AST will contain nodes representing only those elements that TikzEdt "cares about". For example, if an unsupported command is encountered (like \matrix), it is simply ignored. Concretely, the complete list of things the parser cares about is the following:
  * the tikzpicture environment (of course)
  * \tikzset or \tikzstyle commands (in order to extract a list of styles)
  * All \path commands (This includes \node, \draw etc.)
  * scope environments
  * Internal commands (starting with "% !TIKZEDT")

## Structure of the generated AST ##
The AST must produced must have the following structure:
(Note: all node types have token names like `IM_SOMETHING`..)
The single root node is always `IM_DOCUMENT`.

As children, the following nodes are allowed:
  * `IM_PICTURE`: This is the most important node, it describes the tikzpicture environment.
  * `IM_TIKZSET`: It describes a \tikzset clause (i.e., options)
  * `IM_STYLE`: It descibes a \tikzstyle clause.
  * `IM_TIKZEDT_CMD`: It describes an internal command. (starting with "% !TIKZEDT")

The structure and possible children of the most important AST nodes are described below.
(For a description of the less important nodes not detailed here, see the simpletikz.g grammar file.)

**Important:** The nodes in the AST must occur in the same order they occur in the code.

### A general note on container nodes ###
Most elements in a tikzdocument are "container elements". They have the structure
```
<some start tag>
  <some element>
  <another element>
<some end tag>
```
One type of element can also have different start tags, e.g., a \path can be either started with \path, \draw, \fill, \node, \clip

As general principle, the AST node in question (e.g., a path node) will have the structure
```
IM_STARTTAG <element> ... <element> IM_ENDTAG
```
where, e.g., IM\_STARTTAG would contain "\fill" as subnode, "IM\_ENDTAG" contains ";".

### `IM_PICTURE` ###
The tikzpicture node can have the following children
  * `IM_PATH`: This describes a Tikz path, i. e., an list of drawing commands started by \path, \draw, \fill, \clip, or \node.
  * `IM_SCOPE`: Describes a scope container.
  * `IM_TIKZSET` or `IM_STYLE`.


### `IM_TIKZSET` ###
Has the structure
```
IM_STARTTAG (IM_OPTION_KV | IM_OPTION_STYLE)* IM_ENDTAG
```

### `IM_STYLE` ###

### `IM_SCOPE` ###

### `IM_TIKZEDT_CMD` ###


## Example ##
Consider the following Code

```
\begin{tikzpicture}
\begin{scope}[xshift=3cm]
\node (v1) at (3,3) {hallo}
\end{scope}
\end{tikzpicture}
```

It will be translated into the following AST:
```
IM_DOCUMENT
  IM_TIKZPICTURE
    IM_STARTTAG
    IM_SCOPE
      IM_STARTTAG
      IM_OPTIONS
        IM_STARTTAG
        IM_OPTION_KV
          ...
        IM_ENDTAG
      IM_PATH
        IM_STARTTAG
        IM_NODE
          ...
        IM_ENDTAG
      IM_ENDTAG
    IM_ENDTAG
```

## Why use so many trees? ##
The Tikz code is translated in TikzEdt into 4 kinds of trees:
  1. The simpletikzparser produces a parse tree, than from that an AST.
  1. The TikzParser translates this AST into a Tikz\_ParseTree
  1. The PdfOverlay internally represents the elements it displays in a tree build from OverlayShapes. ("Display Tree")

One can ask whether it is not possible to have only one tree and store everything in there. However, this would destroy more or less all modularity of TikzEdt.
The current solution ensures that the TikzParser is shielded completely from the low level parsing done by Antlr, and from the "view layer" introduced by PdfOverlay.