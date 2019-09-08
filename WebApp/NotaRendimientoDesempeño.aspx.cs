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
    public enum EsNot { Buscar,Consulta}
    public partial class NotaRendimientoDesempeño1 : System.Web.UI.Page
    {
          EsNot es;
              BE_Prueba pru;
              BE_PD     pruD;
              BL_Nota_Informe NT;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Parametro1"] != null && Request.QueryString["Parametro2"]!=null) 
                    {
                        codPrueba.Text = Request.QueryString["Parametro1"];
                        nd0.Text = Request.QueryString["Parametro2"];
            }

            //Pasar solo un parametro
            //if (Request.Params["Parametro1 & parametro2"] != null)
            //{
            //    codPrueba.Text = Request.Params["Parametro1"];
            //    nd0.Text = Request.Params["Parametro2"];
            //}
            NT = new BL_Nota_Informe();
            if (!IsPostBack)
            {

                es = EsNot.Buscar;
                Session["vEstado"] = es;
                MostrarNotaDesempeño();
               
            }
        }
        public void MostrarNotaDesempeño() 
            {
                es = (EsNot)Session["vEstado"];
                if (es == EsNot.Buscar)
                {
                    pru = new BE_Prueba();
                    pruD = new BE_PD();
                    pru.CodPrueba = int.Parse(codPrueba.Text);
                    pruD.CodPrueba0 = int.Parse(codPrueba.Text);
                    NT.BuscarPrueba(pru);
                    NT.BuscarPruebaD(pruD);
                        Cargar();
                        es = EsNot.Consulta;
                    }
                Session["vEstado"] = es;
            } 
        private void Cargar() 
            {
                        string dir,pr;
                        nd1.Text=pru.Encargado; 
                        //Cortar un mensaje
                        dir=Convert.ToString(pru.Dia);
                        pr=dir.Substring(0,10);
                        nd2.Text=pr;
                        //
                        nd3.Text=pru.Hora;
                        nd4.Text=pru.Lugar;
                        nd14.Text=pru.Observacion;
                        nd15.Text=pru.Resultado;

                        nd5.Text = Convert.ToString(pruD.PaceLargo);
                        nd6.Text = Convert.ToString(pruD.ConduLinea);
                        nd7.Text = Convert.ToString(pruD.ConduCar);
                        nd8.Text = Convert.ToString(pruD.TiroApueta);
                        nd9.Text = Convert.ToString(pruD.ConduDinamica);
                        nd10.Text = Convert.ToString(pruD.TiroPre);
                        nd11.Text = Convert.ToString(pruD.ControlCompañero);
                        nd12.Text =Convert.ToString( pruD.ImpulsoBalon);
                        nd13.Text = Convert.ToString(pruD.LanzamientoApuerta);

                        

                       
                 }
        
    }
}