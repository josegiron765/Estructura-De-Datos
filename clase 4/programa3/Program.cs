using System;

namespace programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int m, i,y;
            Console.WriteLine("acontinuacion las tablas de 1 al 10  ");
            for (i = 0; i <= 10; i++)
            {
                for ( y = 0; y <= 10; y++)
                    Console.WriteLine(i + "x" + y + "= " + (i * y));
                
            }
        }
    }
}
