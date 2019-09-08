<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PruebaPsicologica.aspx.cs" Inherits="APPAKD.PruebaPsicologica" %>

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
        .fuente {
            font-family: 'Lato', sans-serif;
                font-size: small;
            text-align: center;
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
        .auto-style4 {
            width: 10px;
        }
        .auto-style5 {
            width: 357px;
        }
        .auto-style6 {
            width: 358px;
        }
        .der {


        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>

                        <asp:Panel ID="PanelPreguntasGeneralPsicologico" runat="server" style="text-align: center">
                    <asp:Panel ID="PanelTitulo" runat="server" style="text-align: center; font-size: xx-large" BackColor="Silver">
                        <asp:Label ID="Label9" runat="server" Text="Prueba Psicologica" style="text-align: center"></asp:Label>
                    </asp:Panel>
                    <asp:Panel ID="PDatosG" runat="server" style="text-align: center">
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
                                <asp:Label ID="Label11" runat="server" Text="Encargado de  la Prueba: " CssClass="fuente" ForeColor="#333333"></asp:Label>
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="txtencargado" runat="server" Width="765px" CssClass="PanelTexbox" Height="25px"></asp:TextBox>
                                 <br />

                                        <asp:Label ID="lp1" runat="server" ForeColor="Red" CssClass="fuente"></asp:Label>

                                <br />
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                    <asp:Label ID="Label13" runat="server" Text="Dia : " style="text-align: left" CssClass="fuente" ForeColor="#333333" ></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="txtdia" runat="server" Width="129px" TextMode="Date" CssClass="PanelTexbox" Height="25px"></asp:TextBox>
  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                    <asp:Label ID="Label16" runat="server" Text="Hora :" CssClass="fuente" ForeColor="#333333"></asp:Label>
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:TextBox ID="txthora" runat="server" Width="96px" TextMode="Time" CssClass="PanelTexbox" Height="25px"></asp:TextBox>

                                     <br />

                                        <asp:Label ID="lp2" runat="server" ForeColor="Red" CssClass="fuente"></asp:Label>
                                    <br />

                           &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label120" runat="server" Text="Lugar : " CssClass="fuente" ForeColor="#333333"></asp:Label>
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:TextBox ID="txtlugar" runat="server" Width="765px" CssClass="PanelTexbox" Height="25px"></asp:TextBox>
                                         <br />

                                        <asp:Label ID="lp3" runat="server" ForeColor="Red" CssClass="fuente"></asp:Label>
 <br />
</asp:Panel>
 </asp:Panel>

<asp:Panel ID="PanDatosEncontrados" runat="server">
 <asp:Panel ID="Panel5" runat="server" CssClass="PanelTexbox" Width="1086px" Height="510px">
<asp:Panel ID="Panel6" runat="server" CssClass="pantitu" Height="35px" >
<br />
 <asp:Label ID="Label14" runat="server" Text="Datos Encontrados" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
<br />


    <table class="auto-style1">
        <tr>
            <td style="text-align: left" class="auto-style6">

                <asp:Panel ID="Panel31" runat="server">
                    <table class="auto-style1">
                        <tr>



                                        <td class="auto-style4"></td>
                                        <td>
 <asp:Panel ID="Panel13" runat="server" CssClass="PanelTexbox" Height="92px" Width="325px">
                                                    <asp:Panel ID="Panel8" runat="server" CssClass="pantitu">
                                                        <asp:Label ID="Label18" runat="server" CssClass="fuente" ForeColor="#333333" Text="Motivacion"></asp:Label>
                                                    </asp:Panel>
                                                    <br />
                                                    &nbsp;&nbsp;<asp:Label ID="Label20" runat="server" Text="El paciente se siente motiva al realizar " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                    <br />
                                                    &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="actividades fiscas :" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlMotivado" runat="server" Height="26px" Width="135px" CssClass="fuente" ForeColor="#333333">
                                                        <asp:ListItem Value="0">Seleccionar....</asp:ListItem>
                                                        <asp:ListItem Value="13">Muy frecuente</asp:ListItem>
                                                        <asp:ListItem Value="11">Poco frecuente</asp:ListItem>
                                                        <asp:ListItem Value="9">Regular frecuencia</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <br />
                                                    <asp:Label ID="lp4" runat="server" ForeColor="Red" CssClass="fuente" Width="320px"></asp:Label>
                                                </asp:Panel>

   <br />

                                                <asp:Panel ID="Panel12" runat="server" CssClass="PanelTexbox" Height="92px" Width="325px">
                                                    <asp:Panel ID="Panel3" runat="server" CssClass="pantitu">
                                                        <asp:Label ID="Label19" runat="server" CssClass="fuente" ForeColor="#333333" Text="Percepcion"></asp:Label>
                                                    </asp:Panel>
                                                    <br />
                                                    &nbsp;&nbsp;<asp:Label ID="Label22" runat="server" Text="El paciente tiene  dificultades  en la percepcion" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                    <br />
                                                    &nbsp;&nbsp;<asp:Label ID="Label96" runat="server" Text="de  problemas comunes: " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlpercepcion" runat="server" Height="26px" Width="135px" CssClass="fuente" ForeColor="#333333">
                                                        <asp:ListItem Value="0">Seleccionar...</asp:ListItem>
                                                        <asp:ListItem Value="9">Muy frecuente</asp:ListItem>
                                                        <asp:ListItem Value="11">Poco frecuente</asp:ListItem>
                                                        <asp:ListItem Value="13">Regular frecuencia</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <br />
                                                    <asp:Label ID="lp7" runat="server" ForeColor="Red" CssClass="fuente" Width="320px"></asp:Label>
                                                </asp:Panel>
   <br />
                                                <asp:Panel ID="Panel11" runat="server" CssClass="PanelTexbox" Height="92px" Width="325px">
                                                    <asp:Panel ID="Panel7" runat="server" CssClass="pantitu">
                                                        <asp:Label ID="Label24" runat="server" CssClass="fuente" ForeColor="#333333" Text="Bloqueo Mental"></asp:Label>
                                                    </asp:Panel>
                                                    <br />
                                                    &nbsp;&nbsp;<asp:Label ID="Label25" runat="server" CssClass="fuente" ForeColor="#333333" Text="El paciente presenta"></asp:Label>
                                                    <br />
                                                    &nbsp;&nbsp;<asp:Label ID="Label4" runat="server" CssClass="fuente" ForeColor="#333333" Text=" bloqueo mental :"></asp:Label>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <asp:DropDownList ID="ddlBloqueo" runat="server" Height="26px" Width="135px" CssClass="fuente" ForeColor="#333333">
                                                        <asp:ListItem Value="0">Seleccionar...</asp:ListItem>
                                                        <asp:ListItem Value="9">Muy frecuente</asp:ListItem>
                                                        <asp:ListItem Value="11">Poco frecuente</asp:ListItem>
                                                        <asp:ListItem Value="13">Regular frecuencia</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <br />
                                                    <asp:Label ID="lp10" runat="server" ForeColor="Red" CssClass="fuente" Width="320px"></asp:Label>
                                                </asp:Panel>
   <br />
                                                <asp:Panel ID="Panel10" runat="server" CssClass="PanelTexbox" Height="92px" Width="325px">
                                                    <asp:Panel ID="Panel9" runat="server" CssClass="pantitu">
                                                        <asp:Label ID="Label26" runat="server" CssClass="fuente" ForeColor="#333333" Text="Concentracion"></asp:Label>
                                                    </asp:Panel>
                                                    <br />
                                                    &nbsp;&nbsp;<asp:Label ID="Label29" runat="server" Text="El paciente presenta  perdida " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                    <br />
                                                    &nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="de concentracion :" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlconcentracion" runat="server" Height="26px" Width="135px" CssClass="fuente" ForeColor="#333333">
                                                        <asp:ListItem Value="0">Seleccionar...</asp:ListItem>
                                                        <asp:ListItem Value="9">Muy frecuente</asp:ListItem>
                                                        <asp:ListItem Value="11">Poco frecuente</asp:ListItem>
                                                        <asp:ListItem Value="13">Regular frecuencia</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <br />
                                                    <asp:Label ID="lp13" runat="server" ForeColor="Red" CssClass="fuente" Width="320px"></asp:Label>
                                                </asp:Panel>
                                            <asp:Panel ID="Panel36" runat="server" Height="5px">
                                            </asp:Panel>
   <br />
                                        </td>


                        </tr>
                    </table>
                </asp:Panel>
</td>
            <td style="text-align: left" class="auto-style5">

                <asp:Panel ID="Panel34" runat="server">
<table class="auto-style1">
                        <tr>
                            <td class="auto-style4"></td>
                            <td>

 <asp:Panel ID="Panel14" runat="server" CssClass="PanelTexbox" Height="90px" Width="325px">
                                        <asp:Panel ID="Panel15" runat="server" CssClass="pantitu">
                                            <asp:Label ID="Label27" runat="server" CssClass="fuente" ForeColor="#333333" Text="Trabajo en Equipo"></asp:Label>
                                        </asp:Panel>
 <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label21" runat="server" Text="El paciente presenta  buen trabajo" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                        <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text=" en Equipo :" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddltabajoEqui" runat="server" Height="26px" Width="135px" CssClass="fuente" ForeColor="#333333">
                                            <asp:ListItem Value="0">Seleccionar...</asp:ListItem>
                                            <asp:ListItem Value="13">Muy frecuente</asp:ListItem>
                                            <asp:ListItem Value="11">Poco frecuente</asp:ListItem>
                                            <asp:ListItem Value="9">Regular frecuencia</asp:ListItem>
                                        </asp:DropDownList>
                                        <br />
                                        <asp:Label ID="lp5" runat="server" ForeColor="Red" CssClass="fuente" Width="320px"></asp:Label>
                                    </asp:Panel>
   <br />
                                    <asp:Panel ID="Panel16" runat="server" CssClass="PanelTexbox" Height="100px" Width="325px">
                                        <asp:Panel ID="Panel17" runat="server" CssClass="pantitu">
                                            <asp:Label ID="Label30" runat="server" CssClass="fuente" ForeColor="#333333" Text="Respuesta Positiva"></asp:Label>
                                        </asp:Panel>
 <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label23" runat="server" Text="El paciente da una respuesta positiva ante " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                        <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text=" los problemas :" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlrespuestaPro" runat="server" Height="26px" Width="135px" CssClass="fuente" ForeColor="#333333">
                                            <asp:ListItem Value="0">Seleccionar...</asp:ListItem>
                                            <asp:ListItem Value="13">Muy frecuente</asp:ListItem>
                                            <asp:ListItem Value="11">Poco frecuente</asp:ListItem>
                                            <asp:ListItem Value="9">Regular frecuencia</asp:ListItem>
                                        </asp:DropDownList>
                                        <br />
                                        <asp:Label ID="lp8" runat="server" ForeColor="Red" CssClass="fuente" Width="320px"></asp:Label>
                                    </asp:Panel>
   <br />
                                    <asp:Panel ID="Panel18" runat="server" CssClass="PanelTexbox" Height="90px" Width="325px">
                                        <asp:Panel ID="Panel19" runat="server" CssClass="pantitu">
                                            <asp:Label ID="Label31" runat="server" CssClass="fuente" ForeColor="#333333" Text="Cambio de Animo"></asp:Label>
                                        </asp:Panel>
 <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label28" runat="server" Text="El paciente presenta " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                        <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label10" runat="server" Text="cambio de animo :" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlCambioAni" runat="server" Height="26px" Width="135px" CssClass="fuente" ForeColor="#333333">
                                            <asp:ListItem Value="0">Seleccionar...</asp:ListItem>
                                            <asp:ListItem Value="9">Muy frecuente</asp:ListItem>
                                            <asp:ListItem Value="11">Poco frecuente</asp:ListItem>
                                            <asp:ListItem Value="13">Regular frecuencia</asp:ListItem>
                                        </asp:DropDownList>
                                        <br />
                                        <asp:Label ID="lp11" runat="server" ForeColor="Red" CssClass="fuente" Width="320px"></asp:Label>
                                    </asp:Panel>
   <br />

                                    <asp:Panel ID="Panel20" runat="server" CssClass="PanelTexbox" Height="90px" Width="325px">
                                        <asp:Panel ID="Panel21" runat="server" CssClass="pantitu">
                                            <asp:Label ID="Label32" runat="server" CssClass="fuente" ForeColor="#333333" Text="Frustracion"></asp:Label>
                                        </asp:Panel>
 <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label35" runat="server" Text="El paciente  presenta" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                        <br />
                                        &nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text=" frustracion : " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlFrustracion" runat="server" Height="26px" Width="135px" CssClass="fuente" ForeColor="#333333">
                                            <asp:ListItem Value="0">Seleccionar...</asp:ListItem>
                                            <asp:ListItem Value="9">Muy frecuente</asp:ListItem>
                                            <asp:ListItem Value="11">Poco frecuente</asp:ListItem>
                                            <asp:ListItem Value="13">Regular frecuencia</asp:ListItem>
                                        </asp:DropDownList>
                                        <br />
                                        <asp:Label ID="lp14" runat="server" ForeColor="Red" CssClass="fuente" Width="320px"></asp:Label>
                                    </asp:Panel>

                                    <br />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
 </td>
<td style="text-align: left">



    <asp:Panel ID="Panel33" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4"></td>
                <td>
<asp:Panel ID="Panel22" runat="server" CssClass="PanelTexbox" Width="325px" Height="92px" >
<asp:Panel ID="Panel23" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label34" runat="server" Text="Ansiedad" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
 <br />
                                                            &nbsp;&nbsp;<asp:Label ID="Label33" runat="server" Text="El paciente presenta " CssClass="fuente" ForeColor="#333333"></asp:Label>
<br />
    &nbsp;&nbsp;<asp:Label ID="Label12" runat="server" Text=" ansiedad :" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlAnsiedad" runat="server" Height="26px" Width="135px" CssClass="fuente" ForeColor="#333333">
                                                                <asp:ListItem Value="0">Seleccionar...</asp:ListItem>
                                                                <asp:ListItem Value="9">Muy frecuente</asp:ListItem>
                                                                <asp:ListItem Value="11">Poco frecuente</asp:ListItem>
                                                                <asp:ListItem Value="13">Regular frecuencia</asp:ListItem>
                                                            </asp:DropDownList>
                                                             <br />

                                        <asp:Label ID="lp6" runat="server" ForeColor="Red" CssClass="fuente" Width="320px"></asp:Label>
</asp:Panel>
   <br />
<asp:Panel ID="Panel24" runat="server" CssClass="PanelTexbox" Width="325px" Height="92px" >
<asp:Panel ID="Panel25" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label36" runat="server" Text="Irritabilidad" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
 <br />
                                                                    &nbsp;&nbsp;<asp:Label ID="Label37" runat="server" Text="El paciente presenta" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                                    <br />
    &nbsp;&nbsp;<asp:Label ID="Label15" runat="server" Text=" irritabilidad :" CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlIrritabilidad" runat="server" Height="26px" Width="135px" CssClass="fuente" ForeColor="#333333">
                                                                        <asp:ListItem Value="0">Seleccionar...</asp:ListItem>
                                                                        <asp:ListItem Value="9">Muy frecuente</asp:ListItem>
                                                                        <asp:ListItem Value="11">Poco frecuente</asp:ListItem>
                                                                        <asp:ListItem Value="13">Regular frecuencia</asp:ListItem>
                                                                    </asp:DropDownList>
                                                                     <br />

                                        <asp:Label ID="lp9" runat="server" ForeColor="Red" CssClass="fuente" Width="320px"></asp:Label>
</asp:Panel>
   <br />
<asp:Panel ID="Panel26" runat="server" CssClass="PanelTexbox" Width="325px" Height="92px" >
<asp:Panel ID="Panel27" runat="server" CssClass="pantitu" >
 <asp:Label ID="Label38" runat="server" Text="Abandono Personal" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
 <br />
                                                                      &nbsp;&nbsp;<asp:Label ID="Label40" runat="server" Text="El paciente  presenta " CssClass="fuente" ForeColor="#333333"></asp:Label>
                                                                     <br />
    &nbsp;&nbsp;<asp:Label ID="Label17" runat="server" Text="abandono personal :" CssClass="fuente" ForeColor="#333333"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlAbandono" runat="server" Height="26px" Width="135px" CssClass="fuente" ForeColor="#333333">
                                                                            <asp:ListItem Value="0">Seleccionar...</asp:ListItem>
                                                                            <asp:ListItem Value="9">Muy frecuente</asp:ListItem>
                                                                            <asp:ListItem Value="11">Poco frecuente</asp:ListItem>
                                                                            <asp:ListItem Value="13">Regular frecuencia</asp:ListItem>
                                                                        </asp:DropDownList>
                                                                       <br />

                                        <asp:Label ID="lp12" runat="server" ForeColor="Red" CssClass="fuente" Width="320px"></asp:Label>
</asp:Panel>
                    <asp:Panel ID="Panel35" runat="server" Height="110px">
                    </asp:Panel>
                    <br />

                </td>
            </tr>
        </table>
    </asp:Panel>



</td>
        </tr>
    </table>


</asp:Panel>
                         
                        </asp:Panel>

                        <asp:Panel ID="PaResul" runat="server">
                  <asp:Panel ID="Panel29" runat="server" CssClass="PanelTexbox" Width="1086px" >
<asp:Panel ID="Panel30" runat="server" CssClass="pantitu" Height="35px" >
<br />
 <asp:Label ID="Label39" runat="server" Text="Conclusion de la prueba realizada" CssClass="fuente" ForeColor="#333333"></asp:Label>
</asp:Panel>
                    <br />        
                           <asp:Label ID="Label84" runat="server" Width="409px"></asp:Label>
                               <asp:Button ID="btnresulpsico" runat="server" Text="Resultado de la Prueba " OnClick="btnresulpsico_Click" Height="35px" Width="221px" BackColor="#D2D2D2" CssClass="btn" />
&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                        <asp:TextBox ID="txtrespsico" runat="server" Width="107px" Enabled="False" Visible="False" CssClass="PanelTexbox" Height="25px"></asp:TextBox>
<br />
                                    <asp:Label ID="Label45" runat="server" Text="Observaciones:" Visible="False" CssClass="fuente" ForeColor="#333333"></asp:Label>
 &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                                     <br />             

                                    <asp:TextBox ID="txtObservaciones" runat="server" Height="34px" TextMode="MultiLine" Width="960px" Visible="False" CssClass="PanelTexbox"></asp:TextBox>

</asp:Panel>
                        </asp:Panel>
<br />
                        <asp:Button ID="BtnGuardar" runat="server" Height="36px" Text="Guardar Datos" Width="243px" OnClick="BtnGuardar_Click" BackColor="#D2D2D2" CssClass="btn" Visible="False" />
                        
                    </asp:Panel>

    
    </div>
    </form>
</body>
</html>
