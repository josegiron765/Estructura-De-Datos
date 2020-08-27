using System;

namespace ejercicio30

{
    class ejercicio30
    {
        static void ejercicioMain(string[] args)
        {
            float A = 0;
            int B = 0, C = 0;
            double M = 0, H = 0, TM = 0, TH = 0, prom = 0, edad = 0, edadP = 0;
            string D = "";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}º trabajador", i + 1);
                Console.Write("1 = Mujeres / 2 = Hombres:  ");
                D = Console.ReadLine();
                B = Convert.ToInt32(D);

                Console.Write("Estado civil: 1 = soltero(a) / 2=casado(a) / 3=viudo(a) ");
                D = Console.ReadLine();
                C = Convert.ToInt32(D);

                Console.Write("Digite su edad");
                D = Console.ReadLine();
                edad = Convert.ToInt32(D);

                Console.Write("Digite su salario actual  ");
                D = Console.ReadLine();
                A = Convert.ToSingle(D);
                Console.WriteLine("");


                if (B == 1)
                {
                    M = M + B;
                }
                if (B == 2)
                {
                    H = H + B;
                    edadP = edadP + edad;
                    prom = edadP / H;
                    Console.WriteLine("promedio de edad con hombres: {0} ", prom);
                }
                if (B == 1 || C == 3 || A >= 600)
                {
                    TM = TM + B;
                    Console.WriteLine("Total de mujeres viudas que ganan más de 600 Bs: {0}", TM);
                }
                if (B == 2 || C == 2 || A >= 1000)
                {
                    TH = TH + B;
                    Console.WriteLine("Total de hombres casados que ganan más de 1000 Bs: {0}", TH);
                }
            }
            Console.WriteLine("cantidad de hombres: {0} ", H);
            Console.WriteLine("promedio de edad hombres: {0} ", prom);
            Console.WriteLine("total de mujeres: {0} ", M);
        }
    }
}
