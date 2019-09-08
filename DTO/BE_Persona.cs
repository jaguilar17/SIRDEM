using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BE_Persona
    {
        private int idCodigo;
        public int IdCodigo
        {
            get { return idCodigo; }
            set { idCodigo = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellidoP;
        public string ApellidoP
        {
            get { return apellidoP; }
            set { apellidoP = value; }
        }

        private string apellidoM;
        public string ApellidoM
        {
            get { return apellidoM; }
            set { apellidoM = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int numDNI;



        public int NumDNI
        {
            get { return numDNI; }
            set { numDNI = value; }
        }
        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string Correo;

        public string Correo1
        {
            get { return Correo; }
            set { Correo = value; }
        }
        private int bitEstado;

        public int BitEstado
        {
            get { return bitEstado; }
            set { bitEstado = value; }
        }

        public BE_Persona()
        {
            idCodigo = 0;
            nombre = "";
            apellidoP = "";
            ApellidoM = "";
            fecha = new DateTime(2014, 01, 04);
            numDNI = 0;
            telefono = 0;
            Correo = "";
            bitEstado = 0;

        }
        public BE_Persona(int idco, string nom, string apeP, string apeM, DateTime fec, int numD, int tel, string cor, int bit)
        {
            idCodigo = idco;
            nombre = nom;
            apellidoP = apeP;
            ApellidoM = apeM;
            fecha = fec;
            numDNI = numD;
            telefono = tel;
            Correo = cor;
            bitEstado = bit;

        }
    }
}
