using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese cinco números:");

        double minimo = double.MaxValue;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                if (numero < minimo)
                {
                    minimo = numero;
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un número válido. Intente de nuevo.");
                i--;
            }
        }

        Console.WriteLine("Resultado: " + minimo);
    }
}
