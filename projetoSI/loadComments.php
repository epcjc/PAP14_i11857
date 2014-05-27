<?php
	header('Content-Type: application/json');
	
	session_start(); 
	$db = new PDO('sqlite:database.db');
	$news_id = $_GET['news'];
	
	$type_session = $_SESSION['type'];
	$username_session = $_SESSION['username'];
	
	$user_fullname = "";
	$username = "";
	
	$query_comments = "SELECT * FROM comments WHERE news_id = '$news_id' ORDER BY comments_id DESC";
	$comments = $db->query($query_comments);
	
	$query_write = "SELECT * FROM (news NATURAL JOIN users) WHERE news_id = '$news_id' AND username = '$username_session'";
	$write = $db->query($query_write);		
	$size = count($write->fetchAll());
	
	$array_comments = array();
	$array_valid_comments = array();
	
	foreach($comments as $row_comments)
	{
		$query_users = "SELECT * FROM users WHERE user_id = ";
		$query_users .= $row_comments['autor'];
		
		$users = $db->query($query_users);
		
		foreach($users as $row_users)
		{	
			$user_fullname = $row_users['fullname'];
			$username = $row_users['username'];
		}
		
		$array_comments[] = array(autor=> $user_fullname, comment => $row_comments['text'], id => $row_comments['comments_id']);
		
		if($type_session == 1)
		{	
			$array_valid_comments[] = array(autor=> $user_fullname, comment => $row_comments['text'], id => $row_comments['comments_id']);
		}
		else if($type_session == 2)
		{	
			if($size > 0)
			{
				$array_valid_comments[] = array(autor=> $user_fullname, comment => $row_comments['text'], id => $row_comments['comments_id']);
			}
			else if($size == 0)
			{
				if($username == $username_session)
				{
					$array_valid_comments[] = array(autor=> $user_fullname, comment => $row_comments['text'], id => $row_comments['comments_id']);
				}
			}
		}
		else if($type_session == 3)
		{
			if($username == $username_session)
			{
				$array_valid_comments[] = array(autor=> $user_fullname, comment => $row_comments['text'], id => $row_comments['comments_id']);
			}
		}
	}
	echo json_encode(array(result => 'OK', data_comments => $array_comments, data_valid_comments => $array_valid_comments));
?>