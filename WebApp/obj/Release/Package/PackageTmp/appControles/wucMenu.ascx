<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucMenu.ascx.cs" Inherits="WebApp.appControles.wucMenu" %>
<div id="menuPrincipal">
    <div id="wrapMenu" style="height: 70px;">
        <div class="iconLogo">
           <%--<img class="logoSis" src="/utils/images/logoTransparente.png"/>--%>
        </div>
        <div class="opciones">
            <div class="mensajes">Mensajes</div>
            <div class="calendario">Calendario</div>
            <div id="userMenu">
                <div id="btnUser">
                    <div class="icon"></div>
                    <div class="userName">
                        <asp:Literal runat="server" ID="ltlNombreUsuario"></asp:Literal>
                    </div>
                </div>
                <div id="wrapOpcionesUser">
                    <div class="config"><a href="#">Configurar Cuenta</a></div>
                    <div class="cerrar">
                        <asp:LinkButton runat="server" ID="btnCerrarSesion" 
                            onclick="btnCerrarSesion_Click" Text="Salir" ClientIDMode="Static"></asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>