# Modularity #
Most design decisions have been made so as to increase the modularity of the code as much as possible.
The different parts of the program should know as little as somehow possible from each other. The reasons are that (i) this is good style of course (ii) work can be more easily shared among several people and (iii) my plan is to package parts of the program into the following standalone libraries, that could potentially be reused elsewhere:
  * A component AvalonEditEx: It enhances the Avalon Texteditor by
    1. A find/replace dialog
    1. Code completion
    1. Glue logic for syntax highlighting.
  * A component SnippetList: This comprises the snippet list and the SnippetManager.
  * A component for displaying pdf files. (Essentially TikzDisplay).
  * A component for rendering latex files into pdf (should include precompiled header generation, queues, etc...; contains essentially part of TikzDisplay and the BmpFactory).

# What the various components need to know about each other #