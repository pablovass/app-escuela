using System;
using escuela_app.Entidades;  // Importar el espacio de nombres de las entidades de la escuela

namespace escuela_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Escuela y asignar valores a sus propiedades
            var escuela = new Escuela("Vass School", 2023,TiposEscuela.Secundaria,
            ciudad:"Bogota",pais:"Argentina");
            var arreglegoCursos=new Curso[3];
            arreglegoCursos[0]=new Curso {Nombre="101"};
            arreglegoCursos[1]=new Curso {Nombre="102"};
            arreglegoCursos[2]=new Curso {Nombre="103"};

            // Imprimir el nombre de la escuela en la consola
            Console.WriteLine(escuela);
            System.Console.WriteLine("=========="); //cw shortcut
         // Console.WriteLine(arreglegoCursos[0].Nombre+" "+","+arreglegoCursos[0].UniqueId);
         // Console.WriteLine($"{arreglegoCursos[1].Nombre}, {arreglegoCursos[1].UniqueId}");
         // Console.WriteLine(arreglegoCursos[2].Nombre+" "+","+arreglegoCursos[2].UniqueId);
         ImprimirCursos(arreglegoCursos);
        }
        private static void ImprimirCursos(Curso[]arregloCursos){
          int contador =0;
          while(contador<arregloCursos.Length)
          {
            System.Console.WriteLine($"Nombre{arregloCursos[contador].Nombre},Id {arregloCursos[contador].UniqueId}");
            contador++;
          }

        }
    }
}
