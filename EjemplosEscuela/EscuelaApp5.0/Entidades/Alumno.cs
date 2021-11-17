using System;
using System.Collections.Generic;

namespace EscuelaApp5._0.Entidades
{
    public class Alumno
    {
        public string Nombre { get;  set; }  
        public string UniqueId{ get;private set; }// el get es privado
        public List<Evaluaciones> Evaluacion {get; set;}
        
        public Alumno()=>UniqueId = Guid.NewGuid().ToString(); // id aleatorio
            
    }
} 