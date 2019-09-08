using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;


    public class Globales
    {
        private DtoUsuario DtoUsuario;

        public DtoUsuario Usuario
        {
            get { return DtoUsuario; }
            set { DtoUsuario = value; }
        }

        public static Globales Instance
        {
            get
            {
                if (HttpContext.Current.Session["__Globales__"] == null)
                {
                    HttpContext.Current.Session["__Globales__"] = new Globales();
                }
                Globales objGlobales = (Globales)HttpContext.Current.Session["__Globales__"];
                return objGlobales;
            }
        }

        public void cerrarSesion(String url)
        {
            HttpContext.Current.Session["__Globales__"] = null;
            HttpContext.Current.Session.Abandon();
        }
    }
