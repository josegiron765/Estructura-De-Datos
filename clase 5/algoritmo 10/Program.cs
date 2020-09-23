using System;
using System.Net.Mail;
using System.Runtime.InteropServices.ComTypes;

namespace algoritmo10
{
    class Program
    {
        private static int[,] matriz1;
        private static int[,] matriz2;
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // acontinuacion vamos a llenar la matriz 1 en este caso la hare una matriz 3x3 ya que el ejercicio no especifica cuantas tiene n i tampoco pide al usuario que diga cuantas filas y columnas tiene 
            Console.WriteLine("cuantas filas tienen la matriz 1 ");
            string linea;
            linea = Console.ReadLine();
            int fila1 = int.Parse(linea);

            // capturamos las columnas 
            Console.WriteLine("cuantas columnas tienen la matriz 1 ");
            linea = Console.ReadLine();
            int columna1 = int.Parse(linea);

            Console.WriteLine("cuantas filas tienen la matriz 2 ");
            linea = Console.ReadLine();
            int fila2 = int.Parse(linea);

            // capturamos las columnas 
            Console.WriteLine("cuantas columnas tienen la matriz 2 ");
            linea = Console.ReadLine();
            int columna2 = int.Parse(linea);



            matriz1 = new int[fila1, columna1];
            for (int f = 0; f < matriz1.GetLength(0); f++)
            {
                for (int c = 0; c < matriz1.GetLength(1); c++)
                {
                    Console.Write("por favor ingrese el elemento (" + (f + 1) + " " + (c + 1) + " ) ");
                    linea = Console.ReadLine();
                    matriz1[f, c] = int.Parse(linea);


                }
            }

            Console.WriteLine("la matriz 1 resultante es :  ");
            Console.WriteLine("");

            for (int f = 0; f < matriz1.GetLength(0); f++)
            {
                for (int c = 0; c < matriz1.GetLength(1); c++)
                {
                    Console.Write("    (" + matriz1[f, c] + ")  ");

                }
                Console.WriteLine("");
            }

            matriz2 = new int[fila2, columna2];
            for (int f = 0; f < matriz2.GetLength(0); f++)
            {
                for (int c = 0; c < matriz2.GetLength(1); c++)
                {
                    Console.Write("por favor ingrese el elemento (" + (f + 1) + " " + (c + 1) + " ) ");
                    linea = Console.ReadLine();
                    matriz2[f, c] = int.Parse(linea);


                }
            }

            Console.WriteLine("la Matriz 2 resultante es :  ");
            Console.WriteLine("");

            for (int f = 0; f < matriz2.GetLength(0); f++)
            {
                for (int c = 0; c < matriz2.GetLength(1); c++)
                {
                    Console.Write("    (" + matriz2[f, c] + ")  ");

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            Console.WriteLine("acontinuacion se van a cambiar los datos  de las matrices ");
            Console.WriteLine("");
            Console.WriteLine("la matriz 1 ahora tiene los datos de la matriz 2");
            
                for (int f = 0; f < matriz2.GetLength(0); f++)
                {
                    for (int c = 0; c < matriz2.GetLength(1); c++)
                    {
                        Console.Write("    (" + matriz2[f, c] + ")  ");

                    }
                    Console.WriteLine("");
                }

            Console.WriteLine("la matriz 2 ahora tiene los datos de la matriz 1");
            for (int f = 0; f < matriz1.GetLength(0); f++)
            {
                for (int c = 0; c < matriz1.GetLength(1); c++)
                {
                    Console.Write("    (" + matriz1[f, c] + ")  ");

                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
        
        
    }
}
