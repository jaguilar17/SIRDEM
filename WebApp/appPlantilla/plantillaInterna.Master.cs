using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using WebApp;
using Comunes;

namespace WebApp.appPlantilla
{
    public partial class plantillaInterna : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Globales objGlobales;
            objGlobales = Globales.Instance;
            if (objGlobales.Usuario == null)
            {
                Response.Redirect("~/Inicio.aspx");
            }
            else
            {
                Utilitario utilitario = new Utilitario();
                DtoUsuario objDtoUsuario = new DtoUsuario();
                objDtoUsuario = objGlobales.Usuario;
                ltlUsuarioNombre.Text = objGlobales.Usuario.usuarioNombre;
                
                iFVentana.Attributes["src"] = Page.RouteData.Values["nombreUsuario"] + "/bienvenida";
            }
        }
    }
}