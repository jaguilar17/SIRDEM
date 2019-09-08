using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Conexion
    {
        public static string strCon;

        //private static string ipServer = @"SCAPP"; //Hosting
        public string StrCon
        {
            get { return strCon; }
            set { strCon = value; }
        }

        #region Conexion
        public Conexion()
        {
            //strCon = "Data Source=NESTOR-PC-PC\\ALMEYDA;Initial Catalog=BD_AKD_2;integrated security=SSPI;";
            //strCon = "Data Source=(local);Initial Catalog=BD_AKD_2; User Id=sa; Password=anthony";
            strCon = "Data Source=(local);Initial Catalog=BD_AKD_4; integrated security=SSPI;";
            //strCon = "workstation id=BDAKDv2.mssql.somee.com;packet size=4096;user id=trvca_SQLLogin_3;pwd=7hfr3k76kb;data source=BDAKDv2.mssql.somee.com;persist security info=False;initial catalog=BDAKDv2";
            
            //strCon = "Data Source=" + ipServer + ";Initial Catalog=BD_SIG_2; User Id=U_SIG; Password=nomeacuerdo;";
        }
        #endregion
    }
}
