using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoCategoria : DtoB
    {
        public String codCategoria { get; set; }
        public String nombre { get; set; }
        public Boolean IB_Mostrar { get; set; }
    }
}
