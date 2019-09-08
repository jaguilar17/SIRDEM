using DAO;
using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI.WebControls;


namespace WebApp
{
    public partial class ModificarAsistencia : System.Web.UI.Page
    {
        protected Conexion con = new Conexion();
        SqlConnection cn;
        private List<DtoHorarioEntrenamiento> _Asist = new List<DtoHorarioEntrenamiento>();
        private List<DtoAsistencia> _AsistJug = new List<DtoAsistencia>();
        private List<DtoPersona> _Pers = new List<DtoPersona>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrilla();
                GridView1.Visible = false;
                BotonModificarAsistencia.Visible = false;
                BotonCancelar.Visible = false;
                Labelt1.Visible = false;
                Labelt2.Visible = false;
                LabelCodigoHorario.Visible = false;

            }
        }
        private void CargarGrilla()
        {
            try
            {
                _Asist.Clear();
                DtoHorarioEntrenamiento dto = new DtoHorarioEntrenamiento();
                ClassResultV cr = new CTR.CtrlHorarioEntrenamiento().Consultar_Modificar_HorarioEntrenamiento();
                if (!cr.HuboError)
                {
                    foreach (DtoB dtoB in cr.List)
                        _Asist.Add((DtoHorarioEntrenamiento)dtoB);
                    gvHorarios.DataSource = _Asist;
                    gvHorarios.DataBind();
                }
                else
                {
                    gvHorarios.DataBind();
                }
            }
            catch { }
        }


        protected void gvHorarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View1")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow filaSeleccionada = gvHorarios.Rows[index];

                String valor1 = filaSeleccionada.Cells[1].Text;
                String valor2 = filaSeleccionada.Cells[3].Text;
                String codigo = filaSeleccionada.Cells[0].Text;

                GridView1.Visible = true;
                BotonModificarAsistencia.Visible = true;
                BotonCancelar.Visible = true;
                Labelt1.Visible = true;
                Labelt2.Visible = true;
                Labelt1.Text = "Asistencia: " + valor1;
                Labelt2.Text = valor2;
                LabelCodigoHorario.Text = codigo;
                Consultar_Asistencia();

            }
            if (e.CommandName == "View2")
            {
                int index0 = Convert.ToInt32(e.CommandArgument);
                GridViewRow filaSeleccionada0 = gvHorarios.Rows[index0];
                String code = filaSeleccionada0.Cells[0].Text;

                BindGridViewData(code);

                int columnsCount = GridView2.HeaderRow.Cells.Count;
                PdfPTable pdfTable = new PdfPTable(columnsCount);
                foreach (TableCell gridViewHeaderCell in GridView2.HeaderRow.Cells)
                {

                    Font font = new Font();
                    font.Color = new BaseColor(GridView2.HeaderStyle.ForeColor);
                    PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewHeaderCell.Text, font));
                    pdfCell.BackgroundColor = new BaseColor(GridView2.HeaderStyle.BackColor);
                    float[] values = new float[3];
                    values[0] = 30;
                    values[1] = 85;
                    values[2] = 20;
                    pdfTable.SetWidths(values);
                    pdfTable.AddCell(pdfCell);
                }

                foreach (GridViewRow gridViewRow in GridView2.Rows)
                {
                    if (gridViewRow.RowType == DataControlRowType.DataRow)
                    {

                        foreach (TableCell gridViewCell in gridViewRow.Cells)
                        {
                            Font font = new Font();
                            font.Color = new BaseColor(GridView2.RowStyle.ForeColor);
                            PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewCell.Text, font));
                            pdfCell.BackgroundColor = new BaseColor(GridView2.RowStyle.BackColor);
                            //pdfCell.HorizontalAlignment=1;
                            pdfTable.AddCell(pdfCell);
                        }
                    }
                }

                Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                PdfWriter writer =PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

                //iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(Server.MapPath(".") +"/imagenes/logo_2.jpg");
                //imagen.BorderWidth = 0;
                //imagen.Alignment = Element.ALIGN_RIGHT;
                //float percentage = 0.0f;
                //percentage = 100 / imagen.Width;
                //imagen.ScalePercent(percentage * 100);
                //imagen.IndentationRight = 60;
                //imagen.IndentationLeft = 80;
                //imagen.ScaleToFit(100, 100);

                pdfDocument.Open();
                //pdfDocument.Add(imagen);

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow filaSeleccionada = gvHorarios.Rows[index];
                String tituloe = filaSeleccionada.Cells[1].Text;
                String fechae = filaSeleccionada.Cells[3].Text;
                String descpe = filaSeleccionada.Cells[2].Text;                
                //String entradae = filaSeleccionada.Cells[4].Text;
                //String salidae = filaSeleccionada.Cells[5].Text;

                //pdfDocument.Add(new Paragraph("Fecha:"));
                PdfContentByte cb = writer.DirectContent;
                ColumnText ct = new ColumnText(cb);
                Phrase myText = new Phrase("ASISTENCIA\n\nTitulo Entrenamiento: "+tituloe);
                ct.SetSimpleColumn(myText, 82, 820, 580, 317, 15, Element.ALIGN_LEFT);
                ct.Go();

                PdfContentByte cb1 = writer.DirectContent;
                ColumnText ct1 = new ColumnText(cb1);
                Phrase myText1 = new Phrase("Fecha Asistencia: " + fechae + " \n\nDescripcion: " + descpe);
                ct1.SetSimpleColumn(myText1, 82, 740, 580, 317, 15, Element.ALIGN_LEFT);
                ct1.Go();

                cb.MoveTo(70, 765);
                cb.LineTo(530, 765);
                cb.ClosePathStroke();

                pdfDocument.Add(Chunk.NEWLINE);
                pdfDocument.Add(new Paragraph(" "));
                pdfDocument.Add(Chunk.NEWLINE);
                pdfDocument.Add(new Paragraph(" "));
                pdfDocument.Add(Chunk.NEWLINE);
                pdfDocument.Add(new Paragraph(" "));
                pdfDocument.Add(pdfTable);
                pdfDocument.Close();

                Response.ContentType = "application/pdf";
                Response.AppendHeader("content-disposition",
                    "attachment;filename=Asistencia_"+fechae+".pdf");
                Response.Write(pdfDocument);
                Response.Flush();
                Response.End();

            }
        }

        protected void BotonModificarAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                DtoAsistencia dt = new DtoAsistencia();
                foreach (GridViewRow item in GridView1.Rows)
                {
                    dt.codJugador = item.Cells[0].Text;
                    dt.codHorarioEntrenamiento = Convert.ToInt32(LabelCodigoHorario.Text);
                    CheckBox rd1 = (item.Cells[3].FindControl("RadioButton1") as CheckBox);
                    CheckBox rd2 = (item.Cells[4].FindControl("RadioButton2") as CheckBox);
                    CheckBox rd3 = (item.Cells[5].FindControl("RadioButton3") as CheckBox);
                    CheckBox rd4 = (item.Cells[6].FindControl("RadioButton4") as CheckBox);
                    if (rd1.Checked)
                    {
                        dt.asistencia = "P";
                    }
                    else if (rd2.Checked)
                    {
                        dt.asistencia = "T";
                    }
                    else if (rd3.Checked)
                    {
                        dt.asistencia = "F";
                    }
                    else if (rd4.Checked)
                    {
                        dt.asistencia = "J";
                    }

                    ClassResultV cr1 = new CTR.CtrAsistencia().Modificar_Asistencia(dt);
                }
                Limpiar();
            }
            catch (Exception ex) { }
        }

        public void Limpiar()
        {
            GridView1.Visible = false;
            BotonModificarAsistencia.Visible = false;
            BotonCancelar.Visible = false;
            Labelt1.Visible = false;
            Labelt2.Visible = false;
            GridView1.DataSource = null;
            GridView1.DataBind();
            LabelCodigoHorario.Text = "";
            CargarGrilla();
            txtBuscar.Text = null;
        }

        protected void BotonCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void BuscarCargarGrilla()
        {
            try
            {
                _Asist = new List<DtoHorarioEntrenamiento>();
                ClassResultV cr = new CTR.CtrlHorarioEntrenamiento().Consultar_Modificar_HorarioEntrenamiento();
                if (!cr.HuboError)
                {
                    String campo = txtBuscar.Text.ToLower().Trim();
                    String buscarfecha = campo.Substring(8, 2) + "/" + campo.Substring(5, 2) + "/" + campo.Substring(0, 4);
                    foreach (DtoHorarioEntrenamiento dtoB in cr.List)
                        _Asist.Add(dtoB);
                    _Asist = _Asist.Where(x => x.fechaEntrenamiento.ToString().Substring(0, 11).ToLower().Trim().Contains(buscarfecha)).ToList();
                    gvHorarios.DataSource = _Asist;
                    gvHorarios.DataBind();
                }
                else gvHorarios.DataBind();
            }
            catch { }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCargarGrilla();
            Limpiar();
        }

        private void Consultar_Asistencia()
        {
            try
            {
                _AsistJug.Clear();
                DtoAsistencia dto = new DtoAsistencia();
                ClassResultV cr = new CTR.CtrAsistencia().Consultar_Jugadores_Asistencia(LabelCodigoHorario.Text);
                if (!cr.HuboError)
                {
                    foreach (DtoB dtoB in cr.List)
                        _AsistJug.Add((DtoAsistencia)dtoB);
                    GridView1.DataSource = _AsistJug;
                    GridView1.DataBind();

                    foreach (GridViewRow item in GridView1.Rows)
                    {
                        CheckBox rd1 = (item.Cells[3].FindControl("RadioButton1") as CheckBox);
                        CheckBox rd2 = (item.Cells[4].FindControl("RadioButton2") as CheckBox);
                        CheckBox rd3 = (item.Cells[5].FindControl("RadioButton3") as CheckBox);
                        CheckBox rd4 = (item.Cells[6].FindControl("RadioButton4") as CheckBox);
                        if (item.Cells[2].Text == "P")
                        {
                            rd1.Checked = true;
                        }
                        if (item.Cells[2].Text == "T")
                        {
                            rd2.Checked = true;
                        }
                        if (item.Cells[2].Text == "F")
                        {
                            rd3.Checked = true;
                        }
                        if (item.Cells[2].Text == "J")
                        {
                            rd4.Checked = true;
                        }

                    }
                }
                else
                {
                    GridView1.DataBind();
                }
            }
            catch { }
        }

        private void BindGridViewData(string code)
        {
            string CS = ConfigurationManager.ConnectionStrings["ConexionString"].ConnectionString; 
            using (SqlConnection con1 = new SqlConnection(CS)) { 
                SqlDataAdapter da = new SqlDataAdapter("  Select a.codJugador as Codigo, "+
                "u.usuarioApePaterno+' '+u.usuarioApeMaterno+', '+u.usuarioNombre as Apellidos_y_Nombres, " +
		        " a.asistencia as Asistencia "+
                "from	T_Asistencia a inner join T_Jugador p on a.codJugador=p.codJugador "+
                "inner join T_Usuario u on p.codUsuario=u.codUsuario "+
                "where a.codHorarioEntrenamiento='" + code + "'", con1); 
                DataSet ds = new DataSet(); da.Fill(ds); 
                GridView2.DataSource = ds; 
                GridView2.DataBind(); 
            }            
        }

    }
}
