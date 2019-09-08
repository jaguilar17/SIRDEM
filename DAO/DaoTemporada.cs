using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DAO
{
    public class DaoTemporada : DaoB
    {
        public ClassResultV Usp_TemporadaNombres_GetAll(TipoCons tip)
        {
            ClassResultV cr = new ClassResultV();
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@TipoCons", SqlDbType.Int);
                pr[0].Value = (Int32)tip;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_TemporadaNombres_GetAll", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoTemporada dtoC = new DtoTemporada();
                    dtoC.codTemporada = getValue("codTemporada", reader).Value_String;
                    dtoC.temporadaNombre = getValue("temporadaNombre", reader).Value_String;
                    cr.List.Add(dtoC);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar temporadas";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_Temporada_GetAll(TipoCons tip)
        {
            ClassResultV cr = new ClassResultV();
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@TipoCons", SqlDbType.Int);
                pr[0].Value = (Int32)tip;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Temporada_GetAll", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoTemporada dtoT = new DtoTemporada();
                    dtoT.codTemporada = getValue("codTemporada", reader).Value_String;
                    dtoT.temporadaNombre = getValue("temporadaNombre", reader).Value_String;
                    dtoT.temporadaFechaInicio = getValue("temporadaFechaInicio", reader).Value_DateTime;
                    dtoT.temporadaDuracionDias = getValue("temporadaDuracionDias", reader).Value_Int32;
                    dtoT.temporadaFechaFin = getValue("temporadaFechaFin", reader).Value_DateTime;
                    dtoT.IB_Mostrar = getValue("IB_Mostrar", reader).Value_Bool;
                    dtoT.temporadaFechaFin = getValue("temporadaFechaFin", reader).Value_DateTime;
                    cr.List.Add(dtoT);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar las temporadas";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_Temporada_Insert(DtoTemporada dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoTemporada)dtoBase;
            var pr = new SqlParameter[6];

            try
            {
                pr[0] = new SqlParameter("@temporadaNombre", SqlDbType.VarChar, 100);
                pr[0].Value = dto.temporadaNombre;
                pr[1] = new SqlParameter("@temporadaFechaInicio", SqlDbType.Date);
                pr[1].Value = dto.temporadaFechaInicio;
                pr[2] = new SqlParameter("@temporadaDuracionDias", SqlDbType.Int);
                pr[2].Value = dto.temporadaDuracionDias;
                pr[3] = new SqlParameter("@IB_Mostrar", SqlDbType.Bit);
                pr[3].Value = dto.IB_Mostrar;
                pr[4] = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                pr[4].Direction = ParameterDirection.Output;
                pr[5] = new SqlParameter("@temporadaFechaFin", SqlDbType.Date);
                pr[5].Value = dto.temporadaFechaFin;

                SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_Temporada_Insert", pr);
                if (Convert.ToString(pr[4].Value) != "")
                {
                    cr.LugarError = ToString("Usp_Temporada_Insert");
                    cr.ErrorMsj = Convert.ToString(pr[4].Value);
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al registrar la temporada";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_Temporada_Update(DtoTemporada dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoTemporada)dtoBase;
            var pr = new SqlParameter[7];
            try
            {
                pr[0] = new SqlParameter("@temporadaNombre", SqlDbType.VarChar, 100);
                pr[0].Value = dto.temporadaNombre;
                pr[1] = new SqlParameter("@temporadaFechaInicio", SqlDbType.Date);
                pr[1].Value = dto.temporadaFechaInicio;
                pr[2] = new SqlParameter("@temporadaDuracionDias", SqlDbType.Int);
                pr[2].Value = dto.temporadaDuracionDias;
                pr[3] = new SqlParameter("@IB_Mostrar", SqlDbType.Bit);
                pr[3].Value = dto.IB_Mostrar;
                pr[4] = new SqlParameter("@codTemporada", SqlDbType.VarChar, 4);
                pr[4].Value = dto.codTemporada;
                pr[5] = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                pr[5].Direction = ParameterDirection.Output;
                pr[6] = new SqlParameter("@temporadaFechaFin", SqlDbType.Date);
                pr[6].Value = dto.temporadaFechaFin;

                SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_Temporada_Update", pr);
                if (Convert.ToString(pr[5].Value) != "")
                {
                    cr.LugarError = ToString("Usp_Temporada_Update");
                    cr.ErrorMsj = Convert.ToString(pr[5].Value);
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al actualizar la temporada.";
                objCn.Close();
            }
            return dto;
        }
    }
}
