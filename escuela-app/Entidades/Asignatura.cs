using System.Xml;

namespace escuela_app.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; set;} 
        public string Name { get; set;}
        public Asignatura()=>UniqueId=Guid.NewGuid().ToString();
    
    }

}