using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace CTR
{
    public class CtrSomatocarta
    {
        public ClassResultV Usp_Somatocarta_Insert(DtoSomatocarta dtoBase)
        {
            return new DaoSomatocarta().Usp_Somatocarta_Insert(dtoBase);
        }
    }
}
