using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        if (double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.Write("Ingrese el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out double numero2))
            {
                Console.Write("Ingrese el tercer número: ");
                if (double.TryParse(Console.ReadLine(), out double numero3))
                {
                    Console.Write("Ingrese el cuarto número: ");
                    if (double.TryParse(Console.ReadLine(), out double numero4))
                    {
                        double promedio = (numero1 + numero2 + numero3 + numero4) / 4;
                        Console.WriteLine("Resultado: " + promedio);
                    }
                    else
                    {
                        Console.WriteLine("El cuarto valor ingresado no es un número válido.");
                    }
                }
                else
                {
                    Console.WriteLine("El tercer valor ingresado no es un número válido.");
                }
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
