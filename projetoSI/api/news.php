<?php 

 	session_start();
	$db = new PDO('sqlite:../database.db');
	
	$initTime = $_GET['start_date'];
	$finalTime = $_GET['end_date'];
	$tags = $_GET['tags'];
	$parsedtags = preg_split('/[,.\s;]+/', $tags);
	
	if (count($parsedtags) > 0)
	{
    $where .= " where ";
    for ($i = 0; $i < count($parsedtags); $i++)
    {
       $where .= " tag = '" . $parsedtags[$i] ."'";

       if ($i < count($parsedtags) - 1)
            $where .= " or ";
    }
    }
	
	$query = "SELECT * FROM (
					(Select * from news where t between datetime('$initTime') and datetime('$finalTime'))
					NATURAL JOIN tags) $where ORDER BY news_id DESC";
	echo $query;
	$o = array();
	$result =$db->query($query);	
	
	$data  = array();
	
	foreach($result as $row){
		$userID = $row['user_id'];
		$queryUsername = "Select * from users where user_id ='$userID'";
		$resultname = $db->query($queryUsername);
		$tags = array();
		
		$tag_query = "SELECT tag FROM (news NATURAL JOIN tags) WHERE news_id = $row[news_id] ";
		$tag = $db->query($tag_query);
						
		foreach($tag as $tag_row)
		{
			$tags[] = $tag_row['tag'];
		}
		
		foreach ($resultname as $nameuser){
			$newsusername = $nameuser['fullname'];
		}
		$data[] = array(id => $row['news_id'],title=>$row['title'],date=>$row['t'],text=>$row['text'],posted_by=>$newsusername,url=>"https://paginas.fe.up.pt/~ei10044/thedailynews",tags=>$tags);
	}
		$o = array(result => "success", server_name => "Grupo04",data=>$data);

	echo json_encode($o);
?>