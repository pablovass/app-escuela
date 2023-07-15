using System;
using escuela_app.Entidades;  // Importar el espacio de nombres de las entidades de la escuela

namespace escuela_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Escuela y asignar valores a sus propiedades
            var escuela = new Escuela("Vass School", 2023, TiposEscuela.Secundaria,
            ciudad: "Bogota", pais: "Argentina");
            var arreglegoCursos = new Curso[3];
            arreglegoCursos[0] = new Curso { Nombre = "101" };
            arreglegoCursos[1] = new Curso { Nombre = "102" };
            arreglegoCursos[2] = new Curso { Nombre = "103" };

            // Imprimir el nombre de la escuela en la consola
            Console.WriteLine(escuela);
            System.Console.WriteLine("=========="); //cw shortcut
                                                    // Console.WriteLine(arreglegoCursos[0].Nombre+" "+","+arreglegoCursos[0].UniqueId);
                                                    // Console.WriteLine($"{arreglegoCursos[1].Nombre}, {arreglegoCursos[1].UniqueId}");
                                                    // Console.WriteLine(arreglegoCursos[2].Nombre+" "+","+arreglegoCursos[2].UniqueId);

            ImprimirCursosWhile(arreglegoCursos);
            System.Console.WriteLine("==========");
            ImprimirCursosDoWhile(arreglegoCursos);
            System.Console.WriteLine("==========");
            ImprimirCursosFor(arreglegoCursos);
            System.Console.WriteLine("==========");
            ImprimirCursosForEach(arreglegoCursos);
        }
        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                System.Console.WriteLine($"Nombre{arregloCursos[contador].Nombre},Id {arregloCursos[contador].UniqueId}");
                contador++;
            }

        }
        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                System.Console.WriteLine($"Nombre{arregloCursos[contador].Nombre},Id {arregloCursos[contador].UniqueId}");
                contador++; //tiene que estar de lo contrario un bucle infinito
            }
            while (contador < arregloCursos.Length);
        }
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                System.Console.WriteLine($"Nombre{arregloCursos[i].Nombre},Id {arregloCursos[i].UniqueId}");

            }

        }
        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                System.Console.WriteLine($"Nombre {curso.Nombre},Id {curso.UniqueId}");
            }

        }

    }
}
