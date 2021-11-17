using System;
using System.Collections.Generic;

namespace EscuelaAppPoo.Entidades
{
    public class Alumno:ObjetoEscuelaBase
    {
        public List<Evaluacion> Evaluaciones {get; set;}= new List<Evaluacion>();
      
            
    }
} 