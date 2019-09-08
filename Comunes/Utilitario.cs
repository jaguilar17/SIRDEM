using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;
using System.Web.Caching;
using System.IO;
using System.Threading.Tasks;

namespace Comunes
{
    public class Utilitario
    {
        public void MostrarMensaje(ResultadoTransaccion resultado, Page pagina, String clienteId, String mensajeBIEN, String mensajeMAL)
        {
            if (resultado.TipoResultado == TipoResultadoTransaccion.Tipo.RESULTADO_BIEN)
            {
                pagina.ClientScript.RegisterStartupScript(pagina.GetType(), "__Mensaje__", "MostrarMensaje('" + mensajeBIEN + "','" + clienteId + "');", true);
            }
            if (resultado.TipoResultado == TipoResultadoTransaccion.Tipo.RESULTADO_MAL)
            {
                pagina.ClientScript.RegisterStartupScript(pagina.GetType(), "__Mensaje__", "MostrarMensaje('" + mensajeMAL + "','" + clienteId + "');", true);
            }
        }

        public string cadenaAmigable(string nombre)
        {
            string url = nombre.Trim();
            url = url.ToLower();
            url = Regex.Replace(url, "[áàâãäª@]", "a");
            url = Regex.Replace(url, "[éèêë]", "e");
            url = Regex.Replace(url, "[íìîï]", "i");
            url = Regex.Replace(url, "[óòôõºö]", "o");
            url = Regex.Replace(url, "[úùûü]", "u");
            url = Regex.Replace(url, "[ç]", "c");
            url = Regex.Replace(url, "[ñ]", "n");
            //url = Regex.Replace(url, "[^a-zA-Z0-9\-]", " ");
            url = Regex.Replace(url, " +", " ");
            //url = Regex.Replace(url, "[^a-zA-Z0-9\-]", "-");
            return url;
        }

        public string obtenerPrimerNombre(string cadena)
        {

                string[] nombres = cadena.Split(' ');
                return nombres[0];
        
        }

        public Boolean existeArchivo(String ruta)
        {
            return File.Exists(ruta);
        }
    }
}
