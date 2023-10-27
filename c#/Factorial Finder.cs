using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero >= 0)
            {
                int factorial = 1;

                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine("Resultado: " + factorial);
            }
            else
            {
                Console.WriteLine("El número debe ser no negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
        }
    }
}
