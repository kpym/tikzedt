<?
//include our settings, connect to database etc.
//include dirname($_SERVER['DOCUMENT_ROOT']).'/cfg/settings.php';
//getting required data
//$DATA=dbgetarr("SELECT * FROM links");
$pagetitle = "Documentation";
//etc
//and then call a template:
$tpl = "doc.tpl.php";
include "template.php";
?>
