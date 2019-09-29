using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
using CTR;
using Comunes;
using System.Data.SqlClient;
using System.Configuration;
using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections;

namespace WebApp
{
    public partial class Inicio : System.Web.UI.Page
    {
        Utilitario objUtilitario = new Utilitario();

        List<DtoHorarioEntrenamiento> ListConvocatorias = new List<DtoHorarioEntrenamiento>();
        List<DtoHorarioEntrenamiento> ListTemporadas = new List<DtoHorarioEntrenamiento>();
        Hashtable ConvocatoriaList;
        Hashtable TemporadaList;
        protected void Page_Load(object sender, EventArgs e)
        {

            int cont = 0;
            int top = 5;
            string Imprimir = string.Empty;
            for (int n=0; n<=5; n++)
            {
                 Imprimir += @" <div class=""col-sm-4"">
                    < div class=""row"">
                    <div class=""col-sm-12 text-center"">
                        <div class=""panel panel-default slideInLeft animate"">
                            <div class=""panel-heading"">
                            <h3>Categoria 2002</h3></div>
                            <div class=""panel-body"">
                                <p>DT - Jose Aguilar</p>
                                <hr>
                                <asp:Button ID = ""btnVerListado"" Text= ""Ver Plantilla"" style= ""width:100%"" runat= ""server"" OnClick= ""btnVerListado_Click" + cont +'"'+ @" />
                                < hr >
                            </ div >
                        </ div >
                    </ div >
                </ div >
            </ div >"
           ;
                cont++;

            }


            ConvocatoriaList = GetConvocatorias();
            TemporadaList = GetTemporadas();
            //Calendar1.Caption = "Calender - Author: Puran Singh Mehra";
            Calendar1.FirstDayOfWeek = FirstDayOfWeek.Sunday;
            Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;
            Calendar1.TitleFormat = TitleFormat.Month;
            Calendar1.ShowGridLines = true;
            Calendar1.DayStyle.Height = new Unit(50);
            Calendar1.DayStyle.Width = new Unit(150);
            Calendar1.DayStyle.HorizontalAlign = HorizontalAlign.Center;
            Calendar1.DayStyle.VerticalAlign = VerticalAlign.Middle;
            Calendar1.OtherMonthDayStyle.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void ConsultarConvocatorias()
        {
            ListConvocatorias.Clear();
            DtoHorarioEntrenamiento dto = new DtoHorarioEntrenamiento();
            ClassResultV cr = new CTR.CtrlHorarioEntrenamiento().SelectConvocatorias();
            if (!cr.HuboError)
            {
                foreach (DtoB dtoB in cr.List)
                    ListConvocatorias.Add((DtoHorarioEntrenamiento)dtoB);
            }
            else
            {
                ListConvocatorias.Clear();
            }
        }

        private void ConsultarTemporadas()
        {
            ListTemporadas.Clear();
            DtoHorarioEntrenamiento dto = new DtoHorarioEntrenamiento();
            ClassResultV cr = new CTR.CtrlHorarioEntrenamiento().SelectTemporadas();
            if (!cr.HuboError)
            {
                foreach (DtoB dtoB in cr.List)
                    ListTemporadas.Add((DtoHorarioEntrenamiento)dtoB);
            }
            else
            {
                ListTemporadas.Clear();
            }
        }

        private Hashtable GetConvocatorias()
        {
            ConsultarConvocatorias();
            Hashtable Convocatorias = new Hashtable();

            foreach(DtoHorarioEntrenamiento dto in ListConvocatorias)
            {
                Convocatorias[dto.fechaEntrenamiento.ToShortDateString()] = dto.titulo;
            }
            return Convocatorias;
        }

        private Hashtable GetTemporadas()
        {
            ConsultarTemporadas();
            Hashtable Temporadas = new Hashtable();
            foreach (DtoHorarioEntrenamiento dto in ListTemporadas)
            {
                Temporadas[dto.fechaEntrenamiento.ToShortDateString()] = dto.titulo;
            }
            return Temporadas;
        }

        //SelectConvocatorias

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
        }

        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        { 
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (ConvocatoriaList[e.Day.Date.ToShortDateString()] != null)
            {
                Literal literal1 = new Literal();
                literal1.Text = "<br/>";
                e.Cell.Controls.Add(literal1);
                Label label1 = new Label();
                label1.Text = (string)ConvocatoriaList[e.Day.Date.ToShortDateString()];
                label1.Font.Size = new FontUnit(FontSize.Small);
                e.Cell.Controls.Add(label1);
                e.Cell.BackColor = System.Drawing.Color.LightGreen;
            }

            if (TemporadaList[e.Day.Date.ToShortDateString()] != null)
            {
                Literal literal1 = new Literal();
                literal1.Text = "<br/>";
                e.Cell.Controls.Add(literal1);
                Label label1 = new Label();
                label1.Text = (string)TemporadaList[e.Day.Date.ToShortDateString()];
                label1.Font.Size = new FontUnit(FontSize.Small);
                e.Cell.Controls.Add(label1);
                e.Cell.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            DtoUsuario objDtoUsu = new DtoUsuario();
            CtrUsuario CtrUsu = new CtrUsuario();


            try
            {
                string nombreUsuario = string.Empty;
                objDtoUsu.usuario = txtUsuario.Text.Trim();
                objDtoUsu.usuarioClave = txtContraseña.Text;
                objDtoUsu = CtrUsu.iniciarSesion(objDtoUsu);
                Globales.Instance.Usuario = objDtoUsu;
                nombreUsuario = objUtilitario.obtenerPrimerNombre(objDtoUsu.usuarioNombre) + "-" + objDtoUsu.usuarioApePaterno;
                Response.Redirect(objUtilitario.cadenaAmigable(nombreUsuario));
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Nombre o Contraseña Incorrecta')</script>");

            }

        }
    }
}