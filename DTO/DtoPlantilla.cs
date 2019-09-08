using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoPlantilla : DtoB
    {
        public String codPlantilla { get; set; }
        public String codEquipo { get; set; }
        public String codJugador { get; set; }
        public Boolean IB_Mostrar { get; set; }

        public String nombreCompleto { get; set; }
        public String equipoNombre { get; set; }
        public String descripcionPosicion { get; set; }

        public String talla { get; set; }
        public String peso { get; set; }
        
    }
}
