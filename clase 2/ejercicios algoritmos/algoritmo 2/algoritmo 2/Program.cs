using System;

namespace algoritmo_2
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            float a = 0.0f;
            float c = 0.0f;
            float b = 3.14f;
            Console.WriteLine("Hello World!");
            Console.WriteLine("por favor digite el valor del radio ");
            entrada = Console.ReadLine();
            a = Convert.ToSingle(entrada);
            c = (a * a) * b;
            Console.WriteLine("el valor del area del circulo es {0}", c);
        }
    }
}
