using System;
namespace EscuelaApp.Entidades
{
    public class Asignatura
    {
        public string Nombre { get;  set; }  
        public string UniqueId{ get;private set; }// el get es privado

       
        public Asignatura()=>UniqueId = Guid.NewGuid().ToString(); // id aleatorio
            
    }
} 