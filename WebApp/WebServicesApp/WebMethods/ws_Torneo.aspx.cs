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
    public partial class ws_Torneo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //[WebMethod]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        //public static String CargarTorneos(String codCategoria)
        //{
        //    String resultlJson = string.Empty;
        //    try
        //    {
        //        var _ldtoTor = new List<DtoTorneo>();
        //        DtoTorneo dto = new DtoTorneo();
        //        dto.codCategoria = codCategoria;
        //        ClassResultV cr = new CtrTorneo().Usp_TorneoxCategoria_GetAll(TipoCons.cbx, dto);

        //        if (!cr.HuboError)
        //        {
        //            _ldtoTor.AddRange(cr.List.Cast<DtoTorneo>());
        //            JavaScriptSerializer js = new JavaScriptSerializer();
        //            resultlJson = js.Serialize(_ldtoTor);
        //        }
        //    }
        //    catch (Exception ex) { }

        //    return resultlJson;
        //}
    }
}