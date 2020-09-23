using System;
//Escribe un programa que sea capaz de calcular las ventas semanales de un mes de un
//negocio de comida rápida, además deberá desplegar en pantalla la venta total de todo el
//mes
namespace Ejercicio_16
{
    class Program
    {
        private static float[,] ventas;
        private static int[] semana;

        static void Main(string[] args)
        {
            //se declaran el arreglo y la matriz que va a ser utilizada
            ventas = new float[4, 7];
            semana = new int[4];

            float suma = 0.0f;
            float sum = 0.0f;
            for (int f = 0; f < semana.Length; f++)
            {
                Console.Write("digite las ganancias de la semana " + (f + 1));

                Console.WriteLine();

                for (int c = 0; c < ventas.GetLength(1); c++)
                {
                    Console.Write("digite las ganancais del día " + (c + 1) + ": ");
                    string linea;
                    linea = Console.ReadLine();
                    ventas[f, c] = float.Parse(linea);
                    //Almacenamos en un contador cada ciclo para imprimirlo en pantalla
                    suma = suma + ventas[f, c];
                    
                }
                Console.WriteLine("Las ganancias de la semana son de: " + suma);

                sum = sum + suma;


            }
           
            for (int c = 0; c < ventas.GetLength(1); c++)
            {
                Console.WriteLine("Las ganancias de la semana son de: " + suma);
            }

            //se muestra por pantalla las ganacias.
            Console.WriteLine("Las ganancias totales del mes son de: " + sum);
            Console.ReadKey();
        }
    }
}