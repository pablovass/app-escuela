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
            
            var curso1 = new Curso (){
                Nombre ="101"

            };
            var curso2 = new Curso (){
                Nombre ="201"

            }; 
            var curso3 = new Curso (){
                Nombre ="301"

            }; 
            Console.WriteLine(esc4);
            System.Console.WriteLine("====================");

            Console.WriteLine(curso1.Nombre+" , "+ curso1.UniqueId);
            Console.WriteLine($"{curso2.Nombre} , {curso2.UniqueId}");
            Console.WriteLine($"{curso3.Nombre} , {curso3.UniqueId}");

        }
    }
}
