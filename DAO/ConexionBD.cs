﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class ConexionBD
    {
        public static string CadenaConexion
        {
            get
            {
                return "Data Source=(local);Initial Catalog=BD_AKD_4; integrated security=SSPI;";
                
            }
        }

      

    }
}