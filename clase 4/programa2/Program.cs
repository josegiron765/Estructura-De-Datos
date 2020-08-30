using System;

namespace programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 0, contapar = 0, contaimpar = 0;
            int sumarpar = 0, sumarimpar = 0, media = 0;

            Console.WriteLine(" por favor digite 10 numeros ");
           
            for (int a = 1; a <= 10; a++)
            {
                Console.Write("digite un numero ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    contapar = contapar + 1;
                    sumarpar = sumarpar + num;
                }
                else
                {
                    contaimpar = contaimpar + 1;
                    sumarimpar = sumarimpar + num;
                }
            }

            media = sumarimpar / contaimpar;
            
            Console.WriteLine(" la cantidad de numeros pares digitas es {0} y su suma de los pares es {1}", contapar, sumarpar);
            
            Console.WriteLine(" la media aritimetica de los numeros impares es {0}", media);
        }
    }
}
    

