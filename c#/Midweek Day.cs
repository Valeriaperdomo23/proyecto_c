using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número del 1 al 7: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            string diaLaborable;

            switch (numero)
            {
                case 1:
                    diaLaborable = "Lunes";
                    break;
                case 2:
                    diaLaborable = "Martes";
                    break;
                case 3:
                    diaLaborable = "Miércoles";
                    break;
                case 4:
                    diaLaborable = "Jueves";
                    break;
                case 5:
                    diaLaborable = "Viernes";
                    break;
                default:
                    diaLaborable = "Número fuera del rango laboral.";
                    break;
            }

            Console.WriteLine("Resultado: " + diaLaborable);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número del 1 al 7.");
        }
    }
}
