using System;
using System.Collections.Generic;
using EscuelaAppPoo.Util;

namespace EscuelaAppPoo.Entidades
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
            Console.WriteLine("Limpiando EStablesiomiento....");
            Console.WriteLine($"Curso{Nombre} Limpio");
        }
    }
}