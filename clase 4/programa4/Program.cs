using System;

namespace programa4
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            int alum = 0,i,notas =0,n,acumulador=0,nt=0,media=0;
            Console.WriteLine("Hello World!");
            Console.WriteLine("por favro digite la cantidad de alunmos");
            entrada = Console.ReadLine();
            alum = Convert.ToInt32(entrada);
            for (i = 0; i < alum; i++)
            {
                Console.WriteLine("por favor digite la cantidad de notas que quiere analizar del estudiante");
                entrada = Console.ReadLine();
                notas = Convert.ToInt32(entrada);
                for (n = 0; n < notas; n++)
                {
                    Console.WriteLine("digita nota");
                    entrada = Console.ReadLine();
                    nt = Convert.ToInt32(entrada);
                    
                }
            }
            acumulador = nt + nt;

            media = acumulador / alum;
            Console.WriteLine("la media es de : {0}", media);
        }
    }
}
