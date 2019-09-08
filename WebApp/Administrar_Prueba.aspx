<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrar_Prueba.aspx.cs" Inherits="WebApp.Administrar_Prueba" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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
    </asp:PlaceHolder>
    <style type="text/css">
        .hidden-field {
            display: none;
        }

        .cuadro-heading {
            text-align: left;
        }

        .col-xs-12 {
            text-align: left;
        }

        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <asp:Panel ID="Panel5" runat="server" Style="text-align: center" BackColor="Silver">
                    <asp:Label ID="Label1" runat="server" Style="font-size: xx-large" Text="Participantes registrados en el sistema"></asp:Label>
                </asp:Panel>
                <asp:Panel ID="Apanel" runat="server">
                    <div class="cuadro-container">
                        <div class="cuadro-heading">
                            Seleccion de Participante
                        </div>
                        <div class="cuadro-body">
                            <div class="row">
                                <div class="col-md-4 col-sm-3 col-xs-12">
                                    <asp:Label ID="Label2" runat="server" Text="Escoja a un participante: "> </asp:Label>

                                    <asp:Panel ID="Panel2" runat="server" Visible="False" Width="320px">
                                        <asp:Label ID="fanton1" runat="server">0</asp:Label>
                                        <asp:Label ID="fanton2" runat="server">0</asp:Label>
                                        <asp:Label ID="fanton3" runat="server">0</asp:Label>
                                    </asp:Panel>

                                </div>
                                <br />
                                <br />
                                <div class="col-md-4 col-sm-3 col-xs-12">
                                    <asp:ScriptManager runat="server"></asp:ScriptManager>

                                    <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered" AllowPaging="True" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="7" Style="text-align: center; margin-top: 0px;" Width="900px">


                                        <Columns>
                                            <asp:BoundField DataField="codJugador" FooterText=" Codigo" HeaderText="Codigo">
                                                <ItemStyle Wrap="True" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="usuarioNombre" FooterText="Nombre" HeaderText="Nombre">
                                                <ItemStyle Wrap="True" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="usuarioApePaterno" FooterText="Apellido Paterno" HeaderText="Apellido Paterno" />
                                            <asp:BoundField DataField="usuarioApeMaterno" FooterText="Apellido Ma" HeaderText="Apellido Materno" />
                                            <asp:BoundField DataField="usuarioNumDNI" FooterText="DNI" HeaderText="DNI" />
                                            <asp:BoundField DataField="pesoInicial" FooterText="Peso" HeaderText="Peso" />
                                            <asp:BoundField DataField="tallaInicial" FooterText="Talla" HeaderText="Talla" />
                                            <%--                                        <asp:BoundField DataField="categoria" FooterText="Categoria" HeaderText="Categoria" />--%>
                                            <asp:CommandField HeaderText="Realizar" SelectText="Prueba" ShowHeader="True" ShowSelectButton="True" SortExpression="8" ButtonType="Button" ControlStyle-CssClass="tn btn-primary">
                                                <ControlStyle CssClass="tn btn-primary" />
                                            </asp:CommandField>
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                </asp:Panel>

                <asp:Panel ID="Bpanel" runat="server" Height="360px" Visible="False">

                    <asp:Panel ID="Panel43" runat="server">
                        <div class="cuadro-container">
                            <div class="cuadro-heading">
                                Participante
                            </div>

                            <div>
                                <div class="cuadro-body">
                                    <div class="auto-style2">
                                        <asp:Label ID="Label44" runat="server" Text="Nombre y Apellidos : "> </asp:Label>
                                        &nbsp;&nbsp;&nbsp;
                                                     <asp:Label ID="lblNombreApellido" runat="server" Text=""> </asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <asp:Label ID="Label6" runat="server" Text="Codigo:  "></asp:Label>
                                        &nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="CodJugadorLabel" runat="server"></asp:Label>
                                        <asp:Label ID="lan" runat="server" Visible="False"></asp:Label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="cuadro-container">
                        <div class="cuadro-heading">
                            Nueva Prueba
                        </div>
                        <div>
                            <div class="cuadro-body">
                                <div class="row">
                                    <table class="auto-style1">
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="lblNombrePrue" runat="server"></asp:Label>
                                            </td>
                                            <td class="auto-style2">
                                                <asp:Button ID="btnFormulario" runat="server" CssClass="btn" OnClick="Button1_Click" Text="Mostrar Formulario" Width="157px" />
                                            </td>
                                        </tr>
                                    </table>
                                </div>

                            </div>
                        </div>
                    </div>

                    <asp:Panel ID="PanelGrilla2" runat="server" Style="text-align: center">

                        <div class="cuadro-container">
                            <div class="cuadro-heading">
                                Pruebas Ingresadas
                            </div>
                            <div>
                                <div class="cuadro-body">
                                    <div class="row">
                                        <br />

                                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered" Style="text-align: center">


                                            <Columns>

                                                <asp:BoundField DataField="codPrueba" FooterText=" Codigo" HeaderText="Codigo">
                                                    <ItemStyle Wrap="True" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="dia" FooterText="Dia" HeaderText="Dia" DataFormatString="{0:dd/MM/yyyy}">
                                                    <ItemStyle Wrap="True" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="hora" FooterText="Hora" HeaderText="Hora" />
                                                <asp:BoundField DataField="lugar" FooterText="Lugar" HeaderText="Lugar" />
                                                <asp:BoundField DataField="descripcionGeneral" FooterText="Descripcion" HeaderText="Descripcion" />
                                                <asp:BoundField DataField="resultado" FooterText="Resultado" HeaderText="Resultado">

                                                    <ItemStyle ForeColor="Blue" />
                                                </asp:BoundField>

                                            </Columns>


                                        </asp:GridView>
                                        <asp:Label ID="lblct" runat="server" Visible="False"></asp:Label>
                                        <br />
                                        <br />
                                        <div class="auto-style2">
                                            <asp:Panel ID="Panel3" runat="server">
                                                &nbsp;<asp:Button ID="btnInforme" runat="server" CssClass="btn" OnClick="btnInforme_Click" Text="Generar informe final" Visible="False" />
                                                <asp:Button ID="btnNota" runat="server" CssClass="btn" OnClick="btnNota_Click" Text="Generar informe de rendimiento" Visible="False" />
                                                <br />
                                                <asp:Label ID="lblCodPrueba" runat="server" Visible="False"></asp:Label>
                                                <asp:Label ID="lblCodPrueba2" runat="server" Visible="False"></asp:Label>
                                                <asp:Label ID="lblCodPrueba3" runat="server" Visible="False"></asp:Label>
                                            </asp:Panel>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                </asp:Panel>
            </div>
        </div>
    </form>
</body>
</html>
