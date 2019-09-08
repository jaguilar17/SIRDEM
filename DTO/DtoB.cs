using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace DTO
{
    [Serializable]
    public class DtoB : ClassResultV, ICloneable
    {
        private string _msjError;
        private string criterio;
        //private int cantidadAsignaciones;
        [Browsable(false)]
        public string MsjError
        {
            get { return _msjError; }
            set { _msjError = value; }
        }

        [Browsable(false)]
        public DtoB Error(string msj)
        {
            _msjError = msj;
            return this;
        }

        [Browsable(false)]
        public string Criterio
        {
            get { return criterio; }
            set { criterio = value; }
        }

        #region Miembros de ICloneable

        object ICloneable.Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
}
