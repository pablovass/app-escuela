using Serilog;
using escuela_app.Entidades;
using static System.Console;//con esta linea omitimos System.Console
using escuela_app.App;

namespace escuela_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log.txt")
                .CreateLogger();

            try
            {
                var engine = new EscuelaEngine();
                engine.Inicializar();
                WriteLine("========");
                ImprimirCursosEscuela(engine.Escuela);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Ocurrió un error en el programa");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Log.Information("=====================");
            Log.Information("Cursos de la escuela");
            Log.Information("=====================");

            if (escuela.Cursos == null && escuela != null)
            {
                return;
            }
            else
            {
                foreach (var curso in escuela.Cursos)
                {
                    Log.Information($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                }
            }
        }
    }

}

