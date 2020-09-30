using System;
using System.Collections;

namespace algoritmo6
{
    class Program
    {
        
        // Escriba un programa que dadas dos lista/pila/cola ordenadas de números enteros, realice la concatenación en forma ordenada de ambas lista/pila/cola.
        static void Main(string[] args)
        { // definimos los stacks de 4 pilas la pila 1 y 2 donde tenderemos datos determinados la pila3 es una pila dodne vamos a almacenar los datos de la pila 1 y 2 y la pilacn es la pila donde se va a impirmir los datos de pila3
            Stack pila1 = new Stack();
            Stack pila2 = new Stack();
            Stack pila3 = new Stack();
            Stack pilacn = new Stack();
            pila1.Push(8);
            pila1.Push(9);
            pila1.Push(3);
            pila1.Push(1);
            pila1.Push(7);
            pila2.Push(5);
            pila2.Push(10);
            pila2.Push(11);
            pila2.Push(4);
            pila2.Push(2);
            // imprimos por pantalla los datos de la pila 1 y 2
            Console.WriteLine("tenemos estos datos en la pila 1");
            imprime(pila1);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("tenemos estos datos en la pila 2");
            imprime(pila2);
            // aca se imprime la pila concatenada que se realiza mediante un ciclo while 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("acontinuacion una nueva pila concatenada con los datos  de las pilas 1 y 2");
            Console.WriteLine("");
            // definimos los ciclos while para que se pueda almacenar los datos en la pila 3 
            while (pila1.Count > 0)
            {
                pila3.Push(pila1.Pop());// agregamos los datos de la pila 1 a pila 3 mediante un pop
            }
            while (pila2.Count > 0)
            {
                pila3.Push(pila2.Pop());//agregamos los datos de la pila 2 a pila 3 mediante un pop
            }
            while(pila3.Count > 0)
            {
                pilacn.Push(pila3.Pop());// ya con los datos de la pila 1y 2 en la pila 3 pasamos estso datos a una nueva pila 
            }
            while (pilacn.Count > 0)
            {
                Console.Write("," + pilacn.Pop());// se imprimen los datos en una pila concatenada 
            }
            Console.WriteLine("");


            Console.ReadKey();
        }

        static void imprime(Stack arreglo)// arreglo para que sea posible la impresion de datos  
        {
            foreach (int m in arreglo)
                Console.Write("{0},", m);
        }
    }
}
