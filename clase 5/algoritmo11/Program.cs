using System;
using System.Runtime.CompilerServices;

namespace algoritmo11
{
    class Program
    {
        private static int[,] matriz1;
        private static int[,] matriz2;

        static void Main(string[] args)
        {
            int filas;
            int columnas;
          // hacemos el arrglo para llenar la matriz 1 como no sabemos cuantas filas y columnas tiene el ususario debe especificarlas 
            Console.WriteLine("Hello World!");
            Console.WriteLine("acontinuacion vamos a llenar la matriz 1");
            Console.WriteLine("cuantas filas tiene la matriz");
            string linea;
            linea = Console.ReadLine();
            filas= int.Parse(linea);
            Console.WriteLine("cuantas colunas tiene la matriz 1");
            linea = Console.ReadLine();
            columnas = int.Parse(linea);
            matriz1 = new int[filas, columnas];
            for (int f = 0; f < matriz1.GetLength(0); f++)
            {
                for (int c = 0; c < matriz1.GetLength(1); c++)
                {
                    Console.Write("por favor ingrese el elemento (" + (f + 1) + " " + (c + 1) + " ) ");
                    linea = Console.ReadLine();
                    matriz1[f, c] = int.Parse(linea);


                }
            }
            // imprimimos la imagen de la matriz resulatante en este caso la matriz 1 
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

            // ahora luego de llenar la matrzi 1 llenamos la matriz 2 de la misam manera debe tener las mismas filas y columnas para poder realizar la multiplicacion de otra forma solo imprimira la matriz 2 resultante
            Console.WriteLine("");
            Console.WriteLine("acontinuacion vamos a llenar la matriz 2");
            Console.WriteLine("cuantas filas tiene la matriz");
            linea = Console.ReadLine();
            filas = int.Parse(linea);
            Console.WriteLine("cuantas colunas tiene la matriz 1");
            linea = Console.ReadLine();
            columnas= int.Parse(linea);

            matriz2 = new int[filas, columnas];
            for (int f = 0; f < matriz2.GetLength(0); f++)
            {
                for (int c = 0; c < matriz2.GetLength(1); c++)
                {
                    Console.Write("por favor ingrese el elemento (" + (f + 1) + " " + (c + 1) + " ) ");
                    linea = Console.ReadLine();
                    matriz2[f, c] = int.Parse(linea);


                }
            }
            //imprimimos la matriz 2
            Console.WriteLine("la matriz 2 resultante es :  ");
            Console.WriteLine("");

            for (int f = 0; f < matriz2.GetLength(0); f++)
            {
                for (int c = 0; c < matriz2.GetLength(1); c++)
                {
                    Console.Write("    (" + matriz2[f, c] + ")  ");

                }
                Console.WriteLine("");
            }

            // acontinuacuon vamos a multiplicar por 4 cada elemento y luego sumarlo ejemplo es multiplicar el elemento 1,1 de la matriz 1 por 4 y luego multiplicar el elemento (1,1) de la matriz 2 por 4 y sumar ambos resultados y asi con cada elemento 
            Console.WriteLine(" ");
            Console.WriteLine("La multiplicacion por 4 de cada elemento de las dos matrices y su respectiva suma  es de: ");
            Console.WriteLine(" ");

            //con una tercera matriz guradamos las dos matrices y multiplicamos y sumamos para que se imprima una matriz de los digitos
            
            float[,] matriz3 = new float[filas, columnas];
            for (int f = 0; f < matriz1.GetLength(0); f++)
            {
                for (int c = 0; c < matriz1.GetLength(1); c++)
                {
                    matriz3[f, c] = (matriz1[f, c]*4) + (matriz2[f, c]*4);
                    Console.Write(" [ " + matriz3[f, c] + " ] ");
                }
                Console.WriteLine();
            }
        }
    }
}
        