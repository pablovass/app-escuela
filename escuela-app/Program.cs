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
            
            // Imprimir el nombre de la escuela en la consola
            Console.WriteLine(escuela);
        }
    }
}
