using System;
using System.Collections.Generic;
using System.Linq;
using EscuelaApp5._0.Entidades;


namespace EscuelaApp5._0
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public List <Evaluaciones> Evaluaciones{get; set;}
        public EscuelaEngine()
        {

        }
        public void Incializar()
        {

            Escuela = new Escuela("SchoolPorDefecto", 2021, TiposEscuela.Secundaria, "Argentina", "BA");

            CargarCursos();
           
          
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd =new Random(System.Environment.TickCount);
                        for (int i = 0; i < 5; i++)
                        {
                            var ev=new Evaluaciones{
                                Asignatura=asignatura,
                                Nombre=$"{asignatura.Nombre} Ev#{i+1}",
                                Nota=(float)(5*rnd.NextDouble()),
                                Alumno=alumno
                            };
                            alumno.Evaluacion.Add(ev);
                        }
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var Curso  in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>{
                     new Asignatura {Nombre="Matematica"}, 
                     new Asignatura {Nombre="Educacion fisica"}, 
                     new Asignatura {Nombre="Castellano"},
                     new Asignatura {Nombre="Ciencias Naturales"} 
                };
                Curso.Asignaturas= listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            var listaAlumnos = from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno {Nombre=$"{n1} {n2} {a1}"};
                            
               return listaAlumnos.OrderBy((al)=>al.UniqueId).Take(cantidad).ToList();             
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana.ToString() },
                new Curso(){ Nombre = "201", Jornada = TiposJornada.Noche.ToString() },
                new Curso(){ Nombre = "406", Jornada = TiposJornada.Mañana.ToString() },
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Noche.ToString() },
                new Curso(){ Nombre = "401", Jornada = TiposJornada.Noche.ToString() },
                new Curso(){ Nombre = "501", Jornada = TiposJornada.Mañana.ToString() }
            };
            //int ramdom 
            Random rnd =new Random();
             
             foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom= rnd.Next(5,20);
                curso.Alumnos.AddRange(GenerarAlumnosAlAzar(cantidadRandom));    
            }
        }
    }
}