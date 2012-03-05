<h2><?=$pagetitle?></h2>

Suppose you want to write a Latex document that contains some TikZ pictures. There are essentially three common approaches to accomplish this. It is a matter of taste (and sometimes of external requirements, e. g. of the publisher) which one you choose.

<ol>
  <li>All-in-one approach: You may simply put both the TikZ code and (Latex) text into a single .tex file. Advantages: Simple, compact, only one file to keep around. Disadvantage: Makes the Latex file hard to read and edit, especially if you have complicated picture.</li>
  <li>\input-approach: You may put each Tikz picture in a separate file, and \input these files into the main Latex document. Advantages: Much tidier and easier to edit than the previous solution. Disadvantage: You have to keep several files around.</li>
  <li>Compiled-picture approach: You may compile the pictures separately from your Latex file, say to pdf's, and include only these pdf files. Advantages: The compilation of your Latex document will be faster. Disadvantage: You need to compile every picture and keep the pdf's around.</li>
</ol>

Here is how you would use TikzEdt in each of these scenarios:

<h4>All-in-one approach</h4>
In this case you simply copy-paste the Tikz code into TikzEdt when you want to edit it, and copy-paste it back into the main Latex document when you are done.

<h4>\input approach</h4>
Here you would save each each TikZ picture as a separate file, say "mypic.tikz" and use TikzEdt to open and edit this file. Note that upon installation the .tikz file extension gets associated to TikzEdt.

<h4>Shared styles and the dynamic preamble</h4>
There is a potential problem with the workflow sketched above: In many cases one may want to define common styles or tikz settings in the main Latex document, that are shared across all Tikz pictures. For example, you may want to define some custom \node style to be used in multiple pictures.
In this case there is a problem, since when you use TikzEdt to edit the Tikz code, it has no way of knowing about the styles and settings defined in the main Latex file.
To solve this issue, TikzEdt allows you to define "dynamic preambles". These are code snippets that you may quickly pre-append to your Tikz code.
To see how it works, suppose we have defined two styles in our main Latex document by the lines

<pre class="prettyprint">
  \tikzstyle{foostyle}=[draw, circle, fill]
  \tikzstyle{barstyle}=[minimum size=2cm]
</pre>

Suppose we want to use foostyle or barstyle in some of our TikZ pictures. Then add a dynamic preamble as follows:

<img src="img/dynamicpreamble.png" style="margin-top:15px;"/>

After adding the dynamic preamble it will be displayed in the list of dynamic preambles, in the appropriate tab.
To pre-append that preamble to your Tikz document, just check the mark on the left. So whenever you want to use the styles foostyle or barstyle in any of your TikZ documents in the future, just check the appropriate item in the list of dynamic preambles.

<img src="img/dynamicpreamble2.png" style="margin-top:15px;"/>

<h4>Compiled-picture approach</h4>
In this approach you would create one TikZ file for each picture you want to include in your Latex document (say myfoopic.tikz, mybarpic.tikz, etc.). You can use TikzEdt to edit these picture files. Once you are done editing you can save the picture as pdf file by a single click on the "Save Pdf" button highlighted below.

<img src="img/savepdf.png" style="margin-top:15px;"/>






