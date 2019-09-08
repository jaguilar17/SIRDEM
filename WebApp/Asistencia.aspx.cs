using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using WebApp.HelpClasses;
using DAO;
using System.Data;
using System.Data.SqlClient;

namespace WebApp
{
    public partial class Asistencia : System.Web.UI.Page
    {
        protected Conexion con = new Conexion();
        SqlConnection cn;
        private List<DtoHorarioEntrenamiento> _Asist = new List<DtoHorarioEntrenamiento>();
        private List<DtoJugador> _Pers = new List<DtoJugador>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrilla();
                GridView1.Visible = false;
                BotonGuardarAsistencia.Visible = false;
                BotonCancelar.Visible = false;
                Labelt1.Visible = false;
                Labelt2.Visible = false;
                LabelCodigoHorario.Visible = false;
            }
        }
        private void CargarGrilla()
        {
            try
            {
                _Asist.Clear();
                DtoHorarioEntrenamiento dto = new DtoHorarioEntrenamiento();
                ClassResultV cr = new CTR.CtrlHorarioEntrenamiento().Consultar_HorarioEntrenamiento();
                if (!cr.HuboError)
                {
                    foreach (DtoB dtoB in cr.List)
                        _Asist.Add((DtoHorarioEntrenamiento)dtoB);
                    gvHorarios.DataSource = _Asist;
                    gvHorarios.DataBind();
                }
                else
                {
                    gvHorarios.DataBind();
                }
            }
            catch { }
        }

        private void CargarJugadores()
        {
            try
            {
                _Asist.Clear();
                DtoJugador dto = new DtoJugador();
                ClassResultV cr = new CTR.CtrJugador().Consultar_Jugadores();
                if (!cr.HuboError)
                {
                    foreach (DtoB dtoB in cr.List)
                        _Pers.Add((DtoJugador)dtoB);
                    GridView1.DataSource = _Pers;
                    GridView1.DataBind();
                    foreach (GridViewRow item in GridView1.Rows)
                    {
                        CheckBox rd1 = (item.Cells[2].FindControl("RadioButton1") as CheckBox);
                        rd1.Checked = true;
                    }
                }
                else
                {
                    GridView1.DataBind();
                }
            }
            catch { }
        }

        protected void gvHorarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View1")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow filaSeleccionada = gvHorarios.Rows[index];

                String valor1 = filaSeleccionada.Cells[1].Text;
                String valor2 = filaSeleccionada.Cells[3].Text;
                String codigo = filaSeleccionada.Cells[0].Text;

                GridView1.Visible = true;
                BotonGuardarAsistencia.Visible = true;
                BotonCancelar.Visible = true;
                Labelt1.Visible = true;
                Labelt2.Visible = true;
                Labelt1.Text = "Asistencia: " + valor1;
                Labelt2.Text = valor2;
                LabelCodigoHorario.Text = codigo;
                CargarJugadores();

            }
        }

        protected void BotonGuardarAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                DtoAsistencia dt = new DtoAsistencia();
                foreach (GridViewRow item in GridView1.Rows)
                {
                    dt.codJugador = item.Cells[0].Text;
                    dt.codHorarioEntrenamiento = Convert.ToInt32(LabelCodigoHorario.Text);
                    CheckBox rd1 = (item.Cells[2].FindControl("RadioButton1") as CheckBox);
                    CheckBox rd2 = (item.Cells[3].FindControl("RadioButton2") as CheckBox);
                    CheckBox rd3 = (item.Cells[4].FindControl("RadioButton3") as CheckBox);
                    CheckBox rd4 = (item.Cells[5].FindControl("RadioButton4") as CheckBox);
                    if (rd1.Checked)
                    {
                        dt.asistencia = "P";
                    }
                    else if (rd2.Checked)
                    {
                        dt.asistencia = "T";
                    }
                    else if (rd3.Checked)
                    {
                        dt.asistencia = "F";
                    }
                    else if (rd4.Checked)
                    {
                        dt.asistencia = "J";
                    }

                    ClassResultV cr1 = new CTR.CtrAsistencia().Insertar_Asistencia(dt);
                }
                Limpiar();
            }
            catch (Exception ex) { }
        }

        public void Limpiar()
        {
            GridView1.Visible = false;
            BotonGuardarAsistencia.Visible = false;
            BotonCancelar.Visible = false;
            Labelt1.Visible = false;
            Labelt2.Visible = false;
            GridView1.DataSource = null;
            GridView1.DataBind();
            LabelCodigoHorario.Text = "";
            CargarGrilla();
        }

        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("http://localhost:32566/CalendarSitev1.1/Default.aspx", true);
        //}
    }
}