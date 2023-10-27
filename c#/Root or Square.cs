using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        if (double.TryParse(Console.ReadLine(), out double numero))
        {
            double resultado;

            if (numero > 0)
            {
                resultado = Math.Sqrt(numero);
            }
            else
            {
                resultado = numero * numero;
            }

            Console.WriteLine("Resultado: " + resultado);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número.");
        }
    }
}
