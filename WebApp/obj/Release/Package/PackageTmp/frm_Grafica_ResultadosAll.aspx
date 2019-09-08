<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_Grafica_ResultadosAll.aspx.cs" Inherits="WebApp.frm_Grafica_ResultadosAll" %>

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
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
           <hr />
        <button type="button" id="btnGrafico">Ver Gráfico</button>
        <hr />
        <div id="grafico"></div>
         <div class="row" style="padding-bottom: 10px">
                                <div class="col-md-4 col-sm-3 col-xs-12">
                                    <a runat="server" id="btnRegresar" href='javascript:history.go(-1)' class="btn btn-warning">Regresar</a>
                                </div>
                                <div class="col-md-4 col-sm-3 col-xs-12">
                                    
                                </div>
                                <div class="col-md-4 col-sm-3 col-xs-12"></div>
         </div>
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
                url: "../frm_Grafica_ResultadosAll.aspx/ResultadosAllxJugador",
                data: "{}",
                dataType: "json",
                success: function (Result) {
                    Result = Result.d;
                    var data = [];
                    for (var i in Result) {
                        var serie = new Array(Result[i].Cantidad, Result[i].name);
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
                    type: 'bar'
                },
                title: {
                    text: 'Comparación de los resultados generales de los datos antropométricos'
                },
                subtitle: {
                    text: ''
                },
                xAxis: {
                    categories: ['Ectomorfo', 'Eje Y', 'Eje X', 'Endomorfo', 'Mesomorfo'],
                    title: {
                        text: null
                    }
                },
                yAxis: {
                    min: 0,
                    title: {
                        text: '',
                        align: 'high'
                    },
                    labels: {
                        overflow: 'justify'
                    }
                },
                tooltip: {
                    valueSuffix: ''
                },
                plotOptions: {
                    bar: {
                        dataLabels: {
                            enabled: true
                        }
                    }
                },
                legend: {
                    layout: 'vertical',
                    align: 'right',
                    verticalAlign: 'top',
                    x: -40,
                    y: 20,
                    floating: true,
                    borderWidth: 1,
                    backgroundColor: ((Highcharts.theme && Highcharts.theme.legendBackgroundColor) || '#FFFFFF'),
                    shadow: true
                },
                credits: {
                    enabled: false
                },
                series: [{
                    name: 'Resultados Esperados',
                    data: [2.7, 5, 0.6, 2.1, 4.9]
                },{
                    name: 'Resultados Obtenidos',
                    data: [0.10, 1.93,-14.69,14.79,8.41]
                }]
            });
        }
     </script>
</html>
