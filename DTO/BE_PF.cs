using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
        
    public class BE_PF
    {
        private int codPrueba1;
        public int CodPrueba1
        {
            get { return codPrueba1; }
            set { codPrueba1 = value; }
        }

        private float vel50m;
        
        public float Vel50m
        {
            get { return vel50m; }
            set { vel50m = value; }
        }
        private float ti2000m;

        public float Ti2000m
        {
            get { return ti2000m; }
            set { ti2000m = value; }
        }
        private int alturasalto;

        public int Alturasalto
        {
            get { return alturasalto; }
            set { alturasalto = value; }
        }
        private float disLanzar;

        public float DisLanzar
        {
            get { return disLanzar; }
            set { disLanzar = value; }
        }
        private float vel500m;

        public float Vel500m
        {
            get { return vel500m; }
            set { vel500m = value; }
        }
        private int cantflexion;

        public int Cantflexion
        {
            get { return cantflexion; }
            set { cantflexion = value; }
        }
        private int repeticionV15s;

        public int RepeticionV15s
        {
            get { return repeticionV15s; }
            set { repeticionV15s = value; }
        }
        private int repeticionV1m;

        public int RepeticionV1m
        {
            get { return repeticionV1m; }
            set { repeticionV1m = value; }
        }
        private int canSalto;

        public int CanSalto
        {
            get { return canSalto; }
            set { canSalto = value; }
        }
        private float aceSp20m;

        public float AceSp20m
        {
            get { return aceSp20m; }
            set { aceSp20m = value; }
        }
        private float aceSl30m;

        public float AceSl30m
        {
            get { return aceSl30m; }
            set { aceSl30m = value; }
        }
        private int estado2;

        public int Estado2
        {
            get { return estado2; }
            set { estado2 = value; }
        }
         public BE_PF()
        {
           vel50m=0.0f ;
           ti2000m = 0.0f;
	        alturasalto=0  ;
            disLanzar = 0.0f;
            vel500m = 0.0f;
	        cantflexion=0  ;
	        repeticionV15s=0  ;
	         repeticionV1m =0 ;
	        canSalto=0  ;
            aceSp20m = 0.0f;
            aceSl30m = 0.0f;
             
        }
        public BE_PF(float v50,float t,int a,float dis,float vel500,int fle,int rev15s,int rev1m,int cansal,float ace20,float ace30 )
        {
            vel50m=v50;
            ti2000m=t;
            alturasalto=a;
            disLanzar=dis;
            vel500m=vel500;
            cantflexion=fle;
            repeticionV15s=rev15s;
            repeticionV1m=rev1m;
            canSalto=cansal;
            aceSp20m=ace20;
            aceSl30m=ace30;
        }
    }
}
