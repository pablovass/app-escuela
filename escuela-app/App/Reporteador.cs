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

        public IEnumerable<Escuela> GetListaEvaluacions()
        {
            IEnumerable<Escuela> rta;

            if (_diccionario.TryGetValue(LlaveDiccionario.Escuela, out IEnumerable<ObjetoEscuelaBase> lista))
            {
                rta = lista.Cast<Escuela>();
            }
            else
            {
                rta = null;
                _logger.Error("No se pudo obtener la lista de evaluaciones."); // Registro de log de error
            }

            return rta;
        }
        public IEnumerable<string> GetListaAsignaturas()
        {
            var listaEvaluaciones=GetListaEvaluacions();
            
            return (from Evaluacion ev in listaEvaluaciones
            select ev.Asignatura.Nombre).Distinct();

            
        }
        public Dictionary<string ,IEnumerable<Evaluacion>> GetDicEvaluancion(){
            var dictaRta=new Dictionary<string ,IEnumerable<Evaluacion>>();
            return dictaRta;

        }
    }
}
