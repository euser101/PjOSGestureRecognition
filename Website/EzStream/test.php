<?php
//$res = shell_exec('/var/www/html/EzStream/call.sh', /home/user/Dokumente/Filme);
//echo $res;
$path = "/home/user/Dokumente/Filme/";
$vid_name = $_GET["vid"];
$ex = '/var/www/html/EzStream/call.sh /home/user/Dokumente/Filme/'.$vid_name;
echo $ex;
shell_exec($ex);
?>
