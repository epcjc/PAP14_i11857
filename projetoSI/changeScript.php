<?php
	session_start();
	$username = $_POST["name_user"];
	$type = $_POST["type"];
	if($type == "Utilizador"){
		$change = 3;
	}
	else if($type == "Editor"){
		$change = 2;
	}
	else{
		$change = 1;
	}
	$db = new PDO('sqlite:database.db');
	$query = "UPDATE users SET type='$change' WHERE username='$username'";
	$db->exec($query);
	header("location:changePermitions.php");
?>