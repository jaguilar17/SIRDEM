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
    public class DaoSomatocarta : DaoB
    {
        public ClassResultV Usp_Somatocarta_Insert(DtoSomatocarta dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoSomatocarta)dtoBase;
            var pr = new SqlParameter[4];
            try
            {
                pr[0] = new SqlParameter("@ejeX", SqlDbType.Decimal);
                pr[0].Value = V_ValidaPrNull(dto.ejeX);
                pr[1] = new SqlParameter("@ejeY", SqlDbType.Decimal);
                pr[1].Value = V_ValidaPrNull(dto.ejeY);
                pr[2] = new SqlParameter("@codSomatotipo", SqlDbType.VarChar, 4);
                pr[2].Value = dto.codSomatotipo;
                pr[3] = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                pr[3].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_Somatocarta_Insert", pr);
                if (Convert.ToString(pr[3].Value) != "")
                {
                    cr.LugarError = ToString("Usp_Somatocarta_Insert");
                    cr.ErrorMsj = Convert.ToString(pr[3].Value);
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
