<!DOCTYPE html>
<html>
	<head>
		<title>The Daily Life - Registo</title>
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
				$option = $_GET['option'];
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
						<input type="text" name="text_search" maxlength="20"  pattern="^\w{1,20}$" required="required"/>
					</div>
				</form>
			 </div>
        </div>
       
        <div id="titulo_user">
            <h2>Registo de um novo utilizador</h2>
            <br />
        </div>
         <div id="registo_user">
             <form class="register" action="databaseaddUser.php" name="register" method="post">
                <?php
				if(($option == 3) || ($option == 2))
				{
				?>
					<div class="confirm_pass">
						<img src="danger.png" alt="Perigo" width="25" height="25"/>
						O nome de utilizador que tentou registar já existe na nossa base de dados!
					</div>
					<br />
					<br />
				<?php
				}
				?>
				* Nome de utilizador: <input type="text" size="45" name="name_user" pattern="^\w{8,32}$" maxlength="32" required="required" placeholder="caracteres alfanuméricos e 8 - 32 caracteres"/>
                <br />
				* Nome: <input type="text" name="full_name" maxlength="50" size="60"/>
                <br />
                E-mail(opcional): <input type="email" name="email_user" maxlength="40" size="50"/>
                <br />
                <br />
				<br />
				<br />
				<?php
				if(($option == 1) || ($option == 2))
				{
				?>
					<div class="confirm_pass">
						<img src="danger.png" alt="Perigo" width="25" height="25"/>
						As passwords que tentou escrever são diferentes!
					</div>
					<br />
					<br />
				<?php
				}
				?>
                * Password: <input type="password" name="pass_user" pattern="^\w{1,20}$" width="30" maxlength="20" required="required" placeholder="caracteres alfanuméricos"/>
				<br />
                * Confirmar password: <input type="password" name="confirm_pass_user" width="30" pattern="^\w{1,20}$" maxlength="20" required="required"/>
                <br />
                <br />
                <input class="button_r" type="submit" value="Registar-se" />
                <input class="button_c" type="submit" value="Cancelar" />
				<br />
                <br />
				<br />
                <br />
				<div class="suges_caract">
                    * Obrigatório
                </div>
            </form>
        </div>
    </body>
</html>
