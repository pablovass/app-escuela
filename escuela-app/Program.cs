using Serilog;
using escuela_app.Entidades;
using static System.Console;//con esta linea omitimos System.Console

namespace escuela_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                //.WriteTo.File("log.txt")
                .CreateLogger();

            try
            {
                var escuela = new Escuela("Vass School", 2023, TiposEscuela.Secundaria,
                    ciudad: "Bogota", pais: "Argentina");

                escuela.Cursos = new Curso[]{
                    new Curso { Nombre = "101" },
                    new Curso { Nombre = "102" },
                    new Curso { Nombre = "103" }
                };

                ImprimirCursosEscuela(escuela);
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

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                WriteLine($"Nombre{arregloCursos[contador].Nombre},Id {arregloCursos[contador].UniqueId}");
                contador++;
            }

        }
        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                WriteLine($"Nombre{arregloCursos[contador].Nombre},Id {arregloCursos[contador].UniqueId}");
                contador++; //tiene que estar de lo contrario un bucle infinito
            }
            while (contador < arregloCursos.Length);
        }
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                WriteLine($"Nombre{arregloCursos[i].Nombre},Id {arregloCursos[i].UniqueId}");

            }

        }
        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre {curso.Nombre},Id {curso.UniqueId}");
            }

        }

    }

    }

