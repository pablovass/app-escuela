using System;
using System.Collections.Generic;

namespace escuela_app.Entidades
{
    public class Escuela
    {
        public string Nombre { get; set; }         // Propiedad para almacenar el nombre de la escuela
        public int AñoDeCreacion { get; set; }     // Propiedad para almacenar el año de creación de la escuela
        public string Pais { get; set; }           // Propiedad para almacenar el país de la escuela
        public string Ciudad { get; set; }         // Propiedad para almacenar la ciudad de la escuela
        public string Direccion { get; set; }      // Propiedad para almacenar la dirección de la escuela
        public TiposEscuela TiposEscuela { get; set; } // Propiedad para almacenar el tipo de escuela

        // Constructor por defecto
        public Escuela() { }

        // Constructor con parámetros utilizando expresiones de asignación
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

        // Constructor con parámetros adicionales
        public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
            TiposEscuela = tipo;
        }

        // Método ToString() sobrescrito para devolver una representación en formato de cadena de la instancia de la clase
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TiposEscuela}, \nPaís: {Pais}, Ciudad: {Ciudad}";
        }
    }
}
