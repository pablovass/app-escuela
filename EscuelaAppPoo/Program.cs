
using System;
using System.Collections.Generic;
using EscuelaAppPoo;
using EscuelaAppPoo.Entidades;
using EscuelaAppPoo.Util;
using static System.Console; // me va omitir la palabra console

namespace EscuelaAppPoo
{
    class Program{
        static void Main(string[] args) {
            var engine = new EscuelaEngine();
            engine.Incializar();
            Printer.EscribirTitulo("Bienvenido a la escuela");
            Printer.DibujarLinea(15);
            ImprimirCursosEscuela(engine.Escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.EscribirTitulo("Cursos de escuela");

            //evitamos crash por valores nulos
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, id {curso.UniqueId} ");
                }
            }

        }
    }
}
