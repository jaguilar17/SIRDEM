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
    public class CtrSede
    {
        DaoSede objSedeDao;
        DtoSede objSedeDto;

        public CtrSede()
        {
            objSedeDao = new DaoSede();
        }

        public void Usp_Sede_Insert(DtoSede dto)
        {
            objSedeDto = new DtoSede();
            objSedeDao.Usp_Sede_Insert(dto);
        }

        public void Usp_Sede_Update(DtoSede dto)
        {
            objSedeDto = new DtoSede();
            objSedeDao.Usp_Sede_Update(dto);
        }

        public void Usp_Sede_Delete(DtoSede dto)
        {
            objSedeDto = new DtoSede();
            objSedeDao.Usp_Sede_Delete(dto);
        }

        public DataTable ConsultarSedes()
        {
            try
            {
                return objSedeDao.SelectSedes();
            }
            catch (Exception exa)
            {
                throw exa;
            }
        }

        public bool BuscarSede(DtoSede objSedeBE)
        {
            return objSedeDao.SelectBuscarSede(objSedeBE);
        }


    }

}
