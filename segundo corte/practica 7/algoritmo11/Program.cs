using System;
using System.Collections;

namespace algoritmo11
{
    class Program
    { // Escriba una rutina que reciba dos Colas C1 y C2 de números enteros y proceda a intercambiar sus elementos,pero manteniendo el orden de salida de  los mismos.Al finalizar la rutina,la Cola C1 tendrá los elementos de la ColaC2 y esta a su vez tendrá los elementos de la ColaC1.
        static void Main(string[] args)
        {
            Queue cola1 = new Queue();// creamos las dos colas con el metodo queue
            Queue cola2 = new Queue();
            int opcion ; // definimos unas varibales int para poder llenar la cola
            int num;
            Console.WriteLine("ahora vamos a llenar la cola 1");
            do
            {
                // con un ciclo do while procedemos a llenar la cola 1 
                Console.WriteLine("");
                Console.WriteLine("1) agregar dato ");
                Console.WriteLine("2) mostrar datos de la cola ");
                Console.WriteLine("3) dejar de llenar esta cola ");
                Console.WriteLine("");
                Console.WriteLine("digita una opcion por favor");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    // con el  metodo enqueue agregamos el datoa  al cola 
                    Console.WriteLine("");
                    Console.WriteLine("por favor digita un numero para la cola");
                    num = Convert.ToInt32(Console.ReadLine());
                    cola1.Enqueue(num);
                }
                if (opcion == 2)
                {
                    // mdeiante un count sabemos cuantos datos tiene la cola y asi poder imprimirlos por pantalla mediante un foreach
                    Console.WriteLine("");
                    Console.WriteLine("los elementos de la cola son ", cola1.Count);
                    foreach (int m in cola1)
                    {
                        Console.Write("{0} , ", m);

                    }
                    Console.WriteLine("");
                }
            } while (opcion != 3);
            // si el usuario digita la opcion 3 empezara automaticamente a llenar la cola 2 de igual manera como lleno la cola 1
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("ahora vamos a llenar la cola 2 ");
            do
            {
                Console.WriteLine("");
                Console.WriteLine("1) agregar dato ");
                Console.WriteLine("2) mostrar datos de la cola ");
                Console.WriteLine("3) dejar de llenar esta cola ");
                Console.WriteLine("");
                Console.WriteLine("digita una opcion por favor");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("por favor digita un numero para la cola");
                    num = Convert.ToInt32(Console.ReadLine());
                    cola2.Enqueue(num);
                }
                if (opcion == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("los elementos de la cola son ", cola2.Count);
                    foreach (int m in cola2)
                    {
                        Console.Write("{0} , ", m);

                    }
                    Console.WriteLine("");
                }
            } while (opcion != 3);
            // una vez llenadas las dos colas imprimimos las dos colas originales 
            Console.WriteLine("");
            Console.WriteLine("la cola 1 corresponde a : ");
            foreach (int m in cola1)
            {
                Console.Write("{0} , ", m);

            }
            Console.WriteLine("");

            Console.WriteLine("la cola 2 corresponde a : ");
            foreach (int m in cola2)
            {
                Console.Write("{0} , ", m);

            }
            // una vez impresas las colas procedemos a intercambiar los datos de ambas colas  
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine( "ahora procederemos a  intercambiar los valores de ambas pilas ");
            Console.WriteLine("");
            Console.WriteLine("ahora la cola 1 tiene los elementos de la cola 2 con el mismo orden de salida ");
            Console.WriteLine("");
            Console.Write("cola 1 = ");
            foreach (int m in cola2)
            {
                Console.Write("{0} , ", m);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("ahora la cola 2 tiene los elementos de la cola 1 con el mismo orden de salida ");
            Console.WriteLine("");
            Console.Write("cola 2 = ");
            foreach (int m in cola1)
            {
                Console.Write("{0} , ", m);

            }
            Console.WriteLine("");



        }
    }
}
