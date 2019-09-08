using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class frmGraficaEctomorfiaxJugador : System.Web.UI.Page
    {
        public string codJugador
        {
            get { return Request.QueryString["codJugador"]; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { }
        }

        [WebMethod()]
        public static List<Usp_Grafica_EctomorgiaxJugador_Result> EctomorfiaxJugador()
        {
            //BDAKDv2Entities db = new BDAKDv2Entities();
            BD_AKD_4Entities db = new BD_AKD_4Entities();
            return db.Usp_Grafica_EctomorgiaxJugador().ToList();
        }
    }
}