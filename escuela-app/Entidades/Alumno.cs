using System.Xml;

namespace escuela_app.Entidades
{
    public class Alumno
    {
        public string UniqueId { get; set;} 
        public string Name { get; set;}
        public Alumno()=>UniqueId=Guid.NewGuid().ToString();
    
    }

}