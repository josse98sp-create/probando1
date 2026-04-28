using System;

class CalculadoraIMC
{
    static void Main()
    {
        Console.Write("Ingresa tu peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Ingresa tu altura (m): ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine($"Tu IMC es: {imc:F2}");

        if (imc < 18.5)
            Console.WriteLine("Diagnóstico: Bajo peso");
        else if (imc < 25)
            Console.WriteLine("Diagnóstico: Peso normal");
        else if (imc < 30)
            Console.WriteLine("Diagnóstico: Sobrepeso");
        else
            Console.WriteLine("Diagnóstico: Obesidad");
    }
}