using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CTR;
using WebApp.HelpClasses;

namespace WebApp.contenido2.equipo
{
    public partial class frm_VerPlantilla : System.Web.UI.Page
    {
        #region Variables
        private List<DtoPlantilla> _ldtoPlant = new List<DtoPlantilla>();
        public String codEquipo
        {
            get { return Request.QueryString["codEquipo"]; }
        }
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
                _ldtoPlant = new List<DtoPlantilla>();
                DtoPlantilla dto = new DtoPlantilla();
                dto.codEquipo = Request.QueryString["codEquipo"];
                //dto.IB_Mostrar = true;
                ClassResultV cr = new CTR.CtrPlantilla().Usp_PlantillaxEquipo_GetAll(dto);
                if (!cr.HuboError)
                {
                    foreach (DtoB dtoB in cr.List)
                        _ldtoPlant.Add((DtoPlantilla)dtoB);
                    gvPlantillaxEquipo.DataSource = _ldtoPlant;
                    gvPlantillaxEquipo.DataBind();

                    gvConvocables.DataSource = _ldtoPlant;
                    gvConvocables.DataBind();
                }
            }
            catch { }
        }
        private void BuscarCargarGrilla()
        {
            try
            {
                _ldtoPlant = new List<DtoPlantilla>();
                DtoPlantilla dto = new DtoPlantilla();
                dto.codEquipo = Request.QueryString["codEquipo"];
                ClassResultV cr = new CTR.CtrPlantilla().Usp_PlantillaxEquipo_GetAll(dto);
                if (!cr.HuboError)
                {
                    foreach (DtoPlantilla dtoB in cr.List)
                        _ldtoPlant.Add(dtoB);
                    _ldtoPlant = _ldtoPlant.Where(x => (x.nombreCompleto.ToLower().Trim()).Trim().Contains(txtBuscar.Text.ToLower().Trim())).ToList();

                    gvPlantillaxEquipo.DataSource = _ldtoPlant;
                    gvPlantillaxEquipo.DataBind();

                }
                else gvPlantillaxEquipo.DataBind();
            }
            catch { }
        }
        #endregion

        #region Eventos
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCargarGrilla();
        }
        protected void gvPlantillaxEquipo_RowDataBound(object sender, GridViewRowEventArgs e)
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
        protected void gvPlantillaxEquipo_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            HelpV.RowCancelingEdit(sender, e);
            CargarGrilla();
        }
        protected void gvPlantillaxEquipo_RowEditing(object sender, GridViewEditEventArgs e)
        {
            HelpV.RowEditing(sender, e);
            CargarGrilla();
        }
        protected void gvPlantillaxEquipo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var grid = (GridView)sender;
            string index = e.CommandArgument.ToString();
            //int index = Convert.ToInt32(e.CommandArgument);
        }
        protected void gvPlantillaxEquipo_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }
        protected void gvPlantillaxEquipo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPlantillaxEquipo.PageIndex = e.NewPageIndex;
            CargarGrilla();
        }
        #endregion


    }
}