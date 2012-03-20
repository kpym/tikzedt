<?
$xml = simplexml_load_file("http://tikzedt.googlecode.com/svn/trunk/VersionInfo.xml");
$zipdownload = "http://code.google.com/p/tikzedt/downloads/list";
$msidownload = "http://code.google.com/p/tikzedt/downloads/list";
$teversion = "";

foreach($xml->children() as $child)
{
   if ($child->getName()=="latestversion")
     $teversion = $child;
   else if ($child->getName()=="downloadurl")
     $msidownload = $child;
   else if ($child->getName()=="downloadurlzip")
     $zipdownload = $child;
}

//$zipdownload = "http://tikzedt.googlecode.com/files/TikzEdtBeta0_2_1.zip";
//$msidownload = "http://tikzedt.googlecode.com/files/TikzEdtBeta0_2_1.msi";
//$teversion = "0.2.1";
?>
<!DOCTYPE html>
<html>
<head>
	<link href="style.css" rel="stylesheet" type="text/css" />
	<link rel="icon" type="image/vnd.microsoft.icon" href="img/logo.ico" />
<title>TikzEdt - A WYSIWYG Tikz editor. <?=$pagetitle?></title>
</head>
<body>
	<table id="maintable" >
		<tr>
			<td style="border-bottom:solid 1px black;height:100px;" >
				 <? include "header.html" ?><!---->
			</td>
            <td style="border-bottom:solid 1px black; border-left:solid 1px black;" width="200"></td>
		</tr>
		<tr>			
			<td style="vertical-align:top; margin-top:20px;" >
			  <div id="page">
				<? include $tpl ?>
			  </div>
		  </td>
          <td style="border-left:solid 1px black;vertical-align:top;padding:0px;" width="200">				
					<? include "nav.php" ?>
			<!-- <hr class="mainsep" />	<hr class="mainsep"/> -->
			</td>
		</tr>
	</table>
</body>
</html>
