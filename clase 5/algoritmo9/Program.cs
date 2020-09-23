using System;

namespace algoritmo9
{
    class Program
    { // definimos 2 varibles para cada matriz 
        private static int[,] m1;
        private static int[,] m2;

        static void Main(string[] args)
        {// declaramos las varibales que vamos a utilizar filas y columnas
            int filas;
            int columnas;
            int f2 = 0;
            int c2 = 0;
            m2 = new int[f2, c2];
           //acontinuacion vamos a llenar la matriz o tabla 
            Console.WriteLine("Hello World!");
            Console.WriteLine("acontinuacion vamos a llenar la tabla o matriz ");
            Console.WriteLine("");
            Console.WriteLine("cuantas filas tienen la matriz");
            string linea;
            linea = Console.ReadLine();
            filas = int.Parse(linea);
            Console.WriteLine("cuantas columnas tiene la matriz ");
            linea = Console.ReadLine();
            columnas = int.Parse(linea);
            m1 = new int[filas, columnas];
            for (int f = 0; f < m1.GetLength(0); f++)
            {
                for (int c = 0; c < m1.GetLength(1); c++)
                {
                    Console.Write("por favor ingrese el elemento (" + (f + 1) + " " + (c + 1) + " ) ");
                    linea = Console.ReadLine();
                    m1[f, c] = int.Parse(linea);


                }
            }
            Console.WriteLine("la matriz o tabla resultante es :  ");
            Console.WriteLine("");

            for (int f = 0; f < m1.GetLength(0); f++)
            {
                for (int c = 0; c < m1.GetLength(1); c++)
                {
                    Console.Write("    (" + m1[f, c] + ")  ");

                }
                Console.WriteLine("");
            }
            // aca se hace una matriz vacia por lo tanto al ejecutar aparece en blanco 
            Console.WriteLine("ahora tenemos una tabla vacia");
            Console.WriteLine("");
            Console.WriteLine("la matriz o tabla resultante es :  ");
            Console.WriteLine("");

            for (int f = 0; f < m2.GetLength(0); f++)
            {
                for (int c = 0; c < m2.GetLength(1); c++)
                {
                    Console.Write("    (" + m2[f, c] + ")  ");

                }
                Console.WriteLine("");
            }
            // aca se hace un cilo para que la tabla que estaba vacia imprimiera los datos de la primera tabla 
            Console.WriteLine("");
            Console.WriteLine("ahora la tabla vacia va a copiar los elementos de la primera tabla o matriz ");
            Console.WriteLine("");
            Console.WriteLine("la matriz o tabla resultante es ");
            Console.WriteLine("");
            for (int f = 0; f < m1.GetLength(0); f++)
            {
                for (int c = 0; c < m1.GetLength(1); c++)
                {
                    Console.Write("    (" + m1[f, c] + ")  ");

                }
                Console.WriteLine("");
            }

        }
    }
}
