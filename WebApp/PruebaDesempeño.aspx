<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PruebaDesempeño.aspx.cs" Inherits="APPAKD.PruebaDesempeño1" %>

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

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: left;
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
        .auto-style8 {
            width: 10px;
        }
        .auto-style9 {
            width: 358px;
        }
        .auto-style10 {
            width: 357px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
<asp:Panel ID="PanelPreguntasGeneralDesempeño" runat="server">
                    <asp:Panel ID="Panel10" runat="server" style="text-align: center; font-size: xx-large" BackColor="Silver">
                        <asp:Label ID="Label49" runat="server" Text="Prueba de Desempeño" style="text-align: center"></asp:Label>
                    </asp:Panel>
                    <asp:Panel ID="Panel11" runat="server" style="text-align: center">
 <asp:Panel ID="Panel3" runat="server" CssClass="PanelTexbox" Width="1086px" Height="195px">
<asp:Panel ID="Panel4" runat="server" CssClass="pantitu" Height="35px" >
<br />
 <asp:Label ID="Titulo" runat="server" Text="Datos Generales" CssClass="fuente" ForeColor="#333333" ></asp:Label>
</asp:Panel>


                            <asp:Panel ID="Panel2" runat="server" Visible="False">
                                <asp:Label ID="fant1" runat="server"></asp:Label>
                                <asp:Label ID="fant2" runat="server"></asp:Label>
                                <asp:Label ID="fant3" runat="server"></asp:Label>
                                <asp:Label ID="fant32" runat="server"></asp:Label>
                                <asp:Label ID="codJu" runat="server"></asp:Label>
                                <asp:Label ID="nom" runat="server"></asp:Label>
                            </asp:Panel>
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                           <asp:Label ID="Label52" runat="server" Text="Encargado de  la Prueba: " CssClass="fuente" ForeColor="#333333"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                           <asp:TextBox ID="d1" runat="server" Width="765px" CssClass="PanelTexbox" ForeColor="#333333" Height="25px"></asp:TextBox>
                            <br />
                            <asp:Label ID="lv1" runat="server" ForeColor="Red" CssClass="fuente"></asp:Label>
                            <br />

                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                            <asp:Label ID="Label54" runat="server" style="text-align: left" Text="Dia : " CssClass="fuente" ForeColor="#333333"></asp:Label>
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                            <asp:TextBox ID="d2" runat="server" Width="129px" TextMode="Date" CssClass="PanelTexbox" ForeColor="#333333" Height="25px"></asp:TextBox>
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            <asp:Label ID="Label57" runat="server" Text="Hora :" CssClass="fuente" ForeColor="#333333"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="d3" runat="server" TextMode="Time" Width="96px" CssClass="PanelTexbox" ForeColor="#333333" Height="25px"></asp:TextBox>
                            <br />
                            <asp:Label ID="lv2" runat="server" ForeColor="Red" CssClass="fuente"></asp:Label>
                            <br />

                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
<asp:Label ID="Label58" runat="server" Text="Lugar : " CssClass="fuente" ForeColor="#333333"></asp:Label>
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="d4" runat="server" Width="765px" CssClass="PanelTexbox" ForeColor="#333333" Height="25px"></asp:TextBox>
                            &nbsp;
                            <br />
                            <asp:Label ID="lv205" runat="server" ForeColor="Red"  CssClass="fuente"></asp:Label>


 </asp:Panel>
 </asp:Panel>



                        <asp:Panel ID="Panel12" runat="server">
                            
 <asp:Panel ID="Panel5" runat="server" CssClass="PanelTexbox" Width="1086px" Height="420px">
<asp:Panel ID="Panel6" runat="server" CssClass="pantitu" Height="35px" >
<br />
 <asp:Label ID="Label9" runat="server" Text="Datos Encontrados" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>

                            <table class="auto-style1">
                                <tr>
                                    <td style="text-align: left" class="auto-style9">&nbsp;<table class="auto-style1">
                                            <tr>
                                                <td class="auto-style8">&nbsp;</td>
                                                <td><asp:Panel ID="Panel7" runat="server" CssClass="PanelTexbox" Width="325px" Height="100px" >

<asp:Panel ID="Panel8" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label10" runat="server" Text="Pase" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
<br />
                                                    &nbsp;&nbsp;<asp:Label ID="Label61" runat="server" Text="Pase largo realizado" CssClass="fuente" ForeColor="#333333"></asp:Label>
<br />

                                &nbsp;&nbsp;<asp:Label ID="Label85" runat="server" Text="con un balon: " CssClass="fuente" ForeColor="#333333"></asp:Label>
                               
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlZ1" runat="server" Height="23px" Width="110px" CssClass="PanelTexbox" ForeColor="#333333">
                                    <asp:ListItem Value="0">Seleccionar....</asp:ListItem>
                                    <asp:ListItem Value="1">1 punto</asp:ListItem>
                                    <asp:ListItem Value="2">2 puntos</asp:ListItem>
                                    <asp:ListItem Value="3">3 puntos</asp:ListItem>
                                    <asp:ListItem Value="4">4 puntos</asp:ListItem>
                                    <asp:ListItem Value="5">5 puntos</asp:ListItem>
                                    <asp:ListItem Value="6">6 puntos</asp:ListItem>
                                    <asp:ListItem Value="7">7 puntos</asp:ListItem>
                                    <asp:ListItem Value="8">8 puntos</asp:ListItem>
                                    <asp:ListItem Value="9">9 puntos</asp:ListItem>
                                    <asp:ListItem Value="10">10 puntos</asp:ListItem>
                                </asp:DropDownList>
<br />

                                        <asp:Label ID="lv3" runat="server" ForeColor="Red" style="text-align: center" Width="315px" CssClass="fuente"></asp:Label>
                                <br />
                                                           
</asp:Panel>
<br />

<asp:Panel ID="Panel9" runat="server" CssClass="PanelTexbox" Width="325px" Height="100px">
<asp:Panel ID="Panel14" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label11" runat="server" Text="Conducción del balón(Zig-Zag)" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
                                        <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label65" runat="server" Text="Conducción del balón ,en zig-zag" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                          <br />
                                                        &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text=" con cuatro obstáculos: " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlZ3" runat="server" Height="23px" Width="110px" CssClass="PanelTexbox" ForeColor="#333333">
                                            <asp:ListItem Value="0">Seleccionar....</asp:ListItem>
                                            <asp:ListItem Value="1">1 punto</asp:ListItem>
                                            <asp:ListItem Value="2">2 puntos</asp:ListItem>
                                            <asp:ListItem Value="3">3 puntos</asp:ListItem>
                                            <asp:ListItem Value="4">4 puntos</asp:ListItem>
                                            <asp:ListItem Value="5">5 puntos</asp:ListItem>
                                            <asp:ListItem Value="6">6 puntos</asp:ListItem>
                                            <asp:ListItem Value="7">7 puntos</asp:ListItem>
                                            <asp:ListItem Value="8">8 puntos</asp:ListItem>
                                            <asp:ListItem Value="9">9 puntos</asp:ListItem>
                                            <asp:ListItem Value="10">10 puntos</asp:ListItem>
                                        </asp:DropDownList>
                                        <br />
                                        <asp:Label ID="lv5" runat="server" ForeColor="Red" style="text-align: center" Width="315px" CssClass="fuente"></asp:Label>
</asp:Panel>
 <br />

                  <asp:Panel ID="Panel15" runat="server" CssClass="PanelTexbox" Width="325px" Height="100px" >
<asp:Panel ID="Panel16" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label12" runat="server" Text="Conducción del elevada del balón" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
                                                <br />
                                                &nbsp;&nbsp;<asp:Label ID="Label69" runat="server" Text="Conducción elevada del balón  hasta " style="text-align: left" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                 <br />
                                                        &nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="el vértice del área : " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlZ5" runat="server" Height="23px" Width="110px" CssClass="PanelTexbox" ForeColor="#333333">
                                                    <asp:ListItem Value="0">Seleccionar....</asp:ListItem>
                                                    <asp:ListItem Value="1">1 punto</asp:ListItem>
                                                    <asp:ListItem Value="2">2 puntos</asp:ListItem>
                                                    <asp:ListItem Value="3">3 puntos</asp:ListItem>
                                                    <asp:ListItem Value="4">4 puntos</asp:ListItem>
                                                    <asp:ListItem Value="5">5 puntos</asp:ListItem>
                                                    <asp:ListItem Value="6">6 puntos</asp:ListItem>
                                                    <asp:ListItem Value="7">7 puntos</asp:ListItem>
                                                    <asp:ListItem Value="8">8 puntos</asp:ListItem>
                                                    <asp:ListItem Value="9">9 puntos</asp:ListItem>
                                                    <asp:ListItem Value="10">10 puntos</asp:ListItem>
                                                </asp:DropDownList>
                                                <br />

                                        <asp:Label ID="lv7" runat="server" ForeColor="Red" style="text-align: center" Width="315px" CssClass="fuente"></asp:Label>

</asp:Panel>
   <br /> 

                                                </td>
                                            </tr>
                                        </table>


 </td>
                                    <td class="auto-style10">&nbsp;<table class="auto-style1">
                                            <tr>
                                                <td class="auto-style8">&nbsp;</td>
                                                <td><asp:Panel ID="Panel17" runat="server" CssClass="PanelTexbox" Width="325px" Height="100px" >
<asp:Panel ID="Panel18" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label13" runat="server" Text="Conducción del balón(Lineal)" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
                                                    <br />
                                                    &nbsp;&nbsp;<asp:Label ID="Label63" runat="server" Text="Conducción del balón , en  una " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                  <br />
                                                        &nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="linea recta: " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlZ2" runat="server" Height="23px" Width="110px" CssClass="PanelTexbox" ForeColor="#333333">
                                        <asp:ListItem Value="0">Seleccionar....</asp:ListItem>
                                        <asp:ListItem Value="1">1 punto</asp:ListItem>
                                        <asp:ListItem Value="2">2 puntos</asp:ListItem>
                                        <asp:ListItem Value="3">3 puntos</asp:ListItem>
                                        <asp:ListItem Value="4">4 puntos</asp:ListItem>
                                        <asp:ListItem Value="5">5 puntos</asp:ListItem>
                                        <asp:ListItem Value="6">6 puntos</asp:ListItem>
                                        <asp:ListItem Value="7">7 puntos</asp:ListItem>
                                        <asp:ListItem Value="8">8 puntos</asp:ListItem>
                                        <asp:ListItem Value="9">9 puntos</asp:ListItem>
                                        <asp:ListItem Value="10">10 puntos</asp:ListItem>
                                    </asp:DropDownList>
                                    <br />
                                        <asp:Label ID="lv4" runat="server" ForeColor="Red" style="text-align: center" Width="315px" CssClass="fuente"></asp:Label>

</asp:Panel>
 <br />

                  <asp:Panel ID="Panel19" runat="server" CssClass="PanelTexbox" Width="325px" Height="100px" >
<asp:Panel ID="Panel20" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label14" runat="server" Text="Efectua Tiro" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
                                            <br />
                                            &nbsp;&nbsp;<asp:Label ID="Label67" runat="server" Text="Efectuar tiro a puerta desde" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                           <br />
                                                        &nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="fuera del area: " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlZ4" runat="server" Height="23px" Width="110px" CssClass="PanelTexbox" ForeColor="#333333">
                                                <asp:ListItem Value="0">Seleccionar....</asp:ListItem>
                                                <asp:ListItem Value="1">1 punto</asp:ListItem>
                                                <asp:ListItem Value="2">2 puntos</asp:ListItem>
                                                <asp:ListItem Value="3">3 puntos</asp:ListItem>
                                                <asp:ListItem Value="4">4 puntos</asp:ListItem>
                                                <asp:ListItem Value="5">5 puntos</asp:ListItem>
                                                <asp:ListItem Value="6">6 puntos</asp:ListItem>
                                                <asp:ListItem Value="7">7 puntos</asp:ListItem>
                                                <asp:ListItem Value="8">8 puntos</asp:ListItem>
                                                <asp:ListItem Value="9">9 puntos</asp:ListItem>
                                                <asp:ListItem Value="10">10 puntos</asp:ListItem>
                                            </asp:DropDownList>
                                            <br />

                                        <asp:Label ID="lv6" runat="server" ForeColor="Red" style="text-align: center" Width="315px" CssClass="fuente"></asp:Label>

</asp:Panel>
 <br />
                  <asp:Panel ID="Panel21" runat="server" CssClass="PanelTexbox" Width="325px" Height="100px" >
<asp:Panel ID="Panel22" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label15" runat="server" Text="Tiro de pecision" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
                                                    <br />
                                                    &nbsp;&nbsp;<asp:Label ID="Label71" runat="server" Text="Tiro de precisión situado sobre" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                  <br />
                                                        &nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text="la linea base: " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlZ6" runat="server" Height="23px" Width="110px" CssClass="PanelTexbox" ForeColor="#333333">
                                                        <asp:ListItem Value="0">Seleccionar....</asp:ListItem>
                                                        <asp:ListItem Value="1">1 punto</asp:ListItem>
                                                        <asp:ListItem Value="2">2 puntos</asp:ListItem>
                                                        <asp:ListItem Value="3">3 puntos</asp:ListItem>
                                                        <asp:ListItem Value="4">4 puntos</asp:ListItem>
                                                        <asp:ListItem Value="5">5 puntos</asp:ListItem>
                                                        <asp:ListItem Value="6">6 puntos</asp:ListItem>
                                                        <asp:ListItem Value="7">7 puntos</asp:ListItem>
                                                        <asp:ListItem Value="8">8 puntos</asp:ListItem>
                                                        <asp:ListItem Value="9">9 puntos</asp:ListItem>
                                                        <asp:ListItem Value="10">10 puntos</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <br />
                                                    <asp:Label ID="lv8" runat="server" ForeColor="Red" style="text-align: center" Width="315px" CssClass="fuente"></asp:Label>

</asp:Panel>

 <br />


                                                </td>
                                            </tr>
                                        </table>


                                    </td>
<td class="auto-style2">&nbsp;<table class="auto-style1">
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td><asp:Panel ID="Panel23" runat="server" CssClass="PanelTexbox" Width="325px" Height="100px" >
<asp:Panel ID="Panel24" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label16" runat="server" Text="Conducción del balon (acompañado)" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
                                                        <br />
                                                        &nbsp;&nbsp;<asp:Label ID="Label73" runat="server" Text="Control del balon en conjunto" CssClass="fuente" ForeColor="#333333"></asp:Label>
 <br />
                                                        &nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text=" con un  compañero :" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlZ7" runat="server" Height="23px" Width="110px" CssClass="PanelTexbox" ForeColor="#333333">
                                                            <asp:ListItem Value="0">Seleccionar....</asp:ListItem>
                                                            <asp:ListItem Value="1">1 punto</asp:ListItem>
                                                            <asp:ListItem Value="2">2 puntos</asp:ListItem>
                                                            <asp:ListItem Value="3">3 puntos</asp:ListItem>
                                                            <asp:ListItem Value="4">4 puntos</asp:ListItem>
                                                            <asp:ListItem Value="5">5 puntos</asp:ListItem>
                                                            <asp:ListItem Value="6">6 puntos</asp:ListItem>
                                                            <asp:ListItem Value="7">7 puntos</asp:ListItem>
                                                            <asp:ListItem Value="8">8 puntos</asp:ListItem>
                                                            <asp:ListItem Value="9">9 puntos</asp:ListItem>
                                                            <asp:ListItem Value="10">10 puntos</asp:ListItem>
                                                        </asp:DropDownList>
                                                        <br />
                                        <asp:Label ID="lv9" runat="server" ForeColor="Red" style="text-align: center" Width="315px" CssClass="fuente"></asp:Label>
                                   
</asp:Panel>
 <br />
                  <asp:Panel ID="Panel25" runat="server" CssClass="PanelTexbox" Width="325px" Height="100px" >
<asp:Panel ID="Panel26" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label17" runat="server" Text="Lanzamiento del balon" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
                                                                <br />
                                                                &nbsp;&nbsp;<asp:Label ID="Label77" runat="server" Text="Lanzamiento a puerta desde fuera" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                               <br />
                                                        &nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="del area: " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlZ9" runat="server" Height="23px" Width="110px" CssClass="PanelTexbox" ForeColor="#333333">
                                                                    <asp:ListItem Value="0">Seleccionar....</asp:ListItem>
                                                                    <asp:ListItem Value="1">1 punto</asp:ListItem>
                                                                    <asp:ListItem Value="2">2 puntos</asp:ListItem>
                                                                    <asp:ListItem Value="3">3 puntos</asp:ListItem>
                                                                    <asp:ListItem Value="4">4 puntos</asp:ListItem>
                                                                    <asp:ListItem Value="5">5 puntos</asp:ListItem>
                                                                    <asp:ListItem Value="6">6 puntos</asp:ListItem>
                                                                    <asp:ListItem Value="7">7 puntos</asp:ListItem>
                                                                    <asp:ListItem Value="8">8 puntos</asp:ListItem>
                                                                    <asp:ListItem Value="9">9 puntos</asp:ListItem>
                                                                    <asp:ListItem Value="10">10 puntos</asp:ListItem>
                                                                </asp:DropDownList>
                                                                <br />
                                        <asp:Label ID="lv11" runat="server" ForeColor="Red" style="text-align: center" Width="315px" CssClass="fuente"></asp:Label>
                               
</asp:Panel>
 <br />
                  <asp:Panel ID="Panel27" runat="server" CssClass="PanelTexbox" Width="325px" Height="100px" >
<asp:Panel ID="Panel28" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label18" runat="server" Text="Maniobrabilidad de balon" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
                                                            <br />
                                                            &nbsp;&nbsp;<asp:Label ID="Label75" runat="server" style="text-align: center" Text="Maniobrabilidad de balon en " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                          <br />
                                                        &nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="obstaculos con vallas: " CssClass="fuente" ForeColor="#333333"></asp:Label> 
                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlZ8" runat="server" Height="23px" Width="110px" CssClass="PanelTexbox" ForeColor="#333333">
                                                                <asp:ListItem Value="0">Seleccionar....</asp:ListItem>
                                                                <asp:ListItem Value="1">1 punto</asp:ListItem>
                                                                <asp:ListItem Value="2">2 puntos</asp:ListItem>
                                                                <asp:ListItem Value="3">3 puntos</asp:ListItem>
                                                                <asp:ListItem Value="4">4 puntos</asp:ListItem>
                                                                <asp:ListItem Value="5">5 puntos</asp:ListItem>
                                                                <asp:ListItem Value="6">6 puntos</asp:ListItem>
                                                                <asp:ListItem Value="7">7 puntos</asp:ListItem>
                                                                <asp:ListItem Value="8">8 puntos</asp:ListItem>
                                                                <asp:ListItem Value="9">9 puntos</asp:ListItem>
                                                                <asp:ListItem Value="10">10 puntos</asp:ListItem>
                                                            </asp:DropDownList>
                                                            <br />
                                        <asp:Label ID="lv10" runat="server" ForeColor="Red" style="text-align: center" Width="315px" CssClass="fuente"></asp:Label>
                                    
                                                                                                                                            
</asp:Panel>
   <br /> 
            </td>
        </tr>
    </table>
                              

</td>

                                </tr>
                            </table>


                                                          
</asp:Panel>
             
                                                                </asp:Panel>
                        <asp:Panel ID="Panel13" runat="server" style="text-align: center">

                  <asp:Panel ID="Panel29" runat="server" CssClass="PanelTexbox" Width="1086px" >
<asp:Panel ID="Panel30" runat="server" CssClass="pantitu" Height="35px" >
<br />
 <asp:Label ID="Label19" runat="server" Text="Conclusion de la prueba realizada" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>

                           
                                    <br />
                                    <asp:Label ID="Label84" runat="server" Width="409px" CssClass="fuente"></asp:Label>
                                <asp:Button ID="btnResultado" runat="server" Text="Resultado de la Prueba " OnClick="btnResultado_Click" Height="35px" Width="221px" CssClass="btn" BackColor="#D2D2D2" />
                                        &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
<asp:TextBox ID="txtResDesempeño" runat="server" Width="107px" Enabled="False" CssClass="PanelTexbox" ForeColor="#333333" Height="25px"></asp:TextBox>
<asp:Label ID="lblOptenido" runat="server" Text="Puntaje Obtenido: " Visible="False" CssClass="fuente" ForeColor="#333333"></asp:Label>
                               <asp:TextBox ID="txtResulDesem" runat="server" Width="46px" Enabled="False" Visible="False" CssClass="PanelTexbox" ForeColor="#333333"></asp:TextBox>
                                        <asp:Label ID="lblpunt" runat="server" Visible="False" CssClass="fuente" ForeColor="#333333" >puntos</asp:Label>
                                        <br />
                                <asp:Label ID="Label83" runat="server" Text="Observaciones:" Visible="False" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                    &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                    <br />
                                    <asp:TextBox ID="d5" runat="server" Height="54px" TextMode="MultiLine" Width="960px" Visible="False" CssClass="PanelTexbox" ForeColor="#333333"></asp:TextBox>
   </asp:Panel>
                        </asp:Panel>
<br />
<asp:Panel ID="Panel1" runat="server" style="text-align: center">
                        <asp:Button ID="btnGuardarDesempeño" runat="server" Height="36px" Text="Guardar Datos" Width="243px" Visible="False" CssClass="btn"  OnClick="btnGuardarDesempeño_Click" BackColor="#D2D2D2" />
                    </asp:Panel>
</asp:Panel>
    </div>
    </form>
</body>
</html>
