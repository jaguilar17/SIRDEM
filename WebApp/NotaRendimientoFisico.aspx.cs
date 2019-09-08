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
    public enum EsNotp1 { Buscar, Consulta }
    public enum EsNotp2 { Buscar, Consulta }
    public partial class NotaRendimientoFisico : System.Web.UI.Page
    {
        EsNotp1 es1;
        EsNotp2 es2;
        BE_Prueba pru;
        BE_PD pruD;
        BE_PF pruF;
        BL_Nota_Informe NT;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Parametro1"] != null && Request.QueryString["Parametro2"] != null && Request.QueryString["Parametro3"] != null)
            {
                codPrueba.Text = Request.QueryString["Parametro1"];
                codPrueba2.Text = Request.QueryString["Parametro2"];
                n0.Text = Request.QueryString["Parametro3"];
            }
            NT = new BL_Nota_Informe();
            if (!IsPostBack)
            {

                es1 = EsNotp1.Buscar;
                es2 = EsNotp2.Buscar;
                Session["vEstado"] = es1;
                Session["vEstado2"] = es2;
                MostrarNotaDesempeño();
                MostrarNotaFisica();

            } }
        public void MostrarNotaDesempeño()
        {
            es1 = (EsNotp1)Session["vEstado"];
            if (es1 == EsNotp1.Buscar)
            {
                pru = new BE_Prueba();
                pruD = new BE_PD();
                pru.CodPrueba = int.Parse(codPrueba.Text);
                pruD.CodPrueba0 = int.Parse(codPrueba.Text);
                NT.BuscarPrueba(pru);
                NT.BuscarPruebaD(pruD);
                CargarDesempeño();
                es1 = EsNotp1.Consulta;
            }
            Session["vEstado"] = es1;
        }
        public void MostrarNotaFisica()
        {
            es2 = (EsNotp2)Session["vEstado2"];
            if (es2 == EsNotp2.Buscar)
            {
                pru = new BE_Prueba();
                pruF = new BE_PF();
                pru.CodPrueba = int.Parse(codPrueba2.Text);
                pruF.CodPrueba1 = int.Parse(codPrueba2.Text);
                NT.BuscarPrueba(pru);
                NT.BuscarPruebaF(pruF);
                CargarFisico();
                es2 = EsNotp2.Consulta;
            }
            Session["vEstado2"] = es2;
        } 
              private void CargarDesempeño() 
            {
                        string dir,pr;
                        n1.Text=pru.Encargado; 
                        //Cortar un mensaje
                        dir=Convert.ToString(pru.Dia);
                        pr=dir.Substring(0,10);
                        n2.Text=pr;
                        //
                        n3.Text=pru.Hora;
                        n4.Text=pru.Lugar;
                        n14.Text=pru.Observacion;
                        n15.Text=pru.Resultado;

                        n5.Text = Convert.ToString(pruD.PaceLargo);
                        n6.Text = Convert.ToString(pruD.ConduLinea);
                        n7.Text = Convert.ToString(pruD.ConduCar);
                        n8.Text = Convert.ToString(pruD.TiroApueta);
                        n9.Text = Convert.ToString(pruD.ConduDinamica);
                        n10.Text = Convert.ToString(pruD.TiroPre);
                        n11.Text = Convert.ToString(pruD.ControlCompañero);
                        n12.Text =Convert.ToString( pruD.ImpulsoBalon);
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

           
        }
    }
