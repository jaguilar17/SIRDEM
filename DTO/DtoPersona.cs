using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoPersona : DtoB
    {
        public String codPersona { get; set; }
        public String personaNombre { get; set; }
        public String personaApePaterno { get; set; }
        public String personaApeMaterno { get; set; }
        public DateTime personaFechaNac { get; set; }
        public int personaNumDNI { get; set; }
        public int personaTelefono { get; set; }
        public String personaCorreo { get; set; }
        public String personaDireccion { get; set; }
        public String anio { get; set; }
        public String mes { get; set; }
        public String codUsuario { get; set; }
    }
}
