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
    public class CtrJugador
    {
        //public DataSet Select_Usp_Persona_GetAllByJugador()
        //{
        //    return new DaoJugador().Select_Usp_Persona_GetAllByJugador();
        //}
        public DtoJugador Usp_Jugador_Insert(DtoJugador dto)
        {
            return new DaoJugador().Usp_Jugador_Insert(dto);
        }
        public ClassResultV Usp_DatosxJugador_Antropometria(DtoB dtoBase)
        {
            return new DaoJugador().Usp_DatosxJugador_Antropometria(dtoBase);
        }
        public ClassResultV Consultar_Jugadores()
        {
            return new DaoJugador().Consultar_Jugadores();
        }
        public ClassResultV Usp_Jugador_NombrePosicion(DtoB dtoBase)
        {
            return new DaoJugador().Usp_Jugador_NombrePosicion(dtoBase);
        }
        public ClassResultV Usp_UltimoRegistroAntropometricoxJugador(DtoB dtoBase)
        {
            return new DaoJugador().Usp_UltimoRegistroAntropometricoxJugador(dtoBase);
        }
        public ClassResultV Usp_ResultadosAntropometricosxJugador_GetAll(DtoB dtoBase)
        {
            return new DaoJugador().Usp_ResultadosAntropometricosxJugador_GetAll(dtoBase);
        }
        //public ClassResultV Usp_Jugador_Insert2(DtoJugador dto)
        //{
        //    return new DaoJugador().Usp_Jugador_Insert2(dto);
        //}
    }
}
