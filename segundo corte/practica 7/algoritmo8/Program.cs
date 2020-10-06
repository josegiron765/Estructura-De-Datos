using System;
using System.Collections;

//8.Escriba una rutina que reciba una Cola C de números enteros y mueva sus elementos
//a una nueva Pila, pero manteniendo el orden de salida de los elementos. Al finalizar
//la Cola C no debe contener elementos.
namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aquí Determinamos la variable pila y cola las cuales son pedidd por el ejercicio
            Queue ColaC = new Queue();
            Stack Pila = new Stack();

            //Le asignamos los valores a la cola
            ColaC.Enqueue(2);
            ColaC.Enqueue(3);
            ColaC.Enqueue(4);
            ColaC.Enqueue(5);

            //Para comodiad del usuario le mostramos por pantalla cual es la lista inicial
            Console.WriteLine("la cola inicial es: ");
            while (ColaC.Count > 0)
            {
                //Aqui vamos almacenando los valores de la cola en la pila ya anteriromente determianda
                int Co = 0;
                Co = (int)ColaC.Dequeue();
                Console.WriteLine(Co);
                Pila.Push(Co);
            }
            Console.WriteLine();

            //aqui mostramos por pantalla la copia de la pila, ya que la pila muestra de primear el ultimo valor ingresado nos va a mostar de forma inversa
            //la cola, ya que es asi como la miestra la pila
            Console.WriteLine("La copia de esta cola en una pila es: ");
            while (Pila.Count > 0)
            {
                Console.WriteLine("Copia: " + Pila.Pop());
            }

            //Aqui auqnue sobra en "ColaC.Clear()" ya que no hay valores en la cola, se agregara solo por la seguruidad de que no queden valores en la cola,
            //Aunque ya hubieramos pasado los valores a la pila.
            while (ColaC.Count > 0)
            {
                ColaC.Clear();
                Console.WriteLine(ColaC);

            }
            Console.WriteLine("ya no existe elementos en la cola.");
        }
    }
}
