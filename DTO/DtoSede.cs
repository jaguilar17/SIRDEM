using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoSede : DtoB
    {
        private int idSede;

        public int IdSede
        {
            get { return idSede; }
            set { idSede = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string referencia;

        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        private DateTime fechaIncio;

        public DateTime FechaIncio
        {
            get { return fechaIncio; }
            set { fechaIncio = value; }
        }

        private DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        private float costo;

        public float Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        private int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public DtoSede()
        {
            idSede = 0;
            nombre = "";
            direccion = "";
            referencia = "";
            fechaIncio = new DateTime(2014, 01, 01);
            fechaFin = new DateTime(2014, 01, 01);
            costo = 0;
        }

        public DtoSede(string nom, string dir, string refe, DateTime fechain, DateTime fechafin, float cost)
        {
            nombre = nom;
            direccion = dir;
            referencia = refe;
            fechaIncio = fechain;
            fechaFin = fechafin;
            costo = cost;
        }

        public DtoSede(int id, string nom, string dir, string refe, DateTime fechain, DateTime fechafin, float cost)
        {
            idSede = id;
            nombre = nom;
            direccion = dir;
            referencia = refe;
            fechaIncio = fechain;
            fechaFin = fechafin;
            costo = cost;
        }

    }
}
