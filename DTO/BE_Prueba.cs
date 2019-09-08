using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class BE_Prueba
    {
        private int codPrueba;

        public int CodPrueba
        {
            get { return codPrueba; }
            set { codPrueba = value; }
        }
        private DateTime dia;

        public DateTime Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        private string hora;

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        private string lugar;

        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        private string observacion;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
        private string encargado;

        public string Encargado
        {
            get { return encargado; }
            set { encargado = value; }
        }
        private string codJugador;

        public string CodJugador
        {
            get { return codJugador; }
            set { codJugador = value; }
        }
        private string resultado;

        public string Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        private string descripcionGeneral;

        public string DescripcionGeneral
        {
            get { return descripcionGeneral; }
            set { descripcionGeneral = value; }
        }

        private int estado0;

        public int Estado0
        {
            get { return estado0; }
            set { estado0 = value; }
        }
        public BE_Prueba()
        {
            codPrueba = 0;
            dia = new DateTime(2014, 01, 04);
            hora = "";
            lugar = "";
            encargado = "";
            observacion = "";
            codJugador = "";
            resultado = "";
            descripcionGeneral = "";
        }
        public BE_Prueba(int codP, DateTime di, string ho, string lu, string en, string ob, string coJu, string res,string des)
        {
            codPrueba = codP;
            dia = di;
            hora = ho;
            lugar = lu;
            encargado = en;
            observacion = ob;
            codJugador = coJu;
            resultado = res;
            descripcionGeneral = des;
        }
    }
}
