using System;

namespace algoritmo_3
{
    // creamos la primera clase socio en donde vamos a llenar los datos 
    class socio
    {
        // definimos nuestras dos variables 
        private string nombre;
        private int antiguedad;

        // creamos el constructor en donde ingresamos el nombre y la antiguedad en el club 
        public socio()
        {
            Console.WriteLine("Bienvenido al club por favor ingresa tu nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("ingresa tu antiguedad en años en el club");
            antiguedad = Convert.ToInt32(Console.ReadLine());
        }
        // creamos un metodo para imprimir 

        public void imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Antiguedad: " + antiguedad);

        }
        
        // creamos un metodo para retornar el valor de las antiguedades y asi saber cual es el mayor 
        public int retornar()
        {
            return antiguedad;
        }

    }
    // creamos otra clase llamada club en donde vamos a llamar 3 objetos de la clase socio ( imprimir,retornar,socio)
    class club
    {
        private socio cliente1, cliente2;
        public club()
        {
            cliente1 = new socio();
            cliente2 = new socio();
        }
       // creamos un metodo para saber cual es el cliente con mas antiguedad utilizamos el metodo retornar para saber los datos 

        public void mayor()
        {
            
            if (cliente1.retornar() > cliente2.retornar())
            {
                Console.WriteLine("el cliente mas antiguo es :");
                cliente1.imprimir();
            }
            if (cliente2.retornar() > cliente1.retornar())
            {
                Console.WriteLine("el cliente mas antiguo es :");
                cliente2.imprimir();
            }
        }
    }


    class Program

    {
        // ya en la clase principal llamamos a la clase club que contienen todos los datos correspondientes e imprimimos 
        static void Main(string[] args)
        {
            club op = new club();
            op.mayor();
            

            
        }
    }
}
