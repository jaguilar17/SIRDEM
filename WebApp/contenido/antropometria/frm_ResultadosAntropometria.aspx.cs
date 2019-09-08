using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CTR;
using WebApp.HelpClasses;

namespace WebApp.contenido.antropometria
{
    public partial class frm_ResultadosAntropometria : System.Web.UI.Page
    {
        #region Atributos
        private List<DtoJugador> _ldtoJug = new List<DtoJugador>();
        private List<DtoDatoAntropometrico> _ldtoDatoAntropo = new List<DtoDatoAntropometrico>();
        private List<DtoSomatotipo> _ldtoSomatotipo = new List<DtoSomatotipo>();
        private List<DtoSomatocarta> _ldtoSomatocarta = new List<DtoSomatocarta>();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultaDatosJugador(Request.QueryString["codJugador"]);
                ConsultaUltimoDatoAntropometricoJugador(Request.QueryString["codJugador"]);
                CargaInicial();
                CompararEctomorfo();
                CompararEndomorfia();
                CompararMesomorfia();
                ComparaEjeY();
            }
        }

        #region Metodos
        private void CargaInicial()
        {
            //Ectomorfia
            if (txtPosicionJugador.Text == lblPorteroEctomorfia.Text) { txtDelanteroEctomorfia.Visible = false; txtCentrocampistaEctomorfia.Visible = false; txtDefensaEctomorfia.Visible = false; lblDelanteroEctomorfia.Visible = false; lblCentrocampistaEctomorfia.Visible = false; lblDefensaEctomorfia.Visible = false; }
            if (txtPosicionJugador.Text == lblDelanteroEctomorfia.Text) { txtPorteroEctomorfia.Visible = false; txtCentrocampistaEctomorfia.Visible = false; txtDefensaEctomorfia.Visible = false; lblPorteroEctomorfia.Visible = false; lblCentrocampistaEctomorfia.Visible = false; lblDefensaEctomorfia.Visible = false; }
            if (txtPosicionJugador.Text == lblDefensaEctomorfia.Text) { txtDelanteroEctomorfia.Visible = false; txtCentrocampistaEctomorfia.Visible = false; txtPorteroEctomorfia.Visible = false; lblDelanteroEctomorfia.Visible = false; lblCentrocampistaEctomorfia.Visible = false; lblPorteroEctomorfia.Visible = false; }
            if (txtPosicionJugador.Text == lblCentrocampistaEctomorfia.Text) { txtPorteroEctomorfia.Visible = false; txtDelanteroEctomorfia.Visible = false; txtDefensaEctomorfia.Visible = false; lblPorteroEctomorfia.Visible = false; lblDelanteroEctomorfia.Visible = false; lblDefensaEctomorfia.Visible = false; }
            //Mesomorfia
            if (txtPosicionJugador.Text == lblPorteroMesomorfia.Text) { txtDelanteroMesomorfia.Visible = false; txtCentrocampistaMesomorfia.Visible = false; txtDefensaMesomorfia.Visible = false; lblDelanteroMesomorfia.Visible = false; lblCentroMesomorfia.Visible = false; lblDefensaMesomorfia.Visible = false; }
            if (txtPosicionJugador.Text == lblDelanteroMesomorfia.Text) { txtPorteroMesomorfia.Visible = false; txtCentrocampistaMesomorfia.Visible = false; txtDefensaMesomorfia.Visible = false; lblPorteroMesomorfia.Visible = false; lblCentroMesomorfia.Visible = false; lblDefensaMesomorfia.Visible = false; }
            if (txtPosicionJugador.Text == lblDefensaMesomorfia.Text) { txtDelanteroMesomorfia.Visible = false; txtCentrocampistaMesomorfia.Visible = false; txtPorteroMesomorfia.Visible = false; lblDelanteroMesomorfia.Visible = false; lblCentroMesomorfia.Visible = false; lblPorteroMesomorfia.Visible = false; }
            if (txtPosicionJugador.Text == lblCentroMesomorfia.Text) { txtPorteroMesomorfia.Visible = false; txtDelanteroMesomorfia.Visible = false; txtDefensaMesomorfia.Visible = false; lblPorteroMesomorfia.Visible = false; lblDelanteroMesomorfia.Visible = false; lblDefensaMesomorfia.Visible = false; }
            //Endomorfia
            if (txtPosicionJugador.Text == lblPorteroEndomorfia.Text) { txtDelanteroEndomorfia.Visible = false; txtCentrocampistaEndomorfia.Visible = false; txtDefensaEndomorfia.Visible = false; lblDelanteroEndomorfia.Visible = false; lblCentroEndomorfia.Visible = false; lblDefensaEndomorfia.Visible = false; }
            if (txtPosicionJugador.Text == lblDelanteroEndomorfia.Text) { txtPorteroEndomorfia.Visible = false; txtCentrocampistaEndomorfia.Visible = false; txtDefensaEndomorfia.Visible = false; lblPorteroEndomorfia.Visible = false; lblCentroEndomorfia.Visible = false; lblDefensaEndomorfia.Visible = false; }
            if (txtPosicionJugador.Text == lblDefensaEndomorfia.Text) { txtDelanteroEndomorfia.Visible = false; txtCentrocampistaEndomorfia.Visible = false; txtPorteroEndomorfia.Visible = false; lblDelanteroEndomorfia.Visible = false; lblCentroEndomorfia.Visible = false; lblPorteroEndomorfia.Visible = false; }
            if (txtPosicionJugador.Text == lblCentroEndomorfia.Text) { txtPorteroEndomorfia.Visible = false; txtDelanteroEndomorfia.Visible = false; txtDefensaEndomorfia.Visible = false; lblPorteroEndomorfia.Visible = false; lblDelanteroEndomorfia.Visible = false; lblDefensaEndomorfia.Visible = false; }
            //Eje X
            if (txtPosicionJugador.Text == lblPorteroEjeX.Text) { txtDelanteroEjeX.Visible = false; txtCentroEjeX.Visible = false; txtDefensaEjeX.Visible = false; lblDelanteroEjeX.Visible = false; lblCentroEjeX.Visible = false; lblDefensaEjeX.Visible = false; }
            if (txtPosicionJugador.Text == lblDelanteroEjeX.Text) { txtPorteroEjeX.Visible = false; txtCentroEjeX.Visible = false; txtDefensaEjeX.Visible = false; lblPorteroEjeX.Visible = false; lblCentroEjeX.Visible = false; lblDefensaEjeX.Visible = false; }
            if (txtPosicionJugador.Text == lblDefensaEjeX.Text) { txtDelanteroEjeX.Visible = false; txtCentroEjeX.Visible = false; txtPorteroEjeX.Visible = false; lblDelanteroEjeX.Visible = false; lblCentroEjeX.Visible = false; lblPorteroEjeX.Visible = false; }
            if (txtPosicionJugador.Text == lblCentroEjeX.Text) { txtPorteroEjeX.Visible = false; txtDelanteroEjeX.Visible = false; txtDefensaEjeX.Visible = false; lblPorteroEjeX.Visible = false; lblDelanteroEjeX.Visible = false; lblDefensaEjeX.Visible = false; }
            //Eje Y
            if (txtPosicionJugador.Text == lblPorteroEjeY.Text) { txtDelanteroEjeY.Visible = false; txtCentroEjeY.Visible = false; txtDefensaEjeY.Visible = false; lblDelanteroEjeY.Visible = false; lblCentroEjeY.Visible = false; lblDefensaEjeY.Visible = false; }
            if (txtPosicionJugador.Text == lblDelanteroEjeY.Text) { txtPorteroEjeY.Visible = false; txtCentroEjeY.Visible = false; txtDefensaEjeY.Visible = false; lblPorteroEjeY.Visible = false; lblCentroEjeY.Visible = false; lblDefensaEjeY.Visible = false; }
            if (txtPosicionJugador.Text == lblDefensaEjeY.Text) { txtDelanteroEjeY.Visible = false; txtCentroEjeY.Visible = false; txtPorteroEjeY.Visible = false; lblDelanteroEjeY.Visible = false; lblCentroEjeY.Visible = false; lblPorteroEjeY.Visible = false; }
            if (txtPosicionJugador.Text == lblCentroEjeY.Text) { txtPorteroEjeY.Visible = false; txtDelanteroEjeY.Visible = false; txtDefensaEjeY.Visible = false; lblPorteroEjeY.Visible = false; lblDelanteroEjeY.Visible = false; lblDefensaEjeY.Visible = false; }
        }
        private void ConsultaDatosJugador(string codJugador)
        {
            //cheqear
            codJugador = Request.QueryString["codJugador"];
            DtoJugador dto = new DtoJugador();
            dto.codJugador = codJugador;
            ClassResultV cr = new CtrJugador().Usp_Jugador_NombrePosicion(dto);
            foreach (DtoB dtob in cr.List)
            {
                dto = (DtoJugador)dtob;
                txtCodigoJugador.Text = dto.codJugador;
                txtNombreJugador.Text = dto.nombresyap;
                txtPosicionJugador.Text = dto.descripcionPosicion;
            }
        }
        private void ConsultaUltimoDatoAntropometricoJugador(string codJugador)
        {
            //cheqear
            codJugador = Request.QueryString["codJugador"];
            DtoJugador dto = new DtoJugador();
            dto.codJugador = codJugador;
            ClassResultV cr = new CtrJugador().Usp_UltimoRegistroAntropometricoxJugador(dto);
            foreach (DtoB dtob in cr.List)
            {
                dto = (DtoJugador)dtob;
                txtEctomorfiaDato.Text = Convert.ToString(dto.ectomorfia);
                txtMesomorfiaDato.Text = Convert.ToString(dto.mesomorfia);
                txtEndomorfiaDato.Text = Convert.ToString(dto.endomorfia);
                txtEjeX.Text = Convert.ToString(dto.ejeX);
                txtEjeY.Text = Convert.ToString(dto.ejeY);
            }
        }
        #endregion

        #region Eventos

        public void CompararEctomorfo()
        {
            if (Convert.ToDouble(txtEctomorfiaDato.Text) >= 0.1 && Convert.ToDouble(txtEctomorfiaDato.Text) < 2.5)
            {
                lblResultadoEctomorfo.Text = "Linealidad relativa de gran volumen por unidad de altura. Extremidades relativamente voluminosas.";
                lblEstadoEctomorfo.Text = "Estado: Bajo";
            }
            else if (Convert.ToDouble(txtEctomorfiaDato.Text) >= 2.5 && Convert.ToDouble(txtEctomorfiaDato.Text) < 5.5)
            {
                lblResultadoEctomorfo.Text = "Linealidad relativa moderada. Menos volumen por unidad de altura.";
                lblEstadoEctomorfo.Text = "Estado: Moderado";
            }
            else if (Convert.ToDouble(txtEctomorfiaDato.Text) >= 5.5 && Convert.ToDouble(txtEctomorfiaDato.Text) < 7)
            {
                lblResultadoEctomorfo.Text = "Linealidad relativa moderada. Poco volumen por unidad de altura.";
                lblEstadoEctomorfo.Text = "Estado: Alto";
            }
            else if (Convert.ToDouble(txtEctomorfiaDato.Text) >= 7)
            {
                lblResultadoEctomorfo.Text = "Linealidad relativa muy alta. Volumen muy pequeño por unidad de altura. Individuos muy delgados.";
                lblEstadoEctomorfo.Text = "Estado: Muy Alto";
            }

        }

        public void CompararMesomorfia()
        {
            if (Convert.ToDouble(txtMesomorfiaDato.Text) >= 0.1 && Convert.ToDouble(txtMesomorfiaDato.Text) < 2.5)
            {
                lblResultadoMesomorfo.Text = "Bajo desarrollo muscular. Diámetros óseos y musculares pequeños.";
                lblEstadoMesomorfo.Text = "Estado: Bajo";
            }
            else if (Convert.ToDouble(txtMesomorfiaDato.Text) >= 2.5 && Convert.ToDouble(txtMesomorfiaDato.Text) < 5.5)
            {
                lblResultadoMesomorfo.Text = "Desarrollo músculo esquelético relativo moderado. Mayor volumen de músculos y huesos.";
                lblEstadoMesomorfo.Text = "Estado: Moderado";
            }
            else if (Convert.ToDouble(txtMesomorfiaDato.Text) >= 5.5 && Convert.ToDouble(txtMesomorfiaDato.Text) < 7)
            {
                lblResultadoMesomorfo.Text = "Alto desarrollo músculo esquelético relativo. Diámetros óseos y musculares grandes.";
                lblEstadoMesomorfo.Text = "Estado: Alto";
            }
            else if (Convert.ToDouble(txtMesomorfiaDato.Text) >= 7)
            {
                lblResultadoMesomorfo.Text = "Muy alto desarrollo músculo esquelético relativo. Músculos y esqueleto muy grandes.";
                lblEstadoMesomorfo.Text = "Estado: Muy Alto";
            }
        }

        public void CompararEndomorfia()
        {
            if (Convert.ToDouble(txtEndomorfiaDato.Text) >= 0.1 && Convert.ToDouble(txtEndomorfiaDato.Text) < 2.5)
            {
                lblResultadoEndomorfia.Text = "Poca grasa subcutánea. Contornos musculares y óseos visibles.";
                lblEstadoEndomorfia.Text = "Estado: Bajo";
            }
            else if (Convert.ToDouble(txtEndomorfiaDato.Text) >= 2.5 && Convert.ToDouble(txtEndomorfiaDato.Text) < 5.5)
            {
                lblResultadoEndomorfia.Text = "Moderada adiposidad relativa. Apariencia más blanda.";
                lblEstadoEndomorfia.Text = "Estado: Moderado";
            }
            else if (Convert.ToDouble(txtEndomorfiaDato.Text) >= 5.5 && Convert.ToDouble(txtEndomorfiaDato.Text) < 7)
            {
                lblResultadoEndomorfia.Text = "Alta adiposidad relativa. Grasa subcutánea abundante. Acumulación de grasa en el abdomen.";
                lblEstadoEndomorfia.Text = "Estado: Alto";
            }
            else if (Convert.ToDouble(txtEndomorfiaDato.Text) >= 7)
            {
                lblResultadoEndomorfia.Text = "Adiposidad relativa muy alta. Clara acumulación de grasa subcutánea, especialmente en abdomen.";
                lblEstadoEndomorfia.Text = "Estado: Muy Alto";
            }
        }

        public void ComparaEjeY()
        {
            if (Convert.ToDouble(txtMesomorfiaDato.Text) > Convert.ToDouble(txtEndomorfiaDato.Text) && Convert.ToDouble(txtMesomorfiaDato.Text) > Convert.ToDouble(txtEctomorfiaDato.Text)) (lblResultadoEjeX.Text) = "A - Mesomorfo Balanceado";
            if (Convert.ToDouble(txtEndomorfiaDato.Text) > Convert.ToDouble(txtMesomorfiaDato.Text) && Convert.ToDouble(txtEndomorfiaDato.Text) > Convert.ToDouble(txtEctomorfiaDato.Text)) (lblResultadoEjeX.Text) = "B - Endomorfo Balanceado";
            if (Convert.ToDouble(txtEctomorfiaDato.Text) > Convert.ToDouble(txtEndomorfiaDato.Text) && Convert.ToDouble(txtEctomorfiaDato.Text) > Convert.ToDouble(txtMesomorfiaDato.Text)) (lblResultadoEjeX.Text) = "C - Ectomorfo Balanceado";
            if (Convert.ToDouble(txtEctomorfiaDato.Text) < Convert.ToDouble(txtEndomorfiaDato.Text) && Convert.ToDouble(txtEctomorfiaDato.Text) < Convert.ToDouble(txtMesomorfiaDato.Text)) (lblResultadoEjeX.Text) = "D - Mesomorfo - Endomorfo";
            if (Convert.ToDouble(txtEndomorfiaDato.Text) < Convert.ToDouble(txtEctomorfiaDato.Text) && Convert.ToDouble(txtEndomorfiaDato.Text) < Convert.ToDouble(txtMesomorfiaDato.Text)) (lblResultadoEjeX.Text) = "E - Mesomorfo - Ectomorfo";
            if (Convert.ToDouble(txtMesomorfiaDato.Text) < Convert.ToDouble(txtEndomorfiaDato.Text) && Convert.ToDouble(txtMesomorfiaDato.Text) < Convert.ToDouble(txtEctomorfiaDato.Text)) (lblResultadoEjeX.Text) = "F - Endomorfo - Ectomorfo";
        }

        protected void btnCompararEctomorfo_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtEctomorfiaDato.Text) >= 0.1 && Convert.ToDouble(txtEctomorfiaDato.Text) < 2.5) 
            {
                lblResultadoEctomorfo.Text = "Linealidad relativa de gran volumen por unidad de altura. Extremidades relativamente voluminosas.";
                lblEstadoEctomorfo.Text = "Estado: Bajo";
            }
            else if (Convert.ToDouble(txtEctomorfiaDato.Text) >= 2.5 && Convert.ToDouble(txtEctomorfiaDato.Text) < 5.5)
            {
                lblResultadoEctomorfo.Text = "Linealidad relativa moderada. Menos volumen por unidad de altura.";
                lblEstadoEctomorfo.Text = "Estado: Moderado";
            }
            else if (Convert.ToDouble(txtEctomorfiaDato.Text) >= 5.5 && Convert.ToDouble(txtEctomorfiaDato.Text) < 7)
            {
                lblResultadoEctomorfo.Text = "Linealidad relativa moderada. Poco volumen por unidad de altura.";
                lblEstadoEctomorfo.Text = "Estado: Alto";
            }
            else if (Convert.ToDouble(txtEctomorfiaDato.Text) >= 7)
            {
                lblResultadoEctomorfo.Text = "Linealidad relativa muy alta. Volumen muy pequeño por unidad de altura. Individuos muy delgados.";
                lblEstadoEctomorfo.Text = "Estado: Muy Alto";
            }   
        }
        protected void btnCompararMesomorfia_Click(object sender, EventArgs e) 
        {
            if (Convert.ToDouble(txtMesomorfiaDato.Text) >= 0.1 && Convert.ToDouble(txtMesomorfiaDato.Text) < 2.5)
            {
                lblResultadoMesomorfo.Text = "Bajo desarrollo muscular. Diámetros óseos y musculares pequeños.";
                lblEstadoMesomorfo.Text = "Estado: Bajo";
            }
            else if (Convert.ToDouble(txtMesomorfiaDato.Text) >= 2.5 && Convert.ToDouble(txtMesomorfiaDato.Text) < 5.5)
            {
                lblResultadoMesomorfo.Text = "Desarrollo músculo esquelético relativo moderado. Mayor volumen de músculos y huesos.";
                lblEstadoMesomorfo.Text = "Estado: Moderado";
            }
            else if (Convert.ToDouble(txtMesomorfiaDato.Text) >= 5.5 && Convert.ToDouble(txtMesomorfiaDato.Text) < 7)
            {
                lblResultadoMesomorfo.Text = "Alto desarrollo músculo esquelético relativo. Diámetros óseos y musculares grandes.";
                lblEstadoMesomorfo.Text = "Estado: Alto";
            }
            else if (Convert.ToDouble(txtMesomorfiaDato.Text) >= 7)
            {
                lblResultadoMesomorfo.Text = "Muy alto desarrollo músculo esquelético relativo. Músculos y esqueleto muy grandes.";
                lblEstadoMesomorfo.Text = "Estado: Muy Alto";
            }   
        }
        protected void btnCompararEndomorfia_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtEndomorfiaDato.Text) >= 0.1 && Convert.ToDouble(txtEndomorfiaDato.Text) < 2.5)
            {
                lblResultadoEndomorfia.Text = "Poca grasa subcutánea. Contornos musculares y óseos visibles.";
                lblEstadoEndomorfia.Text = "Estado: Bajo";
            }
            else if (Convert.ToDouble(txtEndomorfiaDato.Text) >= 2.5 && Convert.ToDouble(txtEndomorfiaDato.Text) < 5.5)
            {
                lblResultadoEndomorfia.Text = "Moderada adiposidad relativa. Apariencia más blanda.";
                lblEstadoEndomorfia.Text = "Estado: Moderado";
            }
            else if (Convert.ToDouble(txtEndomorfiaDato.Text) >= 5.5 && Convert.ToDouble(txtEndomorfiaDato.Text) < 7)
            {
                lblResultadoEndomorfia.Text = "Alta adiposidad relativa. Grasa subcutánea abundante. Acumulación de grasa en el abdomen.";
                lblEstadoEndomorfia.Text = "Estado: Alto";
            }
            else if (Convert.ToDouble(txtEndomorfiaDato.Text) >= 7)
            {
                lblResultadoEndomorfia.Text = "Adiposidad relativa muy alta. Clara acumulación de grasa subcutánea, especialmente en abdomen.";
                lblEstadoEndomorfia.Text = "Estado: Muy Alto";
            } 
        }
        protected void btnComparaEjeY_Click(object sender, EventArgs e) 
        {
            if(Convert.ToDouble(txtMesomorfiaDato.Text) > Convert.ToDouble(txtEndomorfiaDato.Text) && Convert.ToDouble(txtMesomorfiaDato.Text) > Convert.ToDouble(txtEctomorfiaDato.Text)) (lblResultadoEjeX.Text) = "A - Mesomorfo Balanceado";
            if (Convert.ToDouble(txtEndomorfiaDato.Text) > Convert.ToDouble(txtMesomorfiaDato.Text) && Convert.ToDouble(txtEndomorfiaDato.Text) > Convert.ToDouble(txtEctomorfiaDato.Text)) (lblResultadoEjeX.Text) = "B - Endomorfo Balanceado";
            if (Convert.ToDouble(txtEctomorfiaDato.Text) > Convert.ToDouble(txtEndomorfiaDato.Text) && Convert.ToDouble(txtEctomorfiaDato.Text) > Convert.ToDouble(txtMesomorfiaDato.Text)) (lblResultadoEjeX.Text) = "C - Ectomorfo Balanceado";
            if (Convert.ToDouble(txtEctomorfiaDato.Text) < Convert.ToDouble(txtEndomorfiaDato.Text) && Convert.ToDouble(txtEctomorfiaDato.Text) < Convert.ToDouble(txtMesomorfiaDato.Text)) (lblResultadoEjeX.Text) = "D - Mesomorfo - Endomorfo";
            if (Convert.ToDouble(txtEndomorfiaDato.Text) < Convert.ToDouble(txtEctomorfiaDato.Text) && Convert.ToDouble(txtEndomorfiaDato.Text) < Convert.ToDouble(txtMesomorfiaDato.Text)) (lblResultadoEjeX.Text) = "E - Mesomorfo - Ectomorfo";
            if (Convert.ToDouble(txtMesomorfiaDato.Text) < Convert.ToDouble(txtEndomorfiaDato.Text) && Convert.ToDouble(txtMesomorfiaDato.Text) < Convert.ToDouble(txtEctomorfiaDato.Text)) (lblResultadoEjeX.Text) = "F - Endomorfo - Ectomorfo";
        }
        #endregion
    }
}