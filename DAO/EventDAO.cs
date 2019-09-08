using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Configuration;

namespace DAO
{
   public  class EventDAO
    {
        private static string connectionString = ConfigurationManager.AppSettings["DBConnString"];

        /*
        //this method retrieves all events within range start-end
        public static List<CalendarEvent> getEvents(DateTime start, DateTime end)
        {
            List<CalendarEvent> events = new List<CalendarEvent>();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT event_id, description, title, event_start, event_end, all_day FROM Event where event_start>=@start AND event_end<=@end", con);
            cmd.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@end", SqlDbType.DateTime).Value = end;

            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    events.Add(new CalendarEvent()
                    {
                        id = Convert.ToInt32(reader["event_id"]),
                        title = Convert.ToString(reader["title"]),
                        description = Convert.ToString(reader["description"]),
                        start = Convert.ToDateTime(reader["event_start"]),
                        end = Convert.ToDateTime(reader["event_end"]),
                        allDay = Convert.ToBoolean(reader["all_day"])
                    });
                }
            }
            return events;
            //side note: if you want to show events only related to particular users,
            //if user id of that user is stored in session as Session["userid"]
            //the event table also contains an extra field named 'user_id' to mark the event for that particular user
            //then you can modify the SQL as:
            //SELECT event_id, description, title, event_start, event_end FROM event where user_id=@user_id AND event_start>=@start AND event_end<=@end
            //then add paramter as:cmd.Parameters.AddWithValue("@user_id", HttpContext.Current.Session["userid"]);
        }

        //this method updates the event title and description
        public static void updateEvent(int id, String title, String description)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE Event SET title=@title, description=@description WHERE event_id=@event_id", con);
            cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = title;
            cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
            cmd.Parameters.Add("@event_id", SqlDbType.Int).Value = id;

            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //this method updates the event start and end time ... allDay parameter added for FullCalendar 2.x
        public static void updateEventTime(int id, DateTime start, DateTime end, bool allDay)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE Event SET event_start=@event_start, event_end=@event_end, all_day=@all_day WHERE event_id=@event_id", con);
            cmd.Parameters.Add("@event_start", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@event_end", SqlDbType.DateTime).Value = end;
            cmd.Parameters.Add("@event_id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@all_day", SqlDbType.Bit).Value = allDay;

            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //this mehtod deletes event with the id passed in.
        public static void deleteEvent(int id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM Event WHERE (event_id = @event_id)", con);
            cmd.Parameters.Add("@event_id", SqlDbType.Int).Value = id;

            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //this method adds events to the database
        public static int addEvent(CalendarEvent cevent)
        {
            //add event to the database and return the primary key of the added event row

            //insert
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Event(title, description, event_start, event_end, all_day) VALUES(@title, @description, @event_start, @event_end, @all_day)", con);
            cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = cevent.title;
            cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = cevent.description;
            cmd.Parameters.Add("@event_start", SqlDbType.DateTime).Value = cevent.start;
            cmd.Parameters.Add("@event_end", SqlDbType.DateTime).Value = cevent.end;
            cmd.Parameters.Add("@all_day", SqlDbType.Bit).Value = cevent.allDay;

            int key = 0;
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

                //get primary key of inserted row
                cmd = new SqlCommand("SELECT max(event_id) FROM Event where title=@title AND description=@description AND event_start=@event_start AND event_end=@event_end AND all_day=@all_day", con);
                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = cevent.title;
                cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = cevent.description;
                cmd.Parameters.Add("@event_start", SqlDbType.DateTime).Value = cevent.start;
                cmd.Parameters.Add("@event_end", SqlDbType.DateTime).Value = cevent.end;
                cmd.Parameters.Add("@all_day", SqlDbType.Bit).Value = cevent.allDay;

                key = (int)cmd.ExecuteScalar();
            }

            return key;
        }
        */



        public static List<CalendarEvent> getEvents(DateTime start, DateTime end)
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


        public static void updateEventTime(int id, DateTime start, DateTime end)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE T_HorariosEntrenamiento SET horaEntrada=@event_start, horaSalida=@event_end,fechaEntrenamiento=convert(date ,@event_start) WHERE codHorarioEntrenamiento=@event_id", con);
            cmd.Parameters.AddWithValue("@event_start", start);
            cmd.Parameters.AddWithValue("@event_end", end);
            cmd.Parameters.AddWithValue("@event_id", id);
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public static void deleteEvent(int id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM T_HorariosEntrenamiento WHERE (codHorarioEntrenamiento = @event_id)", con);
            cmd.Parameters.AddWithValue("@event_id", id);
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        static SqlConnection conec = new SqlConnection(Conexion.strCon);
        static String valor = "";
        public static int addEvent(CalendarEvent cevent)
        {
            //string query = "select  CASE WHEN fechaEntrenamiento is NULL THEN 1 ELSE 0 END as valor from T_HorariosEntrenamiento where fechaEntrenamiento='"+cevent.start.ToShortDateString()+"'";        
            //SqlCommand cmd1 = new SqlCommand(query, conec);
            ////cmd1.Parameters.AddWithValue("@start", cevent.start.ToShortDateString());
            //conec.Open();
            //SqlDataReader dr = cmd1.ExecuteReader();

            //bool hayRegistros = dr.Read();
            //if (hayRegistros)
            //{
            //    valor = (int)dr["valor"] + "";

            //}

            //conec.Close();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO T_HorariosEntrenamiento(titulo, descripcion, fechaEntrenamiento, horaEntrada, horaSalida,codsede) VALUES(@title, @description, convert(date ,@event_start), @event_start, @event_end,@sede)", con);
            //if (!valor.Equals("0"))
            //{

            //insertar


            cmd.Parameters.AddWithValue("@title", cevent.title);
            cmd.Parameters.AddWithValue("@description", cevent.description);
            cmd.Parameters.AddWithValue("@event_start", cevent.start);
            cmd.Parameters.AddWithValue("@event_end", cevent.end);
            cmd.Parameters.AddWithValue("@sede", cevent.sede);


            //}
            int key = 0;
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();

                //get primary key para insertar
                cmd = new SqlCommand("SELECT max(codHorarioEntrenamiento) FROM T_HorariosEntrenamiento where titulo=@title AND descripcion=@description AND codsede=@sede AND horaEntrada=@event_start AND horaSalida=@event_end", con);
                cmd.Parameters.AddWithValue("@title", cevent.title);
                cmd.Parameters.AddWithValue("@description", cevent.description);
                cmd.Parameters.AddWithValue("@event_start", cevent.start);
                cmd.Parameters.AddWithValue("@event_end", cevent.end);
                cmd.Parameters.AddWithValue("@sede", cevent.sede);

                key = (int)cmd.ExecuteScalar();
            }
            return key;


        }


    }
}
