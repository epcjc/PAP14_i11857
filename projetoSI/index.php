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
                     <li><a href="categoria.php?p=39">Tecnologia</a></li>
                     <li><a href="categoria.php?p=23">Mundial 2014</a></li>
                  </ul>
               </div>
            </div>
            <a class="fxd-mnu-x trans1" title="Close" id="hidemenu"><span class="fa-stack fa-lg"> <i class="fa fa-times fa-stack-1x fa-inverse"></i> </span></a>
         </div>
      </div>
      <!-- BOX 1 -->
      <div class="container">
         <div class="main-news-blks">
            <div class="hm-slider-cont">
               <!-- News slider -->
               <div class="flex-container">
                  <div class="flexslider hm-slider">
                     <ul class="slides">
                        <li>
<!-- CMS - Gestor de imagem Box 1 -->                        
<cms:editable name='prop_image' label='Imagem Box1' desc='Insira Imagem "Dimensoes 464*664"'
  width='464'
  height='664'
  type='image' 
  hidden='1'/>
<img src="<cms:show prop_image />" />
                    <h4 class="cat-label cat-label5"><a href="categoria.php?p=40">DESPORTO</a></h4>
                           <div class="hm-sldr-caption">
<!-- CMS c/ GESTOR DE TEXTO (Rich Text)  - Gestor de Texto Box 1  -->                        
<cms:editable name='main_content' type='richtext'> original content </cms:editable>
                              </p>
                           </div>
                        </li>
                     </ul>
                  </div>
               </div>
            </div>
            <!-- Blocos Fixos -->
            <div class="mid-blks-cont">
               <!-- Block1 -->
               <div class="mid-block-1 boxgrid caption">
<!-- CMS - Gestor de imagem Box 2 -->                        
<cms:editable name='imgbox2' label='Imagem Box2' desc='Insira Imagem "Dimensoes 391*231"'
  width='391'
  height='231'
  type='image' 
  hidden='1'/>
<img src="<cms:show imgbox2 />" />                  
  					<div class="cover boxcaption">
<!-- CMS - Gestor de Titulo Box 2 -->                        
<cms:editable  name='ttlb2' label='Titulo BOX2' desc='Insira titulo BOX2' hidden='1' type='text'>Awesome property!</cms:editable>
<!-- CMS - Gestor de Texto Box 2 -->                        
<cms:editable  name='txtb2' label='Texto BOX2' desc='Insira um titulo BOX2' hidden='1' type='text'>Awesome property!</cms:editable>
<!-- CMS - Mostra texto -->                        
                     <h3><a href="categoria.php?p=23"><cms:show ttlb2 /></a></h3>
<!-- CMS - Mostra texto -->                        
                     <p><cms:show txtb2 /></p>
                  </div>
               </div>
               <!-- Box 3 -->
               <div class="mid-block-2 boxgrid caption">
<!-- CMS - Gestor de imagem Box 3 -->                        
<cms:editable name='imgbox3' label='Imagem Box3' desc='Insira Imagem "Dimensoes 391*231"'
  width='391'
  height='231'
  type='image' 
  hidden='1'/>
<img src="<cms:show imgbox3 />" />    
  					<div class="cover boxcaption">
<!-- CMS - Gestor de Titulo Box 3 -->                        
<cms:editable  name='ttlb3' label='Titulo BOX3' desc='Insira titulo BOX3' hidden='1' type='text'>Awesome property!</cms:editable>
<!-- CMS - Gestor de Texto Box 3 -->                        
<cms:editable  name='txtb3' label='Texto BOX3' desc='Insira um titulo BOX3' hidden='1' type='text'>Awesome property!</cms:editable>
                     <h3><a href="categoria.php?p=42"><cms:show ttlb3 /></a></h3>
                     <p><cms:show txtb3 /></p>
                  </div>
               </div>
            </div>
            <!-- Box 4 -->
            <div class="rt-bk-cont">
               <div class="rt-block boxgrid2 caption">
<!-- CMS - Gestor de imagem Box 4 -->                        
<cms:editable name='imgbox4' label='Imagem Box4' desc='Insira Imagem "Dimensoes 391*231"'
  width='289'
  height='475'
  type='image' 
  hidden='1'/>
<img src="<cms:show imgbox4 />" />                  
                  <div class="cover boxcaption2">
<!-- CMS - Gestor de Titulo Box 4 -->                        
<cms:editable  name='ttlb4' label='Titulo BOX4' desc='Insira titulo BOX4' hidden='1' type='text'>Awesome property!</cms:editable>
<!-- CMS - Gestor de Texto Box 2 -->                        
<cms:editable  name='txtb4' label='Texto BOX4' desc='Insira um titulo BOX4' hidden='1' type='text'>Awesome property!</cms:editable>
                     <h3><a href="categoria.php?p=43"><cms:show ttlb4 /></a></h3>
                     <p><cms:show txtb4 /></p>
                  </div>
               </div>
            </div>
         </div>
      </div>
      <!-- Destaques -->
      <div class="container">
         <div class="float-width ticker">
            <h3 class="cat-label1">Destaques</h3>
            <ul class="newsticker">
