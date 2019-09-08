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
    public class DaoCategoria : DaoB
    {
        public ClassResultV Usp_Categoria_GetAll(TipoCons tip)
        {
            ClassResultV cr = new ClassResultV();
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@TipoCons", SqlDbType.Int);
                pr[0].Value = (Int32)tip;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Categoria_GetAll", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoCategoria dtoC = new DtoCategoria();
                    dtoC.codCategoria = getValue("codCategoria", reader).Value_String;
                    dtoC.nombre = getValue("nombre", reader).Value_String;
                    dtoC.IB_Mostrar = getValue("IB_Mostrar", reader).Value_Bool;
                    cr.List.Add(dtoC);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar Categorias";
            }
            objCn.Close();
            return cr;
        }

        public ClassResultV Usp_Categoria_Insert(DtoCategoria dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoCategoria)dtoBase;
            var pr = new SqlParameter[3];
            try
            {
                pr[0] = new SqlParameter("@nombre", SqlDbType.VarChar, 100);
                pr[0].Value = dto.nombre;
                pr[1] = new SqlParameter("@IB_Mostrar", SqlDbType.Bit);
                pr[1].Value = dto.IB_Mostrar;
                pr[2] = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                pr[2].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_Categoria_Insert", pr);
                if (Convert.ToString(pr[2].Value) != "")
                {
                    cr.LugarError = ToString("Usp_Categoria_Insert");
                    cr.ErrorMsj = Convert.ToString(pr[2].Value);
                }
                else { }

            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al registrar Categoria";
            }

            objCn.Close();
            return cr;
        }

        public ClassResultV Usp_Categoria_Update(DtoCategoria dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoCategoria)dtoBase;
            var pr = new SqlParameter[4];
            try
            {
                pr[0] = new SqlParameter("@nombre", SqlDbType.VarChar, 100);
                pr[0].Value = dto.nombre;
                pr[1] = new SqlParameter("@IB_Mostrar", SqlDbType.Bit);
                pr[1].Value = dto.IB_Mostrar;
                pr[2] = new SqlParameter("@codCategoria", SqlDbType.VarChar, 4);
                pr[2].Value = dto.codCategoria;
                pr[3] = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                pr[3].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_Categoria_Update", pr);
                if (Convert.ToString(pr[3].Value) != "")
                {
                    cr.LugarError = ToString("Usp_Categoria_Update");
                    cr.ErrorMsj = Convert.ToString(pr[3].Value);
                }
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al actualizar la categoria.";
                objCn.Close();
            }
            return dto;
        }
    }
}
