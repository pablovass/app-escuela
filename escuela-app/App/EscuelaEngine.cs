
using escuela_app.Entidades;

namespace escuela_app.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }
        public void Inicializar()
        {
            Escuela = new Escuela("Vass School", 2023, TiposEscuela.Secundaria,
                    ciudad: "Bogota", pais: "Argentina");

            Escuela.Cursos = new List<Curso>(){
                    new Curso { Nombre = "101",Jornada=TiposJornada.Mañana },
                    new Curso { Nombre = "201" ,Jornada=TiposJornada.Mañana},
                    new Curso { Nombre = "301",Jornada=TiposJornada.Mañana },
                     new Curso { Nombre = "401",Jornada=TiposJornada.Tarde},
                    new Curso { Nombre = "501" ,Jornada=TiposJornada.Tarde},
            };


        }
    }
}
