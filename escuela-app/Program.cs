using Serilog;
using escuela_app.Entidades;
using escuela_app.App;
using escuela_app.Util;
using static System.Console;//con esta linea omitimos System.Console


namespace escuela_app
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += AccionDelEvento; //evento 

            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            
            Dictionary<int, string> dicccionario = new Dictionary<int, string>();

            dicccionario.Add(10, "JuanK");

            dicccionario.Add(23, "Lorem Ipsum");

            foreach (var keyValPair in dicccionario)
            {
                WriteLine($"Key: {keyValPair.Key} Valor: {keyValPair.Value}");
            }

            var dictmp = engine.GetDiccionarioObjetos();

            engine.ImprimirDiccionario(dictmp, true);

        }

        private static void AccionDelEvento(object sender, EventArgs e)
        {
            Printer.WriteTitle("SALIENDO");
            Printer.WriteTitle("SALIÓ");
        }

        private static void ImpimirCursosEscuela(Escuela escuela)
        {

            Printer.WriteTitle("Cursos de la Escuela");


            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id  {curso.UniqueId}");
                }
            }
        }
    }
}
