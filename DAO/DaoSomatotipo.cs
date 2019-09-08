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
    public class DaoSomatotipo:DaoB
    {
        public ClassResultV Usp_Somatotipo_Insert(DtoSomatotipo dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoSomatotipo)dtoBase;
            var pr = new SqlParameter[6];
            try
            {
                pr[0] = new SqlParameter("@ectomorfia", SqlDbType.Decimal);
                pr[0].Value = V_ValidaPrNull(dto.ectomorfia);
                pr[1] = new SqlParameter("@mesomorfia", SqlDbType.Decimal);
                pr[1].Value = V_ValidaPrNull(dto.mesomorfia);
                pr[2] = new SqlParameter("@endomorfia", SqlDbType.Decimal);
                pr[2].Value = V_ValidaPrNull(dto.endomorfia);
                pr[3] = new SqlParameter("@codDatosAntropo", SqlDbType.VarChar,4);
                pr[3].Value = dto.codDatosAntropo;
                pr[4] = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                pr[4].Direction = ParameterDirection.Output;
                pr[5] = new SqlParameter("@codSomatotipo", SqlDbType.VarChar, 4);
                pr[5].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_Somatotipo_Insert", pr);
                dto.codSomatotipo = Convert.ToString(pr[5].Value);
                if (Convert.ToString(pr[4].Value) != "")
                {
                    cr.LugarError = ToString("Usp_Somatotipo_Insert");
                    cr.ErrorMsj = Convert.ToString(pr[4].Value);
                }
                else { }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al registrar datos antropometricos - somatotipo";
            }

            objCn.Close();
            return cr;
        }
    }
}
