using System;
using static System.Console;

namespace calculoCircunferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI=3.14159;
            double radio;


            WriteLine("Escribe el valor del radio");
            radio=Convert.ToDouble(Console.ReadLine());
            double areaCirculo=PI*radio*radio;
            WriteLine("el radio es {0}, y el area del circulo es {1}",radio,areaCirculo);
        }
    }
}
