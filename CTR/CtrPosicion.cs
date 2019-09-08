using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace CTR
{
    public class CtrPosicion
    {
        public ClassResultV Usp_Posicion_GetAll()
        {
            return new DaoPosicion().Usp_Posicion_GetAll();
        }
        public ClassResultV Usp_PosicionPrincipal_All()
        {
            return new DaoPosicion().Usp_PosicionPrincipal_All();
        }
        public ClassResultV Usp_PosicionAlternativa_All()
        {
            return new DaoPosicion().Usp_PosicionAlternativa_All();
        }
    }
}
