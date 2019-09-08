using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.ApplicationBlocks.Data;

namespace DAO
{
    public class DaoPosicion : DaoB
    {
        public ClassResultV Usp_Posicion_GetAll()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Posicion_GetAll");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoPosicion dtoP = new DtoPosicion();
                    dtoP.codPosicion = getValue("codPosicion", reader).Value_String;
                    dtoP.descripcionPosicion = getValue("descripcionPosicion", reader).Value_String;
                    cr.List.Add(dtoP);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar Posiciones";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_PosicionPrincipal_All()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_PosicionPrincipal_All");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoPosicion dtoP = new DtoPosicion();
                    dtoP.codPosicion = getValue("codPosicion", reader).Value_String;
                    dtoP.descripcionPosicion = getValue("descripcionPosicion", reader).Value_String;
                    cr.List.Add(dtoP);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar Posiciones Principales";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_PosicionAlternativa_All()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_PosicionAlternativa_All");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoPosicion dtoP = new DtoPosicion();
                    dtoP.codPosicion = getValue("codPosicion", reader).Value_String;
                    dtoP.descripcionPosicion = getValue("descripcionPosicion", reader).Value_String;
                    cr.List.Add(dtoP);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar Posiciones Alternativas";
            }
            objCn.Close();
            return cr;
        }
    }
}
