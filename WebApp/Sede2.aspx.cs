using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CTR;
using DAO;
using DTO;
using System.Drawing;
using System.Threading.Tasks;

namespace WebApp
{
    public partial class Sede2 : System.Web.UI.Page
    {
        private CtrSede objCtrSede;
        private DtoSede objSede;
        protected void Page_Load(object sender, EventArgs e)
        {
            objCtrSede = new CtrSede();
            cargarSede();
        }

        private void cargarSede()
        {
            GridView1.DataSource = objCtrSede.ConsultarSedes();
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int32 num = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Modificar")
            {
                string re;
                re = GridView1.Rows[num].Cells[0].Text;
                int id = int.Parse(re);
                
                mostrarPanelModificar();
                objSede = new DtoSede();
                objSede.IdSede = id;
                objCtrSede.BuscarSede(objSede);
                cargarDatosSede();
            }
            else
            {
                if (e.CommandName == "Eliminar")
                {

                    string re;
                    re = GridView1.Rows[num].Cells[0].Text;
                    int id;
                    id = int.Parse(re);

                    mostrarPanelModificar();
                    objSede = new DtoSede();
                    objSede.IdSede = id;
                    objCtrSede.BuscarSede(objSede);
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>confirm('Eiminar Sede?')</script>");
                    //Response.Write("<script>confirm('Eiminar Sede?')</script>");
                    objCtrSede.Usp_Sede_Delete(objSede);
                    Response.Redirect("Sede2.aspx");
                    
                }
            }
        }



        private void cargarDatosSede()
        {

            txtid.Text = objSede.IdSede.ToString();
            txtid.Enabled = false;
            txtnombre.Text = objSede.Nombre;
            txtdireccion.Text = objSede.Direccion;
            txtreferencia.Text = objSede.Referencia;

            txtantiguafechainicio.Text = Convert.ToString(objSede.FechaIncio);
            txtantiguafechafin.Text = Convert.ToString(objSede.FechaFin);
            txtantiguafechainicio.Enabled = false;
            txtantiguafechafin.Enabled = false;
            txtcosto.Text = objSede.Costo.ToString();
        }

        public void Limpiar()
        {
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txtreferencia.Text = "";
            txtcosto.Text = "";
            txtfechainicio.Text = "";
            txtfechafin.Text = "";
            LabelMensaje.Text = "";
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            cargarSede();
        }

        private void mostrarPanelIngresar()
        {
            PanelPrincipalSede.Visible = false;
            PanelRegistrar.Visible = true;
            btnActualizar.Visible = false;
            Label2.Visible = false;
            txtid.Visible = false;
            txtantiguafechafin.Visible = false;
            txtantiguafechainicio.Visible = false;
            Label7.Visible = false;
            Label8.Visible = false;
        }

        private void mostrarPanelModificar()
        {
            PanelPrincipalSede.Visible = false;
            PanelRegistrar.Visible = true;
            btnRegistrar.Visible = false;
        }

        private void mostrarPanelPrincipal()
        {
            PanelPrincipalSede.Visible = true;
            PanelRegistrar.Visible = false;
        }


        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string mensaje="";
            try
            {
                if (string.IsNullOrWhiteSpace(txtnombre.Text))
                {
                    mensaje += "--Nombre Vacio--/";
                }
                if (string.IsNullOrWhiteSpace(txtdireccion.Text))
                {
                    mensaje += "--Direccion Vacia--/";
                }
                if (string.IsNullOrWhiteSpace(txtreferencia.Text))
                {
                    mensaje += "--Referencia Vacia--/";
                }
                if (string.IsNullOrWhiteSpace(txtfechainicio.Text))
                {
                    mensaje += "--Fecha Incio Vacia--/";
                }
                if (string.IsNullOrWhiteSpace(txtfechafin.Text))
                {
                    mensaje += "--Fecha Fin Vacia--/";
                } if (string.IsNullOrWhiteSpace(txtcosto.Text))
                {
                    mensaje += "--Costo Vacio--";
                }
                if (!comprobarFloat(txtcosto.Text))
                {
                    mensaje += "--Costo No es un Numero Valido--";
                }
                LabelMensaje.Text = "" + mensaje;
                DateTime fechaini = Convert.ToDateTime(txtfechainicio.Text);
                DateTime fechafin = Convert.ToDateTime(txtfechafin.Text);
                float costo = float.Parse(txtcosto.Text);
                objSede = new DtoSede(txtnombre.Text, txtdireccion.Text, txtreferencia.Text, fechaini, fechafin, costo);
                objCtrSede.Usp_Sede_Insert(objSede);
                
                Response.Redirect("Sede2.aspx");
            }
            catch (Exception ex)
            {
                mensaje = "Sede Registrada Correctamente";
                
            }
                        
        }

        private bool comprobarFloat(String cadena)
        {
            try
            {
                float num = float.Parse(cadena);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txtnombre.Text))
                {
                    mensaje += "--Nombre Vacio--/";
                }
                if (string.IsNullOrWhiteSpace(txtdireccion.Text))
                {
                    mensaje += "--Direccion Vacia--/";
                }
                if (string.IsNullOrWhiteSpace(txtreferencia.Text))
                {
                    mensaje += "--Referencia Vacia--/";
                }
                if (string.IsNullOrWhiteSpace(txtfechainicio.Text))
                {
                    mensaje += "--Fecha Incio Vacia--/";
                }
                if (string.IsNullOrWhiteSpace(txtfechafin.Text))
                {
                    mensaje += "--Fecha Fin Vacia--/";
                } if (string.IsNullOrWhiteSpace(txtcosto.Text))
                {
                    mensaje += "--Costo Vacio--";
                }
                if (!comprobarFloat(txtcosto.Text))
                {
                    mensaje += "--Costo No es un Numero Valido--";
                }
                LabelMensaje.Text = "" + mensaje;
                DateTime fechaini = Convert.ToDateTime(txtfechainicio.Text);
                DateTime fechafin = Convert.ToDateTime(txtfechafin.Text);
                float costo = float.Parse(txtcosto.Text);
                int idCod = int.Parse(txtid.Text);
                objSede = new DtoSede(idCod, txtnombre.Text, txtdireccion.Text, txtreferencia.Text, fechaini, fechafin, costo);
                objCtrSede.Usp_Sede_Update(objSede);
                Response.Redirect("Sede2.aspx");
            }
            catch (Exception ex)
            {
                mensaje = "Sede Actualizada Correctamente";

            }
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Limpiar();
            mostrarPanelIngresar();
        }

        
    }
}