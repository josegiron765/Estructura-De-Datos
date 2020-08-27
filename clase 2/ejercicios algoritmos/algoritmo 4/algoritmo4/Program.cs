using System;

namespace algoritmo4
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            float area = 0.0f;
            float radio = 0.0f;
            float resultado = 0.0f;
            float pi = 3.14f;
            Console.WriteLine("Hello World!");
            Console.WriteLine("hola por favor dame el valor del area del circulo ");
            entrada = Console.ReadLine();
            area = Convert.ToSingle(entrada);
            Math.Sqrt(area);
            Console.WriteLine("la raiz cuadrada del area es : "+ Math.Sqrt(area));



            radio = (float)(Math.Sqrt(area) * pi);

            Console.WriteLine("el radio del circulo es {0}", radio);
        }


        
    }
}
