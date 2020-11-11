using System;

namespace Ejercicio_1
{
    //Como ejercicio de herencia vamos a realizar una suma y resta 
    class Program
    {
        public class Operacion
        {
            protected int F1;
            protected int F2;
            protected int Rsl;
            //Primeor vamos a declarar las variables que necesitamos para la ejecucion de nuestra herencia
            public int Fa1
            {
                set
                {
                    F1 = value;
                }
                get
                {
                    return F1;
                }
            }

            public int Fa2
            {
                set
                {
                    F2 = value;
                }
                get
                {
                    return F2;
                }
            }
            //Declaramos los primeros valores los cuales van a recibir la informacion que le vamos a ingresar y nos la van a devolver con el return 
            public int R
            {
                protected set
                {
                    Rsl = value;
                }
                get
                {
                    return Rsl;
                }
            }
            //aqui mostraremos los resultados, igual que en el aterior le damos la orden que nos muestre el ultimo valor guardado con el return
        }
        public class Suma : Operacion
        {
            public void Operar()
            {
                R = Fa1 + Fa2;
            }
        }
        public class Resta : Operacion
        {
            public void Operar()
            {
                R = Fa1 - Fa2;
            }
        }
        //para que sea una herencia necesitaremos mas de un class y en ellos les daremos las diferentes ordenes con las cuales queremos ejecutar el codigo
        //estors los entrelasamos con el class principal que tenemos, para asi poder usar los valores asignasdon en el
        class Prueba
        {
            static void Main(string[] args)
            {
                Suma S = new Suma();
                S.Fa1 = 520;
                S.Fa2 = 680;
                S.Operar();
                Console.WriteLine("La suma de " + S.Fa1 + " + " + S.Fa2 + " = " + S.R);
                Resta Rs = new Resta();
                Rs.Fa1 = 1349;
                Rs.Fa2 = 253;
                Rs.Operar();
                Console.WriteLine("La resta de " + Rs.Fa1 + " - " + Rs.Fa2 + " = " + Rs.R);
                Console.ReadKey();
            }
        }
        //Por ultimo en eeste lamaremos a las clases que nos interesan las cuales van a ser las que realizen la suma y resta de nuestro algoridmo
        //ya que todas las clases estan conectadas poderemos llamar a los valores que usamos dentro de ella para poder usarlo como se muestra anteriormente
        //ingrecamos todo en el void principal para mostrar por pantalla el ejercicio y comprobando que la herencia este bien hecha
    }
}