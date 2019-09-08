<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_Antropometria.aspx.cs" Inherits="WebApp.contenido2.antropometria.frm_Antropometria" %>

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
    </asp:PlaceHolder>
    <script type="text/javascript">
        $(function () {
            $(".ddlPerfil").select2();
            $.datepicker.setDefaults($.datepicker.regional["es"]);
            $(".txtFechaAn").datepicker({
                numberOfMonths: 1,
                autoSize: true,
                showAnim: "drop",
                gotoCurrent: true,
                dateFormat: "dd/mm/yy",
                hideIfNoPrevNext: true,
                changeMonth: true,
                changeYear: true,
                yearRange: "-100:+0",
                maxDate: new Date()
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
            <div style="font-size: 11px; margin: 8px;">
                <div id="ctl00_ContentPlaceHolder1_pnlMtn">

                    <table cellpadding="0" cellspacing="1" width="100%">
                        <tbody>
                            <tr>
                                <td bgcolor="#dcdcdc">
                                    <table cellpadding="0" cellspacing="1" width="100%">
                                        <tbody>
                                            <tr bgcolor="whitesmoke" align="center">
                                                <td width="96px">Datos</td>
                                                <td width="65px">Control 1</td>
                                                <td width="65px">Control 2</td>
                                                <td width="65px">Control 3</td>
                                                <td width="65px">Control 4</td>
                                                <td width="65px">Control 5</td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" align="center" class="txtazul">Fecha control</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="txtFechaControlDat" CssClass="txtFechaAn form-control datepicker" style="font-size: 11px; width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox1" CssClass="txtFechaAn form-control datepicker" style="font-size: 11px; width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox2" CssClass="txtFechaAn form-control datepicker" style="font-size: 11px; width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox3" CssClass="txtFechaAn form-control datepicker" style="font-size: 11px; width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox4" CssClass="txtFechaAn form-control datepicker" style="font-size: 11px; width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td bgcolor="WhiteSmoke" style="font-weight: bold; padding: 2px" colspan="11">&nbsp;&nbsp;Perímetros (cm)</td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Brazo</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox5" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                   <asp:TextBox runat="server" ID="TextBox6" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox7" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox8" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox9" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Pecho&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox10" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox11" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox12" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox13" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox14" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Abdomen&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox15" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox16" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                   <asp:TextBox runat="server" ID="TextBox17" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox18" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox19" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Cadera&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox20" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox21" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox22" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox23" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox24" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Muslo&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox25" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                   <asp:TextBox runat="server" ID="TextBox26" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox27" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox28" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox29" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Gemelo&nbsp;</td>
                                                <td style="padding: 2px">
                                                     <asp:TextBox runat="server" ID="TextBox30" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                     <asp:TextBox runat="server" ID="TextBox31" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                     <asp:TextBox runat="server" ID="TextBox32" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                     <asp:TextBox runat="server" ID="TextBox33" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                     <asp:TextBox runat="server" ID="TextBox34" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td bgcolor="WhiteSmoke" style="font-weight: bold; padding: 2px" colspan="11">&nbsp;&nbsp;Longitud (cm)</td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Húmero&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox35" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox36" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox37" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox38" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox39" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Fémur&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox40" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox41" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox42" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox43" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox44" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Muñeca</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox45" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox46" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox47" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                   <asp:TextBox runat="server" ID="TextBox48" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox49" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td bgcolor="WhiteSmoke" style="font-weight: bold; padding: 2px" colspan="11">&nbsp;&nbsp;Pliegues Cutaneos</td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Tríceps&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox50" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                   <asp:TextBox runat="server" ID="TextBox51" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox52" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox53" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox54" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Muslo&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox55" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox56" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox57" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox58" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox59" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Supraespinal&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox60" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox61" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox62" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox63" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox64" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Pectoral&nbsp;</td>
                                                <td style="padding: 2px">
                                                     <asp:TextBox runat="server" ID="TextBox65" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                     <asp:TextBox runat="server" ID="TextBox66" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                     <asp:TextBox runat="server" ID="TextBox67" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                     <asp:TextBox runat="server" ID="TextBox68" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                     <asp:TextBox runat="server" ID="TextBox69" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Abdominal&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox70" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox71" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox72" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox73" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox74" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Gemelo&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox75" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox76" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox77" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox78" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox79" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                             </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button runat="server" ID="btnGuardarDatos" text="Guardar datos antropometricos" CssClass="btn btn-primary" style="width: 96%;"/>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                            <td bgcolor="#dcdcdc">
                                    <table cellpadding="0" cellspacing="1" width="100%">
                                        <tbody>
                                            <tr bgcolor="White">
                                                <td bgcolor="WhiteSmoke" style="font-weight: bold; padding: 2px" colspan="11">&nbsp;&nbsp;Somatotipo (n)</td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Ectomorfia</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox85" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                   <asp:TextBox runat="server" ID="TextBox86" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox87" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox88" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox89" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Mesomorfia&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox90" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox91" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox92" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox93" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox94" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Endomorfia&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox95" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox96" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                   <asp:TextBox runat="server" ID="TextBox97" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox98" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox99" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>

                                            <tr bgcolor="White">
                                                <td bgcolor="WhiteSmoke" style="font-weight: bold; padding: 2px" colspan="11">&nbsp;&nbsp;Somatocarta (n)</td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Eje X&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox115" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox116" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox117" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox118" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox119" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                            <tr bgcolor="White">
                                                <td style="padding: 2px" class="txtazul">&nbsp;&nbsp;&nbsp;&nbsp; Eje Y&nbsp;</td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox120" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox121" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox122" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox123" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                                <td style="padding: 2px">
                                                    <asp:TextBox runat="server" ID="TextBox124" CssClass="form-control" style="width: 95%;"/>
                                                </td>
                                            </tr>
                                             </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button runat="server" ID="btnCalcSomatotipoSomatocarta" text="Calcular Somatotipo y Somatocarta" CssClass="btn btn-primary"/>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" width="100%">
                                        <tbody>
                                            <tr>
                                                <td width="240px" valign="top">
                                                    <table cellpadding="0" cellspacing="0" width="100%">
                                                        <tbody>
                                                            <tr>
                                                                <td>
                                                                    <table cellpadding="0" cellspacing="0" width="100%">
                                                                        <tbody>
                                                                            <tr>
                                                                                <td bgcolor="#dcdcdc">
                                                                                    <table cellpadding="2" cellspacing="1" width="100%">
                                                                                        <tbody>
                                                                                            <tr bgcolor="whitesmoke">
                                                                                                <td align="center" width="75px">Fecha</td>
                                                                                                <td align="center" width="40px">Talla</td>
                                                                                                <td align="center" width="40px">Peso</td>
                                                                                                <td align="center">IMC</td>
                                                                                            </tr>
                                                                                            <tr bgcolor="White">
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtFecSeg1" type="text" value="18/05/2014" maxlength="10" id="ctl00_ContentPlaceHolder1_txtFecSeg1" class="uifecha txtbox hasDatepicker" style="font-size: 11px; width: 95%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtTalla1" type="text" value="179" maxlength="3" id="ctl00_ContentPlaceHolder1_txtTalla1" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtPeso1" type="text" value="67" maxlength="5" id="ctl00_ContentPlaceHolder1_txtPeso1" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtIMC1" type="text" value="20,9" maxlength="4" id="ctl00_ContentPlaceHolder1_txtIMC1" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr bgcolor="White">
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtFecSeg2" type="text" value="21/01/2015" maxlength="10" id="ctl00_ContentPlaceHolder1_txtFecSeg2" class="uifecha txtbox hasDatepicker" style="font-size: 11px; width: 95%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtTalla2" type="text" value="180" maxlength="3" id="ctl00_ContentPlaceHolder1_txtTalla2" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtPeso2" type="text" value="66" maxlength="5" id="ctl00_ContentPlaceHolder1_txtPeso2" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtIMC2" type="text" value="20,4" maxlength="4" id="ctl00_ContentPlaceHolder1_txtIMC2" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr bgcolor="White">
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtFecSeg3" type="text" maxlength="10" id="ctl00_ContentPlaceHolder1_txtFecSeg3" class="uifecha txtbox hasDatepicker" style="font-size: 11px; width: 95%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtTalla3" type="text" maxlength="3" id="ctl00_ContentPlaceHolder1_txtTalla3" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtPeso3" type="text" maxlength="5" id="ctl00_ContentPlaceHolder1_txtPeso3" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtIMC3" type="text" maxlength="4" id="ctl00_ContentPlaceHolder1_txtIMC3" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr bgcolor="White">
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtFecSeg4" type="text" maxlength="10" id="ctl00_ContentPlaceHolder1_txtFecSeg4" class="uifecha txtbox hasDatepicker" style="font-size: 11px; width: 95%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtTalla4" type="text" maxlength="3" id="ctl00_ContentPlaceHolder1_txtTalla4" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtPeso4" type="text" maxlength="5" id="ctl00_ContentPlaceHolder1_txtPeso4" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtIMC4" type="text" maxlength="4" id="ctl00_ContentPlaceHolder1_txtIMC4" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr bgcolor="White">
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtFecSeg5" type="text" maxlength="10" id="ctl00_ContentPlaceHolder1_txtFecSeg5" class="uifecha txtbox hasDatepicker" style="font-size: 11px; width: 95%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtTalla5" type="text" maxlength="3" id="ctl00_ContentPlaceHolder1_txtTalla5" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtPeso5" type="text" maxlength="5" id="ctl00_ContentPlaceHolder1_txtPeso5" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtIMC5" type="text" maxlength="4" id="ctl00_ContentPlaceHolder1_txtIMC5" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr bgcolor="White">
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtFecSeg6" type="text" maxlength="10" id="ctl00_ContentPlaceHolder1_txtFecSeg6" class="uifecha txtbox hasDatepicker" style="font-size: 11px; width: 95%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtTalla6" type="text" maxlength="3" id="ctl00_ContentPlaceHolder1_txtTalla6" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtPeso6" type="text" maxlength="5" id="ctl00_ContentPlaceHolder1_txtPeso6" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtIMC6" type="text" maxlength="4" id="ctl00_ContentPlaceHolder1_txtIMC6" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr bgcolor="White">
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtFecSeg7" type="text" maxlength="10" id="ctl00_ContentPlaceHolder1_txtFecSeg7" class="uifecha txtbox hasDatepicker" style="font-size: 11px; width: 95%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtTalla7" type="text" maxlength="3" id="ctl00_ContentPlaceHolder1_txtTalla7" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtPeso7" type="text" maxlength="5" id="ctl00_ContentPlaceHolder1_txtPeso7" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtIMC7" type="text" maxlength="4" id="ctl00_ContentPlaceHolder1_txtIMC7" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr bgcolor="White">
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtFecSeg8" type="text" maxlength="10" id="ctl00_ContentPlaceHolder1_txtFecSeg8" class="uifecha txtbox hasDatepicker" style="font-size: 11px; width: 95%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtTalla8" type="text" maxlength="3" id="ctl00_ContentPlaceHolder1_txtTalla8" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtPeso8" type="text" maxlength="5" id="ctl00_ContentPlaceHolder1_txtPeso8" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtIMC8" type="text" maxlength="4" id="ctl00_ContentPlaceHolder1_txtIMC8" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr bgcolor="White">
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtFecSeg9" type="text" maxlength="10" id="ctl00_ContentPlaceHolder1_txtFecSeg9" class="uifecha txtbox hasDatepicker" style="font-size: 11px; width: 95%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtTalla9" type="text" maxlength="3" id="ctl00_ContentPlaceHolder1_txtTalla9" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtPeso9" type="text" maxlength="5" id="ctl00_ContentPlaceHolder1_txtPeso9" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtIMC9" type="text" maxlength="4" id="ctl00_ContentPlaceHolder1_txtIMC9" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr bgcolor="White">
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtFecSeg10" type="text" maxlength="10" id="ctl00_ContentPlaceHolder1_txtFecSeg10" class="uifecha txtbox hasDatepicker" style="font-size: 11px; width: 95%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtTalla10" type="text" maxlength="3" id="ctl00_ContentPlaceHolder1_txtTalla10" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtPeso10" type="text" maxlength="5" id="ctl00_ContentPlaceHolder1_txtPeso10" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtIMC10" type="text" maxlength="4" id="ctl00_ContentPlaceHolder1_txtIMC10" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr bgcolor="White">
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtFecSeg11" type="text" maxlength="10" id="ctl00_ContentPlaceHolder1_txtFecSeg11" class="uifecha txtbox hasDatepicker" style="font-size: 11px; width: 95%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtTalla11" type="text" maxlength="3" id="ctl00_ContentPlaceHolder1_txtTalla11" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtPeso11" type="text" maxlength="5" id="ctl00_ContentPlaceHolder1_txtPeso11" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtIMC11" type="text" maxlength="4" id="ctl00_ContentPlaceHolder1_txtIMC11" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr bgcolor="White">
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtFecSeg12" type="text" maxlength="10" id="ctl00_ContentPlaceHolder1_txtFecSeg12" class="uifecha txtbox hasDatepicker" style="font-size: 11px; width: 95%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtTalla12" type="text" maxlength="3" id="ctl00_ContentPlaceHolder1_txtTalla12" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtPeso12" type="text" maxlength="5" id="ctl00_ContentPlaceHolder1_txtPeso12" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                                <td>
                                                                                                    <input name="ctl00$ContentPlaceHolder1$txtIMC12" type="text" maxlength="4" id="ctl00_ContentPlaceHolder1_txtIMC12" class="txtbox" style="font-size: 11px; width: 93%;">
                                                                                                </td>
                                                                                            </tr>
                                                                                        </tbody>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                        </tbody>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>Talla en cm. Peso en Kg.</td>
                                                            </tr>
                                                            <tr>
                                                                <td>&nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                    <input type="submit" name="ctl00$ContentPlaceHolder1$CalculoIMC" value="Recalcular IMC=Peso/Talla2" id="ctl00_ContentPlaceHolder1_CalculoIMC" class="btn btn-default btn-xs" style="width: 96%;">
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>&nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td>&nbsp;</td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </td>
                                                <td width="8px">&nbsp;</td>
                                                <td valign="top">
                                                    <div class="panel panel-default">
                                                        <div class="panel-heading" style="text-align: center; font-size: 13px; background-color: whitesmoke; color: #333333;">
                                                            Observaciones
                                                        </div>
                                                        <div class="panel-body" style="padding: 6px;">
                                                            <textarea name="ctl00$ContentPlaceHolder1$txtObservaciones" rows="2" cols="20" id="ctl00_ContentPlaceHolder1_txtObservaciones" class="txtbox" style="font-family: Arial; font-size: 12px; height: 250px; width: 98%;"></textarea>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </tbody>
                    </table>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
