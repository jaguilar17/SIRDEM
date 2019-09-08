using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes
{
    public class ResultadoTransaccion
    {
        TipoResultadoTransaccion.Tipo _TipoResultado;
        System.Exception _ObjExcepcion;
        Int64 _TipoError;

        public ResultadoTransaccion(TipoResultadoTransaccion.Tipo pTipoResultado, Exception pException, String argClase, String argFuncion)
        {
            _TipoResultado = pTipoResultado;
            _ObjExcepcion = pException;
            _TipoError = 0;
        }
        public TipoResultadoTransaccion.Tipo TipoResultado
        {
            get { return _TipoResultado; }
            set { _TipoResultado = value; }
        }
        public System.Exception ObjExcepcion
        {
            get { return _ObjExcepcion; }
            set { _ObjExcepcion = value; }
        }
        public Int64 TipoError
        {
            get { return _TipoError; }
            set { _TipoError = value; }
        }
    }
}
