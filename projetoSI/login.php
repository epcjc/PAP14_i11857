<?php 

 	session_start(); 
 	
 	$db = new PDO('sqlite:database.db');

 	$username = $_POST['user'];
	
	$password = $_POST['pass'];
	
	$query = "SELECT * FROM users where username ='$username' ";
	
	$result = $db->query($query);
 	
 	$result2 = $result->fetch(PDO::FETCH_ASSOC);
 	
 	
 	if($result2['username'] == $username){
 		if($result2['password'] == $password){
	 			$_SESSION['username'] = $username;
	 			$_SESSION['type'] = $result2['type'];
	 			$_SESSION['user_id'] = $result2['user_id'];
	 		}
 	}
 	header("location:index.php");
?>