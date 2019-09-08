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
    public class DaoCategoriaGeneral : DaoB
    {
        public ClassResultV Usp_CategoriaGeneral_GetAll(TipoCons tip)
        {
            ClassResultV cr = new ClassResultV();
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@TipoCons", SqlDbType.Int);
                pr[0].Value = (Int32)tip;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_CategoriaGeneral_GetAll", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoCategoriaGeneral dtoC = new DtoCategoriaGeneral();
                    dtoC.codCategGen = getValue("codCategGen", reader).Value_String;
                    dtoC.nombreCategGen = getValue("nombreCategGen", reader).Value_String;
                    dtoC.IB_Mostrar = getValue("IB_Mostrar", reader).Value_Bool;
                    cr.List.Add(dtoC);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar Categorias Generales";
            }
            objCn.Close();
            return cr;
        }
    }
}
