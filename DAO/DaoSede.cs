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
    public class DaoSede : DaoB
    {
        private SqlDataAdapter mDa;
        private DataSet mdd;
        SqlConnection conexion;

        public DaoSede()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }

        public DtoSede Usp_Sede_Insert(DtoSede objSede)
        {
            var cr = new ClassResultV();
            var dto = (DtoSede)objSede;
            var pr = new SqlParameter[6];
            try
            {
                pr[0] = new SqlParameter("@nombre", SqlDbType.VarChar, 250);
                pr[0].Value = dto.Nombre;
                pr[1] = new SqlParameter("@direccion", SqlDbType.VarChar, 250);
                pr[1].Value = dto.Direccion;
                pr[2] = new SqlParameter("@referencia", SqlDbType.VarChar, 250);
                pr[2].Value = dto.Referencia;
                pr[3] = new SqlParameter("@fechainicio", SqlDbType.Date);
                pr[3].Value = dto.FechaIncio;
                pr[4] = new SqlParameter("@fechafin", SqlDbType.Date);
                pr[4].Value = dto.FechaFin;
                pr[5] = new SqlParameter("@costo", SqlDbType.Float);
                pr[5].Value = dto.Costo;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_RegistrarSede", pr);
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al registrar sede";
            }
            objCn.Close();
            return dto;
        }

        public DtoSede Usp_Sede_Update(DtoSede objSede)
        {
            var cr = new ClassResultV();
            var dto = (DtoSede)objSede;
            var pr = new SqlParameter[7];
            try
            {
                pr[0] = new SqlParameter("@idSede", SqlDbType.Int);
                pr[0].Value = dto.IdSede;
                pr[1] = new SqlParameter("@nombre", SqlDbType.VarChar, 250);
                pr[1].Value = dto.Nombre;
                pr[2] = new SqlParameter("@direccion", SqlDbType.VarChar, 250);
                pr[2].Value = dto.Direccion;
                pr[3] = new SqlParameter("@referencia", SqlDbType.VarChar, 250);
                pr[3].Value = dto.Referencia;
                pr[4] = new SqlParameter("@fechainicio", SqlDbType.Date);
                pr[4].Value = dto.FechaIncio;
                pr[5] = new SqlParameter("@fechafin", SqlDbType.Date);
                pr[5].Value = dto.FechaFin;
                pr[6] = new SqlParameter("@costo", SqlDbType.Float);
                pr[6].Value = dto.Costo;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_ActualizarSede", pr);
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al actualizar sede";
            }
            objCn.Close();
            return dto;
        }

        public DtoSede Usp_Sede_Delete(DtoSede objSede)
        {
            var cr = new ClassResultV();
            var dto = (DtoSede)objSede;
            var pr = new SqlParameter[7];
            try
            {
                pr[0] = new SqlParameter("@idSede", SqlDbType.Int);
                pr[0].Value = dto.IdSede;
                pr[1] = new SqlParameter("@nombre", SqlDbType.VarChar, 250);
                pr[1].Value = dto.Nombre;
                pr[2] = new SqlParameter("@direccion", SqlDbType.VarChar, 250);
                pr[2].Value = dto.Direccion;
                pr[3] = new SqlParameter("@referencia", SqlDbType.VarChar, 250);
                pr[3].Value = dto.Referencia;
                pr[4] = new SqlParameter("@fechainicio", SqlDbType.Date);
                pr[4].Value = dto.FechaIncio;
                pr[5] = new SqlParameter("@fechafin", SqlDbType.Date);
                pr[5].Value = dto.FechaFin;
                pr[6] = new SqlParameter("@costo", SqlDbType.Float);
                pr[6].Value = dto.Costo;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_EliminarSede", pr);
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al eliminar sede";
            }
            objCn.Close();
            return dto;
        }

        public ClassResultV Consultar_Sede()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_Consultar_Jugadores");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoSede dtoS = new DtoSede();
                    dtoS.IdSede = getValue("idSede", reader).Value_Int32;
                    dtoS.Nombre = getValue("nombre", reader).Value_String;
                    cr.List.Add(dtoS);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar las Personas";
            }
            objCn.Close();
            return cr;
        }

        public DataTable SelectSedes()
        {
            try
            {
                mDa = new SqlDataAdapter("pa_SelectSedes", conexion);
                mDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                mdd = new DataSet();
                mDa.Fill(mdd);
                return mdd.Tables[0];
            }
            catch (Exception ex1)
            {
                throw ex1;
            }
        }


        public DataSet SelectSede()
        {
            SqlDataAdapter da = new SqlDataAdapter("pa_SelectSede", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet dsAsuntos = new DataSet();
            da.Fill(dsAsuntos, "Sede");
            return dsAsuntos;
        }

        public bool SelectBuscarSede(DtoSede objSe)
        {
            String cone = "Select * from T_Sede where idSede = " + objSe.IdSede;
            SqlCommand unComando = new SqlCommand(cone, conexion);

            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();

            bool HayRegistros = reader.Read();

            if (HayRegistros)
            {
                objSe.Nombre = (string)reader[1];
                objSe.Direccion = (string)reader[2];
                objSe.Referencia = (string)reader[3];
                objSe.FechaIncio = (DateTime)reader[4];
                objSe.FechaFin = (DateTime)reader[5];
                objSe.Costo = float.Parse(reader[6].ToString());
                objSe.Estado = 99;
            }
            else objSe.Estado = 1;

            conexion.Close();

            return HayRegistros;
        }
    }
}
