using System;
using System.Collections.Generic;
using System.Text;
namespace MultiplicacionMatrices
{
    class MultiplicacionMatrices
    {
        static void Main()
        {
            //acontinuacion declaramos las variables de la matriz 1 y matriz 2 
            int f1 = 0;
            int f2 = 0;
            int c1 = 0;
            int c2 = 0;
            Console.WriteLine("Matriz 1");
            Console.Write("Numero de filas: ");
            f1 = int.Parse(Console.ReadLine());
            Console.Write(" Numero de columnas ");
            c1 = int.Parse(Console.ReadLine());// en este momento ya se saben cauntas lineas y columnas posee el arreglo 
            Console.WriteLine(" Matriz 2");
            Console.Write("Numero de filas: ");
             f2 = int.Parse(Console.ReadLine());
            Console.Write(" Numero de columnas: ");
             c2 = int.Parse(Console.ReadLine());
            int[,] Matriz1 = new int[f1+1 , c1+1 ];// estas variables son para acomodadr el arreglo de cada matriz 
            int[,] Matriz2 = new int[f2+1, c2+1 ];
            int[,] Multiplicacion = new int[f1 + 1, c2 + 1]; 
          
                Console.WriteLine("  vamos a llenar la  matriz 1: ");// acontinuacion se va a llenar la matriz M1
                for (int i = 1; i <= f1; i++)
                {
                    for (int j = 1; j <= c1; j++)
                    {
                        Console.Write("Ingresa Dato (Fila: {0} - Columna: {1}): ", i, j);
                        Matriz1[i, j] = int.Parse(Console.ReadLine());



                    }

                   

                }

                Console.WriteLine("la M1 resultante es :  ");// se imprime la matriz M1 resultante 
                Console.WriteLine("");

                for (int f = 1; f < Matriz1.GetLength(0); f++)
                {
                    for (int c = 1; c < Matriz1.GetLength(1); c++)
                    {
                        Console.Write("    (" + Matriz1[f, c] + ")  ");

                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("vamos a llenar la matriz 2: ");// acontinuacion se va a llenar la matriz 2 M2 manualmente
                for (int i = 1; i <= f2; i++)
                {
                    for (int j = 1; j <= c2; j++)
                    {
                        Console.Write("Ingresa Dato (Fila: {0} - Columna: {1}): ", i, j);
                        Matriz2[i, j] = int.Parse(Console.ReadLine());
                    }

                    

                }
                Console.WriteLine("la M2  resultante es :  ");// se imprime la matriz 2 M2 resultante 
                Console.WriteLine("");

                for (int f = 1; f < Matriz2.GetLength(0); f++)
                {
                    for (int c = 1; c < Matriz2.GetLength(1); c++)
                    {
                        Console.Write("    (" + Matriz2[f, c] + ")  ");

                    }
                    Console.WriteLine("");
                }
                for (int i = 1; i <= f1; i++)// ciclo for para poder realziar la multiplicaion 
                {
                    for (int j = 1; j <= c2; j++)
                    {
                        Multiplicacion[i, j] = 0;
                        for (int z = 1; z <= c1; z++)
                        {
                            Multiplicacion[i, j] = Matriz1[i, z] * Matriz2[z, j] + Multiplicacion[i, j];
                        }
                    }
                } //
                Console.WriteLine("Multiplicacion de 2 Matrices MP =");//se realiza la multiplicacion y ademas se imprime el resultado 
                for (int i = 1; i <= f1; i++)
                {
                    for (int j = 1; j <= c2; j++)
                    {
                        Console.Write("{0} ", Multiplicacion[i, j]);
                    }
                    Console.WriteLine();
                }
            
            // NOTA :profe hice lo que mas pude perdon si quedo muy largo 
        }
    }
}