<?
//include our settings, connect to database etc.
//include dirname($_SERVER['DOCUMENT_ROOT']).'/cfg/settings.php';
//getting required data
//$DATA=dbgetarr("SELECT * FROM links");
$pagetitle = "Download";
//etc
//and then call a template:
$tpl = "down.tpl.php";
include "template.php";
?>
