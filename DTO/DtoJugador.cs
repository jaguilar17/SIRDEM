using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoJugador : DtoB
    {
        public String codJugador { get; set; }
        public String aliasDeportivo { get; set; }
        public int numDorsal { get; set; }
        public String clubProcedencia { get; set; }
        public String lateralidad { get; set; }
        public String posicionPrincipal { get; set; }
        public String posicionAlternativa { get; set; }
        public Decimal pesoInicial { get; set; }
        public Decimal tallaInicial { get; set; }
        public String anio { get; set; }
        public String mes { get; set; }
        public String codUsuario { get; set; }
        public String codEquipo { get; set; }
        public DateTime jugadorFechaNac { get; set; }

        public String jugadorCompleto { get; set; }
        public String equipoNombre { get; set; }

        public String nombresyap { get; set; }
        public String descripcionPosicion { get; set; }

        public Decimal ectomorfia { get; set; }
        public Decimal mesomorfia { get; set; }
        public Decimal endomorfia { get; set; }
        public Decimal ejeX { get; set; }
        public Decimal ejeY { get; set; }
        public DateTime fechaControl { get; set; }
    }
}
