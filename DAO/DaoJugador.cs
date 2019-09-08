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
    public class DaoJugador : DaoB
    {
        protected Conexion con = new Conexion();
        SqlConnection cn;

        public DaoJugador()
        {
            cn = new SqlConnection(con.StrCon);
        }

        //public DataSet Select_Usp_Persona_GetAllByJugador()
        //{
        //    SqlCommand cmd = new SqlCommand("Usp_Persona_GetAllByJugador", cn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    return ds;
        //}

        public DtoJugador Usp_Jugador_Insert(DtoJugador dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoJugador)dtoBase;
            var pr = new SqlParameter[14];
            try
            {
                pr[0] = new SqlParameter("@aliasDeportivo", SqlDbType.VarChar, 50);
                pr[0].Value = dto.aliasDeportivo;
                pr[1] = new SqlParameter("@numDorsal", SqlDbType.Int);
                pr[1].Value = dto.numDorsal;
                pr[2] = new SqlParameter("@clubProcedencia", SqlDbType.VarChar, 50);
                pr[2].Value = dto.clubProcedencia;
                pr[3] = new SqlParameter("@lateralidad", SqlDbType.Char, 1);
                pr[3].Value = dto.lateralidad;
                pr[4] = new SqlParameter("@posicionPrincipal", SqlDbType.VarChar, 4);
                pr[4].Value = dto.posicionPrincipal;
                pr[5] = new SqlParameter("@posicionAlternativa", SqlDbType.VarChar, 4);
                pr[5].Value = dto.posicionAlternativa;
                pr[6] = new SqlParameter("@pesoInicial", SqlDbType.Decimal);
                pr[6].Value = V_ValidaPrNull(dto.pesoInicial);
                pr[7] = new SqlParameter("@tallaInicial", SqlDbType.Decimal);
                pr[7].Value = V_ValidaPrNull(dto.tallaInicial);
                pr[8] = new SqlParameter("@anio", SqlDbType.Char, 4);
                pr[8].Value = dto.anio;
                pr[9] = new SqlParameter("@mes", SqlDbType.Char, 2);
                pr[9].Value = dto.mes;
                pr[10] = new SqlParameter("@codUsuario", SqlDbType.Char, 9);
                pr[10].Value = dto.codUsuario;
                pr[11] = new SqlParameter("@codEquipo", SqlDbType.VarChar, 4);
                pr[11].Value = dto.codEquipo;
                pr[12] = new SqlParameter("@jugadorFechaNac", SqlDbType.DateTime);
                pr[12].Value = dto.jugadorFechaNac;
                pr[13] = new SqlParameter("@codJugador", SqlDbType.Char, 9);
                pr[13].Direction = ParameterDirection.Output;
               
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Jugador_Insert", pr);
                dto.codJugador = Convert.ToString(pr[13].Value);
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al registrar jugador";
            }
            objCn.Close();
            return dto;
        }
        public ClassResultV Usp_DatosxJugador_Antropometria(DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            var dtoCab = (DtoJugador)dtoBase;
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@codJugador", SqlDbType.Char, 9);
                pr[0].Value = dtoCab.codJugador;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_DatosxJugador_Antropometria", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    dtoCab.aliasDeportivo = getValue("aliasDeportivo", reader).Value_String;
                    dtoCab.jugadorCompleto = getValue("jugadorCompleto", reader).Value_String;
                    dtoCab.equipoNombre = getValue("equipoNombre", reader).Value_String;
                    dtoCab.descripcionPosicion = getValue("descripcionPosicion", reader).Value_String;
                    dtoCab.pesoInicial = getValue("pesoInicial", reader).Value_Decimal;
                    dtoCab.tallaInicial = getValue("tallaInicial", reader).Value_Decimal;
                    cr.List.Add(dtoCab);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar el jugador";
            }
            objCn.Close();
            return cr;

        }
        public ClassResultV Consultar_Jugadores()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_Consultar_Jugadores");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoJugador dtoP = new DtoJugador();
                    dtoP.codJugador = getValue("codJugador", reader).Value_String;
                    dtoP.nombresyap = getValue("nombresyap", reader).Value_String;
                    cr.List.Add(dtoP);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar los Jugadores del equipo";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_UltimoRegistroAntropometricoxJugador(DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            var dtoCab = (DtoJugador)dtoBase;
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@codJugador", SqlDbType.Char, 9);
                pr[0].Value = dtoCab.codJugador;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_UltimoRegistroAntropometricoxJugador", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    dtoCab.ectomorfia = getValue("ectomorfia", reader).Value_Decimal;
                    dtoCab.mesomorfia = getValue("mesomorfia", reader).Value_Decimal;
                    dtoCab.endomorfia = getValue("endomorfia", reader).Value_Decimal;
                    dtoCab.ejeX = getValue("ejeX", reader).Value_Decimal;
                    dtoCab.ejeY = getValue("ejeY", reader).Value_Decimal;
                    cr.List.Add(dtoCab);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar ultimo datos antropometricos del jugador";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_Jugador_NombrePosicion(DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            var dtoCab = (DtoJugador)dtoBase;
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@codJugador", SqlDbType.Char, 9);
                pr[0].Value = dtoCab.codJugador;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Jugador_NombrePosicion", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    dtoCab.codJugador = getValue("codJugador", reader).Value_String;
                    dtoCab.nombresyap = getValue("nombresyap", reader).Value_String;
                    dtoCab.descripcionPosicion = getValue("descripcionPosicion", reader).Value_String;
                    cr.List.Add(dtoCab);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar datos personales del jugador";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_ResultadosAntropometricosxJugador_GetAll(DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            var dtoCab = (DtoJugador)dtoBase;
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@codJugador", SqlDbType.Char, 9);
                pr[0].Value = dtoCab.codJugador;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_ResultadosAntropometricosxJugador_GetAll", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    dtoCab.ectomorfia = getValue("ectomorfia", reader).Value_Decimal;
                    dtoCab.mesomorfia = getValue("mesomorfia", reader).Value_Decimal;
                    dtoCab.endomorfia = getValue("endomorfia", reader).Value_Decimal;
                    dtoCab.ejeX = getValue("ejeX", reader).Value_Decimal;
                    dtoCab.ejeY = getValue("ejeY", reader).Value_Decimal;
                    dtoCab.fechaControl = getValue("fechaControl", reader).Value_DateTime;
                    cr.List.Add(dtoCab);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar ultimo datos antropometricos del jugador";
            }
            objCn.Close();
            return cr;
        }
        //public ClassResultV Usp_Jugador_Insert2(DtoJugador dtoBase)
        //{
        //    var cr = new ClassResultV();
        //    var dto = (DtoJugador)dtoBase;
        //    var pr = new SqlParameter[15];
        //    try
        //    {
        //        pr[0] = new SqlParameter("@nombreDeportivo", SqlDbType.VarChar, 50);
        //        pr[0].Value = dto.nombreDeportivo;
        //        pr[1] = new SqlParameter("@numDorsal", SqlDbType.Int);
        //        pr[1].Value = dto.numDorsal;
        //        pr[2] = new SqlParameter("@clubProcedencia", SqlDbType.VarChar, 50);
        //        pr[2].Value = dto.clubProcedencia;
        //        pr[3] = new SqlParameter("@categoria", SqlDbType.Char, 4);
        //        pr[3].Value = dto.categoria;
        //        pr[4] = new SqlParameter("@lateralidad", SqlDbType.Char, 1);
        //        pr[4].Value = dto.lateralidad;
        //        pr[5] = new SqlParameter("@posicionPrincipal", SqlDbType.VarChar, 4);
        //        pr[5].Value = dto.posicionPrincipal;
        //        pr[6] = new SqlParameter("@posicionAlternativa", SqlDbType.VarChar, 4);
        //        pr[6].Value = dto.posicionAlternativa;
        //        pr[7] = new SqlParameter("@codPersona", SqlDbType.Char, 9);
        //        pr[7].Value = dto.codPersona;
        //        pr[8] = new SqlParameter("@codApoderado", SqlDbType.Char, 9);
        //        pr[8].Value = dto.codApoderado;
        //        pr[9] = new SqlParameter("@codEquipo", SqlDbType.VarChar, 4);
        //        pr[9].Value = dto.codEquipo;
        //        pr[10] = new SqlParameter("@anio", SqlDbType.Char, 4);
        //        pr[10].Value = dto.anio;
        //        pr[11] = new SqlParameter("@mes", SqlDbType.Char, 2);
        //        pr[11].Value = dto.mes;
        //        pr[12] = new SqlParameter("@peso", SqlDbType.Decimal);
        //        pr[12].Value = V_ValidaPrNull(dto.peso);
        //        pr[13] = new SqlParameter("@talla", SqlDbType.Decimal);
        //        pr[13].Value = V_ValidaPrNull(dto.talla);
        //        pr[14] = new SqlParameter("@msj", SqlDbType.VarChar, 100);
        //        pr[14].Direction = ParameterDirection.Output;

        //        SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Jugador_Insert2", pr);
        //        if (Convert.ToString(pr[14].Value) != "")
        //        {
        //            cr.LugarError = ToString("Usp_Jugador_Insert2");
        //            cr.ErrorMsj = Convert.ToString(pr[14].Value);
        //        }
        //        else { }
        //    }
        //    catch (Exception ex)
        //    {
        //        cr.LugarError = ex.StackTrace;
        //        cr.ErrorEx = ex.Message;
        //        cr.ErrorMsj = "Error al registrar jugador";
        //    }
        //    objCn.Close();
        //    return cr;
        //}
    }
}
