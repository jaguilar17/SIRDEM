using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace CTR
{
    public class CtrPerfil
    {
        public ClassResultV Usp_Perfil_GetAll()
        {
            return new DaoPerfil().Usp_Perfil_GetAll();
        }
        public DtoPerfil Usp_Perfil_Insert(DtoPerfil dto)
        {
            return new DaoPerfil().Usp_Perfil_Insert(dto);
        }
    }
}
