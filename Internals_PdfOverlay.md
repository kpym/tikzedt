# How the PdfOverlay control works #

The PdfOverlay control is responsible for the rendering of the overlay, and for handling the wysiwyg drawing the user can perform on it.
It holds the Tikz\_ParseTree for the current document. All the operations it performs it performs directly on this parsetree.
The typical workflow is as follows:

  1. The user makes some wysiwyg change to the picture, e.g., inserts a node.
  1. The program creates a Tikz\_Node object and inserts it into the Tikz\_ParseTree at the appropriate position.
  1. It raises an event (`OnModified`) indicating that the Tikz\_ParseTree has changed. This event is listened to by the main window, which accordingly updates the text displayed in the editor.


# Some internal Details #
From the elements in the Tikz\_Parsetree, the PdfOverlay control only displays the following:
  * editable coordinates (e.g., (3,3), +(180:5)): This includes als the coordinates as in `node at (3,3)`. These coordinates are drawn as crosses. No additional crosses are drawn for non-editable coordinates as occuring in `\draw (v1) -- (v2);` (of course, I would say).
  * scopes: Scopes are drawn as boxes around the elements (i.e., coordinates or other scopes) the scope contains.

There are three C#-classes that the PdfOverlay uses:
  * OverlayShape: Base class for every shape displayed (i.e., cross or box)
  * OverlayNode: represents a cross shape
  * OverlayScope: represents the box displayed for scopes.

The OverlayShapes to be drawn are stored in the List `TopLevelItems` of PdfOverlay.
The class OverlayScope contains a List `children` in which all `OverlayShape`s that are to be shown within the box are contained.

**Note:** To be clear: The list `TopLevelItems` only contains the Top Level Items, for example, some coordinate included in some scope is contained in the List `children` of the corresponding OverlayScope, but not in the `TopLevelItems`.

## Example ##
Consider the following code
```
\begin{tikzpicture}
  \node (v1) at (3,3) {};
  \draw (1,1) -- (2,2);
  \begin{scope}
    \draw (v1) -- (5,5);
  \end{scope}
\end{tikzpicture}
```

Will produce the following tree:
```
TopLevelItems
  OverlayNode
  OverlayNode
  OverlayNode
  OverlayScope
    OverlayNode
```
In particular, the List `children` of OverlayScope has one element, corresponding to the coordinates (5,5).