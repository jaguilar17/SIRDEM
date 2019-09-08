<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_PersonaRegistrar.aspx.cs" Inherits="WebApp.contenido2.personal.frm_PersonaRegistrar" %>

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
        <script src="<%= ResolveClientUrl("~/js/Func_Espec/fun_Persona.js") %>"></script>

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
                yearRange: "1965:1997",
                maxDate: new Date(1997,12,31)
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
                        <div class="col-lg-6">
                            <div class="panel panel-success">
                                <div class="panel-heading">
                                    Cuenta de Usuario
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="divPerfil">
                                        <div class="col-md-8 col-sm-4 col-xs-12">
                                            Perfil:
                                            <asp:DropDownList runat="server" ID="ddlPerfilAdd" CssClass="ddlPerfil form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="divCuenta">
                                        <div class="col-md-8 col-sm-4 col-xs-12">
                                            Usuario:
                                            <asp:TextBox runat="server" ID="txtUsuarioPersona" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="divCuentaClave">
                                        <div class="col-md-8 col-sm-4 col-xs-12">
                                            Contraseña:
                                            <asp:TextBox runat="server" ID="txtUsuarioContrasenia" CssClass="form-control"></asp:TextBox>
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
                        <div class="col-lg-6">
                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    Datos Elementales
                                </div>
                                <div class="panel-body">
                                    <div class="row" id="divNombresApellidos">
                                        <div class="col-md-8 col-sm-4 col-xs-12">
                                            Nombres:
                                            <asp:TextBox runat="server" ID="txtNombrePers" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div1">
                                        <div class="col-md-8 col-sm-4 col-xs-12">
                                            Apellido Paterno:
                                            <asp:TextBox runat="server" ID="txtApellidoPatPers" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div2">
                                        <div class="col-md-8 col-sm-4 col-xs-12">
                                            Apellido Materno:
                                            <asp:TextBox runat="server" ID="txtApellidoMatPers" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="divDatosPer">
                                        <div class="col-md-8 col-sm-4 col-xs-12">
                                            Correo Electrónico:
                                            <asp:TextBox runat="server" ID="txtCorreoPersona" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div3">
                                        <div class="col-md-8 col-sm-4 col-xs-12">
                                            Dirección:
                                            <asp:TextBox runat="server" ID="txtDireccionPersona" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div5">
                                        <div class="col-md-8 col-sm-4 col-xs-12">
                                            Número DNI:
                                            <asp:TextBox runat="server" ID="txtNumDNIPersona" CssClass="form-control" onkeypress="return numbersonly(event);" MaxLength="8" MinLength="8"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div6">
                                        <div class="col-md-8 col-sm-4 col-xs-12">
                                            Telefono o Celular:
                                            <asp:TextBox runat="server" ID="txtTelefonoPersona" CssClass="form-control" onkeypress="return numbersonly(event);" MaxLength="9" MinLength="9"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row" id="div4">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            Fecha Nacimiento:
                                            <asp:TextBox runat="server" ID="txtFechaNacPersona" CssClass="txtFechNacPer form-control datepicker"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row" id="div7">
                                        <div class="col-md-4 col-sm-4 col-xs-12">
                                            <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click"/>
                                        </div>
                                    </div>
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
