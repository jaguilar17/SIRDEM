using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
namespace CTR
{
    public class BL_Pruebas
    {
        DA_Prueba objpruDA;
        DA_PruebaPS objpruPSDA;
        DA_PruebaPD objpruDESDA;
        DA_PruebaPF objpruFISDA;
        DA_Nota_Informes objni;

        BE_Prueba objPru;
        BE_PS objPruPsi;
        BE_PD objPruDes;
        BE_PF objPruFis;
        BE_Jugador objJugador;
        public BL_Pruebas()
        {
            objpruDA = new DA_Prueba();
            objpruPSDA = new DA_PruebaPS();
            objpruDESDA = new DA_PruebaPD();
            objpruFISDA = new DA_PruebaPF();
            objni= new DA_Nota_Informes();
        }

        public void RegistrarPrueba(BE_Prueba objPr)
        {

            objPru = new BE_Prueba();
            objpruDA.InsertarPrueba(objPr);
        }
        public void RegistrarPPS(BE_PS objPP)
        {

            objPruPsi = new BE_PS();
            objpruPSDA.InsertarPPS2(objPP);
        }
        public void RegistrarPPD(BE_PD objPD) 
        {
            objPruDes = new BE_PD();
            objpruDESDA.InsertarPPD(objPD);
        }
        public void RegistrarPPF(BE_PF objPF)
        {
            objPruFis = new BE_PF();
            objpruFISDA.InsertarPPF(objPF);
        }
        public DataTable ConsultarPruebasJugador(string cod) 
        {
            
           try { 
            objJugador= new BE_Jugador();
                 objJugador.Codjugador=cod;
                return objpruDA.cosultarPrueba(objJugador);
           }
           catch (Exception exc)
           {
               throw exc;
           }
        }
        public DataTable ConsultaPersonaJugado() 
        {
            try {
                return objpruDA.SelectJugador();
            }
            catch (Exception exa) 
            {
                throw exa;
            }
        }

         //Buscar Pruebas para los repotes e informes
       
    }
}
