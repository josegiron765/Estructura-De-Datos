using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

//Escriba un programa que reciba la dirección del primer elemento de una lista/pila/cola
//simple de números enteros y devuelva un apuntador al elemento donde exista el
//número. <x>. Este número es recibido por el método. Se debe retornar NULL si el valor
//de <x> no se encuentra en la lista/pila/cola.

namespace Ejercicios_listas_Nu3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Num = new ArrayList();
            Num.Add(40);
            Num.Add(600);
            Num.Add(200);
            Num.Add(1000);
            Num.Add(861);
            imprime(Num);

            Console.WriteLine("El primer elemento de la lista es:");
            Console.WriteLine(Num[0]);

            //Aqui pediremos que incerte un elemento de la lista para ser encontrado si en su defecto no esta saltara el if
            Console.WriteLine("Que elemento desea buscar: ");
            string linea;
            linea = Console.ReadLine();
            int valor = int.Parse(linea);

            //Aquí mostraremos por pantalla el primer elemento de nuestra lista
            Console.WriteLine("ese elemento se encuentra en la posicion: {0}", Num.IndexOf(valor) + 1);

            //aquí declaramos como null si el elemento el cual estamos buscando es diferente al que aparece en nuestra lista
            if (Num.IndexOf(valor) > 5)
            {
                Console.WriteLine("Este valor no esta");
            }
        }
        static void imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.WriteLine(" {0},", n);
            Console.WriteLine("\n-----------");
        }
    }
}
