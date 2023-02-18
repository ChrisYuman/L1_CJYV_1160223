// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su nombre: ");
        string Nombre= Console.ReadLine();

        Console.WriteLine("Hola Mundo");
        Console.WriteLine("soy " +Nombre);

        /* La diferencia entre ambos es que el WriteLine escribe todo en distintas lineas, en cambio el Write lo escribe todo en una misma
         linea, asi como nombramos que el readline nos sirva para poner un nombre que sea, y lo contatenamos con el soy*/

        Console.Write("Hola Mundo ");
        Console.Write("soy " +Nombre);
        

        Console.WriteLine("Hola Mundo");
        Console.WriteLine("soy Christopher Javier Yuman Valdez!");

        /* La diferencia entre ambos es que el WriteLine escribe todo en distintas lineas, en cambio el Write lo escribe todo en una misma
         linea */

        Console.Write("Hola Mundo ");
        Console.Write("soy Christopher Javier Yuman Valdez!");

        Console.WriteLine("Hola mundo soy Christopher Javier Yuman Valdez!");
        Console.ReadKey();
    }
}