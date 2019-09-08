using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoDatoAntropometrico : DtoB
    {
        public String codDatosAntropo { get; set; }
        public Decimal brazoPerimetro { get; set; }
        public Decimal pechoPerimetro { get; set; }
        public Decimal abdomenPerimetro { get; set; }
        public Decimal caderaPerimetro { get; set; }
        public Decimal musloPerimetro { get; set; }
        public Decimal gemeloPerimetro { get; set; }
        public Decimal humeroLongitud { get; set; }
        public Decimal femurLongitud { get; set; }
        public Decimal munecaLongitud { get; set; }
        public Decimal triceps { get; set; }
        public Decimal musloPliegues { get; set; }
        public Decimal supraespinal { get; set; }
        public Decimal pectoral { get; set; }
        public Decimal abdominal { get; set; }
        public Decimal gemeloPliegues { get; set; }
        public Decimal tallaJug { get; set; }
        public Decimal pesoJug { get; set; }
        public String codJugador {get; set;}
        public DateTime fechaControl { get; set; }
    }
}
