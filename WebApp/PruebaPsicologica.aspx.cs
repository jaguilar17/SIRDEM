using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Net;
using System.Xml;
using System.IO;
using System.Xml.XPath;
using System.Globalization;
using System.Data;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Image = System.Drawing.Image;
using DTO;
using DAO;
using CTR;
using System.Drawing;
using System.Threading.Tasks;

namespace APPAKD
{
    public partial class PruebaPsicologica : System.Web.UI.Page
    {
        BE_Prueba p = new BE_Prueba();
        BL_Pruebas BLpru = new BL_Pruebas();
        BE_PS ps = new BE_PS();
        int p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11;
        double res;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Parametro1Z"] != null && Request.QueryString["Parametro2Z"] != null && Request.QueryString["Parametro3Z"] != null && Request.QueryString["Parametro4Z"] != null && Request.QueryString["Parametro5Z"] != null)
            {
                fant1.Text = Request.QueryString["Parametro1Z"];
                fant2.Text = Request.QueryString["Parametro2Z"];
                fant3.Text = Request.QueryString["Parametro3Z"];
                codJu.Text = Request.QueryString["Parametro4Z"];
                nom.Text = Request.QueryString["Parametro5Z"];
            }
            if (!IsPostBack)
            {
                limpiarPruebaPsicologica();
                txtObservaciones.Text = "No se encontraron observaciones...";
            }
        }
        public void limpiarPruebaPsicologica()
        {
            lp1.Text = "";
            lp2.Text = "";
            lp3.Text = "";
            lp4.Text = "";
            lp5.Text = "";
            lp6.Text = "";
            lp7.Text = "";
            lp8.Text = "";
            lp9.Text = "";
            lp10.Text = "";
            lp11.Text = "";
            lp12.Text = "";
            lp13.Text = "";
            lp14.Text = "";
            txtencargado.Text = "";
            txtdia.Text = "";
            txthora.Text = "";
            txtlugar.Text = "";
            ddlMotivado.SelectedIndex = -1;
            ddltabajoEqui.SelectedIndex = -1;
            ddlpercepcion.SelectedIndex = -1;
            ddlrespuestaPro.SelectedIndex = -1;
            ddlBloqueo.SelectedIndex = -1;
            ddlCambioAni.SelectedIndex = -1;
            ddlconcentracion.SelectedIndex = -1;
            ddlAnsiedad.SelectedIndex = -1;
            ddlFrustracion.SelectedIndex = -1;
            ddlIrritabilidad.SelectedIndex = -1;
            ddlAbandono.SelectedIndex = -1;
            txtrespsico.Text = "";
            txtObservaciones.Text = "";
            Label84.Width = 409;
            txtrespsico.Visible = false;

        }

