using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoTemporada:DtoB
    {
        public String codTemporada { get; set; }
        public String temporadaNombre { get; set; }
        public DateTime temporadaFechaInicio { get; set; }
        public int temporadaDuracionDias { get; set; }
        public Boolean IB_Mostrar { get; set; }

        public DateTime temporadaFechaFin { get; set; }
    }
}
