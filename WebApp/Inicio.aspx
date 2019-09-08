<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebApp.Inicio" EnableEventValidation="false" %>
<!DOCTYPE html>
<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AKDsystem</title>
    <asp:PlaceHolder ID="PlaceHolder2" runat="server">
        <script src="<%= ResolveClientUrl("~/tools/jquery/jquery-1.9.1.js") %>" type="text/javascript"></script>
        <script src="<%= ResolveClientUrl("~/Tools/jquery/ui/1.10.4/jquery-ui.custom.js") %>"></script>
        <script src="<%= ResolveClientUrl("~/tools/bootstrap/3.3.5/js/bootstrap.js") %>" type="text/javascript"></script>
        <link href="<%= ResolveClientUrl("~/tools/bootstrap/3.3.5/css/bootstrap.min.css") %>" rel="stylesheet" />
        <link href="<%= ResolveClientUrl("~/tools/font-awesome/4.3.0/css/font-awesome.min.css") %>" rel="stylesheet" />
        <link href="<%= ResolveClientUrl("~/Tools/jquery/ui/1.10.4/jquery.ui.custom.min.css") %>" rel="stylesheet" />
        <link href="<%= ResolveClientUrl("~/css/style_rep.css") %>" rel="stylesheet" />
        <script src="<%= ResolveClientUrl("~/js/fun_general.js") %>" type="text/javascript"></script>
        <link href="<%= ResolveClientUrl("~/css/__jquery.ui.datepicker.css") %>" rel="stylesheet" />
        <link href='https://fonts.googleapis.com/css?family=PT+Sans:400,400italic,700,700italic' rel='stylesheet' type='text/css'>
    </asp:PlaceHolder>

    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="generator" content="Codeply">

    
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css" />
    <link href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href="//cdnjs.cloudflare.com/ajax/libs/animate.css/3.1.1/animate.min.css" rel="stylesheet" />
    <%--<link rel="stylesheet" href="css/styles.css" />--%>
    <link href="../css/styles.css" rel="stylesheet" />

    <link rel="stylesheet" type="text/css" href="engine1/style.css" />
    <script type="text/javascript" src="engine1/jquery.js"></script>

    <style>
        
    </style>
    <script>
        $(document).ready(function () {
            $("a[rel='pop-up']").click(function () {
                var caracteristicas = "height=600, width=800, scrollTo, resizable=1, scrollbars=1, location=0";
                nueva = window.open(this.href, 'Popup', caracteristicas);
                return false;
            });
        });
    </script>

</head>
<body>
 <form id="form1" runat="server">
    <nav class="navbar navbar-trans navbar-fixed-top" role="navigation">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar-collapsible">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand text-danger" href="#">AKDemia</a>
        </div>
        <div class="navbar-collapse collapse" id="navbar-collapsible">
            <ul class="nav navbar-nav navbar-left">
                <li><a href="#section1">Inicio</a></li>
                <li><a href="#section2">Categorias</a></li>
                <li><a href="#section3">Nosotros</a></li>
                <li><a href="#section4">Contactanos</a></li>
                <li><a href="#section5">Destacados</a></li>
                <li><a href="#section6">Siguenos</a></li>
                <li>&nbsp;</li>
            </ul>
            <ul class="nav navbar-nav navbar-right">
                <li><a href="#" data-toggle="modal" data-target="#myModal"><i class="fa fa-user fa-lg"></i></a></li>
            </ul>
        </div>
    </div>
</nav>
 <section class="container-fluid" id="section1">
    <div class="v-center">
        <h1 class="text-center">AKDemia Futbol Club</h1>
        <h2 class="text-center lato animate slideInDown">Donde lo unico que importa es el <b>Deporte y Educación</b></h2>
        <p class="text-center">
            <br>
            <a href="#calendario" class="btn btn-danger btn-lg btn-huge lato"">Calendario de Actividades</a>
        </p>
    </div>
    <a href="#calendario">
		<div class="scroll-down bounceInDown animated">
            <span>
                <i class="fa fa-angle-down fa-2x"></i>
            </span>
		</div>
        </a>
