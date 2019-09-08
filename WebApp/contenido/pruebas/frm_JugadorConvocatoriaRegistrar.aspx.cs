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
    public partial class frm_JugadorConvocatoriaRegistrar : System.Web.UI.Page
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
             
                btnGuardar.Attributes.Add("OnClick", "return ValidaAddJugadorConvocatoria('" + txtNombreUsu.ClientID + "','" + txtApellidoPatUsu.ClientID + "','" + txtApellidoMatUsu.ClientID + "','" + txtCorreo.ClientID + "','"  + txtNumDNI.ClientID + "','" + txtTelefono.ClientID + "','"  + ddlLateralidad.ClientID + "','" + ddlPrincipal.ClientID + "','" + ddlAlternativa.ClientID + "','" + txtPesoJug.ClientID + "','" + txtTallaJug.ClientID + "','" + txtFechNacJug.ClientID + "');");
            }
        }

        #region Metodos
        
        
        
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
       
        private bool AgregarNuevoUsuarioJugador()
        {
            bool valido = false;

            try
            {
                ClassResultV cr = new ClassResultV();
                DTO_JugadorConvocatoria dtoJ = new DTO_JugadorConvocatoria();
                dtoJ.nombres = txtNombreUsu.Text.Trim();
                dtoJ.apellidoPaterno = txtApellidoPatUsu.Text.Trim();
                dtoJ.apellidoMaterno = txtApellidoMatUsu.Text.Trim();
                dtoJ.email = txtCorreo.Text.Trim();
                dtoJ.dni = txtNumDNI.Text.Trim();
                dtoJ.telefono = txtTelefono.Text.Trim();
                dtoJ.clubProcedencia = txtProcedJug.Text.Trim();
                dtoJ.lateralidad = (ddlLateralidad.SelectedValue);
                dtoJ.posicionPrincipal = ddlPrincipal.SelectedValue;
                dtoJ.posicionAlternativa = ddlAlternativa.SelectedValue;
                dtoJ.pesoInicial = Convert.ToDecimal(txtPesoJug.Text);
                dtoJ.tallaInicial = Convert.ToDecimal(txtTallaJug.Text);
            }
            catch(Exception ex)
            {
            }
            return valido;
        }
        private void Limpiar()
        {
           
            txtNombreUsu.Text = "";
            txtApellidoPatUsu.Text = "";
            txtApellidoMatUsu.Text = "";
            txtCorreo.Text = "";
            
            txtNumDNI.Text = "";
            txtTelefono.Text = "";
           
            txtProcedJug.Text = "";
            ddlLateralidad.SelectedIndex = 0;
            ddlPrincipal.SelectedIndex = 0;
            ddlAlternativa.SelectedIndex = 0;
            txtPesoJug.Text = "";
            txtTallaJug.Text = "";

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