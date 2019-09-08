using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoPerfil : DaoB
    {
        public ClassResultV Usp_Perfil_GetAll()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Perfil_GetAll");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoPerfil dtoP = new DtoPerfil();
                    dtoP.codPerfil = getValue("codPerfil", reader).Value_Int32;
                    dtoP.descripcion = getValue("descripcion", reader).Value_String;
                    cr.List.Add(dtoP);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar Perfiles";
            }
            objCn.Close();
            return cr;
        }

        public DtoPerfil Usp_Perfil_Insert(DtoPerfil dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoPerfil)dtoBase;
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@descripcion", SqlDbType.VarChar, 500);
                pr[0].Value = dto.descripcion;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Perfil_Insert", pr);
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al registrar perfil";
            }
            objCn.Close();
            return dto;
        }
    }
}
