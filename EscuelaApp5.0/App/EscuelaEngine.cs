using System;
using System.Collections.Generic;
using EscuelaApp5._0.Entidades;


namespace EscuelaApp5._0
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

            CargarCursos();
            CargarAlumnos();
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            throw new NotImplementedException();
        }

        private void CargarAlumnos()
        {
            throw new NotImplementedException();
        }

        private void CargarCursos()
        {
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