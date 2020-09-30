using System;
using System.Collections;

namespace algoritmo4_segundapagina
{
    class Program
    {
        //4. Escriba una rutina que reciba dos Pilas P1 y P2 de números enteros y proceda a intercambiar sus elementos
//pero manteniendo el orden de salida de los elementos.Al finalizar la rutina,laPilaP1 tendrá los elementos de la PilaP2 y esta a su vez tendrá los elementos de la Pila P1.

    
            static void Main(string[] args)
            {
                int opcion = 0;
                string valor = "";
                int numero = 0;
                Stack pila1 = new Stack();// definimos los stack para la pila 1 y la pila 2
                Stack pila2 = new Stack();

                do
                {
                    // como el problema nos pide que reciba dos pilas primero hay que llenar ambas pilas 
                    // una vez definidos los stack mediante un ciclo do pedimos al usuario que llene la pila mediante la opcion 1 y pueda ver cuantos datos con la opcion 2 mediante la opcion 3 dejara de llenar la pila 1
                    Console.WriteLine("");
                    Console.WriteLine("hola primero vamos a llenar  la pila 1");
                    Console.WriteLine(" 1. agregar numero");
                    Console.WriteLine(" 2. mostrar los numeros agragados ");
                    Console.WriteLine(" 3. dejar de llenar esta pila ");
                    Console.WriteLine("por favor selecciona una opcion ");
                    valor = Console.ReadLine();
                    opcion = Convert.ToInt32(valor);
                    // mediante los ciclos if definimos que se hara segun la opcion digitada
                    if (opcion == 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("por favor ingresa un numero ");
                        valor = Console.ReadLine();
                        numero = Convert.ToInt32(valor);
                        pila1.Push(numero);


                    }

                    if (opcion == 2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("la pila tiene los siguientes elementos almacenados", pila1.Count);
                        foreach (int m in pila1)
                            Console.Write("{0} , ", m);
                        Console.WriteLine("");
                        Console.WriteLine("//////////////////////");
                    }
                } while (opcion != 3);
                // procedemos a otro ciclo do para la pila 2
                Console.WriteLine("");
                Console.WriteLine("ahora vamos a llenar la pila 2");
                Console.WriteLine("");
                do
                {

                    Console.WriteLine(" 1. agregar numero");
                    Console.WriteLine(" 2. mostrar los numeros agragados ");
                    Console.WriteLine(" 3. dejar de llenar esta pila ");
                    Console.WriteLine("por favor selecciona una opcion ");
                    valor = Console.ReadLine();
                    opcion = Convert.ToInt32(valor);
                    // de igual manera creamos ciclos if para realizar una accion segun la opcion 
                    if (opcion == 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("por favor ingresa un numero ");
                        valor = Console.ReadLine();
                        numero = Convert.ToInt32(valor);
                        pila2.Push(numero);


                    }

                    if (opcion == 2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("la pila tiene los siguientes elementos almacenados", pila2.Count);
                        foreach (int m in pila2)
                            Console.Write("{0} , ", m);
                        Console.WriteLine("");
                        Console.WriteLine("//////////////////////");
                    }
                } while (opcion != 3);

                //cuando el usuario termine de llenar las dos pilas imprimimos los datos registrados en cada pila segun su orden de entrada 
                Console.WriteLine("");
                Console.WriteLine("la pila1  corresponde a :");
                foreach (int m in pila1)
                    Console.Write("{0} , ", m);
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("la pila2  corresponde a :");
                foreach (int m in pila2)
                    Console.Write("{0} , ", m);
                Console.WriteLine("");
                // como nos pide el ejercicio intercambiamos los datos de ambas pilas y las imprimimos 
                Console.WriteLine("");
                Console.WriteLine("ahora vamos a intercambiar los datos de ambas pilas ");
                Console.WriteLine("");
                Console.WriteLine("la pila 1 tiene los datos de la pila 2 :");
                foreach (int m in pila2)
                    Console.Write("{0} , ", m);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("la pila 2 tiene los datos de la pila 1 :");
                foreach (int m in pila1)
                    Console.Write("{0} , ", m);
                Console.WriteLine("");

            }
        }
    
}

