using System;
using System.Collections.Generic;
using System.Linq;
using escuela_app.Entidades;

namespace escuela_app.App
{
    public sealed class EscuelaEngine
    {
        // sealed = a sellado y solo se puede crear una instancia de esta clase
        // no se puede heredar de esta clase.
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {

        }
        public void Incializar()
        {
            Escuela = new Escuela("Vass Academy", 2021, TiposEscuela.Primaria,
            ciudad: "BA", pais: "Argentina"
            );
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();

        }
        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
        }
        //sobrecarga de metodo 
        // esta solucion me devuelve una sola cantidad epesifica. y es solo para evaluaciones.
        public (List<ObjetoEscuelaBase>, int) GetObjetosEscuela(
            bool traeEvaluaciones,
            bool traeAlumnos,
            bool traeAsignaturas,
            bool traeCursos
        )
        {
            int conteoEvaluaciones = 0;
            var listaObj = new List<ObjetoEscuelaBase>();
            listaObj.Add(Escuela);
            if (traeCursos)
                listaObj.AddRange(Escuela.Cursos);

            foreach (var curso in Escuela.Cursos)
            {
                if (traeAsignaturas)
                    listaObj.AddRange(curso.Asignaturas);
                if (traeAlumnos)
                    listaObj.AddRange(curso.Alumnos);

                if (traeEvaluaciones)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        listaObj.AddRange(alumno.Evaluaciones);
                        conteoEvaluaciones += alumno.Evaluaciones.Count;
                    }
                }
            }

            return listaObj , conteoEvaluaciones;
        }

        #region  Metodo de carga
        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluacion
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(ev);
                        }
                    }
                }
            }

        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas"} ,
                            new Asignatura{Nombre="Educación Física"},
                            new Asignatura{Nombre="Castellano"},
                            new Asignatura{Nombre="Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }



        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                        new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana.ToString() },
                        new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana.ToString()},
                        new Curso{Nombre = "301", Jornada = TiposJornada.Mañana.ToString()},
                        new Curso(){ Nombre = "401", Jornada = TiposJornada.Tarde.ToString() },
                        new Curso() {Nombre = "501", Jornada = TiposJornada.Tarde.ToString()},
            };
            //int ramdom 
            Random rnd = new Random();

            foreach (var c in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                c.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }
        }
    }
}
#endregion