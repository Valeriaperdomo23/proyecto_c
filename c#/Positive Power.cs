using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        
        // Leer el número ingresado como una cadena de texto
        string input = Console.ReadLine();
        
        // Intentar convertir la cadena a un número decimal
        if (decimal.TryParse(input, out decimal numero))
        {
            if (numero > 0)
            {
                // Elevar al cuadrado y mostrar el resultado
                decimal resultado = numero * numero;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (numero == 0)
            {
                Console.WriteLine("Resultado: 0");
            }
            else
            {
                Console.WriteLine("Resultado: Número negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número.");
        }
    }
}
