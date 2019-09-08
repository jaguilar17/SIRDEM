using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoCategoriaGeneral : DtoB
    {
        public String codCategGen{ get; set; }
        public String nombreCategGen { get; set; }
        public Boolean IB_Mostrar { get; set; }
    }
}
