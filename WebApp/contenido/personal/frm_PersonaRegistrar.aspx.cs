using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CTR;

namespace WebApp.contenido2.personal
{
    public partial class frm_PersonaRegistrar : System.Web.UI.Page
    {
        #region Atributos
        private List<DtoPersona> _ldtoPersona = new List<DtoPersona>();
        private List<DtoPerfil> _ldtoPerfil = new List<DtoPerfil>();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ConsultarPerfil(ddlPerfilAdd);
                btnGuardar.Attributes.Add("Onclick","return ValidaAddPersona('"+txtUsuarioPersona.ClientID+"','"+txtUsuarioContrasenia.ClientID+"','"+txtNombrePers.ClientID+"','" +txtApellidoPatPers.ClientID+"','"+txtApellidoMatPers.ClientID+"','"+txtCorreoPersona.ClientID+"','"+txtDireccionPersona.ClientID+"','"+txtNumDNIPersona.ClientID+"','"+txtTelefonoPersona.ClientID+"','"+txtFechaNacPersona.ClientID+"');");
            }
        }

        #region Metodos
        private void ConsultarPerfil(DropDownList ddlPerfil)
        {
            try
            {
                _ldtoPerfil = new List<DtoPerfil>(); ///Objeto Salida
                ClassResultV cr = new CtrPerfil().Usp_Perfil_GetAll();
                if (!cr.HuboError)
                {
                    _ldtoPerfil.AddRange(cr.List.Cast<DtoPerfil>());
                    _ldtoPerfil.Insert(0, new DtoPerfil() { codPerfil = 0, descripcion = "Seleccionar un perfil" });

                    ddlPerfil.DataSource = _ldtoPerfil;
                    ddlPerfil.DataValueField = "codPerfil";
                    ddlPerfil.DataTextField = "descripcion";
                    ddlPerfil.DataBind();
                }
            }
            catch { }
        }
        private bool AgregarNuevoUsuarioPersona()
        {
            bool valido = false;

            try
            {
                ClassResultV cr = new ClassResultV();
                DtoUsuario dtoU = new DtoUsuario();
                DtoPersona dtoP = new DtoPersona();
                //Usuario
                dtoU.codPerfil = Convert.ToInt32(ddlPerfilAdd.SelectedValue);
                dtoU.usuario = txtUsuarioPersona.Text.Trim();
                dtoU.usuarioClave = txtUsuarioContrasenia.Text.Trim();
                dtoU.usuarioNombre = txtNombrePers.Text.Trim();
                dtoU.usuarioApePaterno = txtApellidoPatPers.Text.Trim();
                dtoU.usuarioApeMaterno = txtApellidoMatPers.Text.Trim();
                dtoU.usuarioCorreo = txtCorreoPersona.Text.Trim();
                dtoU.usuarioDireccion = txtDireccionPersona.Text.Trim();
                dtoU.usuarioNumDNI = Convert.ToInt32(txtNumDNIPersona.Text.Trim());
                dtoU.usuarioTelefono = Convert.ToInt32(txtTelefonoPersona.Text.Trim());
                dtoU.usuarioEstado = "1";
                dtoU = new CtrUsuario().Usp_Usuario_Insert(dtoU);
                //Persona
                dtoP.codUsuario = dtoU.codUsuario;
                dtoP.personaNombre = txtNombrePers.Text.Trim();
                dtoP.personaApePaterno = (txtApellidoPatPers.Text.Trim());
                dtoP.personaApeMaterno = txtApellidoMatPers.Text.Trim();
                dtoP.personaFechaNac = Convert.ToDateTime(txtFechaNacPersona.Text.Trim());
                dtoP.personaNumDNI = Convert.ToInt32(txtNumDNIPersona.Text.Trim());
                dtoP.personaTelefono = Convert.ToInt32(txtTelefonoPersona.Text.Trim());
                dtoP.personaCorreo = txtCorreoPersona.Text.Trim();
                dtoP.personaDireccion = txtDireccionPersona.Text.Trim();

                dtoP = new CtrPersona().Usp_Persona_Insert(dtoP);
                if (!cr.HuboError)
                {
                    Response.Write("<script>alert('Usuario Personal Registrada Correctamente')</script>");
                    Limpiar();
                }
                else
                {
                    Response.Write("<script>alert('" + cr.ErrorMsj + "')</script>");
                }
            }
            catch (Exception ex)
            {
            }
            return valido;
        }
        private void Limpiar()
        {
            txtUsuarioPersona.Text = "";
            txtUsuarioContrasenia.Text = "";
            txtNombrePers.Text = "";
            txtApellidoPatPers.Text = "";
            txtApellidoMatPers.Text = "";
            txtCorreoPersona.Text = "";
            txtDireccionPersona.Text = "";
            txtNumDNIPersona.Text = "";
            txtTelefonoPersona.Text = "";
            ddlPerfilAdd.SelectedIndex = 0;
        }
        #endregion

        #region Eventos
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            AgregarNuevoUsuarioPersona();
        }
        #endregion
    }
}