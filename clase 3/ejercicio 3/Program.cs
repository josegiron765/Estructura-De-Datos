using System;

namespace ejercicio_3
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            int a, b, iva, c, d, v,t;
            Console.WriteLine("Hello World!");
            Console.WriteLine("por favor digite el nombre del producto");
            entrada = Console.ReadLine();
            Console.WriteLine("por favor digite la cantidad de productos que llevo del mismo");
            entrada = Console.ReadLine();
            a = Convert.ToInt32(entrada);
            Console.WriteLine("por favor digite el precio del producto en bsf");
            entrada = Console.ReadLine();
            b = Convert.ToInt32(entrada);
            c = b * a;
            iva = ((int)(c * 11.5)) / 100;
            d = c + iva;
            Console.WriteLine("el precio total es : {0} ", d);
            if (d > 500)
            {
                v = ((int)(d * 6.5)) / 100;
                t = (d - v);
                Console.WriteLine("el producto tiene un descuento de 6.5% por lo tanto el precio total del producto es : {0}", t);
            }
            else
            {
                Console.WriteLine("el producto no aplica para descuento ");
            }




        }
    }
}
