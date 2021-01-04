using System;
using EscuelaApp.Entidades;

namespace EscuelaApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            //objeto de parametro obcionales 
            var esc4  = new Escuela("SchoolPorDefecto",2021,TiposEscuela.Secundaria,"Argentina","BA");
            Console.WriteLine(esc4);
            

        }
    }
}
