using System;
using System.Collections.Generic;
using System.Linq;
using escuela_app.Entidades;

namespace escuela_app.App
{
    /// <summary>
    /// Motor de la Escuela que administra la inicialización y carga de datos.
    /// </summary>
    public sealed class EscuelaEngine
    {
        // sealed = a sellado y solo se puede crear una instancia de esta clase
        // no se puede heredar de esta clase.
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {

        }
        /// <summary>
        /// Inicializa la escuela, carga los cursos, asignaturas y evaluaciones.
        /// </summary>
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
        /// <summary>
        /// Obtiene los objetos de la escuela según los parámetros especificados.
        /// </summary>
        /// <param name="traeEvaluaciones">Indica si se deben incluir las evaluaciones.</param>
        /// <param name="traeAlumnos">Indica si se deben incluir los alumnos.</param>
        /// <param name="traeAsignaturas">Indica si se deben incluir las asignaturas.</param>
        /// <param name="traeCursos">Indica si se deben incluir los cursos.</param>
        /// <returns>Una tupla que contiene la lista de objetos de la escuela y el conteo total de evaluaciones.</returns>
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

            return (listaObj, conteoEvaluaciones);
        }

        #region  Metodo de carga
        /// <summary>
        /// Carga las evaluaciones para cada asignatura y alumno de los cursos de la escuela.
        /// </summary>
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
        /// <summary>
        /// Carga las asignaturas para cada curso de la escuela.
        /// </summary>
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


        /// <summary>
        /// Carga los cursos de la escuela y genera alumnos aleatoriamente para cada curso.
        /// </summary>
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