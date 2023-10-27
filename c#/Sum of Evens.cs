using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        for (int i = 2; i <= 50; i += 2)
        {
            suma += i;
        }

        Console.WriteLine("Resultado: " + suma);
    }
}
