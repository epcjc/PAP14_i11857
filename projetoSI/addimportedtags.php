<?php
	$db = new PDO('sqlite:database.db');
	
	$tag = $_POST['tag'];
	$date = $_POST['date'];
	$author = $_POST['user_author'];
	
	$query_tags = "SELECT * FROM news WHERE news.t = '$date' AND news.username = '$author'";
	$tags = $db->query($query_tags);
	$news_id = 0;
	
	foreach($tags as $row_tags)
	{
		$news_id = $row_tags['news_id'];
	}
	
	$query_tags_verify = "SELECT * FROM tags WHERE tags.news_id = '$news_id'";
	$tags_verify = $db->query($query_tags_verify);
	
	$size = count($tags_verify->fetchAll());
	
	if($size == 0)
	{
		$insert = "INSERT into tags values(NULL, '$news_id', '$tag')";
		$db->exec($insert);
	}
	
	echo json_encode(array(result => 'OK'));
?>