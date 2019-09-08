using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace CTR
{
    public class CtrSomatotipo
    {
        public ClassResultV Usp_Somatotipo_Insert(DtoSomatotipo dtoBase)
        {
            return new DaoSomatotipo().Usp_Somatotipo_Insert(dtoBase);
        }
    }
}
