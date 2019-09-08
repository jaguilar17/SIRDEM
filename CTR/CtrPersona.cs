using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace CTR
{
    public class CtrPersona
    {
        public DtoPersona Usp_Persona_Insert(DtoPersona dto)
        {
            return new DaoPersona().Usp_Persona_Insert(dto);
        }
        //public ClassResultV Usp_Persona_GetAllByJugador()
        //{
        //    return new DaoPersona().Usp_Persona_GetAllByJugador();
        //}
        //public ClassResultV Consultar_Personas() 
        //{
        //    return new DaoPersona().Consultar_Jugadores();
        //}
        //public DtoPersona Usp_PersonaJugador_CambioEstado(DtoPersona dto)
        //{
        //    return new DaoPersona().Usp_PersonaJugador_CambioEstado(dto);
        //}
    }
}
