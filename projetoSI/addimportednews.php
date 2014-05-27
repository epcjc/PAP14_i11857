<?php
	$db = new PDO('sqlite:database.db');
	
	$title = $_POST['title'];
	$text = $_POST['text'];
	$date = $_POST['date'];
	$author = $_POST['user_author'];
	
	$query_news = "SELECT * FROM news WHERE news.title = '$title' AND news.text = '$text' AND news.username = '$author' AND news.t = '$date' AND news.url = '$url'";
	$news = $db->query($query_news);
	
	$size = count($news->fetchAll());
	
	if($size == 0)
	{
		$insert = "INSERT into news values(NULL,'$title','$text', NULL, '$author','$url', '$date')";
		$db->exec($insert);
	}
	
	echo json_encode(array(result => 'OK'));
?>