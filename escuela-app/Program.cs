using System;
using escuela_app.Entidades;  // Importar el espacio de nombres de las entidades de la escuela
using static System.Console; //con esta linea omitimos System.Console.
namespace escuela_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Escuela y asignar valores a sus propiedades
            var escuela = new Escuela("Vass School", 2023, TiposEscuela.Secundaria,
            ciudad: "Bogota", pais: "Argentina");
            //asi
            // var arregloCursos = new Curso[3]{
            //      new Curso { Nombre = "101" },
            //      new Curso { Nombre = "102" },
            //      new Curso { Nombre = "103" }};
            //o asi es lo mismo
            //  Curso[] arregloCursos ={
            //      new Curso { Nombre = "101" },
            //      new Curso { Nombre = "102" },
            //      new Curso { Nombre = "103" }};
            //      escuela.Cursos=arregloCursos;

            //o asi tambien
            escuela.Cursos = new Curso[]{
                new Curso { Nombre = "101" },
                new Curso { Nombre = "102" },
                new Curso { Nombre = "103" }};


            // Imprimir el nombre de la escuela en la consola
            ImprimirCursosEscuela(escuela);
            //  Console.WriteLine(escuela);
            //  System.Console.WriteLine("=========="); //cw shortcut
            //  ImprimirCursosWhile(arregloCursos);
            //  System.Console.WriteLine("==========");
            //  ImprimirCursosDoWhile(arregloCursos);
            //  System.Console.WriteLine("==========");
            //  ImprimirCursosFor(arregloCursos);
            //  System.Console.WriteLine("==========");
            //  ImprimirCursosForEach(arregloCursos);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("=====================");
            WriteLine("Cursos de la escuela");
            WriteLine("=====================");
            if (escuela.Cursos == null && escuela != null)
            {
                return;
            }
            else
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre},Id {curso.UniqueId}");
                }
            }




        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                WriteLine($"Nombre{arregloCursos[contador].Nombre},Id {arregloCursos[contador].UniqueId}");
                contador++;
            }

        }
        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                WriteLine($"Nombre{arregloCursos[contador].Nombre},Id {arregloCursos[contador].UniqueId}");
                contador++; //tiene que estar de lo contrario un bucle infinito
            }
            while (contador < arregloCursos.Length);
        }
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                WriteLine($"Nombre{arregloCursos[i].Nombre},Id {arregloCursos[i].UniqueId}");

            }

        }
        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre {curso.Nombre},Id {curso.UniqueId}");
            }

        }

    }
}
