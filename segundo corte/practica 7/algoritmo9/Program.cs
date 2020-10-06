using System;
using System.Collections;

//9.Escriba una rutina que reciba una Cola C de números enteros y mueva sus elementos
//a una nueva Pila, pero invirtiendo el orden de salida de los elementos. Al finalizar la Cola
//C no debe contener elementos.
namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos las pilas y la cola, la cual nos va a aydudar a que podamos invertir una pila sin la necesidad de un nodo
            Queue ColaC = new Queue();
            Stack Pnum1 = new Stack();
            Stack Pnum2 = new Stack();
            Stack Pnum3 = new Stack();

            //Le agregamos los valores a la cola
            ColaC.Enqueue(2);
            ColaC.Enqueue(3);
            ColaC.Enqueue(4);
            ColaC.Enqueue(5);
            Console.WriteLine("la cola inicial es: ");


            //igaul que en el ejercicio anterior vamos a guardar los valores de la cola en la respectiva pila
            while (ColaC.Count > 0)
            {
                //Aqui vamos almacenando los valores de la cola en la pila ya anteriromente determianda
                int Co = 0;
                Co = (int)ColaC.Dequeue();
                Console.WriteLine(Co);
                Pnum2.Push(Co);
                //Al decirle que se guarde en el segundo stack va solo cva a invertir la pila una ves que es lo que nos pide
            }
            Console.WriteLine();

            //Imprimimos el void
            Console.WriteLine("La pila copeada e invertida es: ");
            copia(Pnum1, Pnum2, Pnum3);


            //Ogual baseamos la cola
            while (ColaC.Count > 0)
            {
                ColaC.Clear();
                Console.WriteLine(ColaC);

            }
            Console.WriteLine("ya no existe elementos en la cola.");

        }
        static void copia(Stack n, Stack n1, Stack n2)
        {
            //Al hacer este ciclo hacemos que la pila se logre invertir sin la necesidad del nodo
            while (n.Count > 0)
                n1.Push(n.Pop());
            while (n1.Count > 0)
                n2.Push(n1.Pop());
            while (n2.Count > 0)
                Console.WriteLine("{0}", n2.Pop());
            //Al haberlo guardado en el segudno hace que solo se invierta unaves y no dos, de deja el primer stack para que la continuidad del
            //Algoritmo sea correcta y no se generen errores
        }
    }
}
