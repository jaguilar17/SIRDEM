using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CTR;
using WebApp.HelpClasses;

namespace WebApp.contenido2.antropometria
{
    public partial class frm_VerTodosJugadores : System.Web.UI.Page
    {
        #region Atributos
        private List<DtoPlantilla> _ldtoPlant = new List<DtoPlantilla>();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrilla();
            }
        }

        #region Metodos
        private void CargarGrilla()
        {
            try
            {
                _ldtoPlant.Clear();
                ClassResultV cr = new CTR.CtrPlantilla().Usp_TotalJugadores_GetAll();
                if (!cr.HuboError)
                {
                    _ldtoPlant.AddRange(cr.List.Cast<DtoPlantilla>().ToList());
                    gvJugadoresAll.DataSource = _ldtoPlant;
                    gvJugadoresAll.DataBind();
                }
                else
                {
                    gvJugadoresAll.DataBind();
                }
                if (gvJugadoresAll.Rows.Count > 0) gvJugadoresAll.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            catch { }
        }
        private void CargarDatosAntropometricos(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                string codJugador = e.CommandArgument.ToString();
                //Response.Redirect("Pages/frm_Actividad.aspx?id="+codProc);
                Response.Redirect("~/contenido/antropometria/frm_AntropometriaRegistro.aspx?codJugador=" + codJugador);
            }
            catch
            { }
        }
        private void CargarUltimosResultados(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                string codJugador = e.CommandArgument.ToString();
                //Response.Redirect("Pages/frm_Actividad.aspx?id="+codProc);
                Response.Redirect("~/contenido/antropometria/frm_ResultadosAntropometria.aspx?codJugador=" + codJugador);
            }
            catch
            { }
        }
        private void CargarControlesResultados(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                string codJugador = e.CommandArgument.ToString();
                //Response.Redirect("Pages/frm_Actividad.aspx?id="+codProc);
                Response.Redirect("~/contenido/antropometria/frm_VerResultadosControles.aspx?codJugador=" + codJugador);
            }
            catch
            { }
        }
        #endregion

        #region Eventos
        protected void gvJugadoresAll_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
            }
            else if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DtoPlantilla dto = (DtoPlantilla)e.Row.DataItem;
                if ((e.Row.RowState == DataControlRowState.Edit) || (e.Row.RowState == (DataControlRowState.Alternate | DataControlRowState.Edit)))
                {
                    //Cuando estoy en edición
                }
                else
                {
                    if (dto.codEquipo.Equals(0))
                    {
                        ((Label)e.Row.FindControl("lblCodPlantillaAdd")).Visible = false;
                    }
                }
            }
        }
        protected void gvJugadoresAll_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            HelpV.RowCancelingEdit(sender, e);
            CargarGrilla();
        }
        protected void gvJugadoresAll_RowEditing(object sender, GridViewEditEventArgs e)
        {
            HelpV.RowEditing(sender, e);
            CargarGrilla();
        }
        protected void gvJugadoresAll_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var grid = (GridView)sender;
            string index = e.CommandArgument.ToString();
            switch (e.CommandName)
            {
                case "View":
                    if (index != "")
                        CargarDatosAntropometricos(grid, e);
                    break;
                case "View2":
                    if (index != "")
                        CargarUltimosResultados(grid, e);
                    break;
                case "View3":
                    if (index != "")
                        CargarControlesResultados(grid, e);
                    break;
            }
        }
        protected void gvJugadoresAll_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }
        protected void gvJugadoresAll_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvJugadoresAll.PageIndex = e.NewPageIndex;
            CargarGrilla();
        }
        #endregion
    }
}