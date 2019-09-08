<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucIframe.ascx.cs" Inherits="WebApp.appControles.wucIframe" %>
    
 <link href="<%= ResolveClientUrl("~/utils/css/reset.css") %>" rel="stylesheet" type="text/css" />
 <link href="<%= ResolveClientUrl("~/utils/js/jquery/bootstrap/css/bootstrap.min.css") %>" rel="stylesheet" type="text/css" />
 <link href="<%= ResolveClientUrl("~/utils/js/jquery/jQueryUI/css/jquery-ui-1.9.1.custom.min.css") %>" rel="stylesheet" type="text/css" />

 <script src="<%= ResolveClientUrl("~/utils/js/jsIframe.js") %>" type="text/javascript"></script>
 <script src="<%= ResolveClientUrl("~/utils/js/jquery/bootstrap/js/bootstrap.min.js") %>" type="text/javascript"></script>
 <script src="<%= ResolveClientUrl("~/utils/js/jquery/jquery-1.3.2.min.js") %>" type="text/javascript"></script>
 <script src="<%= ResolveClientUrl("~/Calendario/js/jquery/jQuery1.8.1.js") %>" type="text/javascript"></script>
 <script src="<%= ResolveClientUrl("~/utils/js/jquery/jQueryUI/js/jquery-ui-1.9.1.custom.min.js") %>" type="text/javascript"></script>

    <style type="text/css">
        html{max-width:1109px;height:1000px}
        #wrapperUsuario{width:800px;margin:0 auto;font-family:Calibri;}
        #wrapIframe{max-width:1109px;height:1000px !important;}
        #loading_layer{background-color:#fafafa;width:100%;padding-top:7%;position:absolute;}
        #loading_layer .wrapper{width:1100px;height:1000px;margin-left:40%;border:1px solid #ccc;font-style:italic;background-color:White;padding:10px;border-radius:4px;box-shadow:0px 0px 20px #ccc;}
        #loading_layer .titulo{font-size:19px;font-family:Calibri;}
        #loading_layer img{width:64px;margin:0 auto;margin-left:7px;}
    </style>