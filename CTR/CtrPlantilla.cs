using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace CTR
{
    public class CtrPlantilla
    {
        public ClassResultV Usp_Plantilla_Insert(DtoPlantilla dto)
        {
            return new DaoPlantilla().Usp_Plantilla_Insert(dto);
        }
        public ClassResultV Usp_PlantillaxEquipo_GetAll(DtoPlantilla dto)
        {
            return new DaoPlantilla().Usp_PlantillaxEquipo_GetAll(dto);
        }
        public ClassResultV Usp_TotalJugadores_GetAll()
        {
            return new DaoPlantilla().Usp_TotalJugadores_GetAll();
        }
    }
}
