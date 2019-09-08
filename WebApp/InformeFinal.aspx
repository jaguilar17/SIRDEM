<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InformeFinal.aspx.cs" Inherits="APPAKD.InformeFinal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .login {
            height: 406px;
            text-align: left;
            width: 470px;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 371px;
        }
        .auto-style5 {
            width: 357px;
        }
        .auto-style6 {
            text-align: center;
        }
         .fuente {
            font-family: 'Lato', sans-serif;
                font-size: medium;
            }
        
 .PanelTexbox {

border-radius: 3px;
border: 1px solid #CCC;
font-weight: 400;
font-size: small;
font-family: Verdana;
box-shadow: 1px 1px 5px #CCC;
  font-family: 'Lato', sans-serif;
            text-align: left;
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

    </style>
</head>
<body>
    <form id="form1" runat="server">
   <div class="container">
    <div>
                    <asp:Panel ID="totalD1" runat="server">
                    <asp:Panel ID="TD1" runat="server" Width="1100px">

                        
<asp:Panel ID="Panel4" runat="server" style="text-align: center" BackColor="Silver">
<asp:Label ID="Label21" runat="server" Text="Informe de Rendimiento  Final" style="font-size: x-large; font-weight: 700"></asp:Label>
<br />
</asp:Panel>
<asp:Panel ID="Panel1" runat="server" CssClass="PanelTexbox"  >
<asp:Panel ID="Panel2" runat="server" CssClass="pantitu" Height="20px" >
    <div class="auto-style6">
        <strong>
        <asp:Label ID="Titulo" runat="server" CssClass="auto-style5" Text="Datos Referentes a la Prueba"></asp:Label>
        </strong>
    </div>
</asp:Panel>
<asp:Label ID="Label37" runat="server" Text="Nombre y Apellido del Participate: "></asp:Label>
<br style="text-align: left" />
<asp:Label ID="n0" runat="server" ForeColor="#666666"></asp:Label>
<br />
<asp:Label ID="Label1" runat="server" Text="Cantidad de pruebas realizadas: "></asp:Label>
<br style="text-align: left" />
<asp:Label ID="Label2" runat="server" Text="3 prueba" ForeColor="#666666"></asp:Label>
<br />
<asp:Label ID="Label3" runat="server" Text="Tipo de prueba ingresada: "></asp:Label>
<br />
<asp:Label ID="Label4" runat="server" Text="Prueba de Desempeño, Prueba Fisica, Prueba Psicologica" ForeColor="#666666"></asp:Label>
<br />
</asp:Panel>
 <asp:Panel ID="Panel17" runat="server" CssClass="PanelTexbox">
<asp:Panel ID="Panel18" runat="server" CssClass="pantitu" Height="20px">
    <strong>
    <asp:Label ID="Label25" runat="server" CssClass="auto-style5" Text="Descripcion de la Prueba Ingresada"></asp:Label>
    </strong>
</asp:Panel>
                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style4">

<asp:Panel ID="Panel20" runat="server" CssClass="PanelTexbox">
<asp:Panel ID="Panel21" runat="server" CssClass="pantitu" BackColor="Silver" Height="20px">
    <asp:Label ID="Label43" runat="server" CssClass="auto-style3" Text=" Prueba de Desempeño"></asp:Label>
</asp:Panel>
 <asp:Panel ID="Panel5" runat="server" CssClass="PanelTexbox">
<asp:Panel ID="Panel22" runat="server" CssClass="pantitu">
    <asp:Label ID="Label5" runat="server" Text="Datos Generales" CssClass="auto-style3"></asp:Label>
</asp:Panel>
                                <asp:Label ID="Label7" runat="server" Text="Encargado de la Prueba : "></asp:Label>
                                <asp:Label ID="codPrueba" runat="server" Visible="False"></asp:Label>
                                <br />
                                <asp:Label ID="n1" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label9" runat="server" Text="Dia: "></asp:Label>
                                <asp:Label ID="n2" runat="server" ForeColor="#666666"></asp:Label>
                                    &nbsp
&nbsp
&nbsp
&nbsp
&nbsp
&nbsp
                                <asp:Label ID="Label11" runat="server" Text="Hora: "></asp:Label>
                                <asp:Label ID="n3" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label6" runat="server" Text="Lugar: "></asp:Label>
                                 <br />
                                <asp:Label ID="n4" runat="server" ForeColor="#666666"></asp:Label>
</asp:Panel>
<asp:Panel ID="Panel3" runat="server" CssClass="PanelTexbox" >
<asp:Panel ID="Panel19" runat="server" CssClass="pantitu" Height="18px" >
 <asp:Label ID="Label14" runat="server" Text="Datos Encontrados" ForeColor="#333333" ></asp:Label>
</asp:Panel>

                                <asp:Label ID="Label15" runat="server" Text="Pase Largo: "></asp:Label>
                                <br />
                                <asp:Label ID="n5" runat="server" ForeColor="#666666"></asp:Label>

<asp:Label ID="Label76" runat="server" ForeColor="#666666">punto(s)</asp:Label>
                                <br />
                                <asp:Label ID="Label17" runat="server" Text="Conduccion del Balon , en una linea recta: "></asp:Label>
                                <br />
                                <asp:Label ID="n6" runat="server" ForeColor="#666666"></asp:Label>
 
<asp:Label ID="Label77" runat="server" ForeColor="#666666">punto(s)</asp:Label>
                                <br />
                                <asp:Label ID="Label19" runat="server" Text="Conduccion del Balon , en zig-zag con cuatro obstaculos: "></asp:Label>
                                <br />
                                <asp:Label ID="n7" runat="server" ForeColor="#666666"></asp:Label>

<asp:Label ID="Label78" runat="server" ForeColor="#666666">punto(s)</asp:Label>
                                <br />
                                <asp:Label ID="Label22" runat="server" Text="Efectuar tiro a puerta desde fuera del área: "></asp:Label>
                                <br />
                                <asp:Label ID="n8" runat="server" ForeColor="#666666"></asp:Label>

<asp:Label ID="Label79" runat="server" ForeColor="#666666">punto(s)</asp:Label>
                                <br />
                                <asp:Label ID="Label24" runat="server" Text="Conducción elevada del balón hasta el vértice del área: "></asp:Label>
                                <br />
                                <asp:Label ID="n9" runat="server" ForeColor="#666666"></asp:Label>

<asp:Label ID="Label80" runat="server" ForeColor="#666666">punto(s)</asp:Label>
                                <br />
                                <asp:Label ID="Label26" runat="server" Text="Tiro de precisión situado sobre la linea base:  "></asp:Label>
                                <br />
                                <asp:Label ID="n10" runat="server" ForeColor="#666666"></asp:Label>

<asp:Label ID="Label81" runat="server" ForeColor="#666666">punto(s)</asp:Label>
                                <br />
                                <asp:Label ID="Label28" runat="server" Text="Control del balon en conjunto con un compañero:  "></asp:Label>
                                <br />
                                <asp:Label ID="n11" runat="server" ForeColor="#666666"></asp:Label>

<asp:Label ID="Label82" runat="server" ForeColor="#666666">punto(s)</asp:Label>
                                <br />
                                <asp:Label ID="Label30" runat="server" Text="Maniobrabilidad de balon en obstaculos con vallas: "></asp:Label>
                                <br />
                                <asp:Label ID="n12" runat="server" ForeColor="#666666"></asp:Label>

<asp:Label ID="Label83" runat="server" ForeColor="#666666">punto(s)</asp:Label>
                                <br />
                                <asp:Label ID="Label32" runat="server" Text="Lanzamiento a puerta desde fuera del área: "></asp:Label>
                                <br />
                                <asp:Label ID="n13" runat="server" ForeColor="#666666"></asp:Label>

<asp:Label ID="Label84" runat="server" ForeColor="#666666">punto(s)</asp:Label>
 

                                    <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
</asp:Panel>

                                                                           <asp:Panel ID="Panel15" runat="server" CssClass="PanelTexbox">
<asp:Panel ID="Panel16" runat="server" CssClass="pantitu">
    <asp:Label ID="Label27" runat="server" Text=" Conclucion de la prueba" CssClass="auto-style3"></asp:Label>
</asp:Panel>
                                                <asp:Label ID="Label13" runat="server" Text="Observaciones: "></asp:Label>
                                    <br />
                                    <asp:Label ID="n14" runat="server" ForeColor="#666666"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label35" runat="server" Text="Resultado: "></asp:Label>
                                    <asp:Label ID="n15" runat="server" ForeColor="#666666"></asp:Label>
</asp:Panel>

</asp:Panel>
                                </td>
                                        
                                <td class="auto-style5">

<asp:Panel ID="Panel7" runat="server" CssClass="PanelTexbox">
<asp:Panel ID="Panel29" runat="server" CssClass="pantitu" BackColor="Silver" Height="20px">
    <asp:Label ID="Label39" runat="server" CssClass="auto-style3" Text=" Prueba Fisica"></asp:Label>
</asp:Panel>

 <asp:Panel ID="Panel23" runat="server" CssClass="PanelTexbox">
<asp:Panel ID="Panel24" runat="server" CssClass="pantitu">
    <asp:Label ID="Label51" runat="server" Text="Datos Generales" CssClass="auto-style3"></asp:Label>
</asp:Panel>
                                <asp:Label ID="Label40" runat="server" Text="Encargado de la Prueba : "></asp:Label>
                                <asp:Label ID="codPrueba2" runat="server" Visible="False"></asp:Label>
                                <br />
                                <asp:Label ID="p1" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label42" runat="server" Text="Dia: "></asp:Label>
                                <asp:Label ID="p2" runat="server" ForeColor="#666666"></asp:Label>
                                                                        &nbsp
&nbsp
&nbsp
&nbsp
&nbsp
&nbsp
                                <asp:Label ID="Label44" runat="server" Text="Hora: "></asp:Label>
                                <asp:Label ID="p3" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label46" runat="server" Text="Lugar: "></asp:Label>
                                   <br />

                                       <asp:Label ID="p4" runat="server" ForeColor="#666666"></asp:Label>
</asp:Panel>
<asp:Panel ID="Panel8" runat="server" CssClass="PanelTexbox" >
<asp:Panel ID="Panel27" runat="server" CssClass="pantitu" Height="18px" >
 <asp:Label ID="Label47" runat="server" Text="Datos Encontrados" ForeColor="#333333" ></asp:Label>
</asp:Panel>
                                <asp:Label ID="Label48" runat="server" Text="Tiempo que demora en recorrer 50 metros:  "></asp:Label>
                                <br />
                                <asp:Label ID="p5" runat="server" ForeColor="#666666"></asp:Label>

<asp:Label ID="Label8" runat="server" ForeColor="#666666">segundos</asp:Label>
                                <br />
                                <asp:Label ID="Label50" runat="server" Text="Tiempo que demora en recorrer 2000 metros:"></asp:Label>
                                <br />
                                <asp:Label ID="p6" runat="server" ForeColor="#666666"></asp:Label>

<asp:Label ID="Label10" runat="server" ForeColor="#666666">segundos</asp:Label>
                                <br />
                                <asp:Label ID="Label52" runat="server" Text="Altura alcanzafa en un salto: "></asp:Label>
                                <br />
                                <asp:Label ID="p7" runat="server" ForeColor="#666666"></asp:Label>

<asp:Label ID="Label12" runat="server" ForeColor="#666666">centimetros</asp:Label>
                                <br />
                                <asp:Label ID="Label54" runat="server" Text="Distancia obtenida al lanzar un balon medicinal: "></asp:Label>
                                <br />
                                <asp:Label ID="p8" runat="server" ForeColor="#666666"></asp:Label>
 
<asp:Label ID="Label16" runat="server" ForeColor="#666666">metros</asp:Label>
                                <br />
                                <asp:Label ID="Label56" runat="server" Text="Velocidad obtenida en una distancia de 500 m: "></asp:Label>
                                <br />
                                <asp:Label ID="p9" runat="server" ForeColor="#666666"></asp:Label>
 
<asp:Label ID="Label18" runat="server" ForeColor="#666666">m/s</asp:Label>
                                <br />
                                <asp:Label ID="Label58" runat="server" Text="Cantidad de flexiones relizadas dentro de un minuto: "></asp:Label>
                                <br />
                                <asp:Label ID="p10" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label60" runat="server" Text="Cantidad de repeticiones &quot;v&quot; realizadas en 15 segundos:"></asp:Label>
                                <br />
                                <asp:Label ID="p11" runat="server"></asp:Label>
                                <asp:Label ID="Label62" runat="server" Text="Cantidad de repeticiones &quot;v&quot; realizadas en 1 minuto: "></asp:Label>
                                <br />
                                <asp:Label ID="p12" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label64" runat="server" Text="Cantidad de saltos realizados en 1 minuto:"></asp:Label>
                                <br />
                                <asp:Label ID="p13" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label70" runat="server">Aceleracion de un desplazamiento global en una distancia de 20 metros (salida parada de pie): </asp:Label>
                                <br />
                                <asp:Label ID="p14" runat="server" ForeColor="#666666"></asp:Label>

<asp:Label ID="Label29" runat="server" ForeColor="#666666">m/s^2 </asp:Label>
                                <br />
                                <asp:Label ID="Label72" runat="server">Aceleracion de un desplazamiento global en una distancia de 30 metros (salida lanzada): </asp:Label>
                                   <br />
                                <asp:Label ID="p15" runat="server" ForeColor="#666666">0</asp:Label>

<asp:Label ID="Label31" runat="server" ForeColor="#666666">m/s^2 </asp:Label>

</asp:Panel>
</asp:Panel>
                                                                          <asp:Panel ID="Panel11" runat="server" CssClass="PanelTexbox">
<asp:Panel ID="Panel12" runat="server" CssClass="pantitu">
    <asp:Label ID="Label34" runat="server" Text=" Conclucion de la prueba" CssClass="auto-style3"></asp:Label>
</asp:Panel>
                                    <asp:Label ID="Label66" runat="server" Text="Observaciones: "></asp:Label>
                        <br />
                        <asp:Label ID="p16" runat="server" ForeColor="#666666"></asp:Label>
                        <br />
                        <asp:Label ID="Label68" runat="server" Text="Resultado: "></asp:Label>
                        <asp:Label ID="p17" runat="server" ForeColor="#666666"></asp:Label>
</asp:Panel>


                                </td>
                                <td><asp:Panel ID="Panel9" runat="server" CssClass="PanelTexbox">
<asp:Panel ID="Panel30" runat="server" CssClass="pantitu" BackColor="Silver" Height="20px">
    <asp:Label ID="Label20" runat="server" CssClass="auto-style3" Text=" Prueba Psicologica"></asp:Label>
</asp:Panel>

<asp:Panel ID="Panel25" runat="server" CssClass="PanelTexbox">
<asp:Panel ID="Panel26" runat="server" CssClass="pantitu">
    <asp:Label ID="Label53" runat="server" Text="Datos Generales" CssClass="auto-style3"></asp:Label>
</asp:Panel>
                                <asp:Label ID="Label23" runat="server" Text="Encargado de la Prueba : "></asp:Label>
                                <asp:Label ID="codPrueba3" runat="server" Visible="False"></asp:Label>
                                <br />
                                <asp:Label ID="s1" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label33" runat="server" Text="Dia: "></asp:Label>
                                <asp:Label ID="s2" runat="server" ForeColor="#666666"></asp:Label>
                                    &nbsp
&nbsp
&nbsp
&nbsp
&nbsp
&nbsp
                                <asp:Label ID="Label36" runat="server" Text="Hora: "></asp:Label>
                                <asp:Label ID="s3" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label41" runat="server" Text="Lugar: "></asp:Label>
                                   <br />
                                       <asp:Label ID="s4" runat="server" ForeColor="#666666"></asp:Label>
</asp:Panel>
<asp:Panel ID="Panel10" runat="server" CssClass="PanelTexbox" >
<asp:Panel ID="Panel28" runat="server" CssClass="pantitu" Height="18px" >
 <asp:Label ID="Label45" runat="server" Text="Datos Encontrados" ForeColor="#333333" ></asp:Label>
</asp:Panel>
                                <asp:Label ID="Label49" runat="server" Text="El paciente se siente motiva al realizar actividades fiscas : "></asp:Label>
                                <br />
                                <asp:Label ID="s5" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label55" runat="server" Text="El paciente presenta buen trabajo en Equipo : "></asp:Label>
                                <br />
                                <asp:Label ID="s6" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label61" runat="server" Text="El paciente tiene dificultades en la percepcion de problemas comunes:"></asp:Label>
                                <br />
                                <asp:Label ID="s7" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label67" runat="server" Text="El paciente da una respuesta positiva ante los problemas : "></asp:Label>
                                <br />
                                <asp:Label ID="s8" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label73" runat="server" Text="El paciente presenta bloqueo mental :"></asp:Label>
                                <br />
                                <asp:Label ID="s9" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label85" runat="server" Text="El paciente presenta cambio de animo :"></asp:Label>
                                <br />
                                <asp:Label ID="s10" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label87" runat="server" Text="El paciente presenta perdida de concentracion : "></asp:Label>
                                <br />
                                <asp:Label ID="s11" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label89" runat="server" Text="El paciente presenta ansiedad : "></asp:Label>
                                <br />
                                <asp:Label ID="s12" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label91" runat="server" Text="El paciente presenta frustracion : "></asp:Label>
                                <br />
                                <asp:Label ID="s13" runat="server" ForeColor="#666666"></asp:Label>
                                <br />
                                <asp:Label ID="Label93" runat="server">El paciente presenta irritabilidad : </asp:Label>
                                <br />
                                <asp:Label ID="s14" runat="server" ForeColor="#666666"></asp:Label>
                                    <br />
                                <asp:Label ID="Label96" runat="server">El paciente presenta abandono personal : </asp:Label>
                                   <br />
                                <asp:Label ID="s15" runat="server" ForeColor="#666666">0</asp:Label>
                                            <br />
</asp:Panel>
</asp:Panel>

                                                                          <asp:Panel ID="Panel13" runat="server" CssClass="PanelTexbox">
<asp:Panel ID="Panel14" runat="server" CssClass="pantitu">
    <asp:Label ID="Label38" runat="server" Text=" Conclucion de la prueba" CssClass="auto-style3"></asp:Label>
</asp:Panel>
                                    <asp:Label ID="Label99" runat="server" Text="Observaciones: "></asp:Label>
                        <br />
                        <asp:Label ID="s16" runat="server" ForeColor="#666666"></asp:Label>
                        <br />
                        <asp:Label ID="Label101" runat="server" Text="Resultado: "></asp:Label>
                        <asp:Label ID="s17" runat="server" ForeColor="#666666"></asp:Label>

</asp:Panel>
                                </td>



                            </tr>
                        </table>

                        
</asp:Panel>
                    </asp:Panel>
<br />
                                </asp:Panel>
               
    
    </div>
 </div>
    </form>
</body>
</html>
