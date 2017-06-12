<?php
$path = "/home/user/Dokumente/Filme/";
$vid_name = $_GET["vid"];
$ex = '/var/www/html/EzStream/call.sh /home/user/Dokumente/Filme/'.$vid_name;
echo $ex;
shell_exec($ex);
header('Location: video.html');
exit
?>
