<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_VerPlantilla.aspx.cs" Inherits="WebApp.contenido2.equipo.frm_VerPlantilla" %>

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

        <script src="<%= ResolveClientUrl("~/js/Func_Espec/fun_torneoxequipo.js") %>"></script>
    </asp:PlaceHolder>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="true" EnablePageMethods="true"
            EnableScriptLocalization="true">
        </asp:ScriptManager>
    <div>
            <div class="cuadro-container">
                <div class="cuadro-heading">
                    Búsqueda
                </div>
                <div class="cuadro-body">
                    <div class="row">
                        <div class="col-md-4 col-sm-3 col-xs-12">
                            <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-4 col-sm-3 col-xs-12">
                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn" OnClick="btnBuscar_Click" />
                        </div>
                        <div class="col-md-4 col-sm-3 col-xs-12"></div>
                    </div>
                </div>
            </div>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <div class="cuadro-container">
                        <div class="cuadro-heading">
                            <span class="cuadro-title">Plantel de Jugadores</span>
                        </div>
                        <div class="cuadro-body">
                            <div class="table-responsive">
                                <asp:GridView runat="server" ID="gvPlantillaxEquipo" AutoGenerateColumns="False" ShowFooter="False" AllowPaging="True"
                                    OnPageIndexChanging="gvPlantillaxEquipo_PageIndexChanging" BorderWidth="0px" CssClass="table table-bordered"
                                    OnRowCancelingEdit="gvPlantillaxEquipo_RowCancelingEdit"
                                    OnRowCommand="gvPlantillaxEquipo_RowCommand"
                                    OnRowDataBound="gvPlantillaxEquipo_RowDataBound"
                                    OnRowEditing="gvPlantillaxEquipo_RowEditing"
                                    OnRowUpdating="gvPlantillaxEquipo_RowUpdating" EmptyDataText="No se encontraron datos.">
                                    <Columns>
                                        <asp:TemplateField Visible="false">
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>Código Plantilla</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblCodPlantillaAdd" runat="server" Text='<% #Bind("codPlantilla")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>Código Equipo</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblCodEquipo" runat="server" Text='<% #Bind("codEquipo")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderStyle Width="25%" />
                                            <HeaderTemplate>
                                                Jugador
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" ID="lblDatosJugador" Text='<% #Bind("nombreCompleto")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>

                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="gvPlantillaxEquipo" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
