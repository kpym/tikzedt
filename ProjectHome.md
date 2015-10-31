Temporarily disabled the OSX download. (There have been problems I have to fix first.)

**News: Uploaded version 0.2.3.**

The new version contains some bug fixes, most notably one solving an issue with foreign locales, which caused the overlay to be misaligned.

P.S.: I have not implemented all requested parser extensions due to lack of time. If you use non-supported Tikz syntax, you may always enclose the conflicting parts of the documents as follows:
```
%/*
(everything here is ignored by TikzEdt's parser)
%*/
```

**Visit our website at [www.tikzedt.org](http://www.tikzedt.org/)**

TikzEdt is a combined WYSIWYG/text editor designed for editing [Tikz](http://www.texample.net/tikz/examples/) code.

**Features:**
  * Syntax highlighting and code completion, based on [AvalonEdit](http://wiki.sharpdevelop.net/AvalonEdit.ashx).
  * Real time rendering, using pdflatex and [mupdf](http://mupdf.com).
  * It contains a Tikz parser, built using the [Antlr](http://www.antlr.org/) parser generator.
  * Parsed coordinates are displayed as an overlay on the rendered image. The overlay can be edited with the mouse in a WYSIWYG manner. The source code is updated accordingly.
  * It comes with a snippet library to store frequently used commands and styles, containing many pre-defined examples.


**New features in version 0.2.2:**
  * One can use an external pdf renderer (mupdf) for better rendering quality. To do this, copy mudraw.exe into Tikzedt's program folder and change the rendering method in the settings.
  * Customization of editor font.
  * Version for Linux, and MacOS (to be tested)
  * Bug-fixes

**New features in version 0.2.1:**
  * New look
  * Dynamic preamble
  * Some bugfixes

**New features in version 0.2:**
  * More WYSIWYG tools. In particular deletion and cut/copy is now possible directly from the overlay.
  * Improved workflow.
  * Snippets can now directly be inserted as styles or used for drawing with one click.
  * Export to svg and html.
  * Folder view panel for faster navigation
  * New precompiler directives.
  * Portable version.


Screenshots (v0.1):

| [https://tikzedt.googlecode.com/svn/wiki/img/screenshot1\_thumb.jpg ](http://code.google.com/p/tikzedt/wiki/screenshot_1) | [![](https://tikzedt.googlecode.com/svn/wiki/img/screenshot2_thumb.jpg)](http://code.google.com/p/tikzedt/wiki/screenshot_2) | [![](https://tikzedt.googlecode.com/svn/wiki/img/screenshot3_thumb.jpg)](http://code.google.com/p/tikzedt/wiki/screenshot_3) |
|:--------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------------------------------------------------------------------|

This program is still under development. If you are interested in contributing, please contact the author. Help is very welcome, be it in coding, bug hunting, or suggesting new features. [more...](How_to_contribute.md)