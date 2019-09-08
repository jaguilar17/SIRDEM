<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PruebaFisica.aspx.cs" Inherits="APPAKD.PruebaFisica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<script type ="text/javascript">
    function disablebackbutton() {
        if (history.forward()) {
            frase = location.replace(history.foward());
        }
        }
        
    disablebackbutton();
</script>
<script type="text/javascript">

    function SoloNumerosDecimales3(e, valInicial, nEntero, nDecimal) {
        var obj = e.srcElement || e.target;
        var tecla_codigo = (document.all) ? e.keyCode : e.which;
        var tecla_valor = String.fromCharCode(tecla_codigo);
        var patron2 = /[\d.]/;
        var control = (tecla_codigo === 46 && (/[.]/).test(obj.value)) ? false : true;
        var existePto = (/[.]/).test(obj.value);

        //el tab
        if (tecla_codigo === 8)
            return true;

        if (valInicial !== obj.value) {
            var TControl = obj.value.length;
            if (existePto === false && tecla_codigo !== 46) {
                if (TControl === nEntero) {
                    obj.value = obj.value + ".";
                }
            }

            if (existePto === true) {
                var subVal = obj.value.substring(obj.value.indexOf(".") + 1, obj.value.length);

                if (subVal.length > 1) {
                    return false;
                }
            }

            return patron2.test(tecla_valor) && control;
        }
        else {
            if (valInicial === obj.value) {
                obj.value = '';
            }
            return patron2.test(tecla_valor) && control;
        }
    }
    function validarNumero(evt, buttonid) {
        var carCode;
        if (window.event)
            carCode = window.event.keyCode; //IE
        else
            carCode = e.which; //firefox
        var bt = document.getElementById(buttonid);
        if (bt) {
            if (carCode < 48 || carCode > 57) {
                if (carCode.keyCode == 13)
                    bt.click();
                return false;
            }
        }
    }
    function noCopyMouse(e) {
        if (event.button == 2 || event.button == 3) {
            //alert('no se puede permite copiar con maos');
            return false;
        }
        return true;
    }
    function noCopyKey(e) {
        var forbiddenKeys = new Array('c', 'x', 'v');
        var isCtrl;


        if (window.event) {
            if (window.event.ctrlKey)
                isCtrl = true;
            else
                isCtrl = false;
        }
        else {
            if (e.ctrlKey)
                isCtrl = true;
            else
                isCtrl = false;
        }

        if (isCtrl) {
            for (i = 0; i < forbiddenKeys.length; i++) {
                if (forbiddenKeys[i] == String.fromCharCode(window.event.keyCode).toLowerCase()) {
                   // alert('no se puede permite copiar con el teclado');
                    return false;
                }
            }
        }
        return true;
    }
