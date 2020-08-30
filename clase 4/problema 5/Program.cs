using System;

namespace problema_5
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int mayor = 0;
            int cant = 0;
            int i=0;
            int n=0;

            
            Console.WriteLine("por favor digite el limite de la secuencia que se menor a -99");
            entrada = Console.ReadLine();
            cant = Convert.ToInt32(entrada);
            for (i = 0; i < cant; i++)
                do
                {
                    Console.WriteLine("ingrese el valor del numero{0}", (i + 1));
                    entrada = Console.ReadLine();
                    n = Convert.ToInt32(entrada);
                    
                        

                } while (i < -99);

            if (n != 0)
            {
                if (n > mayor)
                    mayor = n;
            }

               


          Console.WriteLine("el numero mayor es {0}", mayor);

        }
    }
}
