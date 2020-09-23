using System;
using System.Runtime.InteropServices;
using System.Xml.Schema;

//Escribe un programa que permita llevar un control de planilla de los sueldos de N empleados
//de la empresa Calipso SA. Se debe mostrar el siguiente menú de manera continua:
//a.Ingresar datos(Nombre y sueldo base) de un nuevo empleado
//b. Ver informe de un empleado: Muestra nombre, sueldo base y sueldo neto.
//c. Ver Planilla de empleados:
//i.Se debe presentar como una tabla conteniendo los siguientes datos:
//1.Por c / empleado:
//a. #correlativo de empleado, nombre, monto de sueldo base,
//descuento de renta (10%), de ISSS(3.5%) y sueldo final.
//b. Finalmente se muestra el monto de planilla completa a
//pagar.
//d. d) Finalizar aplicación

namespace Ejercicio_14
{
    class Program
    {
        private static string[] nombre;
        private static int[] sueldo;
        private static int[] pagar;

        static void Main(string[] args)
        {
            Console.Write("digite la cantidad de empleados que van haber en la empresa Calipso SA.: ");
            Console.WriteLine();
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);

            //Creamos un arreglo a la par de un matris para almacenar los valores tipo string y los valores tipo int en la misma matriz
            nombre = new string[filas];
            int[,] sal = new int[filas, 1];
            for (int f = 0; f < nombre.Length; f++)
            {
                Console.Write("digite el nombre del empleado [" + (f + 1) + "]: ");
                nombre[f] = Console.ReadLine();

                for (int c = 0; c < sal.GetLength(1); c++)
                {
                    Console.Write("sigite su sueldo base: ");
                    linea = Console.ReadLine();
                    sal[f, c] = int.Parse(linea);
                }
            }

            //este contador nos almacena los valores de del sueldo para poder mostrarlo mas adelante
            sueldo = new int[filas];
            for (int s = 0; s < sal.GetLength(0); s++)
            {
                int ss = 0;
                for (int g = 0; g < sal.GetLength(1); g++)
                {
                    ss = ss + sal[s, g];
                }
                sueldo[s] = ss;
            }

            Console.WriteLine();
            Console.WriteLine("Total de empleados y sus sueldos");
            Console.WriteLine();

            //Aquí mostramos los datos guardados en sueldo por pantalla
            for (int f = 0; f < sueldo.Length; f++)
            {
                Console.WriteLine(nombre[f] + " con un sueldo de: " + sueldo[f]);
            }

            Console.WriteLine();
            Console.WriteLine("Total de empleados y sus sueldos netos (Te descontamos 10% de renta y 3,5% de ISSS)");
            Console.WriteLine();

            float tolta = 0.0f;
            pagar = new int[filas];
            //aquí juntando pasandolos a tipo float les podemos hacer los descuentos para imprimirlos por pantalla
            for (int f = 0; f < sueldo.Length; f++)
            {

                float sum = (float)(sueldo[f] * 0.1 * 3.5);
                Console.WriteLine(nombre[f] + " con: " + sum);
                tolta = tolta + sum;

            }
            Console.WriteLine();
            Console.WriteLine("El total a pagar es de: " + tolta);
            Console.ReadKey();
        }
    }
}