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
      
        // Constructor por defecto
        public Escuela() { }

         // public Escuela(string nombre, int año)
        // {
        //    this.nombre = nombre;
        //     this.AñoDeCreacion = año;
        // }
        
        // Constructor con parámetros utilizando expresiones de asignación
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
    }
}
