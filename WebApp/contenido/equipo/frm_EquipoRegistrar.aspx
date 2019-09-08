<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_EquipoRegistrar.aspx.cs" Inherits="WebApp.contenido2.equipo.frm_EquipoRegistrar" %>

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
    </asp:PlaceHolder>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="true" EnablePageMethods="true"
            EnableScriptLocalization="true">
        </asp:ScriptManager>
        <div>
            <div style="padding: 14px 2px; font-size: 25px; font-weight: bold;">
                Maestro de Equipos
            </div>

            <div class="row">
                <div class="col-lg-12">
                    <div class="panel panel-success">
                        <div class="panel-heading">
                            Búsqueda
                        </div>
                        <div class="panel-body">
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
                </div>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <div class="cuadro-container">
                        <div class="cuadro-body">
                            <div class="table-responsive">
                                <asp:GridView runat="server" ID="gvEquipo" AutoGenerateColumns="False" ShowFooter="True" AllowPaging="True"
                                    OnPageIndexChanging="gvEquipo_PageIndexChanging" BorderWidth="0px" CssClass="table table-bordered"
                                    OnRowCancelingEdit="gvEquipo_RowCancelingEdit"
                                    OnRowCommand="gvEquipo_RowCommand"
                                    OnRowDataBound="gvEquipo_RowDataBound"
                                    OnRowEditing="gvEquipo_RowEditing"
                                    OnRowUpdating="gvEquipo_RowUpdating" EmptyDataText="No se encontraron datos.">
                                    <Columns>
                                        <asp:TemplateField Visible="false">
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>Código Equipo</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblCodEquipo" runat="server" Text='<% #Bind("codEquipo")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:Label ID="lblCodEquipoEdit" runat="server" Text='<% #Bind("codEquipo")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderStyle Width="15%" />
                                            <HeaderTemplate>Equipo</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" ID="lblNomEquipo" Text='<% #Bind("equipoNombre")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="txtNombreEquipoEdit" CssClass="form-control" Text='<% #Bind("equipoNombre")%>' Width="100%" MaxLength="200" />
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox runat="server" ID="txtNombreEquipoAdd" CssClass="form-control" Width="100%" MaxLength="200" />
                                            </FooterTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderStyle Width="15%" />
                                            <HeaderTemplate>Sede</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" ID="lblDesEquipo" Text='<% #Bind("equipoDescripcion")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="txtDesEquipoEdit" CssClass="form-control" Text='<% #Bind("equipoDescripcion")%>' Width="100%" MaxLength="200" />
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox runat="server" ID="txtDesEquipoAdd" CssClass="form-control" Width="100%" MaxLength="200" />
                                            </FooterTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderStyle Width="15%" />
                                            <HeaderTemplate>Director Tecnico</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" ID="lblDTEquipo" Text='<% #Bind("equipoDirectorTecnico")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:HiddenField ID="hdnNombreDT" runat="server" Value='<% #Bind("equipoDirectorTecnico")%>' />
                                                <%--  <asp:HiddenField ID="hdnCodUsuarioDT" runat="server" Value='<% #Bind("codUsuario")%>' />--%>
                                                <asp:DropDownList runat="server" ID="ddlDTEquipoEdit" CssClass="form-control" Width="100%" MaxLength="200" />
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:DropDownList runat="server" ID="ddlDTEquipoAdd" CssClass="form-control" Width="100%" MaxLength="200" />
                                            </FooterTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderStyle Width="15%" />
                                            <HeaderTemplate>Asistente Tecnico</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" ID="lblATEquipo" Text='<% #Bind("equipoAsistenteTecnico")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:HiddenField ID="hdnNombreAT" runat="server" Value='<% #Bind("equipoAsistenteTecnico")%>' />
                                                <%--<asp:HiddenField ID="hdnCodUsuarioAT" runat="server" Value='<% #Bind("codUsuario")%>' />--%>
                                                <asp:DropDownList runat="server" ID="ddlATEquipoEdit" CssClass="form-control" Width="100%" MaxLength="200" />
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:DropDownList runat="server" ID="ddlATEquipoAdd" CssClass="form-control" Width="100%" MaxLength="200" />
                                            </FooterTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderStyle Width="8%" />
                                            <HeaderTemplate>N°Jugador</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" ID="lblNumMaxJug" Text='<% #Bind("numMaxJugador")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="txtNumMaxJugEdit" CssClass="form-control" Text='<% #Bind("numMaxJugador")%>' Width="100%" />
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox runat="server" ID="txtNumMaxJugAdd" CssClass="form-control" Width="100%" />
                                            </FooterTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderStyle Width="15%" />
                                            <HeaderTemplate>Temporada</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" ID="lblTempoEquipo" Text='<% #Bind("temporadaNombre")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:HiddenField ID="hdnNombreTemporada" runat="server" Value='<% #Bind("temporadaNombre")%>' />
                                                <asp:HiddenField ID="hdnCodTemporada" runat="server" Value='<% #Bind("codTemporada")%>' />
                                                <asp:DropDownList runat="server" ID="ddlTemporadaEdit" CssClass="form-control" Width="100%" MaxLength="200" />
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:DropDownList runat="server" ID="ddlTemporadaAdd" CssClass="form-control" Width="100%" MaxLength="200" />
                                            </FooterTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                            <HeaderTemplate>Habilitado </HeaderTemplate>
                                            <ItemStyle Width="3%" />
                                            <ItemTemplate>
                                                <asp:CheckBox runat="server" ID="chkHabilitado" Enabled="false" Checked='<%# Bind("IB_Mostrar") %>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:CheckBox runat="server" ID="chkHabilitadoEdit" Enabled="true" Checked='<%# Bind("IB_Mostrar") %>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <ItemStyle Width="3%" />
                                            <EditItemTemplate>
                                                <asp:LinkButton runat="server" Text="Actualizar" CommandName="Update" ID="lnkUpdate" CssClass="btn btn-danger"
                                                    CommandArgument='<%# Container.DataItemIndex%>' />&nbsp;
                                                <asp:LinkButton runat="server" Text="Cancelar" CommandName="Cancel" ID="lnkCancel" CommandArgument='<%# Container.DataItemIndex%>' />
                                            </EditItemTemplate>

                                            <FooterTemplate>
                                                <asp:Button runat="server" Text="Agregar" CommandName="AddItem" ID="lnkAddItem" CommandArgument='<%# Container.DataItemIndex%>'
                                                    ValidationGroup="Add" ToolTip="Guardar" CssClass="btn btn-danger" />&nbsp;
                                                <asp:LinkButton runat="server" Text="Cancelar" CommandName="CancelItem" ID="lnkCancelItem" Visible="false"
                                                    CommandArgument='<%# Container.DataItemIndex%>' />
                                            </FooterTemplate>
                                            <ItemTemplate>
                                                <asp:LinkButton runat="server" Text="Editar" ID="lnkEdit" CommandName="Edit" CommandArgument='<%# Container.DataItemIndex%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderStyle Width="3%" />
                                            <HeaderTemplate>
                                                Plantilla
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Button runat="server" Text="Ver Plantilla" CommandName="View" ID="btnViewReader"
                                                    ValidationGroup="Lector" ToolTip="Jugadores que pertenecen al equipo" CssClass="btn btn-primary"
                                                    CommandArgument='<% #Bind("codEquipo")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                    </Columns>
                                </asp:GridView>

                            </div>
                        </div>
                    </div>

                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="gvEquipo" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
