<?php 

 	session_start();
	$db = new PDO('sqlite:database.db');
	$title = $_POST['titulo'];
	$text = $_POST['text'];
	$tags = $_POST['tags'];
	$user = $_SESSION['user_id'];
	$parsedtags = preg_split('/[,.\s;]+/', $tags);
	$idauthor = $_SESSION['user_id'];
	$insert = "INSERT into news values(NULL,'$title','$text','$idauthor', NULL, NULL, DATETIME('now'))";
	$db->exec($insert);
	$query = "SELECT * FROM news where title ='$title' ";
	$result = $db->query($query) or die("ERRO");
 	$result2 = $result->fetch(PDO::FETCH_ASSOC);
 	$idnews = $result2['news_id'];
	foreach($parsedtags as $tagsinto){
		$tagsinto = strtolower($tagsinto);
		$insert = "INSERT into tags values(NULL,'$idnews','$tagsinto')";
		$db->exec($insert);
	}
	
	echo json_encode(array(result => 'OK'));
?>