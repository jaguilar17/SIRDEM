<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_VerTodosJugadores.aspx.cs" Inherits="WebApp.contenido2.antropometria.frm_VerTodosJugadores" %>

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
        <link href="<%= ResolveClientUrl("~/Tools/dataTable/dataTables.bootstrap.min.css") %>" rel="stylesheet" />
        <script src="<%= ResolveClientUrl("~/Tools/dataTable/dataTables.bootstrap.min.js") %>"></script>
        <script src="<%= ResolveClientUrl("~/Tools/dataTable/jquery.dataTables.min.js") %>"></script>

    </asp:PlaceHolder>
      <script>
          $(function () {
              $(".gvDataTB").DataTable({
                  scrollY: 350,
                  scrollCollapse: true,
                  "scrollX": true
              });
          });
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

                    <div class="cuadro-container">
                        <div class="cuadro-heading">
                            <span class="cuadro-title">Jugadores</span>
                        </div>
                        <div class="cuadro-body">
                            <div class="table-responsive">
                                <asp:GridView runat="server" ID="gvJugadoresAll" AutoGenerateColumns="False" ShowFooter="False" AllowPaging="True"
                                    OnPageIndexChanging="gvJugadoresAll_PageIndexChanging" BorderWidth="0px" CssClass="table table-bordered table-interna table-striped gvDataTB"
                                    OnRowCancelingEdit="gvJugadoresAll_RowCancelingEdit"
                                    OnRowCommand="gvJugadoresAll_RowCommand"
                                    OnRowDataBound="gvJugadoresAll_RowDataBound"
                                    OnRowEditing="gvJugadoresAll_RowEditing"
                                    OnRowUpdating="gvJugadoresAll_RowUpdating" EmptyDataText="No se encontraron datos.">
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
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>Nombre Equipo</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblNombreEquipo" runat="server" Text='<% #Bind("equipoNombre")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                         <asp:TemplateField>
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>Código Jugador</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblCodJugador" runat="server" Text='<% #Bind("codJugador")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <HeaderStyle Width="8%" />
                                            <HeaderTemplate>
                                                Jugador
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" ID="lblDatosJugador" Text='<% #Bind("nombreCompleto")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>
                                                Posicion
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" ID="lblPosicionJugador" Text='<% #Bind("descripcionPosicion")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                         <asp:TemplateField>
                                            <HeaderStyle Width="3%" />
                                            <HeaderTemplate>
                                                Datos Antropométricos
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Button runat="server" Text="Ver Datos" CommandName="View" ID="btnViewReader"
                                                    ValidationGroup="Lector" ToolTip="Datos Antropometricos de Jugadores que pertenecen al equipo" CssClass="btn btn-primary"
                                                    CommandArgument='<% #Bind("codJugador")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <HeaderStyle Width="3%" />
                                            <HeaderTemplate>
                                                Evaluar Datos
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Button runat="server" Text="Ver Resultados" CommandName="View2" ID="btnViewReader2"
                                                    ValidationGroup="Lector" ToolTip="Ver ultimo resultado antropometrico" CssClass="btn btn-primary"
                                                    CommandArgument='<% #Bind("codJugador")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <HeaderStyle Width="3%" />
                                            <HeaderTemplate>
                                                Controles
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Button runat="server" Text="Ver Controles" CommandName="View3" ID="btnViewReader3"
                                                    ValidationGroup="Lector" ToolTip="Ver controles antropometricos" CssClass="btn btn-primary"
                                                    CommandArgument='<% #Bind("codJugador")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>

                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="gvJugadoresAll" />
                </Triggers>
            </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
