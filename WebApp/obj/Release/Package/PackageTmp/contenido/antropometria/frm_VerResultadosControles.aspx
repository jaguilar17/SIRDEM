<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_VerResultadosControles.aspx.cs" Inherits="WebApp.contenido.antropometria.frm_VerResultadosControles" %>

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
                            <span class="cuadro-title">Controles de Valores Antropométricos</span>
                        </div>
                        <div class="cuadro-body">
                            <div class="table-responsive">
                                <asp:GridView runat="server" ID="gvControlAll" AutoGenerateColumns="False" ShowFooter="False" AllowPaging="True"
                                    OnPageIndexChanging="gvControlAll_PageIndexChanging" BorderWidth="0px" CssClass="table table-bordered"
                                    OnRowCancelingEdit="gvControlAll_RowCancelingEdit"
                                    OnRowCommand="gvControlAll_RowCommand"
                                    OnRowDataBound="gvControlAll_RowDataBound"
                                    OnRowEditing="gvControlAll_RowEditing"
                                    OnRowUpdating="gvControlAll_RowUpdating" EmptyDataText="No se encontraron datos.">
                                    <Columns>
                                        <asp:BoundField DataField="fechaControl" HeaderText="Fecha Control"/>
                                        <asp:BoundField DataField="ectomorfia" HeaderText="Ectomorfia" />
                                        <asp:BoundField DataField="mesomorfia" HeaderText="Mesomorfia"/>
                                        <asp:BoundField DataField="endomorfia" HeaderText="Endomorfia"/>
                                        <asp:BoundField DataField="ejeX" HeaderText="Eje X" />
                                        <asp:BoundField DataField="ejeY" HeaderText="Eje Y"/>
                                        <%--<asp:TemplateField>
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>Fecha Control</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblFechaControl" runat="server" Text='<% #Bind("fechaControl")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>Ectomorfia</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblEctomorfia" runat="server" Text='<% #Bind("ectomorfia")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                         <asp:TemplateField>
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>Mesomorfia</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblMesomorfia" runat="server" Text='<% #Bind("mesomorfia")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                         <asp:TemplateField>
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>Endomorfia</HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblEndomorfia" runat="server" Text='<% #Bind("endomorfia")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>
                                                Eje X
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" ID="lblEjeX" Text='<% #Bind("ejeX")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <HeaderStyle Width="5%" />
                                            <HeaderTemplate>
                                                Eje Y
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" ID="lblEjeY" Text='<% #Bind("ejeY")%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>--%>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="gvControlAll"/>
                </Triggers>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
