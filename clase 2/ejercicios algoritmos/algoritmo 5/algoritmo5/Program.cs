using System;

namespace algoritmo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double A;
            const double Li = 0.453592;
            double B;
            Console.WriteLine("Dijite su peso en libras :");
            A = double.Parse(Console.ReadLine());

            B = (A * Li);
            Console.WriteLine("Su peso en  Kilogramos es de {0}", B);
        }
    }
}

