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

            var resultado = CalculoCalificaciones.ObtenerPromedio(alumno, materia, periodo, calificaciones, 0);

            resultado.Resultado.ShouldBe(5.1m);
        }

        public void ProbarPromedioConResultadosNulos()
        {
            var alumno = EntitiesHelper.CrearAlumno();
            var materia = EntitiesHelper.CrearMateria();
            var periodo = EntitiesHelper.CrearPeriodo();

            var calificaciones = new List<Calificacion>
            {
                EntitiesHelper.CalificacionBase10(),
                EntitiesHelper.CalificacionBase10(true),
                EntitiesHelper.CalificacionBase10(true),
            };

            calificaciones[0].Resultado = 5;

            var resultado = CalculoCalificaciones.ObtenerPromedio(alumno, materia, periodo, calificaciones, 1);

            resultado.Resultado.ShouldBe(5);
        }

        public void ProbarPromedioConResultadosConDecimales()
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
            calificaciones[1].Resultado = 6;
            calificaciones[2].Resultado = 6;

            var resultado = CalculoCalificaciones.ObtenerPromedio(alumno, materia, periodo, calificaciones, 1);

            resultado.Resultado.ShouldBe(5.6m);
        }
    }
}
