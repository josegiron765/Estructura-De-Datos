using System;

namespace programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("la suma de todso los numeros pares e impares desde el 1 al 200");
            int num, par = 0,impar=0;
            for (int i = 1; i <= 200; i++)
            {
                

                if ((i % 2) == 0)
                    par = par + i;
                      
                else
                    impar = impar + i;
            }

            Console.WriteLine("la suma de los numeros impares es: " + impar);
            Console.WriteLine("la suma de numeros pares es: " + par);
        }
    }
    }

