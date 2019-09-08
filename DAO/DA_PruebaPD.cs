using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DA_PruebaPD
    {
         SqlConnection conexion;

        public DA_PruebaPD()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }
        public void InsertarPPD(BE_PD pcDO)
        {

            SqlCommand unComando = new SqlCommand("sp_RegistrarPPD", conexion);
            unComando.CommandType = CommandType.StoredProcedure;

            unComando.Parameters.AddWithValue("@paceLargo", pcDO.PaceLargo);
            unComando.Parameters.AddWithValue("@conduLinea", pcDO.ConduLinea);
            unComando.Parameters.AddWithValue("@conduCar", pcDO.ConduCar);
            unComando.Parameters.AddWithValue("@tiroApueta", pcDO.TiroApueta);
            unComando.Parameters.AddWithValue("@conduDinamica", pcDO.ConduDinamica);
            unComando.Parameters.AddWithValue("@tiroPre", pcDO.TiroPre);
            unComando.Parameters.AddWithValue("@controlCompañero", pcDO.ControlCompañero);
            unComando.Parameters.AddWithValue("@impulsoBalon", pcDO.ImpulsoBalon);
            unComando.Parameters.AddWithValue("@lanzamientoApuerta", pcDO.LanzamientoApuerta);
            
           
            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();

        }
    }
}
