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
    public class DaoPersona : DaoB
    {
        protected Conexion con = new Conexion();
        SqlConnection cn;

        public DaoPersona()
        {
            cn = new SqlConnection(con.StrCon);
        }

        public DtoPersona Usp_Persona_Insert(DtoPersona dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoPersona)dtoBase;
            var pr = new SqlParameter[11];
            try
            {
                pr[0] = new SqlParameter("@personaNombre", SqlDbType.VarChar, 50);
                pr[0].Value = dto.personaNombre;
                pr[1] = new SqlParameter("@personaApePaterno", SqlDbType.VarChar, 50);
                pr[1].Value = dto.personaApePaterno;
                pr[2] = new SqlParameter("@personaApeMaterno", SqlDbType.VarChar, 50);
                pr[2].Value = dto.personaApeMaterno;
                pr[3] = new SqlParameter("@personaFechaNac", SqlDbType.Date);
                pr[3].Value = dto.personaFechaNac;
                pr[4] = new SqlParameter("@personaNumDNI", SqlDbType.Int);
                pr[4].Value = dto.personaNumDNI;
                pr[5] = new SqlParameter("@personaTelefono", SqlDbType.Int);
                pr[5].Value = dto.personaTelefono;
                pr[6] = new SqlParameter("@personaCorreo", SqlDbType.VarChar, 50);
                pr[6].Value = dto.personaCorreo;
                pr[7] = new SqlParameter("@personaDireccion", SqlDbType.VarChar, 100);
                pr[7].Value = dto.personaDireccion;
                pr[8] = new SqlParameter("@anio", SqlDbType.Char, 4);
                pr[8].Value = dto.anio;
                pr[9] = new SqlParameter("@mes", SqlDbType.Char, 2);
                pr[9].Value = dto.mes;
                pr[10] = new SqlParameter("@codUsuario", SqlDbType.Char, 9);
                pr[10].Value = dto.codUsuario;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Persona_Insert", pr);
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

        //public ClassResultV Usp_Persona_GetAllByJugador()
        //{
        //    ClassResultV cr = new ClassResultV();
        //    try
        //    {
        //        SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Persona_GetAllByJugador");
        //        cr.List = new List<DtoB>();
        //        while (reader.Read())
        //        {
        //            DtoPersona dtoP = new DtoPersona();
        //            dtoP.codPersona = getValue("codPersona", reader).Value_String;
        //            dtoP.nombres = getValue("nombres", reader).Value_String;
        //            dtoP.apellidos = getValue("Apellidos", reader).Value_String;
        //            dtoP.fechaNac = getValue("fechaNac", reader).Value_DateTime;
        //            cr.List.Add(dtoP);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        cr.DT = null;
        //        cr.LugarError = ex.StackTrace;
        //        cr.ErrorEx = ex.Message;
        //        cr.ErrorMsj = "Error al consultar las Personas";
        //    }
        //    objCn.Close();
        //    return cr;
        //}

        //public ClassResultV Consultar_Jugadores()
        //{
        //    ClassResultV cr = new ClassResultV();
        //    try
        //    {
        //        SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_Consultar_Jugadores");
        //        cr.List = new List<DtoB>();
        //        while (reader.Read())
        //        {
        //            DtoPersona dtoP = new DtoPersona();
        //            dtoP.codPersona = getValue("codPersona", reader).Value_String;
        //            dtoP.nombresyap = getValue("nombresyap", reader).Value_String;
        //            cr.List.Add(dtoP);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        cr.DT = null;
        //        cr.LugarError = ex.StackTrace;
        //        cr.ErrorEx = ex.Message;
        //        cr.ErrorMsj = "Error al consultar las Personas";
        //    }
        //    objCn.Close();
        //    return cr;
        //}

        //public DtoPersona Usp_PersonaJugador_CambioEstado(DtoPersona dtoBase)
        //{
        //    var cr = new ClassResultV();
        //    var dto = (DtoPersona)dtoBase;
        //    var pr = new SqlParameter[2];

        //    try
        //    {
        //        pr[0] = new SqlParameter("@codPersona", SqlDbType.Char, 9);
        //        pr[0].Value = dto.codPersona;
        //        pr[1] = new SqlParameter("@estadoJugAsig", SqlDbType.Bit);
        //        pr[1].Value = dto.estadoJugAsig;

        //        SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_PersonaJugador_CambioEstado", pr);
        //        if (Convert.ToString(pr[1].Value) != "")
        //        {
        //            cr.LugarError = ToString("Usp_PersonaJugador_CambioEstado");
        //            cr.ErrorMsj = Convert.ToString(pr[1].Value);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        cr.LugarError = ex.StackTrace;
        //        cr.ErrorEx = ex.Message;
        //        cr.ErrorMsj = "Error al actualizar el estado.";
        //        objCn.Close();
        //    }
        //    return dto;
        //}


    }
}
