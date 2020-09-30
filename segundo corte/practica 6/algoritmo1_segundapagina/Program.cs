using System;
using System.Collections;

namespace algoritmo1_segundapagina
{
    class Program
    { // 1.Escriba una rutina que reciba una Pila P de números enteros y mueva sus elementos a una nueva Pila,pero manteniendo  el orden de  salida  de los mismos.Al finalizar la PilaP no debe contener elementos.
        static void Main(string[] args)
        {// definimos variables para que el usuario llene la pila ya que el ejercicio lo pide
            int opcion = 0;
            int numero = 0;
            string valor = "";
            // creamos 2 stack de pilas 
            Stack pilap = new Stack();
            Stack pilaax = new Stack();
            // definimos un ciclo do while para llenar la pila y realizar las respectivas acciones 
            do
            {
                Console.WriteLine("");
                Console.WriteLine("ahora vamos a llenar la pila p");
                Console.WriteLine("1.ingresar un numero");
                Console.WriteLine("2.mirar los elementos registrados");
                Console.WriteLine("3.dejar de llenar la pila,pasar los datos a una nueva pila y dejar vacia esta pila");
                Console.WriteLine("");
                Console.WriteLine("digita una opcion ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                Console.WriteLine("");
                // hacemos un ciclo if para cada una de las opciones posibles
                if (opcion == 1)
                {
                    Console.WriteLine("por favor ingresa un numero ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);
                    pilap.Push(numero);
                    Console.WriteLine("");
                }
                if (opcion == 2)
                {
                    Console.WriteLine("la pila tiene los siguientes elementos almacenados", pilap.Count);
                    foreach (int m in pilap)
                        Console.Write("{0} , ", m);
                    Console.WriteLine("");
                    Console.WriteLine("//////////////////////");
                }
            } while (opcion != 3);
            // como nos pide el problema primero imprimimos como quedo la pila P
            Console.WriteLine("");
            Console.WriteLine("la pila P corresponde a :");
            foreach (int m in pilap)
                Console.Write("{0} , ", m);
            Console.WriteLine("");
            // luego movemos los datos de la pila p a la nueva pila auxiliar

            // una vez movidos los datos a la nueva pila procedemos a limpiar la pila P con el metodo clear y procedemos a imprimir por pantalla los datos ingresados manteniendo su orden de entrada
            Console.WriteLine("");
            Console.WriteLine("los datos en una nueva pila con el orden de salida ");
            foreach (int m in pilap)
                Console.Write("{0} , ", m);

            Console.WriteLine("");
            Console.WriteLine("ahora se muestra la pila P sin elementos  ");
            Console.Write("pila P =");
            pilap.Clear();// con el comando .clear limpiamos la pila P para que quede vacia 
            Console.WriteLine("");


        }
    }
}
