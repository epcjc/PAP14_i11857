<?php
	session_start();
	$user_id_session = $_SESSION['user_id'];
	$user_id = $_GET['user'];
	$db = new PDO('sqlite:database.db');
	
	if($user_id_session == $user_id)
	{
		$goto = "location:changeUsersWrong.php";
	}
	else if($user_id_session != $user_id)
	{
		$delete = "DELETE FROM users WHERE users.user_id = '$user_id'";
		$delete_news = "DELETE FROM news WHERE news.user_id = '$user_id'";
		$delete_comments = "DELETE FROM comments WHERE comments.autor = '$user_id'";
		
		$db->exec($delete);
		$db->exec($delete_news);
		$db->exec($delete_comments);
	
		$goto = "location:index.php";
	}
	
	header($goto);	
?>