using Escolar.Web.Entities;
using Escolar.Web.Features.Calificaciones;
using Shouldly;
using System.Collections.Generic;

namespace Escolar.Tests.Features
{
    public class CalculoCalificacionesTests
    {
        public void ProbarPromedio()
        {
            var alumno = EntitiesHelper.CrearAlumno();
            var materia = EntitiesHelper.CrearMateria();
            var periodo = EntitiesHelper.CrearPeriodo();

            var calificaciones = new List<Calificacion>
            {
                EntitiesHelper.CalificacionBase10(),
                EntitiesHelper.CalificacionBase10(),
                EntitiesHelper.CalificacionBase10(),
            };

            calificaciones[0].Resultado = 5;
            calificaciones[1].Resultado = 5;
            calificaciones[2].Resultado = 5;

            var resultado = CalculoCalificaciones.ObtenerPromedio(alumno, materia, periodo, calificaciones);

            resultado.Resultado.ShouldBe(5);
        }
    }
}
