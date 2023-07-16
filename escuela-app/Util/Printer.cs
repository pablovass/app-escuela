using static System.Console;

namespace escuela_app.Util
{
    /// <summary>
    /// Clase de utilidades para imprimir en la consola.
    /// </summary>
    public static class Printer
    {
        /// <summary>
        /// Dibuja una línea compuesta por un carácter especificado.
        /// </summary>
        /// <param name="tam">Longitud de la línea (por defecto es 10).</param>
        public static void DibujarLinea(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '='));
        }
        public static void WriteTitle(string titulo)
        {
            var tamaño=titulo.Length+4;
            DibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }
    }
    
}
