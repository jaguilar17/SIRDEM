<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGraficaEctomorfiaxJugador.aspx.cs" Inherits="WebApp.frmGraficaEctomorfiaxJugador" %>

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
        <script src="<%= ResolveClientUrl("~/js/Func_Espec/fun_Jugador.js") %>"></script>

    </asp:PlaceHolder>
</head>
 <body onload="ListaPubli()"> 
    <form id="form1" runat="server">
    <div runat="server" id="divDatos">
    
    </div>
       <%-- <hr />
        <button type="button" id="btnGrafico">Ver Gráfico</button>
        <hr />--%>
        <div id="grafico"></div>
                                <div class="col-md-4 col-sm-3 col-xs-12">
                                    <a runat="server" id="btnRegresar" href='javascript:history.go(-1)' class="btn btn-warning">Regresar</a>
                                </div>
                                <div class="col-md-4 col-sm-3 col-xs-12">
                                    
                                </div>
                                <div class="col-md-4 col-sm-3 col-xs-12"></div>
    </form>
</body>
<script src="/highcharts/jquery.js"></script>
<script src="/highcharts/highcharts.js"></script>
<script src="/highcharts/exporting.js"></script>
     <script>
         $(document).ready(function () {
             $("#btnGrafico").click("click", function () {
                 ListaPubli();
                 //ListaPubli2();
             });
         });

         function ListaPubli() {
             $.ajax({
                 type: "post",
                 contentType: "application/json; charset=utf-8",
                 url: "../frmGraficaEctomorfiaxJugador.aspx/EctomorfiaxJugador",
                 data: "{}",
                 dataType: "json",
                 success: function (Result) {
                     Result = Result.d;
                     var data = [];
                     for (var i in Result) {
                         var serie = new Array(Result[i].fechaControl, Result[i].ectomorfia);
                         data.push(serie);
                     }
                     DibujaGrafico(data);
                     //DreawChartPubli(data, 'container2');
                 },
                 error: function (Result) {
                     alert("Error");
                 }
             });
         }

         function DibujaGrafico(series) {
             $('#grafico').highcharts({
                 chart: {
                     type: 'line'
                 },
                 title: {
                     text: 'Resultados de Ectomorfia por Controles'
                 },
                 subtitle: {
                     text: ''
                 },
                 xAxis: {
                     categories: ['1', '2', '3', '4', '5', '6', '7'],
                     title:{text:'Controles'}
                     //categories: ['17-05-2016', '24-05-2016', '31-05-2016', '07-06-2016', '14-06-2016', '21-06-2016', '28-06-2016']
                 },
                 yAxis: {
                     title: {
                         text: ''
                     }
                 },
                 plotOptions: {
                     line: {
                         dataLabels: {
                             enabled: true
                         },
                         enableMouseTracking: false
                     }
                 },
                 series: [{
                     name: 'Ectomorfo Meta',
                     data: [1.6, 1.8, 1.8, 1.9, 1.9, 2.1, 2.4]
                 }, {
                     name: 'Resultado Obtenido',
                     data: series
                     //data: [1.5, 1.5, 1.7, 1.6, 1.6, 1.8, 2.0]
                 }]
             });
         }
     </script>
</html>
