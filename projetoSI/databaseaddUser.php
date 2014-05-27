<?php 

 	session_start(); 
 	
 	$db = new PDO('sqlite:database.db');

 	$username = $_POST['name_user'];
	$password = $_POST['pass_user'];
	$fullname = $_POST['full_name'];
	$confirm_password = $_POST['confirm_pass_user'];
	
	$query_user = "SELECT * FROM users WHERE username = '$username'";
	$user = $db->query($query_user);
	
	$size = count($user->fetchAll());
	
	if(($password == $confirm_password) && ($size == 0))
	{
		$type = 3;
		
		$insert = "INSERT into users values(NULL,'$username','$fullname','$password','$type','$state')";
		
		$db->exec($insert);
	
		$goto = "location:confirmation.php?user=$username";
	}
	else if (($password == $confirm_password) && ($size != 0))
	{
		$goto = "location:registWrong.php?option=3";
	}
	else if (($password != $confirm_password) && ($size == 0))
	{
		$goto = "location:registWrong.php?option=1";
	}
	else if (($password != $confirm_password) && ($size != 0))
	{
		$goto = "location:registWrong.php?option=2";
	}
	
 	header($goto);	
?>