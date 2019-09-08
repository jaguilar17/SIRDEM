using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace CTR
{
    public class CtrTemporada
    {
        public ClassResultV Usp_TemporadaNombres_GetAll(TipoCons tip)
        {
            return new DaoTemporada().Usp_TemporadaNombres_GetAll(tip);
        }
        public ClassResultV Usp_Temporada_GetAll(TipoCons tip)
        {
            return new DaoTemporada().Usp_Temporada_GetAll(tip);
        }
        public ClassResultV Usp_Temporada_Insert(DtoTemporada dtoBase)
        {
            return new DaoTemporada().Usp_Temporada_Insert(dtoBase);
        }
        public ClassResultV Usp_Temporada_Update(DtoTemporada dtoBase)
        {
            return new DaoTemporada().Usp_Temporada_Update(dtoBase);
        }
    }
}
