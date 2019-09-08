using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CTR;
using WebApp.HelpClasses;
using System.Data;
using System.Configuration;

namespace WebApp.contenido2.antropometria
{
    public partial class frm_AntropometriaRegistro : System.Web.UI.Page
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
                ConsultarJugador(Request.QueryString["codJugador"]);
            }
        }

        #region Metodos
        private void ConsultarJugador(string codJugador)
        {
            //cheqear
            codJugador = Request.QueryString["codJugador"];
            DtoJugador dto = new DtoJugador();
            dto.codJugador = codJugador;
            ClassResultV cr = new CtrJugador().Usp_DatosxJugador_Antropometria(dto);
            foreach (DtoB dtob in cr.List)
            {
                dto = (DtoJugador)dtob;
                txtApodoJugador.Text = dto.aliasDeportivo;
                txtNombreCompleto.Text = dto.jugadorCompleto;
                txtEquipoNombre.Text = dto.equipoNombre;
                txtPosicion.Text = dto.descripcionPosicion;
                txtPesoInicial.Text = Convert.ToString(dto.pesoInicial);
                txtTallaInicial.Text = Convert.ToString(dto.tallaInicial);
            }
        }
        private bool AgregarNuevoDatoAntropometrico()
        {
            bool valido = false;

            try
            {
                ClassResultV cr = new ClassResultV();
                DtoDatoAntropometrico dtoDA = new DtoDatoAntropometrico();
                DtoJugador dtoJ = new DtoJugador();
                DtoSomatotipo dtoST = new DtoSomatotipo();
                DtoSomatocarta dtoSC = new DtoSomatocarta();

                //Datos Antropometrico
                dtoDA.brazoPerimetro = Convert.ToDecimal(txtBrazoPerimetro.Text);
                dtoDA.pechoPerimetro = Convert.ToDecimal(txtPechoPerimetro.Text);
                dtoDA.abdomenPerimetro = Convert.ToDecimal(txtAbdomenPerimetro.Text);
                dtoDA.caderaPerimetro = Convert.ToDecimal(txtCaderaPerimetro.Text);
                dtoDA.musloPerimetro = Convert.ToDecimal(txtMusloPerimetro.Text);
                dtoDA.gemeloPerimetro = Convert.ToDecimal(txtGemeloPerimetro.Text);
                dtoDA.humeroLongitud = Convert.ToDecimal(txtHumeroLongitud.Text);
                dtoDA.femurLongitud = Convert.ToDecimal(txtFemurLongitud.Text);
                dtoDA.munecaLongitud = Convert.ToDecimal(txtMunecaLongitud.Text);
                dtoDA.triceps = Convert.ToDecimal(txtTrícepsPliegues.Text);
                dtoDA.musloPliegues = Convert.ToDecimal(txtMusloPliegues.Text);
                dtoDA.supraespinal = Convert.ToDecimal(txtSupraespinalPliegues.Text);
                dtoDA.pectoral = Convert.ToDecimal(txtPectoralPliegues.Text);
                dtoDA.abdominal = Convert.ToDecimal(txtAbdominalPliegues.Text);
                dtoDA.gemeloPliegues = Convert.ToDecimal(txtGemeloPliegues.Text);
                dtoDA.tallaJug = Convert.ToDecimal(txtTallaControl.Text);
                if (dtoDA.tallaJug > Convert.ToDecimal(txtTallaInicial.Text) && Convert.ToDouble(dtoDA.tallaJug) > 1.55 && Convert.ToDouble(dtoDA.tallaJug) < 2.00)
                {
                    dtoDA.pesoJug = Convert.ToDecimal(txtPesoControl.Text);
                    if (dtoDA.pesoJug > 50 && dtoDA.pesoJug < 90)
                    {
                        dtoDA.codJugador = Request.QueryString["codJugador"];
                        dtoDA.fechaControl = Convert.ToDateTime(txtFechaControl.Text.Trim());
                        cr = new CtrDatoAntropometrico().Usp_DatosAntropometrico_Insert(dtoDA);

                        //CALCULO SOMATOTIPO
                        //Endomorfia
                        //SUBESCAPULAR
                        Decimal supraespinal = Convert.ToDecimal(txtSupraespinalPliegues.Text);
                        //SUPRAILIACO
                        Decimal suprailiaco = Convert.ToDecimal(txtMusloPliegues.Text);
                        //TRICEPS
                        Decimal PlTriceps = Convert.ToDecimal(txtTrícepsPliegues.Text);
                        //Estatura
                        Decimal estatura = Convert.ToDecimal(txtTallaControl.Text);
                        Double e1 = -0.7182;
                        Double e2 = 0.1451;
                        Double e3 = 0.00068;
                        Double e4 = 0.0000014;
                        Double e5 = 170.18;
                        //Calculando X
                        Double X = Convert.ToDouble(PlTriceps + supraespinal + suprailiaco) * (e5 / Convert.ToDouble(estatura));
                        //Calculo endomorfia
                        Double endomorfia = Math.Round(e1 + (e2 * X) - (e3 * Convert.ToDouble(Math.Pow(Convert.ToDouble(X), 2))) + (e4 * Convert.ToDouble(Math.Pow(Convert.ToDouble(X), 3))), 2);
                        //Mostrando endomorfia
                        txtEndomorfia.Text = Convert.ToString(endomorfia);
                        dtoST.endomorfia = Convert.ToDecimal(txtEndomorfia.Text);

                        //Mesomorfia
                        //DH diametro del humero en cm
                        Decimal dhumero = Convert.ToDecimal(txtHumeroLongitud.Text);
                        //DF diametro del femur en cm
                        Decimal dfemur = Convert.ToDecimal(txtFemurLongitud.Text);
                        //PBC perimetro del brazo relajado corregido en cm
                        Decimal pbrazo = Convert.ToDecimal(txtBrazoPerimetro.Text);
                        //PGC perimetro de gemelar o de la pantorrilla corregido en cm
                        Decimal pgemelo = Convert.ToDecimal(txtGemeloPerimetro.Text);
                        Double m1 = 0.858;
                        Double m2 = 0.601;
                        Double m3 = 0.188;
                        Double m4 = 0.161;
                        Double m5 = 0.131;
                        Double m6 = 4.5;
                        //Calculando mesomorfia
                        Double mesomorfia = Math.Round(Convert.ToDouble(m1 * Convert.ToDouble(dhumero) + (m2 * Convert.ToDouble(dfemur)) + (m3 * Convert.ToDouble(pbrazo)) + (m4 * Convert.ToDouble(pgemelo))) - (Convert.ToDouble(estatura) * m5) + m6, 2);
                        //Mostrando mesomorfia
                        txtMesomorfia.Text = Convert.ToString(mesomorfia);
                        dtoST.mesomorfia = Convert.ToDecimal(txtMesomorfia.Text);

                        //Ectomorfia
                        //Peso en kg
                        Decimal peso = Convert.ToDecimal(txtPesoControl.Text);
                        //Indice Ponderal (IP) = estatura/raiz cubica de peso
                        Double raizpeso = Math.Pow(Convert.ToDouble(peso), (Double)1 / 3);
                        //Calculando IP
                        Double indicePonderal = Convert.ToDouble(estatura) / raizpeso;
                        //Calculando ectomorfia
                        Double ectomorfia = 0.0;
                        if (indicePonderal > 40.75) ectomorfia = Math.Round((indicePonderal * 0.732) - 28.58, 2);
                        else if (indicePonderal > 38.28 && indicePonderal < 40.75) ectomorfia = Math.Round((indicePonderal * 0.463) - 17.63, 2);
                        else if (indicePonderal <= 38.28) ectomorfia = 0.1;
                        //Mostrando ectomorfia
                        txtEctomorfia.Text = Convert.ToString(ectomorfia);
                        dtoST.ectomorfia = Convert.ToDecimal(txtEctomorfia.Text);
                        dtoST.codDatosAntropo = dtoDA.codDatosAntropo;
                        cr = new CtrSomatotipo().Usp_Somatotipo_Insert(dtoST);

                        //CALCULANDO SOMATOCARTA
                        //Eje X = Ectomorfia - endomorfia
                        Double ejeX = Math.Round(ectomorfia - endomorfia, 2);
                        //Asignando a textbox ejeX
                        txtEjeX.Text = Convert.ToString(ejeX);
                        dtoSC.ejeX = Convert.ToDecimal(txtEjeX.Text);

                        //Eje Y = (2*Mesomorfia) - (Ectomorfia+Endomorfia)
                        Double ejeY = Math.Round((2 * mesomorfia) - (ectomorfia + endomorfia), 2);
                        //Asignando a textbox ejeY
                        txtEjeY.Text = Convert.ToString(ejeY);
                        dtoSC.ejeY = Convert.ToDecimal(txtEjeY.Text);
                        dtoSC.codSomatotipo = dtoST.codSomatotipo;

                        cr = new CtrSomatocarta().Usp_Somatocarta_Insert(dtoSC);

                        if (!cr.HuboError)
                        {
                            //Response.Write("<script>alert('" + cr.ErrorMsj + "')</script>");
                            Response.Write("<script>alert('Datos Guardados y calculados correctamente')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('" + cr.ErrorMsj + "')</script>");
                        }
                    }
                    else { Response.Write("<script>alert('Peso del jugador debe estar entre los 55 y 90 kg.')</script>"); }
                }
                else { Response.Write("<script>alert('La talla del jugador no puede ser menor a la talla Inicial')</script>"); }
            }
            catch (Exception ex)
            {
            }
            return valido;
        }
        /*
        private bool CalcularSomatotipoSomatocarta()
        {
            bool valido = false;

            try
            {
                ClassResultV cr = new ClassResultV();
                DtoDatoAntropometrico dtoDA = new DtoDatoAntropometrico();
                DtoSomatotipo dtoST = new DtoSomatotipo();
                DtoSomatocarta dtoSC = new DtoSomatocarta();
                //CALCULO SOMATOTIPO
                //Endomorfia
                //SUBESCAPULAR
                Decimal supraespinal = Convert.ToDecimal(txtSupraespinalPliegues.Text);
                //SUPRAILIACO
                Decimal suprailiaco = Convert.ToDecimal(txtMusloPliegues.Text);
                //TRICEPS
                Decimal PlTriceps = Convert.ToDecimal(txtTrícepsPliegues.Text);
                //Estatura
                Decimal estatura = Convert.ToDecimal(txtTallaControl.Text);
                Double e1 = -0.7182;
                Double e2 = 0.1451;
                Double e3 = 0.00068;
                Double e4 = 0.0000014;
                Double e5 = 170.18;
                //Calculando X
                Double X = Convert.ToDouble(PlTriceps + supraespinal + suprailiaco)*(e5/Convert.ToDouble(estatura));
                //Calculo endomorfia
                Double endomorfia = e1+(e2*X)-(e3*Convert.ToDouble(Math.Pow(Convert.ToDouble(X),2)))+(e4*Convert.ToDouble(Math.Pow(Convert.ToDouble(X),3)));
                //Mostrando endomorfia
                txtEndomorfia.Text = Convert.ToString(endomorfia);
                dtoST.ectomorfia = Convert.ToDecimal(txtEndomorfia.Text);

                //Mesomorfia
                //DH diametro del humero en cm
                Decimal dhumero = Convert.ToDecimal(txtHumeroLongitud.Text);
                //DF diametro del femur en cm
                Decimal dfemur = Convert.ToDecimal(txtFemurLongitud.Text);
                //PBC perimetro del brazo relajado corregido en cm
                Decimal pbrazo = Convert.ToDecimal(txtBrazoPerimetro.Text);
                //PGC perimetro de gemelar o de la pantorrilla corregido en cm
                Decimal pgemelo = Convert.ToDecimal(txtGemeloPerimetro.Text);
                Double m1 = 0.858;
                Double m2 = 0.601;
                Double m3 = 0.188;
                Double m4 = 0.161;
                Double m5 = 0.131;
                Double m6 = 4.5;
                //Calculando mesomorfia
                Double mesomorfia = Convert.ToDouble(m1 * Convert.ToDouble(dhumero) + (m2 * Convert.ToDouble(dfemur)) + (m3 * Convert.ToDouble(pbrazo)) + (m4 * Convert.ToDouble(pgemelo))) - (Convert.ToDouble(estatura) * m5) + m6;
                //Mostrando mesomorfia
                txtMesomorfia.Text = Convert.ToString(mesomorfia);
                dtoST.mesomorfia = Convert.ToDecimal(txtMesomorfia.Text);

                //Ectomorfia
                //Peso en kg
                Decimal peso = Convert.ToDecimal(txtPesoControl.Text);
                //Indice Ponderal (IP) = estatura/raiz cubica de peso
                Double raizpeso = Math.Pow(Convert.ToDouble(peso), (Double)1 / 3);
                //Calculando IP
                Double indicePonderal = Convert.ToDouble(estatura) / raizpeso;
                //Calculando ectomorfia
                Double ectomorfia = 0.0;
                if (indicePonderal > 40.75) ectomorfia = (indicePonderal * 0.732) - 28.58;
                else if (indicePonderal > 38.28 && indicePonderal < 40.75) ectomorfia = (indicePonderal * 0.463) - 17.63;
                else if (indicePonderal <= 38.28) ectomorfia = 0.1;
                //Mostrando ectomorfia
                txtEctomorfia.Text = Convert.ToString(ectomorfia);
                dtoST.ectomorfia = Convert.ToDecimal(txtEctomorfia.Text);
                dtoST.codDatosAntropo = dtoDA.codDatosAntropo;
                cr = new CtrSomatotipo().Usp_Somatotipo_Insert(dtoST);

                //CALCULANDO SOMATOCARTA
                //Eje X = Ectomorfia - endomorfia
                Double ejeX = ectomorfia - endomorfia;
                //Asignando a textbox ejeX
                txtEjeX.Text = Convert.ToString(ejeX);
                dtoSC.ejeX = Convert.ToDecimal(txtEjeX.Text);
               
                //Eje Y = (2*Mesomorfia) - (Ectomorfia+Endomorfia)
                Double ejeY = (2.0 * mesomorfia) - (ectomorfia + endomorfia);
                //Asignando a textbox ejeY
                txtEjeY.Text = Convert.ToString(ejeY);
                dtoSC.ejeY = Convert.ToDecimal(txtEjeY.Text);
                dtoSC.codSomatotipo = dtoST.codSomatotipo;

                cr = new CtrSomatocarta().Usp_Somatocarta_Insert(dtoSC);

                if (!cr.HuboError)
                {
                    //Response.Write("<script>alert('" + cr.ErrorMsj + "')</script>");
                    Response.Write("<script>alert('Calculos realizados correctamente')</script>");
                }
                else
                {
                    Response.Write("<script>alert('" + cr.ErrorMsj + "')</script>");
                }
            }
            catch (Exception ex)
            {
            }
            return valido;
        }
         */
        #endregion

        #region Eventos
        protected void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            AgregarNuevoDatoAntropometrico();
        }
        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/contenido/antropometria/frm_VerTodosJugadores.aspx");
        }
        #endregion
    }
}