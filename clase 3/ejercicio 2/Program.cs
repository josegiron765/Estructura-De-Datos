using System;

namespace ejercicio_2
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int n, m, c=0;
            Console.WriteLine("Hello World!");
            Console.WriteLine("ingrese el numero por favor ");
            n = int.Parse(Console.ReadLine());

            for (m = 1; m <= n; m++)
            {
                if (n % m == 0)
                {
                    c = c + 1;

                }
            }
            if (c > 2)
            {
                Console.WriteLine("{0} no es primo", n);
            }
            else
            {
                Console.WriteLine("{0}  es primo", n);
            }
        }
    }
}
