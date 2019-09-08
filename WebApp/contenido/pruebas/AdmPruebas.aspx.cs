using CTR;
using DTO;
using System;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.contenido.pruebas
{
    public enum EstadoPurrrrr { BuscarAct, Actualizar };
    public enum EstadoPuvv3 { Buscaro, tero };

    public partial class AdmPruebas : System.Web.UI.Page
    {
        EstadoPurrrrr ep;
        EstadoPuvv3 eio;
        BE_Jugador ju = new BE_Jugador();
        BE_Persona per = new BE_Persona();
        BE_Prueba p = new BE_Prueba();
        BE_PS ps = new BE_PS();
        BE_PD pd = new BE_PD();
        BE_PF pf = new BE_PF();

        BL_Pruebas BLpru = new BL_Pruebas();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Parametro1D"] != null && Request.QueryString["Parametro2D"] != null && Request.QueryString["Parametro3D"] != null && Request.QueryString["Parametro4D"] != null && Request.QueryString["Parametro5D"] != null)
            {

                fanton1.Text = Request.QueryString["Parametro1D"];
                fanton2.Text = Request.QueryString["Parametro2D"];
                fanton3.Text = Request.QueryString["Parametro3D"];
                CodJugadorLabel.Text = Request.QueryString["Parametro4D"];
                lblNombreApellido.Text = Request.QueryString["Parametro5D"];
                InicioB();
                if (fanton3.Text == "11")
                {
                    lblNombrePrue.Text = "Ingrese Prueba Fisica";
                    btnNota.Visible = false;
                    btnInforme.Visible = false;
                    btnFormulario.Visible = true;
                    //Response.Write("<script>alert('Registro de la prueba de Desempeño realizado');</script>");
                }
                else if (fanton3.Text == "12")
                {
                    btnNota.Visible = true;
                    btnInforme.Visible = false;
                    btnFormulario.Visible = false;
                    lblNombrePrue.Text = "Usted ya no puede ingresar mas Pruebas";
                    lblct.Visible = true;
                    lblct.Text = "El alumno no podra dar la prueba Fisica debido a que desaprobo la prueba de Desempeño";
                    // Response.Write("<script>alert('Registro de la prueba de Desempeño realizado');</script>");
                }


            }
            else if (Request.QueryString["Parametro1F"] != null && Request.QueryString["Parametro2F"] != null && Request.QueryString["Parametro3F"] != null && Request.QueryString["Parametro4F"] != null && Request.QueryString["Parametro5F"] != null)
            {
                fanton1.Text = Request.QueryString["Parametro1F"];
                fanton2.Text = Request.QueryString["Parametro2F"];
                fanton3.Text = Request.QueryString["Parametro3F"];
                CodJugadorLabel.Text = Request.QueryString["Parametro4F"];
                lblNombreApellido.Text = Request.QueryString["Parametro5F"];
                InicioB();
                if (fanton3.Text == "21")
                {
                    lblNombrePrue.Text = "Ingrese Prueba Psicologica";
                    btnNota.Visible = false;
                    btnInforme.Visible = false;
                    btnFormulario.Visible = true;
                    // Response.Write("<script>alert('Registro de la prueba Fisica realizado');</script>");
                }
                else if (fanton3.Text == "22")
                {
                    btnNota.Visible = true;
                    btnInforme.Visible = false;
                    btnFormulario.Visible = false;
                    lblNombrePrue.Text = "Usted ya no puede ingresar mas Pruebas";
                    lblct.Visible = true;
                    lblct.Text = "El alumno no podra dar la prueba Psicologica debido a que desaprobo la prueba Fisica";
                    //  Response.Write("<script>alert('Registro de la prueba Fisica realizado');</script>");
                }

            }
            else if (Request.QueryString["Parametro1S"] != null && Request.QueryString["Parametro2S"] != null && Request.QueryString["Parametro3S"] != null && Request.QueryString["Parametro4S"] != null && Request.QueryString["Parametro5S"] != null)
            {
                fanton1.Text = Request.QueryString["Parametro1S"];
                fanton2.Text = Request.QueryString["Parametro2S"];
                fanton3.Text = Request.QueryString["Parametro3S"];
                CodJugadorLabel.Text = Request.QueryString["Parametro4S"];
                lblNombreApellido.Text = Request.QueryString["Parametro5S"];
                InicioB();
                if (fanton3.Text == "31")
                {
                    lblNombrePrue.Text = "Usted ya no puede ingresar mas Pruebas";
                    btnNota.Visible = false;
                    btnInforme.Visible = true;
                    btnFormulario.Visible = false;
                    lblct.Visible = true;
                    lblct.Text = "Se completó el registro de las pruebas, aprobando cada una de las 3 pruebas";
                    //  Response.Write("<script>alert('Registro de la prueba Psicologica realizado');</script>");
                }
                else if (fanton3.Text == "32")
                {
                    btnNota.Visible = false;
                    btnInforme.Visible = true;
                    btnFormulario.Visible = false;
                    lblNombrePrue.Text = "Usted ya no puede ingresar mas Pruebas";
                    lblct.Visible = true;
                    lblct.Text = "Se completó el registro de las pruebas, desaprobando la última prueba";
                    //  Response.Write("<script>alert('Registro de la prueba Psicologica realizado');</script>");
                }

            }
            if (!Page.IsPostBack)
            {
                Session["vEstado"] = ep;
                ep = EstadoPurrrrr.BuscarAct;
                eio = EstadoPuvv3.Buscaro;
                ep = (EstadoPurrrrr)Session["vEstado"];
                cargarPersonaJugador();

            }

        }
        private void cargarPersonaJugador()
        {
            GridView1.DataSource = BLpru.ConsultaPersonaJugado();

            GridView1.DataBind();

        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            cargarPersonaJugador();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int32 num = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Select")
            {
                if (ep == EstadoPurrrrr.BuscarAct)
                {

                    string re;
                    re = GridView1.Rows[num].Cells[0].Text;
                    CodJugadorLabel.Text = re.ToString();
                    //Obteniendo informacion de persona
                    String Nom, ApeP, ApeM;
                    Nom = GridView1.Rows[num].Cells[1].Text;
                    ApeP = GridView1.Rows[num].Cells[2].Text;
                    ApeM = GridView1.Rows[num].Cells[3].Text;
                    lblNombreApellido.Text = Nom.ToString() + "      " + ApeP.ToString() + "    " + ApeM.ToString();
                    cargarPruebaJugador(re);
                    fanton1.Text = "1";
                    fanton2.Text = "0";
                    fanton3.Text = "0";
                    Label1.Text = "Manejo de informacion de las Pruebas";
                    SinBotonFormulario();
                    Bpanel.Visible = true;
                    Apanel.Visible = false;


                    // Identifcar Aprobados y desaprobados en el inicio

                }
            }

            Session["vEstado"] = ep;
        }

        // Panel b Pruebas ingresadas

        public void cargarPruebaJugador(string cod)
        {
            GridView2.DataSource = BLpru.ConsultarPruebasJugador(cod);

            GridView2.DataBind();

        }

        public void InicioB()
        {
            Apanel.Visible = false;
            Bpanel.Visible = true;
            string cod = CodJugadorLabel.Text;
            cargarPruebaJugador(cod);
            string r1;
            int fin;
            fin = GridView2.Rows.Count - 1;
            r1 = GridView2.Rows[fin].Cells[5].Text;

            if (r1 == "Aprobado")
            {
                GridView2.Rows[fin].Cells[5].ForeColor = Color.Blue;

            }
            else if (r1 == "Desaprobado")
            {
                GridView2.Rows[fin].Cells[5].ForeColor = Color.Red;
            }
        }
        protected void btnListaParticipante_Click(object sender, EventArgs e)
        {
            Apanel.Visible = true;
            Bpanel.Visible = false;
            Response.Redirect("~/Administrar_Prueba.aspx");
            Label1.Text = "Participantes registrados en el sistema";
            btnFormulario.Visible = true;
            btnInforme.Visible = false;
            btnNota.Visible = false;
            lblct.Text = "";
            if (fanton1.Text == "1" && fanton2.Text == "1")
            {
                SinBotonFormulario();
                fanton1.Text = "0";
                fanton2.Text = "0";
                fanton3.Text = "0";

            }
            else
            if (fanton1.Text == "1" && fanton2.Text == "2")
            {
                SinBotonFormulario();
                fanton1.Text = "0";
                fanton2.Text = "0";
                fanton3.Text = "0";
            }
            else
            if (fanton1.Text == "1" && fanton2.Text == "3")
            {
                SinBotonFormulario();
                fanton1.Text = "0";
                fanton2.Text = "0";
                fanton3.Text = "0";
            }
            else
                if (fanton1.Text == "1" && fanton2.Text == "0" && fanton3.Text == "12")
            {
                fanton1.Text = "0";
                fanton2.Text = "0";
                fanton3.Text = "0";
            }
            else
                    if (fanton1.Text == "1" && fanton2.Text == "0" && fanton3.Text == "22")
            {
                fanton1.Text = "0";
                fanton2.Text = "0";
                fanton3.Text = "0";
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (lblNombrePrue.Text == "Ingrese Prueba de Desempeño")
            {

                lblNombrePrue.Text = "Ingrese Prueba Fisica";
                btnInforme.Visible = false;
                btnFormulario.Visible = true;
                btnNota.Visible = false;
                fanton1.Text = "1";
                fanton2.Text = "1";
                fanton3.Text = "0";
                Response.Redirect("~/PruebaDesempeño.aspx?parametro1x=" + fanton1.Text + "&parametro2x=" + this.fanton2.Text + "&parametro3x=" + this.fanton3.Text + "&parametro4x=" + this.CodJugadorLabel.Text + "&parametro5x=" + this.lblNombreApellido.Text);

            }
            else if (lblNombrePrue.Text == "Ingrese Prueba Fisica" && fanton1.Text == "1" && fanton2.Text == "1")
            {
                if (fanton3.Text == "11" || fanton3.Text == "0")
                {

                    lblNombrePrue.Text = "Ingrese Prueba Psicologica";
                    btnFormulario.Visible = true;
                    btnInforme.Visible = false;
                    btnNota.Visible = false;
                    fanton1.Text = "1";
                    fanton2.Text = "2";
                    fanton3.Text = "0";
                    Response.Redirect("~/PruebaFisica.aspx?parametro1Y=" + fanton1.Text + "&parametro2Y=" + this.fanton2.Text + "&parametro3Y=" + this.fanton3.Text + "&parametro4Y=" + this.CodJugadorLabel.Text + "&parametro5Y=" + this.lblNombreApellido.Text);
                }
            }

            else if (lblNombrePrue.Text == "Ingrese Prueba Psicologica" && fanton1.Text == "1" && fanton2.Text == "2")
            {
                if (fanton3.Text == "21" || fanton3.Text == "0")
                {
                    //Paneles

                    //botones
                    btnFormulario.Visible = false;
                    btnInforme.Visible = true;
                    btnNota.Visible = false;
                    lblct.Text = "Se a registrado las 3 pruebas con exito";
                    fanton1.Text = "1";
                    fanton2.Text = "3";
                    fanton3.Text = "0";
                    Response.Redirect("~/PruebaPsicologica.aspx?parametro1Z=" + fanton1.Text + "&parametro2Z=" + this.fanton2.Text + "&parametro3Z=" + this.fanton3.Text + "&parametro4Z=" + this.CodJugadorLabel.Text + "&parametro5Z=" + this.lblNombreApellido.Text);
                }
            }

        }
        protected void btnNota_Click(object sender, EventArgs e)
        {
            //Pasar un solo parametro
            //Response.Redirect("NotaRendimientoFisico.aspx?parametro=" + CodJugadorLabel.Text);
            if (GridView2.Rows.Count == 1)
            {
                string re;
                re = GridView2.Rows[0].Cells[0].Text;
                lblCodPrueba.Text = re.ToString();
                lan.Text = lblNombreApellido.Text;

                if (fanton1.Text == "1" && fanton2.Text == "1" && fanton3.Text == "12")
                {
                    Response.Redirect("~/NotaRendimientoDesempeño.aspx?parametro1=" + lblCodPrueba.Text + "&parametro2=" + this.lan.Text);

                }
                else
                    if (fanton1.Text == "1" && fanton2.Text == "0" && fanton3.Text == "12")
                {
                    Response.Redirect("~/NotaRendimientoDesempeño.aspx?parametro1=" + lblCodPrueba.Text + "&parametro2=" + this.lan.Text);

                }
            }
            else
                if (GridView2.Rows.Count == 2)
            {
                string re1, re2;
                //re = GridView2.Rows[1].Cells[0].Text;
                //lblCodPrueba.Text = re.ToString();
                if (fanton1.Text == "1" && fanton2.Text == "2" && fanton3.Text == "22")
                {

                    re1 = GridView2.Rows[0].Cells[0].Text;
                    lblCodPrueba.Text = re1.ToString();
                    re2 = GridView2.Rows[1].Cells[0].Text;
                    lblCodPrueba2.Text = re2.ToString();
                    lan.Text = lblNombreApellido.Text;
                    Response.Redirect("~/NotaRendimientoFisico.aspx?parametro1=" + lblCodPrueba.Text + "&parametro2=" + this.lblCodPrueba2.Text + "&parametro3=" + this.lan.Text);
                }
                else
                    if (fanton1.Text == "1" && fanton2.Text == "0" && fanton3.Text == "22")
                {

                    re1 = GridView2.Rows[0].Cells[0].Text;
                    lblCodPrueba.Text = re1.ToString();

                    re2 = GridView2.Rows[1].Cells[0].Text;
                    lblCodPrueba2.Text = re2.ToString();
                    lan.Text = lblNombreApellido.Text;
                    Response.Redirect("~/NotaRendimientoFisico.aspx?parametro1=" + lblCodPrueba.Text + "&parametro2=" + this.lblCodPrueba2.Text + "&parametro3=" + this.lan.Text);
                }
            }

        }
        protected void btnInforme_Click(object sender, EventArgs e)
        {
            if (GridView2.Rows.Count == 3)
            {
                string re1, re2, re3;
                //re = GridView2.Rows[1].Cells[0].Text;
                //lblCodPrueba.Text = re.ToString();
                if (fanton1.Text == "1" && fanton2.Text == "3" && fanton3.Text == "31")
                {

                    re1 = GridView2.Rows[0].Cells[0].Text;
                    lblCodPrueba.Text = re1.ToString();
                    re2 = GridView2.Rows[1].Cells[0].Text;
                    lblCodPrueba2.Text = re2.ToString();
                    re3 = GridView2.Rows[2].Cells[0].Text;
                    lblCodPrueba3.Text = re3.ToString();
                    lan.Text = lblNombreApellido.Text;
                    Response.Redirect("~/InformeFinal.aspx?parametro1=" + lblCodPrueba.Text + "&parametro2=" + this.lblCodPrueba2.Text + "&parametro3=" + this.lblCodPrueba3.Text + "&parametro4=" + this.lan.Text);
                }
                else
                    if (fanton1.Text == "1" && fanton2.Text == "3" && fanton3.Text == "32")
                {

                    re1 = GridView2.Rows[0].Cells[0].Text;
                    lblCodPrueba.Text = re1.ToString();
                    re2 = GridView2.Rows[1].Cells[0].Text;
                    lblCodPrueba2.Text = re2.ToString();
                    re3 = GridView2.Rows[2].Cells[0].Text;
                    lblCodPrueba3.Text = re3.ToString();
                    lan.Text = lblNombreApellido.Text;
                    Response.Redirect("~/InformeFinal.aspx?parametro1=" + lblCodPrueba.Text + "&parametro2=" + this.lblCodPrueba2.Text + "&parametro3=" + this.lblCodPrueba3.Text + "&parametro4=" + this.lan.Text);
                }
                else
                        if (fanton1.Text == "1" && fanton2.Text == "3" && fanton3.Text == "0")
                {

                    re1 = GridView2.Rows[0].Cells[0].Text;
                    lblCodPrueba.Text = re1.ToString();
                    re2 = GridView2.Rows[1].Cells[0].Text;
                    lblCodPrueba2.Text = re2.ToString();
                    re3 = GridView2.Rows[2].Cells[0].Text;
                    lblCodPrueba3.Text = re3.ToString();
                    lan.Text = lblNombreApellido.Text;
                    Response.Redirect("~/InformeFinal.aspx?parametro1=" + lblCodPrueba.Text + "&parametro2=" + this.lblCodPrueba2.Text + "&parametro3=" + this.lblCodPrueba3.Text + "&parametro4=" + this.lan.Text);
                }
                else
                            if (fanton1.Text == "1" && fanton2.Text == "0" && fanton3.Text == "32")
                {

                    re1 = GridView2.Rows[0].Cells[0].Text;
                    lblCodPrueba.Text = re1.ToString();
                    re2 = GridView2.Rows[1].Cells[0].Text;
                    lblCodPrueba2.Text = re2.ToString();
                    re3 = GridView2.Rows[2].Cells[0].Text;
                    lblCodPrueba3.Text = re3.ToString();
                    lan.Text = lblNombreApellido.Text;
                    Response.Redirect("~/InformeFinal.aspx?parametro1=" + lblCodPrueba.Text + "&parametro2=" + this.lblCodPrueba2.Text + "&parametro3=" + this.lblCodPrueba3.Text + "&parametro4=" + this.lan.Text);
                }
            }
        }
        public void SinBotonFormulario()
        {

            //solo funcional al inicio antes de precionar el boton mostrar formulario
            if (GridView2.Rows.Count == 0)
            {
                lblNombrePrue.Text = "Ingrese Prueba de Desempeño";
                lblct.Visible = true;
                lblct.Text = "El participante aun no cuenta con pruebas ingresadas ";

                btnInforme.Visible = false;
                btnNota.Visible = false;
                btnFormulario.Visible = true;
            }
            else
            {
                string r1;
                int fin;
                fin = GridView2.Rows.Count - 1;
                r1 = GridView2.Rows[fin].Cells[5].Text;

                if (GridView2.Rows.Count == 1 && r1 == "Aprobado")
                {

                    lblNombrePrue.Text = "Ingrese Prueba Fisica";
                    btnFormulario.Visible = true;
                    btnNota.Visible = false;
                    btnInforme.Visible = false;
                    fanton1.Text = "1";
                    fanton2.Text = "1";
                    GridView2.Rows[fin].Cells[5].ForeColor = Color.Blue;


                }
                else if (GridView2.Rows.Count == 2 && r1 == "Aprobado")
                {
                    lblNombrePrue.Text = "Ingrese Prueba Psicologica";
                    btnFormulario.Visible = true;
                    btnInforme.Visible = false;
                    lblct.Text = "Pruebas Ingresadas :";
                    fanton1.Text = "1";
                    fanton2.Text = "2";
                    GridView2.Rows[fin].Cells[5].ForeColor = Color.Blue;
                }
                else if (GridView2.Rows.Count == 3 && r1 == "Aprobado")
                {
                    lblNombrePrue.Text = "Usted ya no puede ingresar mas Pruebas";
                    btnFormulario.Visible = false;
                    btnInforme.Visible = true;
                    btnNota.Visible = false;
                    fanton1.Text = "1";
                    fanton2.Text = "3";
                    lblct.Visible = true;
                    lblct.Text = "Se completó el registro de las pruebas, aprobando cada una de las 3 pruebas";
                    GridView2.Rows[fin].Cells[5].ForeColor = Color.Blue;
                }


                else if (GridView2.Rows.Count == 1 && r1 == "Desaprobado")
                {

                    GridView2.Rows[fin].Cells[5].ForeColor = Color.Red;
                    if (fanton3.Text == "12")
                    {
                        Apanel.Visible = true;
                        Bpanel.Visible = false;


                        btnInforme.Visible = false;
                        btnNota.Visible = false;
                        fanton1.Text = "0";
                        fanton2.Text = "0";
                        fanton3.Text = "0";
                    }
                    else
                    {
                        Apanel.Visible = false;
                        Bpanel.Visible = true;


                        btnNota.Visible = true;
                        btnFormulario.Visible = false;
                        btnInforme.Visible = false;

                        // LblEspa.Text = "a";
                        fanton3.Text = "12";
                        lblNombrePrue.Text = "Ya no puede ingresar mas pruebas ";
                        lblct.Visible = true;
                        lblct.Text = "El alumno no podra dar la prueba Fisica debido a que desaprobo la prueba de Desempeño";

                    }

                }
                else if (GridView2.Rows.Count == 2 && r1 == "Desaprobado")
                {
                    GridView2.Rows[fin].Cells[5].ForeColor = Color.Red;
                    if (fanton3.Text == "22")
                    {
                        Apanel.Visible = true;
                        Bpanel.Visible = false;


                        btnInforme.Visible = false;
                        btnNota.Visible = false;
                        fanton1.Text = "0";
                        fanton2.Text = "0";
                        fanton3.Text = "0";
                    }
                    else
                    {

                        Apanel.Visible = false;
                        Bpanel.Visible = true;


                        btnNota.Visible = true;
                        btnFormulario.Visible = false;
                        btnInforme.Visible = false;

                        // LblEspa.Width = 50;
                        // LblEspa.Text="b";
                        fanton3.Text = "22";
                        lblNombrePrue.Text = "Ya no puede ingresar mas pruebas";

                        lblct.Visible = true;
                        lblct.Text = "El alumno no podra dar la prueba Psicologica debido a que desaprobo la prueba Fisica";
                    }
                }
                else if (GridView2.Rows.Count == 3 && r1 == "Desaprobado")
                {
                    GridView2.Rows[fin].Cells[5].ForeColor = Color.Red;
                    if (fanton3.Text == "32")
                    {
                        Apanel.Visible = true;
                        Bpanel.Visible = false;


                        btnInforme.Visible = false;
                        btnNota.Visible = false;
                        fanton1.Text = "0";
                        fanton2.Text = "0";
                        fanton3.Text = "0";
                    }
                    else
                    {

                        Apanel.Visible = false;
                        Bpanel.Visible = true;
                        btnNota.Visible = false;
                        btnFormulario.Visible = false;
                        btnInforme.Visible = true;

                        //LblEspa.Width = 50;
                        // LblEspa.Text="c";
                        fanton3.Text = "32";
                        lblNombrePrue.Text = "Ya no puede ingresar mas pruebas";
                        lblct.Visible = true;
                        lblct.Text = "El alumno desaprobo la prueba Psicoligica";
                    }
                }

            }
        }
    }
}