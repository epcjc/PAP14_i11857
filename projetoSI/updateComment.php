<?php
	$db = new PDO('sqlite:database.db');
	
	$comment_id = $_POST['comment'];
	$text = $_POST['text'];
	$news_id = $_POST['news'];
	
	$update = "UPDATE comments SET text='$text' WHERE comments_id = '$comment_id' AND news_id = '$news_id'";
	$db->exec($update);
	
	header("Location:loadComments.php?news=$news_id");
?>