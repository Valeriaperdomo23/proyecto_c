using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();
        
        int longitud = palabra.Length;
        
        Console.WriteLine("Resultado: " + longitud);
    }
}
