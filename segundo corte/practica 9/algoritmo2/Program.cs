using System;

namespace algoritmo2
{
    class operaciones
    {
        // como nos pide el problema debemos trabjar en la clase operaciones la definimos y a su vez creamos las variables privadas a y b
        // en donde iran los numeros que posteriormente vamosa  agregar 
        private int a;
        private int b;
        

        public operaciones(int m, int n)
        {
            // creamos el constructor en donde igualamos a y b a m y n 
            a = m;
            b = n;
        }
        // creamos un metodo para sumar en donde utilizamos return para volver a los valores a y b 
        public int suma()
        {
            return a + b;
        }
        // creamos otro metodo parecido en donde volvemos a utilizar el metodo return 
        public int resta()
        {
            return a - b;
        }
        // asi mismo creamos dos metodos para multiplicacion y division 
        public int multiplicacion()
        {
            return a * b;
        }
        public int division()
        {
            return a / b;
        }
        // luego volvemos a nuestra clase principal  y en el cuerpo principal llamamos nuestros metodos anteriores 
        class program
        {
            static void Main(string[] args)
            {
                // imprimimos los resultados de los metodoos a su vez de definir los dos numeros a y b en este caso 20 y 5 
                operaciones op = new operaciones(20,5);
                Console.WriteLine("la suma entre  20 +  5 es : "+op.suma());
                Console.WriteLine("la resta entre 20 - 5 es : " + op.resta());
                Console.WriteLine("la  multiplicacion entre 20 * 5 es : " + op.multiplicacion());
                Console.WriteLine("la division entre 20 / 5  es : " + op.division());

                Console.ReadKey();
            }
        }
       
    }
}
