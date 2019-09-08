using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace CTR
{
    public class CtrDatoAntropometrico
    {
        public ClassResultV Usp_DatosAntropometrico_Insert(DtoDatoAntropometrico dtoBase)
        {
            return new DaoDatoAntropometrico().Usp_DatosAntropometrico_Insert(dtoBase);
        }
    }
}
