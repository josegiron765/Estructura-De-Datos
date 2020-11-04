using System;

//1.Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo. En el constructor cargar los atributos y luego en otro método 
//sus datos y por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)
namespace Ejercicio_1
{
    class empleado
    {
        private string nombre;
        private int sueldo;
        //Creo la clase empleado junto con los atributos los cuales voy a usar mas adelante
        public empleado()
        {
            Console.WriteLine("Dame tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
            //Declaramos los atributos para poder llenarlos y asi pedir por consola los datos que nos pide en ejercicio
        }
        public void imprimir()
        {
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su sueldo es de: " + sueldo);
            //Ceamos un constructor para cargar los datos optenidos
        }
        public void sueldoM()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Lo lamento debes pagar impuestos :(");
            }
            else
            {
                Console.WriteLine("Felicidades no tienes que pagar impuestos :)");
            }
            //Junto con otro constructor el cual nos va a decir si tenemos o no que pagar impuestos
        }
        static void Main(string[] args)
        {
            empleado empleado1 = new empleado();
            empleado1.imprimir();
            empleado1.sueldoM();
            //Ya por ultimo imprimimos todos los tatos que tenemos junto con la variable del if para mostrarlo por consola
        }
    }
}
