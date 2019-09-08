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
    public class DA_Prueba
    {
        private SqlCommand mCm;
        private SqlDataAdapter mDa;
        private DataSet mdd;

        SqlConnection conexion = new SqlConnection(Conexion.strCon);
        
        public DataTable SelectJugador()
        {
            try
            {
                mDa = new SqlDataAdapter("sp_SelectJugadorClub", conexion);
                mDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                mdd = new DataSet();
                mDa.Fill(mdd);
                return mdd.Tables[0];
            }
            catch (Exception ex1)
            {
                throw ex1;
            }
            
        
        }
        
        public DataTable cosultarPrueba(DTO.BE_Jugador jug) 
        {
            try
            {
                mDa= new SqlDataAdapter("sp_SelectPruebaJugador",conexion);
                mDa.SelectCommand.CommandType=CommandType.StoredProcedure;
                mDa.SelectCommand.Parameters.AddWithValue("@codJugador",jug.Codjugador);
                mDa.SelectCommand.CommandType=CommandType.StoredProcedure;
                mdd= new DataSet();
                mDa.Fill(mdd);
                return mdd.Tables[0];
            }
            catch(Exception ex2)
            {
                throw ex2;
            }
        }
        
       public void InsertarPrueba(BE_Prueba objpru)
        {

            SqlCommand unComando = new SqlCommand("sp_RegistrarPrueba", conexion);
            unComando.CommandType = CommandType.StoredProcedure;

            unComando.Parameters.AddWithValue("@dia", objpru.Dia);
            unComando.Parameters.AddWithValue("@hora", objpru.Hora);
            unComando.Parameters.AddWithValue("@lugar", objpru.Lugar);
            unComando.Parameters.AddWithValue("@encargadoPrueba", objpru.Encargado);
            unComando.Parameters.AddWithValue("@observacion", objpru.Observacion);
            unComando.Parameters.AddWithValue("@codJugador", objpru.CodJugador);
            unComando.Parameters.AddWithValue("@resultado", objpru.Resultado);
            unComando.Parameters.AddWithValue("@descripcionGeneral", objpru.DescripcionGeneral);
            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();

        }

        
    }
}
