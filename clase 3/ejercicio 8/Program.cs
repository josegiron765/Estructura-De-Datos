using System;

namespace Algoritmo8
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Digite el Día: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el Mes: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el Año: ");
            C = int.Parse(Console.ReadLine());

            if (A >= 1 && A <= 30)
            {
                A = A + 1;
                Console.WriteLine("La fecha es: {0}/{1}/{2}", A, B, C);
            }
            if (A > 31)
            {
                Console.WriteLine("esta fecha no existe");
            }
            if (A == 31 && B <= 11)
            {
                A = A - 30;
                B = B + 1;

                Console.WriteLine("La fecha es: {0}/{1}/{2}", A, B, C);
            }
            if (B > 12)
            {
                Console.WriteLine("esta fecha no existe {0}", B);
            }
            if (B == 12 && A == 31)
            {
                A = A - 30;
                B = B - 11;
                C = C + 1;
                Console.WriteLine("La fecha es: {0}/{1}/{2}", A, B, C);
            }
            else
            {
                Console.WriteLine("¡gracias!");
            }
        }
    }
}