<?
//include our settings, connect to database etc.
//include dirname($_SERVER['DOCUMENT_ROOT']).'/cfg/settings.php';
//getting required data
//$DATA=dbgetarr("SELECT * FROM links");
$pagetitle = "Quick Tour";
//etc
//and then call a template:
$tpl = "quicktour.tpl.php";
include "template.php";
?>
