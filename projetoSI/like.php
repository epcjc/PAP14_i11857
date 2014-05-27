<?php
	
	$db = new PDO('sqlite:database.db');
	$passa = 0;

 	$news_id = $_POST['news'];
	$user_id = $_POST['user'];
	
	$query_like = "SELECT * FROM favoritos WHERE news_id = $news_id AND user_id = $user_id";
	$like = $db->query($query_like);
						
	foreach($like as $query_like_row)
	{
		$passa = 1;
	}
	
	if($passa == 0)
	{
		$add = "INSERT INTO favoritos VALUES (NULL, '$user_id', '$news_id')";
		$db->exec($add);
	}
	else if($passa == 1)
	{
		$del = "DELETE FROM favoritos WHERE news_id = $news_id AND user_id = $user_id";
		$db->exec($del);
	}

?>