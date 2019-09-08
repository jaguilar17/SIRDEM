using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoModulo
    {
        public int codModulo { get; set; }
        public string nombre { get; set; }
        public int codModuloPadre { get; set; }
        public string descripcion { get; set; }
        public string url { get; set; }
    }
}
