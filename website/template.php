<!DOCTYPE html>
<html>
<head>
	<link href="style.css" rel="stylesheet" type="text/css" />
	<link rel="icon" type="image/vnd.microsoft.icon" href="img/logo.ico" />
<title>TikzEdt. <?=$pagetitle?></title>
</head>
<body>
	<table id="maintable">
		<tr>
			<td style="border-bottom:solid 1px black;height:100px;">
				 <? include "header.html" ?><!---->
			</td>
            <td style="border-bottom:solid 1px black; border-left:solid 1px black;" width="200"></td>
		</tr>
		<tr>			
			<td style="vertical-align:top; margin-top:20px;">
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
