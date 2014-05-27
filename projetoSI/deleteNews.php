<?php
	$news_id = $_POST['newsid'];
	$db = new PDO('sqlite:database.db');
	
	$delete = "DELETE FROM news WHERE news.news_id = '$news_id'";
	$db->exec($delete);
	
	$goto = "location:index.php";
	header($goto);	
?>