        protected void btnresulpsico_Click(object sender, EventArgs e)
        {
                if(ddlMotivado.SelectedValue.ToString() == "0") {
                lp4.Text = "Seleccione una puntuación para motivacion";
                lp5.Text = "";
                lp6.Text = "";
                lp7.Text = "";
                lp8.Text = "";
                lp9.Text = "";
                lp10.Text = "";
                lp11.Text = "";
                lp12.Text = "";
                lp13.Text = "";
                lp14.Text = "";
}else 
            if(ddltabajoEqui.SelectedValue.ToString() == "0") {
                lp4.Text = "";
                lp5.Text = "Seleccione una puntuación para buen trabajo en equipo";
                lp6.Text = "";
                lp7.Text = "";
                lp8.Text = "";
                lp9.Text = "";
                lp10.Text = "";
                lp11.Text = "";
                lp12.Text = "";
                lp13.Text = "";
                lp14.Text = "";
}else 
            if(ddlAnsiedad.SelectedValue.ToString() == "0") {
                lp4.Text = "";
                lp5.Text = "";
                lp6.Text = "Seleccione una puntuación para ansiedad";
                lp7.Text = "";
                lp8.Text = "";
                lp9.Text = "";
                lp10.Text = "";
                lp11.Text = "";
                lp12.Text = "";
                lp13.Text = "";
                lp14.Text = "";
}else 
            if(ddlpercepcion.SelectedValue.ToString() == "0") {
                lp4.Text = "";
                lp5.Text = "";
                lp6.Text = "";
                lp7.Text = "Seleccione una puntuación para percepcion";
                lp8.Text = "";
                lp9.Text = "";
                lp10.Text = "";
                lp11.Text = "";
                lp12.Text = "";
                lp13.Text = "";
                lp14.Text = "";
}else 
            if(ddlrespuestaPro.SelectedValue.ToString() == "0") {
                lp4.Text = "";
                lp5.Text = "";
                lp6.Text = "";
                lp7.Text = "";
                lp8.Text = "Seleccione una puntuación para respuesta a problemas";
                lp9.Text = "";
                lp10.Text = "";
                lp11.Text = "";
                lp12.Text = "";
                lp13.Text = "";
                lp14.Text = "";
}else 
            if(ddlIrritabilidad.SelectedValue.ToString() == "0") {
                lp4.Text = "";
                lp5.Text = "";
                lp6.Text = "";
                lp7.Text = "";
                lp8.Text = "";
                lp9.Text = "Seleccione una puntuación para irritabilidad";
                lp10.Text = "";
                lp11.Text = "";
                lp12.Text = "";
                lp13.Text = "";
                lp14.Text = "";
} else 
            if(ddlBloqueo.SelectedValue.ToString() == "0") {
                lp4.Text = "";
                lp5.Text = "";
                lp6.Text = "";
                lp7.Text = "";
                lp8.Text = "";
                lp9.Text = "";
                lp10.Text = "Seleccione una puntuación para bloqueo mental";
                lp11.Text = "";
                lp12.Text = "";
                lp13.Text = "";
                lp14.Text = "";
}else 
            if(ddlCambioAni.SelectedValue.ToString() == "0") {
                lp4.Text = "";
                lp5.Text = "";
                lp6.Text = "";
                lp7.Text = "";
                lp8.Text = "";
                lp9.Text = "";
                lp10.Text = "";
                lp11.Text = "Seleccione una puntuación para cambio de animo";
                lp12.Text = "";
                lp13.Text = "";
                lp14.Text = "";
}else 
            if(ddlAbandono.SelectedValue.ToString() == "0") {
                lp4.Text = "";
                lp5.Text = "";
                lp6.Text = "";
                lp7.Text = "";
                lp8.Text = "";
                lp9.Text = "";
                lp10.Text = "";
                lp11.Text = "";
                lp12.Text = "Seleccione una puntuación para abandono personal";
                lp13.Text = "";
                lp14.Text = "";
}else 
            if(ddlconcentracion.SelectedValue.ToString() == "0") {
                lp4.Text = "";
                lp5.Text = "";
                lp6.Text = "";
                lp7.Text = "";
                lp8.Text = "";
                lp9.Text = "";
                lp10.Text = "";
                lp11.Text = "";
                lp12.Text = "";
                lp13.Text = "Seleccione una puntuación para concentracion";
                lp14.Text = "";
}else 
            if(ddlFrustracion.SelectedValue.ToString() == "0") {
                lp4.Text = "";
                lp5.Text = "";
                lp6.Text = "";
                lp7.Text = "";
                lp8.Text = "";
                lp9.Text = "";
                lp10.Text = "";
                lp11.Text = "";
                lp12.Text = "";
                lp13.Text = "";
                lp14.Text = "Seleccione una puntuación para frustracion";
} 
            
            else{
            p1 = int.Parse(ddlIrritabilidad.SelectedValue.ToString());
            p2 = int.Parse(ddlconcentracion.SelectedValue.ToString());
            p3 = int.Parse(ddlBloqueo.SelectedValue.ToString());
            p4 = int.Parse(ddltabajoEqui.SelectedValue.ToString());
            p5 = int.Parse(ddlMotivado.SelectedValue.ToString());
            p6 = int.Parse(ddlpercepcion.SelectedValue.ToString());
            p7 = int.Parse(ddlAnsiedad.SelectedValue.ToString());
            p8 = int.Parse(ddlrespuestaPro.SelectedValue.ToString());
            p9 = int.Parse(ddlFrustracion.SelectedValue.ToString());
            p10 = int.Parse(ddlAbandono.SelectedValue.ToString());
            p11 = int.Parse(ddlCambioAni.SelectedValue.ToString());
            res = (3 * p1 + 3 * p2 + 4 * p3 + 3 * p4 + 4 * p5 + 5 * p6 + 4 * p7 + 4 * p8 + 4 * p9 + 4 * p10 + 3 * p11) / 41;
            Label45.Visible = true;
            txtObservaciones.Visible = true;
            BtnGuardar.Visible = true;
            Label84.Width = 0;
            txtrespsico.Visible=true;
            lp4.Text = "";
            lp5.Text = "";
            lp6.Text = "";
            lp7.Text = "";
            lp8.Text = "";
            lp9.Text = "";
            lp10.Text = "";
            lp11.Text = "";
            lp12.Text = "";
            lp13.Text = "";
            lp14.Text = "";
            if (res >= 10.5)
            {
                txtrespsico.Text = "Aprobado";
            }
            if (res < 10.5)
            {
                txtrespsico.Text = "Desaprobado";
            }
}
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtencargado.Text == "")
            {
                lp1.Text = "Ingrese Nombre y Apellidos del encargado de la Prueba";
                lp2.Text ="";
                lp3.Text = "";
                lp4.Text = "";
                lp5.Text = "";
                lp6.Text = "";
                lp7.Text = "";
                lp8.Text = "";
                lp9.Text = "";
                lp10.Text = "";
                lp11.Text = "";
                lp12.Text = "";
                lp13.Text = "";
                lp14.Text = "";

            }
            else
                if (txtdia.Text == "")
                {
                    lp2.Text = "Ingrese una fecha a la Prueba";
                    lp1.Text = "";

                    lp3.Text = "";
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";


                }
                else
                    if (DateTime.Parse(txtdia.Text) > DateTime.Today)
                    {
                        lp2.Text = "La fecha ingesada no puede ser mayor al dia actual";
                        lp1.Text = "";

                        lp3.Text = "";
                        lp4.Text = "";
                        lp5.Text = "";
                        lp6.Text = "";
                        lp7.Text = "";
                        lp8.Text = "";
                        lp9.Text = "";
                        lp10.Text = "";
                        lp11.Text = "";
                        lp12.Text = "";
                        lp13.Text = "";
                        lp14.Text = "";


                    }
                    else
                        if (txthora.Text == "")
                        {
                            lp2.Text = "Ingrese la hora en la que se realizo la Prueba";
                            lp1.Text = "";

                            lp3.Text = "";
                            lp4.Text = "";
                            lp5.Text = "";
                            lp6.Text = "";
                            lp7.Text = "";
                            lp8.Text = "";
                            lp9.Text = "";
                            lp10.Text = "";
                            lp11.Text = "";
                            lp12.Text = "";
                            lp13.Text = "";
                            lp14.Text = "";




                        }
                        else
                            if (txtlugar.Text == "")
                            {
                                lp3.Text = "Ingrese el lugar en donde se efectuo la Prueba";
                                lp1.Text = "";
                                lp2.Text = "";

                                lp4.Text = "";
                                lp5.Text = "";
                                lp6.Text = "";
                                lp7.Text = "";
                                lp8.Text = "";
                                lp9.Text = "";
                                lp10.Text = "";
                                lp11.Text = "";
                                lp12.Text = "";
                                lp13.Text = "";
                                lp14.Text = "";


                            }



else
//
            if (ddlMotivado.SelectedValue.ToString() == "0")
            {
                lp1.Text = "";
                lp2.Text = "";
                lp3.Text = "";
                lp4.Text = "Seleccione una puntuación para motivacion";
                lp5.Text = "";
                lp6.Text = "";
                lp7.Text = "";
                lp8.Text = "";
                lp9.Text = "";
                lp10.Text = "";
                lp11.Text = "";
                lp12.Text = "";
                lp13.Text = "";
                lp14.Text = "";

            }
            else
                if (ddltabajoEqui.SelectedValue.ToString() == "0")
                {
                    lp1.Text = "";
                    lp2.Text = "";
                    lp3.Text = "";
                    lp4.Text = "";
                    lp5.Text = "Seleccione una puntuación para buen trabajo en equipo";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else
                    if (ddlAnsiedad.SelectedValue.ToString() == "0")
                    {
                        lp1.Text = "";
                        lp2.Text = "";
                        lp3.Text = "";
                        lp4.Text = "";
                        lp5.Text = "";
                        lp6.Text = "Seleccione una puntuación para ansiedad";
                        lp7.Text = "";
                        lp8.Text = "";
                        lp9.Text = "";
                        lp10.Text = "";
                        lp11.Text = "";
                        lp12.Text = "";
                        lp13.Text = "";
                        lp14.Text = "";
                    }
                    else
                        if (ddlpercepcion.SelectedValue.ToString() == "0")
                        {
                            lp1.Text = "";
                            lp2.Text = "";
                            lp3.Text = "";
                            lp4.Text = "";
                            lp5.Text = "";
                            lp6.Text = "";
                            lp7.Text = "Seleccione una puntuación para percepcion";
                            lp8.Text = "";
                            lp9.Text = "";
                            lp10.Text = "";
                            lp11.Text = "";
                            lp12.Text = "";
                            lp13.Text = "";
                            lp14.Text = "";
                        }
                        else
                            if (ddlrespuestaPro.SelectedValue.ToString() == "0")
                            {
                                lp1.Text = "";
                                lp2.Text = "";
                                lp3.Text = "";
                                lp4.Text = "";
                                lp5.Text = "";
                                lp6.Text = "";
                                lp7.Text = "";
                                lp8.Text = "Seleccione una puntuación para respuesta a problemas";
                                lp9.Text = "";
                                lp10.Text = "";
                                lp11.Text = "";
                                lp12.Text = "";
                                lp13.Text = "";
                                lp14.Text = "";
                            }
                            else
                                if (ddlIrritabilidad.SelectedValue.ToString() == "0")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "";
                                    lp8.Text = "";
                                    lp9.Text = "Seleccione una puntuación para irritabilidad";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else
                                    if (ddlBloqueo.SelectedValue.ToString() == "0")
                                    {
                                        lp1.Text = "";
                                        lp2.Text = "";
                                        lp3.Text = "";
                                        lp4.Text = "";
                                        lp5.Text = "";
                                        lp6.Text = "";
                                        lp7.Text = "";
                                        lp8.Text = "";
                                        lp9.Text = "";
                                        lp10.Text = "Seleccione una puntuación para bloqueo mental";
                                        lp11.Text = "";
                                        lp12.Text = "";
                                        lp13.Text = "";
                                        lp14.Text = "";
                                    }
                                    else
                                        if (ddlCambioAni.SelectedValue.ToString() == "0")
                                        {
                                            lp1.Text = "";
                                            lp2.Text = "";
                                            lp3.Text = "";
                                            lp4.Text = "";
                                            lp5.Text = "";
                                            lp6.Text = "";
                                            lp7.Text = "";
                                            lp8.Text = "";
                                            lp9.Text = "";
                                            lp10.Text = "";
                                            lp11.Text = "Seleccione una puntuación para cambio de animo";
                                            lp12.Text = "";
                                            lp13.Text = "";
                                            lp14.Text = "";
                                        }
                                        else
                                            if (ddlAbandono.SelectedValue.ToString() == "0")
                                            {
                                                lp1.Text = "";
                                                lp2.Text = "";
                                                lp3.Text = "";
                                                lp4.Text = "";
                                                lp5.Text = "";
                                                lp6.Text = "";
                                                lp7.Text = "";
                                                lp8.Text = "";
                                                lp9.Text = "";
                                                lp10.Text = "";
                                                lp11.Text = "";
                                                lp12.Text = "Seleccione una puntuación para abandono personal";
                                                lp13.Text = "";
                                                lp14.Text = "";
                                            }
                                            else
                                                if (ddlconcentracion.SelectedValue.ToString() == "0")
                                                {
                                                    lp1.Text = "";
                                                    lp2.Text = "";
                                                    lp3.Text = "";
                                                    lp4.Text = "";
                                                    lp5.Text = "";
                                                    lp6.Text = "";
                                                    lp7.Text = "";
                                                    lp8.Text = "";
                                                    lp9.Text = "";
                                                    lp10.Text = "";
                                                    lp11.Text = "";
                                                    lp12.Text = "";
                                                    lp13.Text = "Seleccione una puntuación para concentracion";
                                                    lp14.Text = "";
                                                }
                                                else
                                                    if (ddlFrustracion.SelectedValue.ToString() == "0")
                                                    {
                                                        lp1.Text = "";
                                                        lp2.Text = "";
                                                        lp3.Text = "";
                                                        lp4.Text = "";
                                                        lp5.Text = "";
                                                        lp6.Text = "";
                                                        lp7.Text = "";
                                                        lp8.Text = "";
                                                        lp9.Text = "";
                                                        lp10.Text = "";
                                                        lp11.Text = "";
                                                        lp12.Text = "";
                                                        lp13.Text = "";
                                                        lp14.Text = "Seleccione una puntuación para frustracion";
                                                    } 
            //Prueba
            else {
            p = new BE_Prueba(0, DateTime.Parse(txtdia.Text), txthora.Text, txtlugar.Text, txtencargado.Text, txtObservaciones.Text, codJu.Text, txtrespsico.Text, "Prueba Psicologica de rasgos generales");
            BLpru.RegistrarPrueba(p);
            //PruebaPsicologica
            string p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11;
            p1 = ddlIrritabilidad.Text;
            p2 = ddlconcentracion.Text;
            p3 = ddlBloqueo.Text;
            p4 = ddltabajoEqui.Text;
            p5 = ddlMotivado.Text;
            p6 = ddlpercepcion.Text;
            p7 = ddlAnsiedad.Text;
            p8 = ddlrespuestaPro.Text;
            p9 = ddlFrustracion.Text;
            p10 = ddlAbandono.Text;
            p11 = ddlCambioAni.Text;
            //p1
            if (p1 == "13")
            {
                p1 = "Muy frecuente";
            }
            else if (p1 == "11")
            {
                p1 = "Regular frecuencia";
            }
            else if (p1 == "9")
            {
                p1 = "Poco frecuente";
            }
            //p2
            if (p2 == "13")
            {
                p2 = "Muy frecuente";
            }
            else if (p2 == "11")
            {
                p2 = "Regular frecuencia";
            }
            else if (p2 == "9")
            {
                p2 = "Poco frecuente";
            }
            //p3
            if (p3 == "9")
            {
                p3 = "Muy frecuente";
            }
            else if (p3 == "11")
            {
                p3 = "Regular frecuencia";
            }
            else if (p3 == "13")
            {
                p3 = "Poco frecuente";
            }
            //p4
            if (p4 == "13")
            {
                p4 = "Muy frecuente";
            }
            else if (p4 == "11")
            {
                p4 = "Regular frecuencia";
            }
            else if (p4 == "9")
            {
                p4 = "Poco frecuente";
            }
            //p5
            if (p5 == "9")
            {
                p5 = "Muy frecuente";
            }
            else if (p5 == "11")
            {
                p5 = "Regular frecuencia";
            }
            else if (p5 == "13")
            {
                p5 = "Poco frecuente";
            }
            //p6
            if (p6 == "9")
            {
                p6 = "Muy frecuente";
            }
            else if (p6 == "11")
            {
                p6 = "Regular frecuencia";
            }
            else if (p6 == "13")
            {
                p6 = "Poco frecuente";
            }
            //p7
            if (p7 == "9")
            {
                p7 = "Muy frecuente";
            }
            else if (p7 == "11")
            {
                p7 = "Regular frecuencia";
            }
            else if (p7 == "13")
            {
                p7 = "Poco frecuente";
            }
            //p8
            if (p8 == "9")
            {
                p8 = "Muy frecuente";
            }
            else if (p8 == "11")
            {
                p8 = "Regular frecuencia";
            }
            else if (p8 == "13")
            {
                p8 = "Poco frecuente";
            }
            //p9
            if (p9 == "9")
            {
                p9 = "Muy frecuente";
            }
            else if (p9 == "11")
            {
                p9 = "Regular frecuencia";
            }
            else if (p9 == "13")
            {
                p9 = "Poco frecuente";
            }
            //p10
            if (p10 == "9")
            {
                p10 = "Muy frecuente";
            }
            else if (p10 == "11")
            {
                p10 = "Regular frecuencia";
            }
            else if (p10 == "13")
            {
                p10 = "Poco frecuente";
            }
            //p10
            if (p11 == "9")
            {
                p11 = "Muy frecuente";
            }
            else if (p11 == "11")
            {
                p11 = "Regular frecuencia";
            }
            else if (p11 == "13")
            {
                p11 = "Poco frecuente";
            }
            ps = new BE_PS(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            BLpru.RegistrarPPS(ps);
            if (txtrespsico.Text == "Aprobado")
            {
                fant3.Text = "31";
            }
            if (txtrespsico.Text == "Desaprobado")
            {
                fant3.Text = "32";
            }
            fant32.Text=fant3.Text;
            limpiarPruebaPsicologica();

            Response.Redirect("Administrar_Prueba.aspx?parametro1S=" + fant1.Text + "&parametro2S=" + this.fant2.Text + "&parametro3S=" + this.fant32.Text + "&parametro4S=" + this.codJu.Text + "&parametro5S=" + this.nom.Text);

        }
    }
}
}