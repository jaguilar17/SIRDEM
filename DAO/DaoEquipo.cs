using DTO;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoEquipo : DaoB
    {
        public ClassResultV Usp_GetEquipoByCodTemporada(TipoCons tip, DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            var dto = (DtoEquipo)dtoBase;
            SqlParameter[] pr = new SqlParameter[2];
            try
            {
                pr[0] = new SqlParameter("@TipoCons", SqlDbType.Int);
                pr[0].Value = tip;
                pr[1] = new SqlParameter("@codTemporada", SqlDbType.VarChar, 4);
                pr[1].Value = dto.codTemporada;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_GetEquipoByCodTemporada", pr);

                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    var dtoProc = new DtoEquipo();
                    dtoProc.codEquipo = getValue("codEquipo", reader).Value_String;
                    dtoProc.equipoNombre = getValue("equipoNombre", reader).Value_String;
                    dtoProc.IB_Mostrar = getValue("IB_Mostrar", reader).Value_Bool;
                    dtoProc.codTemporada = getValue("codTemporada", reader).Value_String;
                    dtoProc.temporadaNombre = getValue("temporadaNombre", reader).Value_String;
                    cr.List.Add(dtoProc);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar equipos.";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_EquipoNombres_GetAll(TipoCons tip)
        {
            ClassResultV cr = new ClassResultV();
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@TipoCons", SqlDbType.Int);
                pr[0].Value = (Int32)tip;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_EquipoNombres_GetAll", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoEquipo dtoC = new DtoEquipo();
                    dtoC.codEquipo = getValue("codEquipo", reader).Value_String;
                    dtoC.equipoNombre = getValue("equipoNombre", reader).Value_String;
                    cr.List.Add(dtoC);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar equipos";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_Equipo_GetAll(TipoCons tip)
        {
            ClassResultV cr = new ClassResultV();
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@TipoCons", SqlDbType.Int);
                pr[0].Value = (Int32)tip;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Equipo_GetAll", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoEquipo dtoE = new DtoEquipo();
                    dtoE.codEquipo = getValue("codEquipo", reader).Value_String;
                    dtoE.equipoNombre = getValue("equipoNombre", reader).Value_String;
                    dtoE.equipoDescripcion = getValue("equipoDescripcion", reader).Value_String;
                    dtoE.equipoDirectorTecnico = getValue("equipoDirectorTecnico", reader).Value_String;
                    dtoE.equipoAsistenteTecnico = getValue("equipoAsistenteTecnico", reader).Value_String;
                    dtoE.numMaxJugador = getValue("numMaxJugador", reader).Value_Int32;
                    dtoE.IB_Mostrar = getValue("IB_Mostrar", reader).Value_Bool;
                    dtoE.codTemporada = getValue("codTemporada", reader).Value_String;
                    dtoE.temporadaNombre = getValue("temporadaNombre", reader).Value_String;
                    cr.List.Add(dtoE);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar Equipos";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_Equipo_Insert(DtoEquipo dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoEquipo)dtoBase;
            var pr = new SqlParameter[8];

            try
            {
                pr[0] = new SqlParameter("@equipoNombre", SqlDbType.VarChar, 100);
                pr[0].Value = dto.equipoNombre;
                pr[1] = new SqlParameter("@equipoDescripcion", SqlDbType.VarChar, 100);
                pr[1].Value = dto.equipoDescripcion;
                pr[2] = new SqlParameter("@equipoDirectorTecnico", SqlDbType.VarChar, 100);
                pr[2].Value = dto.equipoDirectorTecnico;
                pr[3] = new SqlParameter("@equipoAsistenteTecnico", SqlDbType.VarChar, 100);
                pr[3].Value = dto.equipoAsistenteTecnico;
                pr[4] = new SqlParameter("@numMaxJugador", SqlDbType.Int);
                pr[4].Value = dto.numMaxJugador;
                pr[5] = new SqlParameter("@IB_Mostrar", SqlDbType.Bit);
                pr[5].Value = dto.IB_Mostrar;
                pr[6] = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                pr[6].Direction = ParameterDirection.Output;
                pr[7] = new SqlParameter("@codTemporada", SqlDbType.VarChar, 4);
                pr[7].Value = dto.codTemporada;
               
                SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_Equipo_Insert", pr);
                if (Convert.ToString(pr[6].Value) != "")
                {
                    cr.LugarError = ToString("Usp_Equipo_Insert");
                    cr.ErrorMsj = Convert.ToString(pr[6].Value);
                }
                else { }

            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al registrar Equipos";
            }

            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_Equipo_Update(DtoEquipo dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoEquipo)dtoBase;
            var pr = new SqlParameter[9];

            try
            {
                pr[0] = new SqlParameter("@equipoNombre", SqlDbType.VarChar, 100);
                pr[0].Value = dto.equipoNombre;
                pr[1] = new SqlParameter("@equipoDescripcion", SqlDbType.VarChar, 100);
                pr[1].Value = dto.equipoDescripcion;
                pr[2] = new SqlParameter("@equipoDirectorTecnico", SqlDbType.VarChar, 100);
                pr[2].Value = dto.equipoDirectorTecnico;
                pr[3] = new SqlParameter("@equipoAsistenteTecnico", SqlDbType.VarChar, 100);
                pr[3].Value = dto.equipoAsistenteTecnico;
                pr[4] = new SqlParameter("@numMaxJugador", SqlDbType.Int);
                pr[4].Value = dto.numMaxJugador;
                pr[5] = new SqlParameter("@IB_Mostrar", SqlDbType.Bit);
                pr[5].Value = dto.IB_Mostrar;
                pr[6] = new SqlParameter("@codEquipo", SqlDbType.VarChar, 4);
                pr[6].Value = dto.codEquipo;
                pr[7] = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                pr[7].Direction = ParameterDirection.Output;
                pr[8] = new SqlParameter("@codTemporada", SqlDbType.VarChar, 4);
                pr[8].Value = dto.codTemporada;

                SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_Equipo_Update", pr);
                if (Convert.ToString(pr[7].Value) != "")
                {
                    cr.LugarError = ToString("Usp_Equipo_Update");
                    cr.ErrorMsj = Convert.ToString(pr[7].Value);
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al actualizar el equipo.";
                objCn.Close();
            }
            return dto;
        }
        public ClassResultV Usp_EstadoEquipoByCupos_Update(DtoEquipo dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoEquipo)dtoBase;
            var pr = new SqlParameter[3];

            try
            {
                pr[0] = new SqlParameter("@codEquipo", SqlDbType.VarChar, 4);
                pr[0].Value = dto.codEquipo;
                pr[1] = new SqlParameter("@IB_Mostrar", SqlDbType.Bit);
                pr[1].Value = dto.IB_Mostrar;
                pr[2] = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                pr[2].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_EstadoEquipoByCupos_Update", pr);
                if (Convert.ToString(pr[2].Value) != "")
                {
                    cr.LugarError = ToString("Usp_EstadoEquipoByCupos_Update");
                    cr.ErrorMsj = Convert.ToString(pr[2].Value);
                }
                else 
                {

                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al actualizar el estado del equipo.";
                objCn.Close();
            }
            return cr;
        }
        /*
       

       

      
        public ClassResultV Usp_EquipoClub_GetAll(TipoCons tip)
        {
            ClassResultV cr = new ClassResultV();
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@TipoCons", SqlDbType.Int);
                pr[0].Value = (Int32)tip;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_EquipoClub_GetAll", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoEquipo dtoE = new DtoEquipo();
                    dtoE.codEquipo = getValue("codEquipo", reader).Value_String;
                    dtoE.nombre = getValue("nombre", reader).Value_String;
                    cr.List.Add(dtoE);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar Equipos";
            }
            objCn.Close();
            return cr;
        }
         */
    }
}
