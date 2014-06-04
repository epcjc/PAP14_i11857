<!DOCTYPE html>
<html>
	<head>
		<title>The Daily Life - Página Inicial</title>
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
       
		<div id="conteudo">
					
					<div class="servers">
					
					
					<?php
						$db = new PDO('sqlite:database.db');
						$servers_query = "SELECT * FROM servers";
						$servers = $db->query($servers_query);
						?>
						<table>
						<tr>
							<td> Hostname </td>
							<td> URL </td>
						</tr>
						<?php
						foreach($servers as $server_row)
						{
							$serverurl = $server_row['url'];
							$servername = $server_row['name'];
						?>
						<tr>
						<td><?php print $servername;?></td>
						<td><?=$serverurl?></td>
						</tr>
						<?php
						}
						?>
						</table>
						</div>
			</div>
		</div>
	</body>
</html>