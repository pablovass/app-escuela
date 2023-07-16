using System;
using System.Collections.Generic;
using escuela_app.Util;
namespace escuela_app.Entidades
{
 public class Curso : ObjetoEscuelaBase,Ilugar
    {
        public string Jornada{ get; set; }
        public List<Asignatura> Asignaturas {get; set;}
        public List<Alumno> Alumnos {get; set;}

        public string Direccion { get; set; }

        public void LimpiarLugar()
        {
            Printer.DibujarLinea();
            Console.WriteLine("Limpiando Establesimientos....");
            Console.WriteLine($"Curso{Nombre} Limpio");
        }
    }
}