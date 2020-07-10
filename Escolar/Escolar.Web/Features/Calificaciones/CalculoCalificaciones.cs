using Escolar.Web.Entities;
using System;
using System.Collections.Generic;

namespace Escolar.Web.Features.Calificaciones
{
    public static class CalculoCalificaciones
    {
        public static Calificacion ObtenerPromedio(Alumno alumno, Materia materia, Periodo periodo, List<Calificacion> calificaciones, int redondeoDecimales )
        {
            //regla de negocio: ignorar resultados nulos al hacer el promedio
            var contador = 0;
            decimal suma = 0;

            foreach (var item in calificaciones)
            {
                if(item.Resultado.HasValue)
                {
                    contador++;
                    suma += item.Resultado.Value;
                }
            }

            decimal? resultado = null;
            if( contador > 0 )
            {
                resultado = Math.Round(suma / contador, redondeoDecimales);
            }

            return new Calificacion {
                Alumno = alumno,
                Materia = materia,
                Periodo = periodo,
                Resultado = resultado,
                ResultadoTexto = resultado.HasValue ? resultado.Value.ToString() : null
            };
        }
    }
}
