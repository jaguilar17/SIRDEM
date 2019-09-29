<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bienvenida.aspx.cs" Inherits="WebApp.contenido.Bienvenida" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
        <script src="<%= ResolveClientUrl("~/engine1/jquery.js") %>" type="text/javascript"></script>
        <script src="<%= ResolveClientUrl("~/js/fun_general.js") %>" type="text/javascript"></script>


        <link href="<%= ResolveClientUrl("~/css/__jquery.ui.datepicker.css") %>" rel="stylesheet" />
        <link href='https://fonts.googleapis.com/css?family=PT+Sans:400,400italic,700,700italic' rel='stylesheet' type='text/css'>
    </asp:PlaceHolder>

    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="generator" content="Codeply">

    
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css" />
    <link href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href="//cdnjs.cloudflare.com/ajax/libs/animate.css/3.1.1/animate.min.css" rel="stylesheet" />

    <link href="../engine1/style.css" rel="stylesheet" />

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

    
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
    <script type = "text/javascript">
    function ShowTeam() {
        window.location.href  = "~/contenido/equipo/frm_VerPlantilla.aspx?codEquipo=0006";
    }
    function OnSuccess(response) {
        alert(response.d);
    }
    </script>


</head>
<body>
    <form id="form1" runat="server">

    <div class="container v-center">

        <div class="row">
            
            <div class="col-sm-4">
                <div class="row">
                    <div class="col-sm-12 text-center">

                    </div>
                </div>
            </div>
            <div class="col-sm-4 text-center">
                <div class="row">
                    <div class="col-sm-12 text-center">
                        
                            <img style="width:50%" src ="/utils/images/Logo.png" />
                        
                    </div>
                </div>
            </div>
            <div class="col-sm-4 text-center">
                <div class="row">
                    <div class="col-sm-12 text-center">
                        
                    </div>
                </div>
            </div>
        </div>
<br/>
<div class="panel panel-default slideInRight animate" style="padding:5px">
        <h1 style="text-align:center"><asp:Label ID="lblDistrito1" runat="server"></asp:Label> </h1> 
        <h2 style="text-align:center"><asp:Label ID="lblSede1" runat="server"></asp:Label> </h2>
        
        <div class="row">
            
            <asp:Literal ID="ltlSede1" runat="server"></asp:Literal>


            <%--<div class="col-sm-4">
                <div class="row">
                    <div class="col-sm-12 text-center">
                        <div class="panel panel-default slideInLeft animate">
                            <div class="panel-heading">
                            <h3>Categoria 2002</h3></div>
                            <div class="panel-body">
                                <p>DT - Jose Aguilar</p>
                                <hr>
                                <asp:Button ID="btnVerListado" Text="Ver Plantilla" style="width:100%" runat="server" OnClick="btnVerListado_Click" /> 
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
                            <h3>Categoria 2003</h3></div>
                            <div class="panel-body">
                                <p>DT - Jose Aguilar</p>
                                <hr>
                                <asp:Button ID="btnVerListado2" Text="Ver Plantilla" style="width:100%" runat="server" /> 
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
                            <h3>Categoria 2004</h3></div>
                            <div class="panel-body">
                               <p>DT - Jose Aguilar</p>
                                <hr>
                                <asp:Button ID="btnVerListado3" Text="Ver Plantilla" style="width:100%" runat="server" /> 
                                <hr>
                            </div>
                        </div>
                    </div>
                </div>
            </div>--%>
        </div>
        <!--/row-->
</div>
        <br/>
<div class="panel panel-default slideInRight animate" style="padding:5px">
        <h1 style="text-align:center">SEDE BREÑA</h1> 
        <h2 style="text-align:center">Colegio Mariano Melgar</h2>
        <div class="row">
            <div class="col-sm-4">
                <div class="row">
                    <div class="col-sm-12 text-center">
                        <div class="panel panel-default slideInLeft animate">
                            <div class="panel-heading">
                            <h3>Categoria 2002</h3></div>
                            <div class="panel-body">
                                <p>DT - Jose Aguilar</p>
                                <hr>
                                <asp:Button ID="btnVerListado4" Text="Ver Plantilla" style="width:100%" runat="server" OnClick="btnVerListado4_Click" /> 
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
                            <h3>Categoria 2003</h3></div>
                            <div class="panel-body">
                                <p>DT - Jose Aguilar</p>
                                <hr>
                                <asp:Button ID="btnVerListado5" Text="Ver Plantilla" style="width:100%" runat="server" /> 
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
                            <h3>Categoria 2004</h3></div>
                            <div class="panel-body">
                                <p>DT - Jose Aguilar</p>
                                <hr>
                                <asp:Button ID="Button6" Text="Ver Plantilla" style="width:100%" runat="server" /> 
                                <hr>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</div>
</div>
    <!--/container-->
    <%--<asp:Image ID="Image1" runat="server" Height="580px" ImageUrl="~/muni.jpg" Width="1150px"/>--%>
    
    </form>
</body>
</html>
