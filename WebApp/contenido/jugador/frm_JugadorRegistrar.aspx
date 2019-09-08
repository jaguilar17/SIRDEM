<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_JugadorRegistrar.aspx.cs" Inherits="WebApp.contenido2.jugador.frm_JugadorRegistrar" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
        <script src="<%= ResolveClientUrl("~/js/Func_Espec/fun_Jugador.js") %>"></script>

    </asp:PlaceHolder>
    <script type="text/javascript">
        $(function () {
            $(".ddlCategoria2").select2();
            $(".ddlLateralidad2").select2();
            $(".ddlPrincipal2").select2();
            $(".ddlAlternativa2").select2();
            $(".ddlApoderado2").select2();
            $.datepicker.setDefaults($.datepicker.regional["es"]);
            $(".txtFechNacJug").datepicker({
                numberOfMonths: 1,
                autoSize: true,
                showAnim: "drop",
                gotoCurrent: true,
                dateFormat: "dd/mm/yy",
                hideIfNoPrevNext: true,
                changeMonth: true,
                changeYear: true,
                yearRange: "1998:2002",
                maxDate: new Date(2002,12,31)
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

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="panel panel-success">
                                <div class="panel-heading">
                                    Cuenta de Usuario
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="divCuenta">
                                        <div class="col-md-8 col-sm-4 col-xs-12">
                                            Usuario:
                                            <asp:TextBox runat="server" ID="txtUsuarioJugador" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="divCuentaClave">
                                        <div class="col-md-8 col-sm-4 col-xs-12">
                                            Contraseña:
                                            <asp:TextBox runat="server" ID="txtJugadorClave" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
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
                                    Datos Elementales
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="divNombresApellidos">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Nombres:
                                            <asp:TextBox runat="server" ID="txtNombreUsu" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Apellido Paterno:
                                            <asp:TextBox runat="server" ID="txtApellidoPatUsu" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Apellido Materno:
                                            <asp:TextBox runat="server" ID="txtApellidoMatUsu" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="divDatosPer">
                                        <div class="col-md-3 col-sm-3 col-xs-12">
                                            Correo Electrónico:
                                            <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="col-md-3 col-sm-3 col-xs-12">
                                            Dirección:
                                            <asp:TextBox runat="server" ID="txtDireccionJugador" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="col-md-3 col-sm-3 col-xs-12">
                                            Número DNI:
                                            <asp:TextBox runat="server" ID="txtNumDNI" CssClass="form-control" onkeypress="return numbersonly(event);" MaxLength="8" MinLength="8"></asp:TextBox>
                                        </div>
                                        <div class="col-md-3 col-sm-3 col-xs-12">
                                            Telefono o Celular:
                                            <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" onkeypress="return numbersonly(event);" MaxLength="9" MinLength="9"></asp:TextBox>
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
                                    Datos Futbolísticos
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="div3">
                                        <div class="col-md-2 col-sm-3 col-xs-12">
                                            Temporada:
                                        </div>
                                        <div class="col-md-4 col-sm-3 col-xs-12">
                                            <asp:HiddenField ID="hdnTemporada2" runat="server" Value="0" />
                                            <asp:DropDownList runat="server" ID="ddlTemporadaJug2" CssClass="ddlCategoria2 form-control">
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-md-2 col-sm-3 col-xs-12">
                                            Equipo:
                                        </div>
                                        <div class="col-md-4 col-sm-3 col-xs-12">
                                            <asp:HiddenField ID="hdnEquipo2" runat="server" Value="0" />
                                            <asp:DropDownList runat="server" ID="ddlEquipoJug2" CssClass="ddlCategoria2 form-control" AutoPostBack="false">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div1">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Alias:
                                            <asp:TextBox runat="server" ID="txtAliasJug" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Número Dorsal:
                                            <asp:TextBox runat="server" ID="txtNumDorsalJug" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Club Procedencia:
                                            <asp:TextBox runat="server" ID="txtProcedJug" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div2">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Fecha Nacimiento:
                                            <asp:TextBox runat="server" ID="txtFechNacJug" CssClass="txtFechNacJug form-control datepicker"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Peso Inicial:
                                            <asp:TextBox runat="server" ID="txtPesoJug" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Talla Inicial:
                                            <asp:TextBox runat="server" ID="txtTallaJug" CssClass="form-control" onkeypress="return numbersonly(event);"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="divLateralidad">
                                        <div class="col-md-2 col-sm-3 col-xs-12">
                                            Lateralidad:
                                        </div>
                                        <div class="col-md-4 col-sm-9 col-xs-12">
                                            <asp:DropDownList runat="server" ID="ddlLateralidad" CssClass="ddlLateralidad2 form-control" MaxLength="100">
                                                <asp:ListItem Text="Seleccionar una lateralidad" Value="0" />
                                                <asp:ListItem Text="Diestro" Value="D" />
                                                <asp:ListItem Text="Zurdo" Value="Z" />
                                                <asp:ListItem Text="Ambidiestro" Value="A" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="divPosPrincip">
                                        <div class="col-md-2 col-sm-3 col-xs-12">
                                            Posición Principal:
                                        </div>
                                        <div class="col-md-4 col-sm-9 col-xs-12">
                                            <asp:DropDownList runat="server" ID="ddlPrincipal" CssClass="ddlPrincipal2 form-control" MaxLength="100" />
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="divPosAlternativa">
                                        <div class="col-md-2 col-sm-3 col-xs-12">
                                            Posición Alternativa:
                                        </div>
                                        <div class="col-md-4 col-sm-9 col-xs-12">
                                            <asp:DropDownList runat="server" ID="ddlAlternativa" CssClass="ddlAlternativa2 form-control" MaxLength="100" />
                                        </div>
                                    </div>
                                    <div class="row" id="div4">
                                        <div class="col-md-4 col-sm-9 col-xs-12">
                                            <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" />
                                        </div>
                                    </div>
                                    <br />

                                </div>
                            </div>
                            <!-- /.panel -->
                        </div>
                        <!-- /.col-lg-12 -->
                    </div>

                </ContentTemplate>
            </asp:UpdatePanel>
    </form>
</body>
</html>
