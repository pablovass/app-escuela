using System;
using System.Linq; // siempre que trabaje con colecciones esta buenos
using System.Collections.Generic;
using EscuelaAppPoo.Entidades;


namespace EscuelaAppPoo.App
{
    public class Reporteador
    {
        Dictionary<LlaveDiccionario, IEnumerable<ObjetoEscuelaBase>> _diccionario;  
        public Reporteador(Dictionary<LlaveDiccionario, IEnumerable<ObjetoEscuelaBase>> dicObsEsc)
        {
            if (dicObsEsc == null)
            {
                throw new ArgumentNullException(nameof(dicObsEsc));
            }
            _diccionario = dicObsEsc;
        }
        public IEnumerable<Evaluacion> GetListaEvaluacions()
        {
           // IEnumerable<Evaluacion> rta;
            
            if(_diccionario.TryGetValue(LlaveDiccionario.Escuela,out IEnumerable<ObjetoEscuelaBase> lista))
            {
               return lista.Cast<Evaluacion>()
            }
            {
               return new List<Evaluacion>();
                
            }
        }
    }
}