</section>

 <section id="calendario" style="height: 800px">
    
        <h1 class="text-center">Calendario de actividades</h1>
        <div class="row">
            <div class="col-sm-12">
                <div class="col-sm-2"></div>
                <div class="row">
                    <div class="col-sm-8 text-center">  
            <p style="text-align: center">  
            <b></b>  
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium"  
                ForeColor="#0066FF"></asp:Label><br />
            </p>  
            <asp:Calendar ID="Calendar1"  runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66"  
                BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"  
                ForeColor="#663399" ShowGridLines="True" OnDayRender="Calendar1_DayRender">  
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />  
                <SelectorStyle BackColor="#FFCC66" />  
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />  
                <OtherMonthDayStyle ForeColor="#CC9966" />  
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />  
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />  
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />  
            </asp:Calendar>  
            <br />  
            <b></b>  
            <%--<asp:Label ID="LabelAction" runat="server"></asp:Label><br />  --%>
        </div>  
                    </div>
                </div>
                <div class="col-sm-2"></div>
            </div>
    
    <a href="#section2">
		<div class="scroll-down bounceInDown animated">
            <span>
                <i class="fa fa-angle-down fa-2x"></i>
            </span>
		</div>
        </a>
</section>


    <section class="container-fluid" id="section2">
    <div class="container v-center">
        <div class="row">
            <div class="col-sm-4">
                <div class="row">
                    <div class="col-sm-12 text-center">
                        <div class="panel panel-default slideInLeft animate">
                            <div class="panel-heading">
                            <h3>Categoria 99</h3></div>
                            <div class="panel-body">
                                <p>FUTURAS ALINEACIONES</p>
                                <hr>GO
                                <hr>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-4 text-center">
                <div class="row">
                    <div class="col-sm-12 text-center">
                        <div class="panel panel-default slideInUp animate">
                            <div class="panel-heading">
                            <h3>Categoria 98</h3></div>
                            <div class="panel-body">
                                <p>FUTURAS ALINEACIONES</p>
                                <hr>GO
                                <hr>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-4 text-center">
                <div class="row">
                    <div class="col-sm-12 text-center">
                        <div class="panel panel-default slideInRight animate">
                            <div class="panel-heading">
                            <h3>Categoria 2002</h3></div>
                            <div class="panel-body">
                                <p>FUTURAS ALINEACIONES</p>
                                <hr>GO
                                <hr>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--/row-->
        <div class="row">
            <br>
        </div>
    </div>
    <!--/container-->
</section>

<%--    <section>
    <div class="container-fluid v-center">
        <div class="row">
            <div class="col-sm-2 col-sm-offset-2 col-xs-6">
                <div class="text-center">
                    <a href="">
                        <img style="width:100px;" class="img-circle img-responsive img-thumbnail" src="//placehold.it/100/444">
                    </a>
                    <h3 class="text-center"></h3>
                </div>
            </div>
            <div class="col-sm-2 col-xs-6">
                <div class="text-center">
                    <a href="">
                        <img style="width:100px;" class="img-circle img-responsive img-thumbnail" src="//placehold.it/100/444">
                    </a>
                    <h3 class="text-center"></h3>
                </div>
            </div>
            <div class="col-sm-2 col-xs-6">
                <div class="text-center">
                    <a href="">
                        <img style="width:100px;" class="img-circle img-responsive img-thumbnail" src="//placehold.it/100/444">
                    </a>
                    <h3 class="text-center"></h3>
                </div>
            </div>
            <div class="col-sm-2 col-xs-6">
                <div class="text-center">
                    <a href="">
                        <img style="width:100px;" class="img-circle img-responsive img-thumbnail" src="//placehold.it/100/444">
                    </a>
                    <h3 class="text-center"></h3>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-2 col-sm-offset-2 col-xs-6">
                <div class="text-center">
                    <a href="">
                        <img style="width:100px;" class="img-circle img-responsive img-thumbnail" src="//placehold.it/100/444">
                    </a>
                    <h3 class="text-center"></h3>
                </div>
            </div>
            <div class="col-sm-2 col-xs-6">
                <div class="text-center">
                    <a href="">
                        <img style="width:100px;" class="img-circle img-responsive img-thumbnail" src="//placehold.it/100/444">
                    </a>
                    <h3 class="text-center"></h3>
                </div>
            </div>
            <div class="col-sm-2 col-xs-6">
                <div class="text-center">
                    <a href="">
                        <img style="width:100px;" class="img-circle img-responsive img-thumbnail" src="//placehold.it/100/444">
                    </a>
                    <h3 class="text-center"></h3>
                </div>
            </div>
            <div class="col-sm-2 col-xs-6">
                <div class="text-center">
                    <a href="">
                        <img style="width:100px;" class="img-circle img-responsive img-thumbnail" src="//placehold.it/100/444">
                    </a>
                    <h3 class="text-center"></h3>
                </div>
            </div>
        </div>
        <!--/row-->
    </div>
