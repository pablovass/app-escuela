using System;
using System.Collections.Generic;
using EscuelaAppPoo.Util;

namespace EscuelaAppPoo.Entidades
{
   public class Evaluacion : ObjetoEscuelaBase, Ilugar
    {
        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public string Direccion { get; set; }
        public TiposEscuela TipoEscuela{get;set;}
        public List<Curso> Cursos { get; set; }
       
        // constructor
        public Evaluacion(string nombre, int año)
        {
            Nombre = nombre;
            AñoDeCreacion = año;
        }
        //constructor vacio
        public Evaluacion() { }

        //constructor lamda
        public Evaluacion(string nombre, string pais) => (Nombre, Pais) = (nombre, pais);
        //constructor con un valor por defecto
        public Evaluacion(string nombre, int año,TiposEscuela tipo, string pais="",
                        string ciudad="")
        {
            (Nombre,AñoDeCreacion)=(nombre,año);
            Pais=pais;
            Ciudad=ciudad;
        }

        // metodo toString 
        public override string ToString()
        {
            return $" Nombre: {Nombre}, Tipo: {TipoEscuela}\n Pais: {Pais}, Cuidad: {Ciudad}";
        }

        public void LimpiarLugar()
        {
            Printer.DibujarLinea();
            Console.WriteLine("Limpiando EScuela....");
            foreach (var curso in Cursos)
            {
                curso.LimpiarLugar();
            }
            Console.WriteLine($"Escuela {Nombre} Limpio");
        }
    }
}
