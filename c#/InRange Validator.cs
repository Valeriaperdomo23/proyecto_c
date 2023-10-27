using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine("Resultado: Está en el rango.");
            }
            else
            {
                Console.WriteLine("Resultado: Fuera del rango.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
        }
    }
}