</section>--%>

    <section class="container-fluid" id="section3">
    <h1 class="text-center">Nosotros</h1>
    <div class="row">
        <div class="col-sm-6 col-sm-offset-3">
            <h3 class="text-center lato slideInUp animate">Equipos por<strong> Categorias</strong></h3>
            <br>
            <div class="row">
                <div class="col-xs-4 col-xs-offset-1">El AKDemia Futbol Club dispone de 3 categorias para los futuros cracks del balonpié peruano.</div>
                <div class="col-xs-2"></div>
                <div class="col-xs-4 text-right">Las Categorias disponibles hasta este momento son de 1999,1998 y el año 2002, donde muchos jovenes se incorporan a nuestras filas.</div>
            </div>
            <br>
            <p class="text-center">
               
<div id="wowslider-container1">
<div class="ws_images"><ul>
		<li><a href="www.google.com.pe"><img src="data1/images/cami_1.jpg" alt="Entrenador con Primera Camiseta" title="Entrenador con Primera Camiseta" id="wows1_0"/></a></li>
		<li><a href="www.gmail.com"><img src="data1/images/cami_2.jpg" alt="Entreñador con Segunda Camiseta" title="Entreñador con Segunda Camiseta" id="wows1_1"/></a></li>
		<li><img src="data1/images/equipo_cat_1998.jpg" alt="Equipo categoria 1998" title="Equipo categoria 1998" id="wows1_2"/></li>
		<li><a href="http://wowslider.com"><img src="data1/images/equipo_cat_2002.jpg" alt="http://wowslider.com/" title="Equipo categoria 2002" id="wows1_3"/></a></li>
		<li><img src="data1/images/equipo_cat_2002_v2.jpg" alt="Equipo_categoria 2002 v2" title="Equipo_categoria 2002 v2" id="wows1_4"/></li>
	</ul></div>
	<div class="ws_bullets"><div>
		<a href="#" title="Entrenador con Primera Camiseta"><span><img src="data1/tooltips/cami_1.jpg" alt="Entrenador con Primera Camiseta"/>1</span></a>
		<a href="#" title="Entreñador con Segunda Camiseta"><span><img src="data1/tooltips/cami_2.jpg" alt="Entreñador con Segunda Camiseta"/>2</span></a>
		<a href="#" title="Equipo categoria 1998"><span><img src="data1/tooltips/equipo_cat_1998.jpg" alt="Equipo categoria 1998"/>3</span></a>
		<a href="#" title="Equipo categoria 2002"><span><img src="data1/tooltips/equipo_cat_2002.jpg" alt="Equipo categoria 2002"/>4</span></a>
		<a href="#" title="Equipo_categoria 2002 v2"><span><img src="data1/tooltips/equipo_cat_2002_v2.jpg" alt="Equipo_categoria 2002 v2"/>5</span></a>
	</div></div><div class="ws_script" style="position:absolute;left:-99%"><a href="http://wowslider.com">wowslideshow</a> by WOWSlider.com v8.5</div>
<div class="ws_shadow"></div>
</div>	
<script type="text/javascript" src="engine1/wowslider.js"></script>
<script type="text/javascript" src="engine1/script.js"></script>

            </p>
        </div>
    </div>
