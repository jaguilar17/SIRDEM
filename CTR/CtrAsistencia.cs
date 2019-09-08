using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace CTR
{
    public class CtrAsistencia
    {
        public DtoAsistencia Insertar_Asistencia(DtoAsistencia dto)
        {
            return new DaoAsistencia().Insertar_Asistencia(dto);
        }

        public ClassResultV Consultar_Jugadores_Asistencia(string codigo)
        {
            return new DaoAsistencia().Consultar_Jugadores_Asistencia(codigo);
        }
        public DtoAsistencia Modificar_Asistencia(DtoAsistencia dto)
        {
            return new DaoAsistencia().Modificar_Asistencia(dto);
        }
    }
}
