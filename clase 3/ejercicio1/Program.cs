using System;

namespace ejercicio1
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0;

            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            Console.WriteLine("por favor dame el primer numero ");
            entrada= Console.ReadLine();
            a = Convert.ToInt32(entrada);
            Console.WriteLine("");
            Console.WriteLine("por favor dame el segundo numero ");
            entrada = Console.ReadLine();
            b = Convert.ToInt32(entrada);
            Console.WriteLine("");
            Console.WriteLine("por favor dame el tercer numero ");
            entrada = Console.ReadLine();
            c = Convert.ToInt32(entrada);
            Console.WriteLine("");
            Console.WriteLine("por favor dame el cuarto  numero ");
            entrada = Console.ReadLine();
            d = Convert.ToInt32(entrada);
            if (a > b && a > c && a > d)
                Console.WriteLine("el numero mayor es :{0} ", a);
            if(b > a && b > c && b > d)
                Console.WriteLine("el numero mayor es:{0} ",b);
            if (c > a && c > b && c > d)
                Console.WriteLine("el numero mayor es:{0} ", c);
            if (d > a && d > c && d > b)
                Console.WriteLine("el numero mayor es:{0} ", d);






        }
    }
}
