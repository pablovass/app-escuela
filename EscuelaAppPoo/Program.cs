
using System;
using System.Collections.Generic;
using System.Linq;
using EscuelaAppPoo.Entidades;
using EscuelaAppPoo.Util;
using static System.Console; // me va omitir la palabra console

namespace EscuelaAppPoo
{
    class Program{
        static void Main(string[] args) {
            // esto es un manejador de eventos con multiples delegados o predicados
            //son como los eventos de js
            AppDomain.CurrentDomain.ProcessExit+=AccionEvento;
            AppDomain.CurrentDomain.ProcessExit+=(o,s)=>Printer.EscribirTitulo("va un beep");
            // eliminar el evento
            AppDomain.CurrentDomain.ProcessExit-=AccionEvento;

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

          var dictpm= engine.GetDiccionarioObjetos();
          engine.ImprimirDiccionario(dictpm,true);
        }
        // un evento es una accion 
        private static void AccionEvento(object sender, EventArgs e)
        {
            Printer.EscribirTitulo("Inicia el evento ");
            Printer.EscribirTitulo("finaliza el evento ");


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
