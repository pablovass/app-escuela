
using System;
using System.Collections.Generic;
using System.Linq;
using EscuelaAppPoo.App;
using EscuelaAppPoo.Entidades;
using EscuelaAppPoo.Util;
using static System.Console; // me va omitir la palabra console

namespace EscuelaAppPoo
{
    class Program{
        static void Main(string[] args) {
            
            AppDomain.CurrentDomain.ProcessExit+=AccionEvento;
            AppDomain.CurrentDomain.ProcessExit+=(o,s)=>Printer.EscribirTitulo("va un beep");
            AppDomain.CurrentDomain.ProcessExit-=AccionEvento;

            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.EscribirTitulo("Bienvenido a la escuela");
            Printer.DibujarLinea(15);
            ImprimirCursosEscuela(engine.Escuela);
            Dictionary<int,string>diccionario=new Dictionary<int,string>();
            diccionario.Add(10,"pabloV");
            diccionario.Add(23,"PPPP");
      

          var dictpm= engine.GetDiccionarioObjetos();
          engine.ImprimirDiccionario(dictpm,true);

          var reporteador = new Reporteador(engine.GetDiccionarioObjetos());
           // var reporteador = new Reporteador(null);
            
            var evalList=reporteador.GetListaEvaluacions();
        }
        private static void AccionEvento(object sender, EventArgs e)
        {
            Printer.EscribirTitulo("Inicia el evento ");
            Printer.EscribirTitulo("finaliza el evento ");


        }

        private static void ImprimirCursosEscuela(Evaluacion escuela)
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
