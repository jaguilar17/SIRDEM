using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoHorarioEntrenamiento : DtoB
    {
        public int codHorarioEntrenamiento { get; set; }
        public String titulo { get; set; }
        public String descripcion { get; set; }
        public DateTime fechaEntrenamiento { get; set; }
        public DateTime horaEntrada { get; set; }
        public DateTime horaSalida { get; set; }
        public int sede { get; set; }
    }
}
