<!DOCTYPE html>
<html>
	<head>
		<title>The Daily Life - Confirmação</title>
		<meta charset="UTF-8">
		<link rel="stylesheet" href="style.css">
        <link rel="shortcut icon" href="favicon.ico">
	</head>
	<body>
		<div id="image_title">
			<img src="logo_full.png" width="500px" height="250px" alt="The Daily Life logo" />
		</div>
		<div id="message">
			<?php
			$username = $_GET["user"];
			print "A conta de $username já se encontra registada no nosso sistema!!";
			?>
		</div>
		<form class="button_b" method="link" action="index.php">
			<input class="button" type="submit" name="voltar" value="Voltar" />
		</form>
	</body>
</html>