using System;
using System.Reflection.PortableExecutable;

namespace problema_7
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
            
        {
            string respuesta;
            do
            {
                Console.WriteLine("Hello World!");
                int alumnos = 0, peso = 0, albajo = 0, almedio = 0, alalto = 0, alsobre = 0, i;
                Console.WriteLine("por favor digite la cantidad de estudiantes ");
                entrada = Console.ReadLine();
                alumnos = Convert.ToInt32(entrada);
                for (i = 0; i < alumnos; i++)
                {
                    Console.WriteLine("por favor digita tu peso 1: si pesas menos de 40 KG, 2:si pesas entre 40KG y 50KG, 3:si pesas entre 50KG y 60KG,4:si pesas igual o mas a 60KG ");
                    entrada = Console.ReadLine();
                    peso = Convert.ToInt32(entrada);

                    switch (peso)
                    {
                        case 1:
                            Console.WriteLine(" eligiste la opcion 1");
                            albajo++;
                            break;
                        case 2:
                            Console.WriteLine("eligiste la opcion 2");
                            almedio++;
                            break;
                        case 3:
                            Console.WriteLine("eligiste la opcion 3");
                            alalto++;
                            break;
                        case 4:
                            Console.WriteLine("eligiste la opcion 4");
                            alsobre++;
                            break;
                    }
                }
                Console.WriteLine("la cantidad de alumnos que pesan menos de 40kg son = "+ albajo);
                Console.WriteLine("la cantidad de alumnos que pesan entre 40 y 50kg son = "+ almedio);
                Console.WriteLine("la cantidad de alumnos que pesan mas de 50 y menos de 60kg son = "+alalto);
                Console.WriteLine("la cantidad de alumnos que pesan mas o igual a 60kg son = "+ alsobre);


                Console.WriteLine("deseas continual ejecutando la aplicacion si , no");
                respuesta = Console.ReadLine();


            } while (respuesta == "si");
           


        }
    }
}
