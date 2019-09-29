using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CTR;

namespace WebApp.contenido
{
    public partial class Bienvenida : System.Web.UI.Page
    {

        List<DtoEquipo> listEquipos = new List<DtoEquipo>();
        List<DtoEquipo> listSede1 = new List<DtoEquipo>();
        List<DtoEquipo> listSede2 = new List<DtoEquipo>();
        String Imprimir = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {

            CargarInformacion();
            
        }
        public void CargarInformacion()
        {
            ClassResultV cr = new CTR.CtrEquipo().sp_SelectAllEquipoActive();
            if (!cr.HuboError)
            {
                foreach (DtoB dtoB in cr.List)
                    listEquipos.Add((DtoEquipo)dtoB);
            }

            LlenarInformacion(listEquipos);

        }

        public void LlenarInformacion(List<DtoEquipo> list)
        {
            int cont = 0;

            foreach (DtoEquipo dtoE in list)
            {
                if (dtoE.idSede == "1")
                {
                    listSede1.Add((DtoEquipo)dtoE);

                }
                if (dtoE.idSede == "2")
                {
                    listSede2.Add((DtoEquipo)dtoE);
                }

            }
                

            foreach (DtoEquipo dtoE in listSede1)
            {
                 Imprimir += @" <div class=""col-sm-4"">
                    <div class=""row"">
                    <div class=""col-sm-12 text-center"">
                        <div class=""panel panel-default slideInLeft animate"">
                            <div class=""panel-heading"">
                            <h3>"+ dtoE.equipoNombre + @"</h3></div>
                            <div class=""panel-body"">
                                <p>" + dtoE.equipoDirectorTecnico + @"</p>
                                <hr>

                                <input type=""submit"" name=""btnVerListado"+cont+'"'+ @" value=""Ver Plantilla"" id="""+dtoE.codEquipo+'"' + @"style=""width: 100 %"" onClick=""return ShowTeam();"""+'"'+ @"/>
                                 < hr>
                            </div >
                        </div>
                    </div>
                </div>
            </div> "
            ;
            }


            ltlSede1.Text = Convert.ToString(Imprimir);

        }

       


        protected void btnVerListado0_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/contenido/equipo/frm_VerPlantilla.aspx?codEquipo=0006");
        }

        protected void btnVerListado4_Click(object sender, EventArgs e)
        {

        }
    }
}