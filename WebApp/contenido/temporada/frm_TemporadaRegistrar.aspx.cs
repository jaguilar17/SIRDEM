using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CTR;
using WebApp.HelpClasses;

namespace WebApp.contenido2.temporada
{
    public partial class frm_TemporadaRegistrar : System.Web.UI.Page
    {
        #region Atributos
        private List<DtoTemporada> _ldtoTemp = new List<DtoTemporada>();
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
                _ldtoTemp.Clear();
                DtoTemporada dto = new DtoTemporada();

                dto.IB_Mostrar = true;
                ClassResultV cr = new CTR.CtrTemporada().Usp_Temporada_GetAll(TipoCons.grid);
                if (!cr.HuboError)
                {
                    foreach (DtoB dtoB in cr.List)
                        _ldtoTemp.Add((DtoTemporada)dtoB);
                    gvTemporada.DataSource = _ldtoTemp;
                    gvTemporada.DataBind();
                }
                else
                {
                    gvTemporada.DataBind();
                }
            }
            catch { }
        }

        private void BuscarCargarGrilla()
        {
            try
            {
                _ldtoTemp = new List<DtoTemporada>();
                ClassResultV cr = new CTR.CtrTemporada().Usp_Temporada_GetAll(TipoCons.grid);
                if (!cr.HuboError)
                {
                    foreach (DtoTemporada dtoB in cr.List)
                        _ldtoTemp.Add(dtoB);
                    _ldtoTemp = _ldtoTemp.Where(x => x.temporadaNombre.ToLower().Trim().Contains(txtBuscar.Text.ToLower().Trim())).ToList();

                    gvTemporada.DataSource = _ldtoTemp;
                    gvTemporada.DataBind();

                }
                else gvTemporada.DataBind();
            }
            catch { }
        }
        private bool AddNewTemporada(GridView gv)
        {
            bool valido = false;
            try
            {
                DtoTemporada dto = new DtoTemporada();
                dto.temporadaNombre = HelpV.GetRowFooterTextBoxText(gv, "txtNombreTempoAdd");
                dto.temporadaFechaInicio = Convert.ToDateTime(HelpV.GetRowFooterTextBoxText(gv, "txtFechInicioAdd"));
                dto.temporadaDuracionDias = HelpV.GetRowFooterTextBoxTextInt(gv, "txtDuracionTempAdd");
                if (dto.temporadaDuracionDias > 91 && dto.temporadaDuracionDias<= 122)
                {
                    dto.IB_Mostrar = true;

                        ClassResultV cr = new CtrTemporada().Usp_Temporada_Insert(dto);
                        if (!cr.HuboError)
                        {
                            valido = true;
                        }
                }
                else { Response.Write("<script>alert('La duracion tiene que ser mayor a 91 dias y menor a 123 dias')</script>"); }

            }
            catch (Exception ex)
            {

            }
            return valido;
        }
        private bool UpdateTemporada(GridView gv)
        {
            var dto = new DtoTemporada();
            dto.codTemporada = HelpV.GetRowLabelText(gv, "lblCodTemporadaEdit").Trim();
            dto.temporadaNombre = HelpV.GetRowTextBoxText(gv, "txtNombreTempoEdit").Trim();
            dto.temporadaFechaInicio = Convert.ToDateTime(HelpV.GetRowTextBoxText(gv, "txtFechInicioEdit").Trim());
            dto.temporadaDuracionDias = Convert.ToInt32(HelpV.GetRowTextBoxText(gv, "txtDuracionTempEdit").Trim());

            dto.IB_Mostrar = HelpV.GetRowCheckBoxChecked(gv, "chkHabilitadoEdit");

            var ctr = new CtrTemporada();
            ClassResultV cr = ctr.Usp_Temporada_Update(dto);
            if (cr.HuboError)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Eventos
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCargarGrilla();
        }
        protected void gvTemporada_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
                ((Button)e.Row.FindControl("lnkAddItem")).Attributes.Clear();
                ((Button)e.Row.FindControl("lnkAddItem")).Attributes.Add("OnClick", "return ValidaNewTemporada('" + e.Row.FindControl("txtNombreTempoAdd").ClientID + "', '" + e.Row.FindControl("txtFechInicioAdd").ClientID + "', '" + e.Row.FindControl("txtDuracionTempAdd").ClientID + "');");

                ((TextBox)e.Row.FindControl("txtDuracionTempAdd")).Attributes.Add("OnKeyPress", "return NumeroInt(event);");
                ((TextBox)e.Row.FindControl("txtDuracionTempAdd")).Attributes.Add("OnBlur", "ValidateInts(this);");
            }
            else if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DtoTemporada dto = (DtoTemporada)e.Row.DataItem;
                if ((e.Row.RowState == DataControlRowState.Edit) || (e.Row.RowState == (DataControlRowState.Alternate | DataControlRowState.Edit)))
                {
                    //Cuando estoy en edición
                    ((LinkButton)e.Row.FindControl("lnkUpdate")).Attributes.Clear();
                    ((LinkButton)e.Row.FindControl("lnkUpdate")).Attributes.Add("OnClick", "return ValidaUpdateTemporada('" + e.Row.FindControl("txtNombreTempoEdit").ClientID + "', '" + e.Row.FindControl("txtFechInicioEdit").ClientID + "', '" + e.Row.FindControl("txtDuracionTempEdit").ClientID + "');");

                    ((TextBox)e.Row.FindControl("txtDuracionTempEdit")).Attributes.Add("OnKeyPress", "return NumeroInt(event);");
                    ((TextBox)e.Row.FindControl("txtDuracionTempEdit")).Attributes.Add("OnBlur", "ValidateInts(this);");
                }
                if (dto.codTemporada.Equals(String.Empty))
                {
                    ((LinkButton)e.Row.FindControl("lnkEdit")).Visible = false;
                    ((CheckBox)e.Row.FindControl("chkHabilitado")).Visible = false;
                    ((Label)e.Row.FindControl("lblDuracion")).Visible = false;
                    ((Label)e.Row.FindControl("lblFechInicio")).Visible = false;
                    //((Button)e.Row.FindControl("btnViewReader")).Visible = false;
                    ((Label)e.Row.FindControl("lblFechaFin")).Visible = false;
                }
            }

        }
        protected void gvTemporada_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            HelpV.RowCancelingEdit(sender, e);
            CargarGrilla();
        }
        protected void gvTemporada_RowEditing(object sender, GridViewEditEventArgs e)
        {
            HelpV.RowEditing(sender, e);
            CargarGrilla();
        }
        protected void gvTemporada_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var grid = (GridView)sender;
            string index = e.CommandArgument.ToString();
            //int index = Convert.ToInt32(e.CommandArgument);
            switch (e.CommandName)
            {
                case "AddItem":
                    if (AddNewTemporada(grid))
                        CargarGrilla();
                    //else
                    //Response.Write("<script>alert('Este torneo ya existe')</script>");
                    break;
                case "Update":
                    if (UpdateTemporada(grid))
                    {
                        gvTemporada.SetEditRow(-1);
                        CargarGrilla();
                    }
                    break;
                //case "View":
                //    if (index != "")
                //        CargarEquipos(grid, e);
                //    break;
            }
        }
        protected void gvTemporada_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }
        protected void gvTemporada_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTemporada.PageIndex = e.NewPageIndex;
            CargarGrilla();
        }
        #endregion
    }
}