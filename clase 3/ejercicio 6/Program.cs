using System;

namespace Algoritmo_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            double C, D;

            Console.WriteLine("¿Cual fue la distancia recorrida en km?");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuantos días se quedo?");
            B = int.Parse(Console.ReadLine());

            C = 2.5;

            if (A > 800 && B > 7)
            {
                Console.WriteLine("felicidades tendras un descuento del 30%");
                D = (A * C) * 0.30;
                Console.WriteLine("");
                Console.WriteLine("El valor de su tiked es de: {0} ", D);
            }
            else
            {
                D = (A * C);
                Console.WriteLine();
                Console.WriteLine("Elvalor del tiked es de: {0}", D);
            }
        }
    }
}