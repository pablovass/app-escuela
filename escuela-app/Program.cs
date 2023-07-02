using System;

namespace escuela_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // Crear una instancia de la clase Escuela
            var miEscuela = new Escuela();

            // Asignar valores a las propiedades estáticas de la clase Escuela
            Escuela.nombre = "Mi escuela";
            Escuela.direccion = "BA";

            // Llamar al método Timbrar en la instancia de la clase Escuela
            miEscuela.Timbrar();
        }
    }

    class Escuela
    {
        public static string nombre;     // Propiedad estática para almacenar el nombre de la escuela
        public static string direccion;  // Propiedad estática para almacenar la dirección de la escuela

        /// <summary>
        /// Método para hacer sonar el timbre de la escuela.
        /// </summary>
        public void Timbrar()
        {
            Console.Beep(1000, 3000);  // Generar un tono de timbre
        }
    }
}
