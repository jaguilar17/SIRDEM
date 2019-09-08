using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class frm_GraficaMesomorfiaxJugador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack) { }
        }
        [WebMethod()]
        public static List<Usp_Grafica_MesomorfiaxJugador_Result> MesomorfiaxJugador()
        {
            //BDAKDv2Entities db = new BDAKDv2Entities();
            BD_AKD_4Entities db = new BD_AKD_4Entities();
            return db.Usp_Grafica_MesomorfiaxJugador().ToList();
        }
    }
}