</script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            height: 465px;
        }
        .fuente {
            font-family: 'Lato', sans-serif;
                font-size: small;
            }
        
 .PanelTexbox {

border-radius: 3px;
border: 1px solid #CCC;
font-weight: 400;
font-size: small;
font-family: Verdana;
box-shadow: 1px 1px 5px #CCC;
  font-family: 'Lato', sans-serif;
}
.btn{

    border-radius: 3px;
border: 1px solid #CCC;
font-family: 'Lato', sans-serif;
            font-size: small;
        }
        .pantitu {

            border-radius: 3px;
            border: 1px solid #CCC;
            font-weight: 400;
            font-size: small;
            font-family: Verdana;
            box-shadow: 1px 1px 5px #CCC;
            font-family: 'Lato', sans-serif;
            background-color: #F1F2F5;
            text-align: center;
        }

        .auto-style5 {
            width: 10px;
        }
        .auto-style6 {
            width: 358px;
        }
        .auto-style7 {
            width: 357px;
        }
        .auto-style8 {
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>

       
                    <asp:Panel ID="PanelPreguntasGeneralFisico" runat="server" style="text-align: center" Height="996px">
                    <asp:Panel ID="Panel45" runat="server" style="text-align: center; font-size: xx-large" BackColor="Silver">
                        <asp:Label ID="Label111" runat="server" Text="Prueba Fisica" style="text-align: center"></asp:Label>
                    </asp:Panel>
<asp:Panel ID="Panel46" runat="server" style="text-align: center">
                        
                        
                            
 <asp:Panel ID="Panel2" runat="server" CssClass="PanelTexbox" Width="1086px" Height="195px">
<asp:Panel ID="Panel4" runat="server" CssClass="pantitu" Height="35px" >
<br />
 <asp:Label ID="Titulo" runat="server" Text="Datos Generales" CssClass="fuente" ForeColor="#333333" ></asp:Label>
</asp:Panel>
                            <asp:Panel ID="Panel1" runat="server" Visible="False">
                                <asp:Label ID="fant1" runat="server"></asp:Label>
                                <asp:Label ID="fant2" runat="server"></asp:Label>
                                <asp:Label ID="fant3" runat="server"></asp:Label>
                                <asp:Label ID="fant32" runat="server"></asp:Label>
                                <asp:Label ID="codJu" runat="server"></asp:Label>
                                <asp:Label ID="nom" runat="server"></asp:Label>
                            </asp:Panel>
                            <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label113" runat="server" Text="Encargado de  la Prueba: " ForeColor="#333333"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                            <asp:TextBox ID="f1" runat="server" Width="765px" ForeColor="#333333"  CssClass="PanelTexbox" Height="25px" ></asp:TextBox>
                            <br />
                            <asp:Label ID="lp1" runat="server" ForeColor="Red"></asp:Label>
                            <br />

                             &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                            <asp:Label ID="Label116" runat="server" style="text-align: left" Text="Dia : " ForeColor="#333333"></asp:Label>

                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:TextBox ID="f2" runat="server" Width="129px" TextMode="Date" ForeColor="#333333"  CssClass="PanelTexbox" Height="25px"></asp:TextBox>
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            <asp:Label ID="Label118" runat="server" ForeColor="#333333">Hora: </asp:Label>
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="f3" runat="server" TextMode="Time" Width="96px" ForeColor="#333333"  CssClass="PanelTexbox" Height="25px"></asp:TextBox>
                            <br />
                            <asp:Label ID="lp2" runat="server" ForeColor="Red"></asp:Label>
                            <br />
                             &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                            <asp:Label ID="Label120" runat="server" Text="Lugar : " ForeColor="#333333"></asp:Label>
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:TextBox ID="f4" runat="server" Width="765px" ForeColor="#333333"  CssClass="PanelTexbox" Height="25px"></asp:TextBox>
                            &nbsp;
                            <br />

                                        <asp:Label ID="lp3" runat="server"  ForeColor="Red"></asp:Label>
</asp:Panel>
         

                                        

                                   
                            
                        </asp:Panel>
                        <asp:Panel ID="Panel50" runat="server" style="text-align: center">
                                                             

                                                             
 <asp:Panel ID="Panel5" runat="server" CssClass="PanelTexbox" Width="1086px" Height="515px">
<asp:Panel ID="Panel6" runat="server" CssClass="pantitu" Height="35px" >
<br />
 <asp:Label ID="Label9" runat="server" Text="Datos Encontrados" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
                                                             <table class="auto-style2">
                                                                 <tr>
                                                                     <td style="text-align: left" class="auto-style6">


                                                                         <asp:Panel ID="Panel78" runat="server">

                                                                             <table class="auto-style2">
                                                                                 <tr>
                                                                                     <td class="auto-style5">&nbsp;</td>
                                                                                     <td>&nbsp;
<asp:Panel ID="Panel7" runat="server" CssClass="PanelTexbox" Width="325px" Height="83px" >
<asp:Panel ID="Panel8" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label10" runat="server" Text="Potencia de las extremidades inferiores" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
<br />
 &nbsp;&nbsp;
                                <asp:Label ID="Label156" runat="server" Text="Altura alcanzada en un salto: " ForeColor="#333333"></asp:Label>
                                                                                         &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtaltura" runat="server"  Width="83px" Height="20px" ForeColor="#333333"  CssClass="PanelTexbox" MaxLength="4"></asp:TextBox>
                                                                    <asp:Label ID="Label335" runat="server" ForeColor="#333333" style="font-size: small" Text="cm"></asp:Label>
                                                                    <br />

                                                <asp:Label ID="lp4" runat="server" ForeColor="Red" style="text-align: center" Width="320px"></asp:Label>
</asp:Panel>
<br />
     <asp:Panel ID="Panel9" runat="server" CssClass="PanelTexbox" Width="325px" Height="99px" >
<asp:Panel ID="Panel10" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label6" runat="server" Text="Potencia muscular general" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
<br />
                                &nbsp;
                                <asp:Label ID="Label168" runat="server" Text="Distancia obtenida al lanzar" ForeColor="#333333"></asp:Label>
<br />
                                &nbsp;
                                <asp:Label ID="Label1" runat="server" Text="un balon medicinal: " ForeColor="#333333"></asp:Label>
                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:TextBox ID="txtLanzar" runat="server"  Width="83px" Height="20px" ForeColor="#333333"  CssClass="PanelTexbox" MaxLength="4"></asp:TextBox>

                                    <asp:Label ID="Label171" runat="server" Text="m" style="font-size: small" ForeColor="#333333"  ></asp:Label>
                                                                                                    <br />

                                                    <asp:Label ID="lp7" runat="server" ForeColor="Red" style="text-align: center" Width="320px"></asp:Label>
</asp:Panel>
<br />
    
     <asp:Panel ID="Panel11" runat="server" CssClass="PanelTexbox" Width="325px" Height="99px" >
<asp:Panel ID="Panel12" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label7" runat="server" Text="Resistencia cardiovascular" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
<br />
                                &nbsp;
                                <asp:Label ID="Label192" runat="server" Text="Cantidad de flexiones " ForeColor="#333333"></asp:Label>
                                    <br />
                                &nbsp;
                                <asp:Label ID="Label2" runat="server" Text="relizadas dentro de un minuto: " ForeColor="#333333"></asp:Label>
         &nbsp; &nbsp; &nbsp; &nbsp;
<asp:TextBox ID="txtflex" runat="server"  Width="83px" Height="20px" ForeColor="#333333"  CssClass="PanelTexbox" MaxLength="4"></asp:TextBox>
                                                                                                        <br />

                                                            <asp:Label ID="lp10" runat="server" ForeColor="Red" style="text-align: center" Width="320px"></asp:Label>
</asp:Panel>
       
<br />
     <asp:Panel ID="Panel13" runat="server" CssClass="PanelTexbox" Width="325px" Height="99px" >
<asp:Panel ID="Panel14" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label8" runat="server" Text="Resistencia muscular" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
<br />
                                &nbsp;
                                <asp:Label ID="Label212" runat="server" Text="Cantidad de repeticiones &quot;v&quot; " ForeColor="#333333"></asp:Label>
                                      <br />
                                &nbsp;
                                <asp:Label ID="Label3" runat="server" Text="realizadas en 1 minuto: " ForeColor="#333333"></asp:Label>
         &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:TextBox ID="txtv1m" runat="server"  Width="83px" Height="20px" ForeColor="#333333"  CssClass="PanelTexbox" MaxLength="4"></asp:TextBox>
                                                                                                        <br />

                                                                    <asp:Label ID="lp13" runat="server" ForeColor="Red" style="text-align: center" Width="320px"></asp:Label>
</asp:Panel>
                                                                                         <asp:Panel ID="Panel82" runat="server" Height="15px">
                                                                                         </asp:Panel>



                                                                                     </td>
                                                                                 </tr>
                                                                             </table>
                                                                         </asp:Panel>


                                    </td>
                                                                     <td style="text-align: left" class="auto-style7">


                                                                         <asp:Panel ID="Panel79" runat="server">
                                                                             <table class="auto-style2">
                                                                                 <tr>
                                                                                     <td class="auto-style5">&nbsp;</td>
                                                                                     <td>&nbsp;<asp:Panel ID="Panel15" runat="server" CssClass="PanelTexbox" Width="325px" Height="85px" >
<asp:Panel ID="Panel16" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label11" runat="server" Text="Tiempo que demora en reccorrer 50 metros" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
                                                                                         &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;<asp:Label ID="Label272" runat="server" ForeColor="#333333" style="font-size: small" Text="h "></asp:Label>
                                   

                                                                                         &nbsp;<asp:Label ID="Label131" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
                                                                                         &nbsp;<asp:Label ID="Label273" runat="server" ForeColor="#333333" style="font-size: small" Text="m"></asp:Label>
                                                                                         &nbsp;<asp:Label ID="Label274" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
&nbsp;<asp:Label ID="Label275" runat="server" ForeColor="#333333" style="font-size: small" Text="s"></asp:Label>
                                                                                         &nbsp;<asp:Label ID="Label277" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
                                                                                         &nbsp;<asp:Label ID="Label278" runat="server" ForeColor="#333333" style="font-size: small" Text="ms"></asp:Label>
                                                                                         <br />
                                                                                         &nbsp;&nbsp;<asp:Label ID="Label125" runat="server" ForeColor="#333333" Text="Tiempo obtenido: "></asp:Label>
                                                                                         &nbsp;&nbsp;<asp:TextBox ID="p1a" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                                                                                         <asp:Label ID="Label127" runat="server" Text=":"></asp:Label>
                                                                                         <asp:TextBox ID="p1b" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                                                                                         <asp:Label ID="Label128" runat="server" Text=":"></asp:Label>
                                                                                         <asp:TextBox ID="p1c" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                                                                                         <asp:Label ID="Label129" runat="server" Text=":"></asp:Label>
                                                                                         <asp:TextBox ID="p1d" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                                                                                         &nbsp;&nbsp;<br /><asp:Label ID="lp5" runat="server" ForeColor="Red" style="text-align: center" Width="320px"></asp:Label>
</asp:Panel>
<br />
     <asp:Panel ID="Panel17" runat="server" CssClass="PanelTexbox" Width="325px" Height="85px" >
<asp:Panel ID="Panel18" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label12" runat="server" Text="Tiempo que demora en recorrer 2000 metros" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
         &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;<asp:Label ID="Label307" runat="server" Text="h " style="font-size: small" ForeColor="#333333"  ></asp:Label>
                                       
                                         &nbsp;<asp:Label ID="Label308" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
&nbsp;<asp:Label ID="Label309" runat="server" ForeColor="#333333" style="font-size: small" Text="m"></asp:Label>
         &nbsp;<asp:Label ID="Label310" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
         &nbsp;<asp:Label ID="Label311" runat="server" ForeColor="#333333" style="font-size: small" Text="s"></asp:Label>
         &nbsp;<asp:Label ID="Label312" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
         &nbsp;<asp:Label ID="Label313" runat="server" ForeColor="#333333" style="font-size: small" Text="ms"></asp:Label>
         <br />
         &nbsp;
         <asp:Label ID="Label143" runat="server" ForeColor="#333333" Text="Tiempo obtenido: "></asp:Label>
         &nbsp;
         <asp:TextBox ID="p2a" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
         <asp:Label ID="Label145" runat="server" Text=":"></asp:Label>
         <asp:TextBox ID="p2b" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
         <asp:Label ID="Label146" runat="server" Text=":"></asp:Label>
         <asp:TextBox ID="p2c" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
         <asp:Label ID="Label147" runat="server" Text=":"></asp:Label>
         <asp:TextBox ID="p2d" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
         &nbsp;
                                       
                                         <br />
                                            <asp:Label ID="lp8" runat="server" ForeColor="Red" style="text-align: center" Width="320px"></asp:Label>
</asp:Panel>

             <br />                                
 <asp:Panel ID="Panel23" runat="server" CssClass="PanelTexbox" Height="105px" Width="325px">
                                                                                             <asp:Panel ID="Panel24" runat="server" CssClass="pantitu">
                                                                                                 <asp:Label ID="Label15" runat="server" CssClass="fuente" ForeColor="#333333" Text="Velocidad obtenida en una distancia de 500 m"></asp:Label>
                                                                                             </asp:Panel>
                                                                                             &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;<asp:Label ID="Label314" runat="server" style="font-size: small" Text="h " ForeColor="#333333"></asp:Label>
                                                                                             &nbsp;<asp:Label ID="Label315" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
&nbsp;<asp:Label ID="Label316" runat="server" ForeColor="#333333" style="font-size: small" Text="m"></asp:Label>
                                                                                             &nbsp;<asp:Label ID="Label317" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
                                                                                             &nbsp;<asp:Label ID="Label318" runat="server" ForeColor="#333333" style="font-size: small" Text="s"></asp:Label>
                                                                                             &nbsp;<asp:Label ID="Label319" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
                                                                                             &nbsp;<asp:Label ID="Label320" runat="server" ForeColor="#333333" style="font-size: small" Text="ms"></asp:Label>
                                                                                             <br />
                                                                                             &nbsp;
                                                                                             <asp:Label ID="Label178" runat="server" ForeColor="#333333" Text="Tiempo obtenido: "></asp:Label>
                                                                                             &nbsp;
                                                                                             <asp:TextBox ID="p5a" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                                                                                             <asp:Label ID="Label180" runat="server" Text=":"></asp:Label>
                                                                                             <asp:TextBox ID="p5b" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                                                                                             <asp:Label ID="Label181" runat="server" Text=":"></asp:Label>
                                                                                             <asp:TextBox ID="p5c" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                                                                                             <asp:Label ID="Label182" runat="server" Text=":"></asp:Label>
                                                                                             <asp:TextBox ID="p5d" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                                                                                             &nbsp;
                                                                                             <br />
                                                                                             <asp:Label ID="lp11" runat="server" ForeColor="Red" style="text-align: center" Width="320px"></asp:Label>
                                              <br />
                                                                                             &nbsp;<asp:Label ID="vl" runat="server" Text="Velocidad Obtenida: " Visible="False" ForeColor="#333333"></asp:Label>
                                                                                             &nbsp;
                                                                                             <asp:TextBox ID="rvel500" runat="server" Enabled="False" Visible="False" Width="136px" ForeColor="#333333"  CssClass="PanelTexbox" Height="20px"></asp:TextBox>
                                                                                             &nbsp;
                                                                                             <asp:Label ID="vl2" runat="server" Text="m/s " Visible="False" ForeColor="#333333"></asp:Label>
                                                                                             <br />
                                                                                         </asp:Panel>

 <br />



                                                                                         <asp:Panel ID="Panel19" runat="server" CssClass="PanelTexbox" Height="115px" Width="325px">
                                                                                             <asp:Panel ID="Panel20" runat="server" CssClass="pantitu">
                                                                                                 <asp:Label ID="Label13" runat="server" CssClass="fuente" ForeColor="#333333" Text="Aceleracion de un desplazamiento global en una distancia de 20 metros (salida parada de pie)"></asp:Label>
                                                                                             </asp:Panel>
                                                                                             &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp;<asp:Label ID="Label321" runat="server" style="font-size: small" Text="h " ForeColor="#333333"></asp:Label>
                                                                                             &nbsp;<asp:Label ID="Label322" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
&nbsp;<asp:Label ID="Label323" runat="server" ForeColor="#333333" style="font-size: small" Text="m"></asp:Label>
                                                                                             &nbsp;<asp:Label ID="Label324" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
                                                                                             &nbsp;<asp:Label ID="Label325" runat="server" ForeColor="#333333" style="font-size: small" Text="s"></asp:Label>
                                                                                             &nbsp;<asp:Label ID="Label326" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
                                                                                             &nbsp;<asp:Label ID="Label327" runat="server" ForeColor="#333333" style="font-size: small" Text="ms"></asp:Label>
                                                                                             <br />
                                                                                             &nbsp;
                                                                                             <asp:Label ID="Label233" runat="server" ForeColor="#333333" Text="Tiempo obtenido: "></asp:Label>
                                                                                             &nbsp;
                                                                                             <asp:TextBox ID="p10a" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                                                                                             <asp:Label ID="Label235" runat="server" Text=":"></asp:Label>
                                                                                             <asp:TextBox ID="p10b" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                                                                                             <asp:Label ID="Label236" runat="server" Text=":"></asp:Label>
                                                                                             <asp:TextBox ID="p10c" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                                                                                             <asp:Label ID="Label237" runat="server" Text=":"></asp:Label>
                                                                                             <asp:TextBox ID="p10d" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                                                                                             &nbsp;
                                                                                             <br />
                                                                                             <asp:Label ID="lp14" runat="server" ForeColor="Red" style="text-align: center" Width="320px"></asp:Label>
                                                                                             <br />
                                                                                             &nbsp;<asp:Label ID="ac1" runat="server" Text="Aceleracion Obtenida: " Visible="False" ForeColor="#333333"></asp:Label>
                                                                                             &nbsp;<asp:TextBox ID="resAcel20" runat="server" Enabled="False" Visible="False" Width="136px" ForeColor="#333333"  CssClass="PanelTexbox" Height="20px"></asp:TextBox>
                                                                                             &nbsp;<asp:Label ID="ac4" runat="server" Text="m/s^2" Visible="False" ForeColor="#333333"></asp:Label>
                                                                                         </asp:Panel>
<asp:Panel ID="Panel31" runat="server" Height="5px"></asp:Panel>


                                                                                     </td>
                                                                                 </tr>
                                                                             </table>
                                                                         </asp:Panel>


                                                                     </td>

<td>
 

    <asp:Panel ID="Panel80" runat="server">
        <table class="auto-style2">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td style="text-align: left">
<br />
                    <asp:Panel ID="Panel27" runat="server" CssClass="PanelTexbox" Height="100px" Width="325px">
                        <asp:Panel ID="Panel28" runat="server" CssClass="pantitu">
                            <asp:Label ID="Label17" runat="server" CssClass="fuente" ForeColor="#333333" Text="Saltos continuos de duracion larga"></asp:Label>
                        </asp:Panel>
                        <br />
                        &nbsp;
                        <asp:Label ID="Label223" runat="server" ForeColor="#333333" Text="Cantidad de saltos "></asp:Label>
                        <br />
                        &nbsp;
                        <asp:Label ID="Label5" runat="server" ForeColor="#333333" Text="realizados en 1 minuto: "></asp:Label>
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:TextBox ID="txtsalo1m" runat="server" ForeColor="#333333" Height="20px" Width="83px"  CssClass="PanelTexbox" MaxLength="4"></asp:TextBox>
                        <br />
                        <asp:Label ID="lp6" runat="server" ForeColor="Red" style="text-align: center" Width="320px"></asp:Label>
                    </asp:Panel>
                    <br />
                    <asp:Panel ID="Panel25" runat="server" CssClass="PanelTexbox" Height="100px" Width="325px">
                        <asp:Panel ID="Panel26" runat="server" CssClass="pantitu">
                            <asp:Label ID="Label16" runat="server" CssClass="fuente" ForeColor="#333333" Text="Potencia Abdominal"></asp:Label>
                        </asp:Panel>
                        <br />
                        &nbsp;
                        <asp:Label ID="Label201" runat="server" ForeColor="#333333" Text="Cantidad de repeticiones "></asp:Label>
                        <br />
                        &nbsp;
                        <asp:Label ID="Label4" runat="server" ForeColor="#333333" Text="realizadas en 15 segundos: "></asp:Label>
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:TextBox ID="txtv15s" runat="server" ForeColor="#333333" Height="20px" Width="83px" CssClass="PanelTexbox" MaxLength="4"></asp:TextBox>
                        <br />
                        <asp:Label ID="lp9" runat="server" ForeColor="Red" style="text-align: center" Width="320px"></asp:Label>
                    </asp:Panel>
                    <br />
                    <asp:Panel ID="Panel21" runat="server" CssClass="PanelTexbox" Height="120px" Width="325px">
                        <asp:Panel ID="Panel22" runat="server" CssClass="pantitu">
                            <asp:Label ID="Label14" runat="server" CssClass="fuente" ForeColor="#333333" Text="Aceleracion de un desplazamiento global en una distancia de 30 metros (salida lanzada)"></asp:Label>
                        </asp:Panel>
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:Label ID="Label328" runat="server" ForeColor="#333333" style="font-size: small" Text="h "></asp:Label>
                        &nbsp;<asp:Label ID="Label329" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
&nbsp;<asp:Label ID="Label330" runat="server" ForeColor="#333333" style="font-size: small" Text="m"></asp:Label>
                        &nbsp;<asp:Label ID="Label331" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
                        &nbsp;<asp:Label ID="Label332" runat="server" ForeColor="#333333" style="font-size: small" Text="s"></asp:Label>
                        &nbsp;<asp:Label ID="Label333" runat="server" ForeColor="#333333" style="font-size: small" Text=":"></asp:Label>
                        &nbsp;<asp:Label ID="Label334" runat="server" ForeColor="#333333" style="font-size: small" Text="ms"></asp:Label>
                        <br />
                        &nbsp;
                        <asp:Label ID="Label251" runat="server" ForeColor="#333333" Text="Tiempo obtenido: "></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="p11a" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                        <asp:Label ID="Label253" runat="server" Text=":"></asp:Label>
                        <asp:TextBox ID="p11b" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                        <asp:Label ID="Label254" runat="server" Text=":"></asp:Label>
                        <asp:TextBox ID="p11c" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                        <asp:Label ID="Label255" runat="server" Text=":"></asp:Label>
                        <asp:TextBox ID="p11d" runat="server" CssClass="PanelTexbox" ForeColor="#333333" Height="20px" MaxLength="2" Width="15px">00</asp:TextBox>
                        &nbsp;
                        <br />
                        <asp:Label ID="lp12" runat="server" ForeColor="Red" style="text-align: center" Width="320px"></asp:Label>
                        <br />
                        &nbsp;<asp:Label ID="ab1" runat="server" ForeColor="#333333" Text="Aceleracion Obtenida: " Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="resAcel30" runat="server" Enabled="False" ForeColor="#333333" Visible="False" Width="136px"  CssClass="PanelTexbox" Height="20px"></asp:TextBox>
                        &nbsp;<asp:Label ID="ab4" runat="server" ForeColor="#333333" Text="m/s^2" Visible="False" CssClass="auto-style8"></asp:Label>
                        <br />
                        <br />
                    </asp:Panel>
<br />
                    <asp:Panel ID="Panel81" runat="server" Height="79px">
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </asp:Panel>
 

</td>
                                                                 </tr>
                                                             </table>
</asp:Panel>                                                                                                                                                                        
                        </asp:Panel>

                        <asp:Panel ID="Panel76" runat="server" style="text-align: center">
     
                  <asp:Panel ID="Panel29" runat="server" CssClass="PanelTexbox" Width="1086px" >
<asp:Panel ID="Panel30" runat="server" CssClass="pantitu" Height="35px" >
<br />
 <asp:Label ID="Label19" runat="server" Text="Conclusion de la prueba realizada" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>

                            <asp:Panel ID="Panel77" runat="server">
<br />
                                                                    <asp:Label ID="Label84" runat="server" Width="409px"></asp:Label>
                                    <asp:Button ID="btnResulfis" runat="server" Text="Resultado de la Prueba " OnClick="btnResulfis_Click" Height="35px" Width="221px" BackColor="#D2D2D2" CssClass="btn" />
                                   &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
  <asp:TextBox ID="txtresfinal" runat="server" Enabled="False" Width="107px" Visible="False" ForeColor="#333333"  CssClass="PanelTexbox" Height="20px"></asp:TextBox>
                                                                        

                            </asp:Panel>
                            <asp:Label ID="Label271" runat="server" Text="Observaciones:" Visible="False" ForeColor="#333333"></asp:Label>
                            &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                              
                                         
                                
                                    <asp:TextBox ID="f5" runat="server" Height="34px" TextMode="MultiLine" Width="960px" Visible="False" ForeColor="#333333"  CssClass="PanelTexbox"></asp:TextBox>
</asp:Panel>
                        </asp:Panel>
<br />
                        <asp:Button ID="BtnGuardarFisico" runat="server" Height="36px" Text="Guardar Datos" Width="243px" Visible="False" OnClick="BtnGuardarFisico_Click" BackColor="#D2D2D2" CssClass="btn" />
<asp:Panel ID="Panel3" runat="server" Visible="False">
<asp:Label ID="lt1" runat="server" Visible="False"></asp:Label>
                                    <asp:Label ID="rt1s" runat="server" Visible="False"></asp:Label>
                                    <asp:Label ID="rtf1" runat="server" Visible="False"></asp:Label>
                                        <asp:Label ID="lt2" runat="server" Visible="False"></asp:Label>
                                        <asp:Label ID="rts2" runat="server" Visible="False"></asp:Label>
                                        <asp:Label ID="rtf2" runat="server" Visible="False"></asp:Label>
                                            <asp:Label ID="rts3" runat="server" Visible="False"></asp:Label>
                                            <asp:Label ID="rtf3" runat="server" Visible="False"></asp:Label>
                                                <asp:Label ID="rts4" runat="server" Visible="False"></asp:Label>
                                                <asp:Label ID="rtf4" runat="server" Visible="False"></asp:Label>
                                                    <asp:Label ID="rts5" runat="server" Visible="False"></asp:Label>
                                                    <asp:Label ID="rtf5" runat="server" Visible="False"></asp:Label>
                                                        <asp:Label ID="rts6" runat="server" Visible="False"></asp:Label>
                                                        <asp:Label ID="rtf6" runat="server" Visible="False"></asp:Label>

                                                            <asp:Label ID="rts7" runat="server" Visible="False"></asp:Label>
                                                            <asp:Label ID="rtf7" runat="server" Visible="False"></asp:Label>

                                                                <asp:Label ID="rts8" runat="server" Visible="False"></asp:Label>
                                                                <asp:Label ID="rtf8" runat="server" Visible="False"></asp:Label>
                                                                    <asp:Label ID="rts9" runat="server" Visible="False"></asp:Label>
                                                                    <asp:Label ID="rtf9" runat="server" Visible="False"></asp:Label>
                                                                        <asp:Label ID="rts10" runat="server" Visible="False"></asp:Label>
                                                                        <asp:Label ID="rtf10" runat="server" Visible="False"></asp:Label>
                                                                            <asp:Label ID="rts11" runat="server" Visible="False"></asp:Label>
                                                                            <asp:Label ID="rtf11" runat="server" Visible="False"></asp:Label>

</asp:Panel>
                    </asp:Panel>

 </div>

    </form>
</body>
</html>
