using System;

namespace ejercicio_5
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            int a=0, b=0,  d;
            float c = 0.0f;
            Console.WriteLine("Hello World!");
            Console.WriteLine("por favor digite el valor del articulo en bsf");
            entrada = Console.ReadLine();
            a = Convert.ToInt32(entrada);
            if (a < 10)
            {
                b = (int)(a * 0.5);
                Console.WriteLine("tienes una comision del 5% con respecto al valor del producto por lo tanto ganas un total de {0} bsf", b);
            }
            if (a >= 10)
            {
                c = (float)(a * 0.075);
                Console.WriteLine("tienes una comision del 7.5% con respecto al valor del producto por lo tanto ganas un total de {0} bsf",c);

            }
                
            

            
        }
    }
}
