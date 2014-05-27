<?php 

 	session_start();
	$db = new PDO('sqlite:database.db');
	$name = $_POST['hostname'];
	$url = $_POST['site'];
	$user = $_SESSION['user_id'];
	$idauthor = $_SESSION['user_id'];
	$insert = "INSERT into servers values(NULL,'$name')";
	$db->exec($insert);
	$goto="location:showServers.php";
	header($goto);
?>