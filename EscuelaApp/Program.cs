using System;
using EscuelaApp.Entidades;
using static System.Console; // me va omitir la palabra console

namespace EscuelaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //objeto de parametro obcionales 
            var escuela = new Escuela("SchoolPorDefecto", 2021, TiposEscuela.Secundaria, "Argentina", "BA");


            escuela.Cursos = new Curso[]{
                new Curso(){Nombre = "101"},
                new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"}
            };

            ImprimirCursosEscuela(escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("=========================");
            WriteLine("Cursos de la escuela");
            WriteLine("=========================");

            //evitamos crash por valores nulos
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, id {curso.UniqueId} ");
                }
            }

        }

        private static void ImprimirCurso(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre {curso.Nombre}, id {curso.UniqueId} ");
            }
        }


    }
}
