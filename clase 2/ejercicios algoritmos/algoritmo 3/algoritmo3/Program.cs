using System;

namespace algoritmo3
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            Console.WriteLine("Hello World!");
            Console.WriteLine("hola por favor regalame el area del triangulo en entero ");
            entrada = Console.ReadLine();
            a = Convert.ToInt32(entrada);
            Console.WriteLine("por favor regalame ahora la altura del triangulo en entero ");
            entrada = Console.ReadLine();
            b = Convert.ToInt32(entrada);

            c = (2 * a) / b;
            Console.WriteLine("el valor de la base del triangulo es : {0}", c);

        }
    }
}
