<?php 

 	session_start();
	$db = new PDO('sqlite:database.db');
	$query = "SELECT * FROM news";
	$result = $db->query($query);
	$last = 0;
	foreach($result as $row)
	{
		$last = $row['news_id'];
	}
	echo $last;

?>