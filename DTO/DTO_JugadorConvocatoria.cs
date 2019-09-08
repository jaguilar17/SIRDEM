using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_JugadorConvocatoria : DtoB
    {
        public String codJugadorConvocatoria { get; set; }
        public String clubProcedencia { get; set; }
        public String lateralidad { get; set; }
        public String posicionPrincipal { get; set; }
        public String posicionAlternativa { get; set; }
        public Decimal pesoInicial { get; set; }
        public Decimal tallaInicial { get; set; }
        public String anio { get; set; }
        public String mes { get; set; }
        public DateTime jugadorFechaNac { get; set; }
        public String nombres { get; set; }
        public String apellidoPaterno { get; set; }
        public String apellidoMaterno { get; set; }
        public Boolean ib_estado { get; set; }

        public String email { get; set; }
        public String dni { get; set; }
        public String telefono { get; set; }

    }
}
