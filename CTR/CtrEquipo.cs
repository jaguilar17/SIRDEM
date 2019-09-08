using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTR
{
    public class CtrEquipo
    {
        public ClassResultV Usp_GetEquipoByCodTemporada(TipoCons tip, DtoB dto)
        {
            return new DaoEquipo().Usp_GetEquipoByCodTemporada(tip, dto);
        }
        public ClassResultV Usp_EquipoNombres_GetAll(TipoCons tip)
        {
            return new DaoEquipo().Usp_EquipoNombres_GetAll(tip);
        }
        public ClassResultV Usp_Equipo_GetAll(TipoCons tip)
        {
            return new DaoEquipo().Usp_Equipo_GetAll(tip);
        }
        public ClassResultV Usp_Equipo_Insert(DtoEquipo dtoBase)
        {
            return new DaoEquipo().Usp_Equipo_Insert(dtoBase);
        }
        public ClassResultV Usp_Equipo_Update(DtoEquipo dtoBase)
        {
            return new DaoEquipo().Usp_Equipo_Update(dtoBase);
        }
        public ClassResultV Usp_EstadoEquipoByCupos_Update(DtoEquipo dtoBase)
        {
            return new DaoEquipo().Usp_EstadoEquipoByCupos_Update(dtoBase);
        }
        /*
        public ClassResultV Usp_EquipoClub_GetAll(TipoCons tip)
        {
            return new DaoEquipo().Usp_EquipoClub_GetAll(tip);
        }

     
         */
    }
}
