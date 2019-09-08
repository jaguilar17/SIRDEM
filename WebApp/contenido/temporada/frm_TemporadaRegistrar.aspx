<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_TemporadaRegistrar.aspx.cs" Inherits="WebApp.contenido2.temporada.frm_TemporadaRegistrar" %>

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

        <script src="<%= ResolveClientUrl("~/js/Func_Espec/fun_Temporada.js") %>"></script>
    </asp:PlaceHolder>
    <script type="text/javascript">
        $(function () {
            //$(".ddlCateg").select2();
            $(".txtFechI").datepicker({
                numberOfMonths: 1,
                autoSize: true,
                showAnim: "drop",
                gotoCurrent: true,
                dateFormat: "dd/mm/yy",
                hideIfNoPrevNext: true,
                changeMonth: true,
                changeYear: true,
                minDate: new Date()
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
            <div style="padding: 14px 2px; font-size: 25px; font-weight: bold;">
                Maestro de Temporadas
            </div>

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
                        <div class="cuadro-body">
                            <div class="table-responsive">
                                <asp:GridView runat="server" ID="gvTemporada" AutoGenerateColumns="False" ShowFooter="True" AllowPaging="True"
                                    OnPageIndexChanging="gvTemporada_PageIndexChanging" BorderWidth="0px" CssClass="table table-bordered"
                                    OnRowCancelingEdit="gvTemporada_RowCancelingEdit"
                                    OnRowCommand="gvTemporada_RowCommand"
                                    OnRowDataBound="gvTemporada_RowDataBound"
                                    OnRowEditing="gvTemporada_RowEditing"
                                    OnRowUpdating="gvTemporada_RowUpdating" EmptyDataText="No se encontraron datos.">
                                    <Columns>
                                        <asp:TemplateField>
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>Código Temporada</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblCodTemporada" runat="server" Text='<% #Bind("codTemporada")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:Label ID="lblCodTemporadaEdit" runat="server" Text='<% #Bind("codTemporada")%>' />
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderStyle Width="25%" />
                                            <HeaderTemplate>Temporada</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" ID="lblNomTempo" Text='<% #Bind("temporadaNombre")%>' />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="txtNombreTempoEdit" CssClass="form-control" Text='<% #Bind("temporadaNombre")%>' Width="100%" />
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox runat="server" ID="txtNombreTempoAdd" CssClass="form-control" Width="100%" MaxLength="100" />
                                            </FooterTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                            <HeaderStyle Width="10%" />
                                            <HeaderTemplate>
                                                Fecha Inicio
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:HiddenField ID="hdnFechInicio" runat="server" Value='<% #Bind("temporadaFechaInicio")%>' />
                                                <asp:Label ID="lblFechInicio" runat="server" Text='<% #Eval("temporadaFechaInicio", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="txtFechInicioEdit" CssClass="txtFechI form-control datepicker datomaestrodisplay" Text='<% #Bind("temporadaFechaInicio")%>' Width="100%" />
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox runat="server" ID="txtFechInicioAdd" CssClass="txtFechI form-control datepicker datomaestrodisplay" />
                                                <asp:HiddenField ID="hdnFechInicioAdd" runat="server" Value='' />
                                            </FooterTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                                            <HeaderStyle Width="6%" />
                                            <HeaderTemplate>
                                                Duración (Días)
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblDuracion" runat="server" Text='<% #Bind("temporadaDuracionDias")%>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" ID="txtDuracionTempEdit" CssClass="form-control" Text='<% #Bind("temporadaDuracionDias")%>' />
                                            </EditItemTemplate>
                                            <FooterTemplate>
                                                <asp:TextBox runat="server" ID="txtDuracionTempAdd" CssClass="form-control" MaxLength="100" />
                                            </FooterTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                Fecha Fin
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblFechaFin" runat="server" Text='<% #Eval("temporadaFechaFin", "{0:dd/MM/yyyy}")%>'></asp:Label>
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" Width="5%" />
                                            <ItemStyle HorizontalAlign="Center" />
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

                                        <%--<asp:TemplateField>
                                            <HeaderStyle Width="3%" />
                                            <HeaderTemplate>
                                                Equipos
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Button runat="server" Text="Ver Equipos" CommandName="View" ID="btnViewReader"
                                                    ValidationGroup="Lector" ToolTip="Equipos que participan en el torneo" CssClass="btn btn-primary"
                                                    CommandArgument='<% #Bind("codTorneo")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>--%>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>

                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="gvTemporada" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
