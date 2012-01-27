<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<LINK href="style.css" rel="stylesheet" type="text/css">
	<link rel="icon" type="image/vnd.microsoft.icon" href="img/logo.ico">
<title>TikzEdt. <?=$pagetitle?></title>
</head>
<body>
<div id="box">
  <div id="header">
     <? include "header.html" ?><!---->
  </div>
  <div id="hsep" />
  <div id="nav">
    <? include "nav.php" ?>
  </div>
  <div id="page">
    <? include $tpl ?>
  </div>
</div>
</body>
</html>
