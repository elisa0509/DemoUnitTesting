using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escolar.Web.Entities
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string NombreCompleto => $"{ApellidoPaterno} {ApellidoMaterno}, {Nombre}";

        // 
       // public int Edad => DateTime.Now.Subtract(FechaDeNacimiento).

    }
}
