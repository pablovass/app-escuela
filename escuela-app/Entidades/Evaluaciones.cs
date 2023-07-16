using System.Xml;

namespace escuela_app.Entidades
{
    public class Evaluaciones
    {
        public string UniqueId { get; set;} 
        public string Name { get; set;}
        public Alumno Alumno { get; set;}
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }
        public Evaluaciones()=>UniqueId=Guid.NewGuid().ToString();
    
    }

}