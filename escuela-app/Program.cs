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
                .WriteTo.File("log.txt")
                .CreateLogger();

            try
            {
                var escuela = new Escuela("Vass School", 2023, TiposEscuela.Secundaria,
                    ciudad: "Bogota", pais: "Argentina");

           escuela.Cursos = new List<Curso>(){
                    new Curso { Nombre = "101",Jornada=TiposJornada.Mañana },
                    new Curso { Nombre = "102" ,Jornada=TiposJornada.Mañana},
                    new Curso { Nombre = "103",Jornada=TiposJornada.Mañana }
            };
            var otraColeccion = new List<Curso>(){
                    new Curso { Nombre = "401",Jornada=TiposJornada.Mañana },
                    new Curso { Nombre = "502" ,Jornada=TiposJornada.Mañana},
                    new Curso { Nombre = "603",Jornada=TiposJornada.Noche }
            };
            escuela.Cursos.Add(new Curso { Nombre = "212",Jornada=TiposJornada.Tarde});
            escuela.Cursos.AddRange(otraColeccion);
            
                ImprimirCursosEscuela(escuela);
                //Predicate<Curso>miAlgoritmo=Predicado; este tambien se puede ir solo porque es C# 3 en adelante [inferencias de tipos]
               // escuela.Cursos.RemoveAll(miAlgoritmo); por inferencia de tipos esto puede ser asi
               // estas son todos lo mismo 
               escuela.Cursos.RemoveAll(Predicado);
               escuela.Cursos.RemoveAll(delegate(Curso curso) { return curso.Nombre=="311";});
               escuela.Cursos.RemoveAll((Curso curso) =>  curso.Nombre=="311");
               escuela.Cursos.RemoveAll((curso) =>  curso.Nombre=="311");
               escuela.Cursos.RemoveAll((curso) =>  curso.Nombre=="502" && curso.Jornada==TiposJornada.Mañana);

                WriteLine("========");
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

        private static bool Predicado(Curso obj)
        {
            return obj.Nombre=="3001";
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

