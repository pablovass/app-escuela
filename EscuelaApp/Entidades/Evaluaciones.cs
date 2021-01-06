using System;
namespace EscuelaApp.Entidades
{
    public class Evaluaciones
    {

        public string UniqueId { get; private set; }// el get es privado
        public string Nombre { get; set; }
       
        public Alumno Alumno{ get; set; }
         public Asignatura Asignatura{get; set;}
         public float Nota { get; set; }
      
        public Asignatura()=>UniqueId = Guid.NewGuid().ToString(); // id aleatorio
  } 
  }