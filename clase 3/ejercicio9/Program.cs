using System;

namespace Algoritmo9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c = 0, d = 0;
            int z = 0;

            switch (z)
            {
                case 0:
                    Console.WriteLine("Ponga la cantidad de números que quiere digitar, para que tenga la certeza de que el algoritmo siver por favor que el ultimo número a digitar sea -99: ");
                    a = int.Parse(Console.ReadLine());
                    for (int i = 0; i < a; i++)
                    {
                        Console.WriteLine("Escriba un número");
                        b = int.Parse(Console.ReadLine());

                        if (i == 0)
                        {
                            c = b;
                            d = b;
                        }
                        else if (i != 0)
                        {
                            if (b < d)
                            {
                                d = b;
                            }
                            if (b > c)
                            {
                                c = b;
                            }
                        }
                    }
                    Console.WriteLine("El número mayor es " + c);
                    break;
            }
        }
    }
}
