using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la primera fracción en el formato 'a/b': ");
        string fraccion1 = Console.ReadLine();

        Console.Write("Ingrese la segunda fracción en el formato 'a/b': ");
        string fraccion2 = Console.ReadLine();

        if (TryParseFraction(fraccion1, out int num1, out int den1) && TryParseFraction(fraccion2, out int num2, out int den2))
        {
            int denominadorComun = den1 * den2;
            int resultadoNumerador = (num1 * den2) - (num2 * den1);

            Console.WriteLine("Resultado: " + resultadoNumerador + "/" + denominadorComun);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar fracciones en el formato 'a/b'.");
        }
    }

    static bool TryParseFraction(string input, out int numerador, out int denominador)
    {
        numerador = 0;
        denominador = 0;

        string[] parts = input.Split('/');

        if (parts.Length == 2 && int.TryParse(parts[0], out numerador) && int.TryParse(parts[1], out denominador) && denominador != 0)
        {
            return true;
        }

        return false;
    }
}
