using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using DTO;
using CTR;
using System.Globalization;
using System.Data.SqlClient;

namespace WebApp.Calendario
{

    public partial class frm_Calendario : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BD_AKD_4;Integrated Security=SSPI;");
        static SqlConnection conec0 = new SqlConnection("Data Source=(local);Initial Catalog=BD_AKD_4;Integrated Security=SSPI;");
        static SqlConnection conec = new SqlConnection("Data Source=(local);Initial Catalog=BD_AKD_4;Integrated Security=SSPI;");
        static String valor = "1";
        static String valor1 = "1";
        static String valor0 = "1";
        //CtrlHorarioEntrenamiento ho = new CtrlHorarioEntrenamiento();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                //Label3.Visible = false;
                //Label4.Visible = false;
                //Label5.Visible = false;
                //cargaGrilla();            
            }
        }


        CTR.CtrlHorarioEntrenamiento Ctrl_Horario = new CtrlHorarioEntrenamiento();

        public void cargaGrilla()
        {
            GridView1.DataSource = Ctrl_Horario.Consultar_HorarioEntrenamiento();
            GridView1.DataBind();
        }

        private static bool CheckAlphaNumeric(string str)
        {

            return Regex.IsMatch(str, @"^[a-zA-Z0-9 ]*$");


        }


        [System.Web.Services.WebMethod(true)]
        public static string UpdateEvent(CalendarEvent cevent)
        {
            List<int> idList = (List<int>)System.Web.HttpContext.Current.Session["idList"];
            if (idList != null && idList.Contains(cevent.id))
            {
                if (CheckAlphaNumeric(cevent.title) && CheckAlphaNumeric(cevent.description))
                {
                    DtoHorarioEntrenamiento dto = new DtoHorarioEntrenamiento();

                    dto.codHorarioEntrenamiento = cevent.id;
                    dto.titulo = cevent.title;
                    dto.descripcion = cevent.description;
                    dto.sede = cevent.sede;

                    ClassResultV cr = new CTR.CtrlHorarioEntrenamiento().Update_HorariosEntrenamiento(dto);

                    return "updated T_HorariosEntrenamiento with codHorarioEntrenamiento:" + cevent.id + " update titulo to: " + cevent.title +
                    " update descripcion to: " + cevent.description + " update codSede to: " + cevent.sede;
                }
            }
            return "unable to update T_HorariosEntrenamiento with codHorarioEntrenamiento:" + cevent.id + " titulo : " + cevent.title +
                " descripcion : " + cevent.description + " codSede: " + cevent.sede;
        }

        [System.Web.Services.WebMethod(true)]
        public static string UpdateEventTime(ImproperCalendarEvent improperEvent)
        {

            int id0 = improperEvent.id;
            string query0 = "select * from T_HorariosEntrenamiento h inner join  T_Asistencia a " +
                            "on h.codHorarioEntrenamiento=a.codHorarioEntrenamiento where " +
                            "h.codHorarioEntrenamiento='" + id0 + "'";
            SqlCommand cmd0 = new SqlCommand(query0, conec0);
            conec0.Open();
            SqlDataReader dr0 = cmd0.ExecuteReader();

            bool hayRegistros0 = dr0.Read();
            if (hayRegistros0)
            {
                valor0 = "0";

            }
            else { valor0 = "1"; }
            conec0.Close();
            if (valor0.Equals("1"))
            {
                DateTime date = DateTime.ParseExact(improperEvent.start, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                string formattedDate = date.ToString("yyyy-MM-dd");
                string query = "select * from T_HorariosEntrenamiento where fechaEntrenamiento='" + formattedDate + "' and codHorarioEntrenamiento!='" + id0 + "'";
                SqlCommand cmd1 = new SqlCommand(query, conec);
                conec.Open();
                SqlDataReader dr = cmd1.ExecuteReader();

                bool hayRegistros = dr.Read();
                if (hayRegistros)
                {
                    valor = "0";

                }
                else { valor = "1"; }
                conec.Close();
                if (valor.Equals("1"))
                {
                    DateTime date1 = DateTime.ParseExact(improperEvent.start, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    string formattedDate1 = date1.ToString("dd-MM-yyyy HH:mm:ss tt");
                    DateTime date2 = DateTime.ParseExact(improperEvent.end, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    string formattedDate2 = date2.ToString("dd-MM-yyyy HH:mm:ss tt");
                    if (Convert.ToInt32(formattedDate1.Substring(11, 2)) >= 16 && Convert.ToInt32(formattedDate2.Substring(11, 2)) <= 20)//registra con 30 minutos tambien
                    {
                        if ((Convert.ToInt32(formattedDate2.Substring(11, 2)) - Convert.ToInt32(formattedDate1.Substring(11, 2))) == 2)
                        {
                            List<int> idList = (List<int>)System.Web.HttpContext.Current.Session["idList"];
                            if (idList != null && idList.Contains(improperEvent.id))
                            {
                                //EventDAO.updateEventTime(improperEvent.id,
                                //    DateTime.ParseExact(improperEvent.start, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture),
                                //    DateTime.ParseExact(improperEvent.end, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture));

                                return "updated T_HorariosEntrenamiento with codHorarioEntrenamiento:" + improperEvent.id + "update start to: " + improperEvent.start +
                                    " update end to: " + improperEvent.end;
                            }
                        }
                    }
                }
            }
            return "unable to update T_HorariosEntrenamiento with codHorarioEntrenamiento: " + improperEvent.id;
        }

        [System.Web.Services.WebMethod(true)]
        public static String deleteEvent(int id)
        {
            List<int> idList = (List<int>)System.Web.HttpContext.Current.Session["idList"];
            if (idList != null && idList.Contains(id))
            {
                //EventDAO.deleteEvent(id);
                return "deleted T_HorariosEntrenamiento with codHorarioEntrenamiento:" + id;
            }

            return "unable to delete T_HorariosEntrenamiento with codHorarioEntrenamiento: " + id;

        }

        [System.Web.Services.WebMethod]
        public static int addEvent(ImproperCalendarEvent improperEvent)
        {
            //_Default def = new _Default();
            //def.dd();
            DateTime date = DateTime.ParseExact(improperEvent.start, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            string formattedDate = date.ToString("yyyy-MM-dd");
            string query = "select * from T_HorariosEntrenamiento where fechaEntrenamiento='" + formattedDate + "'";
            SqlCommand cmd1 = new SqlCommand(query, conec);
            conec.Open();
            SqlDataReader dr = cmd1.ExecuteReader();

            bool hayRegistros = dr.Read();
            if (hayRegistros)
            {
                valor = "0";

            }
            else { valor = "1"; }
            conec.Close();
            if (valor.Equals("1"))
            {

                DateTime date1 = DateTime.ParseExact(improperEvent.start, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                string formattedDate1 = date1.ToString("dd-MM-yyyy HH:mm:ss tt");
                DateTime date2 = DateTime.ParseExact(improperEvent.end, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                string formattedDate2 = date2.ToString("dd-MM-yyyy HH:mm:ss tt");
                //DateTime diahoy = DateTime.Today;
                //string formattedDate0 = diahoy.ToString("hh");
                //string query1 = "select * from T_HorariosEntrenamiento where SUBSTRING(CONVERT (varchar,CONVERT (time, horaEntrada)),1,2)='" + formattedDate2  + "'";            
                //SqlCommand cmd2 = new SqlCommand(query1, conec);
                //conec.Open();
                //SqlDataReader dr1 = cmd2.ExecuteReader();

                //bool hayRegistros1 = dr1.Read();
                //if (hayRegistros1)
                //{
                //    valor1 = "0";

                //}
                //else { valor1 = "1"; }
                //conec.Close();
                //if ((Convert.ToInt32(formattedDate1.Substring(11, 2)) > 7 && formattedDate1.Substring(20, 2).Equals("AM")) && (Convert.ToInt32(formattedDate2.Substring(11, 2)) < 18 && formattedDate2.Substring(20, 2).Equals("PM")))

                if (Convert.ToInt32(formattedDate1.Substring(11, 2)) >= 16 && Convert.ToInt32(formattedDate2.Substring(11, 2)) <= 20)//registra con 30 minutos tambien
                {
                    //if ((Convert.ToInt32(formattedDate2.Substring(11, 2))-Convert.ToInt32(formattedDate1.Substring(11, 2)))==2)
                    //{
                    CalendarEvent cevent = new CalendarEvent()
                    {
                        title = improperEvent.title,
                        description = improperEvent.description,
                        start = DateTime.ParseExact(improperEvent.start, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture),
                        end = DateTime.ParseExact(improperEvent.end, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture),
                        sede = improperEvent.sede
                    };


                    if (CheckAlphaNumeric(cevent.title) && CheckAlphaNumeric(cevent.description))
                    {
                        int key = 1; //EventDAO.addEvent(cevent);

                        List<int> idList = (List<int>)System.Web.HttpContext.Current.Session["idList"];

                        if (idList != null)
                        {
                            idList.Add(key);
                        }

                        return key;//return the primary key of the added cevent object            

                    }
                    //}
                }
            }
            return -1;//return a negative number just to signify nothing has been added                        
        }


        protected void DropDownList2_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT idSede,nombre FROM T_Sede";
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DropDownList2.DataSource = dr;
            DropDownList2.DataTextField = "nombre";
            DropDownList2.DataValueField = "idSede";
            DropDownList2.DataBind();
            dr.Close();
            con.Close();
            DropDownList2.Items.Insert(0, "-- Seleccionar --");
        }
        protected void DropDownList1_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT idSede,nombre FROM T_Sede";
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DropDownList1.DataSource = dr;
            DropDownList1.DataTextField = "nombre";
            DropDownList1.DataValueField = "idSede";
            DropDownList1.DataBind();
            dr.Close();
            con.Close();
            DropDownList1.Items.Insert(0, "-- Seleccionar --");
        }

        protected void Evento_Fechas_Calendar(object sender, EventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
        }
        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if (RadioButton2.Checked)
            //{
            //    TextBox1.Enabled = true;
            //    TextBox2.Enabled = false;
            //    TextBox3.Enabled = false;
            //}
            //else {
            //    TextBox1.Enabled = false;
            //}

        }
        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if (RadioButton2.Checked)
            //{
            //    TextBox2.Enabled = true;
            //    TextBox3.Enabled = true;
            //    TextBox1.Enabled = false;
            //}
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox4.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.Visible = false;
            Label3.Text = Calendar1.SelectedDate.ToString("yyyy");
            Label4.Text = (Convert.ToInt32(Calendar1.SelectedDate.ToString("MM")) - 1) + "";
            Label5.Text = Calendar1.SelectedDate.ToString("dd");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //    //String valor = "";
            //    //string query = "select  CASE WHEN fechaEntrenamiento is NULL THEN 1 ELSE 0 END as valor from T_HorariosEntrenamiento where fechaEntrenamiento=CONVERT (date, GETDATE())";
            //    //SqlCommand cmd1 = new SqlCommand(query, conec);
            //    //conec.Open();
            //    //SqlDataReader dr = cmd1.ExecuteReader();

            //    //bool hayRegistros = dr.Read();
            //    //if (hayRegistros)
            //    //{
            //    //    Label1.Text = (int)dr["valor"]+"";
            //    //}
            //String a = "dd-MM-yyyy hh:mm:ss tt";
            //    //Label1.Text = a.Substring(11,2);
            //Label1.Text = a.Substring(20, 2);
            Label1.Text = DropDownList3.SelectedItem.ToString();

        }
        protected void DropDownList3_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT idSede,nombre FROM T_Sede";
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DropDownList3.DataSource = dr;
            DropDownList3.DataTextField = "nombre";
            DropDownList3.DataValueField = "idSede";
            DropDownList3.DataBind();
            dr.Close();
            con.Close();
            DropDownList3.Items.Insert(0, "-- Seleccionar --");
        }
    }
 }