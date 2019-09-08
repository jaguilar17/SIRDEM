using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoEquipo : DtoB
    {
        public String codEquipo { get; set; }
        public String equipoNombre { get; set; }
        public String equipoDescripcion { get; set; }
        public String equipoDirectorTecnico { get; set; }
        public String equipoAsistenteTecnico { get; set; }
        public int numMaxJugador { get; set; }
        public Boolean IB_Mostrar { get; set; }
        public String codTemporada { get; set; }
        public String temporadaNombre { get; set; }
    }
}
