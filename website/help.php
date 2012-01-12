<?
//include our settings, connect to database etc.
//include dirname($_SERVER['DOCUMENT_ROOT']).'/cfg/settings.php';
//getting required data
//$DATA=dbgetarr("SELECT * FROM links");
$pagetitle = "Help and Bug Reporting";
//etc
//and then call a template:
$tpl = "help.tpl.php";
include "template.php";
?>
