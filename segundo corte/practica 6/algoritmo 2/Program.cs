using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Diagnostics.CodeAnalysis;

//Escriba un programa que calcule la sumatoria de los cuadrados de los elementos de una
//lista/pila/cola de números enteros
namespace Ejercicios_listas_Nu2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Ele = new ArrayList();

            Console.WriteLine("La lista es: ");
            Ele.Add(100);
            Ele.Add(50);
            Ele.Add(20);
            Ele.Add(500);
            Ele.Add(30);
            Ele.Add(400);
            Ele.Add(1);
            Ele.Add(70);
            imprime(Ele);

            //Aquí mostramos por pantalla las dos Voids que creamos con los procedimientos a pedir
            Console.WriteLine("Los valores elevados al cuadrado son: ");
            Cuadrado(Ele);

            Console.WriteLine("La suma de todos los valores elevados al cuadrado es de: ");
            Sumado(Ele);
        }
        static void imprime(ArrayList arreglo)
        {
            //Aquí mostraremos por pantala la lista que ya esta predefinida
            foreach (int n in arreglo)
                Console.Write(" {0},", n);
            Console.WriteLine("\n-----------");
        }
        static void Cuadrado(ArrayList arreglo)
        {
            //Como toque extra mostraremos por pantalla las variables ejebadas al cuadrado para que el usuario tenga na idea de la suma que se va a realizar
            foreach (int n in arreglo)
                Console.Write(" {0},", n * n);
            Console.WriteLine("\n-----------");
        }
        static void Sumado(ArrayList arreglo)
        {
            int ele = 0;
            foreach (int n in arreglo)
                //Se crea un contador para poder almacenar e ir elevando las variables para así ir sumandolas
                ele = ele + (n * n);
            Console.WriteLine(" {0}", ele);
            Console.WriteLine("\n-----------");
        }
    }
}