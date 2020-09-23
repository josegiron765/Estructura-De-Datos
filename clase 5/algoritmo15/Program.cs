using System;
using System.Runtime.CompilerServices;
using System.Threading;

//Escribe un programa que permita registrar la cantidad de votos de una elección presidencial
//ficticia desarrollada en El Salvador, en la que participan 4 partidos políticos. El conteo de
//votos debe limitarse a solamente los 9 municipios que conforman el departamento de
//Cabañas. Finalmente, muestre a la autoridad electoral los siguientes resultados específicos:
//a.Cantidad acumulada de votos que obtuvo cada partido entre los siguientes
//municipios: Sensuntepeque(su cabecera municipal), Cinquera y San Isidro.
//b. Cantidad y porcentaje de votos que obtuvo cada partido en todo el departamento
//de Cabañas.
//c. Determine el partido que gano en todo el departamento; o sino, debe indicar que
//hubo un empate y aclarar entre cuales de los partidos políticos se genero.
//d. Recordar que un empate electoral puede darse entre 2 o mas partidos del proceso
//electoral.
namespace Ejercicio_15
{
    class Program
    {
        private static int Vot;

        static void Main(string[] args)
        {
            //aqui le mostramos al usuario cuales son los 9 municipios y creamos la matris con sus respectivas medidas
            Console.WriteLine("Eleccion presidencial del salvador");
            int[,] ele = new int[9, 4];

            Console.WriteLine("1. unicipio de Sensuntepeque");
            Console.WriteLine("2. Municipio de Cinquera");
            Console.WriteLine("3. Municipio de Dolores");
            Console.WriteLine("4. Municipio de Guacotecti");
            Console.WriteLine("5. Municipio de Ilobasco");
            Console.WriteLine("6. Municipio de Jutiapa");
            Console.WriteLine("7. Municipio de San Isidro");
            Console.WriteLine("8. Municipio de Tejutepeque");
            Console.WriteLine("9. Municipio de Victoria");
            Console.WriteLine();

            string linea;
            for (int f = 0; f < ele.GetLength(0); f++)
            {
                Console.WriteLine("Municipio #" + (f + 1));
                for (int c = 0; c < ele.GetLength(1); c++)
                {
                    Console.Write("Cantidad de Votos del partido politico # [" + (c + 1) + "]: ");
                    linea = Console.ReadLine();
                    ele[f, c] = int.Parse(linea);


                }
            }

            for (int f = 0; f < ele.GetLength(0); f++)
            {
                Console.WriteLine();
                Console.WriteLine("cantidad de votos en el municipio #" + (f + 1));
                Console.WriteLine();
                for (int c = 0; c < ele.GetLength(1); c++)
                {
                    Console.Write("Votos del partido politico #" + (c + 1) + ": " + " " + ele[f, c]);
                    Console.WriteLine();

                }
            }
            //aqui nos muestra por pantalla los valores que digito el ussuario de los votos electorales
        }
    }
}