<h2><?=$pagetitle?></h2>

<table>
  <tr>
  <th colspan="2">Instant Preview</th>
  </tr>
  <tr height="30"/>
  <tr>
    <td colspan="2"><img src="img/instantpreview.png" width="600"/></td>
  </tr>
  <tr>
    <td style="padding-left:30px;" width="50%">
      <img src="img/button1.png" width="30" align="absmiddle"/> Type some Tikz code.</td>
    <td style="padding-left:30px;" width="50%">
      <img src="img/button2.png" width="30" align="absmiddle"/> Instantly see the compiled result.</td>
  </tr>
  <tr height="50"/>
  <tr style="margin-top:220px;">
    <th colspan="2">Wysiwyg Editing</th>
  </tr>
  <tr height="30"/>
  <tr>
    <td colspan="2">
      <img src="img/mouseedit.png" width="600"/>
    </td>
  </tr>
  <tr>
    <td style="padding-left:10px;">
      <img src="img/button2.png" width="30" align="absmiddle"/> Watch the Tikz code update itself.</td>
    <td style="padding-left:30px;">
      <img src="img/button1.png" width="30" align="absmiddle"/> Edit some coordinates with the mouse.</td>
  </tr>
  <tr height="50"/>
  <tr>
    <th colspan="2">Wysiwyg Editing II</th>
  </tr>
  <tr height="20"/>
  <tr>
    <td colspan="2" style="padding-left:200px;">
      <img src="img/button1.png" width="30" align="absmiddle"/> Choose some drawing tool.</td>
  </tr>
  <tr>
    <td colspan="2">
      <img src="img/drawingtool.png" width="600"/>
    </td>
  </tr>
  <tr>
    <td style="padding-left:30px;">
      <img src="img/button3.png" width="30" align="absmiddle"/> The Tikz code is written for you.</td>
    <td style="padding-left:30px;">
      <img src="img/button2.png" width="30" align="absmiddle"/> Draw something.</td>
  </tr>
  <tr height="50"/>
  <tr>
    <th colspan="2">Styles</th>
  </tr>
  <tr height="20"/>
  <tr>
    <td colspan="2" style="padding-left:200px;">
      <img src="img/button1.png" width="30" align="absmiddle"/> You can customize the basic WYSIWYG drawing tools by selecting or typing some styles or Tikz attributes.
    </td>
  </tr>
  <tr>
    <td colspan="2">
      <img src="img/styles.png" width="600"/>
    </td>
  </tr>
  <tr>
    <td style="padding-left:30px;">
    </td>
    <td style="padding-left:0px;">
      <img src="img/button2.png" width="30" align="absmiddle"/> The styles/attributes will automatically be applied to the objects you draw.
    </td>
  </tr>
  <tr height="50"/>
  <tr>
    <th colspan="2">The snippet library</th>
  </tr>
  <tr height="20"/>
  <tr>
    <td/>
    <td>
      <img src="img/button2.png" width="30" align="absmiddle"/> Pressing the "Play" button selects an attribute for use with the WYSIWYG drawing tools.
    </td>
  </tr>
  <tr>
    <td colspan="2">
      <img src="img/snippets.png" width="600"/>
    </td>
  </tr>
  <tr>
    <td style="padding-left:30px;">
      <img src="img/button1.png" width="30" align="absmiddle"/> TikzEdt contains a collection of predefined code snippets, attributes and styles. You can extend it by defining your own.
    </td>
    <td style="padding-left:30px;">
    </td>
  </tr>
  <tr height="50"/>
  <tr>
    <th colspan="2">How it works</th>
  </tr>
  <tr height="20"/>
  <tr>
    <td colspan="2">
      <img src="img/howitworks.png" width="600"/>
    </td>
  </tr>
  <tr>
    <td style="padding-left:30px; text-align:justify;">
      <img src="img/button1.png" width="30" align="left" style="padding-right:10px;"/> TikzEdt contains a parser that is able to understand the basic structure of Tikz documents and extracts editable coordinates.
    </td>
    <td style="padding-left:30px; text-align:justify;">
      <img src="img/button2.png" width="30" align="left" style="padding-right:10px;"/> The extracted coordinates are drawn as an overlay on top of the pdf compiled from your Tikz code. You can edit the coordinates by dragging the red crosses with your mouse.
    </td>
  </tr>
  <tr height="30"/>
  <tr>
    <td colspan="2" style="text-align:justify;">
      <img src="img/warning.png" width="50" align="left" style="padding:10px;"/>
      Note: Parsing Latex/Tikz code is not a simple task. Tikzedt can understand a couple of Tikz constructs, in particular coordinate transformation and polar coordinates. But, yes, it can be fooled.... see the documentation for more details. (In the worst case, you may always turn off the parser and use TikzEdt as a text editor with instant preview.)
    </td>
  </tr>
</table>