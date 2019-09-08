using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CTR;
using WebApp.HelpClasses;


namespace WebApp.contenido.antropometria
{
    public partial class frm_VerResultadosControles : System.Web.UI.Page
    {
        #region Atributos
        private List<DtoJugador> _ldtoJug = new List<DtoJugador>();
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
                _ldtoJug.Clear();
                DtoJugador dto = new DtoJugador();
                dto.codJugador = Request.QueryString["codJugador"];
                //dto.IB_Mostrar = true;
                ClassResultV cr = new CTR.CtrJugador().Usp_ResultadosAntropometricosxJugador_GetAll(dto);
                if (!cr.HuboError)
                {
                    _ldtoJug.AddRange(cr.List.Cast<DtoJugador>().ToList());
                    gvControlAll.DataSource = _ldtoJug;
                    gvControlAll.DataBind();
                }
                else
                {
                    gvControlAll.DataBind();
                }
                if (gvControlAll.Rows.Count > 0) gvControlAll.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            catch { }
        }
        #endregion

        #region Eventos
        protected void gvControlAll_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
            }
            else if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DtoJugador dto = (DtoJugador)e.Row.DataItem;
                if ((e.Row.RowState == DataControlRowState.Edit) || (e.Row.RowState == (DataControlRowState.Alternate | DataControlRowState.Edit)))
                {
                    //Cuando estoy en edición
                }
                else
                {
                    if (dto.codEquipo.Equals(0))
                    {
                        //((Label)e.Row.FindControl("lblCodPlantillaAdd")).Visible = false;
                    }
                }
            }
        }
        protected void gvControlAll_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            HelpV.RowCancelingEdit(sender, e);
            CargarGrilla();
        }
        protected void gvControlAll_RowEditing(object sender, GridViewEditEventArgs e)
        {
            HelpV.RowEditing(sender, e);
            CargarGrilla();
        }
        protected void gvControlAll_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var grid = (GridView)sender;
            string index = e.CommandArgument.ToString();
        }
        protected void gvControlAll_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }
        protected void gvControlAll_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvControlAll.PageIndex = e.NewPageIndex;
            CargarGrilla();
        }
        #endregion
    }
}