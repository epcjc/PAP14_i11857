<?php
	session_start();
	$id = $_POST['newsid'];
	$title = $_POST['titulo'];
	$text = $_POST['text'];
	$tags = $_POST['tags'];
	$parsedtags = preg_split('/[,.\s;]+/', $tags);
	$db = new PDO('sqlite:database.db');
	$query = "UPDATE news SET title='$title',text='$text' WHERE news_id='$id'";
	$db->exec($query);
	$deleteTags = "delete from tags where news_id='$id'";
	$db->exec($deleteTags);
	foreach($parsedtags as $tagsinto){
		$tagsinto = strtolower($tagsinto);
		$insert = "INSERT into tags values(NULL,'$id','$tagsinto')";
		$db->exec($insert);
	}
	$goto = "location:newsId.php?news=".$id;
	header($goto);
?>