using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTR
{
    public class CtrCategoriaGeneral
    {
        public ClassResultV Usp_CategoriaGeneral_GetAll(TipoCons tip)
        {
            return new DaoCategoriaGeneral().Usp_CategoriaGeneral_GetAll(tip);
        }
    }
}
