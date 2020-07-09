using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escolar.Web.Entities
{
    public class Calificacion
    {
        public Alumno Alumno { get; set; }
        public Materia Materia { get; set; }
        public Periodo Periodo { get; set; }
        public decimal? Resultado { get; set; }
        public string ResultadoTexto { get; set; }

    }
}
