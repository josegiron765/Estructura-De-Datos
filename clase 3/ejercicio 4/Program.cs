using System;

namespace ejercicio_4
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            int n, m,sb=0,r,r2;
            Console.WriteLine("Hello World!");
            Console.WriteLine("por favor digite la cantidad de empleados con el mismo salario base");
            entrada = Console.ReadLine();
            n = Convert.ToInt32(entrada);
            Console.WriteLine("por favor digite el salario base");
            entrada = Console.ReadLine();
            sb= Convert.ToInt32(entrada);
            for (int i = 1; i <= n; i = i + 1)
            {
                if (sb<= 1500)
                {
                    Console.WriteLine("no hay retencion");
                    Console.WriteLine("el salario neto es de {0} ", sb);

                }
                if(sb>1500 && sb < 3000)
                {
                    r = (int)(sb * 0.5);
                    Console.WriteLine("hay una retencion del 5% ");
                    Console.WriteLine("el salario neto es de {0} ", r);

                }
                if (sb >= 3000)
                {
                    r2 = (int)(sb * 0.8);
                    Console.WriteLine("hay una retencion del 8% ");
                    Console.WriteLine("el salario neto es de {0} ", r2);

                }

            }
        }
    }
}
