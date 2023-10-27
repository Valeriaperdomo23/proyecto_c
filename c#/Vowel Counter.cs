using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower(); // Convertir la palabra a minúsculas para considerar todas las vocales

        int contadorVocales = 0;

        foreach (char caracter in palabra)
        {
            if (EsVocal(caracter))
            {
                contadorVocales++;
            }
        }

        Console.WriteLine("Resultado: " + contadorVocales);
    }

    static bool EsVocal(char c)
    {
        return "aeiouáéíóú".Contains(c);
    }
}
