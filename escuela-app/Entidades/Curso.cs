using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace escuela_app.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
      
       //es lo mismo que un constructor construidos con llaves 
        public Curso()=> UniqueId = Guid.NewGuid().ToString();
        
    }

}