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
    public class DA_Nota_Informes
    {
        private SqlCommand mCm;
        private SqlDataAdapter mDa;
        private DataSet mdd;

        SqlConnection conexion = new SqlConnection(ConexionBD.CadenaConexion);

        
        public bool SelectPrueba(BE_Prueba objp )
        {
            string select = "SELECT encargadoPrueba, dia, hora, lugar, observacion, resultado FROM   Prueba where codPrueba='" + objp.CodPrueba+ "'";
            SqlCommand unComando = new SqlCommand(select, conexion);
            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                    objp.Encargado = (string)reader[0];
                    objp.Dia=(DateTime)reader[1];    
                    objp.Hora=(string)reader[2];
                    objp.Lugar=(string)reader[3];
                    objp.Observacion=(string)reader[4];
                    objp.Resultado=(string)reader[5];
                    objp.Estado0=99;
            }
            else objp.Estado0=1;
            conexion.Close();
            return hayRegistros;
        }

        public bool SelectPruebaD(BE_PD objp)
        {
            string select = "SELECT  paceLargo, conduLinea, conduCar, tiroApueta, conduDinamica, tiroPre, controlCompañero, impulsoBalon, lanzamientoApuerta FROM   PruebaDesempeño where codPrueba='" + objp.CodPrueba0 + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);
            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objp.PaceLargo = (int)reader[0];
                objp.ConduLinea = (int)reader[1];
                objp.ConduCar = (int)reader[2];
                objp.TiroApueta = (int)reader[3];
                objp.ConduDinamica=(int)reader[4];
                objp.TiroPre = (int)reader[5];
                objp.ControlCompañero = (int)reader[6];
                objp.ImpulsoBalon = (int)reader[7];
                objp.LanzamientoApuerta = (int)reader[8];
                objp.Estado1=99;
            }
            else objp.Estado1=1;
                conexion.Close();
            return hayRegistros;
        }

        public bool SelectPruebaF(BE_PF objp)
        {
            string select = "SELECT  vel50m, ti2000m, alturasalto, disLanzar, vel500m, cantflexion, repeticionV15s, repeticionV1m, canSalto, aceSp20m, aceSl30m FROM   PruebaFisica  where codPrueba='" + objp.CodPrueba1 + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);
            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objp.Vel50m = (float)(double)reader[0];
                objp.Ti2000m = (float)(double)reader[1];
                objp.Alturasalto = (int)reader[2];
                objp.DisLanzar = (float)(double)reader[3];
                objp.Vel500m = (float)(double)reader[4];
                objp.Cantflexion = (int)reader[5];
                objp.RepeticionV15s = (int)reader[6];
                objp.RepeticionV1m = (int)reader[7];
                objp.CanSalto = (int)reader[8];
                objp.AceSp20m = (float)(double)reader[9];
                objp.AceSl30m = (float)(double)reader[10];
               objp.Estado2=99;
            }
            else objp.Estado2=1;
                conexion.Close();

            return hayRegistros;
        }

        public bool SelectPruebaPS(BE_PS objp)
        {
            string select = "SELECT  irritabilidad, concentracion, bloqueoMental, trabajoEquipo, motivacion, percepcionProblemas, ansiedad, respuestaProblema, frustacion, abandonoPersonal, cambioAnimo FROM    PruebaPsicologica where codPrueba='" + objp.CodPrueba2 + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);
            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objp.Irritabilidad = (string)reader[0];
                objp.Concentracion = (string)reader[1];
                objp.BloqueoMental = (string)reader[2];
                objp.TrabajoEquipo = (string)reader[3];
                objp.Motivacion = (string)reader[4];
                objp.PercepcionProblemas = (string)reader[5];
                objp.Ansiedad = (string)reader[6];
                objp.RespuestaProblema = (string)reader[7];
                objp.Frustacion = (string)reader[8];
                objp.AbandonoPersonal = (string)reader[9];
                objp.CambioAnimo = (string)reader[10];
               objp.Estado3=99;
            }
            else objp.Estado3=1;
                conexion.Close();

            return hayRegistros;
        }
    }
}
