using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using System.Web.Services;
using DTO;
using CTR;

namespace WebApp.WebServicesApp.WebMethods
{
    public partial class ws_Equipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static String CargarEquipos(String codTemporada)
        {
            String resultlJson = string.Empty;
            try
            {
                var _ldtoEquipo = new List<DtoEquipo>();
                DtoEquipo dto = new DtoEquipo();
                dto.codTemporada = codTemporada;
                ClassResultV cr = new CtrEquipo().Usp_GetEquipoByCodTemporada(TipoCons.cbx, dto);

                if (!cr.HuboError)
                {
                    _ldtoEquipo.AddRange(cr.List.Cast<DtoEquipo>());
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    resultlJson = js.Serialize(_ldtoEquipo);
                }
            }
            catch (Exception ex) { }

            return resultlJson;
        }
    }
}