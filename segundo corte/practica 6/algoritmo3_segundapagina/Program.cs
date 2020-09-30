using System;
using System.Collections;

namespace algoritmo3_segundapagina

{
    class Program
    {
        // 3.Escriba una rutina que reciba dos Pilas P1 y P2 de números flotantes y apile las mismas en una nueva Pila resultante.Es de destacar que las Pilas recibidas no deben sufrir ningún tipo de cambio o alteración.
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";
            float numero = 0.0f;
            
            Stack pila1 = new Stack();// definimos los stack para la pila 1 y la pila 2
            Stack pila2 = new Stack();
            Stack pila3 = new Stack();
            Stack pilaax = new Stack();

            do
            {
                // como el problema nos pide que reciba dos pilas primero hay que llenar ambas pilas 
                // una vez definidos los stack mediante un ciclo do pedimos al usuario que llene la pila mediante la opcion 1 y pueda ver cuantos datos con la opcion 2 mediante la opcion 3 dejara de llenar la pila 1
                Console.WriteLine("hola primero vamos a llenar  la pila 1");
                Console.WriteLine(" 1. agregar numero flotante");
                Console.WriteLine(" 2. mostrar los numeros agregados ");
                Console.WriteLine(" 3. dejar de llenar esta pila ");
                Console.WriteLine("por favor selecciona una opcion ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                // mediante los ciclos if definimos que se hara segun la opcion digitada
                if (opcion == 1)
                {
                    Console.WriteLine("por favor ingresa un numero flotante ");// se ingresa un numero flotante debe ser ingresado con el punto (.) ejemplo 3.3 porque si e agrega con la coma se tomara como entero 
                    valor = Console.ReadLine();
                    numero = Convert.ToSingle(valor);
                    pila1.Push(numero);
                    Console.WriteLine("");

                }

                if (opcion == 2)
                {
                    Console.WriteLine("la pila tiene los siguientes elementos almacenados", pila1.Count);
                    foreach (float m in pila1)
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

                Console.WriteLine(" 1. agregar numero flotante");
                Console.WriteLine(" 2. mostrar los numeros agregados ");
                Console.WriteLine(" 3. dejar de llenar esta pila ");
                Console.WriteLine("por favor selecciona una opcion ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                // de igual manera creamos ciclos if para realizar una accion segun la opcion 
                if (opcion == 1)
                {
                    Console.WriteLine("por favor ingresa un numero flotante ");
                    valor = Console.ReadLine();
                    numero = Convert.ToSingle(valor);
                    pila2.Push(numero);
                    Console.WriteLine("");

                }

                if (opcion == 2)
                {
                    Console.WriteLine("la pila tiene los siguientes elementos almacenados", pila2.Count);
                    foreach (float m in pila2)
                        Console.Write("{0} , ", m);
                    Console.WriteLine("");
                    Console.WriteLine("//////////////////////");
                }
            } while (opcion != 3);

            //cuando el usuario termine de llenar las dos pilas imprimimos los datos registrados en cada pila segun su orden de entrada 
            Console.WriteLine("");
            Console.WriteLine("la pila1  corresponde a :");
            foreach (float m in pila1)
                Console.Write("{0} , ", m);
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("la pila2  corresponde a :");
            foreach (float m in pila2)
                Console.Write("{0} , ", m);
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("acontinuacion una nueva pila apilada con los datos  de las pilas 1 y 2");
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
            while (pila3.Count > 0)
            {
                pilaax.Push(pila3.Pop());// ya con los datos de la pila 1 y 2 en la pila 3 pasamos estso datos a una nueva pila 
            }
            while (pilaax.Count > 0)
            {

                Console.WriteLine("" + pilaax.Pop());// se imprimen los datos de la nueva pila apilada
            }
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}

