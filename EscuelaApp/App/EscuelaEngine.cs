using System.Collections.Generic;
using EscuelaApp.Entidades;


namespace EscuelaApp
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {

        }
        public void Incializar()
        {

            Escuela = new Escuela("SchoolPorDefecto", 2021, TiposEscuela.Secundaria, "Argentina", "BA");

            Escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana.ToString() },
                new Curso(){ Nombre = "201", Jornada = TiposJornada.Noche.ToString() },
                new Curso(){ Nombre = "406", Jornada = TiposJornada.Mañana.ToString() },
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Noche.ToString() },
                new Curso(){ Nombre = "401", Jornada = TiposJornada.Noche.ToString() },
                new Curso(){ Nombre = "501", Jornada = TiposJornada.Mañana.ToString() }
            };


        }
    }
}