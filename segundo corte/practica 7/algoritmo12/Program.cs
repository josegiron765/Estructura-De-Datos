using System;
using System.Collections;
using System.Collections.Generic;

namespace algoritmo12
{
    class Program
    {// Escriba una rutina que reciba una ColaC de números flotantes y devuelva una nueva Cola pero con los elementos invertidos,es decir el ultimo de la Cola C, pasará a ser el primero de la nueva Cola.Es de destacar que la Cola C no debe sufrir ningún tipo de cambio o alteración.
        static void Main(string[] args)
        {
            //creamos la cola para ingresar los numeros flotantes
            Queue cola = new Queue();
            // asignamos la variale num como float para recibir numeros flotantes 
            float num = 0.0f;
            int opcion;
            Console.WriteLine("ahora vamos a llenar la cola con numeros flotantes ");
            do
            {
                //con un ciclo do while empezamos  a llenar la cola 
                Console.WriteLine("1) agregar numero");
                Console.WriteLine("2) mostar numeros en la cola ");
                Console.WriteLine("3) dejar de llenar la cola ");
                Console.Write("");
                Console.Write("por favor digita una opcion ");
                Console.WriteLine("");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("digita un numero por favor");
                    num = Convert.ToSingle(Console.ReadLine());
                    cola.Enqueue(num);
                    Console.WriteLine("");
                }
                if (opcion == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("los valores de la cola son :",cola.Count);
                    foreach(float m in cola)
                    {
                        Console.Write("{0} , ", m);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

            } while (opcion != 3);
            // una vez llenada la cola creamos una pila para ayudarnos a invertir la salida de los datos 
            Console.WriteLine("");
            
            Stack pila = new Stack();
           
            Console.WriteLine("la cola resultante con su orden de salida es :");
            Console.WriteLine("");
            // aca tenemos la cola resultante  con su orden de salida norm al 
            foreach (float m in cola)
            {
                Console.Write("{0} , ", m);
            }
            Console.WriteLine("");
            Console.WriteLine("pasamos los datos a una nueva cola ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("cola invertida ");
            while (cola.Count > 0)
            {
                pila.Push(cola.Dequeue());
            }
            while (pila.Count > 0)
            {
                cola.Enqueue(pila.Pop());

            }
            while (cola.Count > 0)
            {
               
                Console.WriteLine("{0}", cola.Dequeue());
            }
            
            Console.WriteLine("");
            Console.WriteLine("");
            
        }
    }
}
