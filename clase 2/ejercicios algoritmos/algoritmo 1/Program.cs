using System;

namespace algoritmo_1
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            int a=0, b=0,c = 0;
            Console.WriteLine("Hello World!");
            Console.WriteLine("por favor digite el valor de la base del triangulo");
            entrada = Console.ReadLine();
            a = Convert.ToInt32(entrada);
            System.Console.WriteLine("Por favor indique la medida de la altura del traingulo");
            entrada = Console.ReadLine();
            b = Convert.ToInt32(entrada);

            c = (a * b) / 2;
            System.Console.WriteLine("la superficie o area del triangulo es {0}", c);
        }
    }
}
