using System;

class Calculadora
{
    static void Main()
    {
        Console.Write("Ingresa el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("1=Suma, 2=Resta, 3=Multiplicación, 4=División");
        Console.Write("Elige una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Resultado: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("Resultado: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("Resultado: " + (num1 * num2));
                break;
            case 4:
                if (num2 == 0)
                    Console.WriteLine("Error: no se puede dividir entre 0");
                else
                    Console.WriteLine("Resultado: " + (num1 / num2));
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}