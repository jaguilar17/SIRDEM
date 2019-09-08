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
    public class DA_PruebaPF
    {
          SqlConnection conexion;

        public DA_PruebaPF()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }
        public void InsertarPPF(BE_PF pcFi)
        {

            SqlCommand unComando = new SqlCommand("sp_RegistrarPPF", conexion);
            unComando.CommandType = CommandType.StoredProcedure;

            unComando.Parameters.AddWithValue("@vel50m", pcFi.Vel50m);
            unComando.Parameters.AddWithValue("@ti2000m", pcFi.Ti2000m);
            unComando.Parameters.AddWithValue("@alturasalto", pcFi.Alturasalto);
            unComando.Parameters.AddWithValue("@disLanzar", pcFi.DisLanzar);
            unComando.Parameters.AddWithValue("@vel500m", pcFi.Vel500m);
            unComando.Parameters.AddWithValue("@cantflexion", pcFi.Cantflexion);
            unComando.Parameters.AddWithValue("@repeticionV15s", pcFi.RepeticionV15s);
            unComando.Parameters.AddWithValue("@repeticionV1m", pcFi.RepeticionV1m);
            unComando.Parameters.AddWithValue("@canSalto", pcFi.CanSalto);
            unComando.Parameters.AddWithValue("@aceSp20m", pcFi.AceSp20m);
            unComando.Parameters.AddWithValue("@aceSl30m", pcFi.AceSl30m);


           
            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();

        }
    }
    
}
