using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
//using Microsoft.Reporting.WebForms;

namespace WebApp.contenido.reportes
{
    public partial class WebFormReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack) 
            //{
            //    BD_AKD_4DataSet.Usp_ResultadosAntropometricosxJugador_GetAllDataTable dt = new BD_AKD_4DataSet.Usp_ResultadosAntropometricosxJugador_GetAllDataTable();
            //    BD_AKD_4DataSetTableAdapters.Usp_ResultadosAntropometricosxJugador_GetAllTableAdapter da = new BD_AKD_4DataSetTableAdapters.Usp_ResultadosAntropometricosxJugador_GetAllTableAdapter();

            //    da.Fill(dt, "201606001");
            //    ReportDataSource RD = new ReportDataSource();
            //    RD.Value = dt;
            //    RD.Name = "DataSet1";

            //    ReportViewer1.LocalReport.DataSources.Clear();
            //    ReportViewer1.LocalReport.DataSources.Add(RD);
            //    ReportViewer1.LocalReport.ReportEmbeddedResource = Server.MapPath("~/contenido/reportes/Report1.rdlc");
            //    ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"~/contenido/reportes/Report1.rdlc"); 
            //    ReportViewer1.LocalReport.Refresh();
            //}
        }
    }
}