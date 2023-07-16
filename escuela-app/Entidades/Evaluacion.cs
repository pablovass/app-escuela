using System;

namespace escuela_app.Entidades
{
    public class Evaluacion : ObjetoEscuelaBase
    {
        public Alumno Alumno{ get; set; }
        public Asignatura Asignatura{get; set;}
        public float Nota { get; set; }
        
        // me permite ver los datos a la hora de hacer el debuguer
        public override string ToString()
        {
            return $"{Nota},{Alumno.Nombre},{Asignatura.Nombre}";
        }  
    
    }
  
}