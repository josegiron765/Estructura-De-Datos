using System;
using System.Collections;
using System.Collections.Generic;

//10.Escriba una rutina que reciba dos Colas C1 y C2 de números enteros y
//devuelva una nueva Cola con los elementos concatenados en el orden C1 y C2. Es de
//destacar que las Colas recibidas no deben ser sufrir ningún tipo de cambio o alteración.
namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos las tres listas que vasmo a usar
            Queue ColaC1 = new Queue();
            Queue ColaC2 = new Queue();
            Queue ColaC3 = new Queue();

            //Les asignamos sus diferentes valores
            ColaC1.Enqueue(2);
            ColaC1.Enqueue(3);
            ColaC1.Enqueue(4);
            ColaC1.Enqueue(5);

            ColaC2.Enqueue(6);
            ColaC2.Enqueue(4);
            ColaC2.Enqueue(3);
            ColaC2.Enqueue(2);

            //Mostramos por pantalla la cola 1 y 2
            Console.WriteLine("Cola 1");
            Console.WriteLine();
            while (ColaC1.Count > 0)
            {
                int Co = 0;
                Co = (int)ColaC1.Dequeue();
                Console.Write(" [" + Co + "] ");
                ColaC3.Enqueue(Co);
                Console.WriteLine();

            }
            Console.WriteLine();

            Console.WriteLine("Cola 2");
            Console.WriteLine();
            while (ColaC2.Count > 0)
            {
                int Co = 0;
                Co = (int)ColaC2.Dequeue();
                Console.Write(" [" + Co + "] ");
                //En cada repeticion de la cola 1 y 2 se van a ir almacenando los datos en la cola 3 para mostrar la union
                ColaC3.Enqueue(Co);
                Console.WriteLine();
            }
            Console.WriteLine();

            //ya con los valores almacenados en la cola 3 los mostramos por pantalla
            Console.WriteLine("Union de las dos colas");
            Console.WriteLine();
            while (ColaC3.Count > 0)
            {
                int Co = 0;
                Co = (int)ColaC3.Dequeue();
                Console.Write(" [" + Co + "] ");
            }
            Console.WriteLine();
        }
    }
}
