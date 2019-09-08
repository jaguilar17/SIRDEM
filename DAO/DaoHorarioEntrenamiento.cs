using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace DAO
{
    public class DaoHorarioEntrenamiento : DaoB
    {
        protected Conexion con = new Conexion();
        SqlConnection cn;

        public DaoHorarioEntrenamiento()
        {
            cn = new SqlConnection(con.StrCon);
        }
        // SELECT para Registrar
        public ClassResultV Consultar_HorarioEntrenamiento()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_Consultar_HorarioEntrenamiento");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoHorarioEntrenamiento dtoA = new DtoHorarioEntrenamiento();
                    dtoA.codHorarioEntrenamiento = getValue("codHorarioEntrenamiento", reader).Value_Int32;
                    dtoA.titulo = getValue("titulo", reader).Value_String;
                    dtoA.descripcion = getValue("descripcion", reader).Value_String;
                    dtoA.fechaEntrenamiento = getValue("fechaEntrenamiento", reader).Value_DateTime;
                    dtoA.horaEntrada = getValue("horaEntrada", reader).Value_DateTime;
                    dtoA.horaSalida = getValue("horaSalida", reader).Value_DateTime;                    
                    cr.List.Add(dtoA);                    
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar las Horario de Entrenamiento";
            }
            objCn.Close();
            return cr;
        }
        // SELECT para Modificar
        public ClassResultV Consultar_Modificar_HorarioEntrenamiento()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_Consultar_Modificar_HorarioEntrenamiento");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoHorarioEntrenamiento dtoA = new DtoHorarioEntrenamiento();
                    dtoA.codHorarioEntrenamiento = getValue("codHorarioEntrenamiento", reader).Value_Int32;
                    dtoA.titulo = getValue("titulo", reader).Value_String;
                    dtoA.descripcion = getValue("descripcion", reader).Value_String;
                    dtoA.fechaEntrenamiento = getValue("fechaEntrenamiento", reader).Value_DateTime;
                    dtoA.horaEntrada = getValue("horaEntrada", reader).Value_DateTime;
                    dtoA.horaSalida = getValue("horaSalida", reader).Value_DateTime;
                    cr.List.Add(dtoA);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar las Horario de Entrenamiento";
            }
            objCn.Close();
            return cr;
        }
        //METODOS DE CALENDARIO
        public ClassResultV BuscarHorario()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_Consultar_HorarioEntrenamiento");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoHorarioEntrenamiento dtoA = new DtoHorarioEntrenamiento();
                    dtoA.codHorarioEntrenamiento = getValue("codHorarioEntrenamiento", reader).Value_Int32;
                    dtoA.titulo = getValue("titulo", reader).Value_String;
                    dtoA.descripcion = getValue("descripcion", reader).Value_String;
                    dtoA.fechaEntrenamiento = getValue("fechaEntrenamiento", reader).Value_DateTime;
                    dtoA.horaEntrada = getValue("horaEntrada", reader).Value_DateTime;
                    dtoA.horaSalida = getValue("horaSalida", reader).Value_DateTime;
                    cr.List.Add(dtoA);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar las Horario de Entrenamiento";
            }
            objCn.Close();
            return cr;
        }
        public DtoHorarioEntrenamiento registrarHorario(DtoHorarioEntrenamiento dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoHorarioEntrenamiento)dtoBase;
            var pr = new SqlParameter[6];
            try
            {
                pr[0] = new SqlParameter("@titulo", SqlDbType.VarChar, 50);
                pr[0].Value = dto.titulo;
                pr[1] = new SqlParameter("@descripcion", SqlDbType.VarChar, 100);
                pr[1].Value = dto.descripcion;
                pr[2] = new SqlParameter("@fechaEntrenamiento", SqlDbType.Date);
                pr[2].Value = dto.fechaEntrenamiento;
                pr[3] = new SqlParameter("@horaEntrada", SqlDbType.DateTime);
                pr[3].Value = dto.horaEntrada;
                pr[4] = new SqlParameter("@horaSalida", SqlDbType.DateTime);
                pr[4].Value = dto.horaSalida;
                pr[5] = new SqlParameter("@codSede", SqlDbType.Int);
                pr[5].Value = dto.sede;
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_Registrar_HorarioEntrenamiento", pr);
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
        public DtoHorarioEntrenamiento modificarHorario(DtoHorarioEntrenamiento dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoHorarioEntrenamiento)dtoBase;
            var pr = new SqlParameter[7];
            try
            {
                pr[0] = new SqlParameter("@codHorarioEntrenamiento", SqlDbType.VarChar, 50);
                pr[0].Value = dto.codHorarioEntrenamiento;
                pr[1] = new SqlParameter("@titulo", SqlDbType.VarChar, 50);
                pr[1].Value = dto.titulo;
                pr[2] = new SqlParameter("@descripcion", SqlDbType.VarChar, 100);
                pr[2].Value = dto.descripcion;
                pr[3] = new SqlParameter("@fechaEntrenamiento", SqlDbType.Date);
                pr[3].Value = dto.fechaEntrenamiento;
                pr[4] = new SqlParameter("@horaEntrada", SqlDbType.DateTime);
                pr[4].Value = dto.horaEntrada;
                pr[5] = new SqlParameter("@horaSalida", SqlDbType.DateTime);
                pr[5].Value = dto.horaSalida;
                pr[6] = new SqlParameter("@codSede", SqlDbType.Int);
                pr[6].Value = dto.sede;
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_Modificar_HorarioEntrenamiento", pr);
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
        public DtoHorarioEntrenamiento eliminarHorario(DtoHorarioEntrenamiento dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoHorarioEntrenamiento)dtoBase;
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@codHorarioEntrenamiento", SqlDbType.VarChar, 50);
                pr[0].Value = dto.codHorarioEntrenamiento;
                pr[6].Value = dto.sede;
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_eliminar_HorarioEntrenamiento", pr);
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

        //Convocatoria categoria 2002
        public ClassResultV SelectConvocatorias()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_SelectConvocatorias");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoHorarioEntrenamiento dtoA = new DtoHorarioEntrenamiento();
                    dtoA.titulo = getValue("titulo", reader).Value_String;
                    dtoA.fechaEntrenamiento = getValue("fechaEntrenamiento", reader).Value_DateTime;
                    cr.List.Add(dtoA);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar las Convocatorias";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV SelectTemporadas()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Sp_SelectTemporadas");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoHorarioEntrenamiento dtoA = new DtoHorarioEntrenamiento();
                    dtoA.titulo = getValue("titulo", reader).Value_String;
                    dtoA.fechaEntrenamiento = getValue("fechaEntrenamiento", reader).Value_DateTime;
                    cr.List.Add(dtoA);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar las Convocatorias";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV SelectAll_EventoActive()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "SP_SelectAll_EventoActive");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoHorarioEntrenamiento dtoA = new DtoHorarioEntrenamiento();
                    dtoA.titulo = getValue("titulo", reader).Value_String;
                    dtoA.horaEntrada = getValue("horaEntrada", reader).Value_DateTime;
                    dtoA.horaSalida = getValue("horaSalida", reader).Value_DateTime;
                    cr.List.Add(dtoA);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar los Eventos";
            }
            objCn.Close();
            return cr;
        }


        private static string connectionString = "Data Source=(local);Initial Catalog=BD_AKD_4;Integrated Security=SSPI;";


        public List<CalendarEvent> getEvents(DateTime start, DateTime end)
        {
            List<CalendarEvent> events = new List<CalendarEvent>();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT codHorarioEntrenamiento, descripcion, titulo,codsede, horaEntrada, horaSalida FROM T_HorariosEntrenamiento  where horaEntrada>=@start AND horaSalida<=@end", con);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@end", end);

            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CalendarEvent cevent = new CalendarEvent();
                    cevent.id = (int)reader["codHorarioEntrenamiento"];
                    cevent.title = (string)reader["titulo"];
                    cevent.description = (string)reader["descripcion"];
                    cevent.start = (DateTime)reader["horaEntrada"];
                    cevent.end = (DateTime)reader["horaSalida"];
                    cevent.sede = (int)reader["codsede"];         
                    events.Add(cevent);
                }
            }
            return events;

        }
        public static void updateEvent(int id, String title, String description, int sede)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE T_HorariosEntrenamiento SET titulo=@title, descripcion=@description,codsede=@sede WHERE codHorarioEntrenamiento=@event_id", con);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@event_id", id);
            cmd.Parameters.AddWithValue("@sede", sede);
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DtoHorarioEntrenamiento Update_HorariosEntrenamiento(DtoB dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoHorarioEntrenamiento)dtoBase;
            var pr = new SqlParameter[4];
            try
            {
                pr[0] = new SqlParameter("@codHorarioEntrenamiento", SqlDbType.VarChar, 50);
                pr[0].Value = dto.codHorarioEntrenamiento;
                pr[1] = new SqlParameter("@titulo", SqlDbType.VarChar, 50);
                pr[1].Value = dto.titulo;
                pr[2] = new SqlParameter("@descripcion", SqlDbType.VarChar, 100);
                pr[2].Value = dto.descripcion;
                pr[3] = new SqlParameter("@codSede", SqlDbType.Int);
                pr[3].Value = dto.sede;
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "sp_Actualizar_HorariosEntrenamiento", pr);
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
    }
}
