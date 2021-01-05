using System;

namespace EscuelaApp.Entidades
{
    public class Curso
    {
        public string Nombre { get;  set; }  
        public string UniqueId{ get;private set; }// el get es privado

        public string Jornada{ get; set; }
/*
        public Curso()
        {
            UniqueId = Guid.NewGuid().ToString(); // id aleatorio
            
        }*/
       
        public Curso()=>UniqueId = Guid.NewGuid().ToString(); // id aleatorio
            
       
    }
}