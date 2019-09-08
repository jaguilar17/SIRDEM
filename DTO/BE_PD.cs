using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BE_PD
    {
        private int codPrueba0;
        public int CodPrueba0
        {
            get { return codPrueba0; }
            set { codPrueba0 = value; }
        }

        private int paceLargo;

        public int PaceLargo
        {
            get { return paceLargo; }
            set { paceLargo = value; }
        }
        private int conduLinea;

        public int ConduLinea
        {
            get { return conduLinea; }
            set { conduLinea = value; }
        }
        private int conduCar;

        public int ConduCar
        {
            get { return conduCar; }
            set { conduCar = value; }
        }
        private int tiroApueta;

        public int TiroApueta
        {
            get { return tiroApueta; }
            set { tiroApueta = value; }
        }
        private int conduDinamica;

        public int ConduDinamica
        {
            get { return conduDinamica; }
            set { conduDinamica = value; }
        }

        private int tiroPre;

        public int TiroPre
        {
            get { return tiroPre; }
            set { tiroPre = value; }
        }
        private int controlCompañero;

        public int ControlCompañero
        {
            get { return controlCompañero; }
            set { controlCompañero = value; }
        }
        private int impulsoBalon;

        public int ImpulsoBalon
        {
            get { return impulsoBalon; }
            set { impulsoBalon = value; }
        }
        private int lanzamientoApuerta;

        public int LanzamientoApuerta
        {
            get { return lanzamientoApuerta; }
            set { lanzamientoApuerta = value; }
        }

        private int estado1;

        public int Estado1
        {
            get { return estado1; }
            set { estado1 = value; }
        }
        public BE_PD()
        {
            paceLargo=0;
            conduLinea=0;
            conduCar =0;
            tiroApueta =0;
            conduDinamica =0;
            tiroPre = 0;
            controlCompañero =0;
            impulsoBalon =0;
            lanzamientoApuerta = 0;
        }
        public BE_PD(int pa, int condl, int condc,int tiro, int conduD,int tp ,int control,int im, int lan )
        {
            paceLargo= pa;
            conduLinea= condl;
            conduCar =condc;
            tiroApueta =tiro;
            conduDinamica =conduD;
            tiroPre = tp;
            controlCompañero = control;
            impulsoBalon = im;
            lanzamientoApuerta=lan; 
        }
    }
}
