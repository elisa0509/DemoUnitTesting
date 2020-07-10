using Escolar.Web.Entities;
using System;

namespace Escolar.Tests
{
    public static class EntitiesHelper
    {
        public static readonly Random Random = new Random();
        public static Alumno CrearAlumno()
        {
            return new Alumno
            {
                Id = Random.Next(),
                Nombre = Guid.NewGuid().ToString(),
                ApellidoMaterno = Guid.NewGuid().ToString(),
                ApellidoPaterno = Guid.NewGuid().ToString(),
                FechaDeNacimiento = DateTime.Now.AddYears(-10)
            };
        }

        public static Materia CrearMateria ()
        {
            return new Materia
            {
                Id = Random.Next(),
                Nombre = Guid.NewGuid().ToString(),
            };
        }
        public static Periodo CrearPeriodo()
        {
            return new Periodo
            {
                Id = Random.Next(),
                Nombre = Guid.NewGuid().ToString(),
            };
        }

        public static Calificacion CalificacionBase10(bool resultadoNulo = false)
        {
            var resultado = new Calificacion
            {
                Alumno = CrearAlumno(),
                Materia = CrearMateria(),
                Periodo = CrearPeriodo()
            };

            if(!resultadoNulo)
            {
                resultado.Resultado = Random.Next(0, 10);
            }

            return resultado;
        }

        public static Calificacion CalificacionBase100(bool resultadoNulo = false)
        {
            var resultado = new Calificacion
            {
                Alumno = CrearAlumno(),
                Materia = CrearMateria(),
                Periodo = CrearPeriodo()
            };

            if (!resultadoNulo)
            {
                resultado.Resultado = Random.Next(0, 100);
            }

            return resultado;
        }
    }
}
