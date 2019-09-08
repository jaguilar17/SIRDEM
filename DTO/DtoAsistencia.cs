using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoAsistencia : DtoB
    {
        public String codJugador { get; set; }
        public int codHorarioEntrenamiento { get; set; }
        public String asistencia { get; set; }

        public String nombresyap { get; set; }
    }
}