</section>

    <section id="section4" style="height: 850px;">
    <div class="container v-center" style="margin-top:40px">
        <div class="row">
            <div class="col-md-12">
                <h1 class="text-center"style="padding-top: 0px;">Mantente en Contacto</h1>
                <hr>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-9">
                <div class="row form-group">
                    <div class="col-sm-3">
                        <input type="text" class="form-control" id="firstName" name="firstName" placeholder="Nombres Completos">
                    </div>
                    <div class="col-sm-4">
                        <input type="text" class="form-control" id="lastName" name="lastName" placeholder="Apellidos Completos">
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-sm-5">
                        <input type="email" class="form-control" name="email" placeholder="Correo" >
                    </div>
                    <div class="col-sm-5">
                        <input type="email" class="form-control" name="phone" placeholder="Telefono o Celular" >
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-sm-10">
                        <input type="homepage" class="form-control" placeholder="Website URL" >
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col-sm-10">
                        <button class="btn btn-default btn-lg pull-right">Contactenos</button>
                    </div>
                </div>
            </div>
            <div class="col-sm-3 pull-right">
                <address>
              <strong>AKDemia FC</strong><br>
              Av. Peru 2820<br>
              San Martin de Porres, Lima Perú<br>
              P: (01) 456-7890
            </address>
                <address>
              <strong>Nuestro Correo</strong><br>
              <a href="mailto:#">AKDemia@gmail.com</a>
            </address>
            </div>
        </div>
         <div class="row">
            <div class="col-md-12" style="margin-bottom:30px;">
               <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3902.1848144898536!2d-77.08559249999999!3d-12.0307942!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x9105ceba180ee21f%3A0x109d472973caa5aa!2sAv.+Per%C3%BA+28%2C+Lima+15106!5e0!3m2!1ses!2spe!4v1441864976135" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>
                 <hr>
            </div>
        </div>
    </div>
</section>

    <section class="container-fluid" id="section5" style="height: 1420px;">
    <div class="row">
        <div class="col-sm-6 col-sm-offset-3 col-md-4 col-md-offset-4">
            <h2 class="text-center lato">Los más destacados del Mes</h2>
            <hr>
            <div class="media">
                <h3>Jose Luis Peña Zambrano</h3>
                <div class="media-left">
                    <img src="imagenes/foto1.png">
                </div>
                <div class="media-body media-middle">
                    <p>Arquero de la Categoria 98, buen jugador con 80 atajadas en 7 partidos por la Copa Federación.
                       El más destacado del club por el gran esfuerzo que demuestra en el campo de juego.
                    </p>
                </div>
            </div>
            <hr>
            <div class="media">
                <h3>Julio Cesar Aguilar Torres</h3>
                <div class="media-body media-middle">
                    <p>Delantero de la Categoria 98, buen manejor del balón con grandes demotraciones en el campo con un total de 32 goles</p>
                </div>
                <div class="media-right">
                    <img src="imagenes/foto2.png">
                </div>
            </div>
            <hr>
            <div class="media">
                <h3>Carlos Alonso Machado Cáceres</h3>
                <div class="media-left">
                    <img src="imagenes/foto3.png">
                </div>
                <div class="media-body media-middle">
                    <p>Extraordinario Defensa Central,veloz y potente su juego se caracteriza por una serena combatividad y su gran esfuerzo.</p>
                </div>
            </div>
            <hr>
            <div class="media">
                <h3>Joe Camargo Melgar</h3>
                <div class="media-body media-middle">
                    <p>Un veloz Lateral Izquierdo, con gran capacidad intuitiva para defender y mostrar que esta siempre listo para el ataque.</p>
                </div>
                <div class="media-right">
                    <img src="imagenes/foto4.png">
                </div>
            </div>
            <hr>
            <div class="media">
                <h3>Cesar Bustamante Aguirre</h3>
                <div class="media-left">
                    <img src="imagenes/foto5.png">
                </div>
                <div class="media-body media-middle">
                    <p>Excelente Volante de Marca que posee ante todo cualidades de defensor.</p>
                </div>
            </div>
            <hr>
            <div class="media">
                <h3>Anthony Martin Campos Céspedes</h3>
                <div class="media-body media-middle">
                    <p>Gran Lateral Derecho, con una excelente velocidad y buena técnica.</p>
                </div>
                <div class="media-right">
                    <img src="imagenes/foto6.png">
                </div>
            </div>

        </div>
    </div>
</section>

    <%--<section class="container-fluid" id="section6"style="height: 210px;padding-bottom: 30px;">
    <ul class="row list-unstyled">
        <li class="col-md-6 col-md-offset-1 col-xs-10 col-xs-offset-1">
            <h3 class="text-center">Administracion de Entrenamientos</h3>
        </li>
        <li class="col-md-3 col-md-offset-0 col-xs-10 col-xs-offset-1 text-center">
            <a href="" class="center-block btn btn-default btn-lg btn-huge lato animate slideInRight">Entrenamientos</a>
        </li>
    </ul>
