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
    public enum EsNotr1 { Buscar, Consulta }
    public enum EsNotr2 { Buscar, Consulta }
    public enum EsNotr3 { Buscar, Consulta }
    public partial class InformeFinal : System.Web.UI.Page
    {
        EsNotr1 es1;
        EsNotr2 es2;
        EsNotr3 es3;
        BE_Prueba pru;
        BE_PD pruD;
        BE_PF pruF;
        BE_PS pruP;
        BL_Nota_Informe NT;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Parametro1"] != null && Request.QueryString["Parametro2"] != null && Request.QueryString["Parametro3"] != null && Request.QueryString["Parametro4"] != null)
            {
                codPrueba.Text  = Request.QueryString["Parametro1"];
                codPrueba2.Text = Request.QueryString["Parametro2"];
                codPrueba3.Text = Request.QueryString["Parametro3"];
                n0.Text         = Request.QueryString["Parametro4"];
            }
            NT = new BL_Nota_Informe();
            if (!IsPostBack)
            {

                es1 = EsNotr1.Buscar;
                es2 = EsNotr2.Buscar;
                es3 = EsNotr3.Buscar;
                Session["vEstado"] = es1;
                Session["vEstado2"] = es2;
                Session["vEstado3"] = es3;
                MostrarNotaDesempeño();
                MostrarNotaFisica();
                MostrarPsicologico();

            }
        }
        public void MostrarNotaDesempeño()
        {
            es1 = (EsNotr1)Session["vEstado"];
            if (es1 == EsNotr1.Buscar)
            {
                pru = new BE_Prueba();
                pruD = new BE_PD();
                pru.CodPrueba = int.Parse(codPrueba.Text);
                pruD.CodPrueba0 = int.Parse(codPrueba.Text);
                NT.BuscarPrueba(pru);
                NT.BuscarPruebaD(pruD);
                CargarDesempeño();
                es1 = EsNotr1.Consulta;
            }
            Session["vEstado"] = es1;
        }
        public void MostrarNotaFisica()
        {
            es2 = (EsNotr2)Session["vEstado2"];
            if (es2 == EsNotr2.Buscar)
            {
                pru = new BE_Prueba();
                pruF = new BE_PF();
                pru.CodPrueba = int.Parse(codPrueba2.Text);
                pruF.CodPrueba1 = int.Parse(codPrueba2.Text);
                NT.BuscarPrueba(pru);
                NT.BuscarPruebaF(pruF);
                CargarFisico();
                es2 = EsNotr2.Consulta;
            }
            Session["vEstado2"] = es2;
        }

        public void MostrarPsicologico() {
            es3 = (EsNotr3)Session["vEstado3"];
            if (es3 == EsNotr3.Buscar)
            {
                pru = new BE_Prueba();
                pruP = new BE_PS();
                pru.CodPrueba = int.Parse(codPrueba3.Text);
                pruP.CodPrueba2 = int.Parse(codPrueba3.Text);
                NT.BuscarPrueba(pru);
                NT.BuscarPruebaPS(pruP);
                CargarPsicologico();
                es3 = EsNotr3.Consulta;
            }
            Session["vEstado3"] = es3;
             }
        private void CargarDesempeño()
        {
            string dir, pr;
            n1.Text = pru.Encargado;
            //Cortar un mensaje
            dir = Convert.ToString(pru.Dia);
            pr = dir.Substring(0, 10);
            n2.Text = pr;
            //
            n3.Text = pru.Hora;
            n4.Text = pru.Lugar;
            n14.Text = pru.Observacion;
            n15.Text = pru.Resultado;

            n5.Text = Convert.ToString(pruD.PaceLargo);
            n6.Text = Convert.ToString(pruD.ConduLinea);
            n7.Text = Convert.ToString(pruD.ConduCar);
            n8.Text = Convert.ToString(pruD.TiroApueta);
            n9.Text = Convert.ToString(pruD.ConduDinamica);
            n10.Text = Convert.ToString(pruD.TiroPre);
            n11.Text = Convert.ToString(pruD.ControlCompañero);
            n12.Text = Convert.ToString(pruD.ImpulsoBalon);
            n13.Text = Convert.ToString(pruD.LanzamientoApuerta);

        }
        private void CargarFisico()
        {
            string dir, pr;
            p1.Text = pru.Encargado;
            //Cortar un mensaje
            dir = Convert.ToString(pru.Dia);
            pr = dir.Substring(0, 10);
            p2.Text = pr;
            //
            p3.Text = pru.Hora;
            p4.Text = pru.Lugar;
            p16.Text = pru.Observacion;
            p17.Text = pru.Resultado;

            p5.Text = Convert.ToString(pruF.Vel50m);
            p6.Text = Convert.ToString(pruF.Ti2000m);
            p7.Text = Convert.ToString(pruF.Alturasalto);
            p8.Text = Convert.ToString(pruF.DisLanzar);
            p9.Text = Convert.ToString(pruF.Vel500m);
            p10.Text = Convert.ToString(pruF.Cantflexion);
            p11.Text = Convert.ToString(pruF.RepeticionV15s);
            p12.Text = Convert.ToString(pruF.RepeticionV1m);
            p13.Text = Convert.ToString(pruF.CanSalto);
            p14.Text = Convert.ToString(pruF.AceSp20m);
            p15.Text = Convert.ToString(pruF.AceSl30m);

        }

        private void CargarPsicologico() 
        {
            string dir, pr;
            s1.Text = pru.Encargado;
            //Cortar un mensaje
            dir = Convert.ToString(pru.Dia);
            pr = dir.Substring(0, 10);
            s2.Text = pr;
            //
            s3.Text = pru.Hora;
            s4.Text = pru.Lugar;
            s16.Text = pru.Observacion;
            s17.Text = pru.Resultado;

            s5.Text = Convert.ToString(pruP.Irritabilidad);
            s6.Text = Convert.ToString(pruP.Concentracion);
            s7.Text = Convert.ToString(pruP.BloqueoMental);
            s8.Text = Convert.ToString(pruP.TrabajoEquipo);
            s9.Text = Convert.ToString(pruP.Motivacion);
            s10.Text = Convert.ToString(pruP.PercepcionProblemas);
            s11.Text = Convert.ToString(pruP.Ansiedad);
            s12.Text = Convert.ToString(pruP.RespuestaProblema);
            s13.Text = Convert.ToString(pruP.Frustacion);
            s14.Text = Convert.ToString(pruP.AbandonoPersonal);
            s15.Text = Convert.ToString(pruP.CambioAnimo);
        }

     
    }
}