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
    public class DA_PruebaPS
    {
        SqlConnection conexion;

        public DA_PruebaPS()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }

        public void InsertarPPS2(BE_PS pcPsico)
        {

            SqlCommand unComando = new SqlCommand("sp_RegistrarPPS", conexion);
            unComando.CommandType = CommandType.StoredProcedure;

            unComando.Parameters.AddWithValue("@irritabilidad", pcPsico.Irritabilidad);
            unComando.Parameters.AddWithValue("@concentracion", pcPsico.Concentracion);
            unComando.Parameters.AddWithValue("@bloqueoMental", pcPsico.BloqueoMental);
            unComando.Parameters.AddWithValue("@trabajoEquipo", pcPsico.TrabajoEquipo);
            unComando.Parameters.AddWithValue("@motivacion", pcPsico.Motivacion);
            unComando.Parameters.AddWithValue("@percepcionProblemas", pcPsico.PercepcionProblemas);
            unComando.Parameters.AddWithValue("@ansiedad", pcPsico.Ansiedad);
            unComando.Parameters.AddWithValue("@respuestaProblema", pcPsico.RespuestaProblema);
            unComando.Parameters.AddWithValue("@frustacion", pcPsico.Frustacion);
            unComando.Parameters.AddWithValue("@abandonoPersonal", pcPsico.AbandonoPersonal);
            unComando.Parameters.AddWithValue("@cambioAnimo", pcPsico.CambioAnimo);
            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();



        }
    }
}
