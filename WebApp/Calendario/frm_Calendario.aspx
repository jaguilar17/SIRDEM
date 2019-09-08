<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_Calendario.aspx.cs" Inherits="WebApp.Calendario.frm_Calendario" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <asp:PlaceHolder ID="PlaceHolder2" runat="server">

        <link href="<%= ResolveClientUrl("~/utils/fullcalendar/fullcalendar.css") %>" rel="stylesheet" />
        <link href="<%= ResolveClientUrl("~/utils/css/cupertino/jquery-ui-1.7.3.custom.css") %>" rel="stylesheet" />
        <link href="<%= ResolveClientUrl("~/Tools/Bootstrap/3.3.5/css/bootstrap-theme.css") %>" rel="stylesheet" />
        <link href="<%= ResolveClientUrl("~/Tools/Bootstrap/3.3.5/css/bootstrap-theme.min.css") %>" rel="stylesheet" />
        <link href="<%= ResolveClientUrl("~/Tools/Bootstrap/3.3.5/css/bootstrap.css") %>" rel="stylesheet" />
        <link href="<%= ResolveClientUrl("~/Tools/Bootstrap/3.3.5/css/bootstrap.min.css") %>" rel="stylesheet" />

        <script src="<%= ResolveClientUrl("~/Calendario/jquery/jquery-1.3.2.min.js") %>" type="text/javascript"></script>
        <script src="<%= ResolveClientUrl("~/Calendario/jquery/jquery-ui-1.7.3.custom.min.js") %>" type="text/javascript"></script>
        <script src="<%= ResolveClientUrl("~/Calendario/jquery/jquery.qtip-1.0.0-rc3.min.js") %>" type="text/javascript"></script>
        <script src="<%= ResolveClientUrl("~/Calendario/fullcalendar/fullcalendar.min.js") %>" type="text/javascript"></script>
        <script src="<%= ResolveClientUrl("~/Calendario/scripts/calendarscript.js") %>" type="text/javascript"></script>
        <script src="<%= ResolveClientUrl("~/Calendario/jquery/jquery-ui-timepicker-addon-0.6.2.min.js") %>" type="text/javascript"></script>

    </asp:PlaceHolder>
    <script type="text/javascript">
        function clickb() {
            $('#calendar').fullCalendar('changeView', 'agendaDay');
            var a1 = document.getElementById("Label3").textContent;
            var a2 = document.getElementById("Label4").textContent;
            var a3 = document.getElementById("Label5").textContent;
            $('#calendar').fullCalendar('gotoDate', a1, a2, a3);
        }

    </script>
    <style type='text/css'>
        body {
            /*margin-top: 40px;*/
            margin-top: 0px;
            margin-left: 0px;
            margin-right: 0px;
            text-align: center;
            font-size: 14px;
            font-family: "Lucida Grande",Helvetica,Arial,Verdana,sans-serif;
        }

        #calendar {
            width: 98%;
            height: 100%;
            margin: 0 auto;
            margin-right: 5px;
        }

        #VentanaMenu {
            width: 25%;
            height: 100%;
            float: left;
            margin: 0 auto;
        }
        /* css for timepicker */
        .ui-timepicker-div dl {
            text-align: left;
        }

            .ui-timepicker-div dl dt {
                height: 25px;
            }

            .ui-timepicker-div dl dd {
                margin: -25px 0 10px 65px;
            }

        .style1 {
            width: 100%;
        }

        /* table fields alignment*/
        .alignRight {
            text-align: right;
            padding-right: 10px;
            padding-bottom: 10px;
        }

        .alignLeft {
            text-align: left;
            padding-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableHistory="true" EnablePartialRendering="true" EnablePageMethods="true"></asp:ScriptManager>

         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

        <div class="cuadro-container">
            <div class="cuadro-heading">
                Eventos del Mes
            </div>
            <div style="visibility: hidden">
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            </div>
            <div class="cuadro-body" style="padding-top: 0px">
                <div class="row" style="padding-top: 0px">
                    <div class="col-md-4 col-sm-3 col-xs-12">
                        <asp:Label ID="Label2" runat="server" Text="Consultar por Fecha:" Style="float: left"></asp:Label>
                        <div>
                            <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" Style="float: left" Enabled="False"></asp:TextBox>
                            <asp:ImageButton ID="ImageButton1" runat="server" OnClick="Evento_Fechas_Calendar" Style="float: right" ImageUrl="~/Calendario_Icon.png" />
                        </div>
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px" OnSelectionChanged="Calendar1_SelectionChanged">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px"></DayHeaderStyle>
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
                            <OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99"></SelectedDayStyle>
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666"></SelectorStyle>
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px"></TitleStyle>
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White"></TodayDayStyle>
                            <WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
                        </asp:Calendar>
                        <input id="Button3" type="button" value="Buscar" onclick="clickb()" class="btn" style="float: left; margin-right: 10px;" />
                    </div>
                    <div class="col-md-4 col-sm-3 col-xs-12"></div>
                </div>
            </div>
        </div>
        
        <%--<asp:ScriptManager ID="ToolkitScriptManager1" runat="server" EnableHistory="true" EnablePartialRendering="true" EnablePageMethods="true"></asp:ScriptManager>--%>

        <div id="VentanaMenu" style="display: none">
            <div class="col-md-12" style="display: none">
                <div class="panel panel-primary" style="height: 600px;">
                    <div class="panel-heading">
                        <h4 class="panel-title">Administrar Horario</h4>
                    </div>
                    <asp:Button ID="Button2" runat="server" Text="Consultar Horarios" />
                    <div class="panel-body">Horarios  Vigentes</div>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnPageIndexChanging="GridView1_PageIndexChanging"
                        Width="100%" CellSpacing="1" AllowPaging="True" HorizontalAlign="Center">
                        <Columns>
                            <asp:BoundField DataField="codHorarioEntrenamiento" HeaderText="Codigo" Visible="False" />
                            <asp:BoundField DataField="titulo" HeaderText="Titulo" />
                            <asp:BoundField DataField="fechaEntrenamiento" HeaderText="Fecha" />
                            <asp:BoundField DataField="entrada" HeaderText="Entrada" />
                            <asp:BoundField DataField="salida" HeaderText="Salida" />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                    </asp:GridView>
                </div>
            </div>
        </div>

        <div id="calendar">
        </div>
        <div id="updatedialog" style="font: 70% 'Trebuchet MS', sans-serif; margin: 50px;"
            title="Actualizar Horario">
            <table cellpadding="0" class="style1">
                <tr>
                    <td class="alignRight">Título:</td>
                    <td class="alignLeft">
                        <input id="eventName" type="text" style="width: 250px; height: 30px" /><br />
                    </td>
                </tr>
                <tr>
                    <td class="alignRight">Descripción:</td>
                    <td class="alignLeft">
                        <textarea id="eventDesc" cols="30" rows="3" style="width: 250px; height: 50px"></textarea></td>
                </tr>
                <tr>
                    <td class="alignRight">Sede:</td>
                    <td class="alignLeft">
                        <asp:DropDownList ID="DropDownList2" runat="server" Width="250px" Height="30px" OnLoad="DropDownList2_Load"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="alignRight">Hora de Entrada:</td>
                    <td class="alignLeft">
                        <span id="eventStart"></span>
                    </td>
                </tr>
                <tr>
                    <td class="alignRight">Hora de Salida: </td>
                    <td class="alignLeft">
                        <span id="eventEnd"></span>
                        <input type="hidden" id="eventId" /></td>
                </tr>
            </table>
        </div>
        <div id="addDialog" style="font: 70% 'Trebuchet MS', sans-serif; margin: 50px;" title="Agregar Horario">
            <table cellpadding="0" class="style1">
                <tr>
                    <td class="alignRight">Título:</td>
                    <td class="alignLeft">
                        <input id="addEventName" type="text" style="width: 250px; height: 30px" /><br />
                    </td>
                </tr>
                <tr>
                    <td class="alignRight">Descripción:</td>
                    <td class="alignLeft">
                        <textarea id="addEventDesc" cols="30" rows="3" style="width: 250px; height: 50px"></textarea></td>
                </tr>
                <tr>
                    <td class="alignRight">Sede:</td>
                    <td class="alignLeft">
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="250px" Height="30px" OnLoad="DropDownList1_Load"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="alignRight">Hora de Entrada:</td>
                    <td class="alignLeft">
                        <span id="addEventStartDate" style="visibility: hidden"></span>
                        <asp:DropDownList ID="DropDownList4" runat="server">
                            <asp:ListItem Value="16"></asp:ListItem>
                            <asp:ListItem Value="17"></asp:ListItem>
                            <asp:ListItem Value="18"></asp:ListItem>
                            <asp:ListItem Value="19"></asp:ListItem>
                            <asp:ListItem Value="20"></asp:ListItem>
                        </asp:DropDownList>
                        :
                    <asp:DropDownList ID="DropDownList5" runat="server">
                        <asp:ListItem Value="00"></asp:ListItem>
                        <asp:ListItem Value="30"></asp:ListItem>
                    </asp:DropDownList>
                        PM
                    </td>
                </tr>
                <tr>
                    <td class="alignRight">Hora de Salida:</td>
                    <td class="alignLeft">
                        <span id="addEventEndDate" style="visibility: hidden"></span>
                        <asp:DropDownList ID="DropDownList6" runat="server">
                            <asp:ListItem Value="16"></asp:ListItem>
                            <asp:ListItem Value="17"></asp:ListItem>
                            <asp:ListItem Value="18"></asp:ListItem>
                            <asp:ListItem Value="19"></asp:ListItem>
                            <asp:ListItem Value="20"></asp:ListItem>
                        </asp:DropDownList>
                        :
                    <asp:DropDownList ID="DropDownList7" runat="server">
                        <asp:ListItem Value="00"></asp:ListItem>
                        <asp:ListItem Value="30"></asp:ListItem>
                    </asp:DropDownList>
                        PM
                    </td>
                </tr>
            </table>

        </div>

        <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" OkControlID="btnNo" PopupControlID="Panel1" BackgroundCssClass="modalBackground" TargetControlID="Button2">
        </cc1:ModalPopupExtender>
        <asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" Style="display: none" Width="500px">
            <div class="header">
                Consulta de Horarios
            </div>
            <div class="body">
                <table style="width: 100%; height: 100%;">
                    <tr>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td width="90%" style="float: right">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" ValidationGroup="Lista"></asp:RadioButtonList>

                            <asp:RadioButton ID="RadioButton1" runat="server" Text="Búsqueda por Título de Horario:" Style="float: left" Checked="True" GroupName="Lista" OnCheckedChanged="RadioButton1_CheckedChanged" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Width="90%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td width="90%" style="float: right">
                            <asp:RadioButton ID="RadioButton2" runat="server" Text="Búsqueda por Rango de Fechas:" Style="float: left" GroupName="Lista" OnCheckedChanged="RadioButton2_CheckedChanged" />
                        </td>
                    </tr>
                    <tr>
                        <td>De:
                            <asp:TextBox ID="TextBox2" runat="server" Width="40%"></asp:TextBox>
                            <cc1:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" BehaviorID="TextBox2_CalendarExtender" TargetControlID="TextBox2" DefaultView="Days" ViewStateMode="Inherit" Format="yyyy-MM-dd" />
                            - A:
                            <asp:TextBox ID="TextBox3" runat="server" Width="40%"></asp:TextBox>
                            <cc1:CalendarExtender ID="TextBox3_CalendarExtender" runat="server" BehaviorID="TextBox3_CalendarExtender" TargetControlID="TextBox3" DefaultView="Days" ViewStateMode="Inherit" Format="yyyy-MM-dd" />
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td width="90%" style="float: right">
                            <asp:Button ID="bAceptarBusqueda" runat="server" Text="Buscar" Style="float: left" Width="100px" /></td>
                    </tr>
                </table>
            </div>
            <div class="footer" align="right">
                <asp:Button ID="btnYes" runat="server" Text="Yes" CssClass="yes" Visible="False" />
                <asp:Button ID="btnNo" runat="server" Text="Regresar" CssClass="no" />
                <asp:Button ID="btnRegresar" runat="server"
                    Text="Salir" Width="100px" Visible="False" />
            </div>
        </asp:Panel>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" Visible="false" />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server" Height="19px" OnLoad="DropDownList3_Load" Width="170px" Visible="false"></asp:DropDownList>

        <div runat="server" id="jsonDiv" />
        <input type="hidden" id="hdClient" runat="server" />

                    </ContentTemplate>
            </asp:UpdatePanel>
    </form>
</body>
</html>
