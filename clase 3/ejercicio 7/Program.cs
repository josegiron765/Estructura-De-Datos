using System;

namespace Algoritmo7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, C, B;

            Console.WriteLine("Ingrese el primer número");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número");
            C = int.Parse(Console.ReadLine());

            if (A > B && A < C)
            {
                Console.WriteLine("El primer núemero es el del medio es: {0}", A);
            }
            else
            {
                if (B > A && B < C)
                {
                    Console.WriteLine("El segundo numero es el del medio {0}", B);
                }

                else
                {
                    if (C > A && C < B)
                    {
                        Console.WriteLine("El tercer numero es el del medio {0}", C);
                    }

                }
            }

        }
    }
}
