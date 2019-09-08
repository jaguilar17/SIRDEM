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
    public partial class PruebaFisica : System.Web.UI.Page
    {
        BE_Prueba p = new BE_Prueba();
        BL_Pruebas BLpru = new BL_Pruebas();
        BE_PF pf = new BE_PF();
        int r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11;

        int resultado;
        protected void Page_Load(object sender, EventArgs e)
        {
            validarNuemeroCopia();
            f5.Text = "No se encontraron observaciones...";
            if (Request.QueryString["Parametro1Y"] != null && Request.QueryString["Parametro2Y"] != null && Request.QueryString["Parametro3Y"] != null && Request.QueryString["Parametro4Y"] != null && Request.QueryString["Parametro5Y"] != null)
            {
                fant1.Text = Request.QueryString["Parametro1Y"];
                fant2.Text = Request.QueryString["Parametro2Y"];
                fant3.Text = Request.QueryString["Parametro3Y"];
                codJu.Text = Request.QueryString["Parametro4Y"];
                nom.Text = Request.QueryString["Parametro5Y"];
            }
        }

        public void validarNuemeroCopia(){

            txtaltura.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            txtaltura.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            txtaltura.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p1a.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p1a.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p1a.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p1b.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p1b.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p1b.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p1c.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p1c.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p1c.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p1d.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p1d.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p1d.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            txtsalo1m.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            txtsalo1m.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            txtsalo1m.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            txtLanzar.Attributes.Add("onkeypress", "return SoloNumerosDecimales3(event,'" + btnResulfis.ClientID + "')");
            txtLanzar.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            txtLanzar.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p2a.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p2a.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p2a.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p2b.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p2b.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p2b.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p2c.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p2c.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p2c.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p2d.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p2d.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p2d.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            txtv15s.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            txtv15s.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            txtv15s.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //

            txtflex.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            txtflex.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            txtflex.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p5a.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p5a.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p5a.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p5b.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p5b.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p5b.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p5c.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p5c.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p5c.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p5d.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p5d.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p5d.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p11a.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p11a.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p11a.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p11b.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p11b.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p11b.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p11c.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p11c.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p11c.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p11d.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p11d.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p11d.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            txtv1m.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            txtv1m.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            txtv1m.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p10a.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p10a.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p10a.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p10b.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p10b.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p10b.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p10c.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p10c.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p10c.Attributes.Add("onkeydown", "return noCopyKey(event);");
            //
            p10d.Attributes.Add("onkeypress", "return validarNumero(event,'" + btnResulfis.ClientID + "')");
            p10d.Attributes.Add("onmousedown", "return noCopyMouse (event);");
            p10d.Attributes.Add("onkeydown", "return noCopyKey(event);");
           
}
        protected void btnResulfis_Click(object sender, EventArgs e)
        {

                if(txtaltura.Text==""){
                    lp4.Text="Ingrese la altura optenida";
                    lp5.Text="";
                    lp6.Text="";
                    lp7.Text="";
                    lp8.Text="";
                    lp9.Text="";
                    lp10.Text="";
                    lp11.Text="";
                    lp12.Text="";
                    lp13.Text="";
                    lp14.Text="";
}
//
                else if (p1a.Text == "" && p1b.Text == "" && p1c.Text == "" && p1d.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "Ingrese un tiempo valido";
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

                else if (p1a.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "Ingrese hora(s) registra(s) en el cronometro";
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
                else if (int.Parse(p1a.Text) > 23)
                {
                    lp4.Text = "";
                    lp5.Text = "Cantidad maxima de horas permitidas es 23 horas";
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
                else if (p1b.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "Ingrese minuto(s) registrado(s) en el cronometro";
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
                else if (int.Parse(p1b.Text) > 59)
                {
                    lp4.Text = "";
                    lp5.Text = "Cantidad maxima de minutos permitidos es 59 minutos";
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
                else if(p1c.Text==""){
                    lp4.Text = "";
                    lp5.Text = "Ingrese segundo(s) registrado(s) en el cronometro";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";}
                else if (int.Parse(p1c.Text) > 59)
                {
                    lp4.Text = "";
                    lp5.Text = "Cantidad maxima de segundos permitidos es 59 segundos";
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
                else if (p1d.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "Ingrese milisegundo(s) registrado(s) en el cronometro";
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
                else if (int.Parse(p1d.Text )> 99)
                {
                    lp4.Text = "";
                    lp5.Text = "Cantidad maxima de milisegundos permitidos es 99 milisegundos";
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
//

                  else if(p1a.Text=="00" && p1b.Text=="00" &&  p1c.Text == "00" && p1d.Text=="00" ){
                      lp4.Text = "";
                      lp5.Text = "Ingrese el tiempo registrado en el cronometro";
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

                else if (txtsalo1m.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "Ingrese la cantidad de saltos optenidos";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
//
                else if(txtLanzar.Text==""){
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "Ingrese la distancia optenida";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
//
                else if (p2a.Text == "" && p2b.Text == "" && p2c.Text == "" && p2d.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "Ingrese un tiempo valido";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (p2a.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "Ingrese hora(s) registra(s) en el cronometro";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (int.Parse(p2a.Text) > 23)
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "Cantidad maxima de horas permitidas es 23 horas";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (p2b.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "Ingrese minuto(s) registrado(s) en el cronometro";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (int.Parse(p2b.Text) > 59)
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "Cantidad maxima de minutos permitidos es 59 minutos";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (p2c.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "Ingrese segundo(s) registrado(s) en el cronometro";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (int.Parse(p2c.Text) > 59)
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "Cantidad maxima de segundos permitidos es 59 segundos";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (p2d.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "Ingrese milisegundo(s) registrado(s) en el cronometro";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (int.Parse(p2d.Text) > 99)
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "Cantidad maxima de milisegundos permitidos es 99 milisegundos";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }


                 else if(p2a.Text=="00" && p2b.Text=="00" &&  p2c.Text == "00" && p2d.Text=="00" ){

                     lp4.Text = "";
                     lp5.Text = "";
                     lp6.Text = "";
                     lp7.Text = "";
                     lp8.Text = "Ingrese el tiempo registrado en el cronometro";
                     lp9.Text = "";
                     lp10.Text = "";
                     lp11.Text = "";
                     lp12.Text = "";
                     lp13.Text = "";
                     lp14.Text = "";
}
//

                else if (txtv15s.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "Ingrese la cantidad de repeticiones optenidas";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
//
                else if(txtflex.Text==""){
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "Ingrese la cantidad de flexiones optenidas";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
//
                else if (p5a.Text == "" && p5b.Text == "" && p5c.Text == "" && p5d.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "Ingrese un tiempo valido";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if(p5a.Text==""){ 
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "Ingrese hora(s) registra(s) en el cronometro";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";}
                else if (int.Parse(p5a.Text) > 23)
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "Cantidad maxima de horas permitidas es 23 horas";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }

                else if (p5b.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "Ingrese minuto(s) registrado(s) en el cronometro";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (int.Parse(p5b.Text) > 59)
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "Cantidad maxima de minutos permitidos es 59 minutos";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (p5c.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "Ingrese segundo(s) registrado(s) en el cronometro";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (int.Parse(p5c.Text) > 59)
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "Cantidad maxima de segundos permitidos es 59 segundos";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (p5d.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "Ingrese milisegundo(s) registrado(s) en el cronometro";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (int.Parse(p5d.Text) > 99)
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "Cantidad maxima de milisegundos permitidos es 99 milisegundos";
                    lp12.Text = "";
                    lp13.Text = "";
                    lp14.Text = "";
                }
               
                 else if(p5a.Text=="00" && p5b.Text=="00" &&  p5c.Text == "00" && p5d.Text=="00" ){
                     lp4.Text = "";
                     lp5.Text = "";
                     lp6.Text = "";
                     lp7.Text = "";
                     lp8.Text = "";
                     lp9.Text = "";
                     lp10.Text = "";
                     lp11.Text = "Ingrese el tiempo registrado en el cronometro";
                     lp12.Text = "";
                     lp13.Text = "";
                     lp14.Text = "";

}
//
                else if (p5a.Text == "" && p5b.Text == "" && p5c.Text == "" && p5d.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "Ingrese un tiempo valido";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (p11a.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "Ingrese hora(s) registra(s) en el cronometro";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (int.Parse(p11a.Text) > 23)
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "Cantidad maxima de horas permitidas es 23 horas";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (p11b.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "Ingrese minuto(s) registrado(s) en el cronometro";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (int.Parse(p11b.Text) > 59)
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "Cantidad maxima de minutos permitidos es 59 minutos";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if(p11c.Text==""){
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "Ingrese segundo(s) registrado(s) en el cronometro";
                    lp13.Text = "";
                    lp14.Text = "";}
                else if (int.Parse(p11c.Text) > 59)
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "Cantidad maxima de segundos permitidos es 59 segundos";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (p11d.Text == "")
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "Ingrese milisegundo(s) registrado(s) en el cronometro";
                    lp13.Text = "";
                    lp14.Text = "";
                }
                else if (int.Parse(p11d.Text) > 99)
                {
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "Cantidad maxima de milisegundos permitidos es 99 milisegundos";
                    lp13.Text = "";
                    lp14.Text = "";
                }
           
                 else if(p11a.Text=="00" && p11b.Text=="00" &&  p11c.Text == "00" && p11d.Text=="00" ){
                     lp4.Text = "";
                     lp5.Text = "";
                     lp6.Text = "";
                     lp7.Text = "";
                     lp8.Text = "";
                     lp9.Text = "";
                     lp10.Text = "";
                     lp11.Text = "";
                     lp12.Text = "Ingrese el tiempo registrado en el cronometro";
                     lp13.Text = "";
                     lp14.Text = "";
}
//
                else if(txtv1m.Text==""){
                    lp4.Text = "";
                    lp5.Text = "";
                    lp6.Text = "";
                    lp7.Text = "";
                    lp8.Text = "";
                    lp9.Text = "";
                    lp10.Text = "";
                    lp11.Text = "";
                    lp12.Text = "";
                    lp13.Text = "Ingrese la cantidad de repiticiones optenidas";
                    lp14.Text = "";
                }
//
                else if (p10a.Text == "" && p10b.Text == "" && p10c.Text == "" && p10d.Text == "")
                {
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
                    lp14.Text = "Ingrese un tiempo valido";
                }
                else if (p10a.Text == "")
                {
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
                    lp14.Text = "Ingrese hora(s) registra(s) en el cronometro";
                }
                else if (int.Parse(p10a.Text) > 99)
                {
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
                    lp14.Text = "Cantidad maxima de horas permitidas es 23 horas";
                }
                else if (p10b.Text == "")
                {
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
                    lp14.Text = "Ingrese minuto(s) registrado(s) en el cronometro";
                }
                else if (int.Parse(p10b.Text) > 59)
                {
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
                    lp14.Text = "Cantidad maxima de minutos permitidos es 59 minutos";
                }
                else if (p10c.Text == "")
                {
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
                    lp14.Text = "Ingrese segundo(s) registrado(s) en el cronometro";
                }
                else if (int.Parse(p10c.Text) > 59)
                {
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
                    lp14.Text = "Cantidad maxima de segundos permitidos es 59 segundos";
                }
                else if (p10d.Text == "")
                {
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
                    lp14.Text = "Ingrese milisegundo(s) registrado(s) en el cronometro";
                }
                else if (int.Parse(p10d.Text) > 99)
                {
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
                    lp14.Text = "Cantidad maxima de milisegundos permitidos es 99 milisegundos";
                }

                else if(p10a.Text=="00" && p10b.Text=="00" &&  p10c.Text == "00" && p10d.Text=="00" ){
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
                    lp14.Text = "Ingrese el tiempo registrado en el cronometro";

}
             else{
            //1)
            int h1, m1, s1, cs1;
            double res1, des1;
            h1 = int.Parse(p1a.Text);
            m1 = int.Parse(p1b.Text);
            s1 = int.Parse(p1c.Text);
            cs1 = int.Parse(p1d.Text);
            des1 = cs1 * 0.01;
            res1 = (h1 * 3600) + (m1 * 60) + s1 + (des1);
            lt1.Text = res1.ToString();
            if (res1 <= 15)
            {
                //rt1.Visible = true;
                //rt1s.Visible = true;
                rt1s.Text = "Aprobado";
                rtf1.Text = "1";
            }
            else if (res1 > 15)
            {
                //rt1.Visible = true;
                // rt1s.Visible = true;
                rt1s.Text = "Desaprobado";
                rtf1.Text = "0";
            }

            //2)
            int h2, m2, s2, cs2;
            double res2, rer2;
            h2 = int.Parse(p2a.Text);
            m2 = int.Parse(p2b.Text);
            s2 = int.Parse(p2c.Text);
            cs2 = int.Parse(p2d.Text);
            rer2 = cs2 * 0.01;
            res2 = (h2 * 3600) + (m2 * 60) + s2 + (rer2);
            lt2.Text = res2.ToString();
            if (res2 <= 600)
            {
                // rt2.Visible = true;
                // rts2.Visible = true;
                rts2.Text = "Aprobado";
                rtf2.Text = "1";
            }
            else if (res2 > 600)
            {
                // rt2.Visible = true;
                // rts2.Visible = true;
                rts2.Text = "Desaprobado";
                rtf2.Text = "0";
            }

            //3)
            int al3;
            al3 = int.Parse(txtaltura.Text);
            if (al3 >= 45)
            {
                // rt3.Visible = true;
                // rts3.Visible = true;
                rts3.Text = "Aprobado";
                rtf3.Text = "1";
            }
            else if (al3 < 45)
            {
                // rt3.Visible = true;
                // rts3.Visible = true;
                rts3.Text = "Desaprobado";
                rtf3.Text = "0";
            }
            //4)
            double lan4;
            lan4 = double.Parse(txtLanzar.Text);
            if (lan4 >= 6)
            {
                // rt4.Visible = true;
                // rts4.Visible = true;
                rts4.Text = "Aprobado";
                rtf4.Text = "1";
            }
            else if (lan4 < 6)
            {
                // rt4.Visible = true;
                // rts4.Visible = true;
                rts4.Text = "Desaprobado";
                rtf4.Text = "0";
            }
            //5)
            int h5, m5, s5, cs5;
            double res5, des5;
            h5 = int.Parse(p5a.Text);
            m5 = int.Parse(p5b.Text);
            s5 = int.Parse(p5c.Text);
            cs5 = int.Parse(p5d.Text);
            des5 = cs5 * 0.01;

            res5 = 500 / ((h5 * 3600) + (m5 * 60) + s5 + (des5));
            rvel500.Text = res5.ToString();
            rvel500.Visible = true;
            if (res5 >= 3.333333333)
            {
                // rt5.Visible = true;
                //  rts5.Visible = true;
                rts5.Text = "Aprobado";
                rtf5.Text = "1";
                vl.Visible = true;
                vl2.Visible = true;

            }
            else if (res5 < 3.333333333)
            {
                //rt5.Visible = true;
                //  rts5.Visible = true;
                rts5.Text = "Desaprobado";
                rtf5.Text = "0";
                vl.Visible = true;
                vl2.Visible = true;

            }
            //6)
            int fle6;
            fle6 = int.Parse(txtflex.Text);
            if (fle6 < 30)
            {
                // rt6.Visible = true;
                // rts6.Visible = true;
                rts6.Text = "Malo(Desaprobado)";
                rtf6.Text = "0";
            }
            else if (fle6 >= 30 || fle6 < 40)
            {
                // rt6.Visible = true;
                // rts6.Visible = true;
                rts6.Text = "Suficiente(Aprobado)";
                rtf6.Text = "1";
            }
            else if (fle6 >= 40 || fle6 < 50)
            {
                // rt6.Visible = true;
                // rts6.Visible = true;
                rts6.Text = "Bueno(Aprobado)";
                rtf6.Text = "1";
            }
            else if (fle6 >= 50 || fle6 <= 60)
            {
                // rt6.Visible = true;
                // rts6.Visible = true;
                rts6.Text = "Notable(Aprobado)";
                rtf6.Text = "1";
            }
            else if (fle6 > 60)
            {
                // rt6.Visible = true;
                // rts6.Visible = true;
                rts6.Text = "Sobresaliente(Aprobado)";
                rtf6.Text = "1";
            }
            //7)
            int txt7;
            txt7 = int.Parse(txtv15s.Text);
            if (txt7 >= 13)
            {
                // rt7.Visible = true;
                // rts7.Visible = true;
                rts7.Text = "Aprobado";
                rtf7.Text = "1";
            }
            else if (txt7 < 13)
            {
                // rt7.Visible = true;
                //  rts7.Visible = true;
                rts7.Text = "Desaprobado";
                rtf7.Text = "0";
            }
            //8)
            int txt8;
            txt8 = int.Parse(txtv1m.Text);
            if (txt8 >= 40)
            {
                // rt8.Visible = true;
                //  rts8.Visible = true;
                rts8.Text = "Aprobado";
                rtf8.Text = "1";
            }
            else if (txt8 < 40)
            {
                // rt8.Visible = true;
                //  rts8.Visible = true;
                rts8.Text = "Desaprobado";
                rtf8.Text = "0";
            }
            //9)
            int sal9;
            sal9 = int.Parse(txtsalo1m.Text);
            if (sal9 >= 100)
            {
                // rt9.Visible = true;
                // rts9.Visible = true;
                rts9.Text = "Aprobado";
                rtf9.Text = "1";
            }
            else if (sal9 < 100)
            {
                //  rt9.Visible = true;
                // rts9.Visible = true;
                rts9.Text = "Desaprobado";
                rtf9.Text = "0";
            }
            //10)
            int h10, m10, s10, cs10;
            double op10, des10;
            h10 = int.Parse(p10a.Text);
            m10 = int.Parse(p10b.Text);
            s10 = int.Parse(p10c.Text);
            cs10 = int.Parse(p10d.Text);
            des10 = cs10 * 0.01;
            op10 = 40 / (((h10 * 3600) + (m10 * 60) + s10 + (des10)) * ((h10 * 3600) + (m10 * 60) + s10 + (des10)));

            resAcel20.Text = op10.ToString();
            resAcel20.Visible = true;
            if (op10 >= (2 / 1125))
            {
                // rt10.Visible = true;
                // rts10.Visible = true;
                rts10.Text = "Aprobado";
                rtf10.Text = "1";
                ac1.Visible = true;

                ac4.Visible = true;
            }
            else if (op10 < (2 / 1125))
            {
                //rt10.Visible = true;
                // rts10.Visible = true;
                rts10.Text = "Desaprobado";
                rtf10.Text = "0";
                ac1.Visible = true;

                ac4.Visible = true;
            }
            //11)
            int h11, m11, s11, cs11;
            double op11, des11;
            h11 = int.Parse(p11a.Text);
            m11 = int.Parse(p11b.Text);
            s11 = int.Parse(p11c.Text);
            cs11 = int.Parse(p11d.Text);
            des11 = cs11 * 0.01;
            op11 = 60 / (((h11 * 3600) + (m11 * 60) + s11 + (des11)) * ((h11 * 3600) + (m11 * 60) + s11 + (des11)));
            resAcel30.Text = op11.ToString();
            resAcel30.Visible = true;
            BtnGuardarFisico.Visible = true;
            f5.Visible = true;
            Label271.Visible = true;
            if (op11 >= 0.002666666665)
            {
                // rt11.Visible = true;
                // rts11.Visible = true;
                rts11.Text = "Aprobado";
                rtf11.Text = "1";
                ab1.Visible = true;
                ab4.Visible = true;
            }
            else if (op11 < 0.002666666665)
            {
                // rt11.Visible = true;
                // rts11.Visible = true;
                rts11.Text = "Desaprobado";
                rtf11.Text = "0";
                ab1.Visible = true;

                ab4.Visible = true;
            }
            //final
           
            r1 = int.Parse(rtf1.Text);
            r2 = int.Parse(rtf2.Text);
            r3 = int.Parse(rtf3.Text);
            r4 = int.Parse(rtf4.Text);
            r5 = int.Parse(rtf5.Text);
            r6 = int.Parse(rtf6.Text);
            r7 = int.Parse(rtf7.Text);
            r8 = int.Parse(rtf8.Text);
            r9 = int.Parse(rtf9.Text);
            r10 = int.Parse(rtf10.Text);
            r11 = int.Parse(rtf11.Text);
            resultado = r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8 + r9 + r10 + r11;
            Label84.Width = 0;
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
            txtresfinal.Visible = true;
            if (resultado >= 6)
            {
                txtresfinal.Text = "Aprobado";
            }
            if (resultado < 6)
            {
                txtresfinal.Text = "Desaprobado";
            }
}
        }


        public void limpiarPruebaFisica()
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
            f1.Text = "";
            f2.Text = "";
            f3.Text = "";
            f4.Text = "";
            txtresfinal.Visible=false;
            Label84.Width = 409;
            p1a.Text = "00";
            p1b.Text = "00";
            p1c.Text = "00";
            p1d.Text = "00";
            p2a.Text = "00";
            p2b.Text = "00";
            p2c.Text = "00";
            p2d.Text = "00";
            txtaltura.Text = "";
            txtLanzar.Text = "";
            p5a.Text = "00";
            p5b.Text = "00";
            p5c.Text = "00";
            p5d.Text = "00";
            rvel500.Text = "";
            txtflex.Text = "";
            txtv15s.Text = "";
            txtv1m.Text = "";
            txtsalo1m.Text = "";
            p10a.Text = "00";
            p10b.Text = "00";
            p10c.Text = "00";
            p10d.Text = "00";
            p11a.Text = "00";
            p11b.Text = "00";
            p11c.Text = "00";
            p11d.Text = "00";
            resAcel30.Text = "";
            resAcel20.Text = "";
            txtresfinal.Text = "";
            f5.Text = "";

            vl.Visible = false;
            vl2.Visible = false;

            rvel500.Visible = false;
            ac1.Visible = false;

            ac4.Visible = false;
            resAcel20.Visible = false;

            resAcel30.Visible = false;
            ab1.Visible = false;

            ab4.Visible = false;
        }

        protected void BtnGuardarFisico_Click(object sender, EventArgs e)
        {
            if (f1.Text == "")
            {
                lp1.Text = "Ingrese Nombre y Apellidos del encargado de la Prueba";
                lp2.Text="";
                lp3.Text="";
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
                if (f2.Text == "")
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
                    if (DateTime.Parse(f2.Text) > DateTime.Today)
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
                        if (f3.Text == "")
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
                            if (f4.Text == "")
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

//
else

                                if (txtaltura.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "Ingrese la altura optenida";
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
                                //
                                else if (p1a.Text == "" && p1b.Text == "" && p1c.Text == "" && p1d.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "Ingrese un tiempo valido";
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

                                else if (p1a.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "Ingrese hora(s) registra(s) en el cronometro";
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
                                else if (int.Parse(p1a.Text) > 23)
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "Cantidad maxima de horas permitidas es 23 horas";
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
                                else if (p1b.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "Ingrese minuto(s) registrado(s) en el cronometro";
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
                                else if (int.Parse(p1b.Text) > 59)
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "Cantidad maxima de minutos permitidos es 59 minutos";
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
                                else if (p1c.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "Ingrese segundo(s) registrado(s) en el cronometro";
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
                                else if (int.Parse(p1c.Text) > 59)
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "Cantidad maxima de segundos permitidos es 59 segundos";
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
                                else if (p1d.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "Ingrese milisegundo(s) registrado(s) en el cronometro";
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
                                else if (int.Parse(p1d.Text) > 99)
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "Cantidad maxima de milisegundos permitidos es 99 milisegundos";
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
                                //

                                else if (p1a.Text == "00" && p1b.Text == "00" && p1c.Text == "00" && p1d.Text == "00")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "Ingrese el tiempo registrado en el cronometro";
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

                                else if (txtsalo1m.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "Ingrese la cantidad de saltos optenidos";
                                    lp7.Text = "";
                                    lp8.Text = "";
                                    lp9.Text = "";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                //
                                else if (txtLanzar.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "Ingrese la distancia optenida";
                                    lp8.Text = "";
                                    lp9.Text = "";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                //
                                else if (p2a.Text == "" && p2b.Text == "" && p2c.Text == "" && p2d.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "";
                                    lp8.Text = "Ingrese un tiempo valido";
                                    lp9.Text = "";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (p2a.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "";
                                    lp8.Text = "Ingrese hora(s) registra(s) en el cronometro";
                                    lp9.Text = "";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (int.Parse(p2a.Text) > 23)
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "";
                                    lp8.Text = "Cantidad maxima de horas permitidas es 23 horas";
                                    lp9.Text = "";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (p2b.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "";
                                    lp8.Text = "Ingrese minuto(s) registrado(s) en el cronometro";
                                    lp9.Text = "";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (int.Parse(p2b.Text) > 59)
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "";
                                    lp8.Text = "Cantidad maxima de minutos permitidos es 59 minutos";
                                    lp9.Text = "";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (p2c.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "";
                                    lp8.Text = "Ingrese segundo(s) registrado(s) en el cronometro";
                                    lp9.Text = "";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (int.Parse(p2c.Text) > 59)
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "";
                                    lp8.Text = "Cantidad maxima de segundos permitidos es 59 segundos";
                                    lp9.Text = "";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (p2d.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "";
                                    lp8.Text = "Ingrese milisegundo(s) registrado(s) en el cronometro";
                                    lp9.Text = "";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (int.Parse(p2d.Text) > 99)
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "";
                                    lp8.Text = "Cantidad maxima de milisegundos permitidos es 99 milisegundos";
                                    lp9.Text = "";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }


                                else if (p2a.Text == "00" && p2b.Text == "00" && p2c.Text == "00" && p2d.Text == "00")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";

                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "";
                                    lp8.Text = "Ingrese el tiempo registrado en el cronometro";
                                    lp9.Text = "";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                //

                                else if (txtv15s.Text == "")
                                {
                                    lp1.Text = "";
                                    lp2.Text = "";
                                    lp3.Text = "";
                                    lp4.Text = "";
                                    lp5.Text = "";
                                    lp6.Text = "";
                                    lp7.Text = "";
                                    lp8.Text = "";
                                    lp9.Text = "Ingrese la cantidad de repeticiones optenidas";
                                    lp10.Text = "";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                //
                                else if (txtflex.Text == "")
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
                                    lp10.Text = "Ingrese la cantidad de flexiones optenidas";
                                    lp11.Text = "";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                //
                                else if (p5a.Text == "" && p5b.Text == "" && p5c.Text == "" && p5d.Text == "")
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
                                    lp11.Text = "Ingrese un tiempo valido";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (p5a.Text == "")
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
                                    lp11.Text = "Ingrese hora(s) registra(s) en el cronometro";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (int.Parse(p5a.Text) > 23)
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
                                    lp11.Text = "Cantidad maxima de horas permitidas es 23 horas";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }

                                else if (p5b.Text == "")
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
                                    lp11.Text = "Ingrese minuto(s) registrado(s) en el cronometro";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (int.Parse(p5b.Text) > 59)
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
                                    lp11.Text = "Cantidad maxima de minutos permitidos es 59 minutos";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (p5c.Text == "")
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
                                    lp11.Text = "Ingrese segundo(s) registrado(s) en el cronometro";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (int.Parse(p5c.Text) > 59)
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
                                    lp11.Text = "Cantidad maxima de segundos permitidos es 59 segundos";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (p5d.Text == "")
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
                                    lp11.Text = "Ingrese milisegundo(s) registrado(s) en el cronometro";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (int.Parse(p5d.Text) > 99)
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
                                    lp11.Text = "Cantidad maxima de milisegundos permitidos es 99 milisegundos";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }

                                else if (p5a.Text == "00" && p5b.Text == "00" && p5c.Text == "00" && p5d.Text == "00")
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
                                    lp11.Text = "Ingrese el tiempo registrado en el cronometro";
                                    lp12.Text = "";
                                    lp13.Text = "";
                                    lp14.Text = "";

                                }
                                //
                                else if (p5a.Text == "" && p5b.Text == "" && p5c.Text == "" && p5d.Text == "")
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
                                    lp12.Text = "Ingrese un tiempo valido";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (p11a.Text == "")
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
                                    lp12.Text = "Ingrese hora(s) registra(s) en el cronometro";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (int.Parse(p11a.Text) > 23)
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
                                    lp12.Text = "Cantidad maxima de horas permitidas es 23 horas";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (p11b.Text == "")
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
                                    lp12.Text = "Ingrese minuto(s) registrado(s) en el cronometro";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (int.Parse(p11b.Text) > 59)
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
                                    lp12.Text = "Cantidad maxima de minutos permitidos es 59 minutos";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (p11c.Text == "")
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
                                    lp12.Text = "Ingrese segundo(s) registrado(s) en el cronometro";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (int.Parse(p11c.Text) > 59)
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
                                    lp12.Text = "Cantidad maxima de segundos permitidos es 59 segundos";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (p11d.Text == "")
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
                                    lp12.Text = "Ingrese milisegundo(s) registrado(s) en el cronometro";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                else if (int.Parse(p11d.Text) > 99)
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
                                    lp12.Text = "Cantidad maxima de milisegundos permitidos es 99 milisegundos";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }

                                else if (p11a.Text == "00" && p11b.Text == "00" && p11c.Text == "00" && p11d.Text == "00")
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
                                    lp12.Text = "Ingrese el tiempo registrado en el cronometro";
                                    lp13.Text = "";
                                    lp14.Text = "";
                                }
                                //
                                else if (txtv1m.Text == "")
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
                                    lp13.Text = "Ingrese la cantidad de repiticiones optenidas";
                                    lp14.Text = "";
                                }
                                //
                                else if (p10a.Text == "" && p10b.Text == "" && p10c.Text == "" && p10d.Text == "")
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
                                    lp14.Text = "Ingrese un tiempo valido";
                                }
                                else if (p10a.Text == "")
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
                                    lp14.Text = "Ingrese hora(s) registra(s) en el cronometro";
                                }
                                else if (int.Parse(p10a.Text) > 99)
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
                                    lp14.Text = "Cantidad maxima de horas permitidas es 23 horas";
                                }
                                else if (p10b.Text == "")
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
                                    lp14.Text = "Ingrese minuto(s) registrado(s) en el cronometro";
                                }
                                else if (int.Parse(p10b.Text) > 59)
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
                                    lp14.Text = "Cantidad maxima de minutos permitidos es 59 minutos";
                                }
                                else if (p10c.Text == "")
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
                                    lp14.Text = "Ingrese segundo(s) registrado(s) en el cronometro";
                                }
                                else if (int.Parse(p10c.Text) > 59)
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
                                    lp14.Text = "Cantidad maxima de segundos permitidos es 59 segundos";
                                }
                                else if (p10d.Text == "")
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
                                    lp14.Text = "Ingrese milisegundo(s) registrado(s) en el cronometro";
                                }
                                else if (int.Parse(p10d.Text) > 99)
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
                                    lp14.Text = "Cantidad maxima de milisegundos permitidos es 99 milisegundos";
                                }

                                else if (p10a.Text == "00" && p10b.Text == "00" && p10c.Text == "00" && p10d.Text == "00")
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
                                    lp14.Text = "Ingrese el tiempo registrado en el cronometro";

                                }

            else {
            //Prueba
            p = new BE_Prueba(0, DateTime.Parse(f2.Text), f3.Text, f4.Text, f1.Text, f5.Text, codJu.Text, txtresfinal.Text, "Prueba Fisica de aptitudes generales");
            BLpru.RegistrarPrueba(p);
            //Prueba fisca
            pf = new BE_PF(
                float.Parse(lt1.Text), float.Parse(lt2.Text), int.Parse(txtaltura.Text), float.Parse(txtLanzar.Text), float.Parse(rvel500.Text), int.Parse(txtflex.Text),
                int.Parse(txtv15s.Text), int.Parse(txtv1m.Text), int.Parse(txtsalo1m.Text), float.Parse(resAcel20.Text), float.Parse(resAcel30.Text));

            if (txtresfinal.Text == "Aprobado")
            {
                fant3.Text = "21";
            }
            if (txtresfinal.Text == "Desaprobado")
            {
                fant3.Text = "22";
            }
            BLpru.RegistrarPPF(pf);
            limpiarPruebaFisica();
            fant32.Text = fant3.Text;
            Response.Redirect("Administrar_Prueba.aspx?parametro1F=" + fant1.Text + "&parametro2F=" + this.fant2.Text + "&parametro3F=" + this.fant32.Text + "&parametro4F=" + this.codJu.Text + "&parametro5F=" + this.nom.Text);
                }
        }   
        }

       
    }
