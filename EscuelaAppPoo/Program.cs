
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

            //nuevo objeto escuela
            Printer.DibujarLinea(20);
            Printer.EscribirTitulo("Prueva polimorfismo");
            var alumnoTest= new Alumno{Nombre="Pablo vass"};
            ObjetoEscuelaBase ob = alumnoTest;
            Printer.EscribirTitulo("Alumno");
            WriteLine($"Alumno {alumnoTest.Nombre}");
            WriteLine($"Alumno {alumnoTest.UniqueId}");

            Printer.EscribirTitulo("ObjetoEscuela");
            WriteLine($"Alumno {ob.Nombre}");
            WriteLine($"Alumno {ob.UniqueId}");
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
