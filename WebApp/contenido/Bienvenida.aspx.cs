using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.contenido
{
    public partial class Bienvenida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerListado_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/contenido/equipo/frm_VerPlantilla.aspx?codEquipo=0006");
        }
    }
}