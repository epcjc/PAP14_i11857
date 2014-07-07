<?php require_once( 'couch/cms.php' ); ?><!-- CMS - Configuração da página --> 
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
      <meta name="description" content="The Daily Life - Online Magazine.">
      <meta name="viewport" content="width=device-width">
      <link rel="stylesheet" href="css/bootstrap.min.css">
      <link rel="stylesheet" href="css/bootstrap-theme.css">
      <link rel="stylesheet" href="css/normalize.css">
      <link rel="stylesheet" href="fonts/font-awesome/css/font-awesome.min.css">
      <link rel="stylesheet" href="css/main.css">
      <link rel="stylesheet" href="css/responsive.css">
      <link rel="stylesheet" href="css/calendar.css">
      <cms:template clonable='1' > </cms:template>
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
                     <li><a href="http://projetos.epcjc.net/couch/">Log in</a></li>
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
                  <!-- CMS - Banner c/ Gestor de conteudos complexo (Texto) -->
<cms:editable  name='banner_topo' label='Banner Topo' desc='Insira a imagem respeitando as medidas abaixo apresentafas' type='richtext'>
    "No caso de um banner publicitário, deverá introduzir a imagem, introduzir o Link, e colucar a anotação "publicidade" (NÃO SE ESQUEÇA DE ELIMINAR ESTA ANOTAÇÃO </cms:editable>              
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
            <!-- ARTIGO -->
            <div class="artcl-main float-width">
               <div class="artcl-prev-nxt float-width">
               </div>
               <div class="artcl-body float-width">
<cms:editable  name='prop_desc' label='Notícia' desc='Insira abaixo uma nova notícia (Siga o esquema apresentado)' type='richtext'>
    "Insira o texto que pretende para gerar uma nova notícia" Esquema: TITULO  >>  IMAGEM  >> TEXTO </cms:editable>  <!-- CMS - GESTOR DE TEXTO PARA A NOTICIA. Possibilidade de introduzir Texto, imagem, links, Flash, etc... --> 
    		   </div>
            </div>
            <!-- ARTIGOS RELACIONADOS A NOTICIA INTRODUZIDA / ABAIXO SÃO APRESENTADOS CMS DE IMAGEM & TEXTO C/GESTOR DE TEXTO VER ANOTAÇÃO ABAIXO  -->
            <div class="artcl-reltd float-width">
               <h3 class="sec-title">Relacionados</h3>
               <div class="reltd-sngl">
<cms:editable  name='relacionados_1' label='Relacionado 1' desc='Inserir apenas ficheiros de imagem com a dimensão igual ou inferior a 107px*85px' type='richtext'><!-- CMS - GESTOR DE IMAGEM (IGUAL NO CODIGO "ARTIGOS RELACIONADOS") --> 
    "Insira Ficheiro de imagem Nrº1 </cms:editable>              
                  <div class="reltd-sngl-txt">
                    <cms:editable  name='titulo_relacionados1' label='Titulo relacionados 1' desc='O numero maximo de caracteres para este titulo são de  são 80.'  type='richtext'> "Insira titulo nrº1 - Tipo de Letra a utilizar HEADING3 </cms:editable> <!-- CMS - GESTOR DE IEXTO (IGUAL NO CODIGO "ARTIGOS RELACIONADOS") -->              
                  </div>
               </div>
               <div class="reltd-sngl">
<cms:editable  name='relacionados_2' label='Relacionado 2' desc='Inserir apenas ficheiros de imagem com a dimensão igual ou inferior a 107px*85px' type='richtext'>
    "Insira Ficheiro de imagem Nrº2 </cms:editable>              
                  <div class="reltd-sngl-txt">
                    <cms:editable  name='titulo_relacionados2' label='Titulo relacionados 2' desc='O numero maximo de caracteres para este titulo são de  são 80.'  type='richtext'> "Insira titulo nrº2 - Tipo de Letra a utilizar HEADING3 </cms:editable>              
                  </div>
               </div>
               <div class="reltd-sngl">
<cms:editable  name='relacionados_3' label='Relacionado 3' desc='Inserir apenas ficheiros de imagem com a dimensão igual ou inferior a 107px*85px' type='richtext'> "Insira Ficheiro de imagem Nrº3 </cms:editable>              
                  <div class="reltd-sngl-txt">
                    <cms:editable  name='titulo_relacionados3' label='Titulo relacionados 3' desc='O numero maximo de caracteres para este titulo são de  são 80.'  type='richtext'> "Insira titulo nrº3 - Tipo de Letra a utilizar HEADING3 </cms:editable>              
                  </div>
               </div>
               <div class="reltd-sngl">
<cms:editable  name='relacionados_4' label='Relacionado 4' desc='Inserir apenas ficheiros de imagem com a dimensão igual ou inferior a 107px*85px' type='richtext'>"Insira Ficheiro de imagem Nrº4 </cms:editable>              
                  <div class="reltd-sngl-txt">
                    <cms:editable  name='titulo_relacionados4' label='Titulo relacionados 4' desc='O numero maximo de caracteres para este titulo são de  são 80.'  type='richtext'> "Insira titulo nrº4 - Tipo de Letra a utilizar HEADING3 </cms:editable>              
                  </div>
               </div>
            </div>
         </div>
         <!-- Main Right side -->
         <div class="main-right-side">
            <!-- Iframe c/ Meteorologia zona Porto -->
<span style="display: block !important; width: 180px; text-align: center; font-family: sans-serif; font-size: 12px;"><a href="http://www.wunderground.com/cgi-bin/findweather/getForecast?query=zmw:00000.1.08545&bannertypeclick=wu_travel_globe1" title="Porto, Portugal Weather Forecast" target="_blank"><img src="http://weathersticker.wunderground.com/weathersticker/cgi-bin/banner/ban/wxBanner?bannertype=wu_travel_globe1_metric&airportcode=LPPR&ForcedCity=Porto&ForcedState=Portugal&wmo=08545&language=BR" alt="Find more about Weather in Porto, PO" width="230" /></a><br><a href="http://www.wunderground.com/cgi-bin/findweather/getForecast?query=zmw:00000.1.08545&bannertypeclick=wu_travel_globe1" title="Get latest Weather Forecast updates" style="font-family: sans-serif; font-size: 12px" target="_blank"></a></span>
            <!-- Subscrição de newslleter -->
            <div class="subscribe lefty">
               <h3 class="sec-title">NEWSLETTER</h3>
               <h6>Estará disponivel brevemente a subscrição da newsletter.</h6>
            </div>
<!-- CMS - Banner lateral Direito c/ Gestor de conteudos de texto para facilmente ajustar as medidadas necessárias -->
            <div class="lefty ad-rt">
<cms:editable  name='destaque_lateral' label='Destaque lateral direito' desc='Largura max:370px' type='richtext'>
    "Insira Ficheiro de imagem para destaque lateral" </cms:editable>              
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
      <!-- Java script necessários-->   
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