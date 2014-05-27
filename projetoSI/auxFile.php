<?php
	$type = $_POST['type'];
	$user_id = $_POST['user'];
	
	if($type == "Alterar perfil")
	{
		header("location:profile.php?user=$user_id");
	}
	else if($type == "Eliminar")
	{
		header("location:databaseDeleteUsers.php?user=$user_id");
	}
?>