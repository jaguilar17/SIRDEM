using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTR
{
    public class CtrCategoria
    {
        public ClassResultV Usp_Categoria_GetAll(TipoCons tip)
        {
            return new DaoCategoria().Usp_Categoria_GetAll(tip);
        }
        public ClassResultV Usp_Categoria_Insert(DtoCategoria dtoBase)
        {
            return new DaoCategoria().Usp_Categoria_Insert(dtoBase);
        }
        public ClassResultV Usp_Categoria_Update(DtoCategoria dtoBase)
        {
            return new DaoCategoria().Usp_Categoria_Update(dtoBase);
        }
    }
}
