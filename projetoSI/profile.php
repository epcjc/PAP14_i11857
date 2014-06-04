<!DOCTYPE html>
<html>

<?php
				session_start();
				$start = $_SESSION['type'];
				$name = $_SESSION['username'];
				if($start != 1 && $start!= 2 && $start != 3){
						?>
						<body style="background-color:#fff">
<br/><br/>
<div align="center">
<table><tr><td width="600px">
<style type="text/css">
img {
width:100%;
}
</style>
<center><img id="errorimage" src="404.png"/></center>
<div id="errorbox">
<h1>Error (404)</h1>We can't find the page you're looking for. Go back to our <a href="index.php">Main Page</a> or <a href="help.php">Help</a> for see my permitions.
</div>
</td></tr></table>
</div>

</body>	<?php
						exit;
					}
				
				?>

	<head>
		<title>The Daily Life - Alterar perfil</title>
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

		<div id="cabecalho">
			<?php
				$user_id = $_GET['user'];
			?>
		</div>
		<div id="conteudo">
			<?php
				$db = new PDO('sqlite:database.db');
				$query = "SELECT * FROM users WHERE user_id = '$user_id'";
				$result = $db->query($query);
				foreach($result as $row)
				{
					if($row['type'] == 1){
						$type = "Administrador";
					}
					else if($row['type']==2){
						$type = "Editor";
					}
					else{
						$type = "Utilizador";
					}				
					?>				
					            <form class="register" action="changeUserScript.php?user=<?=$row['username']?>" name="link" method="post">
					            	Id do utilizador: <input type="text" name="id" disabled="disabled" size="30px" value="<?php echo $user_id; ?>"/> 
									<br/>
									<br/>
									<br/>
					            	<input type="text" name="userid" hidden="hidden" size="30px" value="<?php echo $user_id; ?>"/>
						            Nome de utilizador: <input type="text" name="username" size="45" value="<?php echo $row['username']; ?>" pattern="^\w{8,32}$" required="required" placeholder="caracteres alfanuméricos e 8 - 32 caracteres"/> 
									<br/>
									<br/>
									<br/>
						            Nome completo: <input type="text" name="fullname" size="30" value="<?php echo $row['fullname']; ?>"/> 
									<br/>
									<br/>
									<br/>
						            Password: <input type="password" name="password" size="30" value="<?php echo $row['password']; ?>" pattern="^\w{1,20}$" required="required" placeholder="caracteres alfanuméricos"/> 
									<br/>
									<br/>
									<br/>
						            Permissoes: <input type="text" name="permissoes" disabled="disabled" size="30px" value="<?php echo $type; ?>"/> 
									<br/>
									<br/>
									<br/>
									<br/>
						            <input class="button_c" type="submit" value="Alterar perfil" />
							    </form>
					<?php
					
						}
					?>
		</div>
	</body>
</html>