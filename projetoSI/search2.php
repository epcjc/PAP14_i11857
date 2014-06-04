<!DOCTYPE html>
<html>
	<head>
		<title>The Daily Life - Pesquisa</title>
		<meta charset="UTF-8">
		<link rel="stylesheet" href="style.css">
        <link rel="shortcut icon" href="favicon.ico">
	</head>
	<body>
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
				
				<?php
				if($_SESSION['type']==1)
				{
				
					?>
					<form class="registed_change" method="link" action="changePermitions.php">
						<input class="button_chan" type="submit" value="Alterar permiss�es">
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
			 	<form name="pesquisaavan�ada" method="post" action="advancedSearch.php">
					<div id="imagem">
						<input class="button_r" type="submit" value="Pesquisa Avan�ada">
					</div>
				</form>
				<form name="pesquisar" method="post" action="search.php">
					<div id="imagem">
						<input type="image" src="search.png" alt="Pesquisar" width="20" height="20"/>
					</div>
					<div id="text">
						<input type="text" name="text_search" maxlength="20" />
					</div>
				</form>
			 </div>
        </div>
       
		<div id="cabecalho">
			<?php
				$tag = $_GET['text_search'];
			?>
            <h3>Resultados da pesquisa <?=$tag?>: </h3>
		</div>
		<div id="conteudo">
			<?php
				$tag_str = $_GET['text_search'];
				$tag_str = strtolower($tag_str);
				$db = new PDO('sqlite:database.db');
				$query = "SELECT * FROM (news NATURAL JOIN tags) WHERE tag = '$tag_str' ORDER BY news_id DESC";
				$result = $db->query($query);
				
				foreach($result as $row)
				{
					?>
					
					<div class="noticia">
					<h4> <a href="newsId.php?news=<?=$row['news_id']?>"> <?=$row['title']?> </a> </h4>
					<p> <?=$row['text']?> </p>
					<?php
						$tag_query = "SELECT tag FROM (news NATURAL JOIN tags) WHERE news_id = $row[news_id] ";
						$tag = $db->query($tag_query);
						
						foreach($tag as $tag_row)
						{
						?>
							<p> <?=$tag_row['tag']?> </p>
						<?php
						}
						?>
					</div>
					<?php
				}		
			?>
		</div>
	</body>
</html>