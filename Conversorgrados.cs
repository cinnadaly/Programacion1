using System;

class Program
{
    static void Main(string[] args)
    {
        int op;
        double grados;

        Console.WriteLine("Ingresa la temperatura:");
        grados = double.Parse(Console.ReadLine());

        Console.WriteLine("===MENU===");
        Console.WriteLine("[1] F a C");
        Console.WriteLine("[2] C a F");
        Console.WriteLine("Ingrese la conversión que desea realizar:");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Fahrenheit(grados);
                break;

            case 2:
                Celsius(grados);
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }

    static void Celsius(double grados)
    {
        double resultado = (grados - 32) / 1.8;
        Console.WriteLine($"La conversión de Fahrenheit a Celsius es: {resultado}");
    }

    static void Fahrenheit(double grados)
    {
        double resultado = (grados * 1.8) + 32;
        Console.WriteLine($"La conversión de Celsius a Fahrenheit es: {resultado}");
    }
}


