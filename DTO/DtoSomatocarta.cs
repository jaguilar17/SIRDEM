using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoSomatocarta:DtoB
    {
        public String codSomatocarta { get; set; }
        public Decimal ejeX { get; set; }
        public Decimal ejeY { get; set; }
        public String codSomatotipo { get; set; }
    }
}