<!-- CMS - Gestor de Destaques -->                        
<cms:editable  name='des1' label='Destaque de pagina' desc='1' hidden='1' type='text'>Awesome property!</cms:editable>
<cms:editable  name='des2' label='Destaque de pagina' desc='2' hidden='1' type='text'>Awesome property!</cms:editable>
<cms:editable  name='des3' label='Destaque de pagina' desc='3' hidden='1' type='text'>Awesome property!</cms:editable>
<!-- CMS - Mostra Destaques -->                        
               <li>
                  <h4><cms:show des1 /></h4>
               </li>
               <li>
                  <h4><cms:show des2 /></h4>
               </li>
               <li>
                  <h4><cms:show des3 /></h4>
               </li>
            </ul>
            <div class="ticker-ctrls">
               <a id="tkr-prev">&#59237;</a>
               <a id="tkr-nxt">&#59238;</a>
            </div>
         </div>
      </div>
    <!-- Main Body -->
      <div class="container">
         <!-- Main Left side -->
         <div class="main-left-side">
            <!-- Bloco 2 Noticias -->
            <div class="top-news float-width">
               <div class="float-width sec-cont">
                  <div class="top-big-two">
                     <div class="big-two-1 blocky boxgrid3 caption">
<!-- CMS - Gestor de imagem Box Bloco 2 (Imagem nrº1) -->                        
<cms:editable name='img_1' label='Imagem Box1 - Contentor 2' desc='Insira Imagem "Dimensoes 367*269"'
  width='367'
  height='269'
  type='image' 
  hidden='1'/>
<img src="<cms:show img_1 />" />
                        <div class="cover boxcaption3">
<!-- CMS - Gestor de Texto Box1 - Bloco 2 -->                        
<cms:editable  name='ttl_1' label='Bloco de 2 noticias' desc='1' hidden='1' type='text'>Awesome property!</cms:editable>
<h3><a href="categoria.php?p=43"><cms:show ttl_1 /></a></h3>                           <p class="artcl-time-1">
                           </p>
                        </div>
                     </div>
                     <div class="big-two-2 blocky boxgrid3 caption">
<!-- CMS - Gestor de imagem Box1 Bloco 2  (Imagem nrº2) -->                        
<cms:editable name='img_2' label='Imagem Box2 - Contentor 2' desc='Insira Imagem "Dimensoes 367*269"'
  width='367'
  height='269'
  type='image' 
  hidden='1'/>
<img src="<cms:show img_2 />" />
                        <div class="cover boxcaption3">
<!-- CMS - Gestor de Texto Box2 - Bloco 2 -->                        
<cms:editable  name='ttl_2' label='Bloco de 2 noticias' desc='2' hidden='1' type='text'>Awesome property!</cms:editable>
<h3><a href="categoria.php?p=42"><cms:show ttl_2 /></a></h3>                         
							  <p class="artcl-time-1">
                          	 <p class="artcl-time-1">
                           </p>
                        </div>
                     </div>
                  </div>
               </div>
               <div class="tn-small-1 blocky"> 
<!-- CMS - Gestor de imagem Box Bloco 4 pequenas noticias (Imagem nrº1) -->                        
<cms:editable name='imagem1' label='Imagem 1 Bloco 4' desc='Insira Imagem "Dimensoes 107*85"'  width='107' height='85' type='image' hidden='1'/>
<img alt="" class="lefty" src="<cms:show imagem1 />" width='107' height='85' type='image' />
<!-- CMS - Gestor de Texto Box Bloco 4 - (1) -->                        
<cms:editable  name='txt1bl4' label='Bloco de 4 noticias' desc='1' hidden='1' type='text'>Awesome property!</cms:editable>
<h4 class="lefty"><cms:show txt1bl4 /></h4>
                  <a class="lefty cat-a cat-label4" href="categoria.php?p=43">MUNDO</a>
                  <p class="righty"></p>
               </div>
               <div class="tn-small-1 blocky">
<!-- CMS - Gestor de imagem Box Bloco 4 pequenas noticias (Imagem nrº2) -->                        
<cms:editable name='imagem2' label='Imagem 2 Bloco 4' desc='Insira Imagem "Dimensoes 107*85"'  width='107' height='85' type='image' hidden='1'/>
<img alt="" class="lefty" src="<cms:show imagem2 />" width='107' height='85'/>
<!-- CMS - Gestor de Texto Box Bloco 4 - (2) -->                        
<cms:editable  name='txt2bl4' label='Bloco de 4 noticias' desc='2' hidden='1' type='text'>Awesome property!</cms:editable>
 <h4 class="lefty"><cms:show txt2bl4 /></h4>
                  <a class="lefty cat-a cat-label2" href="categoria.php?p=42">PAÍS</a>
                  <p class="righty"></p>
               </div>
               <div class="tn-small-1 blocky">
