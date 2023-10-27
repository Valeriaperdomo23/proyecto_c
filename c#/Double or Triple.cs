using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        if (int.TryParse(Console.ReadLine(), out int numero1))
        {
            Console.Write("Ingrese el segundo número: ");
            if (int.TryParse(Console.ReadLine(), out int numero2))
            {
                int resultado;

                if (numero1 > numero2)
                {
                    resultado = numero1 * 2;
                }
                else
                {
                    resultado = numero2 * 3;
                }

                Console.WriteLine("Resultado: " + resultado);
            }
            else
            {
                Console.WriteLine("El segundo valor ingresado no es un número válido.");
            }
        }
        else
        {
            Console.WriteLine("El primer valor ingresado no es un número válido.");
        }
    }
}
