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
    public class BL_Nota_Informe
    {
        DA_Prueba objpruDA;
        DA_PruebaPS objpruPSDA;
        DA_PruebaPD objpruDESDA;
        DA_PruebaPF objpruFISDA;
        DA_Nota_Informes objni;

        public BL_Nota_Informe()
        {
            objpruDA = new DA_Prueba();
            objpruPSDA = new DA_PruebaPS();
            objpruDESDA = new DA_PruebaPD();
            objpruFISDA = new DA_PruebaPF();
            objni= new DA_Nota_Informes();
        }
        public bool BuscarPrueba(BE_Prueba objPr)
        {
            return objni.SelectPrueba(objPr);
        }

        public bool BuscarPruebaD(BE_PD objPr)
        {
            return objni.SelectPruebaD(objPr);
        }

        public bool BuscarPruebaF(BE_PF objPr)
        {
            return objni.SelectPruebaF(objPr);
        }

        public bool BuscarPruebaPS(BE_PS objPr)
        {
            return objni.SelectPruebaPS(objPr);
        }
    }
}