<!-- CMS - Gestor de imagem Box Bloco 4 pequenas noticias (Imagem nrº3) -->                        
<cms:editable name='imagem3' label='Imagem 3 Bloco 4' desc='Insira Imagem "Dimensoes 107*85"'  width='107' height='85' type='image' hidden='1'/>
<img alt="" class="lefty" src="<cms:show imagem3 />" width='107' height='85'/>
<!-- CMS - Gestor de Texto Box Bloco 4 - (3) -->                        
<cms:editable  name='txt3bl4' label='Bloco de 4 noticias' desc='3' hidden='1' type='text'>Awesome property!</cms:editable>
<h4 class="lefty"><cms:show txt3bl4 /></h4>
                  <a class="lefty cat-a cat-label3" href="categoria.php?p=41">PAREDES</a>
                  <p class="righty"></p>
               </div>
               <div class="tn-small-1 blocky">
<!-- CMS - Gestor de imagem Box Bloco 4 pequenas noticias (Imagem nrº4) -->                        
<cms:editable name='imagem4' label='Imagem 4 Bloco 4' desc='Insira Imagem "Dimensoes 107*85"'  width='107' height='85' type='image' hidden='1'/>
<img alt="" class="lefty" src="<cms:show imagem4 />" width='107' height='85'/>
<!-- CMS - Gestor de Texto Box Bloco 4 - (4) -->                        
<cms:editable  name='txt4bl4' label='Bloco de 4 noticias' desc='4' hidden='1' type='text'>Awesome property!</cms:editable>
<h4 class="lefty"><cms:show txt4bl4 /></h4>
                  <a class="lefty cat-a cat-label5" href="categoria.php?p=40">DESPORTO</a>
                  <p class="righty"></p>
               </div>
            </div>
            <!-- Sec 1 -->
            <div class="news-sec-1 float-width">
               <div class="float-width sec-cont2">
                  <div class="sec-1-big float-width">
<!-- CMS - Gestor de imagem Ultima not. página -->                        
<cms:editable name='imgboxlast' label='Imagem Ultima Box' desc='Insira Imagem "Dimensoes 281*206"'
  width='281'
  height='206'
  type='image' 
  hidden='1'/>
<a href="categoria.php?p=39"><img alt="" class="blocky" src="<cms:show imgboxlast />" /></a>                     
<div class="sec-1-big-text lefty">
<!-- CMS - Gestor de Titulo Ultima Noticia -->                        
<a href="categoria.php?p=39"><cms:editable  name='ttllast' label='Titulo Ultima box' desc='0' hidden='1' type='text'>Awesome property!</cms:editable></a>                        <h3><cms:show ttllast /></h3>
<!-- CMS - Gestor de Texto Ultima Noticia -->                        
<cms:editable  name='txtlast' label='Texto Ultima box' desc='0' hidden='1' type='text'>Awesome property!</cms:editable>
                        <p><cms:show txtlast /></p>
                     </div>
                  </div>
               </div>
            </div>
         </div>
<!-- CMS - Publicidade  lado direito Nrº1 -->
<cms:editable name='pub2' label='Image' desc='Lado Direito - Topo Dimensoes "370*181"'
  width='370'
  height='181'
  type='image' 
  hidden='1'/>
  <img src="<cms:show pub2 />" />
        <br><br>
         <!-- Main Right side -->
         <div class="main-right-side">
            <!-- One image slider -->
            <div class="sm-sldr-box float-width">
               <div class="flexslider sm-sldr">
                  <ul class="slides">
                     <li>
<!-- CMS - Publicidade  lado direito Nrº2 -->                     
<cms:editable name='slid1' label='Image' desc='Lado Direito - Topo Dimensoes "370*340"'
  width='370'
  height='340'
  type='image' 
  hidden='1'/>
<img src="<cms:show slid1 />" />
                     </li>
                     <li>
<!-- CMS - Publicidade  lado direito Nrº3 -->                     
<cms:editable name='slid2' label='Image' desc='Lado Direito - Topo Dimensoes "370*340"'
  width='370'
  height='340'
  type='image' 
  hidden='1'/>
<img src="<cms:show slid2 />" />
                     </li>
                  </ul>
               </div>
            </div>
          
            <!-- Box FACEBOOK - Iframe Like page Facebook Dev.-->
            <iframe src="//www.facebook.com/plugins/likebox.php?href=https%3A%2F%2Fwww.facebook.com%2FFacebookDevelopers&amp;width=140&amp;height=290&amp;colorscheme=light&amp;show_faces=true&amp;header=true&amp;stream=false&amp;show_border=true" scrolling="no" frameborder="0" style="border:none; overflow:hidden; width:370px; height:300px;" allowTransparency="true"></iframe>
            <!-- Banner Fundo - Sem Editor CMS -->
            <div class="lefty ad-rt">
               <a href="#"><img alt="" src="img/samples/u1.jpg" /></a>
            </div>
         </div>
      </div>
      <!-- RODAPÉ -->
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