using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BE_PS
    {
        private int codPrueba2;
        public int CodPrueba2
        {
            get { return codPrueba2; }
            set { codPrueba2 = value; }
        }


        private string irritabilidad;

        public string Irritabilidad
        {
            get { return irritabilidad; }
            set { irritabilidad = value; }
        }
        private string concentracion;

        public string Concentracion
        {
            get { return concentracion; }
            set { concentracion = value; }
        }
        private string bloqueoMental;

        public string BloqueoMental
        {
            get { return bloqueoMental; }
            set { bloqueoMental = value; }
        }
        private string trabajoEquipo;

        public string TrabajoEquipo
        {
            get { return trabajoEquipo; }
            set { trabajoEquipo = value; }
        }
        private string motivacion;

        public string Motivacion
        {
            get { return motivacion; }
            set { motivacion = value; }
        }
        private string percepcionProblemas;

        public string PercepcionProblemas
        {
            get { return percepcionProblemas; }
            set { percepcionProblemas = value; }
        }
        private string ansiedad;

        public string Ansiedad
        {
            get { return ansiedad; }
            set { ansiedad = value; }
        }
        private string respuestaProblema;

        public string RespuestaProblema
        {
            get { return respuestaProblema; }
            set { respuestaProblema = value; }
        }
        private string frustacion;

        public string Frustacion
        {
            get { return frustacion; }
            set { frustacion = value; }
        }
        private string abandonoPersonal;

        public string AbandonoPersonal
        {
            get { return abandonoPersonal; }
            set { abandonoPersonal = value; }
        }
        private string cambioAnimo;

        public string CambioAnimo
        {
            get { return cambioAnimo; }
            set { cambioAnimo = value; }
        }
      
        private int codPrueba;

        public int CodPrueba
        {
            get { return codPrueba; }
            set { codPrueba = value; }
        }

        private int estado3;

        public int Estado3
        {
            get { return estado3; }
            set { estado3 = value; }
        }
        public BE_PS()
        {

            irritabilidad = "";
            concentracion = "";
            bloqueoMental = "";
            trabajoEquipo = "";
            motivacion = "";
            percepcionProblemas = "";
            ansiedad = "";
            respuestaProblema = "";
            frustacion = "";
            abandonoPersonal = "";
            cambioAnimo = "";
            codPrueba = 0;
        }
        public BE_PS(string ir, string con, string blo, string tra, string mot, string per, string ans, string res, string fru, string cambPer,
            string camA)
        {
            irritabilidad = ir;
            concentracion = con;
            bloqueoMental = blo;
            trabajoEquipo = tra;
            motivacion = mot;
            percepcionProblemas = per;
            ansiedad = ans;
            respuestaProblema = res;
            frustacion = fru;
            abandonoPersonal = cambPer;
            cambioAnimo = camA;

        }
    }
}
