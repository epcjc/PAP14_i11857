<?php
	$db = new PDO('sqlite:database.db');
	
	$comment_id = $_POST['comment'];
	$news_id = $_POST['news'];
	
	$delete = "DELETE FROM comments WHERE comments_id = '$comment_id'";
	$db->exec($delete);
	
	header("Location:loadComments.php?news=$news_id");
?>