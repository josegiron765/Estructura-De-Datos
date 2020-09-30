using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace Ejercicios_listas_Nu4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos las dos listas pedidas en el ejercicio

            Console.WriteLine("lista número 1");
            ArrayList Lista1 = new ArrayList();
            Lista1.Add(1);
            Lista1.Add(3);
            Lista1.Add(5);
            Lista1.Add(7);
            Lista1.Add(9);
            imprime(Lista1);

            Console.WriteLine("lista número 2");
            ArrayList Lista2 = new ArrayList();
            Lista2.Add(2);
            Lista2.Add(4);
            Lista2.Add(6);
            Lista2.Add(8);
            Lista2.Add(10);
            imprime(Lista2);

            Console.WriteLine("La concanetacion de las dos listas es: ");
            //Con este comando concatena las dos listas, ya que usamos el imprimir(lista1) 2 veces lo que hace el ejercicio es seguir la secuencia
            //y primero va a imnprimir la lista sin la concanetacion y siguiendo los pasos luego lo concatena y lo imprime
            Lista1.AddRange(Lista2);
            imprime(Lista1);
        }
        static void imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.Write(" {0},", n);
            Console.WriteLine("\n-----------");
        }
    }
}