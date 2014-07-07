<?php require_once( 'couch/cms.php' ); ?> <!-- CMS - Configuração da página --> 
<!--[if lt IE 7]>       
<html class="no-js lt-ie9 lt-ie8 lt-ie7">
<![endif]-->
<!--[if IE 7]>         
<html class="no-js lt-ie9 lt-ie8">
<![endif]-->
<!--[if IE 8]>         
<html class="no-js lt-ie9">
<![endif]-->
<!--[if gt IE 8]><!--> 
<html class="no-js">
   <!--<![endif]-->
   <head>
      <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
      <title>The Daily Life</title>
      <meta name="description" content="The Daily Life - Online Magazine">
      <meta name="viewport" content="width=device-width">
      <link rel="stylesheet" href="css/bootstrap.min.css">
      <link rel="stylesheet" href="css/bootstrap-theme.css">
      <link rel="stylesheet" href="css/normalize.css">
      <link rel="stylesheet" href="fonts/font-awesome/css/font-awesome.min.css">
      <link rel="stylesheet" href="css/main.css">
      <link rel="stylesheet" href="css/responsive.css">
      <link rel="stylesheet" href="css/calendar.css">
      <cms:template clonable='1' > </cms:template> <!-- CMS - Com este codigo é possivel replicar está página --> 

      <!--[if gt IE 7]>
      <link rel="stylesheet" type="text/css" href="css/ie.css" />
      <![endif]-->
      <script src="js/vendor/modernizr-2.6.2-respond-1.1.0.min.js"></script>
   </head>
   <body>
      <!-- Main Home Layout start -->      
      <!-- Top toolbar -->
      <div class="top-tool-bar">
         <nav class="navbar navbar-default" role="navigation">
            <div class="container">
               <!-- Toolbar get grouped for better mobile display -->
               <div class="navbar-header">
                  <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                  <span class="sr-only">Toggle navigation</span>
                  <span class="icon-bar"></span>
                  <span class="icon-bar"></span>
                  <span class="icon-bar"></span>
                  </button>
               </div>
               <!-- Barra Superior (Login) -->
                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                  <ul class="nav navbar-nav righty">
                     <li><a href="http://projetos.epcjc.net/~i11857/couch/">Log in</a></li>
                  </ul>
               </div>
               <!-- /.navbar-collapse -->
            </div>
            <!-- /.container-fluid -->
         </nav>
      </div>
      <!-- Logo and Ad banner -->
      <div class="logo-top-ad">
         <div class="container">
            <div class="row">
               <!-- The Daily Life Logo -->
               <div class="logo col-lg-4">
                  <a href="index.php"><img alt="" src="img/logo.png" /></a>
               </div>
               <div class="top-banner col-lg-8">
             <!-- Banner topo de página sem CMS -->
                <a href="#"><img alt="" src="img/top-banner.jpg" /></a>
               </div>
            </div>
         </div>
      </div>
      <!-- Menu -->
      <div class="main-menu">
         <div class="container">
            <div class="row">
               <div class="col-lg-8">
                  <!-- Menu -->
                  <ul id="main-menu-items" class="sm sm-menu menu-efct">
                     <li><a href="index.php">Início</a></li>
                     <li><a href="categoria.php?p=43">Mundo</a></li>
                     <li><a href="categoria.php?p=42">País</a></li>
                     <li><a href="categoria.php?p=41">Paredes</a></li>
                     <li><a href="categoria.php?p=40">Desporto</a></li>
                     <li><a href="categoria.php?p=39">Programação</a></li>
                     <li><a href="categoria.php?p=23">Mundial 2014</a></li>
                  </ul>
               </div>
            </div>           
            <!-- Close the Fixed Menu button -->
            <a class="fxd-mnu-x trans1" title="Close" id="hidemenu"><span class="fa-stack fa-lg"> <i class="fa fa-times fa-stack-1x fa-inverse"></i> </span></a>
         </div>
      </div>
      <!-- Main Body -->
      <div class="container">
         <!-- Main Left side -->
         <div class="main-left-side">
            <!-- Single Category - Top News -->
            <div class="top-news float-width">
            </div>
            <!-- Bloco Categoria -->
            <div class="news-sec-1 float-width">
               <div class="float-width sec-cont2">
<!-- CMS - Gestor do Bloco de Categorias / Gestor de Texto Simples para uma fácil introdução de texto, imagens, Flash, Links, Quebras de página Etc  -->
				<cms:editable name='main_content' type='richtext'> original content </cms:editable>	</div>
            </div>
         </div>
         <br>
         <div class="main-right-side">
            <!-- Slide de Imagens s/Gestor de Conteudos -->
            <div class="sm-sldr-box float-width">
               <div class="flexslider sm-sldr">
                  <ul class="slides">
                     <li>
                        <img alt="" src="img/samples/z2.jpg" />
                     </li>
                     <li>
                        <img alt="" src="img/samples/z2.jpg" />
                     </li>
                  </ul>
               </div>
            </div>
            <!-- Iframe c/ Metereologia da Zona do Porto -->
<span style="display: block !important; width: 180px; text-align: center; font-family: sans-serif; font-size: 12px;"><a href="http://www.wunderground.com/cgi-bin/findweather/getForecast?query=zmw:00000.1.08545&bannertypeclick=wu_travel_globe1" title="Porto, Portugal Weather Forecast" target="_blank"><img src="http://weathersticker.wunderground.com/weathersticker/cgi-bin/banner/ban/wxBanner?bannertype=wu_travel_globe1_metric&airportcode=LPPR&ForcedCity=Porto&ForcedState=Portugal&wmo=08545&language=BR" alt="Find more about Weather in Porto, PO" width="230" /></a><br><a href="http://www.wunderground.com/cgi-bin/findweather/getForecast?query=zmw:00000.1.08545&bannertypeclick=wu_travel_globe1" title="Get latest Weather Forecast updates" style="font-family: sans-serif; font-size: 12px" target="_blank"></a></span>
            <!-- Subscrição da Newslleter -->
            <div class="subscribe lefty">
               <h3 class="sec-title">NEWSLETTER</h3>
               <h6>Estará disponivel brevemente a subscrição da newsletter.</h6>
            </div>
            <!-- Banner lado direito inferior S/ Gestor de conteudos -->
            <div class="lefty ad-rt">
               <a href="#"><img alt="" src="img/samples/u1.jpg" /></a>
            </div>
         </div>
      </div>
      <!-- Rodapé -->
      <div class="copy-rt-ftr">
         <div class="container">
            <a class="lefty"><img src="img/logotipo_rodape.png">Todos os direitos reservados.</a>
            <a class="righty"><img src="img/logotipo_rodape_esqueda.png">by: Ruben Pacheco</a>
         </div>
      </div>
      <!-- Java Script necessários -->   
      <script src="js/vendor/jquery-1.10.1.min.js"></script>
      <script src="js/vendor/bootstrap.min.js"></script>
      <script src="js/jquery.smartmenus.min.js"></script>
      <script src="js/jquery.flexslider-min.js"></script>
      <script src="js/newsTicker.js"></script>
      <script src="js/jquery.customSelect.min.js"></script>
      <script src="js/retina-1.1.0.min.js"></script>
      <script src="js/jflickrfeed.min.js"></script>
      <script src="js/calendar.js"></script>
      <script src="js/placeholders.min.js"></script>
      <script src="js/main.js"></script>
   </body>
<?php COUCH::invoke(); ?>  <!-- CMS - Configuração da página --> 