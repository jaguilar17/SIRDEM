using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace CTR
{
    public class CtrlHorarioEntrenamiento
    {
        public ClassResultV Consultar_HorarioEntrenamiento()
        {
            return new DaoHorarioEntrenamiento().Consultar_HorarioEntrenamiento();
        }
        public ClassResultV Consultar_Modificar_HorarioEntrenamiento()
        {
            return new DaoHorarioEntrenamiento().Consultar_Modificar_HorarioEntrenamiento();
        }

        //Update_HorariosEntrenamiento
        public ClassResultV Update_HorariosEntrenamiento(DtoB dtoB)
        {
            return new DaoHorarioEntrenamiento().Update_HorariosEntrenamiento(dtoB);
        }

        //SelectConvocatorias
        public ClassResultV SelectConvocatorias()
        {
            return new DaoHorarioEntrenamiento().SelectConvocatorias();
        }
        public ClassResultV SelectTemporadas()
        {
            return new DaoHorarioEntrenamiento().SelectTemporadas();
        }

        // SelectAll_EventoActive
        public ClassResultV SelectAll_EventoActive()
        {
            return new DaoHorarioEntrenamiento().SelectAll_EventoActive();
        }

        public static List<CalendarEvent> getEvents(DateTime start, DateTime end)
        {
            return new DaoHorarioEntrenamiento().getEvents(start,end);
        }

        //CALENDARIONF
        public ClassResultV addEvent(DtoHorarioEntrenamiento dto)
        {
            return new DaoHorarioEntrenamiento().registrarHorario(dto);
        }
        public ClassResultV updateEvent(DtoHorarioEntrenamiento dto)
        {
            return new DaoHorarioEntrenamiento().modificarHorario(dto);
        }
        public ClassResultV deleteEvent(DtoHorarioEntrenamiento dto)
        {
            return new DaoHorarioEntrenamiento().eliminarHorario(dto);
        }
    }
}
