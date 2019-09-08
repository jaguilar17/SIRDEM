using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.contenido2.antropometria
{
    public partial class frm_Antropometria : System.Web.UI.Page
    {
        #region Atributos
        public String codJugador
        {
            get { return Request.QueryString["codJugador"]; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Metodos
        #endregion

        #region Eventos
        #endregion
    }
}