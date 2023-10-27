using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario el radio del círculo
        Console.Write("Ingrese el radio del círculo: ");
        
        // Leer el radio como una cadena de texto
        string input = Console.ReadLine();
        
        // Intentar convertir la cadena a un número decimal
        if (decimal.TryParse(input, out decimal radio))
        {
            // Calcular el perímetro del círculo
            decimal perimetro = 2 * (decimal)Math.PI * radio;
            
            // Mostrar el resultado redondeado a dos decimales
            Console.WriteLine("Resultado: " + perimetro.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número.");
        }
    }
}
