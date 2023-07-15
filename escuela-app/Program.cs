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
            
            var curso1=new Curso(){Nombre="101"};
            var curso2=new Curso(){Nombre="102"};
            var curso3=new Curso(){Nombre="103"};
            // Imprimir el nombre de la escuela en la consola
            Console.WriteLine(escuela);
            System.Console.WriteLine("=========="); //cw shortcut
           Console.WriteLine(curso1.Nombre+" "+","+curso1.UniqueId);
           Console.WriteLine($"{curso2.Nombre}, {curso2.UniqueId}");
           Console.WriteLine(curso3.Nombre+" "+","+curso3.UniqueId);
        }
    }
}
