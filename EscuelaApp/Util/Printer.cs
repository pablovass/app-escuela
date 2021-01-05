using static System.Console;
namespace EscuelaApp.Util
{
    public static class Printer
    {
        // las clases estaticas no permite crear nuevas instancias
        public static void DibujarLinea(int tam=10){
            
            WriteLine("".PadLeft(tam, '='));
        } 
        public static void EscribirTitulo(string titulo){
            var tamaño =titulo.Length + 4 ;
            DibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }
    }
}