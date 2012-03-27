<table class="navtable" >
<tr>
  <td <?php if ($pagetitle=="Home") echo " id=\"currentpagelink\""; ?> >
    <a href="index.php"> Home</a>
  </td>
</tr>
<!-- <td><a href="http://code.google.com/p/tikzedt/downloads/list" target="_blank">Download</td> -->
<tr>
  <td <?php if ($pagetitle=="Download") echo " id=\"currentpagelink\""; ?>  >
    <a href="down.php">Download</a>
  </td>
</tr>
<tr>
  <td
    <?php if ($pagetitle=="Quick Tour") echo " id=\"currentpagelink\""; ?>>
      <a href="quicktour.php">Quick Tour</a>
  </td>
</tr>
  <tr>
    <td
      <?php if ($pagetitle=="Use Cases") echo " id=\"currentpagelink\""; ?>>
      <a href="usecases.php">Use Cases</a>
    </td>
  </tr>
  <!-- 
  <tr >
    <td <?php if ($pagetitle=="Screenshots") echo " id=\"currentpagelink\""; ?> >
        <a href="screenshots.php">Screenshots</a>
    </td>
  </tr>
  -->
  <tr>
    <td
      <?php if ($pagetitle=="Documentation") echo " id=\"currentpagelink\""; ?>>
      <a href="doc.php">Documentation</a>
    </td>
</tr>
  <tr>
    <td
      <?php if ($pagetitle=="Links") echo " id=\"currentpagelink\""; ?>>
      <a href="links.php">Links and Contact</a>
    </td>
  </tr>
  <!-- 
  <tr>
    <td <?php if ($pagetitle=="About") echo " id=\"currentpagelink\""; ?>>
        <a href="about.php">About</a>
    </td>
  </tr>
  -->
  <tr style="height:90px;">
    <td style="border-bottom:none;background-color:white;"></td>    
  </tr>
  <tr>
      <td style="border-bottom:none;background-color:white;">
        <a href=<?="$msidownload"?>>
          <img style="height:70px;margin-left:0px;" src="img/downloadbtn.png" alt="Download"/>
        </a>
      </td>
    </tr>
<!--<td><a href="help.php">Help</td> -->
</table>