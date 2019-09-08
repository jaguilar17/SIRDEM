using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace CTR
{
    public class CtrUsuario
    {
        public DtoUsuario iniciarSesion(DtoUsuario obj_Usuario)
        {
            DaoUsuario objDao_Usuario = new DaoUsuario();
            return objDao_Usuario.iniciarSesion(obj_Usuario);
        }
        public DtoUsuario Usp_Usuario_Insert(DtoUsuario dto)
        {
            return new DaoUsuario().Usp_Usuario_Insert(dto);
        }
        public ClassResultV Usp_PersonaDirectorTecnico_GetAll(TipoCons tip)
        {
            return new DaoUsuario().Usp_PersonaDirectorTecnico_GetAll(tip);
        }
        public ClassResultV Usp_PersonaAsistenteTecnico_GetAll(TipoCons tip)
        {
            return new DaoUsuario().Usp_PersonaAsistenteTecnico_GetAll(tip);
        }
    }
}
