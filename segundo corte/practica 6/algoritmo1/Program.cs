using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

//Escriba un programa que inserte valores ordenadamente en una lista. La lista/pila/cola
//debe almacenar números enteros. El programa debe leer una secuencia de números
//enteros de la entrada hasta que se ingrese el número cero

namespace Ejercicios_listas_Nu1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Num = new ArrayList();

            //En esta parte mostraremos nuestra lista inicial la cual vamos a modificar mas adelante.
            Console.WriteLine("Lista inicial");

            Num.Add(1);
            Num.Add(500);
            Num.Add(20);
            Num.Add(50);
            Num.Add(30);
            Num.Add(40);
            Num.Add(600);
            Num.Add(200);
            Num.Add(1000);
            Num.Add(861);
            imprime(Num);
            //Agregamos los valores y le ponemos el valor para que lo imprima en patalla

            int opcion = 0;
            String val = "";

            //Con el do/While nos permitira finaliozar el algoridmo caundo el usuario digite 0
            do
            {
                Console.WriteLine("0. cerrar");
                Console.WriteLine("1. mostrar lista con valores(4, 5, 7) insertados");
                Console.WriteLine("2. Mostrar lista con los valores (22, 11, 99) agregados");

                val = Console.ReadLine();
                opcion = Convert.ToInt32(val);

                //Con la opcion 1 y 2 nos agregaran 3 valores a la lista esto diguienfo el criterio de 0, 1, 2 asi sabreos que esta organizada
                if (opcion == 1)
                {
                    Num.Add(4);
                    Num.Add(5);
                    Num.Add(7);

                    Console.WriteLine("Valores agregados");
                    imprime(Num);
                }
                if (opcion == 2)
                {
                    Num.Add(22);
                    Num.Add(11);
                    Num.Add(999);

                    Console.WriteLine("Nuevos Valores agregados");
                    imprime(Num);
                }

            } while (opcion != 0);
        }

        //Con este ultimo podremos hacer que nuestra variable "imprime" me muestre por pantalla la lista creada.
        static void imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.Write(" {0},", n);
            Console.WriteLine("\n-----------");
        }
    }
}
