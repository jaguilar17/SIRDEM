using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoUsuario : DtoB
    {
        #region Atributos

        public String codUsuario { get; set; }
        public int codPerfil { get; set; }
        public String usuario { get; set; }
        public String usuarioClave { get; set; }
        public String usuarioNombre { get; set; }
        public String usuarioApePaterno { get; set; }
        public String usuarioApeMaterno { get; set; }
        public String usuarioCorreo { get; set; }
        public String usuarioDireccion { get; set; }
        public int usuarioNumDNI { get; set; }
        public int usuarioTelefono { get; set; }
        public String usuarioEstado { get; set; }
        //public String correoElectronico { get; set; }
        public String anio { get; set; }
        public String mes { get; set; }
        //Dt o At nombres completos
        public String personaDatos { get; set; }

        List<DtoModuloPadre> _InterfacesPadre;

        public List<DtoModuloPadre> InterfacesPadre
        {
            get { return _InterfacesPadre; }
            set { _InterfacesPadre = value; }
        }
        #endregion

    }
}
