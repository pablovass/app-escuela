using System;
using System.Collections.Generic;

namespace EscuelaAppPoo.Entidades
{
    public class Curso : ObjetoEscuelaBase
    {
        public string Jornada{ get; set; }
        public List<Asignatura> Asignaturas {get; set;}
        public List<Alumno> Alumnos {get; set;}

    }
}