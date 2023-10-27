using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su salario anual: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal salarioAnual))
        {
            decimal impuesto = 0;

            if (salarioAnual > 12000)
            {
                impuesto = (salarioAnual - 12000) * 0.15m;
            }

            if (impuesto > 0)
            {
                Console.WriteLine("Resultado: " + impuesto);
            }
            else
            {
                Console.WriteLine("Resultado: No debe impuestos.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número.");
        }
    }
}
