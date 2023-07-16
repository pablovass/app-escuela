using System.Xml;

namespace escuela_app.Entidades
{
    public class Asignatura : ObjetoEscuelaBase
    {
        public string UniqueId { get; set;} 
        public string Nombre{ get; set;}
        public Asignatura()=>UniqueId=Guid.NewGuid().ToString();
    
    }

}