using System;
using System.Collections.Generic;

namespace EscuelaApp5._0.Entidades
{
    public class Curso
    {
        public string Nombre { get;  set; }  
        public string UniqueId{ get;private set; }// el get es privado

        public string Jornada{ get; set; }
        public List<Asignatura> Asignaturas {get; set;}
        public List<Alumno> Alumnos {get; set;}
/*
        public Curso()
        {
            UniqueId = Guid.NewGuid().ToString(); // id aleatorio
            
        }*/
       
        public Curso()=>UniqueId = Guid.NewGuid().ToString(); // id aleatorio
            
       
    }
}