</section>--%>
     <%--
    <section class="container-fluid" id="section7"style="height: 160px;">
    <div class="row">
        <!--fontawesome icons-->
        <div class="col-sm-1 col-sm-offset-3 col-xs-4 text-center">
            <i class="fa fa-github fa-4x"></i>
        </div>
        <div class="col-sm-1 col-xs-4 text-center">
            <i class="fa fa-foursquare fa-4x"></i>
        </div>
        <div class="col-sm-1 col-xs-4 text-center">
            <i class="fa fa-instagram fa-4x"></i>
        </div>
        <div class="col-sm-1 col-xs-4 text-center">
            <i class="fa fa-google-plus fa-4x"></i>
        </div>
        <div class="col-sm-1 col-xs-4 text-center">
            <i class="fa fa-twitter fa-4x"></i>
        </div>
        <div class="col-sm-1 col-xs-4 text-center">
            <i class="fa fa-dribbble fa-4x"></i>
        </div>
    </div>
</section>--%>

    <footer id="footer">
    <div class="container">
        <div class="row">
            <div class="col-xs-6 col-sm-6 col-md-3 column">
                <h4>Información</h4>
                <ul class="nav">
                    <li><a href="about-us.html">Entrenador</a></li>
                    <li><a href="about-us.html">Servicios</a></li>
                    <li><a href="about-us.html">Convenios</a></li>
                    <li><a href="elements.html">Pagos</a></li>
                </ul>
            </div>
            <%--<div class="col-xs-6 col-md-3 column">
                <h4>Siguenos</h4>
                <ul class="nav">
                    <li><a href="#">Twitter</a></li>
                    <li><a href="#">Facebook</a></li>
                    <li><a href="#">Google+</a></li>
                    <li><a href="#">Instagram</a></li>
                </ul>
            </div>--%>
            <div class="col-xs-6 col-md-3 column">
                <h4>Contactenos</h4>
                <ul class="nav">
                    <li><a href="#">Correo Electronico</a></li>
                    <li><a href="#">Sede</a></li>
                    <li><a href="#">Administración</a></li>
                    <li><a href="#">Soporte</a></li>
                </ul>
            </div>
            <div class="col-xs-6 col-md-3 column">
                <h4>Servicio al Cliente</h4>
                <ul class="nav">
                    <li><a href="#">Sobre Nosotros</a></li>
                    <li><a href="#">Informacion Complementaria</a></li>
                    <li><a href="#">Politica de Privacidad</a></li>
                    <li><a href="#">Terminos &amp; Condiciones</a></li>
                </ul>
            </div>
        </div>
        <!--/row-->
        <p class="text-center" style="margin-top: 20px;">©2019</p>
        <p class="text-center">CopyRight</p>
    </div>
</footer>

    <div class="scroll-up">
	<a href="#"><i class="fa fa-angle-up"></i></a>
</div>

    <div id="myModal" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                <h2 class="text-center"><img src="//placehold.it/110" class="img-circle"><br>Bienvenido</h2>
            </div>
            <div class="modal-body row">
                <h6 class="text-center">LLENAR CAMPOS PARA LOGUEARSE</h6>
                <form class="col-md-10 col-md-offset-1 col-xs-12 col-xs-offset-0">
                    <div class="form-group" style="width: 560px;padding-left: 60px;padding-right: 40px;">
                        <asp:TextBox runat="server" ID="txtUsuario"  CssClass="form-control" placeholder="Usuario" autofocus/>
                    </div>
                    <div class="form-group" style="width: 560px;padding-left: 60px;padding-right: 40px;">
                        <asp:TextBox runat="server" ID="txtContraseña"  CssClass="form-control" placeholder="Contraseña" TextMode="Password" />
                    </div>
                    <div class="form-group" style="width: 560px;padding-left: 60px;padding-right: 40px;">
                        <asp:Button runat="server" ID="btnIniciar"  Text="Iniciar" CssClass="btn btn-danger btn-lg btn-block" OnClick="btnIniciar_Click" />
                        <span class="pull-right"></span><span><a href="#">Necesita ayuda?</a></span>
                    </div>
                </form>
            </div>
            <div class="modal-footer">
                <h6 class="text-center"><a href="">La privacidad es importante para nosotros. Haga clic aquí para leer por qué.</a></h6>
            </div>
        </div>
    </div>
</div>

    <!--scripts loaded here-->
    
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
    
    <script src="js/scripts.js"></script>
    
    
    </form>
</body>
</html>
