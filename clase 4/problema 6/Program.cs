using System;
using System.Reflection;

namespace problema_6
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int hm=0,mm=0,masculino=0,femenino=0,he=0,me=0,estado,salario,empleados=20,promedio=0,edad=0,acumulador=0,i=0,hg=0,mg=0;
            String sexo;
            for (i = 0; i < empleados; i++)
            {
                Console.WriteLine("elija su sexo hombre, mujer");
                sexo = Console.ReadLine();
                switch (sexo)
                {
                    case ("hombre"):

        
                            masculino++;

                    Console.WriteLine("digite su edad");

                    edad = Convert.ToInt32(Console.ReadLine());

                    acumulador = acumulador + edad;

                    
                    Console.WriteLine("elija su estado civil 1: para soltero 2: para casado 3: para viudo");

                    estado = Convert.ToInt16(Console.ReadLine());
                    
                        switch (estado)
                        {
                            case 1:
                               
                                Console.WriteLine("por favor digite su salario 1 si gana menos de 600 Bs.F. ,  2 si gana entre 600 y 1000 Bs.F., 3 si gana mas de 1000 Bs.F");

                                salario = Convert.ToInt32(Console.ReadLine());


                                
                                switch (salario)

                                {

                                    case 1:

                                        Console.WriteLine("tu salario es  de 600 Bs.F.");
                                        break;
                                    case 2:

                                        Console.WriteLine("tu salario esta  entre 600 y 1000Bs.F.");
                                        break;
                                    case 3:

                                        Console.WriteLine("tu salario es de Mas de 1000Bs");
                                        break;
                                }
                                break;
                            case 2:
                                
                                Console.WriteLine("por favor digite su salario 1 si gana menos de 600 Bs.F. ,  2 si gana entre 600 y 1000 Bs.F., 3 si gana mas de 1000 Bs.F");

                                salario = Convert.ToInt32(Console.ReadLine());
                                
                                switch (salario)
                                {
                                    case 1:
                                        Console.WriteLine("tu salario es  de 600 Bs.F.");
                                        break;
                                    case 2:
                                        Console.WriteLine("tu salario esta  entre 600 y 1000Bs.F.");
                                        break;
                                    case 3:
                                        Console.WriteLine("tu salario es de Mas de 1000Bs");
                                        break;
                                }
                                break;
                            case 3:
                                
                                Console.WriteLine("por favor digite su salario 1 si gana menos de 600 Bs.F. ,  2 si gana entre 600 y 1000 Bs.F., 3 si gana mas de 1000 Bs.F");

                                salario = Convert.ToInt32(Console.ReadLine());

                                
                                switch (salario)
                                {
                                    case 1:
                                        Console.WriteLine("tu salario es  de 600 Bs.F.");
                                        break;
                                    case 2:
                                        Console.WriteLine("tu salario esta  entre 600 y 1000Bs.F.");
                                        break;
                                    case 3:
                                        Console.WriteLine("tu salario es de Mas de 1000Bs");
                                        break;
                                }
                                break;
                        }
                        break;

                    case ("mujer"):


                        femenino++;
                        Console.WriteLine("digite su edad");

                        edad = Convert.ToInt32(Console.ReadLine());

                        acumulador = acumulador + edad;

                     
                        Console.WriteLine("elija su estado civil 1: para soltero 2: para casado 3: para viudo");

                        estado = Convert.ToInt16(Console.ReadLine());

                        switch (estado)
                        {
                            case 1:

                                Console.WriteLine("por favor digite su salario 1 si gana menos de 600 Bs.F. ,  2 si gana entre 600 y 1000 Bs.F., 3 si gana mas de 1000 Bs.F");

                                salario = Convert.ToInt32(Console.ReadLine());

                                

                                switch (salario)

                                {
                                    case 1:
                                        Console.WriteLine("tu salario es  de 600 Bs.F.");
                                        break;
                                    case 2:
                                        Console.WriteLine("tu salario esta  entre 600 y 1000Bs.F.");
                                        break;
                                    case 3:
                                        Console.WriteLine("tu salario es de Mas de 1000Bs");
                                        break;
                                }
                                break;
                            case 2:

                                Console.WriteLine("por favor digite su salario 1 si gana menos de 600 Bs.F. ,  2 si gana entre 600 y 1000 Bs.F., 3 si gana mas de 1000 Bs.F");

                                salario = Convert.ToInt32(Console.ReadLine());

                                

                                switch (salario)
                                {
                                    case 1:
                                        Console.WriteLine("tu salario es  de 600 Bs.F.");
                                        break;
                                    case 2:
                                        Console.WriteLine("tu salario esta  entre 600 y 1000Bs.F.");
                                        break;
                                    case 3:
                                        Console.WriteLine("tu salario es de Mas de 1000Bs");
                                        break;
                                }
                                break;

                            case 3:

                                Console.WriteLine("por favor digite su salario 1 si gana menos de 600 Bs.F. ,  2 si gana entre 600 y 1000 Bs.F., 3 si gana mas de 1000 Bs.F");

                                salario = Convert.ToInt32(Console.ReadLine());

                               

                                switch (salario)
                                {
                                    case 1:
                                        Console.WriteLine("tu salario es  de 600 Bs.F.");
                                        break;
                                    case 2:
                                        Console.WriteLine("tu salario esta  entre 600 y 1000Bs.F.");
                                        break;
                                    case 3:
                                        Console.WriteLine("tu salario es de Mas de 1000Bs");
                                        break;
                                }
                                break;
                        }
                        break;

                }



            }
            promedio = acumulador / masculino;

            Console.WriteLine("El total de empleados del sexo femnino son: " + femenino);
            Console.WriteLine("");
            Console.WriteLine("Total de empleados hombres casados que ganan más de 1000 Bs.F. : "+hg);
            Console.WriteLine("");
            Console.WriteLine("Total de empeleados mujeres viudas que ganan más de 600 Bs: "+me);
            Console.WriteLine("");
            Console.WriteLine("el promedio de edad de empleados hombre es de: "+promedio);







        }
    }
}
