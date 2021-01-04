using System;
using EscuelaApp.Entidades;

namespace EscuelaApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            // una escuela 
            var escuela = new Escuela();
            escuela.Nombre="PabloSchool";
            //Console.WriteLine(escuela.Nombre="PabloSchool");
            Console.WriteLine(escuela.Nombre);
            
            // la segunda escuela 
            var escuela2= new Escuela("PepeSchool",2021);
            Console.WriteLine(escuela2.Nombre);
            //puedo agregarle mas atributos 
            escuela2.Pais="Argentina";
            escuela2.Ciudad ="Buenos Aires";

            // tersera escuela 
            var escula3  = new Escuela("School", "Argentina");
            Console.WriteLine(escula3.Nombre); 
        }
    }
}
