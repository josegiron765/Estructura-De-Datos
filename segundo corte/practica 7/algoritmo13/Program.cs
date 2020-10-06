using System;
using System.Collections;
using System.Collections.Generic;

namespace algoritmo13
{
    class Program
    {
       // Escriba una rutina que reciba una ColaC de números flotantes y devuelva una  Pila,manteniendo el orden de salida de los elementos.Es de destacar que la ColaC no debe sufrir ningún tipo de cambio o alteración.
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
                    // se empieza a llenar la cola hasta que el usuario digite la opcion 3 
                    Console.WriteLine("");
                    Console.WriteLine("digita un numero por favor");
                    num = Convert.ToSingle(Console.ReadLine());
                    cola.Enqueue(num);
                    Console.WriteLine("");
                }
                if (opcion == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("los valores de la cola son :", cola.Count);
                    foreach (float m in cola)
                    {
                        Console.Write("{0} , ", m);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

            } while (opcion != 3);
            Console.WriteLine("");
            Console.WriteLine("la cola resultante es ");
            foreach (float m in cola)
            {
                Console.Write("{0} , ", m);
            }
            Console.WriteLine("");
            Console.WriteLine("");

            // creamos el stack pila y le agregamos los datos de la cola y lo imprimios en el mismo orden de salida 
            Stack pila = new Stack(cola.Count);
            Console.WriteLine("");
            Console.WriteLine("los datos en la pila con el mismo orden son ");
            Console.WriteLine("");
            foreach (float m in cola)
            {
                Console.Write("{0} , ", m);
            }
            Console.ReadKey();
            // profe este ejercicio me gustaria que lo hicieras en clase ya que no me fue tan facil hacerlo y al momento de copiar a la pila no se si enrealidad se copean los elememtos 
        }
    }
}

    
   
  
        
        
           
