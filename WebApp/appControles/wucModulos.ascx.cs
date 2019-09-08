using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Comunes;
using DTO;

namespace WebApp.appControles
{
    public partial class wucModulos : System.Web.UI.UserControl
    {
        Utilitario objUtilitario;
        Globales objGlobales;

        protected void Page_Load(object sender, EventArgs e)
        {
            objUtilitario = new Utilitario();
            objGlobales = Globales.Instance;
            renderizarModulos(objGlobales.Usuario.InterfacesPadre);
        }

        public void renderizarModulos(List<DtoModuloPadre> listaInterfacePadre)
        {
            if (listaInterfacePadre.Count > 0)
            {
                string html = "";
                int i, j;
                for (i = 0; i < listaInterfacePadre.Count; i++)
                {
                    html += "<li class='itemList'>";
                    html += "<div class='buttonItem'>";
                    html += "<div class='item'>";
                    html += "<div class='icon " + listaInterfacePadre[i].iconoCss + "'></div>";
                    html += "<div class='text'>" + listaInterfacePadre[i].nombreExterno + "</div>";
                    html += "</div>";
                    html += "</div>";
                    html += "<div class='modulos'>";
                    for (j = 0; j < listaInterfacePadre[i].listaInterfaces.Count; j++)
                    {
                        html += "<div class='modulo' rel='" + listaInterfacePadre[i].listaInterfaces[j].url + "'>";
                        html += listaInterfacePadre[i].listaInterfaces[j].nombre;
                        html += "</div>";
                    }
                    html += "</div>";
                    html += "</li>";
                }
                ltlModulo.Text = html;
            }
        }
    }
}