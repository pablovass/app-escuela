using System;
using EscuelaApp.Entidades;

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
            
         InprimirCursosEscuela(escuela);
        }

        private static void InprimirCursosEscuela(Escuela escuela)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Cursos de la escuela");
            Console.WriteLine("=========================");
            foreach (var curso in escuela.Cursos)
            {
                Console.WriteLine($"Nombre {curso.Nombre}, id {curso.UniqueId} ");
            }
        }

        private static void ImprimirCurso(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine($"Nombre {curso.Nombre}, id {curso.UniqueId} ");
            }
        }


    }
}
