using System;
using System.Collections.Generic;
using EscuelaApp.Entidades;
using static System.Console; // me va omitir la palabra console

namespace EscuelaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //objeto de parametro obcionales 
            var escuela = new Escuela("SchoolPorDefecto", 2021, TiposEscuela.Secundaria, "Argentina", "BA");

            escuela.Cursos=new List<Curso>(){
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana.ToString() },
                new Curso(){ Nombre = "201", Jornada = TiposJornada.Noche.ToString() },
                new Curso(){ Nombre = "406", Jornada = TiposJornada.Mañana.ToString() }
            };
            // vamos a agregar una lista dentro de otra 
            var otraColeccion=new List<Curso>(){
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Noche.ToString() },
                new Curso(){ Nombre = "401", Jornada = TiposJornada.Noche.ToString() },
                new Curso(){ Nombre = "501", Jornada = TiposJornada.Mañana.ToString() }
            };
         
            escuela.Cursos.AddRange(otraColeccion);
            //especifica que borrar 
            escuela.Cursos.RemoveAll(delegate(Curso cur){
                                    return cur.Nombre=="401";
                                    });

            escuela.Cursos.RemoveAll((cur)=>cur.Nombre=="301" && cur.Jornada==TiposJornada.Noche.ToString()); // remueve un espesifico

            
            //adicionando cursos
            escuela.Cursos.Add(new Curso(){Nombre="202", Jornada=TiposJornada.Noche.ToString() });
           

            ImprimirCursosEscuela(escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("=========================");
            WriteLine("Cursos de la escuela");
            WriteLine("=========================");

            //evitamos crash por valores nulos
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, id {curso.UniqueId} ");
                }
            }

        }

        private static void ImprimirCurso(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre {curso.Nombre}, id {curso.UniqueId} ");
            }
        }


    }
}
