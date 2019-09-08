<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asistencia.aspx.cs" Inherits="WebApp.Asistencia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Asistencia Entrenamiento</title>
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
</style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="true" EnablePageMethods="true"
                EnableScriptLocalization="true">
            </asp:ScriptManager>
    <div class="container">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="cuadro-container">
                <div class="cuadro-heading">
                    <span class="cuadro-title">Asistencia</span>
                </div>
                <div class="cuadro-body">
                    <div class="table-responsive">
                        <asp:GridView runat="server" ID="gvHorarios" AutoGenerateColumns="False" ShowFooter="True" AllowPaging="True"
                             BorderWidth="0px" CssClass="table table-bordered" OnRowCommand="gvHorarios_RowCommand"
                             EmptyDataText="No hay Horarios Vigentes para este Día" >                                                        
                            <Columns>
                                <asp:BoundField DataField="codHorarioEntrenamiento" HeaderText="Código"  HeaderStyle-CssClass="hidden-field">
                                <ItemStyle CssClass="hidden-field"/>
                                    <FooterStyle CssClass="hidden-field"/>
                                </asp:BoundField>
<%--                                 <asp:TemplateField Visible="false">
                                    <HeaderStyle Width="8%" />
                                    <HeaderTemplate>Codigo</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblCodPersonaAdd" runat="server" Text='<% #Bind("codHorarioEntrenamiento")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>--%>

                                <asp:BoundField DataField="titulo" HeaderText="Titulo" ItemStyle-Width="10%"/>
<%--                                <asp:TemplateField>
                                    <HeaderStyle Width="10%" />
                                    <HeaderTemplate>Titulo</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblNombDeporAdd" runat="server" Text='<% #Bind("titulo")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>--%>

                                <asp:TemplateField>
                                    <HeaderStyle Width="10%" />
                                    <HeaderTemplate>Descripcion</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblApellidosAdd" runat="server" Text='<% #Bind("descripcion")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:BoundField DataField="fechaEntrenamiento" HeaderText="Fecha" ItemStyle-Width="10%" DataFormatString="{0:d}"/>
<%--                                <asp:TemplateField>
                                    <HeaderStyle Width="8%" />
                                    <HeaderTemplate>Fecha</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblFechaNacAdd" runat="server" Text='<% #Bind("fechaEntrenamiento","{0:d}")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>--%>

                                <asp:TemplateField>
                                    <HeaderStyle Width="8%" />
                                    <HeaderTemplate>Entrada</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblHoraEntradaAdd" runat="server" Text='<% #Bind("horaEntrada","{0:t}")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <HeaderStyle Width="8%" />
                                    <HeaderTemplate>Salida</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblHoraSalidaAdd" runat="server"  Text='<% #Bind("horaSalida","{0:t}")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>

                                 <asp:ButtonField ButtonType="Button" CommandName="View1" Text="Seleccionar Horario"  ControlStyle-CssClass="tn btn-primary" ItemStyle-Width="4%">
  <%--                                  <HeaderStyle Width="8%" />
                                    <HeaderTemplate>                                        
                                    </HeaderTemplate>
                                    <ItemTemplate>--%>
                                      <%--  <asp:Button runat="server" Text="Seleccionar Horario" CommandName="View1" ID="btnViewReader"
                                            ValidationGroup="Lector" ToolTip="Completar datos de jugadores" CssClass="btn btn-primary"  
                                           />--%>
                                        <%--OnClick="btnViewReader_Click"--%>
                                        <%--<input runat="server" id="btnViewReader" type="button" onserverclick="btnViewReader_Click" value="Seleccinar Horario"/>--%>
                                    <%--</ItemTemplate>--%>
                                </asp:ButtonField>

                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <div class="cuadro-body">
                    <div class="table-responsive">
                        <div>
                        <h4 style="float:left;margin-right:10px;"><asp:Label ID="Labelt1" runat="server" class="btn btn-success" Text="Label" ></asp:Label></h4> <h4 style="float:left;"><asp:Label ID="Labelt2" runat="server" class="btn btn-success" Text="Label"></asp:Label></h4>
                            <asp:Label ID="LabelCodigoHorario" runat="server" Text=""></asp:Label>
                        </div>
                        <asp:GridView runat="server" ID="GridView1" AutoGenerateColumns="False" ShowFooter="True" AllowPaging="True"
                             BorderWidth="0px" CssClass="table table-bordered"
                             EmptyDataText="No hay jugadores ingresados">
                            <Columns>
                                 <asp:BoundField DataField="codJugador" HeaderText="Código" ItemStyle-Width="5%" />
<%--                                    <HeaderStyle Width="9%" />
                                    <HeaderTemplate>Código</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblCodPersona" runat="server" Text='<% #Bind("codPersona")%>' />
                                    </ItemTemplate>
                                </asp:BoundField>--%>

                                <asp:TemplateField>
                                    <HeaderStyle Width="20%" />
                                    <HeaderTemplate>Apellidos y Nombres</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lblJugador" runat="server" Text='<% #Bind("nombresyap")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>

<%--                                <asp:BoundField DataField="titulo" HeaderText="Titulo" ItemStyle-Width="10%" />--%>
                                <asp:TemplateField >
                                        <HeaderStyle Width="5%" />
                                        <HeaderTemplate>Presente</HeaderTemplate>
                                    <ItemTemplate>
                                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Lista"/>                 
                                    <%--<input name="RadioButton1" type="radio" value="RadioButton1" />--%>
                                    </ItemTemplate>
                                </asp:TemplateField>
<%--                                <asp:TemplateField>
                                    <HeaderStyle Width="5%" />
                                    <HeaderTemplate>Presente</HeaderTemplate>
                                    <ItemTemplate>       
                                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" GroupName="Lista"></asp:RadioButtonList>                
                                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Lista" />                 
                                    </ItemTemplate>
                                </asp:TemplateField>--%>

                                <asp:TemplateField>
                                    <HeaderStyle Width="5%" />
                                    <HeaderTemplate>Tarde</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Lista" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                                <asp:TemplateField>
                                    <HeaderStyle Width="5%" />
                                    <HeaderTemplate>Falta</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Lista" />
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <HeaderStyle Width="5%" />
                                    <HeaderTemplate>Justificado</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Lista" />
                                    </ItemTemplate>
                                </asp:TemplateField>

                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <div style="float:right">
                <asp:Button ID="BotonCancelar" runat="server" ValidationGroup="Lector" Text="No Grabar" OnClick="BotonCancelar_Click"
                    CssClass="btn btn-danger" style="float:right" /> 
                    </div> 
                <div style="float:right">
                 <asp:Button ID="BotonGuardarAsistencia" runat="server" ValidationGroup="Lector" Text="Grabar Asistencia" 
                    CssClass="btn btn-primary" style="float:right; margin-right:10px;" OnClick="BotonGuardarAsistencia_Click"/>   
                </div>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
