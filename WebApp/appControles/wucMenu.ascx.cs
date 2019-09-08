using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using Comunes;

namespace WebApp.appControles
{
    public partial class wucMenu : System.Web.UI.UserControl
    {
        Utilitario objUtilitario;
        Globales objGlobales;

        protected void Page_Load(object sender, EventArgs e)
        {
            objUtilitario = new Utilitario();
            objGlobales = Globales.Instance;

            setNombreUsuario(objGlobales.Usuario);
        }

        private void setNombreUsuario(DtoUsuario objU)
        {
            ltlNombreUsuario.Text = objUtilitario.obtenerPrimerNombre(objU.usuarioNombre) + " " + objU.usuarioApePaterno;
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            objGlobales.cerrarSesion("");
            Response.Redirect("~/Inicio.aspx");
        }

        protected void btnCalendario_Click1(object sender, EventArgs e)
        {
            DtoUsuario objDtoUsu = new DtoUsuario();
            string nombreUsuario = string.Empty;
            objDtoUsu = Globales.Instance.Usuario;
            nombreUsuario = objUtilitario.obtenerPrimerNombre(objDtoUsu.usuarioNombre) + "-" + objDtoUsu.usuarioApePaterno;
            Response.Redirect(objUtilitario.cadenaAmigable(nombreUsuario));
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            DtoUsuario objDtoUsu = new DtoUsuario();
            string nombreUsuario = string.Empty;
            objDtoUsu = Globales.Instance.Usuario;
            nombreUsuario = objUtilitario.obtenerPrimerNombre(objDtoUsu.usuarioNombre) + "-" + objDtoUsu.usuarioApePaterno;
            Response.Redirect(objUtilitario.cadenaAmigable(nombreUsuario));
        }
    }
}