using escuela_app.Util;

namespace escuela_app.Entidades
{
    /// <summary>
    /// Representa una escuela.
    /// </summary>
    public class Escuela : ObjetoEscuelaBase, Ilugar
    {
        /// <summary>
        /// Obtiene o establece el año de creación de la escuela.
        /// </summary>
        public int AñoDeCreacion { get; set; }
        /// <summary>
        /// Obtiene o establece el país de la escuela.
        /// </summary>
        public string Pais { get; set; }
        /// <summary>
        /// Obtiene o establece la ciudad de la escuela.
        /// </summary>
        public string Ciudad { get; set; }
        /// <summary>
        /// Obtiene o establece la dirección de la escuela.
        /// </summary>
        public string Direccion { get; set; }
        /// <summary>
        /// Obtiene o establece el tipo de escuela.
        /// </summary>
        public TiposEscuela TipoEscuela { get; set; }
        /// <summary>
        /// Obtiene o establece la lista de cursos de la escuela.
        /// </summary>
        public List<Curso> Cursos { get; set; }

        /// <summary>
        /// Constructor de la clase Escuela.
        /// </summary>
        /// <param name="nombre">Nombre de la escuela.</param>
        /// <param name="año">Año de creación de la escuela.</param>
        public Escuela(string nombre, int año)
        {
            Nombre = nombre;
            AñoDeCreacion = año;
        }
        /// <summary>
        /// Constructor vacío de la clase Escuela.
        /// </summary>
        public Escuela() { }

        /// <summary>
        /// Constructor de la clase Escuela utilizando una expresión lambda.
        /// </summary>
        /// <param name="nombre">Nombre de la escuela.</param>
        /// <param name="pais">País de la escuela.</param>
        public Escuela(string nombre, string pais) => (Nombre, Pais) = (nombre, pais);
        /// <summary>
        /// Constructor de la clase Escuela con valores por defecto para el país y la ciudad.
        /// </summary>
        /// <param name="nombre">Nombre de la escuela.</param>
        /// <param name="año">Año de creación de la escuela.</param>
        /// <param name="tipo">Tipo de escuela.</param>
        /// <param name="pais">País de la escuela (opcional, valor por defecto: "").</param>
        /// <param name="ciudad">Ciudad de la escuela (opcional, valor por defecto: "").</param>
        public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "",
                        string ciudad = "")
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        /// <summary>
        /// Devuelve una representación en forma de cadena de la escuela.
        /// </summary>
        /// <returns>La representación en forma de cadena de la escuela.</returns>
        public override string ToString()
        {
            return $" Nombre: {Nombre}, Tipo: {TipoEscuela}\n Pais: {Pais}, Cuidad: {Ciudad}";
        }
        /// <summary>
        /// Limpia el lugar de la escuela y de cada curso dentro de la escuela.
        /// </summary>
        public void LimpiarLugar()
        {
            Printer.DrawLine();
            Console.WriteLine("Limpiando Escuela....");
            foreach (var curso in Cursos)
            {
                curso.LimpiarLugar();
            }
            Console.WriteLine($"Escuela {Nombre} Limpio");
        }
    }
}
