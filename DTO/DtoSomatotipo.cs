using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoSomatotipo:DtoB
    {
        public String codSomatotipo { get; set; }
        public Decimal ectomorfia { get; set; }
        public Decimal mesomorfia { get; set; }
        public Decimal endomorfia { get; set; }
        public String codDatosAntropo { get; set; }
    }
}
