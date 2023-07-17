using escuela_app.Entidades;
namespace escuela_app.App
{
    public class Reporteador
    {
        Dictionary<LlaveDiccionario, IEnumerable<ObjetoEscuelaBase>> _diccionario;  // siempre que hago es privado _privado (guion bajo)
        public Reporteador(Dictionary<LlaveDiccionario, IEnumerable<ObjetoEscuelaBase>> dicObsEsc)
        {
            if (dicObsEsc == null)
            {
                throw new ArgumentNullException(nameof(dicObsEsc));
            }
            _diccionario = dicObsEsc;
        }
        /*    
        public IEnumerable<Evaluacion>GetEvaluacions()
        {
            var lista= _diccionario.GetValueOrDefault(LlaveDiccionario.Escuela); 
            return lista.Cast<Escuela>();       }  
    
    */
        public IEnumerable<Escuela> GetListaEvaluacions()
        {
            IEnumerable<Escuela> rta;
            //var lista = _diccionario.GetValueOrDefault(LlaveDiccionario.Escuela); me trae un valor por defecto
            if(_diccionario.TryGetValue(LlaveDiccionario.Escuela,out IEnumerable<ObjetoEscuelaBase> lista))
            {
               rta= lista.Cast<Escuela>();
            }
            {
                rta=null;
                //Escribir en el log de auditoria
            }
            return rta;
        }
    }
}