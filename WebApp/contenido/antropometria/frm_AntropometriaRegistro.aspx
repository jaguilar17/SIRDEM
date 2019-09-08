<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_AntropometriaRegistro.aspx.cs" Inherits="WebApp.contenido2.antropometria.frm_AntropometriaRegistro" %>

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

    </asp:PlaceHolder>
    <script type="text/javascript">
        $(function () {
            $(".ddlPerfil").select2();
            $.datepicker.setDefaults($.datepicker.regional["es"]);
            $(".txtFechNacPer").datepicker({
                numberOfMonths: 1,
                autoSize: true,
                showAnim: "drop",
                gotoCurrent: true,
                dateFormat: "dd/mm/yy",
                hideIfNoPrevNext: true,
                changeMonth: true,
                changeYear: true,
                yearRange: "-100:+0",
                maxDate: new Date()
            });
        });

        function numbersonly(e) {
            var unicode = e.charCode ? e.charCode : e.keyCode
            if (unicode != 8 && unicode != 44 && unicode != 46) {// && unicode != 44(,) - 46(.)
                if (unicode < 48 || unicode > 57) //if not a number
                {
                    return false //solo numeros
                }
            }
        }
    </script>
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
                        <div class="col-lg-12">
                            <h1 class="page-header">Valoración Antropométrica</h1>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="panel panel-success">
                                <div class="panel-heading">
                                    Datos del Jugador
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="divCuenta">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Apodo:
                                            <asp:TextBox runat="server" ID="txtApodoJugador" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Nombre Completo:
                                            <asp:TextBox runat="server" ID="txtNombreCompleto" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Equipo:
                                            <asp:TextBox runat="server" ID="txtEquipoNombre" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div9">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Posición:
                                            <asp:TextBox runat="server" ID="txtPosicion" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Peso Inicial:
                                            <asp:TextBox runat="server" ID="txtPesoInicial" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Talla Inicial:
                                            <asp:TextBox runat="server" ID="txtTallaInicial" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.panel -->
                        </div>
                        <!-- /.col-lg-12 -->
                    </div>
                     <div class="row">
                        <div class="col-lg-12">
                            <div class="panel panel-success">
                                <div class="panel-heading">
                                    Control
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div8">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Fecha:
                                            <asp:TextBox runat="server" ID="txtFechaControl" CssClass="txtFechNacPer form-control datepicker"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Peso:
                                            <asp:TextBox runat="server" ID="txtPesoControl" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Talla:
                                            <asp:TextBox runat="server" ID="txtTallaControl" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.panel -->
                        </div>
                        <!-- /.col-lg-12 -->
                    </div>
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Datos Antropométricos - Perímetros (cm)
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="divNombresApellidos">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Brazo:
                                            <asp:TextBox runat="server" ID="txtBrazoPerimetro" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Pecho:
                                            <asp:TextBox runat="server" ID="txtPechoPerimetro" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Abdomen:
                                            <asp:TextBox runat="server" ID="txtAbdomenPerimetro" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="divDatosPer">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Cadera:
                                            <asp:TextBox runat="server" ID="txtCaderaPerimetro" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Muslo:
                                            <asp:TextBox runat="server" ID="txtMusloPerimetro" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Gemelo:
                                            <asp:TextBox runat="server" ID="txtGemeloPerimetro" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.panel -->
                        </div>
                        <!-- /.col-lg-12 -->
                    </div>
                     <div class="row">
                        <div class="col-lg-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Datos Antropométricos - Longitud (cm)
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div1">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Húmero:
                                            <asp:TextBox runat="server" ID="txtHumeroLongitud" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Fémur:
                                            <asp:TextBox runat="server" ID="txtFemurLongitud" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Muñeca:
                                            <asp:TextBox runat="server" ID="txtMunecaLongitud" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                    </div>

                                </div>
                            </div>
                            <!-- /.panel -->
                        </div>
                        <!-- /.col-lg-12 -->
                    </div>
                     <div class="row">
                        <div class="col-lg-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Datos Antropométricos - Pliegues Cutaneos
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div2">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Tríceps:
                                            <asp:TextBox runat="server" ID="txtTrícepsPliegues" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Muslo:
                                            <asp:TextBox runat="server" ID="txtMusloPliegues" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Supraespinal:
                                            <asp:TextBox runat="server" ID="txtSupraespinalPliegues" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div3">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Pectoral:
                                            <asp:TextBox runat="server" ID="txtPectoralPliegues" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Abdominal:
                                            <asp:TextBox runat="server" ID="txtAbdominalPliegues" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Gemelo:
                                            <asp:TextBox runat="server" ID="txtGemeloPliegues" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.panel -->
                        </div>
                        <!-- /.col-lg-12 -->
                    </div>
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="panel panel-info">
                                <div class="panel-body">
                                    <div class="row" id="div4">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            <asp:Button runat="server" ID="btnGuardarDatos" text="Guardar y Calcular datos antropométricos" CssClass="btn btn-primary" OnClick="btnGuardarDatos_Click"></asp:Button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Somatotipo (n)
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div5">
                                        <div class="col-md-4 col-sm-3 col-xs-12">
                                            Ectomorfia:
                                            <asp:TextBox runat="server" ID="txtEctomorfia" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-3 col-xs-12">
                                            Mesomorfia:
                                            <asp:TextBox runat="server" ID="txtMesomorfia" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-3 col-xs-12">
                                            Endomorfia:
                                            <asp:TextBox runat="server" ID="txtEndomorfia" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                     <div class="row">
                        <div class="col-lg-12">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Somatocarta (n)
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div6">
                                        <div class="col-md-4 col-sm-3 col-xs-12">
                                            Eje X:
                                            <asp:TextBox runat="server" ID="txtEjeX" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-3 col-xs-12">
                                            Eje Y:
                                            <asp:TextBox runat="server" ID="txtEjeY" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="panel panel-info">
                                <div class="panel-body">
                                    <div class="row" id="div7">
                                        <%--<div class="col-md-4 col-sm-4 col-xs-12">
                                            <asp:Button runat="server" ID="btnCalcular" text="Calcular somatotipo y somatocarta" CssClass="btn btn-primary" OnClick="btnCalcular_Click"></asp:Button>
                                        </div>--%>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            <asp:Button runat="server" ID="btnRegresar" text="Terminar" CssClass="btn btn-primary" OnClick="btnRegresar_Click"></asp:Button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
