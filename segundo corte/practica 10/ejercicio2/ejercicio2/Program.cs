using System;
// como ejercicio de herencia vamos a relaizar la impresion de dos frases 
// Primero creamos una clase A junto con las variables que nesecitamos la la ejecucion de la herencia 
public class A
{
    private string f1 =" ..Aquellos que no son capacez de reconocerce a si mismos estan destinados a fracasar.. ";
    private string f2 = "..Perdon por el retraso me perdi por el sendero de la vida.. ";
    // Definimos otra clase y devolvemos con el metodo return la informacion ya suministrada
    public class B : A
    {
        public string f()
        {
            return this.f1;
        }
    }
    // asi mismo creamos otra clase para la otra frase devolviendola igualmente con el metodo return

    public class C : A
    {
        public string fr2()
        {
            return this.f2;
        }
    }


}


// para que sea una herencia nesecitamos mas una clase como las que ya tenemos y las unimos todas en nuestra clase principal en donde imprimimos las dos frases 
public class Example
{
    public static void Main(string[] args)
    {
        var b = new A.B();
        var c = new A.C();
        Console.WriteLine(" FRASE NUMERO 1 :");
        Console.WriteLine(b.f());
        Console.WriteLine(" FRASE NUMERO 2 :");
        Console.WriteLine(c.fr2());
        Console.ReadKey();
    }
}
