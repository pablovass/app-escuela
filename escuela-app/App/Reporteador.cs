using escuela_app.Entidades;
using Serilog;

namespace escuela_app.App
{
    public class Reporteador
    {
        private Dictionary<LlaveDiccionario, IEnumerable<ObjetoEscuelaBase>> _diccionario;
        private ILogger _logger;

        public Reporteador(Dictionary<LlaveDiccionario, IEnumerable<ObjetoEscuelaBase>> dicObsEsc)
        {
            if (dicObsEsc == null)
            {
                throw new ArgumentNullException(nameof(dicObsEsc));
            }

            _diccionario = dicObsEsc;
            _logger = new LoggerConfiguration()
                .WriteTo.File("log.txt") // Especifica el archivo de registro
                .CreateLogger();
        }
        public IEnumerable<Evaluacion> GetListaEvaluaciones()
        {
            if (_diccionario.TryGetValue(LlaveDiccionario.Evaluacion,
                                                 out IEnumerable<ObjetoEscuelaBase> lista))
            {
                return lista.Cast<Evaluacion>();
            }
            {
                _logger.Error("No se pudo obtener la lista de evaluaciones."); // Registro de log de error
                return new List<Evaluacion>();

            }
        }

        public IEnumerable<string> GetListaAsignaturas()
        {
            return GetListaAsignaturas(out var dummy);
        }
        public IEnumerable<string> GetListaAsignaturas(
             out IEnumerable<Evaluacion> listaEvaluaciones)
        {
            listaEvaluaciones = GetListaEvaluaciones();

            return (from Evaluacion ev in listaEvaluaciones
                    select ev.Asignatura.Nombre).Distinct();
        }
        public Dictionary<string, IEnumerable<Evaluacion>> GetDicEvaluaXAsig()
        {
            var dictaRta = new Dictionary<string, IEnumerable<Evaluacion>>();

            var listaAsig = GetListaAsignaturas(out var listaEval);

            foreach (var asig in listaAsig)
            {
                var evalsAsig = from eval in listaEval
                                where eval.Asignatura.Nombre == asig
                                select eval;

                dictaRta.Add(asig, evalsAsig);
            }

            return dictaRta;
        }
        public Dictionary<string, IEnumerable<object>> GetPromeAlumnPorAsignatura()
        {
            var rta = new Dictionary<string, IEnumerable<object>>();
            var dicEvalXAsig = GetDicEvaluaXAsig();
            foreach (var asigConEval in dicEvalXAsig)
            {
                var promsAlumn = from eval in asigConEval.Value
                                 group eval by new { eval.Alumno.UniqueId, eval.Alumno.Nombre }
                into grupoEvalsAlumno
                                 select new AlumnoPromedio
                                 {
                                     alumnoId = grupoEvalsAlumno.Key.UniqueId,
                                     alumnoNombre = grupoEvalsAlumno.Key.Nombre,
                                     promedio = grupoEvalsAlumno.Average(evaluacion => evaluacion.Nota)
                                 };
                rta.Add(asigConEval.Key, promsAlumn);
            }

            return rta;
        }
    }
}
