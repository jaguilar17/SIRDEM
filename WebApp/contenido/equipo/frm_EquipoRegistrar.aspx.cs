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
    public partial class frm_EquipoRegistrar : System.Web.UI.Page
    {
        #region Atributos
        private List<DtoEquipo> _ldtoEq = new List<DtoEquipo>();
        private List<DtoUsuario> _ldtoUsuario = new List<DtoUsuario>();
        private List<DtoPerfil> _ldtoPerfil = new List<DtoPerfil>();
        private List<DtoTemporada> _ldtoTemporada = new List<DtoTemporada>();
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
                _ldtoEq.Clear();
                DtoEquipo dto = new DtoEquipo();

                ClassResultV cr = new CTR.CtrEquipo().Usp_Equipo_GetAll(TipoCons.grid);
                if (!cr.HuboError)
                {
                    foreach (DtoB dtoB in cr.List)
                        _ldtoEq.Add((DtoEquipo)dtoB);
                    gvEquipo.DataSource = _ldtoEq;
                    gvEquipo.DataBind();
                }
                else
                {
                    gvEquipo.DataBind();
                }
            }
            catch { }
        }
        private void BuscarCargarGrilla()
        {
            try
            {
                _ldtoEq = new List<DtoEquipo>();
                ClassResultV cr = new CTR.CtrEquipo().Usp_Equipo_GetAll(TipoCons.grid);
                if (!cr.HuboError)
                {
                    foreach (DtoEquipo dtoB in cr.List)
                        _ldtoEq.Add(dtoB);
                    _ldtoEq = _ldtoEq.Where(x => x.equipoNombre.ToLower().Trim().Contains(txtBuscar.Text.ToLower().Trim())).ToList();

                    gvEquipo.DataSource = _ldtoEq;
                    gvEquipo.DataBind();

                }
                else gvEquipo.DataBind();
            }
            catch { }
        }
        private bool AddNewEquipo(GridView gv)
        {
            bool valido = false;

            try
            {
                DtoEquipo dto = new DtoEquipo();
                dto.equipoNombre = HelpV.GetRowFooterTextBoxText(gv, "txtNombreEquipoAdd");
                dto.equipoDescripcion = HelpV.GetRowFooterTextBoxText(gv, "txtDesEquipoAdd");
                dto.equipoDirectorTecnico = HelpV.GetRowFooterDdlText(gv, "ddlDTEquipoAdd");
                dto.equipoAsistenteTecnico = HelpV.GetRowFooterDdlText(gv, "ddlATEquipoAdd");
                dto.numMaxJugador = HelpV.GetRowFooterTextBoxTextInt(gv, "txtNumMaxJugAdd");
                dto.IB_Mostrar = true;
                dto.codTemporada = HelpV.GetRowFooterDdlValue(gv, "ddlTemporadaAdd");
                if (dto.numMaxJugador >= 16 && dto.numMaxJugador <= 20)
                {
                    ClassResultV cr = new CtrEquipo().Usp_Equipo_Insert(dto);
                    if (!cr.HuboError)
                    {
                        valido = true;
                        Response.Write("<script>alert('Equipo Registrado Correctamente')</script>");
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(UpdatePanel1, UpdatePanel1.GetType(), "script", "alert('1111');", true);
                    }
                }
                else { Response.Write("<script>alert('El N°de Jugadores debe ser mayor a 16 y menor a 20')</script>"); }
            }
            catch (Exception ex)
            {

            }
            return valido;
        }
        private bool UpdateEquipo(GridView gv)
        {
            var dto = new DtoEquipo();
            dto.codEquipo = HelpV.GetRowLabelText(gv, "lblCodEquipoEdit").Trim();
            dto.equipoNombre = HelpV.GetRowTextBoxText(gv, "txtNombreEquipoEdit").Trim();
            dto.equipoDescripcion = HelpV.GetRowTextBoxText(gv, "txtDesEquipoEdit").Trim();
            dto.equipoDirectorTecnico = HelpV.GetRowDdlValueText(gv, "ddlDTEquipoEdit").Trim();
            dto.equipoAsistenteTecnico = HelpV.GetRowDdlValueText(gv, "ddlATEquipoEdit").Trim();
            dto.numMaxJugador = Convert.ToInt32(HelpV.GetRowTextBoxText(gv, "txtNumMaxJugEdit"));
            dto.IB_Mostrar = HelpV.GetRowCheckBoxChecked(gv, "chkHabilitadoEdit");
            dto.codTemporada = HelpV.GetRowDdlValue(gv, "ddlTemporadaEdit").Trim();
            
            var ctr = new CtrEquipo();
            ClassResultV cr = ctr.Usp_Equipo_Update(dto);
            if (cr.HuboError)
            {
                return false;
            }
            return true;
        }
        private void ConsultarDT(DropDownList ddlDirectorTecnico)
        {
            try
            {
                _ldtoUsuario = new List<DtoUsuario>(); ///Objeto Salida
                ClassResultV cr = new CtrUsuario().Usp_PersonaDirectorTecnico_GetAll(TipoCons.cbx);
                if (!cr.HuboError)
                {
                    _ldtoUsuario.AddRange(cr.List.Cast<DtoUsuario>());
                    _ldtoUsuario.Insert(0, new DtoUsuario() { codUsuario = "0", personaDatos = "Seleccionar un director tecnico" });

                    ddlDirectorTecnico.DataSource = _ldtoUsuario;
                    ddlDirectorTecnico.DataValueField = "codUsuario";
                    ddlDirectorTecnico.DataTextField = "personaDatos";
                    ddlDirectorTecnico.DataBind();
                }
            }
            catch { }
        }
        private void ConsultarAT(DropDownList ddlAsistenteTecnico)
        {
            try
            {
                _ldtoUsuario = new List<DtoUsuario>(); ///Objeto Salida
                ClassResultV cr = new CtrUsuario().Usp_PersonaAsistenteTecnico_GetAll(TipoCons.cbx);
                if (!cr.HuboError)
                {
                    _ldtoUsuario.AddRange(cr.List.Cast<DtoUsuario>());
                    _ldtoUsuario.Insert(0, new DtoUsuario() { codUsuario = "0", personaDatos = "Seleccionar un asistente tecnico" });

                    ddlAsistenteTecnico.DataSource = _ldtoUsuario;
                    ddlAsistenteTecnico.DataValueField = "codUsuario";
                    ddlAsistenteTecnico.DataTextField = "personaDatos";
                    ddlAsistenteTecnico.DataBind();
                }
            }
            catch { }
        }
        private void ConsultarTemporada(DropDownList ddlTemporada)
        {
            try
            {
                _ldtoTemporada = new List<DtoTemporada>(); ///Objeto Salida
                ClassResultV cr = new CtrTemporada().Usp_TemporadaNombres_GetAll(TipoCons.cbx);
                if (!cr.HuboError)
                {
                    _ldtoTemporada.AddRange(cr.List.Cast<DtoTemporada>());
                    _ldtoTemporada.Insert(0, new DtoTemporada() { codTemporada = "0", temporadaNombre = "Seleccionar una temporada" });

                    ddlTemporada.DataSource = _ldtoTemporada;
                    ddlTemporada.DataValueField = "codTemporada";
                    ddlTemporada.DataTextField = "temporadaNombre";
                    ddlTemporada.DataBind();
                }
            }
            catch { }
        }
        private void CargarEquipos(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                string codEquipo = e.CommandArgument.ToString();
                //Response.Redirect("Pages/frm_Actividad.aspx?id="+codProc);
                Response.Redirect("~/contenido/equipo/frm_VerPlantilla.aspx?codEquipo=" + codEquipo);
            }
            catch
            { }
        }
        #endregion

        #region Eventos
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCargarGrilla();
        }
        protected void gvEquipo_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
                ConsultarDT(((DropDownList)e.Row.FindControl("ddlDTEquipoAdd")));
                ConsultarAT(((DropDownList)e.Row.FindControl("ddlATEquipoAdd")));
                ConsultarTemporada(((DropDownList)e.Row.FindControl("ddlTemporadaAdd")));
                ((Button)e.Row.FindControl("lnkAddItem")).Attributes.Clear();
                ((Button)e.Row.FindControl("lnkAddItem")).Attributes.Add("OnClick", "return ValidaAddEquipo('" + e.Row.FindControl("txtNombreEquipoAdd").ClientID + "', '" + e.Row.FindControl("txtDesEquipoAdd").ClientID + "', '" + e.Row.FindControl("ddlDTEquipoAdd").ClientID + "','" + e.Row.FindControl("ddlATEquipoAdd").ClientID + "','" + e.Row.FindControl("txtNumMaxJugAdd").ClientID + "','" + e.Row.FindControl("ddlTemporadaAdd").ClientID + "');");
                ((TextBox)e.Row.FindControl("txtNumMaxJugAdd")).Attributes.Add("OnKeyPress", "return NumeroInt(event);");
                ((TextBox)e.Row.FindControl("txtNumMaxJugAdd")).Attributes.Add("OnBlur", "ValidateInts(this);");
            }
            else if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DtoEquipo dto = (DtoEquipo)e.Row.DataItem;
                if ((e.Row.RowState == DataControlRowState.Edit) || (e.Row.RowState == (DataControlRowState.Alternate | DataControlRowState.Edit)))
                {
                    //Cuando estoy en edición
                    ConsultarDT(((DropDownList)e.Row.FindControl("ddlDTEquipoEdit")));
                    ConsultarAT(((DropDownList)e.Row.FindControl("ddlATEquipoEdit")));
                    ConsultarTemporada(((DropDownList)e.Row.FindControl("ddlTemporadaEdit")));
                    ((LinkButton)e.Row.FindControl("lnkUpdate")).Attributes.Clear();
                    ((LinkButton)e.Row.FindControl("lnkUpdate")).Attributes.Add("OnClick", "return ValidaUpdateEquipo('" + e.Row.FindControl("txtNombreEquipoEdit").ClientID + "', '" + e.Row.FindControl("txtDesEquipoEdit").ClientID + "', '" + e.Row.FindControl("ddlDTEquipoEdit").ClientID + "','" + e.Row.FindControl("ddlATEquipoEdit").ClientID + "','" + e.Row.FindControl("txtNumMaxJugEdit").ClientID + "','" + e.Row.FindControl("ddlTemporadaEdit").ClientID + "');");
                    ((TextBox)e.Row.FindControl("txtNumMaxJugEdit")).Attributes.Add("OnKeyPress", "return NumeroInt(event);");
                    ((TextBox)e.Row.FindControl("txtNumMaxJugEdit")).Attributes.Add("OnBlur", "ValidateInts(this);");
                }
                if (dto.codEquipo.Equals(String.Empty))
                {
                    ((Label)e.Row.FindControl("lblNumMaxJug")).Visible = false;
                    ((LinkButton)e.Row.FindControl("lnkEdit")).Visible = false;
                    ((CheckBox)e.Row.FindControl("chkHabilitado")).Visible = false;
                }
                if (dto.IB_Mostrar.Equals(false)) 
                {
                    ((LinkButton)e.Row.FindControl("lnkEdit")).Visible = false;
                }
            }
        }
        protected void gvEquipo_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            HelpV.RowCancelingEdit(sender, e);
            CargarGrilla();
        }
        protected void gvEquipo_RowEditing(object sender, GridViewEditEventArgs e)
        {
            HelpV.RowEditing(sender, e);
            CargarGrilla();
            if (((GridView)sender).EditIndex >= 0)
            {
                DropDownList ddlDirectorTecnico = (DropDownList)((GridView)sender).Rows[((GridView)sender).EditIndex].FindControl("ddlDTEquipoEdit");
                HiddenField hdnDirectorTecnico = (HiddenField)((GridView)sender).Rows[((GridView)sender).EditIndex].FindControl("hdnNombreDT");
                //DropDownList ddlAsistenteTecnico = (DropDownList)((GridView)sender).Rows[((GridView)sender).EditIndex].FindControl("ddlATEquipoEdit");
                //HiddenField hdnAsistenteTecnico = (HiddenField)((GridView)sender).Rows[((GridView)sender).EditIndex].FindControl("hdnCodUsuarioAT");
                DropDownList ddlTemporada = (DropDownList)((GridView)sender).Rows[((GridView)sender).EditIndex].FindControl("ddlTemporadaEdit");
                HiddenField hdnTemporada = (HiddenField)((GridView)sender).Rows[((GridView)sender).EditIndex].FindControl("hdnCodTemporada");
                ddlDirectorTecnico.SelectedValue = hdnDirectorTecnico.Value.ToString();
                //ddlAsistenteTecnico.SelectedValue = hdnAsistenteTecnico.Value.ToString();
                ddlTemporada.SelectedValue = hdnTemporada.Value.ToString();
            }
        }
        protected void gvEquipo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var grid = (GridView)sender;
            string index = e.CommandArgument.ToString();
            switch (e.CommandName)
            {
                case "AddItem":
                    if (AddNewEquipo(grid))
                        CargarGrilla();
                    else
                        Response.Write("<script>alert('Este equipo ya existe')</script>");
                    break;
                case "Update":
                    if (UpdateEquipo(grid))
                    {
                        gvEquipo.SetEditRow(-1);
                        CargarGrilla();
                    }
                    break;
                case "View":
                    if (index != "")
                        CargarEquipos(grid, e);
                    break;
            }
        }
        protected void gvEquipo_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }
        protected void gvEquipo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEquipo.PageIndex = e.NewPageIndex;
            CargarGrilla();
        }
        #endregion
    }
}