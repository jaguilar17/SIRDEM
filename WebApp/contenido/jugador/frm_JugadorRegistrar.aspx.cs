using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CTR;
using WebApp.HelpClasses;
using System.Data;
using System.Configuration;

namespace WebApp.contenido2.jugador
{
    public partial class frm_JugadorRegistrar : System.Web.UI.Page
    {
        #region Atributos
        private List<DtoPosicion> _ldtoPos = new List<DtoPosicion>();
        private List<DtoEquipo> _ldtoEquip = new List<DtoEquipo>();
        private List<DtoTemporada> _ldtoTemporada = new List<DtoTemporada>();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ConsultarPosicionPrincipal(ddlPrincipal);
                ConsultarPosicionAlternativa(ddlAlternativa);
                CargaInicial();
                btnGuardar.Attributes.Add("OnClick", "return ValidaAddJugador('" + txtUsuarioJugador.ClientID + "','" + txtJugadorClave.ClientID + "','" + txtNombreUsu.ClientID + "','" + txtApellidoPatUsu.ClientID + "','" + txtApellidoMatUsu.ClientID + "','" + txtCorreo.ClientID + "','" + txtDireccionJugador.ClientID + "','" + txtNumDNI.ClientID + "','" + txtTelefono.ClientID + "','" + txtAliasJug.ClientID + "','" + txtNumDorsalJug.ClientID + "','" + ddlLateralidad.ClientID + "','" + ddlPrincipal.ClientID + "','" + ddlAlternativa.ClientID + "','" + txtPesoJug.ClientID + "','" + txtTallaJug.ClientID + "','" + txtFechNacJug.ClientID + "');");
                //ConsultarEquipo(ddlEquipo);
            }
            ConsultaTemporadas();
            if (!hdnTemporada2.Value.Equals("0")) ConsultaEquiposxTemporada(ddlTemporadaJug2.SelectedValue);
            else ConsultaEquiposxTemporada(String.Empty);
        }

        #region Metodos
        private void CargaInicial() 
        {
            DtoEquipo dtoE = new DtoEquipo();
            ddlTemporadaJug2.Attributes.Add("OnChange", "GetEquipos('" + ConfigurationManager.AppSettings["RootWeb"] + "','" + ddlTemporadaJug2.ClientID + "','" + ddlEquipoJug2.ClientID + "'); SetHiddenValue('" + hdnTemporada2.ClientID + "','" + ddlTemporadaJug2.ClientID + "');");
            ddlEquipoJug2.Attributes.Add("OnChange", "SetHiddenValue('" + hdnEquipo2.ClientID + "','" + ddlEquipoJug2.ClientID + "');");
            
        }
        private void ConsultaTemporadas()
        {
            try
            {
                ClassResultV cr = new CtrTemporada().Usp_TemporadaNombres_GetAll(TipoCons.cbx);
                var _ldtoTemporada = new List<DtoTemporada>();
                if (!cr.HuboError)
                {
                    _ldtoTemporada.AddRange(cr.List.Cast<DtoTemporada>());
                    ddlTemporadaJug2.DataSource = _ldtoTemporada;
                    ddlTemporadaJug2.DataValueField = "codTemporada";
                    ddlTemporadaJug2.DataTextField = "temporadaNombre";
                    ddlTemporadaJug2.DataBind();
                    ddlTemporadaJug2.Items.Insert(0, new ListItem("Seleccionar una Temporada", "0"));
                    if (!hdnTemporada2.Value.Equals("0")) ddlTemporadaJug2.SelectedValue = hdnTemporada2.Value;
                }
            }
            catch { }
        }
        private void ConsultaEquiposxTemporada(String CodTemp)
        {
            try
            {
                var _ldtoEquip = new List<DtoEquipo>();
                DtoEquipo dto = new DtoEquipo();
                dto.codTemporada = CodTemp;
                ClassResultV cr = new CtrEquipo().Usp_GetEquipoByCodTemporada(TipoCons.cbx, dto);

                if (!cr.HuboError)
                {
                    _ldtoEquip.AddRange(cr.List.Cast<DtoEquipo>());
                    ddlEquipoJug2.DataSource = _ldtoEquip;
                    ddlEquipoJug2.DataValueField = "codEquipo";
                    ddlEquipoJug2.DataTextField = "equipoNombre";
                    ddlEquipoJug2.DataBind();
                    ddlEquipoJug2.Items.Insert(0, new ListItem("Seleccionar una Temporada", "0"));
                    if (!hdnEquipo2.Value.Equals("0")) ddlEquipoJug2.SelectedValue = hdnEquipo2.Value;
                }
            }
            catch (Exception ex) { }
        }
        private void ConsultarPosicionPrincipal(DropDownList ddlPrincipal)
        {
            try
            {
                _ldtoPos = new List<DtoPosicion>(); ///Objeto Salida
                ClassResultV cr = new CtrPosicion().Usp_PosicionPrincipal_All();
                if (!cr.HuboError)
                {
                    _ldtoPos.AddRange(cr.List.Cast<DtoPosicion>());
                    _ldtoPos.Insert(0, new DtoPosicion() { codPosicion = "0", descripcionPosicion = "Seleccionar una posicion" });

                    ddlPrincipal.DataSource = _ldtoPos;
                    ddlPrincipal.DataValueField = "codPosicion";
                    ddlPrincipal.DataTextField = "descripcionPosicion";
                    ddlPrincipal.DataBind();
                }
            }
            catch { }
        }
        private void ConsultarPosicionAlternativa(DropDownList ddlAlternativo)
        {
            try
            {
                _ldtoPos = new List<DtoPosicion>(); ///Objeto Salida
                ClassResultV cr = new CtrPosicion().Usp_PosicionAlternativa_All();
                if (!cr.HuboError)
                {
                    _ldtoPos.AddRange(cr.List.Cast<DtoPosicion>());
                    _ldtoPos.Insert(0, new DtoPosicion() { codPosicion = "0", descripcionPosicion = "Seleccionar una posicion" });

                    ddlAlternativo.DataSource = _ldtoPos;
                    ddlAlternativo.DataValueField = "codPosicion";
                    ddlAlternativo.DataTextField = "descripcionPosicion";
                    ddlAlternativo.DataBind();
                }
            }
            catch { }
        }
        /*
        private void ConsultarPosicion(DropDownList ddlPrincipal, DropDownList ddlAlternativo)
        {
            try
            {
                _ldtoPos = new List<DtoPosicion>(); ///Objeto Salida
                ClassResultV cr = new CtrPosicion().Usp_Posicion_GetAll();
                if (!cr.HuboError)
                {
                    _ldtoPos.AddRange(cr.List.Cast<DtoPosicion>());
                    _ldtoPos.Insert(0, new DtoPosicion() { codPosicion = "0", descripcionPosicion = "Seleccionar una posicion" });

                    ddlPrincipal.DataSource = _ldtoPos;
                    ddlPrincipal.DataValueField = "codPosicion";
                    ddlPrincipal.DataTextField = "descripcionPosicion";
                    ddlPrincipal.DataBind();

                    ddlAlternativo.DataSource = _ldtoPos;
                    ddlAlternativo.DataValueField = "codPosicion";
                    ddlAlternativo.DataTextField = "descripcionPosicion";
                    ddlAlternativo.DataBind();
                }
            }
            catch { }
        }
        */ 
        //private void ConsultarEquipo(DropDownList ddlEquipo)
        //{
        //    try
        //    {
        //        _ldtoEquip = new List<DtoEquipo>(); ///Objeto Salida
        //        ClassResultV cr = new CtrEquipo().Usp_EquipoNombres_GetAll(TipoCons.cbx);
        //        if (!cr.HuboError)
        //        {
        //            _ldtoEquip.AddRange(cr.List.Cast<DtoEquipo>());
        //            _ldtoEquip.Insert(0, new DtoEquipo() { codEquipo = "0", equipoNombre = "Seleccionar un equipo" });

        //            ddlEquipo.DataSource = _ldtoEquip;
        //            ddlEquipo.DataValueField = "codEquipo";
        //            ddlEquipo.DataTextField = "equipoNombre";
        //            ddlEquipo.DataBind();
        //        }
        //    }
        //    catch { }
        //}
        private bool AgregarNuevoUsuarioJugador()
        {
            bool valido = false;

            try
            {
                ClassResultV cr = new ClassResultV();
                DtoUsuario dtoU = new DtoUsuario();
                DtoJugador dtoJ = new DtoJugador();
                DtoPlantilla dtoP = new DtoPlantilla();
                DtoEquipo dtoE = new DtoEquipo();
                //Usuario
                dtoU.codPerfil = 3;
                dtoU.usuario = txtUsuarioJugador.Text.Trim();
                dtoU.usuarioClave = txtJugadorClave.Text.Trim();
                dtoU.usuarioNombre = txtNombreUsu.Text.Trim();
                dtoU.usuarioApePaterno = txtApellidoPatUsu.Text.Trim();
                dtoU.usuarioApeMaterno = txtApellidoMatUsu.Text.Trim();
                dtoU.usuarioCorreo = txtCorreo.Text.Trim();
                dtoU.usuarioDireccion = txtDireccionJugador.Text.Trim();
                dtoU.usuarioNumDNI = Convert.ToInt32(txtNumDNI.Text.Trim());
                dtoU.usuarioTelefono = Convert.ToInt32(txtTelefono.Text.Trim());
                dtoU.usuarioEstado = "1";
                dtoU = new CtrUsuario().Usp_Usuario_Insert(dtoU);
                //Persona - Jugador
                dtoJ.codUsuario = dtoU.codUsuario;
                dtoJ.aliasDeportivo = txtAliasJug.Text.Trim();
                dtoJ.numDorsal = Convert.ToInt32(txtNumDorsalJug.Text.Trim());
                dtoJ.clubProcedencia = txtProcedJug.Text.Trim();
                dtoJ.lateralidad = (ddlLateralidad.SelectedValue);
                dtoJ.posicionPrincipal = ddlPrincipal.SelectedValue;
                dtoJ.posicionAlternativa = ddlAlternativa.SelectedValue;
                dtoJ.pesoInicial = Convert.ToDecimal(txtPesoJug.Text);
                if (dtoJ.pesoInicial > 55 && dtoJ.pesoInicial < 90)
                {
                    dtoJ.tallaInicial = Convert.ToDecimal(txtTallaJug.Text);
                    if (Convert.ToDouble(dtoJ.tallaInicial) > 1.55 && Convert.ToDouble(dtoJ.tallaInicial) < 2.00)
                    {
                        dtoJ.codEquipo = hdnEquipo2.Value.Equals("0") ? String.Empty : hdnEquipo2.Value;
                        dtoJ.jugadorFechaNac = Convert.ToDateTime(txtFechNacJug.Text.Trim());
                        dtoJ = new CtrJugador().Usp_Jugador_Insert(dtoJ);
                        //Plantilla
                        dtoP.codEquipo = hdnEquipo2.Value.Equals("0") ? String.Empty : hdnEquipo2.Value;
                        dtoP.codJugador = dtoJ.codJugador;
                        dtoP.IB_Mostrar = true;
                        cr = new CtrPlantilla().Usp_Plantilla_Insert(dtoP);
                        if (!cr.HuboError)
                        {
                            dtoE.codEquipo = dtoP.codEquipo;
                            dtoE.IB_Mostrar = false;
                            cr = new CtrEquipo().Usp_EstadoEquipoByCupos_Update(dtoE);
                            Response.Write("<script>alert('" + cr.ErrorMsj + "')</script>");
                            //Response.Write("<script>alert('Jugador Registrado Correctamente')</script>");
                            Limpiar();
                        }
                        else
                        {
                            Response.Write("<script>alert('" + cr.ErrorMsj + "')</script>");
                            dtoE.codEquipo = dtoP.codEquipo;
                            dtoE.IB_Mostrar = false;
                            cr = new CtrEquipo().Usp_EstadoEquipoByCupos_Update(dtoE);
                        }
                    }
                    else { Response.Write("<script>alert('Talla del jugador debe estar entre 1.55 y 2.00 cm.')</script>"); }
                }
                else { Response.Write("<script>alert('Peso del jugador debe estar entre los 55 y 90 kg.')</script>"); }
            }
            catch(Exception ex)
            {
            }
            return valido;
        }
        private void Limpiar()
        {
            txtUsuarioJugador.Text = "";
            txtJugadorClave.Text = "";
            txtNombreUsu.Text = "";
            txtApellidoPatUsu.Text = "";
            txtApellidoMatUsu.Text = "";
            txtCorreo.Text = "";
            txtDireccionJugador.Text = "";
            txtNumDNI.Text = "";
            txtTelefono.Text = "";
            txtAliasJug.Text = "";
            txtNumDorsalJug.Text = "";
            txtProcedJug.Text = "";
            ddlLateralidad.SelectedIndex = 0;
            ddlPrincipal.SelectedIndex = 0;
            ddlAlternativa.SelectedIndex = 0;
            txtPesoJug.Text = "";
            txtTallaJug.Text = "";
            ddlTemporadaJug2.SelectedIndex = 0;
            ddlEquipoJug2.SelectedIndex = 0;
            txtFechNacJug.Text = "";
        }
        #endregion

        #region Eventos
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            AgregarNuevoUsuarioJugador();
        }
        #endregion
    }
}