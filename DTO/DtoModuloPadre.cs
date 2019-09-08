using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoModuloPadre
    {
        public int codModuloPadre { get; set; }
        public string nombreExterno { get; set; }
        public string nombreInterno { get; set; }
        public string descripcion { get; set; }
        public string iconoCss { get; set; }
        List<DtoModulo> _listaInterfaces = new List<DtoModulo>();

        public List<DtoModulo> listaInterfaces
        {
            get { return _listaInterfaces; }
            set { _listaInterfaces = value; }
        }
    }
}
