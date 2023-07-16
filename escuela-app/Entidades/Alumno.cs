using System;

namespace escuela_app.Entidades
{
    public class Alumno : ObjetoEscuelaBase
    {
        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
    }

}