<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sede2.aspx.cs" Inherits="WebApp.Sede2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sede</title>
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
 .hidden-field
 {
     display:none;
 }
    .cuadro-heading {
        text-align: left;
    }

</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="PanelPrincipalSede" runat="server" style="text-align: center">
            <div class="container">
            <div class="cuadro-container">
        <div class="cuadro-heading">
            Ingresar Nueva Sede
        </div>
        <div class="cuadro-body">
            <div class="row">
                <div class="col-md-4 col-sm-3 col-xs-12">
                    <asp:Label ID="Label1" runat="server" Text="Ingresar Nueva Sede:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn" OnClick="btnIngresar_Click"  />
                </div>
            </div>
        </div>
       </div>
                </div>

            <div class="container" >
                <asp:ScriptManager runat="server"></asp:ScriptManager>
                    <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand" PageSize="7">
                        <Columns>
                            <asp:BoundField DataField="idSede" FooterText="Id" HeaderText="Id" />
                            <asp:BoundField FooterText="Nombre" HeaderText="Nombre" DataField="nombre" />
                            <asp:BoundField FooterText="Direccion" HeaderText="Direccion" DataField="direccion" />
                            <asp:BoundField FooterText="Referencia" HeaderText="Referencia" DataField="referencia" />
                            <asp:BoundField DataField="fechainicio" HeaderText="Fecha Inicio" ItemStyle-Width="10%" DataFormatString="{0:dd/MM/yyyy}" FooterText="Fecha Inicio">
                            <ItemStyle Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField DataField="fechafin" HeaderText="Fecha Fin" ItemStyle-Width="10%" DataFormatString="{0:dd/MM/yyyy}" FooterText="Fecha Fin">
                            <ItemStyle Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField DataField="costo" FooterText="Costo" HeaderText="Costo" />
                            <asp:ButtonField CommandName="Modificar" HeaderText="Modificar" Text="Modificar" ButtonType="Button" />
                            <asp:ButtonField CommandName="Eliminar" HeaderText="Eliminar" Text="Eliminar" ButtonType="Button" />
                        </Columns>
                    </asp:GridView>

            </div>
            <hr />
            <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-4"><CENTER><asp:Label ID="LabelPrincipal" runat="server" Text=""></asp:Label></CENTER></div>
                    <div class="col-md-4"></div>
                </div>
        </asp:Panel>

        <asp:Panel ID="PanelRegistrar" runat="server" Visible="false">

            <div class="container">
                
                <div class="row">
                    <div class="col-md-4"></div>
                    <div class="col-md-4"><CENTER><asp:Label ID="Label2" runat="server" Text="Id:"></asp:Label>&nbsp<asp:TextBox ID="txtid" runat="server" Width="40px"></asp:TextBox></CENTER></div>
                    <div class="col-md-4"></div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-4"><asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp <asp:TextBox ID="txtnombre" runat="server" Width="200px"></asp:TextBox></div>
                    <div class="col-md-4"><asp:Label ID="Label4" runat="server" Text="Direccion:"></asp:Label> &nbsp<asp:TextBox ID="txtdireccion" runat="server" Width="200px"></asp:TextBox></div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-4"><asp:Label ID="Label5" runat="server" Text="Referencia:"></asp:Label>&nbsp&nbsp&nbsp<asp:TextBox ID="txtreferencia" runat="server" Width="200px"></asp:TextBox></div>
                    <div class="col-md-4"><asp:Label ID="Label6" runat="server" Text="Costo:"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:TextBox ID="txtcosto" runat="server" Width="200px"></asp:TextBox></div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-4"><asp:Label ID="Label9" runat="server" Text="Nueva Fecha Inicio:"></asp:Label>&nbsp&nbsp&nbsp<asp:TextBox ID="txtfechainicio" runat="server"  Width="155px" TextMode="Date" ></asp:TextBox></div>
                    <div class="col-md-4"><asp:Label ID="Label10" runat="server" Text="Nueva Fecha Fin:"></asp:Label>&nbsp&nbsp&nbsp<asp:TextBox ID="txtfechafin" runat="server"  TextMode="Date" Width="155px"></asp:TextBox></div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-4"><asp:Label ID="Label7" runat="server" Text="Antigua Fecha Inicio:"></asp:Label>&nbsp<asp:TextBox ID="txtantiguafechainicio" runat="server"  Width="155px"></asp:TextBox></div>
                    <div class="col-md-4"><asp:Label ID="Label8" runat="server" Text="Antigua Fecha Fin:"></asp:Label>&nbsp<asp:TextBox ID="txtantiguafechafin" runat="server"  Width="155px"></asp:TextBox></div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-md-4"></div>
                    <div class="col-md-4"><CENTER><asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" /><asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" /></CENTER></div>
                    <div class="col-md-4"></div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-md-4"></div>
                    <div class="col-md-4"><CENTER><asp:Label ID="LabelMensaje" runat="server" Text=""></asp:Label></asp:Label></CENTER></div>
                    <div class="col-md-4"></div>
                </div>
                
            </div>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
