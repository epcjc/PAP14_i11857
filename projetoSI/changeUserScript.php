<?php
 	session_start(); 
	$id= $_POST['userid'];
	$actual_user = $_GET['user'];
	$username = $_POST['username'];
	$fullname = $_POST['fullname'];
	$password = $_POST['password'];
	$db = new PDO('sqlite:database.db');
	
	$query_user = "SELECT * FROM users WHERE username = '$username'";
	$user = $db->query($query_user);
	
	$size = count($user->fetchAll());
	
	if($size == 0)
	{
		$query = "UPDATE users SET username='$username', fullname = '$fullname', password ='$password' WHERE user_id='$id'";
		$db->exec($query);
		header("location:index.php");
	}
	else if($actual_user == $username)
	{
		$query = "UPDATE users SET username='$username', fullname = '$fullname', password ='$password' WHERE user_id='$id'";
		$db->exec($query);
		header("location:index.php");
	}
	else
	{
		header("location:profileWrong.php?user=$id");
	}
?>