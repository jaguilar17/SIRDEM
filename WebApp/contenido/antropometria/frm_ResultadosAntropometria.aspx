<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_ResultadosAntropometria.aspx.cs" Inherits="WebApp.contenido.antropometria.frm_ResultadosAntropometria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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

        <link href="<%= ResolveClientUrl("~/Tools/select2/css/select2.min.css") %>" rel="stylesheet" />
        <script src="<%= ResolveClientUrl("~/Tools/select2/js/select2.min.js") %>"></script>
        <link href="<%= ResolveClientUrl("~/Tools/Bootstrap/3.3.5/css/bootstrap-clockpicker.min.css") %>" rel="stylesheet" />
        <script src="<%= ResolveClientUrl("~/Tools/Bootstrap/3.3.5/js/bootstrap-clockpicker.js") %>"></script>
        <link href="<%= ResolveClientUrl("~/Tools/jquery/ui/1.10.4/jquery.ui.custom.min.css") %>" rel="stylesheet" />
        <script src="<%= ResolveClientUrl("~/js/Func_Espec/fun_Equipo.js") %>"></script>

    </asp:PlaceHolder>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="true" EnablePageMethods="true"
            EnableScriptLocalization="true">
        </asp:ScriptManager>
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                   <div class="row">
                        <div class="col-lg-6">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Datos Jugador
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div20">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Código Jugador:
                                            <asp:TextBox runat="server" ID="txtCodigoJugador" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Apellidos y Nombres:
                                            <asp:TextBox runat="server" ID="txtNombreJugador" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                         <div class="col-md-4 col-sm-4 col-xs-12">
                                            Posición:
                                            <asp:TextBox runat="server" ID="txtPosicionJugador" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
  <%--                                  <div class="row" id="divCuenta">
                                        
                                    </div>
                                    <br />
                                    <div class="row" id="divCuentaClave">
                                       
                                    </div>--%>
                                    <br />
                                </div>
                            </div>
                            <!-- /.panel -->
                        </div>
                        <!-- /.col-lg-12 -->
                    </div>
                    <div class="row">
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Resultados Ectomorfia
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div1">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            Ectomorfia
                                            <asp:TextBox runat="server" ID="txtEctomorfiaDato" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div6" style="visibility:hidden">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Button runat="server" ID="btnCompararEctomorfo" Text="Comparar Ectomorfo" CssClass="btn btn-primary" OnClick="btnCompararEctomorfo_Click"></asp:Button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.panel -->
                        </div>
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Valores Optimos Ectomorfia
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div2">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Portero" ID="lblPorteroEctomorfia"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtPorteroEctomorfia" Text="2,4" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div3">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Defensa" ID="lblDefensaEctomorfia"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtDefensaEctomorfia" Text="2,5" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div4">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Centrocampista" ID="lblCentrocampistaEctomorfia"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtCentrocampistaEctomorfia" Text="2,5" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div5">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Delantero" ID="lblDelanteroEctomorfia"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtDelanteroEctomorfia" Text="2,7" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="col-md-12 col-sm-12 col-xs-12">
                                <div class="panel panel-primary">
                                    <div class="panel-heading">
                                        <div class="row">
                                            <div class="col-xs-3">
                                                <i class="fa fa-comments fa-5x"></i>
                                            </div>
                                            <div class="col-xs-9 text-right">
                                                <div class="huge"><asp:Label runat="server" ID="lblEstadoEctomorfo"></asp:Label></div>
                                                <div><asp:Label runat="server" ID="lblResultadoEctomorfo"></asp:Label></div>
                                            </div>
                                        </div>
                                    </div>
                                    <a href="../../frmGraficaEctomorfiaxJugador.aspx">
                                        <div class="panel-footer">
                                            <span class="pull-left">Más Detalles</span>
                                            <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                                            <div class="clearfix"></div>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <!-- /.col-lg-12 -->
                    </div>
                    <div class="row">
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Resultados Mesomorfia
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div7">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            Mesomorfia
                                            <asp:TextBox runat="server" ID="txtMesomorfiaDato" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div8" style="visibility:hidden">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Button runat="server" ID="btnCompararMesomorfia" Text="Comparar Mesomorfia" CssClass="btn btn-primary" OnClick="btnCompararMesomorfia_Click"></asp:Button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.panel -->
                        </div>
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Valores Optimos Mesomorfia
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div9">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Portero" ID="lblPorteroMesomorfia"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtPorteroMesomorfia" Text="5,2" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div10">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Defensa" ID="lblDefensaMesomorfia"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtDefensaMesomorfia" Text="5,2" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div11">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Centrocampista" ID="lblCentroMesomorfia"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtCentrocampistaMesomorfia" Text="5" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div12">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Delantero" ID="lblDelanteroMesomorfia"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtDelanteroMesomorfia" Text="4,9" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="col-md-12 col-sm-12 col-xs-12">
                                <div class="panel panel-primary">
                                    <div class="panel-heading">
                                        <div class="row">
                                            <div class="col-xs-3">
                                                <i class="fa fa-comments fa-5x"></i>
                                            </div>
                                            <div class="col-xs-9 text-right">
                                                <div class="huge"><asp:Label runat="server" ID="lblEstadoMesomorfo"></asp:Label></div>
                                                <div><asp:Label runat="server" ID="lblResultadoMesomorfo"></asp:Label></div>
                                            </div>
                                        </div>
                                    </div>
                                    <a href="../../frm_GraficaMesomorfiaxJugador.aspx">
                                        <div class="panel-footer">
                                            <span class="pull-left">Más Detalles</span>
                                            <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                                            <div class="clearfix"></div>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <!-- /.col-lg-12 -->
                    </div> 
                    <div class="row">
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Resultados Endomorfia
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div13">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            Endomorfia
                                            <asp:TextBox runat="server" ID="txtEndomorfiaDato" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div14" style="visibility:hidden">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Button runat="server" ID="btnCompararEndomorfia" Text="Comparar Endomorfia" CssClass="btn btn-primary" OnClick="btnCompararEndomorfia_Click"></asp:Button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.panel -->
                        </div>
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Valores Optimos Endomorfia
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div15">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Portero" ID="lblPorteroEndomorfia"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtPorteroEndomorfia" Text="2,5" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div16">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Defensa" ID="lblDefensaEndomorfia"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtDefensaEndomorfia" Text="2,2" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div17">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Centrocampista" ID="lblCentroEndomorfia"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtCentrocampistaEndomorfia" Text="2,5" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div18">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Delantero" ID="lblDelanteroEndomorfia"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtDelanteroEndomorfia" Text="2,1" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="col-md-12 col-sm-12 col-xs-12">
                                <div class="panel panel-primary">
                                    <div class="panel-heading">
                                        <div class="row">
                                            <div class="col-xs-3">
                                                <i class="fa fa-comments fa-5x"></i>
                                            </div>
                                            <div class="col-xs-9 text-right">
                                                <div class="huge"><asp:Label runat="server" ID="lblEstadoEndomorfia"></asp:Label></div>
                                                <div><asp:Label runat="server" ID="lblResultadoEndomorfia"></asp:Label></div>
                                            </div>
                                        </div>
                                    </div>
                                    <a href="../../frm_GraficaEndomorfiaxJugador.aspx">
                                        <div class="panel-footer">
                                            <span class="pull-left">Más Detalles</span>
                                            <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                                            <div class="clearfix"></div>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <!-- /.col-lg-12 -->
                    </div> 
                    <!-- SOMATOCARTA -->
                    <div class="row">
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Resultados Eje X
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div19" style="visibility:hidden">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            Eje X
                                            <asp:TextBox runat="server" ID="txtEjeX" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.panel -->
                        </div>
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Valores Optimos Eje X
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div21">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Portero" ID="lblPorteroEjeX"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtPorteroEjeX" Text="-0,1" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div22">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Defensa" ID="lblDefensaEjeX"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtDefensaEjeX" Text="0,3" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div23">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Centrocampista" ID="lblCentroEjeX"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtCentroEjeX" Text="0" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div24">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Delantero" ID="lblDelanteroEjeX"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtDelanteroEjeX" Text="0,6" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="col-md-12 col-sm-12 col-xs-12">
                                <div class="panel panel-primary">
                                    <div class="panel-heading">
                                        <div class="row">
                                            <div class="col-xs-3">
                                                <i class="fa fa-comments fa-5x"></i>
                                            </div>
                                            <div class="col-xs-9 text-right">
                                                <div class="huge"><asp:Label runat="server" ID="lblEstadoEjeX"></asp:Label></div>
                                                <div><asp:Label runat="server" ID="lblResultadoEjeX"></asp:Label></div>
                                            </div>
                                        </div>
                                    </div>
                                    <a href="../../frm_Grafica_ResultadosAll.aspx">
                                        <div class="panel-footer">
                                            <span class="pull-left">Más Detalles</span>
                                            <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                                            <div class="clearfix"></div>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <!-- /.col-lg-12 -->
                    </div>
                    <div class="row">
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Resultados Eje Y
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div25">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            Eje Y
                                            <asp:TextBox runat="server" ID="txtEjeY" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div26" style="visibility:hidden">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Button runat="server" ID="btnComparaEjeY" Text="Somatocarta - Resultado Eje X - Eje Y" CssClass="btn btn-primary" OnClick="btnComparaEjeY_Click"></asp:Button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.panel -->
                        </div>
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Valores Optimos Eje Y
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div27">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Portero" ID="lblPorteroEjeY"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtPorteroEjeY" Text="5,5" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div28">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Defensa" ID="lblDefensaEjeY"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtDefensaEjeY" Text="5,7" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div29">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Centrocampista" ID="lblCentroEjeY"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtCentroEjeY" Text="5" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div30">
                                        <div class="col-md-12 col-sm-4 col-xs-12">
                                            <asp:Label runat="server" Text="Delantero" ID="lblDelanteroEjeY"></asp:Label>
                                            <asp:TextBox runat="server" ID="txtDelanteroEjeY" Text="5" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>  
                        <!-- /.col-lg-12 -->
                    </div>  
                </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
