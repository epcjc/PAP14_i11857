<!DOCTYPE html>
<html>
	<head>
		<title>The Daily Life</title>
		<?php
			$news_id = $_GET['news'];
			$comment = $_GET['comment'];
		?>
		<meta charset="UTF-8">
		<link rel="stylesheet" href="style.css">
		<script type="text/javascript" src="lib/jquery.js">
		</script>
		<script type="text/javascript" src="script.js">
		</script>
        <link rel="shortcut icon" href="favicon.ico">
	</head>
	<body onload="loadComments(<?=$news_id?>)">
         <div id="registo">
			<div id="message">
			<?php
				session_start(); 
				$start = $_SESSION['type'];
				$name = $_SESSION['username'];
				if($_SESSION['username']){
				?>
				Bem vindo <?=$_SESSION['username']?>!
				<?php
				}
			?>
			</div>
			<div id="botoes">
			<?php
			if($_SESSION['username']){
			?>
				<form class="logout" method="link" action="logout.php">
					<input class="button_r" type="submit" value="Logout">
				</form>
				<form class="registed_change" method="post" action="profile.php?user=<?php echo $_SESSION['user_id']; ?>">
				    <input type="text" name="user" hidden="hidden" size="30px" value="<?php echo $_SESSION['user_id']; ?>"/>
					<input class="button_chan" type="submit" value="Alterar Perfil">
				</form>
				<form class="favorites" method="post" action="favoriteNews.php">
					<input class="button_chan" type="submit" value="Noticias favoritas">
				</form>
				
				<?php
				if($_SESSION['type']==1)
				{
				
					?>
					<form class="registed_change" method="link" action="changePermitions.php">
						<input class="button_chan" type="submit" value="Alterar permissões">
					</form>
					<form class="registed_change" method="link" action="addNews.php">
						<input class="button_chan" type="submit" value="Adicionar Noticia ">
					</form>
					<form class="registed_change" method="link" action="changeUsers.php">
						<input class="button_chan" type="submit" value="Alterar Perfil de um Utilizador">
					</form>
					<form class="registed_change" method="link" action="addServers.php">
						<input class="button_chan" type="submit" value="Importar">
					</form>
					<?php
				}
				?>
				
				<?php
					if ($_SESSION['type']==2){
					?>
						<form class="registed_change" method="link" action="addNews.php">
							<input class="button_chan" type="submit" value="Adicionar Noticia ">
						</form>
					<?php }
				?>
				
				<?php
			}
			else{
				$start = 0;
				?>
				<form class="signin" action="login.php" name="register" method="post">
					Utilizador: <input type="text" name="user" maxlength="100" />
					Password: <input type="password" name="pass" maxlength="100" />
					<input class="button_s" type="submit" value="Login" />
				</form>
				<form class="register" method="link" action="regist.php">
					<input class="button_r" type="submit" value="Registo">
				</form>
				<?php
			}
				?>
			 </div>
			 <div id="pesquisa">
			 	<form name="pesquisaavançada" method="post" action="advancedSearch.php">
					<div id="imagem">
						<input class="button_r" type="submit" value="Pesquisa Avançada">
					</div>
				</form>
				<form name="pesquisar" method="post" action="search.php">
					<div id="imagem">
						<input type="image" src="search.png" alt="Pesquisar" width="20" height="20"/>
					</div>
					<div id="text">
						<input type="text" name="text_search" maxlength="20" pattern="^\w{1,20}$" required="required"/>
					</div>
				</form>
			 </div>
        </div>
        
		<div id="cabecalho">
			<?php
				$db = new PDO('sqlite:database.db');
			?>	
		</div>
		<div id="conteudo">
			<?php
				$passa = 0;
				$db = new PDO('sqlite:database.db');
				$query = "SELECT * FROM news WHERE news_id = '$news_id'";
				$result = $db->query($query);
				
				if($start == 2 || $start == 1 || $start == 3)
				{			
					$query_name = "SELECT * FROM users WHERE username = '$name' ";
					$result_number_user = $db->query($query_name);
					
					foreach($result_number_user as $row_user)
					{
						$user_on_id = $row_user['user_id'];
						$fullname = $row_user['fullname'];
					}
				}
				
				foreach($result as $row)
				{
					?>
					
					<div class="noticia">
					<h4> <?=$row['title']?> </h4>
					<p> <?=$row['text']?> </p> 
					
					<br/>
					<div class="autor">
						<?php
							if($row['user_id'] != NULL)
							{
								$userID = $row['user_id'];
								$queryUsername = "Select * from users where user_id ='$userID'";
								$resultname = $db->query($queryUsername);
								foreach ($resultname as $nameuser)
								{
								?>
									<img src="user.png" alt="Autor" height="25" width="25" />
									<p><?=$nameuser['fullname']?> </p>
								<?php
								}
							}
							else
							{?>
								<img src="user.png" alt="Autor" height="25" width="25" />
								<p><?=$row['username']?> </p>
							<?php
							}
						?>
					</div>
					
					<div class="hora">
						<img src="lapis.png" alt="Tag" height="25" width="25" />
						<p><?=$row['t']?> </p>
					</div>
					
					<div class="url">
					<?php
						if($row['url'] == NULL)
						{?>
							<img src="url.png" alt="Hora de escrita" height="25" width="25" />
							<p>local </p>
						<?php
						}
						else if($row['url'] != NULL)
						{?>
							<img src="url.png" alt="Hora de escrita" height="25" width="25" />
							<p><?=$row['url']?> </p>
						<?php
						}
						?>
					</div>
					
					<?php
					
					$tag_query = "SELECT tag FROM (news NATURAL JOIN tags) WHERE news_id = $row[news_id] ";
					$tag = $db->query($tag_query);
						
					foreach($tag as $tag_row)
					{
					?>
						<div class="tag_img">
							<img src="tags.png" alt="Tag" height="25" width="25" />
							<p> <?=$tag_row['tag']?> </p>
						</div>
					<?php
					}
					if ($start == 1 || ($start == 2 && $userID == $_SESSION['user_id'])){
					?>
						<div id="botoes">
							<form class="registed_change" method="post" action="editNews.php">
								<input type="text" name="newsid" hidden="hidden" size="30px" value="<?php echo $news_id ?>"/>
								<input class="button_chan" type="submit" value="Editar Noticia">
							</form>
							<form class="delete_news" method="post" action="deleteNews.php">
								<input type="text" name="newsid" hidden="hidden" size="30px" value="<?php echo $news_id ?>"/>
								<input class="button_chan" type="submit" value="Eliminar Noticia">
							</form>
						</div>
						<?php
						}
					if($start == 2 || $start == 1 || $start == 3)
					{
						$query_like = "SELECT * FROM favoritos WHERE news_id = $row[news_id] AND user_id = $user_on_id";
						$like = $db->query($query_like);
						
						foreach($like as $query_like_row)
						{
							$passa = 1;
						}
						
						if($passa == 0)
						{
							?>
							<form id="like_id" method="post">
								<input id=<?=$row['news_id']?>, type="image" src="like_cont.png" alt="Like" width="25" height="25" onclick="putLike(<?=$row['news_id']?>, <?=$user_on_id?>);return false"/>
							</form>
							<?php
						}
						else if($passa == 1)
						{
							?>
							<form id="like_id" method="post">
								<input id=<?=$row['news_id']?>, type="image" src="like.png" alt="Dislike" width="25" height="25" onclick="putLike(<?=$row['news_id']?>, <?=$user_on_id?>);return false"/>
							</form>
							<?php
						}
						
						?>
						<form id="comentario_img" method="post">
							<img src="comentario.png" width="50px" height="50px" alt="Comentario" />
							<?php
							if($comment == 1)
							{
								
								?>
									<textarea id="comment" name="text" rows="7" cols="80" autofocus="autofocus"> </textarea>
								<?php
								
							}
							else if($comment == 0)
							{
								?>
									<textarea id="comment" name="text" rows="7" cols="80" autofocus="autofocus"> </textarea>
								<?php
							}
							?>
							</br>
							</br>
							<button id="button_r" onClick="putComment(text ,<?=$user_on_id?>, <?=$row['news_id']?>);return false"> Adicionar comentário </button>
						</form>				
					
					<?php
						
					}
					else
					{?>
						<div id="comentario_img2">
						<img src="comentario.png" width="40px" height="40px" alt="Comentario" />
						</div>
					<?php
					}
					?>
					<div class="comments_show"> </div>
					</div>
					<?php
					$passa = 0;
				}		
			?>
		</div>
	</body>
</html>