using System;

class ClasificaNota
{
    static void Main()
    {
        Console.Write("Ingresa la nota (0-20): ");
        int nota = int.Parse(Console.ReadLine());

        if (nota == 20)
        {
            Console.WriteLine("¡Excelente!");
        }
        else if (nota >= 11)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Desaprobado");
        }
    }
}