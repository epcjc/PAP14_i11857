<?php
	$db = new PDO('sqlite:database.db');
	
	$user_id = $_POST['user'];
	$text = $_POST['text'];
	$news_id = $_POST['news'];
	
	$add = "INSERT INTO comments VALUES (NULL, '$news_id', '$user_id', '$text')";
	$db->exec($add);
	
	header("Location:loadComments.php?news=$news_id");
?>