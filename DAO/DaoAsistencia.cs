using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace DAO 
{
   public class DaoAsistencia : DaoB
    {
        protected Conexion con = new Conexion();
        SqlConnection cn;

        public DaoAsistencia()
        {
            cn = new SqlConnection(con.StrCon);
        }
       //INSERTAR
        public DtoAsistencia Insertar_Asistencia(DtoAsistencia dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoAsistencia)dtoBase;
            var pr = new SqlParameter[3];
            DtoAsistencia dtoA = dto;

            try
            {
                pr[0] = new SqlParameter("@codJugador", SqlDbType.VarChar, 50);
                pr[0].Value = dtoA.codJugador;
                pr[1] = new SqlParameter("@codHorarioEntrenamiento", SqlDbType.Int);
                pr[1].Value = dtoA.codHorarioEntrenamiento;
                pr[2] = new SqlParameter("@asistencia", SqlDbType.Char, 1);
                pr[2].Value = dtoA.asistencia;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_Insertar_Asistencia", pr);
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al registrar Asistencia";
            }

            objCn.Close();
            return dtoA;
        }
        
        //Modificar
        public DtoAsistencia Modificar_Asistencia(DtoAsistencia dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoAsistencia)dtoBase;
            var pr = new SqlParameter[3];
            try
            {
                pr[0] = new SqlParameter("@codJugador", SqlDbType.VarChar, 50);
                pr[0].Value = dto.codJugador;
                pr[1] = new SqlParameter("@codHorarioEntrenamiento", SqlDbType.Int);
                pr[1].Value = dto.codHorarioEntrenamiento;
                pr[2] = new SqlParameter("@asistencia", SqlDbType.Char, 1);
                pr[2].Value = dto.asistencia;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_Modificar_Asistencia", pr);
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al registrar persona";
            }
            objCn.Close();
            return dto;
        }


       //Consultar Asistencia para Modificar
        public ClassResultV Consultar_Jugadores_Asistencia(string codigo)
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
			    {
                    new SqlParameter("@codHorario", codigo)
			    };
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_Consultar_Jugadores_Asistencia", parameters);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoAsistencia dtoP = new DtoAsistencia();
                    dtoP.codJugador = getValue("codJugador", reader).Value_String;
                    dtoP.nombresyap = getValue("nombresyap", reader).Value_String;
                    dtoP.asistencia = getValue("asistencia", reader).Value_String;                    
                    cr.List.Add(dtoP);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar Asistencia";
            }
            objCn.Close();
            return cr;
        }

    }
}
