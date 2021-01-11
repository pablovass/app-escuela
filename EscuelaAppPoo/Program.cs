
using System.Collections.Generic;
using System.Linq;
using EscuelaAppPoo.Entidades;
using EscuelaAppPoo.Util;
using static System.Console; // me va omitir la palabra console

namespace EscuelaAppPoo
{
    class Program{
        static void Main(string[] args) {

            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.EscribirTitulo("Bienvenido a la escuela");
            Printer.DibujarLinea(15);
            ImprimirCursosEscuela(engine.Escuela);
            Dictionary<int,string>diccionario=new Dictionary<int,string>();
            diccionario.Add(10,"pabloV");
            diccionario.Add(23,"PPPP");
          /*
          foreach (var keyValPair in diccionario)
          {
              WriteLine($"Key: {keyValPair.Key} Valor: {keyValPair.Value}")
          }*/
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
