using System;
using System.Runtime.CompilerServices;

//Escribir un programa que divida dos matrices. La primera matriz llamada dividendo que
//tendrá los números a dividir y la segunda matriz llamada divisora que tendrá los números 
//que dividirán los elementos de la primera matriz. Los cocientes o resultados serán
//almacenados en otra matriz llamada cociente.

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ya que hablamos de matrices por favor en las dos siguientes preguntas ingresa valores de 2 en adelnate");
            Console.WriteLine("");
            //aquí le damos a elegir al usuario que tan grande quiere que sea la matris.
            Console.WriteLine("Digite la cantidad filas que tendra los divisores y dividendos: ");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);

            Console.WriteLine("Digite la cantidad de columnas que tendra los divisores y dividendos: ");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);

            //ya teniendo los dos valores de la matriz creamos una primmera para poder almacenar los divisores
            float[,] mat = new float[filas, columnas];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("Digite el divisor [" + (f + 1) + "   " + (c + 1) + "]: ");
                    linea = Console.ReadLine();
                    mat[f, c] = float.Parse(linea);

                }
            }
            //Aquí imprimimos en paltalla la matriz que acabamos de crear
            Console.WriteLine(" ");
            Console.WriteLine("La matris es divisora es: ");
            Console.WriteLine(" ");

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(" [ " + mat[f, c] + " ] ");

                }
                Console.WriteLine();
            }
            

            //Aquí guardamos los valores de los dividentos
            float[,] mat1 = new float[filas, columnas];

            for (int j = 0; j < mat1.GetLength(0); j++)
            {
                for (int k = 0; k < mat1.GetLength(1); k++)
                {
                    Console.Write("Digite el dividendo [" + (j + 1) + "   " + (k + 1) + "]: ");
                    linea = Console.ReadLine();
                    mat1[j, k] = float.Parse(linea);
                }
            }

            //Y aqui los imprimimos en pantalla
            Console.WriteLine(" ");
            Console.WriteLine("La matris es dividenda es: ");
            Console.WriteLine(" ");

            for (int j = 0; j < mat.GetLength(0); j++)
            {
                for (int k = 0; k < mat.GetLength(1); k++)
                {
                    Console.Write(" [ " + mat1[j, k] + " ] ");

                }
                Console.WriteLine();
            }
            

            Console.WriteLine(" ");
            Console.WriteLine("La division de las dos matrices es de: ");
            Console.WriteLine(" ");

            //con una tercera matriz guradamos las dos matrices y las dividmimos para que de solo una matris con la divicion de los digitos
            //que ingrese el usuario
            float[,] matriz3 = new float[filas, columnas];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    matriz3[f, c] = mat[f, c] / mat1[f, c];
                    Console.Write(" [ " + matriz3[f, c] + " ] ");
                }
                Console.WriteLine();
            }
        }
    }
}