using Escolar.Web.Entities;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escolar.Tests.Entities
{
    public class AlumnoTests
    {
        public void NombreCompletoTest()
        {
            var alumno = CrearAlumno();

            alumno.NombreCompleto.ShouldBe($"{alumno.ApellidoPaterno} {alumno.ApellidoMaterno}, {alumno.Nombre}");
        }

        private Alumno CrearAlumno()
        {
            return new Alumno
            {
                Nombre = Guid.NewGuid().ToString(),
                ApellidoMaterno = Guid.NewGuid().ToString(),
                ApellidoPaterno = Guid.NewGuid().ToString(),
                FechaDeNacimiento = DateTime.Now.AddYears(-10)
            };
        }
    }   
}
