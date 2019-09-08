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
    public partial class PruebaDesempeño1 : System.Web.UI.Page
    {
BE_Prueba p = new BE_Prueba();
BL_Pruebas BLpru = new BL_Pruebas();
BE_PD pd = new BE_PD();

double promedio = 0.0;
double a1 = 0.0, a2 = 0.0, a3 = 0.0, a4 = 0.0, a5 = 0.0, a6 = 0.0, a7 = 0.0, a8 = 0.0, a9 = 0.0;

        protected void Page_Load(object sender, EventArgs e)
        {
         
            if (Request.QueryString["Parametro1x"] != null && Request.QueryString["Parametro2x"] != null && Request.QueryString["Parametro3x"] != null && Request.QueryString["Parametro4x"] != null && Request.QueryString["Parametro5x"] != null)
            {
                fant1.Text = Request.QueryString["Parametro1x"];
                fant2.Text = Request.QueryString["Parametro2x"];
                fant3.Text = Request.QueryString["Parametro3x"];
                codJu.Text = Request.QueryString["Parametro4x"];
                nom.Text = Request.QueryString["Parametro5x"];
            }

            if (!IsPostBack)
            {               limpiarPruebaDesempeño();
            d5.Text = "No se encontraron observaciones...";
                            
            }

        }

        protected void btnResultado_Click(object sender, EventArgs e)
        {
            if (ddlZ1.SelectedValue.ToString() == "0")
            {
                lv3.Text = "Seleccione una puntuación para pase largo";
                lv4.Text="";
                lv5.Text="";
                lv6.Text="";
                lv7.Text="";
                lv8.Text="";
                lv9.Text="";
                lv10.Text="";
                lv11.Text="";

            }
            else
                if (ddlZ2.SelectedValue.ToString() == "0")
                {
                    lv4.Text = "Seleccione una puntuación para conducción del balón(línea recta)";
                    lv3.Text = "";

                    lv5.Text = "";
                    lv6.Text = "";
                    lv7.Text = "";
                    lv8.Text = "";
                    lv9.Text = "";
                    lv10.Text = "";
                    lv11.Text = "";
                  
                }
                else
                    if (ddlZ7.SelectedValue.ToString() == "0")
                    {
                        lv9.Text = "Seleccione una puntuación para control del balón";
                        lv3.Text = "";
                        lv4.Text = "";
                        lv5.Text = "";
                        lv6.Text = "";
                        lv7.Text = "";
                        lv8.Text = "";

                        lv10.Text = "";
                        lv11.Text = "";

                    }
                else
                    if (ddlZ3.SelectedValue.ToString() == "0")
                    {
                        lv5.Text = "Seleccione una puntuación para conducción del balón(en zig-zag) ";
                        lv3.Text = "";
                        lv4.Text = "";

                        lv6.Text = "";
                        lv7.Text = "";
                        lv8.Text = "";
                        lv9.Text = "";
                        lv10.Text = "";
                        lv11.Text = "";
                        
                    }
                    else
                        if (ddlZ4.SelectedValue.ToString() == "0")
                        {
                            lv6.Text = "Seleccione una puntuación para tiro a puerta";
                            lv3.Text = "";
                            lv4.Text = "";
                            lv5.Text = "";

                            lv7.Text = "";
                            lv8.Text = "";
                            lv9.Text = "";
                            lv10.Text = "";
                            lv11.Text = "";
                           
                        }
                        else
                            if (ddlZ9.SelectedValue.ToString() == "0")
                            {
                                lv11.Text = "Seleccione una puntuación para lanzamiento a puerta";
                                lv3.Text = "";
                                lv4.Text = "";
                                lv5.Text = "";
                                lv6.Text = "";
                                lv7.Text = "";
                                lv8.Text = "";
                                lv9.Text = "";
                                lv10.Text = "";



                            }
                        else

                            if (ddlZ5.SelectedValue.ToString() == "0")
                            {
                                lv7.Text = "Seleccione una puntuación para conducción elevada del balón";
                                lv3.Text = "";
                                lv4.Text = "";
                                lv5.Text = "";
                                lv6.Text = "";

                                lv8.Text = "";
                                lv9.Text = "";
                                lv10.Text = "";
                                lv11.Text = "";
                               
                            }
                            else
                                if (ddlZ6.SelectedValue.ToString() == "0")
                                {
                                    lv8.Text = "Seleccione una puntuación para tiro de precisión";
                                    lv3.Text = "";
                                    lv4.Text = "";
                                    lv5.Text = "";
                                    lv6.Text = "";
                                    lv7.Text = "";

                                    lv9.Text = "";
                                    lv10.Text = "";
                                    lv11.Text = "";
                                    
                                }
                             
                                    else
                                        if (ddlZ8.SelectedValue.ToString() == "0")
                                        {
                                            lv10.Text = "Seleccione una puntuación para maniobrabilidad del balón";
                                            lv3.Text = "";
                                            lv4.Text = "";
                                            lv5.Text = "";
                                            lv6.Text = "";
                                            lv7.Text = "";
                                            lv8.Text = "";
                                            lv9.Text = "";
                                            lv11.Text = "";
                                            
                                        }
                                        
                                            else
                                            {
                                                
                                                a1 = double.Parse(ddlZ1.SelectedValue.ToString());
                                                a2 = double.Parse(ddlZ2.SelectedValue.ToString());
                                                a3 = double.Parse(ddlZ3.SelectedValue.ToString());
                                                a4 = double.Parse(ddlZ4.SelectedValue.ToString());
                                                a5 = double.Parse(ddlZ5.SelectedValue.ToString());
                                                a6 = double.Parse(ddlZ6.SelectedValue.ToString());
                                                a7 = double.Parse(ddlZ7.SelectedValue.ToString());
                                                a8 = double.Parse(ddlZ8.SelectedValue.ToString());
                                                a9 = double.Parse(ddlZ9.SelectedValue.ToString());
                                                promedio = (a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9) / 9;
                                                txtResulDesem.Text = promedio.ToString();
                                              //  txtResulDesem.Visible = true;
                                                txtResDesempeño.Visible = true;
                                                Label84.Width=0;
                                                //lblOptenido.Visible = true;
                                                //lblpunt.Visible = true;
                                                d5.Visible = true;
                                                btnGuardarDesempeño.Visible = true;
                                                Label83.Visible = true;
                                                lv3.Text = "";
                                                lv4.Text = "";
                                                lv5.Text = "";
                                                lv6.Text = "";
                                                lv7.Text = "";
                                                lv8.Text = "";
                                                lv9.Text = "";
                                                lv10.Text= "";
                                                lv11.Text = "";
                                                if (promedio >= 5)
                                                {
                                                    txtResDesempeño.Text = "Aprobado";
                                                }
                                                else
                                                    if (promedio < 5)
                                                    {
                                                        txtResDesempeño.Text = "Desaprobado";
                                                    }
                                            }
        }
        public void limpiarPruebaDesempeño()
        {
            d1.Text = "";
            d2.Text = "";
            d3.Text = "";
            d4.Text = "";
            ddlZ1.SelectedIndex = -1;
            ddlZ2.SelectedIndex = -1;
            ddlZ3.SelectedIndex = -1;
            ddlZ4.SelectedIndex = -1;
            ddlZ5.SelectedIndex = -1;
            ddlZ6.SelectedIndex = -1;
            ddlZ7.SelectedIndex = -1;
            ddlZ8.SelectedIndex = -1;
            ddlZ9.SelectedIndex = -1;
            txtResDesempeño.Visible = false;
            Label84.Width =409;
            txtResDesempeño.Text = "";
            txtResulDesem.Text = "";
            d5.Text = "";
            //txtResulDesem.Visible = false;
            //lblpunt.Visible = false;
            //lblOptenido.Visible = false;
            lv1.Text = "";
            lv2.Text = "";
            lv205.Text = "";
            lv3.Text = "";
            lv4.Text = "";
            lv5.Text = "";
            lv6.Text = "";
            lv7.Text = "";
            lv8.Text = "";
            lv9.Text = "";
            lv10.Text = "";
            lv11.Text = "";


        }

        protected void btnGuardarDesempeño_Click(object sender, EventArgs e)
        {

            if (d1.Text == "") 
                    {
                        lv1.Text = "Ingrese Nombre y Apellidos del encargado de la Prueba";

                        lv2.Text = "";
                        lv205.Text = "";
                        lv3.Text = "";
                        lv4.Text = "";
                        lv5.Text = "";
                        lv6.Text = "";
                        lv7.Text = "";
                        lv8.Text = "";
                        lv9.Text = "";
                        lv10.Text = "";
                        lv11.Text = "";
                        
                        }
            else
                if (d2.Text == "")
                {
                    lv2.Text = "Ingrese una fecha a la Prueba";
                    lv1.Text = "";
                    lv205.Text = "";
                    lv3.Text = "";
                    lv4.Text = "";
                    lv5.Text = "";
                    lv6.Text = "";
                    lv7.Text = "";
                    lv8.Text = "";
                    lv9.Text = "";
                    lv10.Text = "";
                    lv11.Text = "";

                }
else
                    if (DateTime.Parse(d2.Text) > DateTime.Today)
                    {
                        lv2.Text = "La fecha ingesada no puede ser mayor al dia actual";
                        lv1.Text = "";
                        lv205.Text = "";
                        lv3.Text = "";
                        lv4.Text = "";
                        lv5.Text = "";
                        lv6.Text = "";
                        lv7.Text = "";
                        lv8.Text = "";
                        lv9.Text = "";
                        lv10.Text = "";
                        lv11.Text = "";
}
                else
                    if (d3.Text == "")
                    {
                        lv2.Text = "Ingrese la hora en la que se realizo la Prueba";
                        lv1.Text = "";

                        lv205.Text = "";
                        lv3.Text = "";
                        lv4.Text = "";
                        lv5.Text = "";
                        lv6.Text = "";
                        lv7.Text = "";
                        lv8.Text = "";
                        lv9.Text = "";
                        lv10.Text = "";
                        lv11.Text = "";


                    }
                    else
                        if (d4.Text == "")
                        {
                            lv205.Text = "Ingrese el lugar en donde se efectuo la Prueba";
                            lv1.Text = "";
                            lv2.Text = "";

                            lv3.Text = "";
                            lv4.Text = "";
                            lv5.Text = "";
                            lv6.Text = "";
                            lv7.Text = "";
                            lv8.Text = "";
                            lv9.Text = "";
                            lv10.Text = "";
                            lv11.Text = "";

                        }
                        else if (ddlZ1.SelectedValue.ToString() == "0")
                        {
                            lv3.Text = "Seleccione una puntuación para pase largo";
                            lv1.Text = "";
                            lv2.Text = "";
                            lv205.Text = "";

                            lv4.Text = "";
                            lv5.Text = "";
                            lv6.Text = "";
                            lv7.Text = "";
                            lv8.Text = "";
                            lv9.Text = "";
                            lv10.Text = "";
                            lv11.Text = "";
                        }
                        else
                            if (ddlZ2.SelectedValue.ToString() == "0")
                            {
                                lv4.Text = "Seleccione una puntuación para conducción del balón(línea recta) ";
                                lv1.Text = "";
                                lv2.Text = "";
                                lv205.Text = "";
                                lv3.Text = "";

                                lv5.Text = "";
                                lv6.Text = "";
                                lv7.Text = "";
                                lv8.Text = "";
                                lv9.Text = "";
                                lv10.Text = "";
                                lv11.Text = "";

                            }
                            else
                                if (ddlZ7.SelectedValue.ToString() == "0")
                                {
                                    lv9.Text = "Seleccione una puntuación para control del balón";
                                    lv1.Text = "";
                                    lv2.Text = "";
                                    lv205.Text = "";
                                    lv3.Text = "";
                                    lv4.Text = "";
                                    lv5.Text = "";
                                    lv6.Text = "";
                                    lv7.Text = "";
                                    lv8.Text = "";

                                    lv10.Text = "";
                                    lv11.Text = "";
                                }
                                else
                                if (ddlZ3.SelectedValue.ToString() == "0")
                                {
                                    lv5.Text = "Seleccione una puntuación para conducción del balón(en zig-zag)";
                                    lv1.Text = "";
                                    lv2.Text = "";
                                    lv205.Text = "";
                                    lv3.Text = "";
                                    lv4.Text = "";

                                    lv6.Text = "";
                                    lv7.Text = "";
                                    lv8.Text = "";
                                    lv9.Text = "";
                                    lv10.Text = "";
                                    lv11.Text = "";

                                }
                                else
                                    if (ddlZ4.SelectedValue.ToString() == "0")
                                    {
                                        lv6.Text = "Seleccione una puntuación para tiro a puerta";
                                        lv1.Text = "";
                                        lv2.Text = "";
                                        lv205.Text = "";
                                        lv3.Text = "";
                                        lv4.Text = "";
                                        lv5.Text = "";

                                        lv7.Text = "";
                                        lv8.Text = "";
                                        lv9.Text = "";
                                        lv10.Text = "";
                                        lv11.Text = "";

                                    }
                                    else
                                        if (ddlZ9.SelectedValue.ToString() == "0")
                                        {
                                            lv11.Text = "Seleccione una puntuación para lanzamiento a puerta";
                                            lv1.Text = "";
                                            lv2.Text = "";
                                            lv205.Text = "";
                                            lv3.Text = "";
                                            lv4.Text = "";
                                            lv5.Text = "";
                                            lv6.Text = "";
                                            lv7.Text = "";
                                            lv8.Text = "";
                                            lv9.Text = "";
                                            lv10.Text = "";
                                        }

                                        else
                                        if (ddlZ5.SelectedValue.ToString() == "0")
                                        {
                                            lv7.Text = "Seleccione una puntuación para conducción elevada del balón";
                                            lv1.Text = "";
                                            lv2.Text = "";
                                            lv205.Text = "";
                                            lv3.Text = "";
                                            lv4.Text = "";
                                            lv5.Text = "";
                                            lv6.Text = "";

                                            lv8.Text = "";
                                            lv9.Text = "";
                                            lv10.Text = "";
                                            lv11.Text = "";

                                        }
                                        else
                                            if (ddlZ6.SelectedValue.ToString() == "0")
                                            {
                                                lv8.Text = "Seleccione una puntuación para tiro de precisión";
                                                lv1.Text = "";
                                                lv2.Text = "";
                                                lv205.Text = "";
                                                lv3.Text = "";
                                                lv4.Text = "";
                                                lv5.Text = "";
                                                lv6.Text = "";
                                                lv7.Text = "";

                                                lv9.Text = "";
                                                lv10.Text = "";
                                                lv11.Text = "";
                                            }
                                            else
                                               
                                                    if (ddlZ8.SelectedValue.ToString() == "0")
                                                    {
                                                        lv10.Text = "Seleccione una puntuación para maniobrabilidad del balón";
                                                        lv1.Text = "";
                                                        lv2.Text = "";
                                                        lv205.Text = "";
                                                        lv3.Text = "";
                                                        lv4.Text = "";
                                                        lv5.Text = "";
                                                        lv6.Text = "";
                                                        lv7.Text = "";
                                                        lv8.Text = "";
                                                        lv9.Text = "";

                                                        lv11.Text = "";
                                                    }
                                                    else
                                                        { 
            //Prueba
            p = new BE_Prueba(0, DateTime.Parse(d2.Text), d3.Text, d4.Text, d1.Text, d5.Text, codJu.Text, txtResDesempeño.Text, "Prueba de Desempeño basada en habilidad");
            BLpru.RegistrarPrueba(p);
            //Prueba de desempeño
            pd = new BE_PD(
                int.Parse(ddlZ1.SelectedValue.ToString()),int.Parse(ddlZ2.SelectedValue.ToString()), int.Parse(ddlZ3.SelectedValue.ToString()), int.Parse(ddlZ4.SelectedValue.ToString()),
                int.Parse(ddlZ5.SelectedValue.ToString()),int.Parse(ddlZ6.SelectedValue.ToString()),int.Parse(ddlZ7.SelectedValue.ToString()),int.Parse(ddlZ8.SelectedValue.ToString()),  
                int.Parse(ddlZ9.SelectedValue.ToString()));
            BLpru.RegistrarPPD(pd);
            
            if (txtResDesempeño.Text == "Aprobado")
            {
                fant3.Text = "11";
            }
            else
                if (txtResDesempeño.Text == "Desaprobado")
                {
                    fant3.Text = "12";
                    
                }

            
            limpiarPruebaDesempeño();
           fant32.Text=fant3.Text;
          Response.Redirect("Administrar_Prueba.aspx?parametro1D=" + fant1.Text + "&parametro2D=" + this.fant2.Text + "&parametro3D=" + this.fant32.Text + "&parametro4D=" + this.codJu.Text + "&parametro5D=" + this.nom.Text);
          
          
            }
      
           }
        }
    }
